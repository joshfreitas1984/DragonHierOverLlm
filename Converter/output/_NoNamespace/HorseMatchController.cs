// ============================================================
// Type  : HorseMatchController
// Token : 0x20002DD
// ============================================================

public class HorseMatchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001783
    public HorseMatchState horseMatchState;

    // Token: 0x4001784
    public GameObject horseMatchRoot;

    // Token: 0x4001785
    public GameObject horseMatchUIPanel;

    // Token: 0x4001786
    public GameObject horseMatchHeroPrefab;

    // Token: 0x4001787
    public GameObject horseMatchSpeObjPrefab;

    // Token: 0x4001788
    public float matchDifficulty;

    // Token: 0x4001789
    public List<HeroData> heroList;

    // Token: 0x400178A
    public GameObject playerObj;

    // Token: 0x400178B
    public List<GameObject> heroObjList;

    // Token: 0x400178C
    public List<GameObject> speObjList;

    // Token: 0x400178D
    public List<HeroData> HeroFinalList;

    // Token: 0x400178E
    public string endMatchCallPlot;

    // Token: 0x400178F
    public Text stateText;

    // Token: 0x4001790
    public GameObject startButton;

    // Token: 0x4001791
    public GameObject endLine;

    // Token: 0x4001792
    public float timeCount;

    // Token: 0x4001793
    public GameObject horse;

    // Token: 0x4001794
    public List<Sprite> speObjSprite;

    // Token: 0x4001795
    public GameObject rankList;

    // Token: 0x4001796
    public GameObject endButton;

    // Token: 0x4001797
    public List<GameObject> checkDisableObj;

    // Token: 0x4001798
    public List<GameObject> checkEnableObj;

    // Token: 0x4001799
    private GameObject newObj;

    // Token: 0x400179A
    private static float TotalRangeHalf;

    // Token: 0x400179B
    public static List<string> AreaHorseMatchResultString;

    // Token: 0x400179C
    public static List<int> AreaHorseMatchResultReward;

    // Token: 0x400179D
    public static List<int> AreaHorseMatchFameReward;

    // Token: 0x400179E
    private static HorseMatchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001825
    // RVA   : 0xB06A20   Offset: 0xB05E20   Length: 0x58
    public static HorseMatchController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d768d0 + 184) + 32);
    }

    // Token : 0x6001826
    // RVA   : 0xB04520   Offset: 0xB03920   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d768d0 + 184) + 32);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001827
    // RVA   : 0xB064F0   Offset: 0xB058F0   Length: 0x2FE
    private void Update()
    {
        ulong uVar1;
        int iVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar10;
        long lVar11;
        float fVar13;
        float fVar14;
        uint[] local_res8 = new uint[2];
        iVar2 = this.horseMatchState;
        plVar9 = (int64 *)0;
        local_res8[0] = 0;
        if ((iVar2 != 0) && (iVar2 != 1)) {
          if (iVar2 == 2) {
            fVar14 = this.timeCount;
            fVar13 = (float)Time.get_deltaTime(0);
            fVar13 = fVar14 - fVar13;
            this.timeCount = fVar13;
            iVar2 = Mathf.CeilToInt(fVar13,0);
            iVar3 = Mathf.CeilToInt(fVar14,0);
            if (iVar2 != iVar3) {
              plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeBig",0);
              if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
                plVar9 = plVar7;
              }
              NGUITools.PlaySound(plVar9,0);
            }
            uVar1 = this.stateText;
            local_res8[0] = Mathf.CeilToInt(this.timeCount,0);
            uVar4 = Int32.ToString(local_res8,0);
            LTLocalization.SetText(uVar1,uVar4,0);
            if (this.timeCount <= 0.0) {
        LAB_180b067bf:
              HorseMatchController.ChangeNextState(this,0);
            }
          }
          else {
            if (iVar2 == 3) {
              fVar14 = this.timeCount;
              fVar13 = (float)Time.get_deltaTime(0);
              uVar1 = this.stateText;
              fVar13 = fVar13 + fVar14;
              this.timeCount = fVar13;
              local_res8[0] = Mathf.FloorToInt(fVar13,0);
              uVar4 = Int32.ToString(local_res8,0);
              LTLocalization.SetText(uVar1,uVar4,0);
              lVar5 = this.heroObjList;
              if (lVar5 != null) {
                lVar11 = 32;
                plVar7 = plVar9;
                plVar12 = (int64 *)1;
                while( true ) {
                  uVar10 = (uint32)plVar7;
                  if (lVar5.Count <= (int)uVar10) {
                    if ((char)!plVar12) {
                      return;
                    }
                    goto LAB_180b067bf;
                  }
                  if (lVar5 == null) break;
                  if (lVar5.Count <= uVar10) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar11 + lVar5._items);
                  if ((lVar5 == null) || (lVar6 = GameObject.GetComponent(lVar5,DAT_181d71df8)) == null)
                  break;
                  lVar5 = this.heroObjList;
                  lVar11 = lVar11 + 8;
                  plVar7 = (int64 *)(uint64)(uVar10 + 1);
                  plVar8 = plVar9;
                  if (*(char *)(lVar6 + 40) != false) {
                    plVar8 = plVar12;
                  }
                  plVar12 = plVar8;
                  if (lVar5 == null) break;
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (iVar2 == 4) {
              fVar14 = this.timeCount;
              fVar13 = (float)Time.get_deltaTime(0);
              fVar14 = fVar14 - fVar13;
              this.timeCount = fVar14;
              if (fVar14 <= 0.0) {
                HorseMatchController.FinishHorseMatch(this,0);
              }
            }
          }
        }
    }

    // Token : 0x6001828
    // RVA   : 0xB04FA0   Offset: 0xB043A0   Length: 0x444
    public void FinishMatch(GameObject targetHero)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        long lVar8;
        int[] local_res10 = new int[2];
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if ((targetHero != null) && (lVar3 = GameObject.GetComponent(targetHero,DAT_181d71df8)) != null) {
          *(uint8 *)(lVar3 + 40) = 1;
          lVar3 = GameObject.GetComponent(targetHero,DAT_181d71df8);
          if ((lVar3 != null) && (lVar3.Count != null)) {
            HeroData.RefreshHorseState(lVar3.Count,0,0);
            lVar3 = this.HeroFinalList;
            lVar4 = GameObject.GetComponent(targetHero,DAT_181d71df8);
            if ((lVar4 != null) && (lVar3 != null)) {
              FUN_18181e0a0(lVar3,*(uint64 *)(lVar4 + 24),DAT_181d8b518);
              lVar3 = **(int64 **)(DAT_181d72cc8 + 184);
              if (this.HeroFinalList != null) {
                local_res10[0] = this.HeroFinalList.Count;
                uVar5 = Int32.ToString(local_res10,0);
                lVar4 = GameObject.get_transform(targetHero,0);
                if (lVar4 != null) {
                  puVar6 = (uint64 *)Transform.get_position(&local_38,lVar4,0);
                  uVar1 = *puVar6;
                  uVar2 = *(uint32 *)(puVar6 + 1);
                  puVar7 = (uint32 *)Color.get_yellow(&local_28,0);
                  if (lVar3 != null) {
                    local_28 = *puVar7;
                    uStack_24 = puVar7[1];
                    uStack_20 = puVar7[2];
                    uStack_1c = puVar7[3];
                    local_38 = uVar1;
                    local_30 = uVar2;
                    GameController.ShowTextAtPos(lVar3,uVar5,&local_38,30,&local_28,0);
                    if (this.HeroFinalList != null) {
                      if (3 < this.HeroFinalList.Count) {
                        return;
                      }
                      if (this.rankList != null) {
                        lVar3 = GameObject.get_transform(this.rankList,0);
                        if (this.HeroFinalList != null) {
                          local_res10[0] = this.HeroFinalList.Count + -1;
                          uVar5 = Int32.ToString(local_res10,0);
                          if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,uVar5,0)) != null) {
                            uVar5 = Component.get_gameObject(lVar3,0);
                            if (*pStatics != 0) {
                              uVar1 = *(uint64 *)(*pStatics + 144);
                              lVar3 = GlobalData.AddChild(uVar5,uVar1,0);
                              if (lVar3 != null) {
                                lVar4 = GameObject.GetComponent(lVar3,DAT_181d71b50);
                                lVar8 = GameObject.GetComponent(targetHero,DAT_181d71df8);
                                if ((lVar8 != null) && (lVar4 != null)) {
                                  *(uint64 *)(lVar4 + 32) = *(uint64 *)(lVar8 + 24);
                                  lVar4 = GameObject.GetComponent(lVar3,DAT_181d71b50);
                                  if (lVar4 != null) {
                                    *(uint32 *)(lVar4 + 24) = 0;
                                    lVar3 = GameObject.GetComponent(lVar3,DAT_181d71b50);
                                    if (lVar3 != null) {
                                      *(uint8 *)(lVar3 + 88) = 1;
                                      plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                                      plVar10 = (int64 *)0;
                                      if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf348)) {
                                        plVar10 = plVar9;
                                      }
                                      NGUITools.PlaySound(plVar10,0);
                                      if (this.HeroFinalList != null) {
                                        if (this.HeroFinalList.Count == 3) {
                                          if (this.endButton == null) throw; // [null/range check failed]
                                          GameObject.SetActive(this.endButton,1,0);
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
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001829
    // RVA   : 0xB04590   Offset: 0xB03990   Length: 0x6C1
    public void ChangeNextState()
    {
        int iVar1;
        float fVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar6;
        int iVar8;
        uint uVar9;
        long lVar12;
        ulong local_58;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        ulong local_28;
        ulong uStack_20;
        uVar3 = DAT_181db9f50;
        iVar1 = this.horseMatchState;
        uVar3 = Type.GetTypeFromHandle(uVar3,0);
        lVar4 = Enum.GetNames(uVar3,0);
        fVar2 = local_40;
        if (lVar4 == null) {
        LAB_180b04c4c:
          local_40 = fVar2;
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (iVar1 + 1 < lVar4.Count) {
          iVar1 = this.horseMatchState;
          iVar8 = iVar1 + 1;
          this.horseMatchState = iVar8;
          if (iVar8 != 0) {
            if (iVar1 == 0) {
              uVar3 = this.stateText;
              LTLocalization.SetText(uVar3,"准备",0);
              fVar2 = local_40;
              if (this.startButton != null) {
                GameObject.SetActive(this.startButton,1,0);
                fVar2 = local_40;
                if (this.startButton != null) {
                  lVar4 = GameObject.get_transform(this.startButton,0);
                  puVar7 = (uint64 *)Vector3.get_one(&local_28,0);
                  local_38 = *puVar7;
                  local_30 = *(float *)(puVar7 + 1);
                  local_40 = local_30 * 3.0;
                  local_58 = CONCAT44((float)((uint64)local_38 >> 32) * 3.0,(float)local_38 * 3.0);
                  local_48 = local_38;
                  fVar2 = local_30;
                  if (lVar4 != null) {
                    local_48 = local_58;
                    Transform.set_localScale(lVar4,&local_48,0);
                    fVar2 = local_40;
                    if (this.startButton != null) {
                      uVar3 = GameObject.get_transform(this.startButton,0);
                      uVar3 = ShortcutExtensions.DOScale(uVar3,0x3f800000,0x3e800000,0);
                      TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1db0);
                      fVar2 = local_40;
                      if (this.startButton != null) {
                        plVar5 = (int64 *)
                                 GameObject.GetComponent(this.startButton,DAT_181d71e80);
                        puVar7 = (uint64 *)FUN_1810d3570(&local_28,0);
                        local_28 = *puVar7;
                        uStack_20 = puVar7[1];
                        puVar7 = (uint64 *)GlobalData.SetColorAlpha(&local_38,&local_28,0,0);
                        fVar2 = local_40;
                        if (plVar5 != (int64 *)0) {
                          local_28 = *puVar7;
                          uStack_20 = puVar7[1];
                          (**(code **)(*plVar5 + 0x2a8))
                                    (plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                          fVar2 = local_40;
                          if (this.startButton != null) {
                            uVar3 = GameObject.GetComponent(this.startButton,DAT_181d71e80);
                            DOTweenModuleUI.DOFade(uVar3,0x3f800000,0x3e800000,0);
                            return;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            else if (iVar1 == 1) {
              this.timeCount = 0x40400000;
              if (this.startButton != null) {
                uVar3 = GameObject.get_transform(this.startButton,0);
                ShortcutExtensions.DOScale(uVar3,0x40400000,0x3e800000,0);
                fVar2 = local_40;
                if (this.startButton != null) {
                  uVar3 = GameObject.GetComponent(this.startButton,DAT_181d71e80);
                  uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e800000,0);
                  uVar6 = new OnTooltipCB(this,DAT_181d79530,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar6,DAT_181dbffb0);
                  return;
                }
              }
            }
            else {
              if (iVar8 != 3) {
                if (iVar8 != 4) {
                  return;
                }
                plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/人群欢呼",0);
                plVar11 = (int64 *)0;
                if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                  plVar11 = plVar5;
                }
                NGUITools.PlaySound(plVar11,0);
                uVar3 = this.stateText;
                LTLocalization.SetText(uVar3,"终了",0);
                this.timeCount = 0x40400000;
                return;
              }
              if (this.rankList != null) {
                uVar3 = GameObject.get_transform(this.rankList,0);
                plVar11 = (int64 *)0;
                ShortcutExtensions.DOLocalMoveY(uVar3,0xc4048000,0x3f000000,0,0);
                plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/开场锣",0);
                plVar10 = plVar11;
                if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
                  plVar10 = plVar5;
                }
                NGUITools.PlaySound(plVar10,0);
                lVar4 = this.heroObjList;
                fVar2 = local_40;
                if (lVar4 != null) {
                  lVar12 = 32;
                  while( true ) {
                    uVar9 = (uint32)plVar11;
                    if (lVar4.Count <= (int)uVar9) {
                      return;
                    }
                    fVar2 = local_40;
                    if (lVar4 == null) break;
                    if (lVar4.Count <= uVar9) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(lVar12 + lVar4._items);
                    fVar2 = local_40;
                    if ((lVar4 == null) ||
                       (lVar4 = GameObject.GetComponent(lVar4,DAT_181d71df8), fVar2 = local_40,
                       lVar4 == null)) break;
                    *(uint8 *)(lVar4 + 56) = 1;
                    lVar4 = this.heroObjList;
                    if (lVar4 == null) break;
                    if (lVar4.Count <= uVar9) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(lVar12 + lVar4._items);
                    fVar2 = local_40;
                    if ((lVar4 == null) ||
                       (lVar4 = GameObject.GetComponent(lVar4,DAT_181d71df8), fVar2 = local_40,
                       lVar4 == null)) break;
                    uVar3 = *(uint64 *)(lVar4 + 32);
                    GlobalData.SetSkeletonAnimationFromRandomStart(uVar3,0,"run",1,0);
                    lVar4 = this.heroObjList;
                    plVar11 = (int64 *)(uint64)(uVar9 + 1);
                    lVar12 = lVar12 + 8;
                    fVar2 = local_40;
                    if (lVar4 == null) break;
                  }
                }
              }
            }
            goto LAB_180b04c4c;
          }
        }
        else {
          this.horseMatchState = 0;
        }
    }

    // Token : 0x600182A
    // RVA   : 0xB064B0   Offset: 0xB058B0   Length: 0xE
    public void StartButtonClicked()
    {
        void FUN_180b064b0(int64 this)
        {
        if (this.horseMatchState == 1) {
          HorseMatchController.ChangeNextState(this,0);
          return;
        }
    }

    // Token : 0x600182B
    // RVA   : 0xB05970   Offset: 0xB04D70   Length: 0xB3A
    public void RestartHorseMatch(List<HeroData> _heroList, string _endMatchCallPlot, float _difficulty)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_dcf8 = *(int64*)(DAT_181dadcf8 + 184);
        void HorseMatchController.RestartHorseMatch
                     (int64 this,uint64 _heroList,uint64 _endMatchCallPlot,uint32 _difficulty)
        {
        float fVar1;
        char cVar2;
        uint8 uVar3;
        int64 lVar4;
        int64 *plVar5;
        uint64 uVar6;
        uint64 *puVar7;
        int64 lVar8;
        uint64 uVar9;
        uint32 uVar10;
        int64 *plVar11;
        int64 *plVar12;
        int64 lVar13;
        float fVar14;
        uint64 local_108;
        float local_100;
        uint64 local_f8;
        uint64 uStack_f0;
        float local_e8;
        float local_e4;
        float local_e0;
        float local_d0;
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [128];
        lVar4 = this.checkDisableObj;
        plVar12 = (int64 *)0;
        fVar1 = local_100;
        if (lVar4 != null) {
          lVar13 = 32;
          plVar5 = plVar12;
          while (uVar10 = (uint32)plVar5, (int)uVar10 < lVar4.Count) {
            fVar1 = local_100;
            if (lVar4 == null) goto LAB_180b064a5;
            if (lVar4.Count <= uVar10) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = local_100;
            if (*(int64 *)(lVar13 + lVar4._items) == 0) goto LAB_180b064a5;
            cVar2 = GameObject.get_activeSelf();
            if (cVar2) {
              fVar1 = local_100;
              if ((this.checkDisableObj == null) ||
                 (lVar4 = FUN_180002f80(this.checkDisableObj,plVar5,DAT_181d89918),
                 fVar1 = local_100, lVar4 == null)) goto LAB_180b064a5;
              GameObject.SetActive(lVar4,0,0);
              lVar4 = this.checkEnableObj;
              fVar1 = local_100;
              if ((this.checkDisableObj == null) ||
                 (FUN_180002f80(this.checkDisableObj,plVar5,DAT_181d89918), fVar1 = local_100,
                 lVar4 == null)) goto LAB_180b064a5;
              FUN_18181e0a0(lVar4);
            }
            lVar4 = this.checkDisableObj;
            plVar5 = (int64 *)(uint64)(uVar10 + 1);
            lVar13 = lVar13 + 8;
            fVar1 = local_100;
            if (lVar4 == null) goto LAB_180b064a5;
          }
          plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/紧密鼓点",0);
          plVar11 = plVar12;
          if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
            plVar11 = plVar5;
          }
          NGUITools.PlaySound(plVar11,0);
          fVar1 = local_100;
          if (this.horseMatchRoot != null) {
            GameObject.SetActive(this.horseMatchRoot,1,0);
            fVar1 = local_100;
            if (this.horseMatchUIPanel != null) {
              GameObject.SetActive(this.horseMatchUIPanel,1,0);
              uVar6 = il2cpp_internal(DAT_181d93350);
              FUN_18132faf0(uVar6,DAT_181d8b418);
              this.HeroFinalList = uVar6;
              this.matchDifficulty = _difficulty;
              uVar6 = GlobalData.SortHeroList(_heroList,0,0);
              this.heroList = uVar6;
              this.endMatchCallPlot = _endMatchCallPlot;
              this.horseMatchState = 0;
              HorseMatchController.ChangeNextState(this,0);
              fVar1 = local_100;
              if (this.endButton != null) {
                GameObject.SetActive(this.endButton,0,0);
                this.playerObj = 0;
                lVar4 = this.heroList;
                fVar1 = local_100;
                if (lVar4 != null) goto LAB_180b05d50;
              }
            }
          }
        }
        LAB_180b064a5:
        local_100 = fVar1;
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b05d50:
        puVar7 = &this.playerObj;
        uVar10 = (uint32)plVar12;
        if (lVar4.Count <= (int)uVar10) {
          uVar6 = this.playerObj;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          lVar4 = this.horse;
          fVar1 = local_100;
          if (!cVar2) {
            if (lVar4 == null) goto LAB_180b064a5;
            GameObject.SetActive(lVar4,0,0);
          }
          else {
            if (lVar4 == null) goto LAB_180b064a5;
            GameObject.SetActive(lVar4,1,0);
            fVar1 = local_100;
            if (*pStatics_dcf8 == 0) goto LAB_180b064a5;
            TutorialController.StartTutorial(*pStatics_dcf8,"赛马大会",0);
          }
          fVar1 = local_100;
          if (((this.horseMatchUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.horseMatchUIPanel,0), fVar1 = local_100,
              lVar4 == null)) ||
             (lVar4 = Transform.Find(lVar4,"HorseBack",0), fVar1 = local_100) == null)
          goto LAB_180b064a5;
          lVar4 = Component.get_gameObject(lVar4,0);
          uVar6 = this.playerObj;
          uVar3 = Object.op_Inequality(uVar6,0,0);
          fVar1 = local_100;
          if (lVar4 == null) goto LAB_180b064a5;
          GameObject.SetActive(lVar4,uVar3,0);
          fVar1 = local_100;
          if (((this.horseMatchUIPanel == null) ||
              (lVar4 = GameObject.get_transform(this.horseMatchUIPanel,0), fVar1 = local_100,
              lVar4 == null)) ||
             (lVar4 = Transform.Find(lVar4,"HorseName",0), fVar1 = local_100) == null)
          goto LAB_180b064a5;
          uVar9 = Component.GetComponent(lVar4,DAT_181d96160);
          cVar2 = Object.op_Inequality(this.playerObj,0,0);
          uVar6 = "";
          if (cVar2) {
            fVar1 = local_100;
            if (((*pStatics_2cc8 == 0) ||
                (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
               (lVar4 = WorldData.Player(lVar4,0), fVar1 = local_100) == null) goto LAB_180b064a5;
            uVar6 = "";
            if (*(int64 *)(lVar4 + 0x208) != 0) {
              fVar1 = local_100;
              if ((((*pStatics_2cc8 == 0) ||
                   (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
                  (lVar4 = WorldData.Player(lVar4,0), fVar1 = local_100) == null) ||
                 (*(int64 *)(lVar4 + 0x208) == 0)) goto LAB_180b064a5;
              uVar6 = *(uint64 *)(*(int64 *)(lVar4 + 0x208) + 32);
            }
          }
          LTLocalization.SetText(uVar9,uVar6,0);
          HorseMatchController.GenerateSpeObj(this,0);
          fVar1 = local_100;
          if (this.rankList != null) {
            lVar4 = GameObject.get_transform(this.rankList,0);
            puVar7 = (uint64 *)Vector3.get_down(local_c8,0);
            local_108 = *puVar7;
            local_100 = *(float *)(puVar7 + 1) * 650.0;
            fVar1 = *(float *)(puVar7 + 1);
            if (lVar4 != null) {
              local_108 = CONCAT44((float)((uint64)local_108 >> 32) * 650.0,(float)local_108 * 650.0)
              ;
              Transform.set_localPosition(lVar4,&local_108,0);
              return;
            }
          }
          goto LAB_180b064a5;
        }
        uVar6 = this.horseMatchRoot;
        uVar9 = this.horseMatchHeroPrefab;
        lVar4 = GlobalData.AddChild(uVar6,uVar9,0);
        this.newObj = lVar4;
        fVar14 = ((float)(int)((float)(int)uVar10 * 0.5) * 0.5 + 0.25) *
                 (float)(int)((~uVar10 & 1) * 2 + -1);
        fVar1 = local_100;
        if (*plVar5 == 0) goto LAB_180b064a5;
        lVar4 = GameObject.get_transform(*plVar5,0);
        fVar1 = local_100;
        if (lVar4 == null) goto LAB_180b064a5;
        local_e8 = -**(float **)(DAT_181d768d0 + 184) - 0.8;
        local_e4 = fVar14;
        local_e0 = fVar14 * 0.1;
        Transform.set_localPosition(lVar4,&local_e8,0);
        fVar1 = local_100;
        if (*plVar5 == 0) goto LAB_180b064a5;
        lVar4 = GameObject.GetComponent(*plVar5,DAT_181d71df8);
        fVar1 = local_100;
        if ((this.heroList == null) ||
           (uVar6 = FUN_180002f80(this.heroList,plVar12,DAT_181d8bb98), fVar1 = local_100,
           lVar4 == null)) goto LAB_180b064a5;
        lVar4.Count = uVar6;
        fVar1 = local_100;
        if ((*plVar5 == 0) ||
           (lVar4 = GameObject.GetComponent(*plVar5,DAT_181d71df8), fVar1 = local_100) == null)
        goto LAB_180b064a5;
        lVar4 = *(int64 *)(lVar4 + 48);
        if ((this.heroList == null) ||
           (lVar13 = FUN_180002f80(this.heroList,plVar12,DAT_181d8bb98), fVar1 = local_100
           , lVar13 == null)) goto LAB_180b064a5;
        if (*(int *)(lVar13 + 88) == 0) {
          puVar7 = (uint64 *)Color.get_green(local_b8);
        }
        else {
          puVar7 = (uint64 *)FUN_180d98fe0(local_a8);
        }
        fVar1 = local_100;
        if (lVar4 == null) goto LAB_180b064a5;
        local_f8 = *puVar7;
        uStack_f0 = puVar7[1];
        SpriteRenderer.set_color(lVar4,&local_f8,0);
        fVar1 = local_100;
        if (*plVar5 == 0) goto LAB_180b064a5;
        lVar4 = GameObject.GetComponent(*plVar5,DAT_181d71df8);
        fVar1 = local_100;
        if (this.heroList == null) goto LAB_180b064a5;
        lVar8 = FUN_180002f80(this.heroList,plVar12,DAT_181d8bb98);
        lVar13 = *plVar5;
        puVar7 = (uint64 *)Vector3.get_one(local_c8,0);
        local_f8 = *puVar7;
        local_d0 = *(float *)(puVar7 + 1);
        uStack_f0 = CONCAT44((int)((uint64)uStack_f0 >> 32),local_d0);
        fVar1 = local_100;
        if (lVar8 == null) goto LAB_180b064a5;
        local_108 = CONCAT44((float)((uint64)local_f8 >> 32) * 0.3,(float)local_f8 * 0.3);
        local_100 = local_d0 * 0.3;
        uVar6 = HeroData.GenerateHeroSkeleton(lVar8,lVar13,&local_108,0);
        fVar1 = local_100;
        if (lVar4 == null) goto LAB_180b064a5;
        *(uint64 *)(lVar4 + 32) = uVar6;
        fVar1 = local_100;
        if (((this.heroObjList == null) ||
            (FUN_18181e0a0(this.heroObjList,*plVar5,DAT_181d89398), fVar1 = local_100,
            this.heroList == null)) ||
           (lVar4 = FUN_180002f80(), fVar1 = local_100) == null) goto LAB_180b064a5;
        if (*(int *)(lVar4 + 88) == 0) {
          this.playerObj = *plVar5;
        }
        lVar4 = this.heroList;
        plVar12 = (int64 *)(uint64)(uVar10 + 1);
        fVar1 = local_100;
        if (lVar4 == null) goto LAB_180b064a5;
        goto LAB_180b05d50;
    }

    // Token : 0x600182C
    // RVA   : 0xB053F0   Offset: 0xB047F0   Length: 0x573
    private void GenerateSpeObj()
    {
        float fVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        int iVar9;
        int iVar10;
        int iVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        int[] local_res18 = new int[2];
        float local_res20;
        uint uStackX_24;
        float local_f8;
        float local_f4;
        uint local_f0;
        float[] local_e8 = new float[4];
        float[] local_d8 = new float[40];
        local_res18[0] = 0;
        iVar5 = FUN_180d95a30(3);
        iVar9 = 0;
        if (0 < iVar5) {
          do {
            uVar6 = DAT_181db9ec8;
            uVar6 = Type.GetTypeFromHandle(uVar6,0);
            lVar7 = Enum.GetNames(uVar6,0);
            if (lVar7 == null) {
        LAB_180b0595e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar4 = (int64)iVar9 % (int64)*(int *)(lVar7 + 24);
            fVar2 = **(float **)(DAT_181d768d0 + 184);
            fVar12 = (float)Random.Range();
            fVar13 = (float)Random.Range();
            plVar1 = &this.newObj;
            iVar10 = 0;
            do {
              uVar6 = this.horseMatchRoot;
              uVar3 = this.horseMatchSpeObjPrefab;
              lVar7 = GlobalData.AddChild(uVar6,uVar3,0);
              this.newObj = lVar7;
              il2cpp_internal(plVar1,lVar7);
              if (this.newObj == null) goto LAB_180b0595e;
              lVar7 = GameObject.get_transform(this.newObj,0);
              if (lVar7 == null) goto LAB_180b0595e;
              local_f0 = 0x3f800000;
              local_f8 = fVar12 + ((fVar2 + fVar2) / (float)iVar5) * (float)iVar9 + -fVar2;
              local_f4 = (float)iVar10 * 0.5 - 3.75;
              Transform.set_localPosition(lVar7,&local_f8,0);
              lVar7 = this.newObj;
              iVar11 = (int)uVar4;
              local_res18[0] = iVar11;
              uVar6 = Int32.ToString(local_res18,0);
              if (lVar7 == null) goto LAB_180b0595e;
              Object.set_name(lVar7,uVar6,0);
              if (this.newObj == null) goto LAB_180b0595e;
              lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73bb8);
              if ((this.speObjSprite == null) ||
                 (uVar6 = FUN_180002f80(this.speObjSprite,uVar4 & 0xffffffff,DAT_181da39d8),
                 lVar7 == null)) goto LAB_180b0595e;
              SpriteRenderer.set_sprite(lVar7,uVar6,0);
              if (iVar11 == 0) {
                if (this.newObj == null) goto LAB_180b0595e;
                lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73bb8);
                if (lVar7 == null) goto LAB_180b0595e;
                SpriteRenderer.set_size(lVar7,CONCAT44(0x3f000000,fVar13 * 0.5),0);
                if ((this.newObj == null) ||
                   (lVar7 = GameObject.GetComponent(this.newObj,DAT_181dc7848)) == null)
                goto LAB_180b0595e;
                pfVar8 = local_d8;
                local_d8[1] = 0.45;
                local_d8[2] = 10.0;
                local_d8[0] = fVar13 * 0.5;
        LAB_180b058a0:
                BoxCollider.set_size(lVar7,pfVar8,0);
              }
              else if (iVar11 == 1) {
                if (this.newObj != null) {
                  lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73bb8);
                  uStackX_24 = 0x3f000000;
                  fVar14 = fVar13 * 0.5;
                  local_res20 = fVar14;
                  if (lVar7 != null) {
                    SpriteRenderer.set_size(lVar7,CONCAT44(0x3f000000,fVar14),0);
                    if ((this.newObj != null) &&
                       (lVar7 = GameObject.GetComponent(this.newObj,DAT_181dc7848)) != null) {
                      pfVar8 = local_e8;
                      local_e8[1] = 0.45;
                      local_e8[2] = 10.0;
                      local_e8[0] = fVar14;
                      goto LAB_180b058a0;
                    }
                  }
                }
                goto LAB_180b0595e;
              }
              if (this.speObjList == null) goto LAB_180b0595e;
              FUN_18181e0a0();
              iVar10 = iVar10 + 1;
            } while (iVar10 < 16);
            iVar9 = iVar9 + 1;
          } while (iVar9 < iVar5);
        }
    }

    // Token : 0x600182D
    // RVA   : 0xB04C60   Offset: 0xB04060   Length: 0x334
    public void FinishHorseMatch()
    {
        long lVar2;
        ulong uVar3;
        uint uVar5;
        long lVar6;
        int[] local_res8 = new int[2];
        local_res8[0] = 0;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/终场锣",0);
        plVar4 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar4 = plVar1;
        }
        NGUITools.PlaySound(plVar4,0);
        lVar2 = this.checkEnableObj;
        uVar5 = 0;
        if (lVar2 != null) {
          lVar6 = 32;
          do {
            if (lVar2.Count <= (int)uVar5) {
              FUN_1812f9a10(lVar2,DAT_181d89418);
              local_res8[0] = 0;
              goto LAB_180b04dd0;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar6 + lVar2._items);
            if (lVar2 == null) break;
            GameObject.SetActive(lVar2,1);
            lVar2 = this.checkEnableObj;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
          } while (lVar2 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar2 = GameObject.get_transform(this.rankList,0);
          uVar3 = Int32.ToString(local_res8,0);
          if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar3,0)) == null) throw; // [null/range check failed]
          uVar3 = Component.get_gameObject(lVar2);
          GlobalData.DeleteAllChild(uVar3);
          local_res8[0] = local_res8[0] + 1;
          if (2 < local_res8[0]) break;
        LAB_180b04dd0:
          if (this.rankList == null) throw; // [null/range check failed]
        }
        uVar3 = this.heroObjList;
        GlobalData.DestroyAll(uVar3,0);
        GlobalData.DestroyAll(this.speObjList,0);
        if (this.heroList != null) {
          FUN_1812f9a10(this.heroList,DAT_181d8b618);
          this.horseMatchState = 0;
          if (this.horseMatchRoot != null) {
            GameObject.SetActive(this.horseMatchRoot,0,0);
            if (this.horseMatchUIPanel != null) {
              GameObject.SetActive(this.horseMatchUIPanel,0,0);
              lVar2 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
              if ((lVar2 != null) && (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
                GameObject.SendMessage(lVar2,this.endMatchCallPlot,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600182E
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600182F
    // RVA   : 0xB067F0   Offset: 0xB05BF0   Length: 0x22E
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d768d0 + 184);
        long lVar1;
        **(uint32 **)(DAT_181d768d0 + 184) = 0x41000000;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"阁下骏马奔逸绝尘，一骑当先，千里马常有而伯乐不常有，本次大赛冠军可谓实至名归。",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"阁下骏马风驰电掣，奋勇争先，只比冠军稍落后一筹，实在可惜。",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"阁下骏马龙腾虎跃，一往无前，还需再接再厉，未来可期。",DAT_181da3d58);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar1,DAT_181d8f098);
          if (lVar1 != null) {
            FUN_18182a0b0(lVar1,400,DAT_181d8f218);
            FUN_18182a0b0(lVar1,200,DAT_181d8f218);
            FUN_18182a0b0(lVar1,100,DAT_181d8f218);
            plVar2 = (int64 *)(pStatics + 16);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar1,DAT_181d8f098);
            if (lVar1 != null) {
              FUN_18182a0b0(lVar1,10,DAT_181d8f218);
              FUN_18182a0b0(lVar1,4,DAT_181d8f218);
              FUN_18182a0b0(lVar1,2,DAT_181d8f218);
              plVar2 = (int64 *)(pStatics + 24);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

    // Token : 0x6001830
    // RVA   : 0xB064C0   Offset: 0xB058C0   Length: 0x23
    private void <ChangeNextState>b__33_0()
    {
        if (this.startButton != null) {
          GameObject.SetActive(this.startButton,0,0);
          return;
        }
    }

}
