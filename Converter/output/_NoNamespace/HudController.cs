// ============================================================
// Type  : HudController
// Token : 0x20002DC
// ============================================================

public class HudController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016FD
    public GameObject heroFace;

    // Token: 0x40016FE
    public Text timeLabel;

    // Token: 0x40016FF
    public Image timeCircle;

    // Token: 0x4001700
    public Text nameLabel;

    // Token: 0x4001701
    public Text fightScoreLabel;

    // Token: 0x4001702
    public Image weatherIcon;

    // Token: 0x4001703
    public Image seasonIcon;

    // Token: 0x4001704
    public Text fameLabel;

    // Token: 0x4001705
    public Text badfameLabel;

    // Token: 0x4001706
    public GameObject badfameIcon;

    // Token: 0x4001707
    public RectTransform moneyLayout;

    // Token: 0x4001708
    public Text moneyLabel;

    // Token: 0x4001709
    public Text forceLabel;

    // Token: 0x400170A
    public GameObject nowResearch;

    // Token: 0x400170B
    public Text contributionLabel;

    // Token: 0x400170C
    public Text heroNumLabel;

    // Token: 0x400170D
    public Text areaNumLabel;

    // Token: 0x400170E
    public GameObject forceUI;

    // Token: 0x400170F
    public GameObject infoList;

    // Token: 0x4001710
    public GameObject settingButton;

    // Token: 0x4001711
    public GameObject externalInjury;

    // Token: 0x4001712
    public GameObject internalInjury;

    // Token: 0x4001713
    public GameObject poisonInjury;

    // Token: 0x4001714
    public GameObject quickMap;

    // Token: 0x4001715
    public GameObject forceDetail;

    // Token: 0x4001716
    public GameObject heroSearch;

    // Token: 0x4001717
    private List<HudResourceShowData> hudResourceShowDatas;

    // Token: 0x4001718
    public bool inited;

    // Token: 0x4001719
    private float refreshTime;

    // Token: 0x400171A
    private static HudController _instance;

    // Token: 0x400171B
    public bool needRefreshPlayerSkeleton;

    // Token: 0x400171C
    private bool showInfoList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017F6
    // RVA   : 0xB4AEB0   Offset: 0xB496B0   Length: 0x36
    public static HudController get_Instance()
    {
        return **(uint64 **)(DAT_181d51d80 + 184);
    }

    // Token : 0x60017F7
    // RVA   : 0xB46860   Offset: 0xB45060   Length: 0xDD
    private void Awake()
    {
        long lVar2;
        ulong uVar3;
        plVar1 = *(int64 **)(DAT_181d51d80 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        if (this.forceUI != null) {
          lVar2 = GameObject.get_transform(this.forceUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"ContributionFull",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d6bc40);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0x3e99999a,0x40000000,0);
              TweenSettingsExtensions.SetLoops(uVar3,0xffffffff,1,DAT_181d97f50);
              return;
            }
          }
        }
    }

    // Token : 0x60017F8
    // RVA   : 0xB477A0   Offset: 0xB45FA0   Length: 0x210C
    private void Update()
    {
        var pStatics_0f00 = *(int64*)(DAT_181d50f00 + 184);
        var pStatics_29a0 = *(int64*)(DAT_181da29a0 + 184);
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_d1f8 = *(int64*)(DAT_181d5d1f8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ede0 = *(int64*)(DAT_181d6ede0 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        var pStatics_fc60 = *(int64*)(DAT_181d8fc60 + 184);
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
          if (this.heroFace == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(this.heroFace,DAT_181da11b0);
          if (((*pStatics_df90 == 0) ||
              (lVar14 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (uVar4 = WorldData.Player(lVar14,0), lVar3 == null)) throw; // [null/range check failed]
          lVar3.Count = uVar4;
          HudController.RefreshHeroSkeleton(this,0);
        }
        lVar3 = this.timeCircle;
        if (((*pStatics_df90 == 0) ||
            (lVar14 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar3 == null)) throw; // [null/range check failed]
        Image.set_fillAmount(lVar3,*(float *)(lVar14 + 180) / 24.0,0);
        cVar1 = GlobalData.GetKeyDown(113);
        if (!cVar1) {
          cVar1 = GlobalData.GetKeyDown(105);
          if (!cVar1) {
            cVar1 = GlobalData.GetKeyDown(111);
            if (!cVar1) {
              cVar1 = GlobalData.GetKeyDown(112);
              if (cVar1) {
                if (this.heroSearch == null) throw; // [null/range check failed]
                cVar1 = GameObject.get_activeInHierarchy(this.heroSearch,0);
                if (cVar1) {
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  cVar1 = GameController.HaveSpeUI(lVar3,1,0);
                  if (!cVar1) {
                    lVar3 = FUN_18077c200(0);
                    if (lVar3 == null) throw; // [null/range check failed]
                    HeroSearchController.OpenHeroSearch(lVar3,0);
                    goto LAB_180b4828b;
                  }
                }
                lVar3 = FUN_18077c200(0);
                if ((lVar3 == null) || (lVar3.Count == null)) throw; // [null/range check failed]
                cVar1 = GameObject.get_activeSelf(lVar3.Count,0);
                if (cVar1) {
                  lVar3 = FUN_18077c200(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (((lVar3.Count == null) ||
                      (lVar14 = GameObject.get_transform(lVar3.Count,0)) == null) ||
                     (lVar14 = Transform.Find(lVar14,"BlackBackground",0)) == null) throw; // [null/range check failed]
                  uVar4 = Component.GetComponent(lVar14,DAT_181d6bc40);
                  uVar4 = DOTweenModuleUI.DOFade(uVar4,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d98958);
                  if ((lVar3.Count == null) ||
                     (lVar14 = GameObject.get_transform(lVar3.Count,0)) == null)
                  throw; // [null/range check failed]
                  uVar4 = Transform.Find(lVar14,"HeroSearchRoot",0);
                  uVar4 = ShortcutExtensions.DOScaleX(uVar4,0,0x3e4ccccd,0);
                  uVar4 = TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d98af0);
                  uVar7 = new OnTooltipCB(lVar3,DAT_181d50490,0);
                  TweenSettingsExtensions.OnComplete(uVar4,uVar7,DAT_181d96ee8);
                }
              }
            }
            else {
              if (this.forceDetail == null) throw; // [null/range check failed]
              cVar1 = GameObject.get_activeInHierarchy(this.forceDetail,0);
              if (cVar1) {
                lVar3 = FUN_18046c0a0(0);
                if (lVar3 == null) throw; // [null/range check failed]
                cVar1 = GameController.HaveSpeUI(lVar3,1,0);
                if (!cVar1) {
                  lVar3 = FUN_18077c180(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  ForceDetailController.OpenForceDetail(lVar3,0);
                  goto LAB_180b4828b;
                }
              }
              if ((*pStatics_29a0 == 0) ||
                 (lVar3 = *(int64 *)(*pStatics_29a0 + 24)) == null)
              throw; // [null/range check failed]
              cVar1 = GameObject.get_activeSelf(lVar3,0);
              if (cVar1) {
                lVar3 = FUN_18077c180(0);
                if (lVar3 == null) throw; // [null/range check failed]
                ForceDetailController.HideForceDetail(lVar3,0);
              }
            }
          }
          else {
            if (this.quickMap == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeInHierarchy(this.quickMap,0);
            if (cVar1) {
              lVar3 = FUN_18046c0a0(0);
              if (lVar3 == null) throw; // [null/range check failed]
              cVar1 = GameController.HaveSpeUI(lVar3,1,0);
              if (!cVar1) {
                lVar3 = FUN_18046c500(0);
                if (lVar3 == null) throw; // [null/range check failed]
                QuickTravelUIController.ShowQuickTravelUIShowType(lVar3,0);
                goto LAB_180b4828b;
              }
            }
            if ((*pStatics_ede0 == 0) ||
               (lVar3 = *(int64 *)(*pStatics_ede0 + 32)) == null)
            throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (cVar1) {
              if (*pStatics_ede0 == 0) throw; // [null/range check failed]
              QuickTravelUIController.HideQuickTravelUI(*pStatics_ede0,0);
            }
          }
        }
        else {
          if (this.heroFace == null) throw; // [null/range check failed]
          cVar1 = GameObject.get_activeInHierarchy(this.heroFace,0);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 == null) throw; // [null/range check failed]
            cVar1 = GameController.HaveSpeUI(lVar3,1,0);
            if (!cVar1) {
              if ((this.heroFace == null) ||
                 (lVar3 = GameObject.GetComponent(this.heroFace,DAT_181da11b0),
                 lVar3 == null)) throw; // [null/range check failed]
              ShowHeroDetail.OnClick(lVar3,0);
              goto LAB_180b4828b;
            }
          }
          if ((*pStatics_0f00 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_0f00 + 32)) == null)
          throw; // [null/range check failed]
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d88158 + 184) + 8);
            if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 40)) == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (!cVar1) {
              if ((*pStatics_d1f8 == 0) ||
                 (lVar3 = *(int64 *)(*pStatics_d1f8 + 24)) == null)
              throw; // [null/range check failed]
              cVar1 = GameObject.get_activeSelf(lVar3,0);
              if (!cVar1) {
                lVar3 = FUN_18077c1c0(0);
                if (lVar3 == null) throw; // [null/range check failed]
                HeroDetailController.UnshowHeroDetail(lVar3,0);
              }
            }
          }
        }
        LAB_180b4828b:
        fVar16 = this.refreshTime;
        fVar15 = (float)RealTime.get_deltaTime(0);
        lVar3 = this.hudResourceShowDatas;
        fVar16 = fVar16 - fVar15;
        this.refreshTime = fVar16;
        if (lVar3 != null) {
          if (lVar3.Count < 1) {
        LAB_180b48527:
            if (0.0 < fVar16) {
              return;
            }
            uVar4 = this.timeLabel;
            this.refreshTime = 0x3e99999a;
            if (((*pStatics_df90 != 0) &&
                (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar3 = *(int64 *)(lVar3 + 168)) != null) {
              uVar7 = Int32.ToString(lVar3 + 16,0);
              if (((*pStatics_df90 != 0) &&
                  (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                 (lVar3 = *(int64 *)(lVar3 + 168)) != null) {
                uVar9 = Int32.ToString(lVar3 + 20,0);
                if (((*pStatics_df90 != 0) &&
                    (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                   (lVar3 = *(int64 *)(lVar3 + 168)) != null) {
                  uVar10 = Int32.ToString(lVar3 + 24,0);
                  uVar7 = String.Format("{0}年{1}月{2}日",uVar7,uVar9,uVar10,0);
                  LTLocalization.SetText(uVar4,uVar7,0);
                  lVar3 = this.weatherIcon;
                  lVar14 = *pStatics_6270;
                  if (*pStatics_fc60 != 0) {
                    lVar5 = *(int64 *)(*pStatics_fc60 + 32);
                    if (((*pStatics_df90 != 0) &&
                        (lVar6 = *(int64 *)(*pStatics_df90 + 32)) != null)
                       && (lVar5 != null)) {
                      uVar13 = *(uint32 *)(lVar6 + 0x16c);
                      if (*(uint32 *)(lVar5 + 24) <= uVar13) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)
                               (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar13 * 8);
                      if (((lVar5 != null) &&
                          (uVar4 = String.Concat("天气_",*(uint64 *)(lVar5 + 16),0),
                          lVar14 != null)) &&
                         (uVar4 = TextureController.LoadAtlasSprite(lVar14,"UIAtlas",uVar4,0),
                         lVar3 != null)) {
                        Image.set_sprite(lVar3,uVar4,0);
                        lVar3 = this.seasonIcon;
                        lVar14 = *pStatics_6270;
                        lVar5 = *(int64 *)(pStatics_ef00 + 0x3c8);
                        if ((((*pStatics_df90 != 0) &&
                             (lVar6 = *(int64 *)(*pStatics_df90 + 32),
                             lVar6 != null)) && (lVar6 = *(int64 *)(lVar6 + 168)) != null) &&
                           (iVar2 = Mathf.CeilToInt((float)*(int *)(lVar6 + 20) / 3.0,0), lVar5 != null))
                        {
                          if (*(uint32 *)(lVar5 + 24) <= iVar2 - 1U) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          uVar4 = String.Concat("季节_",
                                                 *(uint64 *)
                                                  (*(int64 *)(lVar5 + 16) + 32 +
                                                  (int64)(int)(iVar2 - 1U) * 8),0);
                          if ((lVar14 != null) &&
                             (uVar4 = TextureController.LoadAtlasSprite(lVar14,"UIAtlas",uVar4,0),
                             lVar3 != null)) {
                            Image.set_sprite(lVar3,uVar4,0);
                            uVar4 = this.nameLabel;
                            if (((*pStatics_df90 != 0) &&
                                (lVar3 = *(int64 *)(*pStatics_df90 + 32),
                                lVar3 != null)) && (lVar3 = WorldData.Player(lVar3,0)) != null) {
                              LTLocalization.SetText(uVar4,*(uint64 *)(lVar3 + 104),0);
                              uVar4 = this.fightScoreLabel;
                              if (((*pStatics_df90 != 0) &&
                                  (lVar3 = *(int64 *)(*pStatics_df90 + 32),
                                  lVar3 != null)) && (lVar3 = WorldData.Player(lVar3,0)) != null) {
                                uVar7 = Single.ToString(lVar3 + 0x38c,"f0",0);
                                LTLocalization.SetText(uVar4,uVar7,0);
                                uVar4 = this.fameLabel;
                                if (((*pStatics_df90 != 0) &&
                                    (lVar3 = *(int64 *)(*pStatics_df90 + 32),
                                    lVar3 != null)) && (lVar3 = WorldData.Player(lVar3,0)) != null) {
                                  uVar7 = Single.ToString(lVar3 + 0x1c4,"f0",0);
                                  LTLocalization.SetText(uVar4,uVar7,0);
                                  uVar4 = this.badfameLabel;
                                  if (((*pStatics_df90 != 0) &&
                                      (lVar3 = *(int64 *)(*pStatics_df90 + 32)
                                      , lVar3 != null)) && (lVar3 = WorldData.Player(lVar3,0)) != null)
                                  {
                                    uVar7 = Single.ToString(lVar3 + 0x1c8,"f0",0);
                                    LTLocalization.SetText(uVar4,uVar7,0);
                                    plVar11 = this.badfameLabel;
                                    if (((*pStatics_df90 != 0) &&
                                        (lVar3 = *(int64 *)
                                                  (*pStatics_df90 + 32),
                                        lVar3 != null)) && (lVar3 = WorldData.Player(lVar3,0)) != null)
                                    {
                                      if (*(float *)(lVar3 + 0x1c8) <
                                          *(float *)(pStatics_ef00 + 300)) {
                                        if (((*pStatics_df90 == 0) ||
                                            (lVar3 = *(int64 *)
                                                      (*pStatics_df90 + 32),
                                            lVar3 == null)) ||
                                           (lVar3 = WorldData.Player(lVar3,0)) == null)
                                        throw; // [null/range check failed]
                                        if (*(float *)(lVar3 + 0x1c8) <= 0.0) {
                                          puVar8 = (uint64 *)FUN_181098a50(&local_78,0);
                                        }
                                        else {
                                          puVar8 = (uint64 *)Color.get_yellow();
                                        }
                                      }
                                      else {
                                        puVar8 = (uint64 *)Color.get_red(&local_78,0);
                                      }
                                      if (plVar11 != (int64 *)0) {
                                        local_78 = *puVar8;
                                        uStack_70 = puVar8[1];
                                        (**(code **)(*plVar11 + 0x2a8))
                                                  (plVar11,&local_78,*(uint64 *)(*plVar11 + 0x2b0));
                                        if (this.badfameIcon != null) {
                                          plVar11 = (int64 *)
                                                    GameObject.GetComponent
                                                              (this.badfameIcon,DAT_181d9fe50
                                                              );
                                          if (((*pStatics_df90 != 0) &&
                                              (lVar3 = *(int64 *)
                                                        (*pStatics_df90 + 32),
                                              lVar3 != null)) &&
                                             (lVar3 = WorldData.Player(lVar3,0)) != null) {
                                            if (*(int *)(lVar3 + 192) < 0) {
                                              lVar3 = FUN_18046c0a0(0);
                                              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                                                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)
                                                 , lVar3 == null)) throw; // [null/range check failed]
                                              if (*(char *)(lVar3 + 208) == false) {
                                                puVar8 = (uint64 *)FUN_181098a50(&local_78,0);
                                              }
                                              else {
                                                puVar8 = (uint64 *)Color.get_yellow();
                                              }
                                            }
                                            else {
                                              puVar8 = (uint64 *)Color.get_red(&local_78,0);
                                            }
                                            if (plVar11 != (int64 *)0) {
                                              local_78 = *puVar8;
                                              uStack_70 = puVar8[1];
                                              (**(code **)(*plVar11 + 0x2a8))
                                                        (plVar11,&local_78,
                                                         *(uint64 *)(*plVar11 + 0x2b0));
                                              if (this.badfameIcon != null) {
                                                lVar3 = GameObject.GetComponent
                                                                  (this.badfameIcon,
                                                                   DAT_181da12b0);
                                                if (((*pStatics_df90 != 0) &&
                                                    (lVar14 = *(int64 *)
                                                               (*pStatics_df90 +
                                                               32), lVar14 != null)) &&
                                                   (lVar14 = WorldData.Player(lVar14,0)) != null) {
                                                  uVar4 = "恶名\n城镇内x200%";
                                                  if (*(int *)(lVar14 + 192) < 0) {
                                                    lVar14 = FUN_18046c0a0(0);
                                                    if (((lVar14 == null) ||
                                                        (*(int64 *)(lVar14 + 32) == 0)) ||
                                                       (lVar14 = WorldData.Player(*(int64 *)
                                                                                    (lVar14 + 32),0),
                                                       lVar14 == null)) throw; // [null/range check failed]
                                                    uVar4 = "恶名\n野外x100%";
                                                    if (*(char *)(lVar14 + 208) != false) {
                                                      uVar4 = "恶名\n安全区内x150%";
                                                    }
                                                  }
                                                  if (lVar3 != null) {
                                                    lVar3.Count = uVar4;
                                                    uVar4 = this.moneyLabel;
                                                    if ((((*pStatics_df90 != 0) &&
                                                         (lVar3 = *(int64 *)
                                                                   (*pStatics_df90
                                                                   + 32), lVar3 != null)) &&
                                                        (lVar3 = WorldData.Player(lVar3,0)) != null)
                                                       && (*(int64 *)(lVar3 + 0x220) != 0)) {
                                                      uVar7 = Int32.ToString(*(int64 *)(lVar3 + 0x220)
                                                                              + 24,0);
                                                      LTLocalization.SetText(uVar4,uVar7,0);
                                                      uVar4 = this.moneyLayout;
                                                      LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                (uVar4,0);
                                                      uVar4 = this.forceLabel;
                                                      if (((*pStatics_df90 != 0) &&
                                                          (lVar3 = *(int64 *)
                                                                    (*pStatics_df90
                                                                    + 32), lVar3 != null)) &&
                                                         (lVar3 = WorldData.Player(lVar3,0)) != null)
                                                      {
                                                        uVar7 = HeroData.GetHeroForceLvDescribe
                                                                          (lVar3,1,0);
                                                        LTLocalization.SetText(uVar4,uVar7,0);
                                                        if (((*pStatics_df90 != 0)
                                                            && (lVar3 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181d4df90 + 184) + 32)
                                                               , lVar3 != null)) &&
                                                           (lVar3 = WorldData.Player(lVar3,0), lVar3 != null
                                                           )) {
                                                          if (*(int *)(lVar3 + 132) < 0) {
                                                            lVar3 = FUN_18046c0a0(0);
                                                            if (((lVar3 == null) ||
                                                                (*(int64 *)(lVar3 + 32) == 0)) ||
                                                               (lVar3 = WorldData.Player(*(int64 *)
                                                                                           (lVar3 + 32),
                                                                                          0), lVar3 == null))
                                                            throw; // [null/range check failed]
                                                            lVar14 = this.forceLabel;
                                                            if (*(int *)(lVar3 + 0x380) < 0) {
                                                              if (lVar14 == null) {
        LAB_180b4ad95:
                          // WARNING: Subroutine does not return
                                                                FUN_1800d6620();
                                                              }
                                                              lVar3 = Component.GetComponent
                                                                                (lVar14,DAT_181d6ccc0);
                                                              if (((*(byte *)(DAT_181d4df90 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181d4df90 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              lVar14 = FUN_18046c0a0(0);
                                                              if (((lVar14 == null) ||
                                                                  (*(int64 *)(lVar14 + 32) == 0)) ||
                                                                 (lVar14 = WorldData.Player(*(int64 *)
                                                                                              (lVar14 + 
                                                        32),0), lVar14 == null)) goto LAB_180b4ad95;
                                                        local_b8 = (float)
                                                        HeroData.OutsideForceExtraContributionRate
                                                                  (lVar14,0xffffffff);
                                                        local_b8 = local_b8 * 100.0;
                                                        uVar4 = il2cpp_value_box(DAT_181d7d0b8,&local_b8);
                                                        uVar4 = String.Format("官府/所有门派功绩+{0}%",uVar4,0);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (((lVar14 == null) ||
                                                            (*(int64 *)(lVar14 + 32) == 0)) ||
                                                           (lVar14 = WorldData.Player(*(int64 *)
                                                                                        (lVar14 + 32),0)
                                                           , lVar14 == null)) goto LAB_180b4ad95;
                                                        uVar7 = "\n<i><color=#696969>江湖地位由声望直接决定\n达到下一级别需声望{0}</color></i>";
                                                        if (4 < *(int *)(lVar14 + 184)) {
                                                          uVar7 = "";
                                                        }
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (((lVar14 == null) ||
                                                            (*(int64 *)(lVar14 + 32) == 0)) ||
                                                           (lVar14 = WorldData.Player(*(int64 *)
                                                                                        (lVar14 + 32),0)
                                                           , lVar14 == null)) {
        LAB_180b4ad8f:
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        local_b4 = (float)HeroData.GetNextForceLvFame
                                                                                    (lVar14,0);
                                                        uVar9 = il2cpp_value_box(DAT_181d7d0b8,&local_b4);
                                                        uVar7 = String.Format(uVar7,uVar9,0);
                                                        uVar4 = String.Concat(uVar4,uVar7,0);
                                                        if (lVar3 == null) goto LAB_180b4ad8f;
                                                        lVar3.Count = uVar4;
                                                        }
                                                        else {
                                                          if (lVar14 == null) {
        LAB_180b4ae21:
                          // WARNING: Subroutine does not return
                                                            FUN_1800d6620();
                                                          }
                                                          lVar3 = Component.GetComponent
                                                                            (lVar14,DAT_181d6ccc0);
                                                          plVar11 = (int64 *)
                                                                    FUN_1800d60b0(DAT_181d7f180,4);
                                                          lVar14 = FUN_18046c0a0(0);
                                                          if ((lVar14 == null) ||
                                                             (*(int64 *)(lVar14 + 32) == 0))
                                                          goto LAB_180b4ae21;
                                                          lVar14 = WorldData.Player(*(int64 *)
                                                                                      (lVar14 + 32),0);
                                                          lVar5 = FUN_18046c0a0(0);
                                                          if ((lVar5 == null) ||
                                                             (((*(int64 *)(lVar5 + 32) == 0 ||
                                                               (lVar5 = WorldData.Player(*(int64 *)
                                                                                           (lVar5 + 32),
                                                                                          0), lVar5 == null))
                                                              || (lVar14 == null)))) goto LAB_180b4ae21;
                                                          local_b4 = (float)
                                                        HeroData.OutsideForceExtraContributionRate
                                                                  (lVar14,*(uint32 *)(lVar5 + 0x380),0
                                                                  );
                                                        local_b4 = local_b4 * 100.0;
                                                        lVar14 = il2cpp_value_box(DAT_181d7d0b8,&local_b4)
                                                        ;
                                                        if (plVar11 == (int64 *)0)
                                                        goto LAB_180b4ae21;
                                                        if ((lVar14 != null) &&
                                                           (lVar5 = il2cpp_internal(lVar14,*(
                                                        uint64 *)(*plVar11 + 64)), lVar5 == null)) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if ((int)plVar11[3] == 0) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar11[4] = lVar14;
                                                        il2cpp_internal(plVar11 + 4,lVar14);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (lVar14 == null) goto LAB_180b4ae21;
                                                        lVar14 = *(int64 *)(lVar14 + 32);
                                                        lVar5 = FUN_18046c0a0(0);
                                                        if (((lVar5 == null) ||
                                                            (*(int64 *)(lVar5 + 32) == 0)) ||
                                                           ((lVar5 = WorldData.Player(*(int64 *)
                                                                                        (lVar5 + 32),0),
                                                            lVar5 == null ||
                                                            ((lVar14 == null ||
                                                             (lVar14 = WorldData.GetForce(lVar14,*(
                                                        uint32 *)(lVar5 + 0x380),0), lVar14 == null))))))
                                                        goto LAB_180b4ae21;
                                                        lVar14 = *(int64 *)(lVar14 + 24);
                                                        if ((lVar14 != null) &&
                                                           (lVar5 = il2cpp_internal(lVar14,*(
                                                        uint64 *)(*plVar11 + 64)), lVar5 == null)) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar11 + 3) < 2) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar11[5] = lVar14;
                                                        il2cpp_internal(plVar11 + 5,lVar14);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (((lVar14 == null) ||
                                                            (*(int64 *)(lVar14 + 32) == 0)) ||
                                                           (lVar14 = WorldData.Player(*(int64 *)
                                                                                        (lVar14 + 32),0)
                                                           , lVar14 == null)) goto LAB_180b4ae21;
                                                        local_b8 = (float)(int)*(float *)(lVar14 + 160);
                                                        lVar14 = il2cpp_value_box(DAT_181d5b2f8,&local_b8)
                                                        ;
                                                        if ((lVar14 != null) &&
                                                           (lVar5 = il2cpp_internal(lVar14,*(
                                                        uint64 *)(*plVar11 + 64)), lVar5 == null)) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar11 + 3) < 3) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar11[6] = lVar14;
                                                        il2cpp_internal(plVar11 + 6,lVar14);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if ((lVar14 == null) ||
                                                           (*(int64 *)(lVar14 + 32) == 0))
                                                        goto LAB_180b4ae21;
                                                        local_b0 = 1 - *(int *)(*(int64 *)
                                                                                 (lVar14 + 32) + 0x150);
                                                        lVar14 = il2cpp_value_box(DAT_181d5b2f8,&local_b0)
                                                        ;
                                                        if ((lVar14 != null) &&
                                                           (lVar5 = il2cpp_internal(lVar14,*(
                                                        uint64 *)(*plVar11 + 64)), lVar5 == null)) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        if (*(uint32 *)(plVar11 + 3) < 4) {
                                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar4,0);
                                                        }
                                                        plVar11[7] = lVar14;
                                                        il2cpp_internal(plVar11 + 7,lVar14);
                                                        uVar4 = String.Format("{1}功绩+{0}%\n获得{0}%门派加成效果\n当月功绩可获月俸<b>{2}</b>\n每月刷新门派委托{3}/1次",plVar11,0);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (((lVar14 == null) ||
                                                            (*(int64 *)(lVar14 + 32) == 0)) ||
                                                           (lVar14 = WorldData.Player(*(int64 *)
                                                                                        (lVar14 + 32),0)
                                                           , lVar14 == null)) goto LAB_180b4ae21;
                                                        uVar7 = "\n<i><color=#696969>门客地位由声望直接决定\n达到下一级别需声望{0}</color></i>";
                                                        if (4 < *(int *)(lVar14 + 184)) {
                                                          uVar7 = "";
                                                        }
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (((lVar14 == null) ||
                                                            (*(int64 *)(lVar14 + 32) == 0)) ||
                                                           (lVar14 = WorldData.Player(*(int64 *)
                                                                                        (lVar14 + 32),0)
                                                           , lVar14 == null)) {
        LAB_180b4ae1b:
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6620();
                                                        }
                                                        local_ac = HeroData.GetNextForceLvFame(lVar14,0);
                                                        uVar9 = il2cpp_value_box(DAT_181d7d0b8,&local_ac);
                                                        uVar7 = String.Format(uVar7,uVar9,0);
                                                        uVar4 = String.Concat(uVar4,uVar7,0);
                                                        if (lVar3 == null) goto LAB_180b4ae1b;
                                                        lVar3.Count = uVar4;
                                                        }
                                                        }
                                                        else {
                                                          if (this.forceLabel == null)
                                                          throw; // [null/range check failed]
                                                          lVar3 = Component.GetComponent
                                                                            (this.forceLabel
                                                                             ,DAT_181d6ccc0);
                                                          lVar14 = *(int64 *)
                                                                    (pStatics_ef00 +
                                                                    0x4b8);
                                                          if (((*pStatics_df90 == 0
                                                               ) || (lVar5 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181d4df90 + 184) +
                                                                              32), lVar5 == null)) ||
                                                             (lVar5 = WorldData.Player(lVar5,0),
                                                             lVar5 == null)) throw; // [null/range check failed]
                                                          if (*(char *)(lVar5 + 180) == false) {
                                                            lVar5 = FUN_18046c0a0(0);
                                                            if (((lVar5 == null) ||
                                                                (*(int64 *)(lVar5 + 32) == 0)) ||
                                                               (lVar5 = WorldData.Player(*(int64 *)
                                                                                           (lVar5 + 32),
                                                                                          0), lVar5 == null))
                                                            throw; // [null/range check failed]
                                                            uVar13 = *(uint32 *)(lVar5 + 184);
                                                          }
                                                          else {
                                                            uVar13 = 6;
                                                          }
                                                          if (lVar14 == null) throw; // [null/range check failed]
                                                          if (*(uint32 *)(lVar14 + 24) <= uVar13) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          uVar4 = *(uint64 *)
                                                                   (*(int64 *)(lVar14 + 16) + 32 +
                                                                   (int64)(int)uVar13 * 8);
                                                          if (lVar3 == null) throw; // [null/range check failed]
                                                          lVar3.Count = uVar4;
                                                        }
                                                        il2cpp_internal(puVar8,uVar4);
                                                        HudController.RefreshNowResearch(this,0);
                                                        if ((*pStatics_df90 != 0)
                                                           && (lVar3 = *(int64 *)
                                                                        (**(int64 **)
                                                                           (DAT_181d4df90 + 184) + 32),
                                                              lVar3 != null)) {
                                                          lVar3 = WorldData.Player(lVar3,0);
                                                          uVar4 = Component.get_gameObject(this,0);
                                                          if (lVar3 != null) {
                                                            HeroData.SetHpBar(lVar3,uVar4,0);
                                                            if ((*pStatics_df90 !=
                                                                 0) && (lVar3 = *(int64 *)
                                                                                 (**(int64 **)
                                                                                    (DAT_181d4df90 + 184)
                                                                                 + 32), lVar3 != null)) {
                                                              lVar3 = WorldData.Player(lVar3,0);
                                                              uVar4 = Component.get_gameObject(this,0)
                                                              ;
                                                              if (lVar3 != null) {
                                                                HeroData.SetMpBar(lVar3,uVar4,0);
                                                                uVar4 = this.externalInjury;
                                                                if (((*(byte *)(DAT_181d4df90 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d4df90 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init(DAT_181d4df90)
                                                                  ;
                                                                }
                                                                if (((**(int64 **)
                                                                        (DAT_181d4df90 + 184) != 0) &&
                                                                    (lVar3 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181d4df90 + 184) +
                                                                              32), lVar3 != null)) &&
                                                                   (lVar3 = WorldData.Player(lVar3,0),
                                                                   lVar3 != null)) {
                                                                  HudController.FreshHudInjury
                                                                            (this,uVar4,
                                                                             *(uint32 *)
                                                                              (lVar3 + 0x1a0),0);
                                                                  uVar4 = this.internalInjury;
                                                                  if (((*(byte *)(DAT_181d4df90 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d4df90 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init
                                                                              (DAT_181d4df90);
                                                                  }
                                                                  if (((**(int64 **)
                                                                          (DAT_181d4df90 + 184) != 0) &&
                                                                      (lVar3 = *(int64 *)
                                                                                (**(int64 **)
                                                                                   (DAT_181d4df90 + 184)
                                                                                + 32), lVar3 != null)) &&
                                                                     (lVar3 = WorldData.Player(lVar3,0),
                                                                     lVar3 != null)) {
                                                                    HudController.FreshHudInjury
                                                                              (this,uVar4,
                                                                               *(uint32 *)
                                                                                (lVar3 + 0x1a4),0);
                                                                    uVar4 = *(uint64 *)(this + 200)
                                                                    ;
                                                                    if (((*(byte *)(DAT_181d4df90 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181d4df90 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init
                                                                                (DAT_181d4df90);
                                                                    }
                                                                    if (((**(int64 **)
                                                                            (DAT_181d4df90 + 184) != 0)
                                                                        && (lVar3 = *(int64 *)
                                                                                     (**(int64 **)
                                                                                        (DAT_181d4df90 +
                                                                                        184) + 32),
                                                                           lVar3 != null)) &&
                                                                       (lVar3 = WorldData.Player(lVar3,0)
                                                                       , lVar3 != null)) {
                                                                      HudController.FreshHudInjury
                                                                                (this,uVar4,
                                                                                 *(uint32 *)
                                                                                  (lVar3 + 0x1a8),0);
                                                                      if (!DAT_181e6a735) {
                                                                        il2cpp_internal(&DAT_181d4df90
                                                                                           );
                                                                        DAT_181e6a735 = true;
                                                                      }
                                                                      if (((*(byte *)(DAT_181d4df90 +
                                                                                     0x133) & 4) != 0) &&
                                                                         (*(int *)(DAT_181d4df90 + 224)
                                                                          == 0)) {
                                                                        il2cpp_runtime_class_init
                                                                                  (DAT_181d4df90);
                                                                      }
                                                                      if (((**(int64 **)
                                                                              (DAT_181d4df90 + 184) != 0)
                                                                          && (lVar3 = *(int64 *)
                                                                                       (**(int64 **)
                                                                                          (DAT_181d4df90 +
                                                                                          184) + 32),
                                                                             lVar3 != null)) &&
                                                                         (lVar3 = WorldData.Player(lVar3,
                                                        0), lVar3 != null)) {
                                                          lVar14 = this.forceUI;
                                                          if (*(int *)(lVar3 + 132) < 0) {
                                                            if (lVar14 == null) throw; // [null/range check failed]
                                                            cVar1 = GameObject.get_activeSelf(lVar14,0);
                                                            if (cVar1) {
                                                              if (this.forceUI == null)
                                                              throw; // [null/range check failed]
                                                              GameObject.SetActive
                                                                        (this.forceUI,0,0
                                                                        );
                                                            }
        LAB_180b4aba5:
                                                            lVar3 = FUN_18046c100(0);
                                                            if (lVar3 != null) {
                                                              cVar1 = GameDataController.CanSaveLoad
                                                                                (lVar3,0);
                                                              lVar3 = this.settingButton;
                                                              if (!cVar1) {
                                                                if ((((lVar3 != null) &&
                                                                     (lVar3 = GameObject.get_transform
                                                                                        (lVar3,0),
                                                                     lVar3 != null)) &&
                                                                    (lVar3 = Transform.Find(lVar3,
                                                        "Saving",0), lVar3 != null)) &&
                                                        (lVar3 = Component.get_gameObject(lVar3,0),
                                                        lVar3 != null)) {
                                                          cVar1 = GameObject.get_activeSelf(lVar3,0);
                                                          if (cVar1) {
                                                            return;
                                                          }
                                                          if (((this.settingButton != null) &&
                                                              (lVar3 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 176),0),
                                                              lVar3 != null)) &&
                                                             ((lVar3 = Transform.Find(lVar3,"Saving"
                                                                                       ,0), lVar3 != null &&
                                                              (lVar3 = Component.get_gameObject(lVar3,0),
                                                              lVar3 != null)))) {
                                                            uVar4 = 1;
                                                            goto LAB_180b4ac94;
                                                          }
                                                        }
                                                        }
                                                        else if (((lVar3 != null) &&
                                                                 (lVar3 = GameObject.get_transform
                                                                                    (lVar3,0), lVar3 != null)
                                                                 ) && ((lVar3 = Transform.Find(lVar3,
                                                        "Saving",0), lVar3 != null &&
                                                        (lVar3 = Component.get_gameObject(lVar3,0),
                                                        lVar3 != null)))) {
                                                          cVar1 = GameObject.get_activeSelf(lVar3,0);
                                                          if (!cVar1) {
                                                            return;
                                                          }
                                                          if ((((this.settingButton != null) &&
                                                               (lVar3 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 176),0),
                                                               lVar3 != null)) &&
                                                              (lVar3 = Transform.Find(lVar3,"Saving"
                                                                                       ,0), lVar3 != null))
                                                             && (lVar3 = Component.get_gameObject
                                                                                   (lVar3,0), lVar3 != null))
                                                          {
                                                            uVar4 = 0;
        LAB_180b4ac94:
                                                            GameObject.SetActive(lVar3,uVar4,0);
                                                            return;
                                                          }
                                                        }
                                                        }
        LAB_180b4ad83:
                          // WARNING: Subroutine does not return
                                                        FUN_1800d6620();
                                                        }
                                                        if (lVar14 != null) {
                                                          cVar1 = GameObject.get_activeSelf(lVar14,0);
                                                          if (!cVar1) {
                                                            if (this.forceUI == null)
                                                            throw; // [null/range check failed]
                                                            GameObject.SetActive
                                                                      (this.forceUI,1,0);
                                                          }
                                                          uVar4 = this.contributionLabel;
                                                          lVar3 = FUN_18046c0a0(0);
                                                          if (((lVar3 != null) &&
                                                              (*(int64 *)(lVar3 + 32) != 0)) &&
                                                             (lVar3 = WorldData.Player(*(int64 *)
                                                                                         (lVar3 + 32),0)
                                                             , lVar3 != null)) {
                                                            local_res8[0] = (int)*(float *)(lVar3 + 0x1c0)
                                                            ;
                                                            uVar7 = Int32.ToString(local_res8,0);
                                                            lVar3 = FUN_18046c0a0(0);
                                                            if (((lVar3 != null) &&
                                                                (*(int64 *)(lVar3 + 32) != 0)) &&
                                                               (lVar3 = WorldData.Player(*(int64 *)
                                                                                           (lVar3 + 32),
                                                                                          0), lVar3 != null))
                                                            {
                                                              local_res8[0] =

                                                        HeroData.GetUpgradeForceLvNeedContribution
                                                                  (lVar3,0x3f800000,0);
                                                        uVar9 = Int32.ToString(local_res8,0);
                                                        uVar7 = String.Concat(uVar7,"/",uVar9,0
                                                                              );
                                                        LTLocalization.SetText(uVar4,uVar7,0);
                                                        lVar3 = FUN_18046c0a0(0);
                                                        if (((lVar3 != null) &&
                                                            (*(int64 *)(lVar3 + 32) != 0)) &&
                                                           (lVar3 = WorldData.Player(*(int64 *)
                                                                                       (lVar3 + 32),0),
                                                           lVar3 != null)) {
                                                          lVar14 = this.forceUI;
                                                          if (*(char *)(lVar3 + 180) == false) {
                                                            if ((lVar14 == null) ||
                                                               (lVar3 = GameObject.get_transform
                                                                                  (lVar14,0), lVar3 == null))
                                                            throw; // [null/range check failed]
                                                            lVar3 = Transform.Find(lVar3,"ContributionBarBack",0)
                                                            ;
                                                            puVar8 = (uint64 *)
                                                                     Vector3.get_one(local_88,0);
                                                            if (lVar3 == null) throw; // [null/range check failed]
                                                            local_90 = *(uint32 *)(puVar8 + 1);
                                                            local_98 = *puVar8;
                                                            Transform.set_localScale(lVar3,&local_98,0);
                                                            if ((((this.forceUI == null) ||
                                                                 (lVar3 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 160),0),
                                                                 lVar3 == null)) ||
                                                                (lVar3 = Transform.Find(lVar3,
                                                        "ContributionBarBack",0), lVar3 == null)) ||
                                                        (lVar3 = Transform.Find(lVar3,"ContributionBar",0),
                                                        lVar3 == null)) throw; // [null/range check failed]
                                                        lVar3 = Component.GetComponent
                                                                          (lVar3,DAT_181d6bc40);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if (((lVar14 == null) ||
                                                            (*(int64 *)(lVar14 + 32) == 0)) ||
                                                           (lVar14 = WorldData.Player(*(int64 *)
                                                                                        (lVar14 + 32),0)
                                                           , lVar14 == null)) throw; // [null/range check failed]
                                                        fVar16 = *(float *)(lVar14 + 0x1c0);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if ((((lVar14 == null) ||
                                                             (*(int64 *)(lVar14 + 32) == 0)) ||
                                                            (lVar14 = WorldData.Player(*(int64 *)
                                                                                         (lVar14 + 32),0
                                                                                       ), lVar14 == null)) ||
                                                           (iVar2 = 
                                                        HeroData.GetUpgradeForceLvNeedContribution
                                                                  (lVar14,0x3f800000,0), lVar3 == null))
                                                        throw; // [null/range check failed]
                                                        Image.set_fillAmount
                                                                  (lVar3,fVar16 / (float)iVar2,0);
                                                        if ((this.forceUI == null) ||
                                                           (lVar3 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 160),0),
                                                           lVar3 == null)) throw; // [null/range check failed]
                                                        lVar3 = Transform.Find(lVar3,"ContributionFull",0);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if ((lVar14 == null) ||
                                                           ((*(int64 *)(lVar14 + 32) == 0 ||
                                                            (lVar14 = WorldData.Player(*(int64 *)
                                                                                         (lVar14 + 32),0
                                                                                       ), lVar14 == null))))
                                                        throw; // [null/range check failed]
                                                        fVar16 = *(float *)(lVar14 + 0x1c0);
                                                        lVar14 = FUN_18046c0a0(0);
                                                        if ((lVar14 == null) ||
                                                           ((*(int64 *)(lVar14 + 32) == 0 ||
                                                            (lVar14 = WorldData.Player(*(int64 *)
                                                                                         (lVar14 + 32),0
                                                                                       ), lVar14 == null))))
                                                        throw; // [null/range check failed]
                                                        iVar2 = 
                                                        HeroData.GetUpgradeForceLvNeedContribution
                                                                  (lVar14,0x3f800000,0);
                                                        if (fVar16 < (float)iVar2) {
                                                          puVar8 = (uint64 *)
                                                                   Vector3.get_zero(local_88,0);
                                                        }
                                                        else {
                                                          puVar8 = (uint64 *)Vector3.get_one();
                                                        }
                                                        uVar12 = *(uint32 *)(puVar8 + 1);
                                                        uVar4 = *puVar8;
                                                        if (lVar3 == null) throw; // [null/range check failed]
                                                        }
                                                        else {
                                                          if ((lVar14 == null) ||
                                                             (lVar3 = GameObject.get_transform(lVar14,0),
                                                             lVar3 == null)) throw; // [null/range check failed]
                                                          lVar3 = Transform.Find(lVar3,"ContributionBarBack",0);
                                                          puVar8 = (uint64 *)
                                                                   Vector3.get_zero(local_88,0);
                                                          if (lVar3 == null) throw; // [null/range check failed]
                                                          local_90 = *(uint32 *)(puVar8 + 1);
                                                          local_98 = *puVar8;
                                                          Transform.set_localScale(lVar3,&local_98,0);
                                                          if ((this.forceUI == null) ||
                                                             (lVar3 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 160),0),
                                                             lVar3 == null)) throw; // [null/range check failed]
                                                          lVar3 = Transform.Find(lVar3,"ContributionFull",0);
                                                          puVar8 = (uint64 *)
                                                                   Vector3.get_zero(local_88,0);
                                                          if (lVar3 == null) throw; // [null/range check failed]
                                                          uVar4 = *puVar8;
                                                          uVar12 = *(uint32 *)(puVar8 + 1);
                                                        }
                                                        local_98 = uVar4;
                                                        local_90 = uVar12;
                                                        Transform.set_localScale(lVar3,&local_98,0);
                                                        uVar4 = this.heroNumLabel;
                                                        lVar3 = FUN_18046c0a0(0);
                                                        if (((lVar3 != null) &&
                                                            (*(int64 *)(lVar3 + 32) != 0)) &&
                                                           (lVar3 = WorldData.GetHeroForce
                                                                              (*(int64 *)(lVar3 + 32)
                                                                               ,0,0), lVar3 != null)) {
                                                          uVar7 = Int32.ToString(lVar3 + 132,0);
                                                          lVar3 = FUN_18046c0a0(0);
                                                          if (((lVar3 != null) &&
                                                              (*(int64 *)(lVar3 + 32) != 0)) &&
                                                             (lVar3 = WorldData.GetHeroForce
                                                                                (*(int64 *)
                                                                                  (lVar3 + 32),0,0),
                                                             lVar3 != null)) {
                                                            fVar16 = (float)ForceData.GetMaxHeroNum
                                                                                      (lVar3,0);
                                                            local_res8[0] = (int)fVar16;
                                                            uVar9 = Int32.ToString(local_res8,0);
                                                            uVar7 = String.Concat(uVar7,"/",
                                                                                   uVar9,0);
                                                            LTLocalization.SetText(uVar4,uVar7,0);
                                                            uVar4 = this.areaNumLabel;
                                                            lVar3 = FUN_18046c0a0(0);
                                                            if (((lVar3 != null) &&
                                                                (*(int64 *)(lVar3 + 32) != 0)) &&
                                                               ((lVar3 = WorldData.GetHeroForce
                                                                                   (*(int64 *)
                                                                                     (lVar3 + 32),0,0),
                                                                lVar3 != null &&
                                                                (*(int64 *)(lVar3 + 96) != 0)))) {
                                                              local_res8[0] =
                                                                   *(int *)(*(int64 *)(lVar3 + 96) +
                                                                           24);
                                                              uVar7 = Int32.ToString(local_res8,0);
                                                              lVar3 = FUN_18046c0a0(0);
                                                              if (((lVar3 != null) &&
                                                                  (*(int64 *)(lVar3 + 32) != 0)) &&
                                                                 (lVar3 = WorldData.GetHeroForce
                                                                                    (*(int64 *)
                                                                                      (lVar3 + 32),0,0),
                                                                 lVar3 != null)) {
                                                                fVar16 = (float)ForceData.GetMaxAreaNum
                                                                                          (lVar3,0);
                                                                local_res8[0] = (int)fVar16;
                                                                uVar9 = Int32.ToString(local_res8,0);
                                                                uVar7 = String.Concat(uVar7,"/"
                                                                                       ,uVar9,0);
                                                                LTLocalization.SetText(uVar4,uVar7,0);
                                                                local_res18[0] = 0;
                                                                do {
                                                                  iVar2 = local_res18[0];
                                                                  if (((*(byte *)(DAT_181d4df90 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d4df90 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init
                                                                              (DAT_181d4df90);
                                                                  }
                                                                  if (((*(byte *)(DAT_181d4df90 + 0x133) &
                                                                       4) != 0) &&
                                                                     (*(int *)(DAT_181d4df90 + 224) == 0)
                                                                     ) {
                                                                    il2cpp_runtime_class_init
                                                                              (DAT_181d4df90);
                                                                  }
                                                                  if ((((**(int64 **)
                                                                           (DAT_181d4df90 + 184) == 0) ||
                                                                       (lVar3 = *(int64 *)
                                                                                 (**(int64 **)
                                                                                    (DAT_181d4df90 + 184)
                                                                                 + 32), lVar3 == null)) ||
                                                                      (lVar3 = WorldData.GetHeroForce
                                                                                         (lVar3,0,0),
                                                                      lVar3 == null)) ||
                                                                     (*(int64 *)(lVar3 + 136) == 0))
                                                                  break;
                                                                  if (*(int *)(*(int64 *)(lVar3 + 136)
                                                                              + 24) <= iVar2) {
                                                                    if (((*(byte *)(DAT_181d4df90 + 0x133)
                                                                         & 4) != 0) &&
                                                                       (*(int *)(DAT_181d4df90 + 224) ==
                                                                        0)) {
                                                                      il2cpp_runtime_class_init();
                                                                    }
                                                                    lVar3 = FUN_18046c0a0(0);
                                                                    if (((lVar3 == null) ||
                                                                        (*(int64 *)(lVar3 + 32) == 0)
                                                                        ) || (lVar3 = WorldData.Player(*(
                                                        int64 *)(lVar3 + 32),0), lVar3 == null)) break;
                                                        cVar1 = HeroData.HaveForceFunction(lVar3,6);
                                                        lVar3 = this.forceUI;
                                                        if (!cVar1) {
                                                          if ((lVar3 == null) ||
                                                             (lVar3 = GameObject.get_transform(lVar3,0),
                                                             lVar3 == null)) break;
                                                          lVar3 = Transform.Find(lVar3,"SpeResourceNum",0);
                                                          puVar8 = (uint64 *)
                                                                   Vector3.get_zero(local_88,0);
                                                          if (lVar3 == null) break;
                                                          local_90 = *(uint32 *)(puVar8 + 1);
                                                          local_98 = *puVar8;
                                                          Transform.set_localScale(lVar3,&local_98,0);
                                                        }
                                                        else {
                                                          if ((lVar3 == null) ||
                                                             (lVar3 = GameObject.get_transform(lVar3,0),
                                                             lVar3 == null)) break;
                                                          lVar3 = Transform.Find(lVar3,"SpeResourceNum",0);
                                                          puVar8 = (uint64 *)
                                                                   Vector3.get_one(local_88,0);
                                                          if (lVar3 == null) break;
                                                          local_90 = *(uint32 *)(puVar8 + 1);
                                                          local_98 = *puVar8;
                                                          Transform.set_localScale(lVar3,&local_98,0);
                                                          if (((this.forceUI == null) ||
                                                              (lVar3 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 160),0),
                                                              lVar3 == null)) ||
                                                             (lVar3 = Transform.Find(lVar3,"SpeResourceNum",
                                                                                      0), lVar3 == null))
                                                          break;
                                                          uVar4 = Component.GetComponent
                                                                            (lVar3,DAT_181d6d8c0);
                                                          lVar3 = FUN_18046c0a0(0);
                                                          if ((lVar3 == null) ||
                                                             (*(int64 *)(lVar3 + 32) == 0)) break;
                                                          uVar7 = Int32.ToString(*(int64 *)
                                                                                   (lVar3 + 32) + 0x230,
                                                                                  0);
                                                          LTLocalization.SetText(uVar4,uVar7,0);
                                                        }
                                                        goto LAB_180b4aba5;
                                                        }
                                                        if (this.forceUI == null) break;
                                                        lVar3 = GameObject.get_transform
                                                                          (this.forceUI,0
                                                                          );
                                                        uVar4 = Int32.ToString(local_res18,0);
                                                        if ((lVar3 == null) ||
                                                           (lVar3 = Transform.Find(lVar3,uVar4,0),
                                                           lVar3 == null)) break;
                                                        uVar4 = Component.GetComponent
                                                                          (lVar3,DAT_181d6d8c0);
                                                        lVar3 = FUN_18046c0a0(0);
                                                        if ((((lVar3 == null) ||
                                                             (*(int64 *)(lVar3 + 32) == 0)) ||
                                                            (lVar3 = WorldData.GetHeroForce
                                                                               (*(int64 *)
                                                                                 (lVar3 + 32),0,0),
                                                            lVar3 == null)) ||
                                                           (*(int64 *)(lVar3 + 136) == 0)) break;
                                                        fVar16 = (float)FUN_1800d6780(*(int64 *)
                                                                                       (lVar3 + 136),
                                                                                      local_res18[0],
                                                                                      DAT_181d796d8);
                                                        local_res8[0] = (int)fVar16;
                                                        uVar7 = Int32.ToString(local_res8,0);
                                                        lVar3 = FUN_18046c0a0(0);
                                                        if (((lVar3 == null) ||
                                                            (*(int64 *)(lVar3 + 32) == 0)) ||
                                                           ((lVar3 = WorldData.GetHeroForce
                                                                               (*(int64 *)
                                                                                 (lVar3 + 32),0,0),
                                                            lVar3 == null ||
                                                            (*(int64 *)(lVar3 + 144) == 0)))) break;
                                                        fVar16 = (float)FUN_1800d6780(*(int64 *)
                                                                                       (lVar3 + 144),
                                                                                      local_res18[0],
                                                                                      DAT_181d796d8);
                                                        local_res8[0] = (int)fVar16;
                                                        uVar9 = Int32.ToString(local_res8,0);
                                                        uVar7 = String.Concat(uVar7,"/",uVar9,0
                                                                              );
                                                        LTLocalization.SetText(uVar4,uVar7,0);
                                                        lVar3 = FUN_18046c0a0(0);
                                                        if (((lVar3 == null) ||
                                                            (*(int64 *)(lVar3 + 32) == 0)) ||
                                                           ((lVar3 = WorldData.GetHeroForce
                                                                               (*(int64 *)
                                                                                 (lVar3 + 32),0,0),
                                                            lVar3 == null ||
                                                            (*(int64 *)(lVar3 + 152) == 0)))) break;
                                                        fVar16 = (float)FUN_1800d6780(*(int64 *)
                                                                                       (lVar3 + 152),
                                                                                      local_res18[0]);
                                                        lVar3 = this.forceUI;
                                                        if (fVar16 == 0.0) {
                                                          if (lVar3 == null) break;
                                                          lVar3 = GameObject.get_transform(lVar3,0);
                                                          uVar4 = Int32.ToString(local_res18,0);
                                                          if (((lVar3 == null) ||
                                                              (lVar3 = Transform.Find(lVar3,uVar4),
                                                              lVar3 == null)) ||
                                                             (lVar3 = Transform.Find(lVar3,"Add")
                                                             , lVar3 == null)) break;
                                                          uVar4 = Component.GetComponent
                                                                            (lVar3,DAT_181d6d8c0);
                                                          LTLocalization.SetText(uVar4);
                                                        }
                                                        else {
                                                          if (lVar3 == null) break;
                                                          lVar3 = GameObject.get_transform(lVar3,0);
                                                          uVar4 = Int32.ToString(local_res18,0);
                                                          if (((lVar3 == null) ||
                                                              (lVar3 = Transform.Find(lVar3,uVar4,0),
                                                              lVar3 == null)) ||
                                                             (lVar3 = Transform.Find(lVar3,"Add",
                                                                                      0), lVar3 == null))
                                                          break;
                                                          uVar4 = Component.GetComponent
                                                                            (lVar3,DAT_181d6d8c0);
                                                          lVar3 = FUN_18046c0a0(0);
                                                          if (((lVar3 == null) ||
                                                              (*(int64 *)(lVar3 + 32) == 0)) ||
                                                             ((lVar3 = WorldData.GetHeroForce
                                                                                 (*(int64 *)
                                                                                   (lVar3 + 32),0,0),
                                                              lVar3 == null ||
                                                              (*(int64 *)(lVar3 + 152) == 0)))) break;
                                                          local_res20[0] =
                                                               (float)FUN_1800d6780(*(int64 *)
                                                                                     (lVar3 + 152),
                                                                                    local_res18[0],
                                                                                    DAT_181d796d8);
                                                          uVar7 = Single.ToString(local_res20,
                                                                                   "+0;-0;0",0);
                                                          LTLocalization.SetText(uVar4,uVar7,0);
                                                          if (this.forceUI == null) break;
                                                          lVar3 = GameObject.get_transform
                                                                            (this.forceUI
                                                                             ,0);
                                                          uVar4 = Int32.ToString(local_res18,0);
                                                          if (((lVar3 == null) ||
                                                              (lVar3 = Transform.Find(lVar3,uVar4,0),
                                                              lVar3 == null)) ||
                                                             (lVar3 = Transform.Find(lVar3,"Add",
                                                                                      0), lVar3 == null))
                                                          break;
                                                          plVar11 = (int64 *)
                                                                    Component.GetComponent
                                                                              (lVar3,DAT_181d6d8c0);
                                                          lVar3 = FUN_18046c0a0(0);
                                                          if (((lVar3 == null) ||
                                                              (*(int64 *)(lVar3 + 32) == 0)) ||
                                                             ((lVar3 = WorldData.GetHeroForce
                                                                                 (*(int64 *)
                                                                                   (lVar3 + 32),0,0),
                                                              lVar3 == null ||
                                                              (*(int64 *)(lVar3 + 152) == 0)))) break;
                                                          fVar16 = (float)FUN_1800d6780(*(int64 *)
                                                                                         (lVar3 + 152),
                                                                                        local_res18[0],
                                                                                        DAT_181d796d8);
                                                          if (fVar16 <= 0.0) {
                                                            uVar4 = *(uint64 *)
                                                                     (pStatics_ef00
                                                                     + 0x2e8);
                                                            uVar7 = *(uint64 *)
                                                                     (pStatics_ef00
                                                                     + 0x2f0);
                                                          }
                                                          else {
                                                            uVar4 = *(uint64 *)
                                                                     (pStatics_ef00
                                                                     + 0x280);
                                                            uVar7 = *(uint64 *)
                                                                     (pStatics_ef00
                                                                     + 0x288);
                                                          }
                                                          if (plVar11 == (int64 *)0) break;
                                                          local_78 = uVar4;
                                                          uStack_70 = uVar7;
                                                          (**(code **)(*plVar11 + 0x2a8))(plVar11);
                                                        }
                                                        if (local_res18[0] == 0) {
                                                          if (this.forceUI == null) {
        LAB_180b4ae27:
                          // WARNING: Subroutine does not return
                                                            FUN_1800d6620();
                                                          }
                                                          lVar3 = GameObject.get_transform
                                                                            (this.forceUI
                                                                             ,0);
                                                          uVar4 = Int32.ToString(local_res18,0);
                                                          if (((lVar3 == null) ||
                                                              (lVar3 = Transform.Find(lVar3,uVar4,0),
                                                              lVar3 == null)) ||
                                                             (lVar3 = Transform.Find(lVar3,"Icon",
                                                                                      0), lVar3 == null))
                                                          goto LAB_180b4ae27;
                                                          lVar3 = Component.GetComponent
                                                                            (lVar3,DAT_181d6ccc0);
                                                          lVar14 = FUN_18046c0a0(0);
                                                          if (((lVar14 == null) ||
                                                              (*(int64 *)(lVar14 + 32) == 0)) ||
                                                             (lVar14 = WorldData.GetHeroForce
                                                                                 (*(int64 *)
                                                                                   (lVar14 + 32),0,0),
                                                             lVar14 == null)) goto LAB_180b4ae27;
                                                          local_ac = ForceData.GetRealSalaryCost
                                                                               (lVar14,0);
                                                          uVar4 = il2cpp_value_box(DAT_181d5b2f8,&local_ac
                                                                                  );
                                                          lVar14 = FUN_18046c0a0(0);
                                                          if (((lVar14 == null) ||
                                                              (*(int64 *)(lVar14 + 32) == 0)) ||
                                                             (lVar14 = WorldData.GetHeroForce
                                                                                 (*(int64 *)
                                                                                   (lVar14 + 32),0,0),
                                                             lVar14 == null)) goto LAB_180b4ae27;
                                                          local_res20[0] =
                                                               (float)ForceData.GetSalaryRate(lVar14,0);
                                                          local_res20[0] = local_res20[0] * 100.0;
                                                          Single.ToString(local_res20,"f0",0);
                                                          uVar4 = String.Format("门派银钱\n♦门派银钱消耗包含弟子月俸总计{0}两({1}%)\n♦若月底门派银钱告罄，会导致全派弟子忠诚-20",uVar4);
                                                          if (lVar3 == null) goto LAB_180b4ae27;
                                                          lVar3.Count = uVar4;
                                                        }
                                                        local_res18[0] = local_res18[0] + 1;
                                                        } while( true );
                                                        }
                                                        }
                                                        }
                                                        }
                                                        goto LAB_180b4ad83;
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
            lVar14 = 32;
            do {
              if (lVar3.Count <= (int)uVar13) {
                FUN_180f56130(lVar3,DAT_181d65378);
                fVar16 = this.refreshTime;
                goto LAB_180b48527;
              }
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar13) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int64 *)(lVar14 + lVar3._items) != 0) {
                lVar3 = FUN_18046c0a0(0);
                if ((this.hudResourceShowDatas == null) ||
                   (lVar5 = FUN_180002f80(this.hudResourceShowDatas,uVar13,DAT_181d65478)) == null
                   ) break;
                uVar4 = Single.ToString(lVar5 + 20,"+0;-0;0",0);
                if (this.forceUI == null) break;
                lVar5 = GameObject.get_transform(this.forceUI,0);
                if ((((this.hudResourceShowDatas == null) ||
                     (lVar6 = FUN_180002f80(this.hudResourceShowDatas,uVar13,DAT_181d65478),
                     lVar6 == null)) || (uVar7 = Int32.ToString(lVar6 + 16,0), lVar5 == null)) ||
                   (lVar5 = Transform.Find(lVar5,uVar7,0)) == null) break;
                puVar8 = (uint64 *)Transform.get_position(local_88,lVar5,0);
                uVar7 = *puVar8;
                uVar12 = *(uint32 *)(puVar8 + 1);
                if ((this.hudResourceShowDatas == null) ||
                   (lVar5 = FUN_180002f80(this.hudResourceShowDatas,uVar13,DAT_181d65478)) == null
                   ) break;
                if (*(float *)(lVar5 + 20) <= 0.0) {
                  uVar9 = *(uint64 *)(pStatics_ef00 + 0x2e8);
                  uVar10 = *(uint64 *)(pStatics_ef00 + 0x2f0);
                }
                else {
                  uVar9 = *(uint64 *)(pStatics_ef00 + 0x280);
                  uVar10 = *(uint64 *)(pStatics_ef00 + 0x288);
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
          }
        }
    }

    // Token : 0x60017F9
    // RVA   : 0xB46E60   Offset: 0xB45660   Length: 0x93C
    public void RefreshNowResearch()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        if (((*pStatics == 0) ||
            (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        lVar2 = HeroData.GetForce(lVar2,0,0);
        if (lVar2 != null) {
          if ((((*pStatics == 0) ||
               (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
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
                lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
                lVar3 = FUN_18046c0a0(0);
                if (((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                     (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                    ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                     (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null))) && (lVar2 != null)) {
                  Image.set_fillAmount(lVar2,*(uint32 *)(lVar3 + 24),0);
                  if (((this.nowResearch != null) &&
                      (lVar2 = GameObject.get_transform(this.nowResearch,0)) != null) &&
                     (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
                    uVar4 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                    lVar2 = FUN_18046c0a0(0);
                    if ((((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                        (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) &&
                       (((lVar2 = HeroData.GetForce(lVar2,0,0), lVar2 != null &&
                         (lVar2 = ForceData.GetNowResearchTech(lVar2,0)) != null) &&
                        ((lVar2 = ForceTechLvData.Database(lVar2,0), lVar2 != null &&
                         (*(int64 *)(lVar2 + 24) != 0)))))) {
                      local_res18[0] = String.get_Chars(*(int64 *)(lVar2 + 24),0,0);
                      uVar5 = Char.ToString(local_res18,0);
                      LTLocalization.SetText(uVar4,uVar5,0);
                      if (this.nowResearch != null) {
                        lVar2 = GameObject.GetComponent(this.nowResearch,DAT_181da12b0);
                        plVar6 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                        lVar3 = FUN_18046c0a0(0);
                        if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                           ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 != null &&
                            (((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                              (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null) &&
                             (lVar3 = ForceTechLvData.Database(lVar3,0)) != null))))) {
                          uVar4 = *(uint64 *)(lVar3 + 24);
                          lVar3 = FUN_18046c0a0(0);
                          if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                              (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                             ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                              (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null))) {
                            uVar5 = Int32.ToString(lVar3 + 20,0);
                            lVar3 = String.Concat(uVar4,"等级",uVar5,0);
                            if (plVar6 != (int64 *)0) {
                              if ((lVar3 != null) &&
                                 (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if ((int)plVar6[3] == 0) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar6[4] = lVar3;
                              il2cpp_internal(plVar6 + 4,lVar3);
                              lVar3 = FUN_18046c0a0(0);
                              if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                  (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null)
                                 && (lVar3 = HeroData.GetForce(lVar3,0,0)) != null) {
                                lVar3 = ForceData.GetNowResearchTech(lVar3,0);
                                lVar7 = FUN_18046c0a0(0);
                                if ((((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) &&
                                    ((lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0), lVar7 != null
                                     && ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                                         (*(int64 *)(lVar7 + 0x148) != 0)))))) &&
                                   (fVar8 = (float)ForceSpeAddData.Get(*(int64 *)(lVar7 + 0x148),4),
                                   lVar3 != null)) {
                                  local_res20[0] =
                                       ForceTechLvData.GetResearchLeftDay(lVar3,fVar8 + 1.0,0);
                                  lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                                  if ((lVar3 != null) &&
                                     (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar6 + 64)),
                                     lVar7 == null)) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  if (*(uint32 *)(plVar6 + 3) < 2) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  plVar6[5] = lVar3;
                                  il2cpp_internal(plVar6 + 5,lVar3);
                                  lVar3 = FUN_18046c0a0(0);
                                  if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                      (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0),
                                      lVar3 != null)) && (lVar3 = HeroData.GetForce(lVar3,0,0)) != null)
                                  {
                                    lVar3 = ForceData.GetNowResearchTech(lVar3,0);
                                    lVar7 = FUN_18046c0a0(0);
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
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      if (*(uint32 *)(plVar6 + 3) < 3) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar4,0);
                                      }
                                      plVar6[6] = lVar3;
                                      il2cpp_internal(plVar6 + 6,lVar3);
                                      lVar3 = FUN_18046c0a0(0);
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
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        if (*(uint32 *)(plVar6 + 3) < 4) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar4,0);
                                        }
                                        plVar6[7] = lVar3;
                                        il2cpp_internal(plVar6 + 7,lVar3);
                                        uVar4 = String.Format("正在研究 {0}\n下一等级 {2}\n剩余时间 {1}日({3}%)",plVar6,0);
                                        if (lVar2 != null) {
                                          *(uint64 *)(lVar2 + 24) = uVar4;
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
              FUN_1800d6620();
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

    // Token : 0x60017FA
    // RVA   : 0xB46940   Offset: 0xB45140   Length: 0x290
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
             (plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0), plVar5 != (int64 *)0
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
              uVar1 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              Mathf.CeilToInt(targetNum,0);
              GlobalData.DoTweenTextValue(uVar1);
              uVar1 = GameObject.get_transform(targetObj,0);
              cVar3 = DOTween.IsTweening(uVar1,1,0);
              if (cVar3) {
                return;
              }
              uVar1 = GameObject.get_transform(targetObj,0);
              uVar1 = ShortcutExtensions.DOScale(uVar1);
              uVar1 = TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181d98af0);
              TweenSettingsExtensions.SetLoops(uVar1,2,1,DAT_181d98060);
              return;
            }
          }
        }
    }

    // Token : 0x60017FB
    // RVA   : 0xB46800   Offset: 0xB45000   Length: 0x56
    public void AddHudResourceShowData(HudResourceShowData newData)
    {
        if (this.hudResourceShowDatas != null) {
          FUN_181827900(this.hudResourceShowDatas,newData,DAT_181d652f8);
          return;
        }
    }

    // Token : 0x60017FC
    // RVA   : 0xB46DD0   Offset: 0xB455D0   Length: 0x8B
    public void RefreshHeroSkeleton()
    {
        long lVar1;
        ulong uVar2;
        if (this.heroFace != null) {
          lVar1 = GameObject.GetComponent(this.heroFace,DAT_181da11b0);
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

    // Token : 0x60017FD
    // RVA   : 0xB46DA0   Offset: 0xB455A0   Length: 0x26
    private void LateUpdate()
    {
        if (this.needRefreshPlayerSkeleton) {
          HudController.RefreshHeroSkeleton(this,0);
          this.needRefreshPlayerSkeleton = 0;
        }
    }

    // Token : 0x60017FE
    // RVA   : 0xB46D20   Offset: 0xB45520   Length: 0x77
    public void InfoButtonClicked()
    {
        this.showInfoList = !this.showInfoList;
        if (this.infoList != null) {
          plVar1 = (int64 *)GameObject.GetComponent(this.infoList,DAT_181da2230);
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180b46d8b. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x188))
                      (plVar1,this.showInfoList,*(uint64 *)(*plVar1 + 400));
            return;
          }
        }
    }

    // Token : 0x60017FF
    // RVA   : 0xB46BE0   Offset: 0xB453E0   Length: 0x13D
    public bool HudPanelActive()
    {
        var pStatics_1200 = *(int64*)(DAT_181d51200 + 184);
        var pStatics_29a0 = *(int64*)(DAT_181da29a0 + 184);
        var pStatics_e090 = *(int64*)(DAT_181d4e090 + 184);
        var pStatics_ede0 = *(int64*)(DAT_181d6ede0 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if ((*pStatics_ede0 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_ede0 + 32)) != null) {
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          if (cVar2) {
            return true;
          }
          if ((*pStatics_29a0 != 0) &&
             (lVar1 = *(int64 *)(*pStatics_29a0 + 24)) != null) {
            cVar2 = GameObject.get_activeSelf(lVar1,0);
            if (cVar2) {
              return true;
            }
            if ((*pStatics_1200 != 0) &&
               (lVar1 = *(int64 *)(*pStatics_1200 + 24)) != null) {
              cVar2 = GameObject.get_activeSelf(lVar1,0);
              if (cVar2) {
                return true;
              }
              if ((*pStatics_e090 != 0) &&
                 (lVar1 = *(int64 *)(*pStatics_e090 + 24)) != null) {
                uVar3 = GameObject.get_activeSelf(lVar1,0);
                return uVar3;
              }
            }
          }
        }
    }

    // Token : 0x6001800
    // RVA   : 0xB4AE30   Offset: 0xB49630   Length: 0x79
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e9b0);
        FUN_180f58a90(uVar1,DAT_181d65278);
        this.hudResourceShowDatas = uVar1;
        FUN_18044ef50(this,0);
    }

}
