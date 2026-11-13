// ============================================================
// Type  : AreaBuildingIconController
// Token : 0x200013E
// ============================================================

public class AreaBuildingIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007AE
    public AreaBuildingData buildingData;

    // Token: 0x40007AF
    public AreaUnitController areaTile;

    // Token: 0x40007B0
    public GameObject buildingUI;

    // Token: 0x40007B1
    public SkeletonAnimation skeletonAnimation;

    // Token: 0x40007B2
    public GameObject destroyObstacleSprite;

    // Token: 0x40007B3
    public GameObject upgradeHintSprite;

    // Token: 0x40007B4
    public GameObject highLightObj;

    // Token: 0x40007B5
    public bool highLight;

    // Token: 0x40007B6
    public bool mouseIsOver;

    // Token: 0x40007B7
    private Vector3 buildingUIOffset;

    // Token: 0x40007B8
    private Text buildingLvText;

    // Token: 0x40007B9
    private int shownBuildingLv;

    // Token: 0x40007BA
    private int shownLanguageVersion;

    // Token: 0x40007BB
    private float buildHintTimer;

    // Token: 0x40007BC
    private const float BuildHintCheckInterval;

    // Token: 0x40007BD
    private Color hoverColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A28
    // RVA   : 0x7933A0   Offset: 0x7921A0   Length: 0xDD6
    private void Update()
    {
        int iVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        ulong uVar8;
        float fVar10;
        float fVar11;
        ulong local_88;
        float local_80;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        float local_60;
        ulong local_58;
        float fStack_50;
        uint32 uStack_4c;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint64 uStack_30;
        if ((this.areaTile == null) ||
           (lVar4 = this.areaTile.areaTileData) == null) goto LAB_180794165;
        if (lVar4.shopItemList == null) {
          AreaBuildingIconController.SelfDestroy(this,0);
          return;
        }
        uVar5 = this.buildingUI;
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (!cVar3) {
          lVar4 = this.buildingData;
          if (lVar4 == null) goto LAB_180794165;
          if (-1 < lVar4.buildingID) {
            lVar4 = AreaBuildingData.DataBase(lVar4,0);
            if (lVar4 == null) goto LAB_180794165;
            if (lVar4.missionDatas != 5) {
              lVar4 = FUN_180210060(0);
              if (lVar4 == null) goto LAB_180794165;
              uVar5 = *(uint64 *)(lVar4 + 112);
              lVar4 = FUN_180210060(0);
              if (lVar4 == null) goto LAB_180794165;
              uVar8 = *(uint64 *)(lVar4 + 120);
              uVar5 = GlobalData.AddChild(uVar5,uVar8,0);
              this.buildingUI = uVar5;
              if ((((this.buildingUI == null) ||
                   (lVar4 = GameObject.get_transform(this.buildingUI,0)) == null) ||
                  (lVar4 = Transform.Find(lVar4,"Back",0)) == null) ||
                 (lVar4 = Transform.Find(lVar4,"BuildingName",0)) == null) goto LAB_180794165;
              uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
              if ((this.buildingData == null) ||
                 (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
              goto LAB_180794165;
              uVar8 = lVar4.buildTimeLeft;
              LTLocalization.SetText(uVar5,uVar8,0);
            }
          }
        }
        else {
          uVar5 = this.buildingLvText;
          cVar3 = Object.op_Equality(uVar5,0,0);
          if (cVar3) {
            if (((this.buildingUI == null) ||
                (lVar4 = GameObject.get_transform(this.buildingUI,0)) == null) ||
               (lVar4 = Transform.Find(lVar4,"BuildingLv",0)) == null) goto LAB_180794165;
            uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
            this.buildingLvText = uVar5;
          }
          if (this.buildingData == null) goto LAB_180794165;
          iVar1 = this.buildingData.lv;
          iVar2 = *(int *)(*(int64 *)(DAT_181e64c70 + 184) + 8);
          if ((iVar1 != this.shownBuildingLv) || (iVar2 != this.shownLanguageVersion)) {
            uVar5 = this.buildingLvText;
            this.shownBuildingLv = iVar1;
            this.shownLanguageVersion = iVar2;
            uVar8 = GlobalData.GetNumText(iVar1,0);
            LTLocalization.SetText(uVar5,uVar8,0);
          }

          if (((lVar4 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56)?.missionNumCount) == null) ||
             (lVar4 = GameObject.get_transform(lVar4,0)) == null) goto LAB_180794165;
          pfVar6 = (float *)Transform.get_localScale(&local_58,lVar4,0);
          fVar11 = *pfVar6;
          if (this.buildingUI == null) goto LAB_180794165;
          lVar4 = GameObject.get_transform(this.buildingUI,0);
          lVar7 = Component.get_transform(this,0);
          if (lVar7 == null) goto LAB_180794165;
          puVar9 = (uint64 *)Transform.get_position(&local_48,lVar7,0);
          local_78 = this.buildingUIOffset;
          uStack_70 = CONCAT44(uStack_70._4_4_,*(float *)(this + 92));
          local_58 = *puVar9;
          fStack_50 = *(float *)(puVar9 + 1);
          local_88 = CONCAT44((float)((uint64)local_78 >> 32) * fVar11 +
                              (float)((uint64)local_58 >> 32),
                              (float)local_78 * fVar11 + (float)local_58);
          local_80 = *(float *)(this + 92) * fVar11 + fStack_50;
          local_68 = local_58;
          local_60 = fStack_50;
          if (lVar4 == null) goto LAB_180794165;
          local_68 = local_88;
          local_60 = local_80;
          Transform.set_position(lVar4,&local_68,0);
          if (this.buildingUI == null) goto LAB_180794165;
          lVar4 = GameObject.get_transform(this.buildingUI,0);
          puVar9 = (uint64 *)Vector3.get_one(&local_48,0);
          if (1.0 <= fVar11) {
            fVar10 = 0.5;
          }
          else {
            fVar10 = 0.75;
          }
          local_58 = *puVar9;
          fStack_50 = *(float *)(puVar9 + 1);
          fVar11 = (fVar11 - 1.0) * fVar10 + 1.0;
          local_80 = fStack_50 * fVar11;
          local_88 = CONCAT44((float)((uint64)local_58 >> 32) * fVar11,(float)local_58 * fVar11);
          local_68 = local_58;
          local_60 = fStack_50;
          if (lVar4 == null) goto LAB_180794165;
          local_68 = local_88;
          local_60 = local_80;
          Transform.set_localScale(lVar4,&local_68,0);
        }
        if ((!this.highLight) && (!this.mouseIsOver)) {
          if (this.highLightObj == null) goto LAB_180794165;
          cVar3 = GameObject.get_activeSelf(this.highLightObj,0);
          if (cVar3) {
            lVar4 = this.highLightObj;
            if (lVar4 == null) goto LAB_180794165;
            uVar5 = 0;
        LAB_180793aa0:
            GameObject.SetActive(lVar4,uVar5,0);
          }
        }
        else {
          if (this.highLightObj == null) goto LAB_180794165;
          cVar3 = GameObject.get_activeSelf(this.highLightObj,0);
          if (!cVar3) {
            lVar4 = this.highLightObj;
            if (lVar4 == null) goto LAB_180794165;
            uVar5 = 1;
            goto LAB_180793aa0;
          }
        }
        fVar11 = this.buildHintTimer;
        fVar10 = (float)Time.get_unscaledDeltaTime(0);
        fVar11 = fVar11 - fVar10;
        this.buildHintTimer = fVar11;
        if (0.0 < fVar11) {
          lVar4 = FUN_1805185c0(0);
          if (lVar4 == null) goto LAB_180794165;
          if (lVar4.missionDatas) {
            return;
          }
        }
        this.buildHintTimer = 0x3e800000;
        if (this.buildingData == null) goto LAB_180794165;
        if (this.buildingData.buildingID == -1) {
          lVar4 = FUN_1805185c0(0);
          if (lVar4 == null) goto LAB_180794165;
          if (!lVar4.missionDatas) {
        LAB_180794085:
            uVar5 = this.destroyObstacleSprite;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (cVar3) {
              if (this.destroyObstacleSprite == null) goto LAB_180794165;
              cVar3 = GameObject.get_activeSelf(this.destroyObstacleSprite,0);
              if (cVar3) {
                lVar4 = this.destroyObstacleSprite;
                if (lVar4 == null) goto LAB_180794165;
                uVar5 = 0;
        LAB_1807940de:
                GameObject.SetActive(lVar4,uVar5,0);
              }
            }
          }
          else {
            lVar4 = FUN_1802106e0(0);
            if (lVar4 == null) goto LAB_180794165;
            cVar3 = GameController.ObstacleCanDestroy(lVar4,this.buildingData,0);
            if (!cVar3) goto LAB_180794085;
            uVar5 = this.destroyObstacleSprite;
            cVar3 = Object.op_Equality(uVar5,0,0);
            if (cVar3) {
              uVar5 = Component.get_gameObject(this,0);
              lVar4 = FUN_180210d00(0);
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar8 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","建筑模式_铲除",0);
              local_78 = 0;
              uStack_70 = 0;
              local_88 = 0xbe8000003e800000;
              local_80 = -1.0;
              FUN_180de6c10(&local_78,&local_88,DAT_181e9d678);
              puVar9 = (uint64 *)Vector3.get_one(&local_48,0);
              local_58 = *puVar9;
              local_60 = *(float *)(puVar9 + 1) * 0.6;
              local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.6,(float)local_58 * 0.6);
              local_38 = 0;
              uStack_30 = 0;
              fStack_50 = local_60;
              FUN_180de6c10(&local_38,&local_68,DAT_181e9d678);
              local_48 = (uint32)local_38;
              uStack_44 = local_38._4_4_;
              uStack_40 = (float)uStack_30;
              uStack_3c = uStack_30._4_4_;
              local_58 = local_78;
              fStack_50 = (float)uStack_70;
              uStack_4c = uStack_70._4_4_;
              uVar5 = GlobalData.AddSprite(uVar5,"DestroySprite",uVar8,&local_58,&local_48,0);
              this.destroyObstacleSprite = uVar5;
            }
            if (this.destroyObstacleSprite == null) goto LAB_180794165;
            cVar3 = GameObject.get_activeSelf(this.destroyObstacleSprite,0);
            if (!cVar3) {
              lVar4 = this.destroyObstacleSprite;
              if (lVar4 == null) goto LAB_180794165;
              uVar5 = 1;
              goto LAB_1807940de;
            }
          }
          uVar5 = this.upgradeHintSprite;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (!cVar3) {
            return;
          }
          uVar5 = this.upgradeHintSprite;
          Object.Destroy(uVar5,0);
          this.upgradeHintSprite = 0;
          this = this + 64;
          goto LAB_180793e1c;
        }
        lVar4 = FUN_1805185c0(0);
        if (lVar4 == null) goto LAB_180794165;
        if (!lVar4.missionDatas) {
        LAB_180793d54:
          uVar5 = this.upgradeHintSprite;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (cVar3) {
            if (this.upgradeHintSprite == null) {
        LAB_180794165:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar3 = GameObject.get_activeSelf(this.upgradeHintSprite,0);
            if (cVar3) {
              lVar4 = this.upgradeHintSprite;
              if (lVar4 == null) goto LAB_180794165;
              uVar5 = 0;
        LAB_180793dad:
              GameObject.SetActive(lVar4,uVar5,0);
            }
          }
        }
        else {
          lVar4 = FUN_1802106e0(0);
          if (lVar4 == null) goto LAB_180794165;
          cVar3 = GameController.BuildingCanUpgrade(lVar4,this.buildingData,0);
          if (!cVar3) goto LAB_180793d54;
          uVar5 = this.upgradeHintSprite;
          cVar3 = Object.op_Equality(uVar5,0,0);
          if (cVar3) {
            uVar5 = Component.get_gameObject(this,0);
            lVar4 = FUN_180210d00(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar8 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","建筑模式_升级",0);
            local_38 = 0;
            uStack_30 = 0;
            local_88 = 0xbe8000003e800000;
            local_80 = -1.0;
            FUN_180de6c10(&local_38,&local_88,DAT_181e9d678);
            puVar9 = (uint64 *)Vector3.get_one(&local_48,0);
            local_58 = *puVar9;
            local_60 = *(float *)(puVar9 + 1) * 0.6;
            local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.6,(float)local_58 * 0.6);
            local_78 = 0;
            uStack_70 = 0;
            fStack_50 = local_60;
            FUN_180de6c10(&local_78,&local_68,DAT_181e9d678);
            local_48 = (uint32)local_78;
            uStack_44 = local_78._4_4_;
            uStack_40 = (float)uStack_70;
            uStack_3c = uStack_70._4_4_;
            local_58 = local_38;
            fStack_50 = (float)uStack_30;
            uStack_4c = uStack_30._4_4_;
            uVar5 = GlobalData.AddSprite(uVar5,"UpgradeHintSprite",uVar8,&local_58,&local_48,0);
            this.upgradeHintSprite = uVar5;
          }
          if (this.upgradeHintSprite == null) goto LAB_180794165;
          cVar3 = GameObject.get_activeSelf(this.upgradeHintSprite,0);
          if (!cVar3) {
            lVar4 = this.upgradeHintSprite;
            if (lVar4 == null) goto LAB_180794165;
            uVar5 = 1;
            goto LAB_180793dad;
          }
        }
        uVar5 = this.destroyObstacleSprite;
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (!cVar3) {
          return;
        }
        uVar5 = this.destroyObstacleSprite;
        Object.Destroy(uVar5,0);
        this.destroyObstacleSprite = 0;
        this = this + 56;
        LAB_180793e1c:
        il2cpp_internal(this,0);
    }

    // Token : 0x6000A29
    // RVA   : 0x7932B0   Offset: 0x7920B0   Length: 0xE8
    public void SelfDestroy()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = this.buildingUI;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.buildingUI;
          Object.Destroy(uVar1,0);
        }
        lVar3 = Component.get_gameObject(this,0);
        if (lVar3 != null) {
          GameObject.SetActive(lVar3,0,0);
          uVar1 = Component.get_gameObject(this,0);
          Object.Destroy(uVar1,0);
          return;
        }
    }

    // Token : 0x6000A2A
    // RVA   : 0x792A80   Offset: 0x791880   Length: 0x508
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        long lVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 221) != false) {
            return;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c5b8 + 184) + 16);
          if (lVar1 == null) throw; // [null/range check failed]
          if (!lVar1.missionDatas) {
            lVar1 = this.buildingData;
            if (lVar1 != null) {
              if (lVar1.buildingID < 0) {
                return;
              }
              lVar1 = AreaBuildingData.DataBase(lVar1,0);
              if ((lVar1 != null) && (lVar1.areaID != null)) {
                if (*(int *)(lVar1.areaID + 24) < 1) {
                  return;
                }
                uVar2 = this.buildingData;
                lVar1 = *(int64 *)(*(int64 *)(DAT_181e942d8 + 184) + 8);
                lVar4 = Component.get_transform(this,0);
                if ((lVar4 != null) &&
                   (puVar5 = (uint64 *)Transform.get_position(local_18,lVar4,0), lVar1 != null)) {
                  local_28 = *puVar5;
                  local_20 = *(uint32 *)(puVar5 + 1);
                  BuildingUIController.EnterBuilding(lVar1,uVar2,&local_28,0);
                  return;
                }
              }
            }
            throw; // [null/range check failed]
          }
          lVar1 = FUN_1805185c0(0);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(char *)(lVar1 + 49) == false) {
            lVar1 = FUN_1805185c0(0);
            uVar2 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              AreaBuildController.SetBuildTarget(lVar1,uVar2,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar1 = this.buildingData;
          if (lVar1 == null) throw; // [null/range check failed]
          if (lVar1.buildingID == -1) {
            lVar1 = FUN_1802106e0(0);
            uVar2 = "无法与障碍交换位置";
          }
          else {
            lVar1 = AreaBuildingData.DataBase(lVar1,0);
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(char *)(lVar1 + 53) == false) {
              lVar1 = this.buildingData;
              if (lVar1 == null) throw; // [null/range check failed]
              if (((lVar1.buildTimeLeft < 1) && (lVar1.destroyTimeLeft < 1)) &&
                 (lVar1.upgradeTimeLeft < 1)) {
                lVar1 = FUN_1805185c0(0);
                uVar2 = Component.get_gameObject(this,0);
                if (lVar1 != null) {
                  AreaBuildController.MoveBuildTarget(lVar1,uVar2,0);
                  return;
                }
                throw; // [null/range check failed]
              }
              lVar1 = FUN_1802106e0(0);
              uVar2 = "无法与未完工建筑交换位置";
              if (lVar1 == null) throw; // [null/range check failed]
              goto LAB_180792e0d;
            }
            lVar1 = FUN_1802106e0(0);
            uVar2 = "无法与主要建筑交换位置";
          }
          if (lVar1 != null) {
        LAB_180792e0d:
            GameController.ShowTextOnMouse(lVar1,uVar2,0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar6 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
              plVar6 = plVar3;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x6000A2B
    // RVA   : 0x793060   Offset: 0x791E60   Length: 0x181
    public void OnHover(bool isOver)
    {
        long lVar1;
        long lVar2;
        long lVar4;
        ulong uVar5;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.skeletonAnimation;
        this.mouseIsOver = isOver;
        if (!isOver) {
          if (lVar1 != null) {
            uVar5 = *(uint64 *)(lVar1 + 192);
            puVar3 = (uint32 *)FUN_180f24d00(&local_18,0);
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            SkeletonExtensions.SetColor(uVar5,&local_18,0);
            return;
          }
        }
        else if (lVar1 != null) {
          local_18 = this.hoverColor;
          uStack_14 = *(uint32 *)(this + 120);
          uStack_10 = *(uint32 *)(this + 124);
          uStack_c = *(uint32 *)(this + 128);
          SkeletonExtensions.SetColor(*(uint64 *)(lVar1 + 192),&local_18,0);
          lVar4 = Component.GetComponent(this,DAT_181e788b8);
          lVar1 = this.buildingData;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e8c5b8 + 184) + 16);
          if ((lVar2 != null) && (lVar1 != null)) {
            uVar5 = AreaBuildingData.GetBuildingText(lVar1,1,*(uint8 *)(lVar2 + 48),1,0);
            if (lVar4 != null) {
              *(uint64 *)(lVar4 + 24) = uVar5;
              return;
            }
          }
        }
    }

    // Token : 0x6000A2C
    // RVA   : 0x792F90   Offset: 0x791D90   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A2D
    // RVA   : 0x7931F0   Offset: 0x791FF0   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A2E
    // RVA   : 0x794180   Offset: 0x792F80   Length: 0x7B
    public void /*ctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        this.buildingUIOffset = 0x3dcccccdbd75c28f;
        *(uint32 *)(this + 92) = 0;
        this.shownBuildingLv = 0xffffffff80000000;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f400000,0x3f400000,0x3f400000,0);
        this.hoverColor = (uint32)local_18;
        *(uint32 *)(this + 120) = local_18._4_4_;
        *(uint32 *)(this + 124) = (uint32)uStack_10;
        *(uint32 *)(this + 128) = uStack_10._4_4_;
        FUN_180ae8740(this,0);
    }

}
