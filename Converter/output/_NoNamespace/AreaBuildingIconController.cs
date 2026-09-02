// ============================================================
// Type  : AreaBuildingIconController
// Token : 0x200013E
// ============================================================

public class AreaBuildingIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007B2
    public AreaBuildingData buildingData;

    // Token: 0x40007B3
    public AreaUnitController areaTile;

    // Token: 0x40007B4
    public GameObject buildingUI;

    // Token: 0x40007B5
    public SkeletonAnimation skeletonAnimation;

    // Token: 0x40007B6
    public GameObject destroyObstacleSprite;

    // Token: 0x40007B7
    public GameObject upgradeHintSprite;

    // Token: 0x40007B8
    public GameObject highLightObj;

    // Token: 0x40007B9
    public bool highLight;

    // Token: 0x40007BA
    public bool mouseIsOver;

    // Token: 0x40007BB
    private Vector3 buildingUIOffset;

    // Token: 0x40007BC
    private Color hoverColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A27
    // RVA   : 0xA19740   Offset: 0xA17F40   Length: 0xC4D
    private void Update()
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar7;
        float fVar9;
        float fVar10;
        ulong local_78;
        float local_70;
        ulong local_68;
        float fStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        float fStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 uStack_40;
        uint64 local_38;
        uint64 uStack_30;
        if ((this.areaTile == null) ||
           (lVar3 = this.areaTile.areaTileData) == null) goto LAB_180a1a37c;
        if (lVar3.shopItemList == null) {
          AreaBuildingIconController.SelfDestroy(this,0);
          return;
        }
        uVar4 = this.buildingUI;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          lVar3 = this.buildingData;
          if (lVar3 == null) goto LAB_180a1a37c;
          if (-1 < lVar3.buildingID) {
            lVar3 = AreaBuildingData.DataBase(lVar3,0);
            if (lVar3 == null) goto LAB_180a1a37c;
            if (lVar3.missionDatas != 5) {
              lVar3 = FUN_18046bac0(0);
              if (lVar3 == null) goto LAB_180a1a37c;
              uVar4 = *(uint64 *)(lVar3 + 112);
              lVar3 = FUN_18046bac0(0);
              if (lVar3 == null) goto LAB_180a1a37c;
              uVar7 = *(uint64 *)(lVar3 + 120);
              uVar4 = GlobalData.AddChild(uVar4,uVar7,0);
              this.buildingUI = uVar4;
              if ((((this.buildingUI == null) ||
                   (lVar3 = GameObject.get_transform(this.buildingUI,0)) == null) ||
                  (lVar3 = Transform.Find(lVar3,"Back",0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BuildingName",0)) == null) goto LAB_180a1a37c;
              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              if ((this.buildingData == null) ||
                 (lVar3 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
              goto LAB_180a1a37c;
              LTLocalization.SetText(uVar4,lVar3.buildTimeLeft,0);
            }
          }
        }
        else {
          if (((this.buildingUI == null) ||
              (lVar3 = GameObject.get_transform(this.buildingUI,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuildingLv",0)) == null) goto LAB_180a1a37c;
          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          if (this.buildingData == null) goto LAB_180a1a37c;
          uVar1 = this.buildingData.lv;
          uVar7 = GlobalData.GetNumText(uVar1,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (this.buildingUI == null) goto LAB_180a1a37c;
          lVar3 = GameObject.get_transform(this.buildingUI,0);
          lVar5 = Component.get_transform(this,0);
          if (lVar5 == null) goto LAB_180a1a37c;
          puVar8 = (uint64 *)Transform.get_position(&local_58,lVar5,0);
          local_68 = *puVar8;
          fStack_60 = *(float *)(puVar8 + 1);
          local_78 = this.buildingUIOffset;
          local_70 = *(float *)(this + 92);
          lVar5 = FUN_18046bac0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 72) == 0)) ||
             (lVar5 = GameObject.get_transform(*(int64 *)(lVar5 + 72),0)) == null)
          goto LAB_180a1a37c;
          pfVar6 = (float *)Transform.get_localScale(&local_58,lVar5,0);
          fVar10 = *pfVar6;
          local_58 = CONCAT44(local_78._4_4_ * fVar10 + local_68._4_4_,
                              (float)local_78 * fVar10 + (float)local_68);
          fStack_50 = local_70 * fVar10 + fStack_60;
          if (lVar3 == null) goto LAB_180a1a37c;
          local_68 = local_58;
          fStack_60 = fStack_50;
          Transform.set_position(lVar3,&local_68,0);
          if (this.buildingUI == null) goto LAB_180a1a37c;
          lVar3 = GameObject.get_transform(this.buildingUI,0);
          puVar8 = (uint64 *)Vector3.get_one(&local_68,0);
          fStack_50 = *(float *)(puVar8 + 1);
          local_58 = *puVar8;
          lVar5 = FUN_18046bac0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 72) == 0)) ||
             (lVar5 = GameObject.get_transform(*(int64 *)(lVar5 + 72),0)) == null)
          goto LAB_180a1a37c;
          pfVar6 = (float *)Transform.get_localScale(&local_68,lVar5,0);
          fVar10 = *pfVar6;
          lVar5 = FUN_18046bac0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 72) == 0)) ||
             (lVar5 = GameObject.get_transform(*(int64 *)(lVar5 + 72),0)) == null)
          goto LAB_180a1a37c;
          pfVar6 = (float *)Transform.get_localScale(&local_68,lVar5,0);
          if (1.0 < *pfVar6 || *pfVar6 == 1.0) {
            fVar9 = 0.5;
          }
          else {
            fVar9 = 0.75;
          }
          fVar10 = (fVar10 - 1.0) * fVar9 + 1.0;
          fStack_60 = fStack_50 * fVar10;
          local_68 = CONCAT44(local_58._4_4_ * fVar10,(float)local_58 * fVar10);
          if (lVar3 == null) goto LAB_180a1a37c;
          local_58 = local_68;
          fStack_50 = fStack_60;
          Transform.set_localScale(lVar3,&local_58,0);
        }
        if ((!this.highLight) && (!this.mouseIsOver)) {
          if (this.highLightObj == null) goto LAB_180a1a37c;
          cVar2 = GameObject.get_activeSelf(this.highLightObj,0);
          if (cVar2) {
            lVar3 = this.highLightObj;
            if (lVar3 == null) goto LAB_180a1a37c;
            uVar4 = 0;
        LAB_180a19d13:
            GameObject.SetActive(lVar3,uVar4,0);
          }
        }
        else {
          if (this.highLightObj == null) goto LAB_180a1a37c;
          cVar2 = GameObject.get_activeSelf(this.highLightObj,0);
          if (!cVar2) {
            lVar3 = this.highLightObj;
            if (lVar3 == null) goto LAB_180a1a37c;
            uVar4 = 1;
            goto LAB_180a19d13;
          }
        }
        if (this.buildingData == null) goto LAB_180a1a37c;
        if (this.buildingData.buildingID == -1) {
          lVar3 = FUN_1807e85e0(0);
          if (lVar3 == null) goto LAB_180a1a37c;
          if (!lVar3.missionDatas) {
        LAB_180a1a29c:
            uVar4 = this.destroyObstacleSprite;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              if (this.destroyObstacleSprite == null) goto LAB_180a1a37c;
              cVar2 = GameObject.get_activeSelf(this.destroyObstacleSprite,0);
              if (cVar2) {
                lVar3 = this.destroyObstacleSprite;
                if (lVar3 == null) goto LAB_180a1a37c;
                uVar4 = 0;
        LAB_180a1a2f5:
                GameObject.SetActive(lVar3,uVar4,0);
              }
            }
          }
          else {
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 == null) goto LAB_180a1a37c;
            cVar2 = GameController.ObstacleCanDestroy(lVar3,this.buildingData,0);
            if (!cVar2) goto LAB_180a1a29c;
            uVar4 = this.destroyObstacleSprite;
            cVar2 = Object.op_Equality(uVar4,0,0);
            if (cVar2) {
              uVar4 = Component.get_gameObject(this,0);
              lVar3 = FUN_18046c6c0(0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar7 = TextureController.LoadAtlasSprite(lVar3,"UIAtlas","建筑模式_铲除",0);
              local_48 = 0;
              uStack_40 = 0;
              local_58 = 0xbe8000003e800000;
              fStack_50 = -1.0;
              FUN_1815cf310(&local_48,&local_58,DAT_181d92dc0);
              puVar8 = (uint64 *)Vector3.get_one(&local_78,0);
              local_68 = *puVar8;
              fStack_60 = *(float *)(puVar8 + 1) * 0.6;
              local_58 = CONCAT44((float)((uint64)local_68 >> 32) * 0.6,(float)local_68 * 0.6);
              local_38 = 0;
              uStack_30 = 0;
              fStack_50 = fStack_60;
              FUN_1815cf310(&local_38,&local_58,DAT_181d92dc0);
              local_58 = local_38;
              fStack_50 = (float)uStack_30;
              uStack_4c = uStack_30._4_4_;
              local_68 = local_48;
              fStack_60 = (float)uStack_40;
              uStack_5c = uStack_40._4_4_;
              uVar4 = GlobalData.AddSprite(uVar4,"DestroySprite",uVar7,&local_68,&local_58,0);
              this.destroyObstacleSprite = uVar4;
            }
            if (this.destroyObstacleSprite == null) goto LAB_180a1a37c;
            cVar2 = GameObject.get_activeSelf(this.destroyObstacleSprite,0);
            if (!cVar2) {
              lVar3 = this.destroyObstacleSprite;
              if (lVar3 == null) goto LAB_180a1a37c;
              uVar4 = 1;
              goto LAB_180a1a2f5;
            }
          }
          uVar4 = this.upgradeHintSprite;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            return;
          }
          uVar4 = this.upgradeHintSprite;
          Object.Destroy(uVar4,0);
          this.upgradeHintSprite = 0;
          this = this + 64;
          goto LAB_180a1a033;
        }
        lVar3 = FUN_1807e85e0(0);
        if (lVar3 == null) goto LAB_180a1a37c;
        if (!lVar3.missionDatas) {
        LAB_180a19f6b:
          uVar4 = this.upgradeHintSprite;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (cVar2) {
            if (this.upgradeHintSprite == null) {
        LAB_180a1a37c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = GameObject.get_activeSelf(this.upgradeHintSprite,0);
            if (cVar2) {
              lVar3 = this.upgradeHintSprite;
              if (lVar3 == null) goto LAB_180a1a37c;
              uVar4 = 0;
        LAB_180a19fc4:
              GameObject.SetActive(lVar3,uVar4,0);
            }
          }
        }
        else {
          lVar3 = FUN_18046c0a0(0);
          if (lVar3 == null) goto LAB_180a1a37c;
          cVar2 = GameController.BuildingCanUpgrade(lVar3,this.buildingData,0);
          if (!cVar2) goto LAB_180a19f6b;
          uVar4 = this.upgradeHintSprite;
          cVar2 = Object.op_Equality(uVar4,0,0);
          if (cVar2) {
            uVar4 = Component.get_gameObject(this,0);
            lVar3 = FUN_18046c6c0(0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar7 = TextureController.LoadAtlasSprite(lVar3,"UIAtlas","建筑模式_升级",0);
            local_38 = 0;
            uStack_30 = 0;
            local_58 = 0xbe8000003e800000;
            fStack_50 = -1.0;
            FUN_1815cf310(&local_38,&local_58,DAT_181d92dc0);
            puVar8 = (uint64 *)Vector3.get_one(&local_78,0);
            local_68 = *puVar8;
            fStack_60 = *(float *)(puVar8 + 1) * 0.6;
            local_58 = CONCAT44((float)((uint64)local_68 >> 32) * 0.6,(float)local_68 * 0.6);
            local_48 = 0;
            uStack_40 = 0;
            fStack_50 = fStack_60;
            FUN_1815cf310(&local_48,&local_58,DAT_181d92dc0);
            local_58 = local_48;
            fStack_50 = (float)uStack_40;
            uStack_4c = uStack_40._4_4_;
            local_68 = local_38;
            fStack_60 = (float)uStack_30;
            uStack_5c = uStack_30._4_4_;
            uVar4 = GlobalData.AddSprite(uVar4,"UpgradeHintSprite",uVar7,&local_68,&local_58,0);
            this.upgradeHintSprite = uVar4;
          }
          if (this.upgradeHintSprite == null) goto LAB_180a1a37c;
          cVar2 = GameObject.get_activeSelf(this.upgradeHintSprite,0);
          if (!cVar2) {
            lVar3 = this.upgradeHintSprite;
            if (lVar3 == null) goto LAB_180a1a37c;
            uVar4 = 1;
            goto LAB_180a19fc4;
          }
        }
        uVar4 = this.destroyObstacleSprite;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          return;
        }
        uVar4 = this.destroyObstacleSprite;
        Object.Destroy(uVar4,0);
        this.destroyObstacleSprite = 0;
        this = this + 56;
        LAB_180a1a033:
        il2cpp_internal(this,0);
    }

    // Token : 0x6000A28
    // RVA   : 0xA19650   Offset: 0xA17E50   Length: 0xE8
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

    // Token : 0x6000A29
    // RVA   : 0xA18E20   Offset: 0xA17620   Length: 0x508
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        long lVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 221) != false) {
            return;
          }
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
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
                lVar1 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
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
          lVar1 = FUN_1807e85e0(0);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(char *)(lVar1 + 49) == false) {
            lVar1 = FUN_1807e85e0(0);
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
            lVar1 = FUN_18046c0a0(0);
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
                lVar1 = FUN_1807e85e0(0);
                uVar2 = Component.get_gameObject(this,0);
                if (lVar1 != null) {
                  AreaBuildController.MoveBuildTarget(lVar1,uVar2,0);
                  return;
                }
                throw; // [null/range check failed]
              }
              lVar1 = FUN_18046c0a0(0);
              uVar2 = "无法与未完工建筑交换位置";
              if (lVar1 == null) throw; // [null/range check failed]
              goto LAB_180a191ad;
            }
            lVar1 = FUN_18046c0a0(0);
            uVar2 = "无法与主要建筑交换位置";
          }
          if (lVar1 != null) {
        LAB_180a191ad:
            GameController.ShowTextOnMouse(lVar1,uVar2,0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
            plVar6 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
              plVar6 = plVar3;
            }
            NGUITools.PlaySound(plVar6,0);
            return;
          }
        }
    }

    // Token : 0x6000A2A
    // RVA   : 0xA19400   Offset: 0xA17C00   Length: 0x181
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
            puVar3 = (uint32 *)FUN_181098a50(&local_18,0);
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
          uStack_14 = *(uint32 *)(this + 100);
          uStack_10 = *(uint32 *)(this + 104);
          uStack_c = *(uint32 *)(this + 108);
          SkeletonExtensions.SetColor(*(uint64 *)(lVar1 + 192),&local_18,0);
          lVar4 = Component.GetComponent(this,DAT_181d6ccc0);
          lVar1 = this.buildingData;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
          if ((lVar2 != null) && (lVar1 != null)) {
            uVar5 = AreaBuildingData.GetBuildingText(lVar1,1,*(uint8 *)(lVar2 + 48),1,0);
            if (lVar4 != null) {
              *(uint64 *)(lVar4 + 24) = uVar5;
              return;
            }
          }
        }
    }

    // Token : 0x6000A2B
    // RVA   : 0xA19330   Offset: 0xA17B30   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A2C
    // RVA   : 0xA19590   Offset: 0xA17D90   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (lVar1 != null) {
          AreaController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000A2D
    // RVA   : 0xA1A390   Offset: 0xA18B90   Length: 0x73
    public void /*ctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        this.buildingUIOffset = 0x3dcccccdbd75c28f;
        *(uint32 *)(this + 92) = 0;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f400000,0x3f400000,0x3f400000,0);
        this.hoverColor = (uint32)local_18;
        *(uint32 *)(this + 100) = local_18._4_4_;
        *(uint32 *)(this + 104) = (uint32)uStack_10;
        *(uint32 *)(this + 108) = uStack_10._4_4_;
        FUN_18044ef50(this,0);
    }

}
