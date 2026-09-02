// ============================================================
// Type  : AreaUnitController
// Token : 0x2000144
// ============================================================

public class AreaUnitController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000808
    public AreaTileData areaTileData;

    // Token: 0x4000809
    public AreaBuildingIconController building;

    // Token: 0x400080A
    public List<GameObject> decorations;

    // Token: 0x400080B
    private static Color emptyColor;

    // Token: 0x400080C
    private static Color buildingColor;

    // Token: 0x400080D
    private static Color obstacleColor;

    // Token: 0x400080E
    private static Color roadColor;

    // Token: 0x400080F
    private GameObject buildEffect;

    // Token: 0x4000810
    private SimpleDetailText detailText;

    // Token: 0x4000811
    private Color targetColor;

    // Token: 0x4000812
    private SpriteRenderer tileRenderer;

    // Token: 0x4000813
    private bool showBuilgindSpe;

    // Token: 0x4000814
    private bool isOver;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A80
    // RVA   : 0x7F09E0   Offset: 0x7EF1E0   Length: 0x6E
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"BuildEffect",0);
          if (lVar1 != null) {
            uVar2 = Component.get_gameObject(lVar1,0);
            this.buildEffect = uVar2;
            return;
          }
        }
    }

    // Token : 0x6000A81
    // RVA   : 0x7F0A50   Offset: 0x7EF250   Length: 0x112
    private void Update()
    {
        int iVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uVar2 = this.building;
        this.showBuilgindSpe = 0;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          if (this.areaTileData == null) throw; // [null/range check failed]
          lVar3 = this.areaTileData.areaRoadData;
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
        LAB_1807f0af2:
            if (iVar1 != 0) goto LAB_1807f0af4;
          }
        }
        else {
          if ((this.building == null) ||
             (lVar3 = this.building.buildingData) == null)
          throw; // [null/range check failed]
          if ((*(int *)(lVar3 + 24) == 0) && (*(int *)(lVar3 + 28) == 0)) {
            iVar1 = *(int *)(lVar3 + 32);
            goto LAB_1807f0af2;
          }
        LAB_1807f0af4:
          this.showBuilgindSpe = 1;
        }
        lVar3 = this.buildEffect;
        if (!this.showBuilgindSpe) {
          if (lVar3 != null) {
            cVar4 = GameObject.get_activeSelf(lVar3,0);
            if (cVar4) {
              if (this.buildEffect == null) throw; // [null/range check failed]
              GameObject.SetActive(this.buildEffect,0,0);
            }
            return;
          }
        }
        else if (lVar3 != null) {
          cVar4 = GameObject.get_activeSelf(lVar3,0);
          if (cVar4) {
            return;
          }
          if (this.buildEffect != null) {
            GameObject.SetActive(this.buildEffect,1,0);
            return;
          }
        }
    }

    // Token : 0x6000A82
    // RVA   : 0x7F0780   Offset: 0x7EEF80   Length: 0x25D
    public void RefreshUnitColor()
    {
        var pStatics = *(int64*)(DAT_181d879b0 + 184);
        long lVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        ulong local_18;
        ulong uStack_10;
        puVar1 = (uint32 *)FUN_181098a50(&local_18,0);
        uVar3 = puVar1[1];
        uVar4 = puVar1[2];
        uVar5 = puVar1[3];
        this.targetColor = *puVar1;
        *(uint32 *)(this + 68) = uVar3;
        *(uint32 *)(this + 72) = uVar4;
        *(uint32 *)(this + 76) = uVar5;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
        if (lVar2 != null) {
          if (lVar2.tileType) {
            lVar2 = this.areaTileData;
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar2.tileType == 1) {
              lVar2 = pStatics;
              uVar3 = lVar2.tileType;
              uVar4 = *(uint32 *)(lVar2 + 52);
              uVar5 = lVar2.areaRoadData;
              uVar6 = *(uint32 *)(lVar2 + 60);
            }
            else if (lVar2.building == null) {
              puVar1 = *(uint32 **)(DAT_181d879b0 + 184);
              uVar3 = *puVar1;
              uVar4 = puVar1[1];
              uVar5 = puVar1[2];
              uVar6 = puVar1[3];
            }
            else if (*(int *)(lVar2.building + 16) < 0) {
              lVar2 = pStatics;
              uVar3 = lVar2.spriteRotateType;
              uVar4 = lVar2.spriteFlipX;
              uVar5 = lVar2.building;
              uVar6 = *(uint32 *)(lVar2 + 44);
            }
            else {
              lVar2 = pStatics;
              uVar3 = lVar2.name;
              uVar4 = *(uint32 *)(lVar2 + 20);
              uVar5 = lVar2.spriteName;
              uVar6 = *(uint32 *)(lVar2 + 28);
            }
            this.targetColor = uVar3;
            *(uint32 *)(this + 68) = uVar4;
            *(uint32 *)(this + 72) = uVar5;
            *(uint32 *)(this + 76) = uVar6;
          }
          if (this.isOver) {
            local_18 = 0;
            uStack_10 = 0;
            FUN_1809981e0(&local_18,this.targetColor * 0.6,*(float *)(this + 68) * 0.6,
                          *(float *)(this + 72) * 0.6,0x3f800000,0);
            this.targetColor = (uint32)local_18;
            *(uint32 *)(this + 68) = local_18._4_4_;
            *(uint32 *)(this + 72) = (uint32)uStack_10;
            *(uint32 *)(this + 76) = uStack_10._4_4_;
          }
          lVar2 = Component.GetComponent(this,DAT_181d6d540);
          if (lVar2 != null) {
            local_18 = this.targetColor;
            uStack_10 = *(uint64 *)(this + 72);
            SpriteRenderer.set_color(lVar2,&local_18,0);
            return;
          }
        }
    }

    // Token : 0x6000A83
    // RVA   : 0x7F01D0   Offset: 0x7EE9D0   Length: 0x2A9
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d87338 + 184);
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(pStatics + 16);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 48) == false) {
            return;
          }
          lVar1 = *(int64 *)(pStatics + 16);
          if (lVar1 != null) {
            if (*(char *)(lVar1 + 49) == false) {
              lVar1 = FUN_1807e85e0(0);
              uVar2 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                AreaBuildController.SetBuildTarget(lVar1,uVar2,0);
                return;
              }
            }
            else if (this.areaTileData != null) {
              if (this.areaTileData.tileType == null) {
                lVar1 = FUN_1807e85e0(0);
                uVar2 = Component.get_gameObject(this,0);
                if (lVar1 != null) {
                  AreaBuildController.MoveBuildTarget(lVar1,uVar2,0);
                  return;
                }
              }
              else {
                lVar1 = FUN_18046c0a0(0);
                if (lVar1 != null) {
                  GameController.ShowTextOnMouse(lVar1,"只能移动到空地上",0);
                  plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                  plVar4 = (int64 *)0;
                  if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
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

    // Token : 0x6000A84
    // RVA   : 0x7F0550   Offset: 0x7EED50   Length: 0x16C
    public void OnHover(bool _isOver)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        this.isOver = _isOver;
        AreaUnitController.RefreshUnitColor(this,0);
        if (this.isOver) {
          if (this.areaTileData == null) goto LAB_1807f06b7;
          uVar4 = this.detailText;
          if (this.areaTileData.tileType == 1) {
            cVar2 = Object.op_Equality(uVar4,0,0);
            if (cVar2) {
              lVar3 = Component.get_gameObject(this,0);
              if (lVar3 == null) goto LAB_1807f06b7;
              uVar4 = GameObject.AddComponent(lVar3,DAT_181d9cf90);
              this.detailText = uVar4;
              if (this.detailText == null) goto LAB_1807f06b7;
              this.detailText.forceUp = 1;
            }
            lVar3 = this.detailText;
            if (((this.areaTileData == null) ||
                (lVar1 = this.areaTileData.areaRoadData) == null) ||
               (uVar4 = AreaRoadData.GetRoadDescribe(lVar1,0), lVar3 == null)) {
        LAB_1807f06b7:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3.text = uVar4;
          }
          else {
            cVar2 = Object.op_Inequality(uVar4,0,0);
            uVar4 = "";
            if (!cVar2) {
              return;
            }
            if (this.detailText == null) goto LAB_1807f06b7;
            this.detailText.text = "";
          }
          il2cpp_internal(puVar5,uVar4);
        }
    }

    // Token : 0x6000A85
    // RVA   : 0x7F0480   Offset: 0x7EEC80   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A86
    // RVA   : 0x7F06C0   Offset: 0x7EEEC0   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A87
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000A88
    // RVA   : 0x7F0B70   Offset: 0x7EF370   Length: 0x13F
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d879b0 + 184);
        long lVar2;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        local_68 = 0;
        uStack_60 = 0;
        Color.ctor(&local_68,0x3f733333,0x3f800000,0x3f733333,0);
        puVar1 = *(uint32 **)(DAT_181d879b0 + 184);
        *puVar1 = (uint32)local_68;
        puVar1[1] = local_68._4_4_;
        puVar1[2] = (uint32)uStack_60;
        puVar1[3] = uStack_60._4_4_;
        local_58 = 0;
        uStack_50 = 0;
        Color.ctor(&local_58,0x3f800000,0x3f666666,0x3f4ccccd,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 16) = (uint32)local_58;
        *(uint32 *)(lVar2 + 20) = local_58._4_4_;
        *(uint32 *)(lVar2 + 24) = (uint32)uStack_50;
        *(uint32 *)(lVar2 + 28) = uStack_50._4_4_;
        local_48 = 0;
        uStack_40 = 0;
        Color.ctor(&local_48,0x3f800000,0x3f666666,0x3f666666,0);
        lVar2 = pStatics;
        *(uint32 *)(lVar2 + 32) = (uint32)local_48;
        *(uint32 *)(lVar2 + 36) = local_48._4_4_;
        *(uint32 *)(lVar2 + 40) = (uint32)uStack_40;
        *(uint32 *)(lVar2 + 44) = uStack_40._4_4_;
        local_38 = 0;
        uStack_30 = 0;
        Color.ctor(&local_38,0x3f666666,0x3f666666,0x3f800000,0);
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 48) = local_38;
        *(uint64 *)(lVar2 + 56) = uStack_30;
    }

}
