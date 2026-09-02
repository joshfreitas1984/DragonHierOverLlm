// ============================================================
// Type  : ForceDetailController
// Token : 0x2000283
// ============================================================

public class ForceDetailController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013B5
    public GameObject forceDetailPanel;

    // Token: 0x40013B6
    public GameObject forceDetailTabGrid;

    // Token: 0x40013B7
    public GameObject forceDetailTabPrefab;

    // Token: 0x40013B8
    public GameObject forceDetail;

    // Token: 0x40013B9
    public GameObject forceSkillGrid;

    // Token: 0x40013BA
    public GameObject forceHeroGrid;

    // Token: 0x40013BB
    public int nowShowForceID;

    // Token: 0x40013BC
    public Text baseDetailText;

    // Token: 0x40013BD
    public Text areaText;

    // Token: 0x40013BE
    public Text detailText;

    // Token: 0x40013BF
    public Text favorText;

    // Token: 0x40013C0
    private bool inited;

    // Token: 0x40013C1
    private static ForceDetailController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001460
    // RVA   : 0xBB3640   Offset: 0xBB1E40   Length: 0x36
    public static ForceDetailController get_Instance()
    {
        return **(uint64 **)(DAT_181da29a0 + 184);
    }

    // Token : 0x6001461
    // RVA   : 0xBAFE40   Offset: 0xBAE640   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181da29a0 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181da29a0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001462
    // RVA   : 0xBB00C0   Offset: 0xBAE8C0   Length: 0x505
    public void InitForceDetailTab()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        int64 local_38;
        uint32 local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        int64 local_20;
        if (((*pStatics_df90 == 0) ||
            (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar6 = *(int64 *)(lVar6 + 72)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1817ff240(&local_48,lVar6,DAT_181d60878);
        local_30 = local_48;
        uStack_2c = uStack_44;
        uStack_28 = uStack_40;
        uStack_24 = uStack_3c;
        local_20 = local_38;
        while( true ) {
          cVar2 = FUN_180d197a0(&local_30,DAT_181d66148);
          lVar6 = local_20;
          if (!cVar2) {
            ZhSegment.Initialize(&local_30,DAT_181d660c8);
            return;
          }
          uVar4 = this.forceDetailTabGrid;
          uVar1 = this.forceDetailTabPrefab;
          lVar3 = GlobalData.AddChild(uVar4,uVar1,0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar8 = (uint32 *)(lVar6 + 16);
          uVar4 = Int32.ToString(puVar8,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Object.set_name(lVar3,uVar4,0);
          lVar5 = GameObject.GetComponent(lVar3,DAT_181d9f768);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint32 *)(lVar5 + 24) = *puVar8;
          lVar5 = GameObject.get_transform(lVar3,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = Transform.Find(lVar5,"Name",0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          LTLocalization.SetText(uVar4,*(uint64 *)(lVar6 + 24),0);
          lVar6 = GameObject.get_transform(lVar3,0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar6 = Transform.Find(lVar6,"Icon",0);
          if (lVar6 == null) break;
          lVar6 = Component.GetComponent(lVar6,DAT_181d6bc40);
          lVar5 = FUN_18046c6c0(0);
          uVar4 = GlobalData.GetForceIconName(*puVar8,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = TextureController.LoadAtlasSprite(lVar5,"UIAtlas",uVar4,0);
          if (lVar6 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Image.set_sprite(lVar6,uVar4);
          if (*(int *)(pStatics_ef00 + 8) == 1) {
            lVar6 = *(int64 *)(pStatics_ef00 + 32);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = FUN_181815240(lVar6,*puVar8);
            if (!cVar2) {
              lVar6 = GameObject.GetComponent(lVar3,DAT_181d9ee60);
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
              uVar4 = Component.GetComponent(lVar6,DAT_181d6d8c0);
              LTLocalization.SetText(uVar4,"???",0);
              lVar6 = GameObject.get_transform(lVar3,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = Transform.Find(lVar6,"Icon",0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d6bc40);
              puVar8 = (uint32 *)Color.get_black(&local_48,0);
              if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_58 = *puVar8;
              uStack_54 = puVar8[1];
              uStack_50 = puVar8[2];
              uStack_4c = puVar8[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_58);
            }
          }
        }
    }

    // Token : 0x6001463
    // RVA   : 0xBB08F0   Offset: 0xBAF0F0   Length: 0xAAE
    public void RefreshForceDetailTab()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar7;
        long lVar8;
        float fVar9;
        int[] local_res18 = new int[4];
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint32 local_58;
        uint32 uStack_54;
        uint32 uStack_50;
        uint32 uStack_4c;
        int64 local_48;
        uint32 local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        int64 local_30;
        local_res18[0] = 0;
        if (((*pStatics == 0) ||
            (lVar8 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar8 = *(int64 *)(lVar8 + 72)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1817ff240(&local_58,lVar8,DAT_181d60878);
        local_40 = local_58;
        uStack_3c = uStack_54;
        uStack_38 = uStack_50;
        uStack_34 = uStack_4c;
        local_30 = local_48;
        LAB_180bb0a90:
        do {
          cVar1 = FUN_180d197a0(&local_40,DAT_181d66148);
          lVar8 = local_30;
          if (!cVar1) {
            ZhSegment.Initialize(&local_40,DAT_181d660c8);
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
          if (*(int *)(lVar4 + 132) == *(int *)(lVar8 + 16)) {
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
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
              goto LAB_180bb0bc5;
            }
          }
          else {
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
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
        LAB_180bb0bc5:
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
          if (*(int *)(lVar4 + 132) < 0) {
        LAB_180bb1110:
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
            if (*(int *)(lVar4 + 132) == *(int *)(lVar8 + 16)) goto LAB_180bb1110;
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
            plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
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
            puVar6 = (uint32 *)GlobalData.GetForceFavorLvColor(&local_58);
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_68 = *puVar6;
            uStack_64 = puVar6[1];
            uStack_60 = puVar6[2];
            uStack_5c = puVar6[3];
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_68);
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
            uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
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
          if (-1 < *(int *)(lVar4 + 132)) {
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
            if (*(int *)(lVar4 + 132) != *(int *)(lVar8 + 16)) {
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
              lVar8 = ForceData.GetForceRelationshipText(lVar4,*(uint32 *)(lVar8 + 16),1,0);
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
                uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                LTLocalization.SetText(uVar3,lVar8);
                goto LAB_180bb0a90;
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

    // Token : 0x6001464
    // RVA   : 0xBB05D0   Offset: 0xBAEDD0   Length: 0x315
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
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                if (this.forceDetailPanel != null) {
                  lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                    if (lVar1 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
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
                                uVar5 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
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
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
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

    // Token : 0x6001465
    // RVA   : 0xBAFF20   Offset: 0xBAE720   Length: 0x194
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
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
              if (this.forceDetailPanel != null) {
                lVar1 = GameObject.get_transform(this.forceDetailPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"ForceDetailRoot",0);
                  uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98af0);
                  uVar3 = new OnTooltipCB(this,DAT_181d983e0,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001466
    // RVA   : 0xBB15C0   Offset: 0xBAFDC0   Length: 0x37
    public void ResetForceDetail()
    {
        if (this.forceDetail != null) {
          GameObject.SetActive(this.forceDetail,0,0);
          this.nowShowForceID = 0xffffffff;
          ForceDetailController.RefreshForceTab(this,0);
          return;
        }
    }

    // Token : 0x6001467
    // RVA   : 0xBB13A0   Offset: 0xBAFBA0   Length: 0x21B
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
               (lVar3 = Component.GetComponent(lVar3,DAT_181d6b6c0)) == null) break;
            lVar1 = this.forceDetailTabGrid;
            if (*(int *)(lVar3 + 24) == this.nowShowForceID) {
              if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              if (plVar4 == (int64 *)0) break;
              (**(code **)(*plVar4 + 0x2a8))(plVar4);
            }
            else {
              if (((lVar1 == null) || (lVar3 = GameObject.get_transform(lVar1,0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,iVar5,0)) == null) break;
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              FUN_181098a50(local_18,0);
              if (plVar4 == (int64 *)0) break;
              (**(code **)(*plVar4 + 0x2a8))(plVar4);
            }
            lVar3 = this.forceDetailTabGrid;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6001468
    // RVA   : 0xBB1600   Offset: 0xBAFE00   Length: 0x2039
    public void ShowForceDetail(int targetForceID)
    {
        var plVar5 = *(int64*)(lVar5 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar9;
        ulong uVar10;
        ulong uVar11;
        long lVar13;
        int iVar14;
        uint uVar15;
        uint[] local_res20 = new uint[2];
        uint[] local_a8 = new uint[2];
        ulong local_a0;
        ulong local_98;
        ulong uStack_90;
        long local_88;
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
        local_98 = 0;
        uStack_90 = 0;
        local_88 = 0;
        if (this.nowShowForceID == targetForceID) {
          return;
        }
        this.nowShowForceID = targetForceID;
        ForceDetailController.RefreshForceTab(this,0);
        if (this.forceDetail != null) {
          GameObject.SetActive(this.forceDetail,1);
          if ((*pStatics_df90 != 0) &&
             (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            lVar5 = WorldData.GetForce(lVar5,targetForceID);
            local_80 = lVar5;
            if ((this.forceDetail != null) &&
               (((lVar6 = GameObject.get_transform(this.forceDetail,0), lVar6 != null &&
                 (lVar6 = Transform.Find(lVar6,"ForceName")) != null) &&
                (uVar7 = Component.GetComponent(lVar6,DAT_181d6d8c0), lVar5 != null)))) {
              LTLocalization.SetText(uVar7,*(uint64 *)(lVar5 + 24));
              uVar7 = this.baseDetailText;
              plVar8 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
              if (plVar8 != (int64 *)0) {
                if (("等级 " != 0) &&
                   (lVar6 = il2cpp_internal("等级 ",*(uint64 *)(*plVar8 + 64)), lVar6 == null
                   )) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar6 = "等级 ";
                if ((int)plVar8[3] == 0) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[4] = "等级 ";
                il2cpp_internal(plVar8 + 4,lVar6);
                uVar4 = *(uint32 *)(lVar5 + 52);
                lVar6 = GlobalData.GetNumText(uVar4,0);
                if ((lVar6 != null) &&
                   (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar8 + 64))) == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(plVar8 + 3) < 2) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[5] = lVar6;
                il2cpp_internal(plVar8 + 5,lVar6);
                if (("\n风格 " != 0) &&
                   (lVar6 = il2cpp_internal("\n风格 ",*(uint64 *)(*plVar8 + 64)), lVar6 == null
                   )) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar6 = "\n风格 ";
                if (*(uint32 *)(plVar8 + 3) < 3) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[6] = "\n风格 ";
                il2cpp_internal(plVar8 + 6,lVar6);
                lVar6 = *(int64 *)(lVar5 + 40);
                if ((lVar6 != null) &&
                   (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar8 + 64))) == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(plVar8 + 3) < 4) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[7] = lVar6;
                il2cpp_internal(plVar8 + 7,lVar6);
                if (("\n专长 " != 0) &&
                   (lVar6 = il2cpp_internal("\n专长 ",*(uint64 *)(*plVar8 + 64)), lVar6 == null
                   )) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar6 = "\n专长 ";
                if (*(uint32 *)(plVar8 + 3) < 5) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar8[8] = "\n专长 ";
                il2cpp_internal(plVar8 + 8,lVar6);
                uVar10 = String.Concat(plVar8,0);
                LTLocalization.SetText(uVar7,uVar10);
                plVar8 = this.baseDetailText;
                if (plVar8 != (int64 *)0) {
                  local_a0 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0));
                  iVar14 = 0;
                  lVar6 = *(int64 *)(lVar5 + 240);
                  lVar9 = "";
                  while (lVar6 != null) {
                    if (*(int *)(lVar6 + 24) <= iVar14) {
                      uVar7 = String.Concat(local_a0,lVar9,0);
                      (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
                      iVar14 = 0;
                      goto LAB_180bb1cd0;
                    }
                    lVar13 = "/";
                    if (iVar14 == 0) {
                      lVar13 = "";
                    }
                    if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) &&
                       (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                      il2cpp_runtime_class_init(DAT_181d4ef00);
                      lVar6 = *(int64 *)(lVar5 + 240);
                    }
                    lVar1 = *(int64 *)(pStatics_ef00 + 0x498);
                    if ((lVar6 == null) || (uVar4 = FUN_1800d6750(lVar6,iVar14,DAT_181d68270), lVar1 == null))
                    break;
                    uVar7 = FUN_180002f80(lVar1,uVar4,DAT_181d7c9c0);
                    lVar9 = String.Concat(lVar9,lVar13,uVar7,0);
                    iVar14 = iVar14 + 1;
                    lVar6 = *(int64 *)(lVar5 + 240);
                  }
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180bb1cd0:
        if (*(int64 *)(lVar5 + 248) == 0) throw; // [null/range check failed]
        if (*(int *)(*(int64 *)(lVar5 + 248) + 24) <= iVar14) {
          if (0 < *(int *)(lVar5 + 0x17c)) {
            plVar8 = this.baseDetailText;
            if (plVar8 == (int64 *)0) throw; // [null/range check failed]
            uVar7 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0));
            lVar6 = FUN_18046c100(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 224) == 0)) ||
               (lVar6 = FUN_1817cc780(*(int64 *)(lVar6 + 224),*(uint32 *)(lVar5 + 0x17c),
                                      DAT_181d925f0), lVar6 == null)) throw; // [null/range check failed]
            uVar10 = *(uint64 *)(lVar6 + 24);
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 0x180)) == null)
            throw; // [null/range check failed]
            cVar3 = FUN_181815240(lVar6,*(uint32 *)(lVar5 + 0x17c),DAT_181d67bf8);
            uVar2 = "\n特殊建筑 {0}({1}</color>)";
            uVar11 = "<color=grey>未解锁";
            if (cVar3) {
              uVar11 = String.Concat(*(uint64 *)(pStatics_ef00 + 0x260),
                                      "已解锁",0);
            }
            uVar10 = String.Format(uVar2,uVar10,uVar11,0);
            uVar7 = String.Concat(uVar7,uVar10,0);
            (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
          }
          plVar8 = this.baseDetailText;
          plVar12 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if ((plVar8 != (int64 *)0) &&
             (lVar6 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0)),
             plVar12 != (int64 *)0)) {
            if ((lVar6 != null) &&
               (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if ((int)plVar12[3] == 0) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[4] = lVar6;
            il2cpp_internal(plVar12 + 4,lVar6);
            if (("\n\n区域 " != 0) &&
               (lVar6 = il2cpp_internal("\n\n区域 ",*(uint64 *)(*plVar12 + 64))) == null)
            {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar6 = "\n\n区域 ";
            if (*(uint32 *)(plVar12 + 3) < 2) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[5] = "\n\n区域 ";
            il2cpp_internal(plVar12 + 5,lVar6);
            if (*(int64 *)(lVar5 + 96) != 0) {
              local_a8[0] = *(uint32 *)(*(int64 *)(lVar5 + 96) + 24);
              lVar6 = Int32.ToString(local_a8,0);
              if ((lVar6 != null) &&
                 (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              if (*(uint32 *)(plVar12 + 3) < 3) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar12[6] = lVar6;
              il2cpp_internal(plVar12 + 6,lVar6);
              if (("/" != 0) &&
                 (lVar6 = il2cpp_internal("/",*(uint64 *)(*plVar12 + 64))) == null
                 ) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar6 = "/";
              if (*(uint32 *)(plVar12 + 3) < 4) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              plVar12[7] = "/";
              il2cpp_internal(plVar12 + 7,lVar6);
              if (*(int64 *)(lVar5 + 0x148) != 0) {
                local_res20[0] = ForceSpeAddData.Get(*(int64 *)(lVar5 + 0x148),0,0);
                lVar6 = Single.ToString(local_res20,0);
                if ((lVar6 != null) &&
                   (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(plVar12 + 3) < 5) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar12[8] = lVar6;
                il2cpp_internal(plVar12 + 8,lVar6);
                uVar7 = String.Concat(plVar12,0);
                (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
                plVar8 = this.baseDetailText;
                plVar12 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
                if ((plVar8 != (int64 *)0) &&
                   (lVar6 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0)),
                   plVar12 != (int64 *)0)) {
                  if ((lVar6 != null) &&
                     (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if ((int)plVar12[3] == 0) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar12[4] = lVar6;
                  il2cpp_internal(plVar12 + 4,lVar6);
                  if (("\n弟子 " != 0) &&
                     (lVar6 = il2cpp_internal("\n弟子 ",*(uint64 *)(*plVar12 + 64)),
                     lVar6 == null)) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar6 = "\n弟子 ";
                  if (*(uint32 *)(plVar12 + 3) < 2) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar12[5] = "\n弟子 ";
                  il2cpp_internal(plVar12 + 5,lVar6);
                  lVar6 = Int32.ToString(lVar5 + 132,0);
                  if ((lVar6 != null) &&
                     (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  if (*(uint32 *)(plVar12 + 3) < 3) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar12[6] = lVar6;
                  il2cpp_internal(plVar12 + 6,lVar6);
                  if (("/" != 0) &&
                     (lVar6 = il2cpp_internal("/",*(uint64 *)(*plVar12 + 64)),
                     lVar6 == null)) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  lVar6 = "/";
                  if (*(uint32 *)(plVar12 + 3) < 4) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar12[7] = "/";
                  il2cpp_internal(plVar12 + 7,lVar6);
                  if (*(int64 *)(lVar5 + 0x148) != 0) {
                    local_res20[0] = ForceSpeAddData.Get(*(int64 *)(lVar5 + 0x148),1);
                    lVar6 = Single.ToString(local_res20,0);
                    if ((lVar6 != null) &&
                       (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null)
                    {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    if (*(uint32 *)(plVar12 + 3) < 5) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    plVar12[8] = lVar6;
                    il2cpp_internal(plVar12 + 8,lVar6);
                    uVar7 = String.Concat(plVar12,0);
                    (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
                    iVar14 = 0;
                    goto LAB_180bb22f0;
                  }
                }
              }
            }
          }
          throw; // [null/range check failed]
        }
        plVar8 = this.baseDetailText;
        if (plVar8 == (int64 *)0) throw; // [null/range check failed]
        uVar7 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0));
        lVar6 = *(int64 *)(pStatics_ef00 + 0x4a8);
        if ((*(int64 *)(lVar5 + 248) == 0) ||
           (uVar4 = FUN_1800d6750(*(int64 *)(lVar5 + 248),iVar14,DAT_181d68270), lVar6 == null))
        throw; // [null/range check failed]
        uVar10 = FUN_180002f80(lVar6,uVar4,DAT_181d7c9c0);
        uVar7 = String.Concat(uVar7,"/",uVar10,0);
        (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
        iVar14 = iVar14 + 1;
        goto LAB_180bb1cd0;
        LAB_180bb22f0:
        if (*(int64 *)(lVar5 + 136) == 0) throw; // [null/range check failed]
        if (*(int *)(*(int64 *)(lVar5 + 136) + 24) <= iVar14) {
          lVar6 = FUN_18046c0a0(0);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar6 + 32) + 156) == 1) {
            lVar6 = *(int64 *)(pStatics_ef00 + 0x3a0);
            if (lVar6 == null) throw; // [null/range check failed]
            cVar3 = FUN_181815240(lVar6,targetForceID,DAT_181d67bf8);
            if (!cVar3) {
              uVar7 = this.baseDetailText;
              lVar6 = FUN_18046c100(0);
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 208) == 0)) ||
                 (lVar6 = FUN_1817cc780(*(int64 *)(lVar6 + 208),targetForceID,DAT_181d94178)) == null)
              throw; // [null/range check failed]
              uVar10 = *(uint64 *)(lVar6 + 0x180);
              uVar10 = String.Format("\n\n<b>门派特性</b>\n{1}{0}</color>",uVar10,
                                      *(uint64 *)(pStatics_ef00 + 0x250),0);
              LTLocalization.AddText(uVar7,uVar10,0);
            }
          }
          LTLocalization.SetText(this.areaText,"",0);
          uVar15 = 0;
          lVar6 = 32;
          goto LAB_180bb2870;
        }
        plVar8 = this.baseDetailText;
        plVar12 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,10);
        if ((plVar8 == (int64 *)0) ||
           (lVar6 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0)),
           plVar12 == (int64 *)0)) throw; // [null/range check failed]
        if ((lVar6 != null) &&
           (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        if ((int)plVar12[3] == 0) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[4] = lVar6;
        il2cpp_internal(plVar12 + 4,lVar6);
        if (("\n" != 0) &&
           (lVar6 = il2cpp_internal("\n",*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        lVar6 = "\n";
        if (*(uint32 *)(plVar12 + 3) < 2) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[5] = "\n";
        il2cpp_internal(plVar12 + 5,lVar6);
        lVar6 = *(int64 *)(pStatics_ef00 + 0x430);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar6 = FUN_180002f80(lVar6,iVar14,DAT_181d7c9c0);
        if ((lVar6 != null) &&
           (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        if (*(uint32 *)(plVar12 + 3) < 3) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[6] = lVar6;
        il2cpp_internal(plVar12 + 6,lVar6);
        if ((" " != 0) &&
           (lVar6 = il2cpp_internal(" ",*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        lVar6 = " ";
        if (*(uint32 *)(plVar12 + 3) < 4) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[7] = " ";
        il2cpp_internal(plVar12 + 7,lVar6);
        if (*(int64 *)(lVar5 + 136) == 0) throw; // [null/range check failed]
        local_res20[0] = FUN_1800d6780(*(int64 *)(lVar5 + 136),iVar14,DAT_181d796d8);
        lVar6 = Single.ToString(local_res20,"f0",0);
        if ((lVar6 != null) &&
           (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        if (*(uint32 *)(plVar12 + 3) < 5) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[8] = lVar6;
        il2cpp_internal(plVar12 + 8,lVar6);
        if (("/" != 0) &&
           (lVar6 = il2cpp_internal("/",*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        lVar6 = "/";
        if (*(uint32 *)(plVar12 + 3) < 6) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[9] = "/";
        il2cpp_internal(plVar12 + 9,lVar6);
        if (*(int64 *)(lVar5 + 144) == 0) throw; // [null/range check failed]
        local_res20[0] = FUN_1800d6780(*(int64 *)(lVar5 + 144),iVar14,DAT_181d796d8);
        lVar6 = Single.ToString(local_res20,"f0",0);
        if ((lVar6 != null) &&
           (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        if (*(uint32 *)(plVar12 + 3) < 7) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[10] = lVar6;
        il2cpp_internal(plVar12 + 10,lVar6);
        if ((" (" != 0) &&
           (lVar6 = il2cpp_internal(" (",*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        lVar6 = " (";
        if (*(uint32 *)(plVar12 + 3) < 8) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[11] = " (";
        il2cpp_internal(plVar12 + 11,lVar6);
        if (*(int64 *)(lVar5 + 152) == 0) throw; // [null/range check failed]
        local_res20[0] = FUN_1800d6780(*(int64 *)(lVar5 + 152),iVar14,DAT_181d796d8);
        lVar6 = Single.ToString(local_res20,"+0;-0;0",0);
        if ((lVar6 != null) &&
           (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        if (*(uint32 *)(plVar12 + 3) < 9) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[12] = lVar6;
        il2cpp_internal(plVar12 + 12,lVar6);
        if ((")" != 0) &&
           (lVar6 = il2cpp_internal(")",*(uint64 *)(*plVar12 + 64))) == null) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        lVar6 = ")";
        if (*(uint32 *)(plVar12 + 3) < 10) {
          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar7,0);
        }
        plVar12[13] = ")";
        il2cpp_internal(plVar12 + 13,lVar6);
        uVar7 = String.Concat(plVar12,0);
        (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7);
        iVar14 = iVar14 + 1;
        goto LAB_180bb22f0;
        LAB_180bb2870:
        lVar9 = *(int64 *)(lVar5 + 96);
        if (lVar9 == null) throw; // [null/range check failed]
        if ((int)*(uint32 *)(lVar9 + 24) <= (int)uVar15) {
          iVar14 = 0;
          goto LAB_180bb2981;
        }
        if (*(uint32 *)(lVar9 + 24) <= uVar15) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int *)(lVar6 + *(int64 *)(lVar9 + 16)) != *(int *)(lVar5 + 56)) {
          plVar8 = this.areaText;
          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
          uVar7 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0));
          cVar3 = FUN_1816fd990(uVar7,"",0);
          lVar9 = "\n";
          if (cVar3) {
            lVar9 = "";
          }
          lVar13 = FUN_18046c0a0(0);
          if (lVar13 == null) throw; // [null/range check failed]
          lVar13 = *(int64 *)(lVar13 + 32);
          if (((*(int64 *)(lVar5 + 96) == 0) ||
              (uVar4 = FUN_1800d6750(*(int64 *)(lVar5 + 96),uVar15), lVar13 == null)) ||
             (lVar13 = WorldData.GetArea(lVar13,uVar4)) == null) throw; // [null/range check failed]
          uVar7 = String.Concat(lVar9,*(uint64 *)(lVar13 + 24));
          LTLocalization.AddText(plVar8,uVar7);
        }
        uVar15 = uVar15 + 1;
        lVar6 = lVar6 + 4;
        goto LAB_180bb2870;
        LAB_180bb2981:
        if (*(int64 *)(lVar5 + 104) == 0) throw; // [null/range check failed]
        if (*(int *)(*(int64 *)(lVar5 + 104) + 24) <= iVar14) {
          LTLocalization.SetText(this.favorText,"",0);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
             (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 72)) != null) {
            FUN_1817ff240(&local_68,lVar6,DAT_181d60878);
            local_98 = CONCAT44(uStack_64,local_68);
            uStack_90 = CONCAT44(uStack_5c,uStack_60);
            local_88 = local_58;
            goto LAB_180bb2af0;
          }
          throw; // [null/range check failed]
        }
        plVar8 = this.areaText;
        if (plVar8 == (int64 *)0) throw; // [null/range check failed]
        uVar7 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0));
        cVar3 = FUN_1816fd990(uVar7,"",0);
        lVar6 = "\n";
        if (cVar3) {
          lVar6 = "";
        }
        lVar9 = FUN_18046c0a0(0);
        if (lVar9 == null) throw; // [null/range check failed]
        lVar9 = *(int64 *)(lVar9 + 32);
        if (((*(int64 *)(lVar5 + 104) == 0) ||
            (uVar4 = FUN_1800d6750(*(int64 *)(lVar5 + 104),iVar14), lVar9 == null)) ||
           (lVar9 = WorldData.GetResourcePoint(lVar9,uVar4)) == null) throw; // [null/range check failed]
        uVar7 = String.Concat(lVar6,*(uint64 *)(lVar9 + 32));
        LTLocalization.AddText(plVar8,uVar7);
        iVar14 = iVar14 + 1;
        goto LAB_180bb2981;
        joined_r0x000180bb3099:
        iVar14 = iVar14 + -1;
        if (iVar14 < 0) {
          uVar7 = this.forceSkillGrid;
          GlobalData.SortChild(uVar7,0);
          return;
        }
        uVar7 = this.forceSkillGrid;
        if (*pStatics_e188 == 0) throw; // [null/range check failed]
        uVar10 = *(uint64 *)(*pStatics_e188 + 160);
        lVar6 = GlobalData.AddChild(uVar7,uVar10,0);
        if (lVar6 == null) throw; // [null/range check failed]
        lVar9 = GameObject.GetComponent(lVar6,DAT_181da0070);
        if ((plVar5 == 0) ||
           (lVar13 = *(int64 *)(plVar5 + 48)) == null) throw; // [null/range check failed]
        if (*(uint32 *)(lVar13 + 24) < 4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar13 = *(int64 *)(*(int64 *)(lVar13 + 16) + 56);
        if ((lVar13 == null) || (uVar7 = FUN_180002f80(lVar13,iVar14), lVar9 == null)) throw; // [null/range check failed]
        *(uint64 *)(lVar9 + 32) = uVar7;
        lVar9 = GameObject.GetComponent(lVar6,DAT_181da0070);
        if (lVar9 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar9 + 40) = 1;
        lVar6 = GameObject.GetComponent(lVar6,DAT_181da0070);
        if (lVar6 == null) throw; // [null/range check failed]
        ItemIconController.AutoSetName(lVar6,1);
        goto joined_r0x000180bb3099;
        LAB_180bb2af0:
        cVar3 = FUN_180d197a0(&local_98,DAT_181d66148);
        lVar6 = local_88;
        if (cVar3) {
          if (local_88 != lVar5) {
            uVar7 = this.favorText;
            plVar12 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,8);
            plVar8 = this.favorText;
            if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar10 = (**(code **)(*plVar8 + 0x5d8))(plVar8,*(uint64 *)(*plVar8 + 0x5e0));
            cVar3 = FUN_1816fd990(uVar10,"",0);
            lVar9 = "\n";
            if (cVar3) {
              lVar9 = "";
            }
            if (plVar12 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((lVar9 != null) &&
               (lVar13 = il2cpp_internal(lVar9,*(uint64 *)(*plVar12 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            FUN_180002fd0(plVar12,0,lVar9);
            if (*(int *)(pStatics_ef00 + 8) == 1) {
              lVar9 = *(int64 *)(pStatics_ef00 + 32);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar3 = FUN_181815240(lVar9,*(uint32 *)(lVar6 + 16),DAT_181d67bf8);
              lVar9 = "???";
              if (!(cVar3))
              {
                }
                else {
                if (lVar6 == null) {
                // WARNING: Subroutine does not return
                FUN_1800d6620();
                }
              }
              lVar9 = *(int64 *)(lVar6 + 24);
            }
            if ((lVar9 != null) &&
               (lVar13 = il2cpp_internal(lVar9,*(uint64 *)(*plVar12 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            FUN_180002fd0(plVar12,1,lVar9);
            if ((" " != 0) &&
               (lVar9 = il2cpp_internal(" ",*(uint64 *)(*plVar12 + 64))) == null)
            {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar9 = " ";
            if (*(uint32 *)(plVar12 + 3) < 3) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[6] = " ";
            il2cpp_internal(plVar12 + 6,lVar9);
            uVar4 = ForceData.GetForceFavor(lVar5,*(uint32 *)(lVar6 + 16),0);
            lVar9 = GlobalData.GetForceFavorLvText(uVar4,0);
            if ((lVar9 != null) &&
               (lVar13 = il2cpp_internal(lVar9,*(uint64 *)(*plVar12 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar12 + 3) < 4) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[7] = lVar9;
            il2cpp_internal(plVar12 + 7,lVar9);
            if (("(" != 0) &&
               (lVar9 = il2cpp_internal("(",*(uint64 *)(*plVar12 + 64))) == null)
            {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar9 = "(";
            if (*(uint32 *)(plVar12 + 3) < 5) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[8] = "(";
            il2cpp_internal(plVar12 + 8,lVar9);
            local_res20[0] = ForceData.GetForceFavor(lVar5,*(uint32 *)(lVar6 + 16),0);
            lVar9 = Single.ToString(local_res20,0);
            if ((lVar9 != null) &&
               (lVar13 = il2cpp_internal(lVar9,*(uint64 *)(*plVar12 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar12 + 3) < 6) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[9] = lVar9;
            il2cpp_internal(plVar12 + 9,lVar9);
            if ((") " != 0) &&
               (lVar9 = il2cpp_internal(") ",*(uint64 *)(*plVar12 + 64))) == null)
            {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar9 = ") ";
            if (*(uint32 *)(plVar12 + 3) < 7) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[10] = ") ";
            il2cpp_internal(plVar12 + 10,lVar9);
            lVar6 = ForceData.GetForceRelationshipText(lVar5,*(uint32 *)(lVar6 + 16));
            if ((lVar6 != null) &&
               (lVar9 = il2cpp_internal(lVar6,*(uint64 *)(*plVar12 + 64))) == null) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            if (*(uint32 *)(plVar12 + 3) < 8) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            plVar12[11] = lVar6;
            il2cpp_internal(plVar12 + 11,lVar6);
            uVar10 = String.Concat(plVar12,0);
            LTLocalization.AddText(uVar7,uVar10);
          }
          goto LAB_180bb2af0;
        }
        ZhSegment.Initialize(&local_98,DAT_181d660c8);
        uVar7 = this.detailText;
        if (*(int64 *)(lVar5 + 0x148) != 0) {
          uVar10 = ForceSpeAddData.GetDescribe(*(int64 *)(lVar5 + 0x148),1,0);
          LTLocalization.SetText(uVar7,uVar10,0);
          uVar7 = this.forceHeroGrid;
          GlobalData.DeleteAllChild(uVar7,0);
          GlobalData.DeleteAllChild(this.forceSkillGrid,0);
          lVar6 = local_78;
          iVar14 = 0;
          while (*(int64 *)(lVar5 + 112) != 0) {
            uVar7 = *(uint64 *)(lVar6 + 64);
            if (*(int *)(*(int64 *)(lVar5 + 112) + 24) <= iVar14) {
              GlobalData.SortChild(uVar7,0);
              if ((plVar5 != 0) &&
                 (lVar6 = *(int64 *)(plVar5 + 48)) != null) {
                if (*(uint32 *)(lVar6 + 24) < 4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 56);
                if (lVar6 != null) {
                  iVar14 = *(int *)(lVar6 + 24);
                  goto joined_r0x000180bb3099;
                }
              }
              break;
            }
            if (*pStatics_e188 == 0) break;
            uVar10 = *(uint64 *)(*pStatics_e188 + 144);
            lVar9 = GlobalData.AddChild(uVar7,uVar10,0);
            if (lVar9 == null) break;
            lVar13 = GameObject.GetComponent(lVar9,DAT_181d9fb20);
            uVar7 = ForceData.GetOwnHero(lVar5,iVar14);
            if (lVar13 == null) break;
            *(uint64 *)(lVar13 + 32) = uVar7;
            lVar13 = GameObject.GetComponent(lVar9,DAT_181d9fb20);
            if (lVar13 == null) break;
            *(uint32 *)(lVar13 + 24) = 0;
            lVar9 = GameObject.GetComponent(lVar9);
            if (lVar9 == null) break;
            HeroIconController.AutoSetName(lVar9);
            iVar14 = iVar14 + 1;
          }
        }
    }

    // Token : 0x6001469
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600146A
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <HideForceDetail>b__19_0()
    {
        if (this.forceDetailPanel != null) {
          GameObject.SetActive(this.forceDetailPanel,0,0);
          return;
        }
    }

}
