// ============================================================
// Type  : HeroFightScoreListController
// Token : 0x20002C8
// ============================================================

public class HeroFightScoreListController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001714
    public GameObject heroFightScoreListUIPanel;

    // Token: 0x4001715
    public GameObject heroFightScoreListGrid;

    // Token: 0x4001716
    public GameObject heroFightScoreListPrefab;

    // Token: 0x4001717
    private GameObject newObj;

    // Token: 0x4001718
    public List<HeroData> heroFightScoreList;

    // Token: 0x4001719
    private const int FightScoreListNum;

    // Token: 0x400171A
    private const int FightScoreListShowNum;

    // Token: 0x400171B
    private static HeroFightScoreListController _instance;

    // Token: 0x400171C
    private bool initFinished;

    // Token: 0x400171D
    private bool refreshFinished;

    // Token: 0x400171E
    private bool refreshing;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017BF
    // RVA   : 0xAF4330   Offset: 0xAF3730   Length: 0x36
    public static HeroFightScoreListController get_Instance()
    {
        return **(uint64 **)(DAT_181d760d8 + 184);
    }

    // Token : 0x60017C0
    // RVA   : 0xAF2880   Offset: 0xAF1C80   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d760d8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60017C1
    // RVA   : 0xAF40E0   Offset: 0xAF34E0   Length: 0x24F
    private void Update()
    {
        long lVar1;
        ulong uVar2;
        uint local_18;
        uint local_14;
        uint local_10;
        if ((this.initFinished) && (this.refreshFinished)) {
          this.refreshFinished = 0;
          HeroFightScoreListController.RefreshUI(this,0);
          if (this.heroFightScoreListUIPanel != null) {
            lVar1 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Loading",0);
              if (lVar1 != null) {
                lVar1 = Component.get_gameObject(lVar1,0);
                if (lVar1 != null) {
                  GameObject.SetActive(lVar1,0,0);
                  if (this.heroFightScoreListUIPanel != null) {
                    lVar1 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"HeroFightScoreListRoot",0);
                      if (lVar1 != null) {
                        lVar1 = Component.get_gameObject(lVar1,0);
                        if (lVar1 != null) {
                          GameObject.SetActive(lVar1,1,0);
                          if (this.heroFightScoreListUIPanel != null) {
                            lVar1 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"HeroFightScoreListRoot",0);
                              if (lVar1 != null) {
                                lVar1 = Component.get_transform(lVar1,0);
                                if (lVar1 != null) {
                                  local_18 = 0x3f800000;
                                  local_14 = 0;
                                  local_10 = 0x3f800000;
                                  Transform.set_localScale(lVar1,&local_18,0);
                                  if (this.heroFightScoreListUIPanel != null) {
                                    lVar1 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
                                    if (lVar1 != null) {
                                      lVar1 = Transform.Find(lVar1,"HeroFightScoreListRoot",0);
                                      if (lVar1 != null) {
                                        uVar2 = Component.get_transform(lVar1,0);
                                        ShortcutExtensions.DOScaleY(uVar2,0x3f800000,0x3e4ccccd,0);
                                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                                        plVar4 = (int64 *)0;
                                        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf348)) {
                                          plVar4 = plVar3;
                                        }
                                        NGUITools.PlaySound(plVar4,0);
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
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60017C2
    // RVA   : 0xAF3E80   Offset: 0xAF3280   Length: 0x102
    public void ShowHeroFightScoreListUI()
    {
        long lVar1;
        if (this.heroFightScoreListUIPanel != null) {
          GameObject.SetActive(this.heroFightScoreListUIPanel,1,0);
          if (this.heroFightScoreListUIPanel != null) {
            lVar1 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Loading",0);
              if (lVar1 != null) {
                lVar1 = Component.get_gameObject(lVar1,0);
                if (lVar1 != null) {
                  GameObject.SetActive(lVar1,1,0);
                  bVar2 = !DAT_181e9dc51;
                  this.refreshFinished = 0;
                  if (bVar2) {
                    il2cpp_runtime_class_init(&DAT_181d79348);
                    DAT_181e9dc51 = true;
                  }
                  lVar1 = new WarpText_d__8(0,0);
                  if (lVar1 != null) {
                    *(int64 *)(lVar1 + 32) = this;
                    FUN_180d8c2e0(this,lVar1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60017C3
    // RVA   : 0xAF3F90   Offset: 0xAF3390   Length: 0x6C
    public IEnumerator StartShowHeroFightScore()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60017C4
    // RVA   : 0xAF28D0   Offset: 0xAF1CD0   Length: 0x105
    public void HideHeroFightScoreListUI()
    {
        long lVar1;
        if (this.heroFightScoreListUIPanel != null) {
          GameObject.SetActive(this.heroFightScoreListUIPanel,0,0);
          if (this.heroFightScoreListUIPanel != null) {
            lVar1 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"HeroFightScoreListRoot",0);
              if (lVar1 != null) {
                lVar1 = Component.get_gameObject(lVar1,0);
                if (lVar1 != null) {
                  GameObject.SetActive(lVar1,0,0);
                  plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                  plVar3 = (int64 *)0;
                  if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf348)) {
                    plVar3 = plVar2;
                  }
                  NGUITools.PlaySound(plVar3,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60017C5
    // RVA   : 0xAF29E0   Offset: 0xAF1DE0   Length: 0x2F6
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        int[] local_res18 = new int[2];
        local_res18[0] = 0;
        do {
          if (this.heroFightScoreListUIPanel == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.heroFightScoreListUIPanel,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"HeroFightScoreListRoot",0);
          uVar3 = Int32.ToString(local_res18,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,uVar3,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"HeroIconPos",0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = Component.get_gameObject(lVar2,0);
          if (*pStatics == 0) throw; // [null/range check failed]
          uVar1 = *(uint64 *)(*pStatics + 144);
          uVar3 = GlobalData.AddChild(uVar3,uVar1);
          this.newObj = uVar3;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 24) = 0;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent();
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar2 + 40) = 1;
          local_res18[0] = local_res18[0] + 1;
        } while (local_res18[0] < 3);
        iVar4 = 3;
        while( true ) {
          uVar3 = this.heroFightScoreListGrid;
          uVar1 = this.heroFightScoreListPrefab;
          lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
          if (lVar2 == null) break;
          lVar2 = GameObject.get_transform(lVar2,0);
          if (lVar2 == null) break;
          lVar2 = Transform.Find(lVar2,"HeroIconPos");
          if (lVar2 == null) break;
          uVar3 = Component.get_gameObject(lVar2,0);
          lVar2 = FUN_18046c1a0(0);
          if (lVar2 == null) break;
          uVar3 = GlobalData.AddChild(uVar3,*(uint64 *)(lVar2 + 144),0);
          this.newObj = uVar3;
          if (this.newObj == null) break;
          lVar2 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
          if (lVar2 == null) break;
          *(uint32 *)(lVar2 + 24) = 0;
          if (this.newObj == null) break;
          lVar2 = GameObject.GetComponent(this.newObj,DAT_181d71b50);
          if (lVar2 == null) break;
          iVar4 = iVar4 + 1;
          *(uint8 *)(lVar2 + 40) = 1;
          if (99 < iVar4) {
            this.initFinished = 1;
            return;
          }
        }
    }

    // Token : 0x60017C6
    // RVA   : 0xAF3370   Offset: 0xAF2770   Length: 0xB0C
    public void RefreshUI()
    {
        int iVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar9;
        long lVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        uint uVar15;
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        ulong in_stack_ffffffffffffff48;
        ulong local_a8;
        ulong uStack_a0;
        byte[] local_98 = new byte[96];
        local_res20[0] = 0;
        local_res18[0] = 0;
        do {
          uVar13 = (uint32)((uint64)in_stack_ffffffffffffff48 >> 32);
          if ((this.heroFightScoreListUIPanel == null) ||
             (lVar3 = GameObject.get_transform(this.heroFightScoreListUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"HeroFightScoreListRoot",0);
          uVar4 = Int32.ToString(local_res18,0);
          if ((lVar3 == null) ||
             (((lVar3 = Transform.Find(lVar3,uVar4,0), lVar3 == null ||
               (lVar3 = Transform.Find(lVar3,"HeroIconPos",0)) == null) ||
              (lVar3 = Transform.GetChild(lVar3,0,0)) == null))) throw; // [null/range check failed]
          lVar5 = Component.GetComponent(lVar3,DAT_181d940e0);
          lVar3 = this.heroFightScoreList;
          lVar10 = (int64)(int)local_res18[0];
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.Count <= local_res18[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar5 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar5 + 32) = *(uint64 *)(lVar3._items + 32 + lVar10 * 8)
          ;
          il2cpp_internal();
          if ((this.heroFightScoreListUIPanel == null) ||
             (lVar3 = GameObject.get_transform(this.heroFightScoreListUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"HeroFightScoreListRoot",0);
          uVar4 = Int32.ToString(local_res18,0);
          if ((((lVar3 == null) ||
               ((lVar3 = Transform.Find(lVar3,uVar4,0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"HeroIconPos",0)) == null))) ||
              (lVar3 = Transform.GetChild(lVar3,0,0)) == null) ||
             (lVar3 = Component.GetComponent(lVar3,DAT_181d940e0)) == null) throw; // [null/range check failed]
          HeroIconController.Init(lVar3,0);
          if ((this.heroFightScoreListUIPanel == null) ||
             (lVar3 = GameObject.get_transform(this.heroFightScoreListUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"HeroFightScoreListRoot",0);
          uVar4 = Int32.ToString(local_res18,0);
          if ((lVar3 == null) ||
             ((lVar3 = Transform.Find(lVar3,uVar4,0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"Score",0)) == null))) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          lVar3 = this.heroFightScoreList;
          lVar5 = (int64)(int)local_res18[0];
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.Count <= local_res18[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar3._items + 32 + lVar5 * 8);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar6 = Single.ToString(lVar3 + 0x3d4,"f0",0);
          uVar6 = String.Format("战力\n<b>{0}</b>",uVar6,0);
          LTLocalization.SetText(uVar4,uVar6,0);
          if ((this.heroFightScoreListUIPanel == null) ||
             (lVar3 = GameObject.get_transform(this.heroFightScoreListUIPanel,0)) == null)
          throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"HeroFightScoreListRoot",0);
          uVar4 = Int32.ToString(local_res18,0);
          if ((lVar3 == null) ||
             ((lVar3 = Transform.Find(lVar3,uVar4,0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"ColorBack",0)) == null))) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d94460);
          if ((this.heroFightScoreList == null) ||
             (lVar3 = FUN_180002f80(this.heroFightScoreList,local_res18[0],DAT_181d8bb98),
             lVar3 == null)) throw; // [null/range check failed]
          local_a8 = 0;
          uStack_a0 = 0;
          in_stack_ffffffffffffff48 = CONCAT44(uVar13,0x3f4ccccd);
          if (*(int *)(lVar3 + 88) == 0) {
            uVar15 = 0x3ee0e0e1;
            uVar14 = 0x3f4bcbcc;
            uVar13 = 0x3f69e9ea;
          }
          else {
            uVar15 = 0x3f800000;
            uVar14 = 0x3f800000;
            uVar13 = 0x3f800000;
          }
          FUN_1809dc910(&local_a8,uVar13,uVar14,uVar15,in_stack_ffffffffffffff48,0);
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar7 + 0x2a8))(plVar7);
          local_res18[0] = local_res18[0] + 1;
        } while ((int)local_res18[0] < 3);
        lVar3 = 56;
        iVar2 = 0;
        do {
          if ((((this.heroFightScoreListGrid == null) ||
               (lVar5 = GameObject.get_transform(this.heroFightScoreListGrid,0)) == null) ||
              (lVar5 = Transform.GetChild(lVar5,iVar2,0)) == null) ||
             ((lVar5 = Transform.Find(lVar5,"HeroIconPos",0), lVar5 == null ||
              (lVar5 = Transform.GetChild(lVar5,0,0)) == null))) throw; // [null/range check failed]
          lVar10 = Component.GetComponent(lVar5,DAT_181d940e0);
          lVar5 = this.heroFightScoreList;
          if (lVar5 == null) throw; // [null/range check failed]
          uVar11 = iVar2 + 3;
          if (lVar5.Count <= uVar11) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar10 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar10 + 32) = *(uint64 *)(lVar3 + lVar5._items);
          if (((this.heroFightScoreListGrid == null) ||
              (lVar5 = GameObject.get_transform(this.heroFightScoreListGrid,0)) == null) ||
             ((lVar5 = Transform.GetChild(lVar5,iVar2,0), lVar5 == null ||
              (((lVar5 = Transform.Find(lVar5,"HeroIconPos",0), lVar5 == null ||
                (lVar5 = Transform.GetChild(lVar5,0,0)) == null) ||
               (lVar5 = Component.GetComponent(lVar5,DAT_181d940e0)) == null))))) throw; // [null/range check failed]
          HeroIconController.Init(lVar5,0);
          if (((this.heroFightScoreListGrid == null) ||
              (lVar5 = GameObject.get_transform(this.heroFightScoreListGrid,0)) == null) ||
             ((lVar5 = Transform.GetChild(lVar5,iVar2,0), lVar5 == null ||
              (lVar5 = Transform.Find(lVar5,"Num",0)) == null))) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar5,DAT_181d96160);
          local_res20[0] = iVar2 + 4;
          uVar6 = Int32.ToString(local_res20,0);
          LTLocalization.SetText(uVar4,uVar6,0);
          if ((((this.heroFightScoreListGrid == null) ||
               (lVar5 = GameObject.get_transform(this.heroFightScoreListGrid,0)) == null) ||
              (lVar5 = Transform.GetChild(lVar5,iVar2,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Name",0)) == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar5,DAT_181d96160);
          if (this.heroFightScoreList == null) throw; // [null/range check failed]
          lVar5 = FUN_180002f80(this.heroFightScoreList,uVar11,DAT_181d8bb98);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar6 = HeroData.HeroName(lVar5,1,0);
          LTLocalization.SetText(uVar4,uVar6,0);
          if (((this.heroFightScoreListGrid == null) ||
              (lVar5 = GameObject.get_transform(this.heroFightScoreListGrid,0)) == null) ||
             ((lVar5 = Transform.GetChild(lVar5,iVar2,0), lVar5 == null ||
              (lVar5 = Transform.Find(lVar5,"Score",0)) == null))) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar5,DAT_181d96160);
          if ((this.heroFightScoreList == null) ||
             (lVar5 = FUN_180002f80(this.heroFightScoreList,uVar11,DAT_181d8bb98)) == null)
          throw; // [null/range check failed]
          uVar6 = Single.ToString(lVar5 + 0x3d4,"f0",0);
          LTLocalization.SetText(uVar4,uVar6,0);
          if ((this.heroFightScoreListGrid == null) ||
             ((lVar5 = GameObject.get_transform(this.heroFightScoreListGrid,0), lVar5 == null ||
              (lVar5 = Transform.GetChild(lVar5,iVar2,0)) == null))) throw; // [null/range check failed]
          plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d94460);
          if ((this.heroFightScoreList == null) ||
             (lVar5 = FUN_180002f80(this.heroFightScoreList,uVar11,DAT_181d8bb98)) == null)
          throw; // [null/range check failed]
          if (*(int *)(lVar5 + 88) == 0) {
            local_a8 = 0;
            uStack_a0 = 0;
            Color.ctor(&local_a8,0x3f69e9ea,0x3f4bcbcc,0x3ee0e0e1,0);
            uVar13 = (uint32)local_a8;
            uVar14 = local_a8._4_4_;
            uVar15 = (uint32)uStack_a0;
            uVar12 = uStack_a0._4_4_;
          }
          else {
            puVar8 = (uint32 *)FUN_1810d3570(local_98,0);
            uVar13 = *puVar8;
            uVar14 = puVar8[1];
            uVar15 = puVar8[2];
            uVar12 = puVar8[3];
          }
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          local_a8 = CONCAT44(uVar14,uVar13);
          uStack_a0 = CONCAT44(uVar12,uVar15);
          (**(code **)(*plVar7 + 0x2a8))(plVar7);
          lVar3 = lVar3 + 8;
          iVar1 = iVar2 + 4;
          iVar2 = iVar2 + 1;
        } while (iVar1 < 100);
        lVar3 = this.heroFightScoreList;
        lVar5 = FUN_18046c0a0(0);
        if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
           (uVar4 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar3 != null)) {
          iVar2 = FUN_1817eb4e0(lVar3,uVar4,DAT_181d8b798);
          if (((this.heroFightScoreListUIPanel != null) &&
              (lVar3 = GameObject.get_transform(this.heroFightScoreListUIPanel,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"HeroFightScoreListRoot",0), lVar3 != null &&
              (lVar3 = Transform.Find(lVar3,"PlayerNumText",0)) != null))) {
            uVar9 = Component.GetComponent(lVar3,DAT_181d96160);
            uVar4 = "你的排名 ";
            uVar6 = "500+";
            if (-1 < iVar2) {
              local_res20[0] = iVar2 + 1;
              uVar6 = Int32.ToString(local_res20,0);
            }
            uVar4 = String.Concat(uVar4,uVar6,0);
            LTLocalization.SetText(uVar9,uVar4,0);
            if (iVar2 == 0) {
              lVar3 = FUN_18046c100(0);
              if (lVar3 == null) throw; // [null/range check failed]
              GameDataController.ChangeAchStats(lVar3,20,0x3f800000);
            }
            return;
          }
        }
    }

    // Token : 0x60017C7
    // RVA   : 0xAF2CE0   Offset: 0xAF20E0   Length: 0x680
    public void RefreshHeroFightScoreList()
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        int iVar7;
        if (this.heroFightScoreList != null) {
          FUN_1812f9a10(this.heroFightScoreList,DAT_181d8b618);
          lVar3 = this.heroFightScoreList;
          if (((GameController._instance != null) &&
              (lVar4 = GameController._instance.worldData) != null) &&
             (lVar4 = lVar4.Heros) != null) {
            if (lVar4.cityAreaID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar3 != null) {
              FUN_18181e0a0(lVar3,*(uint64 *)(lVar4.chapter + 32),DAT_181d8b518);
              iVar7 = 1;
        LAB_180af2e70:
              do {
                if (((GameController._instance == null) ||
                    (lVar3 = GameController._instance.worldData) == null) ||
                   (lVar3 = lVar3.Heros) == null) break;
                if (lVar3.Count <= iVar7) {
                  return;
                }
                lVar3 = FUN_18046c0a0(0);
                if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                   (lVar3 = *(int64 *)(lVar3.villageAreaID + 80)) == null) break;
                lVar3 = FUN_180002f80(lVar3,iVar7,DAT_181d8bb98);
                if (lVar3 != null) {
                  lVar3 = FUN_18046c0a0(0);
                  if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                     (lVar3 = *(int64 *)(lVar3.villageAreaID + 80)) == null) break;
                  lVar3 = FUN_180002f80(lVar3,iVar7,DAT_181d8bb98);
                  if (lVar3 == null) break;
                  if (!lVar3.BigMapRandomEventDatas) {
                    lVar3 = FUN_18046c0a0(0);
                    if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                       (lVar3 = *(int64 *)(lVar3.villageAreaID + 80)) == null) break;
                    lVar3 = FUN_180002f80(lVar3,iVar7,DAT_181d8bb98);
                    if (lVar3 == null) break;
                    if (*(char *)(lVar3 + 97) == false) {
                      lVar3 = FUN_18046c0a0(0);
                      if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                         (lVar3 = *(int64 *)(lVar3.villageAreaID + 80)) == null) break;
                      lVar3 = FUN_180002f80(lVar3,iVar7,DAT_181d8bb98);
                      if (lVar3 == null) break;
                      cVar2 = FUN_18171e540(lVar3.AreaMapRandomEventDatas,"白云天",0);
                      if (cVar2) {
                        lVar3 = FUN_18046c0a0(0);
                        if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                           (lVar3 = *(int64 *)(lVar3.villageAreaID + 216)) == null) break;
                        cVar2 = FUN_1808ab490(lVar3,1000,DAT_181dbf7d8);
                        if (!cVar2) goto LAB_180af333a;
                      }
                      lVar3 = FUN_18046c0a0(0);
                      if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                         (lVar3 = *(int64 *)(lVar3.villageAreaID + 80)) == null) break;
                      lVar3 = FUN_180002f80(lVar3,iVar7,DAT_181d8bb98);
                      if (lVar3 == null) break;
                      HeroData.CheckHeroDetailDirty(lVar3,0,0);
                      iVar6 = 0;
                      while( true ) {
                        lVar3 = this.heroFightScoreList;
                        if (lVar3 == null) throw; // [null/range check failed]
                        if (lVar3.Count <= iVar6) {
                          if (499 < lVar3.Count) goto LAB_180af333a;
                          lVar4 = FUN_18046c0a0(0);
                          if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                             (lVar4 = *(int64 *)(lVar4.villageAreaID + 80)) == null)
                          throw; // [null/range check failed]
                          uVar5 = FUN_180002f80(lVar4,iVar7,DAT_181d8bb98);
                          FUN_18181e0a0(lVar3,uVar5,DAT_181d8b518);
                          goto LAB_180af333a;
                        }
                        lVar3 = FUN_18046c0a0(0);
                        if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                           (lVar3 = *(int64 *)(lVar3.villageAreaID + 80)) == null)
                        throw; // [null/range check failed]
                        lVar3 = FUN_180002f80(lVar3,iVar7,DAT_181d8bb98);
                        if (lVar3 == null) throw; // [null/range check failed]
                        fVar1 = *(float *)(lVar3 + 0x3d4);
                        if (this.heroFightScoreList == null) throw; // [null/range check failed]
                        lVar3 = FUN_180002f80(this.heroFightScoreList,iVar6,DAT_181d8bb98);
                        if (lVar3 == null) throw; // [null/range check failed]
                        if (*(float *)(lVar3 + 0x3d4) <= fVar1 && fVar1 != *(float *)(lVar3 + 0x3d4))
                        break;
                        iVar6 = iVar6 + 1;
                      }
                      lVar3 = this.heroFightScoreList;
                      lVar4 = FUN_18046c0a0(0);
                      if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                         (lVar4 = *(int64 *)(lVar4.villageAreaID + 80)) == null) break;
                      uVar5 = FUN_180002f80(lVar4,iVar7,DAT_181d8bb98);
                      if (lVar3 == null) break;
                      FUN_181822520(lVar3,iVar6,uVar5,DAT_181d8b818);
                      lVar3 = this.heroFightScoreList;
                      if (lVar3 == null) break;
                      if (500 < lVar3.Count) {
                        FUN_181823590(lVar3,lVar3.Count + -1,DAT_181d8b998);
                        iVar7 = iVar7 + 1;
                        goto LAB_180af2e70;
                      }
                    }
                  }
                }
        LAB_180af333a:
                iVar7 = iVar7 + 1;
              } while( true );
            }
          }
        }
    }

    // Token : 0x60017C8
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60017C9
    // RVA   : 0xAF4000   Offset: 0xAF3400   Length: 0xD2
    private void <StartShowHeroFightScore>b__16_0()
    {
        HeroFightScoreListController.RefreshHeroFightScoreList(this,0);
        this.refreshFinished = 1;
    }

}
