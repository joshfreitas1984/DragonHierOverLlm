// ============================================================
// Type  : ManageTagController
// Token : 0x2000301
// ============================================================

public class ManageTagController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018BA
    public GameObject manageTagUIPanel;

    // Token: 0x40018BB
    public HeroData targetHero;

    // Token: 0x40018BC
    public GameObject selfTagList;

    // Token: 0x40018BD
    public List<GameObject> allTagList;

    // Token: 0x40018BE
    public bool useMoney;

    // Token: 0x40018BF
    private GameObject newObj;

    // Token: 0x40018C0
    private static ManageTagController _instance;

    // Token: 0x40018C1
    public static List<string> availableCategory;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018E6
    // RVA   : 0xA8CC50   Offset: 0xA8C050   Length: 0x57
    public static ManageTagController get_Instance()
    {
        return **(uint64 **)(DAT_181d87a18 + 184);
    }

    // Token : 0x60018E7
    // RVA   : 0xA8ACA0   Offset: 0xA8A0A0   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d87a18 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60018E8
    // RVA   : 0xA8C400   Offset: 0xA8B800   Length: 0x175
    private void Start()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        int[] local_res18 = new int[4];
        iVar4 = 0;
        while( true ) {
          local_res18[0] = iVar4;
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d87a18 + 184) + 8);
          if (lVar1 == null) break;
          if (lVar1.Count <= iVar4) {
            return;
          }
          lVar1 = this.allTagList;
          if (this.manageTagUIPanel == null) break;
          lVar2 = GameObject.get_transform(this.manageTagUIPanel,0);
          uVar3 = Int32.ToString(local_res18,0);
          uVar3 = String.Concat("TagList",uVar3,0);
          if (lVar2 == null) break;
          lVar2 = Transform.Find(lVar2,uVar3,0);
          if (lVar2 == null) break;
          lVar2 = Transform.Find(lVar2,"Viewport",0);
          if (lVar2 == null) break;
          lVar2 = Transform.Find(lVar2,"Content",0);
          if (lVar2 == null) break;
          Component.get_gameObject(lVar2,0);
          if (lVar1 == null) break;
          FUN_18181e0a0(lVar1);
          iVar4 = local_res18[0] + 1;
        }
    }

    // Token : 0x60018E9
    // RVA   : 0xA8BC80   Offset: 0xA8B080   Length: 0x166
    public void HideManageTagUI()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        if (this.manageTagUIPanel != null) {
          GameObject.SetActive(this.manageTagUIPanel,0,0);
          if (((this.manageTagUIPanel != null) &&
              (lVar1 = GameObject.get_transform(this.manageTagUIPanel,0)) != null) &&
             (lVar1 = Transform.Find(lVar1,"TargetHero",0)) != null) {
            uVar2 = Component.get_gameObject(lVar1,0);
            GlobalData.DeleteAllChild(uVar2,0);
            lVar1 = this.allTagList;
            uVar4 = 0;
            if (lVar1 != null) {
              lVar3 = 32;
              do {
                if (lVar1.Count <= (int)uVar4) {
                  return;
                }
                if (lVar1 == null) break;
                if (lVar1.Count <= uVar4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar2 = *(uint64 *)(lVar3 + lVar1._items);
                GlobalData.DeleteAllChild(uVar2,0);
                lVar1 = this.allTagList;
                uVar4 = uVar4 + 1;
                lVar3 = lVar3 + 8;
              } while (lVar1 != null);
            }
          }
        }
    }

    // Token : 0x60018EA
    // RVA   : 0xA8BDF0   Offset: 0xA8B1F0   Length: 0x60C
    public void ShowManageTagUI(HeroData _targetHero, bool _useMoney)
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_7a18 = *(int64*)(DAT_181d87a18 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        int64 local_48;
        uint32 local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        int64 local_30;
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
        plVar9 = (int64 *)0;
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
          plVar9 = plVar5;
        }
        NGUITools.PlaySound(plVar9,0);
        if (this.manageTagUIPanel != null) {
          GameObject.SetActive(this.manageTagUIPanel,1,0);
          this.targetHero = _targetHero;
          this.useMoney = _useMoney;
          if (this.manageTagUIPanel != null) {
            lVar6 = GameObject.get_transform(this.manageTagUIPanel,0);
            if (lVar6 != null) {
              lVar6 = Transform.Find(lVar6,"TargetHero",0);
              if (lVar6 != null) {
                uVar7 = Component.get_gameObject(lVar6,0);
                if (*pStatics_2ee8 != 0) {
                  uVar1 = *(uint64 *)(*pStatics_2ee8 + 144);
                  uVar7 = GlobalData.AddChild(uVar7,uVar1,0);
                  this.newObj = uVar7;
                  if (this.newObj != null) {
                    lVar6 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
                    if (lVar6 != null) {
                      *(uint64 *)(lVar6 + 32) = this.targetHero;
                      if (this.newObj != null) {
                        lVar6 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
                        if (lVar6 != null) {
                          *(uint32 *)(lVar6 + 24) = 2;
                          if (this.newObj != null) {
                            lVar6 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
                            if (lVar6 != null) {
                              HeroIconController.AutoSetName(lVar6,0);
                              lVar6 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
                              if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 0x198)) != null) {
                                lVar6 = FUN_1808ae5b0(lVar6,DAT_181dba4a8);
                                if (lVar6 != null) {
                                  ValueCollection.GetEnumerator(&local_40,lVar6,DAT_181d7e7e8);
                                  local_58 = local_40;
                                  uStack_54 = uStack_3c;
                                  uStack_50 = uStack_38;
                                  uStack_4c = uStack_34;
                                  local_48 = local_30;
                                  while( true ) {
                                    do {
                                      cVar3 = FUN_1811c3f80(&local_58,DAT_181d988d8);
                                      lVar6 = local_48;
                                      if (!cVar3) {
                                        ZhSegment.Initialize(&local_58,DAT_181d98858);
                                        ManageTagController.FreshManageTagUI(this,0);
                                        return;
                                      }
                                      lVar8 = *(int64 *)(pStatics_7a18 + 8);
                                      if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      cVar3 = FUN_18181e400(lVar8,*(uint64 *)(lVar6 + 80),
                                                            DAT_181da3e58);
                                    } while (!cVar3);
                                    lVar8 = this.allTagList;
                                    lVar2 = *(int64 *)(pStatics_7a18 + 8);
                                    if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    uVar4 = FUN_1817eb4e0(lVar2,*(uint64 *)(lVar6 + 80),
                                                          DAT_181da3fd8);
                                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    uVar7 = FUN_180002f80(lVar8,uVar4,DAT_181d89918);
                                    lVar8 = FUN_18046c1a0(0);
                                    if (lVar8 == null) break;
                                    uVar1 = *(uint64 *)(lVar8 + 200);
                                    uVar7 = GlobalData.AddChild(uVar7,uVar1,0);
                                    this.newObj = uVar7;
                                    if (this.newObj == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    lVar8 = GameObject.GetComponent
                                                      (this.newObj,DAT_181d71ce8);
                                    uVar4 = *(uint32 *)(lVar6 + 16);
                                    uVar7 = new HeroTagData(uVar4,0xbf800000,0,0);
                                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    *(uint64 *)(lVar8 + 32) = uVar7;
                                    if (this.newObj == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    lVar6 = GameObject.GetComponent
                                                      (this.newObj,DAT_181d71ce8);
                                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    *(uint32 *)(lVar6 + 24) = 1;
                                  }
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
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

    // Token : 0x60018EB
    // RVA   : 0xA8B280   Offset: 0xA8A680   Length: 0x9F6
    public void FreshManageTagUI()
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        long lVar9;
        ulong uVar11;
        ulong uVar12;
        long lVar14;
        uint uVar15;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (((this.manageTagUIPanel != null) &&
            (lVar9 = GameObject.get_transform(this.manageTagUIPanel,0)) != null) &&
           (lVar9 = Transform.Find(lVar9,"TagPointNum",0)) != null) {
          plVar10 = (int64 *)Component.GetComponent(lVar9,DAT_181d96160);
          if (this.targetHero != null) {
            uVar11 = Single.ToString(this.targetHero + 0x364,"0.##",0);
            uVar11 = String.Concat("天赋点 ",uVar11,0);
            uVar11 = LTLocalization.GetText(uVar11,0,1,0);
            if (plVar10 != (int64 *)0) {
              (**(code **)(*plVar10 + 0x5e8))(plVar10,uVar11,*(uint64 *)(*plVar10 + 0x5f0));
              LTLocalization.CheckTextFont(plVar10,0);
              if (((this.manageTagUIPanel != null) &&
                  (lVar9 = GameObject.get_transform(this.manageTagUIPanel,0)) != null) &&
                 (lVar9 = Transform.Find(lVar9,"TagNum",0)) != null) {
                plVar10 = (int64 *)Component.GetComponent(lVar9,DAT_181d96160);
                if (this.targetHero != null) {
                  local_res8[0] = HeroData.GetHeroPermanentTagNum(this.targetHero,0);
                  uVar11 = il2cpp_value_box(DAT_181d80418,local_res8);
                  if (this.targetHero != null) {
                    local_res18[0] = HeroData.GetMaxTagNum(this.targetHero,0);
                    uVar12 = il2cpp_value_box(DAT_181d80418,local_res18);
                    uVar11 = String.Format("{0}/{1}",uVar11,uVar12,0);
                    uVar11 = LTLocalization.GetText(uVar11,0,1,0);
                    if (plVar10 != (int64 *)0) {
                      (**(code **)(*plVar10 + 0x5e8))(plVar10,uVar11,*(uint64 *)(*plVar10 + 0x5f0));
                      LTLocalization.CheckTextFont(plVar10,0);
                      if (((this.manageTagUIPanel != null) &&
                          (lVar9 = GameObject.get_transform(this.manageTagUIPanel,0)) != null
                          ) && (lVar9 = Transform.Find(lVar9,"TagNum",0)) != null) {
                        plVar10 = (int64 *)Component.GetComponent(lVar9,DAT_181d96160);
                        if (this.targetHero != null) {
                          iVar4 = HeroData.GetHeroPermanentTagNum(this.targetHero,0);
                          if (this.targetHero != null) {
                            iVar5 = HeroData.GetMaxTagNum(this.targetHero,0);
                            if (iVar4 < iVar5) {
                              puVar13 = (uint32 *)Color.get_black(&local_38,0);
                            }
                            else {
                              puVar13 = (uint32 *)Color.get_red();
                            }
                            if (plVar10 != (int64 *)0) {
                              local_38 = *puVar13;
                              uStack_34 = puVar13[1];
                              uStack_30 = puVar13[2];
                              uStack_2c = puVar13[3];
                              (**(code **)(*plVar10 + 0x2a8))
                                        (plVar10,&local_38,*(uint64 *)(*plVar10 + 0x2b0));
                              uVar11 = this.selfTagList;
                              GlobalData.DeleteAllChild(uVar11);
                              lVar9 = this.targetHero;
                              uVar15 = 0;
                              if (lVar9 != null) {
                                lVar14 = 32;
                                do {
                                  if (lVar9.heroTagData == null) break;
                                  if (*(int *)(lVar9.heroTagData + 24) <= (int)uVar15) {
                                    iVar4 = 0;
                                    while( true ) {
                                      lVar9 = *(int64 *)(*(int64 *)(DAT_181d87a18 + 184) + 8);
                                      if (lVar9 == null) break;
                                      if (lVar9.summonLv <= iVar4) {
                                        return;
                                      }
                                      iVar5 = 0;
        LAB_180a8b860:
                                      if (((this.allTagList == null) ||
                                          (lVar9 = FUN_180002f80(this.allTagList,iVar4,
                                                                 DAT_181d89918), lVar9 == null)) ||
                                         (lVar9 = GameObject.get_transform(lVar9,0)) == null) break;
                                      iVar6 = Transform.get_childCount(lVar9,0);
                                      if (iVar5 < iVar6) {
                                        if (((this.allTagList != null) &&
                                            (lVar9 = FUN_180002f80(this.allTagList,iVar4,
                                                                   DAT_181d89918), lVar9 != null)) &&
                                           ((lVar9 = GameObject.get_transform(lVar9,0), lVar9 != null &&
                                            (lVar9 = Transform.GetChild(lVar9,iVar5,0)) != null))) {
                                          lVar9 = Component.GetComponent(lVar9,DAT_181d94160);
                                          if (this.targetHero != null) {
                                            iVar6 = HeroData.GetHeroPermanentTagNum
                                                              (this.targetHero,0);
                                            if (this.targetHero != null) {
                                              iVar7 = HeroData.GetMaxTagNum
                                                                (this.targetHero,0);
                                              if (iVar6 < iVar7) {
        LAB_180a8b97e:
                                                iVar6 = 0;
                                                do {
                                                  lVar14 = this.targetHero;
                                                  if ((lVar14 == null) ||
                                                     (lVar1 = lVar14.heroTagData) == null)
                                                  goto LAB_180a8bc6b;
                                                  if (*(int *)(lVar1 + 24) <= iVar6) {
                                                    if ((lVar9 == null) || (lVar9.summonControlable == null)
                                                       ) goto LAB_180a8bc6b;
                                                    uVar11 = HeroTagData.DataBase
                                                                       (lVar9.summonControlable,0);
                                                    uVar3 = ManageTagController.CheckMeetCondition
                                                                      (this,lVar14,uVar11,0);
                                                    goto LAB_180a8bbcc;
                                                  }
                                                  if ((lVar9 == null) || (lVar9.summonControlable == null))
                                                  goto LAB_180a8bc6b;
                                                  iVar7 = *(int *)(lVar9.summonControlable + 16);
                                                  lVar14 = FUN_180002f80(lVar1,iVar6,DAT_181d8c718);
                                                  if (lVar14 == null) goto LAB_180a8bc6b;
                                                  if (iVar7 == lVar14.isSummon)
                                                  goto LAB_180a8bb96;
                                                  if ((lVar9.summonControlable == null) ||
                                                     (lVar14 = HeroTagData.DataBase
                                                                         (lVar9.summonControlable,0),
                                                     lVar14 == null)) goto LAB_180a8bc6b;
                                                  cVar2 = String.op_Inequality
                                                                    (lVar14.summonSourceHero,
                                                                     "",0);
                                                  if (cVar2) {
                                                    if ((((this.targetHero == null) ||
                                                         (lVar14 = *(int64 *)
                                                                    (this.targetHero + 0x368
                                                                    ), lVar14 == null)) ||
                                                        (lVar14 = FUN_180002f80(lVar14,iVar6,DAT_181d8c718
                                                                               ), lVar14 == null)) ||
                                                       (lVar14 = HeroTagData.DataBase(lVar14,0),
                                                       lVar14 == null)) goto LAB_180a8bc6b;
                                                    uVar11 = lVar14.interestingStar;
                                                    if ((lVar9.summonControlable == null) ||
                                                       (lVar14 = HeroTagData.DataBase
                                                                           (lVar9.summonControlable,0)
                                                       , lVar14 == null)) goto LAB_180a8bc6b;
                                                    cVar2 = FUN_18171e540(uVar11,*(uint64 *)
                                                                                  (lVar14 + 40),0);
                                                    if (cVar2) goto LAB_180a8bb96;
                                                    if (((this.targetHero == null) ||
                                                        (lVar14 = *(int64 *)
                                                                   (this.targetHero + 0x368)
                                                        , lVar14 == null)) ||
                                                       ((lVar14 = FUN_180002f80(lVar14,iVar6,DAT_181d8c718
                                                                               ), lVar14 == null ||
                                                        (lVar14 = HeroTagData.DataBase(lVar14,0),
                                                        lVar14 == null)))) goto LAB_180a8bc6b;
                                                    uVar11 = lVar14.summonSourceHero;
                                                    if ((lVar9.summonControlable == null) ||
                                                       (lVar14 = HeroTagData.DataBase
                                                                           (lVar9.summonControlable,0)
                                                       , lVar14 == null)) goto LAB_180a8bc6b;
                                                    cVar2 = FUN_18171e540(uVar11,*(uint64 *)
                                                                                  (lVar14 + 40),0);
                                                    if (cVar2) {
                                                      if ((((this.targetHero == null) ||
                                                           (lVar14 = *(int64 *)
                                                                      (this.targetHero +
                                                                      0x368), lVar14 == null)) ||
                                                          (lVar14 = FUN_180002f80(lVar14,iVar6,
                                                                                  DAT_181d8c718),
                                                          lVar14 == null)) ||
                                                         (lVar14 = HeroTagData.DataBase(lVar14,0),
                                                         lVar14 == null)) goto LAB_180a8bc6b;
                                                      iVar7 = Mathf.Abs(lVar14.summonControlable);
                                                      if ((lVar9.summonControlable == null) ||
                                                         (lVar14 = HeroTagData.DataBase
                                                                             (lVar9.summonControlable,
                                                                              0), lVar14 == null))
                                                      goto LAB_180a8bc6b;
                                                      iVar8 = Mathf.Abs(lVar14.summonControlable);
                                                      if (iVar8 <= iVar7) goto LAB_180a8bb96;
                                                    }
                                                  }
                                                  iVar6 = iVar6 + 1;
                                                } while( true );
                                              }
                                              if (((lVar9 != null) && (lVar9.summonControlable != null)) &&
                                                 ((lVar14 = HeroTagData.DataBase
                                                                      (lVar9.summonControlable,0),
                                                  lVar14 != null && (lVar14.heroAIDataArriveTargetRecord != null)))) {
                                                iVar6 = *(int *)(lVar14.heroAIDataArriveTargetRecord + 24);
                                                uVar3 = 0 < iVar6;
                                                if (0 < iVar6) goto LAB_180a8b97e;
                                                goto LAB_180a8bbcc;
                                              }
                                            }
                                          }
                                        }
                                        break;
                                      }
                                      iVar4 = iVar4 + 1;
                                    }
                                    break;
                                  }
                                  if ((lVar9 = lVar9?.heroTagData) == null)
                                  break;
                                  if (lVar9.summonLv <= uVar15) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  lVar9 = *(int64 *)(lVar14 + lVar9.isSummon);
                                  if (lVar9 == null) break;
                                  cVar2 = HeroTagData.IsPermanentTag(lVar9,0);
                                  if (cVar2) {
                                    uVar11 = this.selfTagList;
                                    lVar9 = FUN_18046c1a0(0);
                                    if (lVar9 == null) break;
                                    uVar12 = lVar9.bigMapPos;
                                    uVar11 = GlobalData.AddChild(uVar11,uVar12,0);
                                    this.newObj = uVar11;
                                    if (this.newObj == null) break;
                                    lVar9 = GameObject.GetComponent
                                                      (this.newObj,DAT_181d71ce8);
                                    if (((this.targetHero == null) ||
                                        (lVar1 = this.targetHero.heroTagData,
                                        lVar1 == null)) || (uVar11 = FUN_180002f80(lVar1,uVar15), lVar9 == null)
                                       ) break;
                                    lVar9.summonControlable = uVar11;
                                  }
                                  lVar9 = this.targetHero;
                                  uVar15 = uVar15 + 1;
                                  lVar14 = lVar14 + 8;
                                } while (lVar9 != null);
                              }
                            }
        LAB_180a8bc6b:
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
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
        LAB_180a8bb96:
        uVar3 = 0;
        LAB_180a8bbcc:
        if (((this.allTagList == null) ||
            (lVar14 = FUN_180002f80(this.allTagList,iVar4,DAT_181d89918)) == null) ||
           ((lVar14 = GameObject.get_transform(lVar14,0), lVar14 == null ||
            ((lVar14 = Transform.GetChild(lVar14,iVar5,0), lVar14 == null ||
             (lVar14 = Component.GetComponent(lVar14,DAT_181d93760)) == null)))))
        goto LAB_180a8bc6b;
        Selectable.set_interactable(lVar14,uVar3,0);
        HeroTagIconController.RefreshInfo(lVar9,0);
        iVar5 = iVar5 + 1;
        goto LAB_180a8b860;
    }

    // Token : 0x60018EC
    // RVA   : 0xA8AD10   Offset: 0xA8A110   Length: 0xD3
    public bool CheckMeetCondition(HeroData checkHero, HeroTagDataBase targetTag)
    {
        uint64 ManageTagController.CheckMeetCondition
                          (uint64 this,int64 checkHero,int64 targetTag)
        {
        uint32 uVar1;
        int64 lVar2;
        uint64 uVar3;
        uint32 uVar4;
        int64 lVar5;
        float extraout_XMM0_Da;
        if ((targetTag != null) && (uVar3 = HeroTagDataBase.GetCostValue(targetTag,0,0), checkHero != null)) {
          if (*(float *)(checkHero + 0x364) <= extraout_XMM0_Da &&
              extraout_XMM0_Da != *(float *)(checkHero + 0x364)) {
        LAB_180a8adda:
            return uVar3 & 0xffffffffffffff00;
          }
          uVar4 = 0;
          lVar5 = 32;
          while (lVar2 = *(int64 *)(targetTag + 64)) != null {
            uVar1 = *(uint32 *)(lVar2 + 24);
            if ((int)uVar1 <= (int)uVar4) {
              return CONCAT71((uint7)(uint3)(uVar1 >> 8),1);
            }
            if (uVar1 <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = ManageTagController.CheckMeetOneCondition
                              (this,checkHero,*(uint64 *)(lVar5 + *(int64 *)(lVar2 + 16)),0);
            if ((char)!uVar3) goto LAB_180a8adda;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
          }
        }
    }

    // Token : 0x60018ED
    // RVA   : 0xA8ADF0   Offset: 0xA8A1F0   Length: 0x480
    public bool CheckMeetOneCondition(HeroData checkHero, string requirement)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        uint64
        ManageTagController.CheckMeetOneCondition(uint64 this,int64 checkHero,int64 requirement)
        {
        float *pfVar1;
        char cVar2;
        uint32 uVar3;
        uint64 uVar4;
        uint64 uVar5;
        int64 lVar6;
        int64 lVar7;
        float fVar8;
        if (requirement == null) goto LAB_180a8b26b;
        cVar2 = String.Contains(requirement,"天赋:",0);
        if (cVar2) {
          uVar4 = String.Replace(requirement,"天赋:","",0);
          uVar3 = 0;
          if (checkHero != null) {
            lVar7 = 32;
            while (lVar6 = *(int64 *)(checkHero + 0x368)) != null {
              if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar3) goto LAB_180a8b1c0;
              if (*(uint32 *)(lVar6 + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(lVar7 + *(int64 *)(lVar6 + 16));
              if (lVar6 == null) break;
              lVar6 = HeroTagData.DataBase(lVar6,0);
              if (lVar6 == null) break;
              cVar2 = FUN_18171e540(*(uint64 *)(lVar6 + 24),uVar4,0);
              if (cVar2) goto LAB_180a8b264;
              uVar3 = uVar3 + 1;
              lVar7 = lVar7 + 8;
            }
          }
          goto LAB_180a8b26b;
        }
        uVar4 = Regex.Replace(requirement,"[^\\u4e00-\\u9fa5]","",0);
        uVar5 = Regex.Replace(requirement,"[\\u4e00-\\u9fa5]","",0);
        fVar8 = (float)Single.Parse(uVar5,0);
        lVar7 = *(int64 *)(pStatics + 0x498);
        if (lVar7 == null) goto LAB_180a8b26b;
        cVar2 = FUN_18181e400(lVar7,uVar4,DAT_181da3e58);
        if (!cVar2) {
        LAB_180a8b00a:
          lVar7 = *(int64 *)(pStatics + 0x4a0);
          if (lVar7 == null) goto LAB_180a8b26b;
          cVar2 = FUN_18181e400(lVar7,uVar4,DAT_181da3e58);
          if (cVar2) {
            if (checkHero == null) goto LAB_180a8b26b;
            lVar7 = *(int64 *)(checkHero + 0x140);
            lVar6 = *(int64 *)(pStatics + 0x4a0);
            if (lVar6 == null) goto LAB_180a8b26b;
            uVar3 = FUN_1817eb4e0(lVar6,uVar4,DAT_181da3fd8);
            if (lVar7 == null) goto LAB_180a8b26b;
            if (*(uint32 *)(lVar7 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            pfVar1 = (float *)(*(int64 *)(lVar7 + 16) + 32 + (int64)(int)uVar3 * 4);
            if (*pfVar1 <= fVar8 && fVar8 != *pfVar1) goto LAB_180a8b1c0;
          }
          lVar7 = *(int64 *)(pStatics + 0x4b0);
          if (lVar7 == null) goto LAB_180a8b26b;
          cVar2 = FUN_18181e400(lVar7,uVar4,DAT_181da3e58);
          if (cVar2) {
            if (checkHero == null) {
        LAB_180a8b26b:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = *(int64 *)(checkHero + 0x158);
            lVar6 = *(int64 *)(pStatics + 0x4b0);
            if (lVar6 == null) goto LAB_180a8b26b;
            uVar3 = FUN_1817eb4e0(lVar6,uVar4,DAT_181da3fd8);
            if (lVar7 == null) goto LAB_180a8b26b;
            if (*(uint32 *)(lVar7 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            pfVar1 = (float *)(*(int64 *)(lVar7 + 16) + 32 + (int64)(int)uVar3 * 4);
            if (*pfVar1 <= fVar8 && fVar8 != *pfVar1) goto LAB_180a8b1c0;
          }
        LAB_180a8b264:
          uVar4 = 1;
        }
        else {
          if (checkHero == null) goto LAB_180a8b26b;
          lVar7 = *(int64 *)(checkHero + 0x128);
          lVar6 = *(int64 *)(pStatics + 0x498);
          if (lVar6 == null) goto LAB_180a8b26b;
          uVar3 = FUN_1817eb4e0(lVar6,uVar4,DAT_181da3fd8);
          if (lVar7 == null) goto LAB_180a8b26b;
          if (*(uint32 *)(lVar7 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          pfVar1 = (float *)(*(int64 *)(lVar7 + 16) + 32 + (int64)(int)uVar3 * 4);
          if (fVar8 < *pfVar1 || fVar8 == *pfVar1) goto LAB_180a8b00a;
        LAB_180a8b1c0:
          uVar4 = 0;
        }
        return uVar4;
    }

    // Token : 0x60018EE
    // RVA   : 0xA8C580   Offset: 0xA8B980   Length: 0x33D
    public void SureUnderstandTag(string tagIDString)
    {
        long lVar1;
        uint uVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        if (this.targetHero != null) {
          if (this.targetHero.heroID != null) {
            ManageTagController.UnderstandTag(this,tagIDString,0);
            return;
          }
          lVar5 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
          uVar2 = Int32.Parse(tagIDString,0);
          if (lVar5 != null) {
            lVar5 = GameDataController.GetTagDataBase(lVar5,uVar2,0);
            if (this.useMoney) {
              if (((this.targetHero == null) ||
                  (lVar1 = this.targetHero.itemListData) == null) ||
                 (iVar4 = lVar1.summonLv, lVar5 == null)) throw; // [null/range check failed]
              iVar3 = HeroTagDataBase.GetCostMoney(lVar5,0);
              if (iVar4 < iVar3) {
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 != null) {
                  GameController.ShowTextOnMouse(lVar5,"银钱不足！",0);
                  plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                  plVar8 = (int64 *)0;
                  if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
                    plVar8 = plVar7;
                  }
                  NGUITools.PlaySound(plVar8,0);
                  return;
                }
                throw; // [null/range check failed]
              }
              lVar1 = this.targetHero;
              iVar4 = HeroTagDataBase.GetCostMoney(lVar5,0);
              if (lVar1 == null) throw; // [null/range check failed]
              HeroData.ChangeMoney(lVar1,-iVar4,1,0);
            }
            lVar1 = *(int64 *)(*(int64 *)(DAT_181db5de8 + 184) + 8);
            if (lVar5 != null) {
              uVar6 = String.Format("领悟{0}",*(uint64 *)(lVar5 + 24),0);
              uVar2 = HeroTagDataBase.GetCostTime(lVar5,0);
              if (lVar1 != null) {
                WorkingUIController.StartWorking(lVar1,uVar6,uVar2,0,0,"FinishUnderstandTag",tagIDString,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60018EF
    // RVA   : 0xA8C8C0   Offset: 0xA8BCC0   Length: 0x1FA
    public void UnderstandTag(string tagIDString)
    {
        var pStatics = *(int64*)(DAT_181d72d50 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        uint uVar4;
        lVar1 = this.targetHero;
        lVar3 = *(int64 *)(pStatics + 32);
        uVar2 = Int32.Parse(tagIDString,0);
        if (lVar3 != null) {
          lVar3 = GameDataController.GetTagDataBase(lVar3,uVar2,0);
          if (lVar3 != null) {
            uVar4 = HeroTagDataBase.GetCostValue(lVar3,0,0);
            if (lVar1 != null) {
              HeroData.ChangeTagPoint(lVar1,uVar4 ^ 0x80000000,1,0);
              lVar1 = this.targetHero;
              uVar2 = Int32.Parse(tagIDString,0);
              if (lVar1 != null) {
                HeroData.UnderstandTag(lVar1,uVar2,1,0);
                ManageTagController.FreshManageTagUI(this,0);
                if (this.targetHero != null) {
                  if (this.targetHero.heroID == null) {
                    lVar1 = *(int64 *)(pStatics + 32);
                    if (lVar1 == null) throw; // [null/range check failed]
                    GameDataController.ChangeAchStats(lVar1,12,0x3f800000);
                  }
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60018F0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60018F1
    // RVA   : 0xA8CAC0   Offset: 0xA8BEC0   Length: 0x186
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"武学",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"高级",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"技艺",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"天生",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"志向",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"喜好",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"战法",DAT_181da3d58);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d87a18 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
