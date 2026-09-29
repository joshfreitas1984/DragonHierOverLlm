// ============================================================
// Type  : ForceDetailController
// Token : 0x2000289
// ============================================================

public class ForceDetailController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001466
    public GameObject forceDetailPanel;

    // Token: 0x4001467
    public GameObject forceDetailTabGrid;

    // Token: 0x4001468
    public GameObject forceDetailTabPrefab;

    // Token: 0x4001469
    public GameObject forceDetail;

    // Token: 0x400146A
    public GameObject forceSkillGrid;

    // Token: 0x400146B
    public GameObject forceHeroGrid;

    // Token: 0x400146C
    public int nowShowForceID;

    // Token: 0x400146D
    public Text baseDetailText;

    // Token: 0x400146E
    public Text areaText;

    // Token: 0x400146F
    public Text detailText;

    // Token: 0x4001470
    public Text favorText;

    // Token: 0x4001471
    public bool inited;

    // Token: 0x4001472
    private static ForceDetailController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014A4
    // RVA   : 0xB3C980   Offset: 0xB3BD80   Length: 0x36
    public static ForceDetailController get_Instance()
    {
        return **(uint64 **)(DAT_181dc7d18 + 184);
    }

    // Token : 0x60014A5
    // RVA   : 0xB392F0   Offset: 0xB386F0   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181dc7d18 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181dc7d18 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014A6
    // RVA   : 0xB39570   Offset: 0xB38970   Length: 0x434
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
          FUN_1800d6620();
        }
        FUN_1817eba30(&local_38,lVar6,DAT_181d88038);
        local_20 = local_38;
        uStack_1c = uStack_34;
        uStack_18 = uStack_30;
        uStack_14 = uStack_2c;
        local_10 = local_28;
        while( true ) {
          do {
            do {
              cVar2 = FUN_180c75510(&local_20,DAT_181d8c600);
              lVar6 = local_10;
              if (!cVar2) {
                ZhSegment.Initialize(&local_20,DAT_181d8c580);
                return;
              }
              uVar4 = this.forceDetailTabGrid;
              uVar1 = this.forceDetailTabPrefab;
              lVar3 = GlobalData.AddChild(uVar4,uVar1,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = Int32.ToString(lVar6 + 16,0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              Object.set_name(lVar3,uVar4);
              lVar5 = GameObject.GetComponent(lVar3,DAT_181d71710);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              *(uint32 *)(lVar5 + 24) = lVar6.chapter;
            } while (PlotController.fightSkillIndexCache != 1);
            lVar5 = PlotController.LeftFaceHideOffset;
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_18182a9b0(lVar5,lVar6.chapter);
          } while (cVar2);
          lVar6 = GameObject.GetComponent(lVar3,DAT_181dc7c18);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Selectable.set_interactable(lVar6,0,0);
          lVar6 = GameObject.get_transform(lVar3,0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar6 = Transform.Find(lVar6,"Name",0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = Component.GetComponent(lVar6,DAT_181d96178);
          LTLocalization.SetText(uVar4,"???",0);
          lVar6 = GameObject.get_transform(lVar3,0);
          if (lVar6 == null) break;
          lVar6 = Transform.Find(lVar6,"Icon",0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94478);
          puVar8 = (uint32 *)Color.get_black(&local_38,0);
          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_48 = *puVar8;
          uStack_44 = puVar8[1];
          uStack_40 = puVar8[2];
          uStack_3c = puVar8[3];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_48);
        }
    }

    // Token : 0x60014A7
    // RVA   : 0xB39CD0   Offset: 0xB390D0   Length: 0xBF7
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
          FUN_1800d6620();
        }
        FUN_1817eba30(&local_68,lVar8,DAT_181d88038);
        local_50 = local_68;
        uStack_4c = uStack_64;
        uStack_48 = uStack_60;
        uStack_44 = uStack_5c;
        local_40 = local_58;
        LAB_180b39e80:
        do {
          cVar1 = FUN_180c75510(&local_50,DAT_181d8c600);
          lVar8 = local_40;
          if (!cVar1) {
            ZhSegment.Initialize(&local_50,DAT_181d8c580);
            return;
          }
          if (this.forceDetailTabGrid == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = GameObject.get_transform(this.forceDetailTabGrid,0);
          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = Int32.ToString(lVar8 + 16,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Transform.Find(lVar2,uVar3,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = Component.get_transform(lVar2,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = Transform.Find(lVar4,"Name",0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = Component.GetComponent(lVar4,DAT_181d96178);
          cVar1 = FUN_180d75bc0(lVar8.totalBadFame,0);
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
            FUN_1800d6620();
          }
          lVar4 = Transform.Find(lVar4,"Icon",0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = Component.GetComponent(lVar4,DAT_181d94478);
          uVar3 = ForceData.GetForceIcon(lVar8,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Image.set_sprite(lVar4,uVar3);
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar4 + 132) == lVar8.chapter) {
            lVar4 = Transform.Find(lVar2,"SelfForce",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar1) {
              lVar4 = Transform.Find(lVar2,"SelfForce",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar3 = 1;
              goto LAB_180b3a0a2;
            }
          }
          else {
            lVar4 = Transform.Find(lVar2,"SelfForce",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (cVar1) {
              lVar4 = Transform.Find(lVar2,"SelfForce",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar3 = 0;
        LAB_180b3a0a2:
              GameObject.SetActive(lVar4,uVar3);
            }
          }
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = HeroData.HaveForce(lVar4,0);
          if (!cVar1) {
        LAB_180b3a626:
            lVar4 = Transform.Find(lVar2,"Favor",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (cVar1) {
              lVar4 = Transform.Find(lVar2,"Favor",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SetActive(lVar4,0);
            }
          }
          else {
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(lVar4 + 132) == lVar8.chapter) goto LAB_180b3a626;
            lVar4 = Transform.Find(lVar2,"Favor",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar1) {
              lVar4 = Transform.Find(lVar2,"Favor",0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SetActive(lVar4,1,0);
            }
            lVar4 = Transform.Find(lVar2,"Favor",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = Transform.Find(lVar4,"Icon",0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d94478);
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            ForceData.GetForceFavor(lVar8,*(uint32 *)(lVar4 + 132),0);
            puVar6 = (uint32 *)GlobalData.GetForceFavorLvColor(&local_68);
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_78 = *puVar6;
            uStack_74 = puVar6[1];
            uStack_70 = puVar6[2];
            uStack_6c = puVar6[3];
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_78);
            lVar4 = Transform.Find(lVar2,"Favor");
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = Transform.Find(lVar4,"Text");
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar3 = Component.GetComponent(lVar4,DAT_181d96178);
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar9 = (float)ForceData.GetForceFavor(lVar8,*(uint32 *)(lVar4 + 132));
            local_res18[0] = (int)fVar9;
            uVar7 = Int32.ToString(local_res18,0);
            LTLocalization.SetText(uVar3,uVar7);
          }
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = HeroData.HaveForce(lVar4,0);
          if (cVar1) {
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(lVar4 + 132) != lVar8.chapter) {
              lVar4 = FUN_18046c0a0(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar4 + 32) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar4 = HeroData.GetForce(lVar4,0,0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar8 = ForceData.GetForceRelationshipText(lVar4,lVar8.chapter,1,0);
              if (lVar8 != null) {
                lVar4 = Transform.Find(lVar2,"Relation");
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Component.get_gameObject(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = GameObject.get_activeSelf(lVar4,0);
                if (!cVar1) {
                  lVar4 = Transform.Find(lVar2,"Relation");
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar4 = Component.get_gameObject(lVar4,0);
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  GameObject.SetActive(lVar4,1);
                }
                lVar2 = Transform.Find(lVar2,"Relation");
                if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar3 = Component.GetComponent(lVar2,DAT_181d96178);
                LTLocalization.SetText(uVar3,lVar8);
                goto LAB_180b39e80;
              }
            }
          }
          lVar8 = Transform.Find(lVar2,"Relation");
          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar8 = Component.get_gameObject(lVar8,0);
          if (lVar8 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = GameObject.get_activeSelf(lVar8,0);
          if (cVar1) {
            lVar8 = Transform.Find(lVar2,"Relation");
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar8 = Component.get_gameObject(lVar8,0);
            if (lVar8 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SetActive(lVar8,0);
          }
        } while( true );
    }

    // Token : 0x60014A8
    // RVA   : 0xB399B0   Offset: 0xB38DB0   Length: 0x315
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
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94478);
                if (this.forceDetailPanel != null) {
                  lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                    if (lVar1 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181d94478);
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
                                uVar5 = Component.GetComponent(lVar1,DAT_181d94478);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1dc8);
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
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1f60);
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

    // Token : 0x60014A9
    // RVA   : 0xB393D0   Offset: 0xB387D0   Length: 0x194
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
              uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1dc8);
              if (this.forceDetailPanel != null) {
                lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"ForceDetailRoot",0);
                  uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1f60);
                  uVar3 = new OnTooltipCB(this,DAT_181dc1180,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc0380);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60014AA
    // RVA   : 0xB3AAF0   Offset: 0xB39EF0   Length: 0x37
    public void ResetForceDetail()
    {
        if (this.forceDetail != null) {
          GameObject.SetActive(this.forceDetail,0,0);
          this.nowShowForceID = 0xffffffff;
          ForceDetailController.RefreshForceTab(this,0);
          return;
        }
    }

    // Token : 0x60014AB
    // RVA   : 0xB3A8D0   Offset: 0xB39CD0   Length: 0x21B
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
               (lVar3 = Component.GetComponent(lVar3,DAT_181d93ef8)) == null) break;
            lVar1 = this.forceDetailTabGrid;
            if (*(int *)(lVar3 + 24) == this.nowShowForceID) {
              if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
              if (plVar4 == (int64 *)0) break;
              (**(code **)(*plVar4 + 0x2a8))(plVar4);
            }
            else {
              if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
              FUN_1810d3b80(local_18,0);
              if (plVar4 == (int64 *)0) break;
              (**(code **)(*plVar4 + 0x2a8))(plVar4);
            }
            lVar3 = this.forceDetailTabGrid;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x60014AC
    // RVA   : 0xB3AB30   Offset: 0xB39F30   Length: 0x1E49
    public void ShowForceDetail(int targetForceID)
    {
        var plVar4 = lVar4.forceMeetingStarted;
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
                (uVar6 = Component.GetComponent(lVar5,DAT_181d96178), lVar4 != null)))) {
              cVar2 = FUN_180d75bc0(lVar4.totalBadFame,0);
              if (!cVar2) {
                uVar9 = lVar4.totalBadFame;
              }
              else {
                uVar9 = lVar4.cityAreaID;
              }
              LTLocalization.SetText(uVar6,uVar9);
              uVar6 = this.baseDetailText;
              plVar7 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,5);
              if (plVar7 != (int64 *)0) {
                if (("等级 " != 0) &&
                   (lVar5 = il2cpp_internal("等级 ",*(uint64 *)(*plVar7 + 64)), lVar5 == null
                   )) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                lVar5 = "等级 ";
                if ((int)plVar7[3] == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar7[4] = "等级 ";
                il2cpp_internal(plVar7 + 4,lVar5);
                uVar3 = *(uint32 *)(lVar4 + 52);
                lVar5 = GlobalData.GetNumText(uVar3,0);
                if ((lVar5 != null) &&
                   (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar7 + 3) < 2) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar7[5] = lVar5;
                il2cpp_internal(plVar7 + 5,lVar5);
                if (("\n风格 " != 0) &&
                   (lVar5 = il2cpp_internal("\n风格 ",*(uint64 *)(*plVar7 + 64)), lVar5 == null
                   )) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                lVar5 = "\n风格 ";
                if (*(uint32 *)(plVar7 + 3) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar7[6] = "\n风格 ";
                il2cpp_internal(plVar7 + 6,lVar5);
                lVar5 = lVar4.forceAreaID;
                if ((lVar5 != null) &&
                   (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar7 + 3) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar7[7] = lVar5;
                il2cpp_internal(plVar7 + 7,lVar5);
                if (("\n专长 " != 0) &&
                   (lVar5 = il2cpp_internal("\n专长 ",*(uint64 *)(*plVar7 + 64)), lVar5 == null
                   )) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                lVar5 = "\n专长 ";
                if (*(uint32 *)(plVar7 + 3) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
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
                    goto LAB_180b3b210;
                  }
                  lVar12 = "/";
                  if (iVar14 == 0) {
                    lVar12 = "";
                  }
                  if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) &&
                     (*(int *)(DAT_181d73d40 + 224) == 0)) {
                    il2cpp_runtime_class_init(DAT_181d73d40);
                    lVar5 = lVar4.worldPlotEventStartData;
                  }
                  lVar1 = *(int64 *)(pStatics_3d40 + 0x4a0);
                  if ((lVar5 == null) || (uVar3 = FUN_1800d6760(lVar5,iVar14,DAT_181d8fa30), lVar1 == null))
                  break;
                  uVar9 = FUN_180002f80(lVar1,uVar3,DAT_181da4370);
                  lVar8 = String.Concat(lVar8,lVar12,uVar9);
                  iVar14 = iVar14 + 1;
                  lVar5 = lVar4.worldPlotEventStartData;
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180b3b210:
        lVar5 = lVar4.worldPlotEventStartTime;
        if (lVar5 == null) throw; // [null/range check failed]
        uVar6 = this.baseDetailText;
        if (*(int *)(lVar5 + 24) <= (int)uVar15) {
          lVar5 = *(int64 *)(pStatics_3d40 + 0x4d0);
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
            lVar5 = FUN_18046c100(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 224) == 0)) ||
               (lVar5 = FUN_1817da420(*(int64 *)(lVar5 + 224),*(uint32 *)(lVar4 + 0x17c),
                                      DAT_181db7bf0), lVar5 == null)) throw; // [null/range check failed]
            uVar9 = *(uint64 *)(lVar5 + 24);
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x180)) == null)
            throw; // [null/range check failed]
            cVar2 = FUN_18182a9b0(lVar5,*(uint32 *)(lVar4 + 0x17c),DAT_181d8f3b0);
            uVar11 = "\n特殊建筑 {0}({1}</color>)";
            uVar10 = "<color=grey>未解锁";
            if (cVar2) {
              uVar10 = String.Concat(*(uint64 *)(pStatics_3d40 + 0x268),
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
                goto LAB_180b3b630;
              }
            }
          }
          throw; // [null/range check failed]
        }
        if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
          il2cpp_runtime_class_init(DAT_181d73d40);
          lVar5 = lVar4.worldPlotEventStartTime;
        }
        lVar8 = *(int64 *)(pStatics_3d40 + 0x4b0);
        if ((lVar5 == null) || (uVar3 = FUN_1800d6760(lVar5,uVar15,DAT_181d8fa30), lVar8 == null))
        throw; // [null/range check failed]
        uVar9 = FUN_180002f80(lVar8,uVar3);
        String.Concat("/",uVar9);
        LTLocalization.AddText(uVar6);
        uVar15 = uVar15 + 1;
        goto LAB_180b3b210;
        LAB_180b3b630:
        if (lVar4.WorldNewsDatas == null) throw; // [null/range check failed]
        if (*(int *)(lVar4.WorldNewsDatas + 24) <= (int)uVar15) {
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar5 + 32) + 156) == 1) {
            lVar5 = *(int64 *)(pStatics_3d40 + 0x3a8);
            if (lVar5 == null) throw; // [null/range check failed]
            cVar2 = FUN_18182a9b0(lVar5,targetForceID,DAT_181d8f3b0);
            if (!cVar2) {
              uVar6 = this.baseDetailText;
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
              if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 208)) == null) ||
                 (lVar5 = FUN_1817da420(lVar5,lVar4.chapter,DAT_181db9778)) == null)
              throw; // [null/range check failed]
              uVar9 = *(uint64 *)(lVar5 + 0x180);
              uVar9 = String.Format("\n\n<b>门派特性</b>\n{1}{0}</color>",uVar9,
                                     *(uint64 *)(pStatics_3d40 + 600),0);
              LTLocalization.AddText(uVar6,uVar9,0);
            }
          }
          uVar6 = this.areaText;
          LTLocalization.SetText(uVar6,"",0);
          lVar5 = 32;
          goto LAB_180b3bc30;
        }
        uVar6 = this.baseDetailText;
        plVar7 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,9);
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        if (("\n" != 0) &&
           (lVar5 = il2cpp_internal("\n",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar5 = "\n";
        if ((int)plVar7[3] == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[4] = "\n";
        il2cpp_internal(plVar7 + 4,lVar5);
        lVar5 = *(int64 *)(pStatics_3d40 + 0x438);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar5 = FUN_180002f80(lVar5,uVar15,DAT_181da4370);
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 2) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[5] = lVar5;
        il2cpp_internal(plVar7 + 5,lVar5);
        if ((" " != 0) &&
           (lVar5 = il2cpp_internal(" ",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar5 = " ";
        if (*(uint32 *)(plVar7 + 3) < 3) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[6] = " ";
        il2cpp_internal(plVar7 + 6,lVar5);
        if (lVar4.WorldNewsDatas == null) throw; // [null/range check failed]
        local_res20[0] = FUN_1800d6790(lVar4.WorldNewsDatas,uVar15,DAT_181da1090);
        lVar5 = Single.ToString(local_res20,"f0",0);
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 4) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[7] = lVar5;
        il2cpp_internal(plVar7 + 7,lVar5);
        if (("/" != 0) &&
           (lVar5 = il2cpp_internal("/",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar5 = "/";
        if (*(uint32 *)(plVar7 + 3) < 5) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[8] = "/";
        il2cpp_internal(plVar7 + 8,lVar5);
        if (lVar4.MailDatas == null) throw; // [null/range check failed]
        local_res20[0] = FUN_1800d6790(lVar4.MailDatas,uVar15,DAT_181da1090);
        lVar5 = Single.ToString(local_res20,"f0",0);
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 6) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[9] = lVar5;
        il2cpp_internal(plVar7 + 9,lVar5);
        if ((" (" != 0) &&
           (lVar5 = il2cpp_internal(" (",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar5 = " (";
        if (*(uint32 *)(plVar7 + 3) < 7) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[10] = " (";
        il2cpp_internal(plVar7 + 10,lVar5);
        if (lVar4.cheating == null) throw; // [null/range check failed]
        local_res20[0] = FUN_1800d6790(lVar4.cheating,uVar15);
        lVar5 = Single.ToString(local_res20,"+0;-0;0");
        if ((lVar5 != null) &&
           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        if (*(uint32 *)(plVar7 + 3) < 8) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[11] = lVar5;
        il2cpp_internal(plVar7 + 11,lVar5);
        if ((")" != 0) &&
           (lVar5 = il2cpp_internal(")",*(uint64 *)(*plVar7 + 64))) == null) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        lVar5 = ")";
        if (*(uint32 *)(plVar7 + 3) < 9) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        plVar7[12] = ")";
        il2cpp_internal(plVar7 + 12,lVar5);
        uVar9 = String.Concat(plVar7,0);
        LTLocalization.AddText(uVar6,uVar9);
        uVar15 = uVar15 + 1;
        goto LAB_180b3b630;
        LAB_180b3bc30:
        lVar8 = lVar4.BigMapRandomEventDatas;
        if (lVar8 == null) throw; // [null/range check failed]
        if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar16) {
          iVar14 = 0;
          goto LAB_180b3bd70;
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar16) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int *)(lVar5 + *(int64 *)(lVar8 + 16)) != lVar4.Inns) {
          plVar7 = this.areaText;
          if (plVar7 == (int64 *)0) throw; // [null/range check failed]
          uVar6 = (**(code **)(*plVar7 + 0x5d8))(plVar7,*(uint64 *)(*plVar7 + 0x5e0));
          cVar2 = FUN_18171eb50(uVar6,"",0);
          lVar8 = "\n";
          if (cVar2) {
            lVar8 = "";
          }
          lVar12 = FUN_18046c0a0(0);
          if (lVar12 == null) throw; // [null/range check failed]
          lVar12 = *(int64 *)(lVar12 + 32);
          if (((lVar4.BigMapRandomEventDatas == null) ||
              (uVar3 = FUN_1800d6760(lVar4.BigMapRandomEventDatas,uVar16), lVar12 == null)) ||
             (lVar12 = WorldData.GetArea(lVar12,uVar3)) == null) throw; // [null/range check failed]
          uVar6 = AreaData.GetAreaName(lVar12,0);
          uVar6 = String.Concat(lVar8,uVar6);
          LTLocalization.AddText(plVar7,uVar6);
        }
        uVar16 = uVar16 + 1;
        lVar5 = lVar5 + 4;
        goto LAB_180b3bc30;
        LAB_180b3bd70:
        if (lVar4.AreaMapRandomEventDatas == null) throw; // [null/range check failed]
        if (*(int *)(lVar4.AreaMapRandomEventDatas + 24) <= iVar14) {
          uVar6 = this.favorText;
          LTLocalization.SetText(uVar6,"",0);
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
             (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 72)) != null) {
            FUN_1817eba30(&local_68,lVar5,DAT_181d88038);
            local_a0 = CONCAT44(uStack_64,local_68);
            uStack_98 = CONCAT44(uStack_5c,uStack_60);
            local_90 = local_58;
            goto LAB_180b3bf30;
          }
          throw; // [null/range check failed]
        }
        plVar7 = this.areaText;
        if (plVar7 == (int64 *)0) throw; // [null/range check failed]
        uVar6 = (**(code **)(*plVar7 + 0x5d8))(plVar7,*(uint64 *)(*plVar7 + 0x5e0));
        cVar2 = FUN_18171eb50(uVar6,"",0);
        lVar5 = "\n";
        if (cVar2) {
          lVar5 = "";
        }
        lVar8 = FUN_18046c0a0(0);
        if (lVar8 == null) throw; // [null/range check failed]
        lVar8 = *(int64 *)(lVar8 + 32);
        if (((lVar4.AreaMapRandomEventDatas == null) ||
            (uVar3 = FUN_1800d6760(lVar4.AreaMapRandomEventDatas,iVar14), lVar8 == null)) ||
           (lVar8 = WorldData.GetResourcePoint(lVar8,uVar3)) == null) throw; // [null/range check failed]
        uVar6 = ResourcePointData.GetResourcePointFullName(lVar8,0);
        uVar6 = String.Concat(lVar5,uVar6);
        LTLocalization.AddText(plVar7,uVar6);
        iVar14 = iVar14 + 1;
        goto LAB_180b3bd70;
        joined_r0x000180b3c538:
        iVar14 = iVar14 + -1;
        if (iVar14 < 0) {
          uVar6 = this.forceSkillGrid;
          GlobalData.SortChild(uVar6,0);
          return;
        }
        uVar6 = this.forceSkillGrid;
        if (*pStatics_2ee8 == 0) throw; // [null/range check failed]
        uVar9 = *(uint64 *)(*pStatics_2ee8 + 160);
        lVar5 = GlobalData.AddChild(uVar6,uVar9,0);
        if (lVar5 == null) throw; // [null/range check failed]
        lVar8 = GameObject.GetComponent(lVar5,DAT_181d720a0);
        if ((plVar4 == 0) ||
           (lVar12 = *(int64 *)(plVar4 + 48)) == null) throw; // [null/range check failed]
        if (*(uint32 *)(lVar12 + 24) < 4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar12 = *(int64 *)(*(int64 *)(lVar12 + 16) + 56);
        if ((lVar12 == null) || (uVar6 = FUN_180002f80(lVar12,iVar14), lVar8 == null)) throw; // [null/range check failed]
        *(uint64 *)(lVar8 + 32) = uVar6;
        lVar8 = GameObject.GetComponent(lVar5,DAT_181d720a0);
        if (lVar8 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar8 + 40) = 1;
        lVar5 = GameObject.GetComponent(lVar5,DAT_181d720a0);
        if (lVar5 == null) throw; // [null/range check failed]
        ItemIconController.AutoSetName(lVar5,1);
        goto joined_r0x000180b3c538;
        LAB_180b3bf30:
        cVar2 = FUN_180c75510(&local_a0,DAT_181d8c600);
        lVar5 = local_90;
        if (cVar2) {
          if (local_90 != lVar4) {
            uVar6 = this.favorText;
            plVar13 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,8);
            plVar7 = this.favorText;
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar9 = (**(code **)(*plVar7 + 0x5d8))(plVar7,*(uint64 *)(*plVar7 + 0x5e0));
            cVar2 = FUN_18171eb50(uVar9,"",0);
            lVar8 = "\n";
            if (cVar2) {
              lVar8 = "";
            }
            if (plVar13 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            FUN_180002fd0(plVar13,0,lVar8);
            if (PlotController.fightSkillIndexCache == 1) {
              lVar8 = PlotController.LeftFaceHideOffset;
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar2 = FUN_18182a9b0(lVar8,*(uint32 *)(lVar5 + 16),DAT_181d8f3b0);
              lVar8 = "???";
              if (!(cVar2))
              {
                }
                else {
                if (lVar5 == null) {
                // WARNING: Subroutine does not return
                FUN_1800d6620();
                }
              }
              cVar2 = FUN_180d75bc0(*(uint64 *)(lVar5 + 0x198),0);
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
              FUN_1800d65f0(uVar6,0);
            }
            FUN_180002fd0(plVar13,1,lVar8);
            if ((" " != 0) &&
               (lVar8 = il2cpp_internal(" ",*(uint64 *)(*plVar13 + 64))) == null)
            {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar8 = " ";
            if (*(uint32 *)(plVar13 + 3) < 3) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar13[6] = " ";
            il2cpp_internal(plVar13 + 6,lVar8);
            uVar3 = ForceData.GetForceFavor(lVar4,*(uint32 *)(lVar5 + 16),0);
            lVar8 = GlobalData.GetForceFavorLvText(uVar3,0);
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar13 + 3) < 4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar13[7] = lVar8;
            il2cpp_internal(plVar13 + 7,lVar8);
            if (("(" != 0) &&
               (lVar8 = il2cpp_internal("(",*(uint64 *)(*plVar13 + 64))) == null)
            {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar8 = "(";
            if (*(uint32 *)(plVar13 + 3) < 5) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar13[8] = "(";
            il2cpp_internal(plVar13 + 8,lVar8);
            local_res20[0] = ForceData.GetForceFavor(lVar4,*(uint32 *)(lVar5 + 16),0);
            lVar8 = Single.ToString(local_res20,0);
            if ((lVar8 != null) &&
               (lVar12 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar13 + 3) < 6) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar13[9] = lVar8;
            il2cpp_internal(plVar13 + 9,lVar8);
            if ((") " != 0) &&
               (lVar8 = il2cpp_internal(") ",*(uint64 *)(*plVar13 + 64))) == null)
            {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar8 = ") ";
            if (*(uint32 *)(plVar13 + 3) < 7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar13[10] = ") ";
            il2cpp_internal(plVar13 + 10,lVar8);
            lVar5 = ForceData.GetForceRelationshipText(lVar4,*(uint32 *)(lVar5 + 16));
            if ((lVar5 != null) &&
               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar13 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar13 + 3) < 8) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar13[11] = lVar5;
            il2cpp_internal(plVar13 + 11,lVar5);
            uVar9 = String.Concat(plVar13,0);
            LTLocalization.AddText(uVar6,uVar9);
          }
          goto LAB_180b3bf30;
        }
        ZhSegment.Initialize(&local_a0,DAT_181d8c580);
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
                  goto joined_r0x000180b3c538;
                }
              }
              break;
            }
            if (*pStatics_2ee8 == 0) break;
            uVar9 = *(uint64 *)(*pStatics_2ee8 + 144);
            lVar8 = GlobalData.AddChild(uVar6,uVar9,0);
            if (lVar8 == null) break;
            lVar12 = GameObject.GetComponent(lVar8,DAT_181d71b50);
            uVar6 = ForceData.GetOwnHero(lVar4,iVar14);
            if (lVar12 == null) break;
            *(uint64 *)(lVar12 + 32) = uVar6;
            lVar12 = GameObject.GetComponent(lVar8,DAT_181d71b50);
            if (lVar12 == null) break;
            *(uint32 *)(lVar12 + 24) = 0;
            lVar8 = GameObject.GetComponent(lVar8);
            if (lVar8 == null) break;
            HeroIconController.AutoSetName(lVar8);
            iVar14 = iVar14 + 1;
          }
        }
    }

    // Token : 0x60014AD
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60014AE
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <HideForceDetail>b__19_0()
    {
        if (this.forceDetailPanel != null) {
          GameObject.SetActive(this.forceDetailPanel,0,0);
          return;
        }
    }

}
