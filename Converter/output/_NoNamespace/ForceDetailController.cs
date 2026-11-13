// ============================================================
// Type  : ForceDetailController
// Token : 0x2000291
// ============================================================

public class ForceDetailController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014A9
    public GameObject forceDetailPanel;

    // Token: 0x40014AA
    public GameObject forceDetailTabGrid;

    // Token: 0x40014AB
    public GameObject forceDetailTabPrefab;

    // Token: 0x40014AC
    public GameObject forceDetail;

    // Token: 0x40014AD
    public GameObject forceSkillGrid;

    // Token: 0x40014AE
    public GameObject forceHeroGrid;

    // Token: 0x40014AF
    public int nowShowForceID;

    // Token: 0x40014B0
    public Text baseDetailText;

    // Token: 0x40014B1
    public Text areaText;

    // Token: 0x40014B2
    public Text detailText;

    // Token: 0x40014B3
    public Text favorText;

    // Token: 0x40014B4
    public bool inited;

    // Token: 0x40014B5
    private static ForceDetailController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001510
    // RVA   : 0x8FE360   Offset: 0x8FD160   Length: 0x36
    public static ForceDetailController get_Instance()
    {
        return **(uint64 **)(DAT_181e50a28 + 184);
    }

    // Token : 0x6001511
    // RVA   : 0x8FACD0   Offset: 0x8F9AD0   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e50a28 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e50a28 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001512
    // RVA   : 0x8FAF50   Offset: 0x8F9D50   Length: 0x434
    public void InitForceDetailTab()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        int64 local_28;
        uint32 local_20;
        uint32 uStack_1c;
        uint32 uStack_18;
        uint32 uStack_14;
        int64 local_10;
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.Forces) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_1816629a0(&local_38,lVar6,DAT_181e6a378);
        local_20 = local_38;
        uStack_1c = uStack_34;
        uStack_18 = uStack_30;
        uStack_14 = uStack_2c;
        local_10 = local_28;
        while( true ) {
          do {
            do {
              cVar2 = FUN_1807b3f30(&local_20,DAT_181e6e0c0);
              lVar6 = local_10;
              if (!cVar2) {
                ZhSegment.Initialize(&local_20,DAT_181e6e040);
                return;
              }
              uVar4 = this.forceDetailTabGrid;
              uVar1 = this.forceDetailTabPrefab;
              lVar3 = GlobalData.AddChild(uVar4,uVar1,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar4 = Int32.ToString(lVar6 + 16,0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              Object.set_name(lVar3,uVar4);
              lVar5 = GameObject.GetComponent(lVar3,DAT_181e547d8);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              *(uint32 *)(lVar5 + 24) = lVar6.chapter;
            } while (PlotController.fightSkillIndexCache != 1);
            lVar5 = PlotController.LeftFaceHideOffset;
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = FUN_18176a2d0(lVar5,lVar6.chapter);
          } while (cVar2);
          lVar6 = GameObject.GetComponent(lVar3,DAT_181e53cb0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          Selectable.set_interactable(lVar6,0,0);
          lVar6 = GameObject.get_transform(lVar3,0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar6 = Transform.Find(lVar6,"Name",0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar4 = Component.GetComponent(lVar6,DAT_181e79538);
          LTLocalization.SetText(uVar4,"???",0);
          lVar6 = GameObject.get_transform(lVar3,0);
          if (lVar6 == null) break;
          lVar6 = Transform.Find(lVar6,"Icon",0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          puVar8 = (uint32 *)Color.get_black(&local_38,0);
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_48 = *puVar8;
          uStack_44 = puVar8[1];
          uStack_40 = puVar8[2];
          uStack_3c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_48);
        }
    }

    // Token : 0x6001513
    // RVA   : 0x8FB6B0   Offset: 0x8FA4B0   Length: 0xBF7
    public void RefreshForceDetailTab()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar7;
        long lVar8;
        float fVar9;
        int[] local_res18 = new int[4];
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        int64 local_58;
        uint32 local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        int64 local_40;
        local_res18[0] = 0;
        if (((GameController._instance == null) ||
            (lVar8 = GameController._instance.worldData) == null) ||
           (lVar8 = lVar8.Forces) == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_1816629a0(&local_68,lVar8,DAT_181e6a378);
        local_50 = local_68;
        uStack_4c = uStack_64;
        uStack_48 = uStack_60;
        uStack_44 = uStack_5c;
        local_40 = local_58;
        LAB_1808fb860:
        do {
          cVar1 = FUN_1807b3f30(&local_50,DAT_181e6e0c0);
          lVar8 = local_40;
          if (!cVar1) {
            ZhSegment.Initialize(&local_50,DAT_181e6e040);
            return;
          }
          if (this.forceDetailTabGrid == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = GameObject.get_transform(this.forceDetailTabGrid,0);
          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar3 = Int32.ToString(lVar8 + 16,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = Transform.Find(lVar2,uVar3,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = Component.get_transform(lVar2,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = Transform.Find(lVar4,"Name",0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar3 = Component.GetComponent(lVar4,DAT_181e79538);
          cVar1 = FUN_180ad1200(lVar8.totalBadFame,0);
          if (!cVar1) {
            uVar7 = lVar8.totalBadFame;
          }
          else {
            uVar7 = lVar8.cityAreaID;
          }
          LTLocalization.SetText(uVar3,uVar7);
          lVar4 = Component.get_transform(lVar2,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = Transform.Find(lVar4,"Icon",0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = Component.GetComponent(lVar4,DAT_181e777b8);
          uVar3 = ForceData.GetForceIcon(lVar8,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          Image.set_sprite(lVar4,uVar3);
          lVar4 = FUN_1802106e0(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int *)(lVar4 + 132) == lVar8.chapter) {
            lVar4 = Transform.Find(lVar2,"SelfForce",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar1) {
              lVar4 = Transform.Find(lVar2,"SelfForce",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar3 = 1;
              goto LAB_1808fba82;
            }
          }
          else {
            lVar4 = Transform.Find(lVar2,"SelfForce",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (cVar1) {
              lVar4 = Transform.Find(lVar2,"SelfForce",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar3 = 0;
        LAB_1808fba82:
              GameObject.SetActive(lVar4,uVar3);
            }
          }
          lVar4 = FUN_1802106e0(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = HeroData.HaveForce(lVar4,0);
          if (!cVar1) {
        LAB_1808fc006:
            lVar4 = Transform.Find(lVar2,"Favor",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (cVar1) {
              lVar4 = Transform.Find(lVar2,"Favor",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              GameObject.SetActive(lVar4,0);
            }
          }
          else {
            lVar4 = FUN_1802106e0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int *)(lVar4 + 132) == lVar8.chapter) goto LAB_1808fc006;
            lVar4 = Transform.Find(lVar2,"Favor",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar1) {
              lVar4 = Transform.Find(lVar2,"Favor",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              GameObject.SetActive(lVar4,1,0);
            }
            lVar4 = Transform.Find(lVar2,"Favor",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = Transform.Find(lVar4,"Icon",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
            lVar4 = FUN_1802106e0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            ForceData.GetForceFavor(lVar8,*(uint32 *)(lVar4 + 132),0);
            puVar6 = (uint32 *)GlobalData.GetForceFavorLvColor(&local_68);
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_78 = *puVar6;
            uStack_74 = puVar6[1];
            uStack_70 = puVar6[2];
            uStack_6c = puVar6[3];
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_78);
            lVar4 = Transform.Find(lVar2,"Favor");
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = Transform.Find(lVar4,"Text");
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar3 = Component.GetComponent(lVar4,DAT_181e79538);
            lVar4 = FUN_1802106e0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            fVar9 = (float)ForceData.GetForceFavor(lVar8,*(uint32 *)(lVar4 + 132));
            local_res18[0] = (int)fVar9;
            uVar7 = Int32.ToString(local_res18,0);
            LTLocalization.SetText(uVar3,uVar7);
          }
          lVar4 = FUN_1802106e0(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = HeroData.HaveForce(lVar4,0);
          if (cVar1) {
            lVar4 = FUN_1802106e0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int *)(lVar4 + 132) != lVar8.chapter) {
              lVar4 = FUN_1802106e0(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar4 = HeroData.GetForce(lVar4,0,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar8 = ForceData.GetForceRelationshipText(lVar4,lVar8.chapter,1,0);
              if (lVar8 != null) {
                lVar4 = Transform.Find(lVar2,"Relation");
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar4 = Component.get_gameObject(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                cVar1 = GameObject.get_activeSelf(lVar4,0);
                if (!cVar1) {
                  lVar4 = Transform.Find(lVar2,"Relation");
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar4 = Component.get_gameObject(lVar4,0);
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  GameObject.SetActive(lVar4,1);
                }
                lVar2 = Transform.Find(lVar2,"Relation");
                if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
                LTLocalization.SetText(uVar3,lVar8);
                goto LAB_1808fb860;
              }
            }
          }
          lVar8 = Transform.Find(lVar2,"Relation");
          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar8 = Component.get_gameObject(lVar8,0);
          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          cVar1 = GameObject.get_activeSelf(lVar8,0);
          if (cVar1) {
            lVar8 = Transform.Find(lVar2,"Relation");
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar8 = Component.get_gameObject(lVar8,0);
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SetActive(lVar8,0);
          }
        } while( true );
    }

    // Token : 0x6001514
    // RVA   : 0x8FB390   Offset: 0x8FA190   Length: 0x315
    public void OpenForceDetail()
    {
        long lVar1;
        ulong uVar5;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (!this.inited) {
          this.inited = 1;
          ForceDetailController.InitForceDetailTab(this,0);
        }
        ForceDetailController.RefreshForceDetailTab(this,0);
        if (this.forceDetailPanel != null) {
          GameObject.SetActive(this.forceDetailPanel,1,0);
          if (this.forceDetailPanel != null) {
            lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
                if (this.forceDetailPanel != null) {
                  lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                    if (lVar1 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
                      if (plVar3 != (int64 *)0) {
                        puVar4 = (uint64 *)
                                 (**(code **)(*plVar3 + 0x298))
                                           (&local_38,plVar3,*(uint64 *)(*plVar3 + 0x2a0));
                        local_38 = *puVar4;
                        uStack_30 = puVar4[1];
                        puVar4 = (uint64 *)GlobalData.SetColorAlpha(local_28,&local_38,0,0);
                        if (plVar2 != (int64 *)0) {
                          local_38 = *puVar4;
                          uStack_30 = puVar4[1];
                          (**(code **)(*plVar2 + 0x2a8))
                                    (plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
                          if (this.forceDetailPanel != null) {
                            lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                              if (lVar1 != null) {
                                uVar5 = Component.GetComponent(lVar1,DAT_181e777b8);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea5848);
                                if (this.forceDetailPanel != null) {
                                  lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                                  if (lVar1 != null) {
                                    lVar1 = Transform.Find(lVar1,"ForceDetailRoot",0);
                                    if (lVar1 != null) {
                                      local_38 = 0x3f80000000000000;
                                      uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                                      Transform.set_localScale(lVar1,&local_38,0);
                                      if (this.forceDetailPanel != null) {
                                        lVar1 = GameObject.get_transform(this.forceDetailPanel,0)
                                        ;
                                        if (lVar1 != null) {
                                          uVar5 = Transform.Find(lVar1,"ForceDetailRoot",0);
                                          uVar5 = ShortcutExtensions.DOScaleX
                                                            (uVar5,0x3f800000,0x3e800000,0);
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea59e0);
                                          if (this.forceDetail != null) {
                                            GameObject.SetActive(this.forceDetail,0,0);
                                            this.nowShowForceID = 0xffffffff;
                                            ForceDetailController.RefreshForceTab(this,0);
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
        }
    }

    // Token : 0x6001515
    // RVA   : 0x8FADB0   Offset: 0x8F9BB0   Length: 0x194
    public void HideForceDetail()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.forceDetailPanel != null) {
          lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BlackBackground",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181e777b8);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea5848);
              if (this.forceDetailPanel != null) {
                lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"ForceDetailRoot",0);
                  uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea59e0);
                  uVar3 = new OnTooltipCB(this,DAT_181ea4938,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3dc0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001516
    // RVA   : 0x8FC4D0   Offset: 0x8FB2D0   Length: 0x37
    public void ResetForceDetail()
    {
        if (this.forceDetail != null) {
          GameObject.SetActive(this.forceDetail,0,0);
          this.nowShowForceID = 0xffffffff;
          ForceDetailController.RefreshForceTab(this,0);
          return;
        }
    }

    // Token : 0x6001517
    // RVA   : 0x8FC2B0   Offset: 0x8FB0B0   Length: 0x21B
    public void RefreshForceTab()
    {
        long lVar1;
        int iVar2;
        long lVar3;
        int iVar5;
        byte[] local_18 = new byte[16];
        lVar3 = this.forceDetailTabGrid;
        iVar5 = 0;
        if (lVar3 != null) {
          while (lVar3 = GameObject.get_transform(lVar3,0)) != null {
            iVar2 = Transform.get_childCount(lVar3,0);
            if (iVar2 <= iVar5) {
              return;
            }
            if ((((this.forceDetailTabGrid == null) ||
                 (lVar3 = GameObject.get_transform(this.forceDetailTabGrid,0)) == null) ||
                (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) ||
               (lVar3 = Component.GetComponent(lVar3,DAT_181e77238)) == null) break;
            lVar1 = this.forceDetailTabGrid;
            if (*(int *)(lVar3 + 24) == this.nowShowForceID) {
              if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
              if (plVar4 == (int64 *)0) break;
              (**(code **)(*plVar4 + 0x2a8))(plVar4);
            }
            else {
              if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
              FUN_180f24d00(local_18,0);
              if (plVar4 == (int64 *)0) break;
              (**(code **)(*plVar4 + 0x2a8))(plVar4);
            }
            lVar3 = this.forceDetailTabGrid;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6001518
    // RVA   : 0x8FC510   Offset: 0x8FB310   Length: 0x1E49
    public void ShowForceDetail(int targetForceID)
    {
        var plVar4 = lVar4.forceMeetingStarted;
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        long lVar12;
        int iVar14;
        uint uVar15;
        uint uVar16;
        uint[] local_res20 = new uint[2];
        uint[] local_a8 = new uint[2];
        ulong local_a0;
        ulong uStack_98;
        long local_90;
        long local_80;
        long local_78;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        int64 local_58;
        local_78 = this;
        local_a8[0] = 0;
        local_res20[0] = 0;
        local_a0 = 0;
        uStack_98 = 0;
        local_90 = 0;
        if (this.nowShowForceID == targetForceID) {
          return;
        }
        this.nowShowForceID = targetForceID;
        ForceDetailController.RefreshForceTab(this,0);
        if (this.forceDetail != null) {
          GameObject.SetActive(this.forceDetail,1);
          if ((GameController._instance != null) &&
             (lVar4 = GameController._instance.worldData) != null) {
            lVar4 = WorldData.GetForce(lVar4,targetForceID);
            local_80 = lVar4;
            if ((this.forceDetail != null) &&
               (((lVar5 = GameObject.get_transform(this.forceDetail,0), lVar5 != null &&
                 (lVar5 = Transform.Find(lVar5,"ForceName")) != null) &&
                (uVar6 = Component.GetComponent(lVar5,DAT_181e79538), lVar4 != null)))) {
              cVar2 = FUN_180ad1200(lVar4.totalBadFame,0);
              if (!cVar2) {
                uVar9 = lVar4.totalBadFame;
              }
              else {
                uVar9 = lVar4.cityAreaID;
              }
              LTLocalization.SetText(uVar6,uVar9);
              uVar6 = this.baseDetailText;
              plVar7 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
              if (plVar7 != (int64 *)0) {
                if (("等级 " != 0) &&
                   (lVar5 = il2cpp_internal("等级 ",*(uint64 *)(*plVar7 + 64)), lVar5 == null
                   )) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                lVar5 = "等级 ";
                if ((int)plVar7[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar7[4] = "等级 ";
                il2cpp_internal(plVar7 + 4,lVar5);
                uVar3 = *(uint32 *)(lVar4 + 52);
                lVar5 = GlobalData.GetNumText(uVar3,0);
                if ((lVar5 != null) &&
                   (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                if (*(uint32 *)(plVar7 + 3) < 2) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar7[5] = lVar5;
                il2cpp_internal(plVar7 + 5,lVar5);
                if (("\n风格 " != 0) &&
                   (lVar5 = il2cpp_internal("\n风格 ",*(uint64 *)(*plVar7 + 64)), lVar5 == null
                   )) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                lVar5 = "\n风格 ";
                if (*(uint32 *)(plVar7 + 3) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar7[6] = "\n风格 ";
                il2cpp_internal(plVar7 + 6,lVar5);
                lVar5 = lVar4.forceAreaID;
                if ((lVar5 != null) &&
                   (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                if (*(uint32 *)(plVar7 + 3) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar7[7] = lVar5;
                il2cpp_internal(plVar7 + 7,lVar5);
                if (("\n专长 " != 0) &&
                   (lVar5 = il2cpp_internal("\n专长 ",*(uint64 *)(*plVar7 + 64)), lVar5 == null
                   )) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                lVar5 = "\n专长 ";
                if (*(uint32 *)(plVar7 + 3) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                plVar7[8] = "\n专长 ";
                il2cpp_internal(plVar7 + 8,lVar5);
                uVar9 = String.Concat(plVar7,0);
                LTLocalization.SetText(uVar6,uVar9);
                uVar6 = this.baseDetailText;
                iVar14 = 0;
                lVar5 = lVar4.worldPlotEventStartData;
                lVar8 = "";
                while (lVar5 != null) {
                  if (*(int *)(lVar5 + 24) <= iVar14) {
                    LTLocalization.AddText(uVar6,lVar8,0);
                    uVar16 = 0;
                    uVar15 = uVar16;
                    goto LAB_1808fcbf0;
                  }
                  lVar12 = "/";
                  if (iVar14 == 0) {
                    lVar12 = "";
                  }
                  if (((*(byte *)(DAT_181e538e8 + 0x133) & 4) != 0) &&
                     (*(int *)(DAT_181e538e8 + 224) == 0)) {
                    il2cpp_runtime_class_init(DAT_181e538e8);
                    lVar5 = lVar4.worldPlotEventStartData;
                  }
                  lVar1 = *(int64 *)(pStatics_38e8 + 0x4a8);
                  if ((lVar5 == null) || (uVar3 = FUN_180002480(lVar5,iVar14,DAT_181e71bf0), lVar1 == null))
                  break;
                  uVar9 = FUN_1800024b0(lVar1,uVar3,DAT_181e86970);
                  lVar8 = String.Concat(lVar8,lVar12,uVar9);
                  iVar14 = iVar14 + 1;
                  lVar5 = lVar4.worldPlotEventStartData;
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        LAB_1808fcbf0:
        lVar5 = lVar4.worldPlotEventStartTime;
        if (lVar5 == null) throw; // [null/range check failed]
        uVar6 = this.baseDetailText;
        if (*(int *)(lVar5 + 24) <= (int)uVar15) {
          lVar5 = *(int64 *)(pStatics_38e8 + 0x4d8);
          lVar8 = lVar4.tutorialFinished;
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar15 = Mathf.RoundToInt(*(uint32 *)(*(int64 *)(lVar8 + 16) + 32),0);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar5 + 24) <= uVar15) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar9 = String.Concat("\n喜好物品 ",
                                 *(uint64 *)
                                  (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar15 * 8),0);
          LTLocalization.AddText(uVar6,uVar9,0);
          if (0 < *(int *)(lVar4 + 0x17c)) {
            uVar6 = this.baseDetailText;
            lVar5 = FUN_180210740(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 224) == 0)) ||
               (lVar5 = FUN_18171b450(*(int64 *)(lVar5 + 224),*(uint32 *)(lVar4 + 0x17c),
                                      DAT_181e98c78), lVar5 == null)) throw; // [null/range check failed]
            uVar9 = *(uint64 *)(lVar5 + 24);
            lVar5 = FUN_1802106e0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x180)) == null)
            throw; // [null/range check failed]
            cVar2 = FUN_18176a2d0(lVar5,*(uint32 *)(lVar4 + 0x17c),DAT_181e71570);
            uVar11 = "\n特殊建筑 {0}({1}</color>)";
            uVar10 = "<color=grey>未解锁";
            if (cVar2) {
              uVar10 = String.Concat(*(uint64 *)(pStatics_38e8 + 0x270),
                                      "已解锁",0);
            }
            uVar9 = String.Format(uVar11,uVar9,uVar10,0);
            LTLocalization.AddText(uVar6,uVar9,0);
          }
          uVar6 = this.baseDetailText;
          if (lVar4.BigMapRandomEventDatas != null) {
            local_a8[0] = *(uint32 *)(lVar4.BigMapRandomEventDatas + 24);
            uVar9 = Int32.ToString(local_a8,0);
            if (lVar4.monthBreakEquipTime != null) {
              local_res20[0] = ForceSpeAddData.Get(lVar4.monthBreakEquipTime,0,0);
              uVar11 = Single.ToString(local_res20,0);
              uVar9 = String.Concat("\n\n区域 ",uVar9,"/",uVar11,0);
              LTLocalization.AddText(uVar6,uVar9,0);
              uVar6 = this.baseDetailText;
              uVar9 = Int32.ToString(lVar4 + 132,0);
              if (lVar4.monthBreakEquipTime != null) {
                local_res20[0] = ForceSpeAddData.Get(lVar4.monthBreakEquipTime,1);
                uVar11 = Single.ToString(local_res20,0);
                uVar9 = String.Concat("\n弟子 ",uVar9,"/",uVar11,0);
                LTLocalization.AddText(uVar6,uVar9,0);
                uVar15 = uVar16;
                goto LAB_1808fd010;
              }
            }
          }
          throw; // [null/range check failed]
        }
        if (((*(byte *)(DAT_181e538e8 + 0x133) & 4) != 0) && (*(int *)(DAT_181e538e8 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181e538e8);
          lVar5 = lVar4.worldPlotEventStartTime;
        }
        lVar8 = *(int64 *)(pStatics_38e8 + 0x4b8);
        if ((lVar5 == null) || (uVar3 = FUN_180002480(lVar5,uVar15,DAT_181e71bf0), lVar8 == null))
        throw; // [null/range check failed]
        uVar9 = FUN_1800024b0(lVar8,uVar3);
        String.Concat("/",uVar9);
        LTLocalization.AddText(uVar6);
        uVar15 = uVar15 + 1;
        goto LAB_1808fcbf0;
        LAB_1808fd010:
        if (lVar4.WorldNewsDatas == null) throw; // [null/range check failed]
        if (*(int *)(lVar4.WorldNewsDatas + 24) <= (int)uVar15) {
          lVar5 = FUN_1802106e0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar5 + 32) + 156) == 1) {
            lVar5 = *(int64 *)(pStatics_38e8 + 0x3b0);
            if (lVar5 == null) throw; // [null/range check failed]
            cVar2 = FUN_18176a2d0(lVar5,targetForceID,DAT_181e71570);
            if (!cVar2) {
              uVar6 = this.baseDetailText;
              lVar5 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
              if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 208)) == null) ||
                 (lVar5 = FUN_18171b450(lVar5,lVar4.chapter,DAT_181e9ad50)) == null)
              throw; // [null/range check failed]
              uVar9 = *(uint64 *)(lVar5 + 0x180);
              uVar9 = String.Format("\n\n<b>门派特性</b>\n{1}{0}</color>",uVar9,
                                     *(uint64 *)(pStatics_38e8 + 0x260),0);
              LTLocalization.AddText(uVar6,uVar9,0);
            }
          }
          uVar6 = this.areaText;
          LTLocalization.SetText(uVar6,"",0);
          lVar5 = 32;
          goto LAB_1808fd610;
        }
        uVar6 = this.baseDetailText;
        plVar7 = (int64 *)FUN_1801dfd90(DAT_181e85e38,9);
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        if (("\n" != 0) &&
           (lVar5 = il2cpp_internal("\n",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar5 = "\n";
        if ((int)plVar7[3] == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[4] = "\n";
        il2cpp_internal(plVar7 + 4,lVar5);
        lVar5 = *(int64 *)(pStatics_38e8 + 0x440);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar5 = FUN_1800024b0(lVar5,uVar15,DAT_181e86970);
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 2) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[5] = lVar5;
        il2cpp_internal(plVar7 + 5,lVar5);
        if ((" " != 0) &&
           (lVar5 = il2cpp_internal(" ",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar5 = " ";
        if (*(uint32 *)(plVar7 + 3) < 3) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[6] = " ";
        il2cpp_internal(plVar7 + 6,lVar5);
        if (lVar4.WorldNewsDatas == null) throw; // [null/range check failed]
        local_res20[0] = FUN_1800024e0(lVar4.WorldNewsDatas,uVar15,DAT_181e83530);
        lVar5 = Single.ToString(local_res20,"f0",0);
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 4) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[7] = lVar5;
        il2cpp_internal(plVar7 + 7,lVar5);
        if (("/" != 0) &&
           (lVar5 = il2cpp_internal("/",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar5 = "/";
        if (*(uint32 *)(plVar7 + 3) < 5) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[8] = "/";
        il2cpp_internal(plVar7 + 8,lVar5);
        if (lVar4.MailDatas == null) throw; // [null/range check failed]
        local_res20[0] = FUN_1800024e0(lVar4.MailDatas,uVar15,DAT_181e83530);
        lVar5 = Single.ToString(local_res20,"f0",0);
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 6) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[9] = lVar5;
        il2cpp_internal(plVar7 + 9,lVar5);
        if ((" (" != 0) &&
           (lVar5 = il2cpp_internal(" (",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar5 = " (";
        if (*(uint32 *)(plVar7 + 3) < 7) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[10] = " (";
        il2cpp_internal(plVar7 + 10,lVar5);
        if (lVar4.cheating == null) throw; // [null/range check failed]
        local_res20[0] = FUN_1800024e0(lVar4.cheating,uVar15);
        lVar5 = Single.ToString(local_res20,"+0;-0;0");
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 8) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[11] = lVar5;
        il2cpp_internal(plVar7 + 11,lVar5);
        if ((")" != 0) &&
           (lVar5 = il2cpp_internal(")",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        lVar5 = ")";
        if (*(uint32 *)(plVar7 + 3) < 9) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar6,0);
        }
        plVar7[12] = ")";
        il2cpp_internal(plVar7 + 12,lVar5);
        uVar9 = String.Concat(plVar7,0);
        LTLocalization.AddText(uVar6,uVar9);
        uVar15 = uVar15 + 1;
        goto LAB_1808fd010;
        LAB_1808fd610:
        lVar8 = lVar4.BigMapRandomEventDatas;
        if (lVar8 == null) throw; // [null/range check failed]
        if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar16) {
          iVar14 = 0;
          goto LAB_1808fd750;
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar16) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int *)(lVar5 + *(int64 *)(lVar8 + 16)) != lVar4.Inns) {
          plVar7 = this.areaText;
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          uVar6 = (**(code **)(*plVar7 + 0x5d8))(plVar7,*(uint64 *)(*plVar7 + 0x5e0));
          cVar2 = FUN_1816387f0(uVar6,"",0);
          lVar8 = "\n";
          if (cVar2) {
            lVar8 = "";
          }
          lVar12 = FUN_1802106e0(0);
          if (lVar12 == null) throw; // [null/range check failed]
          lVar12 = *(int64 *)(lVar12 + 32);
          if (((lVar4.BigMapRandomEventDatas == null) ||
              (uVar3 = FUN_180002480(lVar4.BigMapRandomEventDatas,uVar16), lVar12 == null)) ||
             (lVar12 = WorldData.GetArea(lVar12,uVar3)) == null) throw; // [null/range check failed]
          uVar6 = AreaData.GetAreaName(lVar12,0);
          uVar6 = String.Concat(lVar8,uVar6);
          LTLocalization.AddText(plVar7,uVar6);
        }
        uVar16 = uVar16 + 1;
        lVar5 = lVar5 + 4;
        goto LAB_1808fd610;
        LAB_1808fd750:
        if (lVar4.AreaMapRandomEventDatas == null) throw; // [null/range check failed]
        if (*(int *)(lVar4.AreaMapRandomEventDatas + 24) <= iVar14) {
          uVar6 = this.favorText;
          LTLocalization.SetText(uVar6,"",0);
          lVar5 = FUN_1802106e0(0);
          if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
             (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 72)) != null) {
            FUN_1816629a0(&local_68,lVar5,DAT_181e6a378);
            local_a0 = CONCAT44(uStack_64,local_68);
            uStack_98 = CONCAT44(uStack_5c,uStack_60);
            local_90 = local_58;
            goto LAB_1808fd910;
          }
          throw; // [null/range check failed]
        }
        plVar7 = this.areaText;
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        uVar6 = (**(code **)(*plVar7 + 0x5d8))(plVar7,*(uint64 *)(*plVar7 + 0x5e0));
        cVar2 = FUN_1816387f0(uVar6,"",0);
        lVar5 = "\n";
        if (cVar2) {
          lVar5 = "";
        }
        lVar8 = FUN_1802106e0(0);
        if (lVar8 == null) throw; // [null/range check failed]
        lVar8 = *(int64 *)(lVar8 + 32);
        if (((lVar4.AreaMapRandomEventDatas == null) ||
            (uVar3 = FUN_180002480(lVar4.AreaMapRandomEventDatas,iVar14), lVar8 == null)) ||
           (lVar8 = WorldData.GetResourcePoint(lVar8,uVar3)) == null) throw; // [null/range check failed]
        uVar6 = ResourcePointData.GetResourcePointFullName(lVar8,0);
        uVar6 = String.Concat(lVar5,uVar6);
        LTLocalization.AddText(plVar7,uVar6);
        iVar14 = iVar14 + 1;
        goto LAB_1808fd750;
        joined_r0x0001808fdf18:
        iVar14 = iVar14 + -1;
        if (iVar14 < 0) {
          uVar6 = this.forceSkillGrid;
          GlobalData.SortChild(uVar6,0);
          return;
        }
        uVar6 = this.forceSkillGrid;
        if (*pStatics_2a90 == 0) throw; // [null/range check failed]
        uVar9 = *(uint64 *)(*pStatics_2a90 + 160);
        lVar5 = GlobalData.AddChild(uVar6,uVar9,0);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar8 = GameObject.GetComponent(lVar5,DAT_181e55168);
        if ((plVar4 == 0) ||
           (lVar12 = *(int64 *)(plVar4 + 48)) == null) throw; // [null/range check failed]
        if (*(uint32 *)(lVar12 + 24) < 4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar12 = *(int64 *)(*(int64 *)(lVar12 + 16) + 56);
        if ((lVar12 == null) || (uVar6 = FUN_1800024b0(lVar12,iVar14), lVar8 == null)) throw; // [null/range check failed]
        *(uint64 *)(lVar8 + 32) = uVar6;
        lVar8 = GameObject.GetComponent(lVar5,DAT_181e55168);
        if (lVar8 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar8 + 40) = 1;
        lVar5 = GameObject.GetComponent(lVar5,DAT_181e55168);
        if (lVar5 == null) throw; // [null/range check failed]
        ItemIconController.AutoSetName(lVar5,1);
        goto joined_r0x0001808fdf18;
        LAB_1808fd910:
        cVar2 = FUN_1807b3f30(&local_a0,DAT_181e6e0c0);
        lVar5 = local_90;
        if (cVar2) {
          if (local_90 != lVar4) {
            uVar6 = this.favorText;
            plVar13 = (int64 *)FUN_1801dfd90(DAT_181e85e38,8);
            plVar7 = this.favorText;
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar9 = (**(code **)(*plVar7 + 0x5d8))(plVar7,*(uint64 *)(*plVar7 + 0x5e0));
            cVar2 = FUN_1816387f0(uVar9,"",0);
            lVar8 = "\n";
            if (cVar2) {
              lVar8 = "";
            }
            if (plVar13 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            FUN_1800025b0(plVar13,0,lVar8);
            if (PlotController.fightSkillIndexCache == 1) {
              lVar8 = PlotController.LeftFaceHideOffset;
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              cVar2 = FUN_18176a2d0(lVar8,*(uint32 *)(lVar5 + 16),DAT_181e71570);
              lVar8 = "???";
              if (!(cVar2))
              {
                }
                else {
                if (lVar5 == null) {
                // WARNING: Subroutine does not return
                FUN_1801e0300();
                }
              }
              cVar2 = FUN_180ad1200(*(uint64 *)(lVar5 + 0x198),0);
              if (!cVar2) {
                lVar8 = *(int64 *)(lVar5 + 0x198);
              }
              else {
                lVar8 = *(int64 *)(lVar5 + 24);
              }
            }
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            FUN_1800025b0(plVar13,1,lVar8);
            if ((" " != 0) &&
               (lVar8 = il2cpp_internal(" ",*(uint64 *)(*plVar13 + 64))) == null)
            {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar8 = " ";
            if (*(uint32 *)(plVar13 + 3) < 3) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar13[6] = " ";
            il2cpp_internal(plVar13 + 6,lVar8);
            uVar3 = ForceData.GetForceFavor(lVar4,*(uint32 *)(lVar5 + 16),0);
            lVar8 = GlobalData.GetForceFavorLvText(uVar3,0);
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar13 + 3) < 4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar13[7] = lVar8;
            il2cpp_internal(plVar13 + 7,lVar8);
            if (("(" != 0) &&
               (lVar8 = il2cpp_internal("(",*(uint64 *)(*plVar13 + 64))) == null)
            {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar8 = "(";
            if (*(uint32 *)(plVar13 + 3) < 5) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar13[8] = "(";
            il2cpp_internal(plVar13 + 8,lVar8);
            local_res20[0] = ForceData.GetForceFavor(lVar4,*(uint32 *)(lVar5 + 16),0);
            lVar8 = Single.ToString(local_res20,0);
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar13 + 3) < 6) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar13[9] = lVar8;
            il2cpp_internal(plVar13 + 9,lVar8);
            if ((") " != 0) &&
               (lVar8 = il2cpp_internal(") ",*(uint64 *)(*plVar13 + 64))) == null)
            {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar8 = ") ";
            if (*(uint32 *)(plVar13 + 3) < 7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar13[10] = ") ";
            il2cpp_internal(plVar13 + 10,lVar8);
            lVar5 = ForceData.GetForceRelationshipText(lVar4,*(uint32 *)(lVar5 + 16));
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar13 + 3) < 8) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar13[11] = lVar5;
            il2cpp_internal(plVar13 + 11,lVar5);
            uVar9 = String.Concat(plVar13,0);
            LTLocalization.AddText(uVar6,uVar9);
          }
          goto LAB_1808fd910;
        }
        ZhSegment.Initialize(&local_a0,DAT_181e6e040);
        uVar6 = this.detailText;
        if (lVar4.monthBreakEquipTime != null) {
          uVar9 = ForceSpeAddData.GetDescribe(lVar4.monthBreakEquipTime,1,0);
          LTLocalization.SetText(uVar6,uVar9,0);
          uVar6 = this.forceHeroGrid;
          GlobalData.DeleteAllChild(uVar6,0);
          GlobalData.DeleteAllChild(this.forceSkillGrid,0);
          lVar5 = local_78;
          iVar14 = 0;
          while (lVar4.lastRandomWorldEventDay != null) {
            uVar6 = *(uint64 *)(lVar5 + 64);
            if (*(int *)(lVar4.lastRandomWorldEventDay + 24) <= iVar14) {
              GlobalData.SortChild(uVar6,0);
              if ((plVar4 != 0) &&
                 (lVar5 = *(int64 *)(plVar4 + 48)) != null) {
                if (*(uint32 *)(lVar5 + 24) < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 56);
                if (lVar5 != null) {
                  iVar14 = *(int *)(lVar5 + 24);
                  goto joined_r0x0001808fdf18;
                }
              }
              break;
            }
            if (*pStatics_2a90 == 0) break;
            uVar9 = *(uint64 *)(*pStatics_2a90 + 144);
            lVar8 = GlobalData.AddChild(uVar6,uVar9,0);
            if (lVar8 == null) break;
            lVar12 = GameObject.GetComponent(lVar8,DAT_181e54c18);
            uVar6 = ForceData.GetOwnHero(lVar4,iVar14);
            if (lVar12 == null) break;
            *(uint64 *)(lVar12 + 32) = uVar6;
            lVar12 = GameObject.GetComponent(lVar8,DAT_181e54c18);
            if (lVar12 == null) break;
            *(uint32 *)(lVar12 + 24) = 0;
            lVar8 = GameObject.GetComponent(lVar8);
            if (lVar8 == null) break;
            HeroIconController.AutoSetName(lVar8);
            iVar14 = iVar14 + 1;
          }
        }
    }

    // Token : 0x6001519
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x600151A
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    private void <HideForceDetail>b__19_0()
    {
        if (this.forceDetailPanel != null) {
          GameObject.SetActive(this.forceDetailPanel,0,0);
          return;
        }
    }

}
