// ============================================================
// Type  : AreaIconController
// Token : 0x2000142
// ============================================================

public class AreaIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007F8
    public AreaData areaData;

    // Token: 0x40007F9
    public GameObject areaUIRoot;

    // Token: 0x40007FA
    public GameObject areaNameLabel;

    // Token: 0x40007FB
    public GameObject areaForceIcon;

    // Token: 0x40007FC
    public Image missionTarget;

    // Token: 0x40007FD
    public GameObject areaSafeRange;

    // Token: 0x40007FE
    public float safeRange;

    // Token: 0x40007FF
    public bool showAreaSafeSprite;

    // Token: 0x4000800
    private Color temp;

    // Token: 0x4000801
    private int showBelongForceID;

    // Token: 0x4000802
    private Vector3 areaUIOffset;

    // Token: 0x4000803
    private static List<Vector3> boxColliderSize;

    // Token: 0x4000804
    private SpriteVisibleController spriteVisible;

    // Token: 0x4000805
    private Text areaNameText;

    // Token: 0x4000806
    private Image areaCoverImage;

    // Token: 0x4000807
    private Image areaForceImage;

    // Token: 0x4000808
    private Transform areaSafeSpriteTrans;

    // Token: 0x4000809
    private BigmapNpcController playerArmyNpc;

    // Token: 0x400080A
    private int missionState;

    // Token: 0x400080B
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A72
    // RVA   : 0x51D630   Offset: 0x51C430   Length: 0x829
    public void Init()
    {
        var pStatics_b8e8 = *(int64*)(DAT_181e8b8e8 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        bool cVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        float fVar9;
        ulong uVar10;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        this.areaNameText = 0;
        this.areaCoverImage = 0;
        this.areaForceImage = 0;
        this.missionState = 0xffffffff;
        lVar5 = Component.get_transform(this,0);
        if (lVar5 != null) {
          lVar5 = Transform.Find(lVar5,"Sprite",0);
          if (lVar5 != null) {
            lVar5 = Component.GetComponent(lVar5,DAT_181e791b8);
            if ((this.areaData != null) && (*pStatics_b8e8 != 0)) {
              uVar6 = TextureController.LoadAtlasSprite
                                (*pStatics_b8e8,"AreaIconAtlas",
                                 this.areaData.spriteName,0);
              if (lVar5 != null) {
                SpriteRenderer.set_sprite(lVar5,uVar6,0);
                lVar7 = Component.GetComponent(this,DAT_181e76938);
                lVar5 = this.areaData;
                if (lVar5 != null) {
                  lVar3 = lVar5.speBoxColliderSize;
                  if (lVar3 == null) {
                    if (((*(byte *)(DAT_181e8c9b0 + 0x133) & 4) != 0) &&
                       (*(int *)(DAT_181e8c9b0 + 224) == 0)) {
                      il2cpp_runtime_class_init(DAT_181e8c9b0);
                      lVar5 = this.areaData;
                    }
                    lVar3 = **(int64 **)(DAT_181e8c9b0 + 184);
                    if ((lVar5 == null) || (lVar3 == null)) throw; // [null/range check failed]
                    uVar2 = lVar5.areaType;
                    if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar6 = *(uint64 *)
                             (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 12);
                    fVar9 = *(float *)(*(int64 *)(lVar3 + 16) + 40 + (int64)(int)uVar2 * 12);
                  }
                  else {
                    if (*(int *)(lVar3 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      lVar5 = this.areaData;
                    }
                    uVar1 = *(uint32 *)(*(int64 *)(lVar3 + 16) + 32);
                    if ((lVar5 = lVar5?.speBoxColliderSize) == null)
                    throw; // [null/range check failed]
                    if (lVar5.areaName < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    local_40 = 0.1;
                    fVar9 = 0.1;
                    uVar6 = CONCAT44(*(uint32 *)(lVar5.areaID + 36),uVar1);
                  }
                  if (lVar7 != null) {
                    local_58 = uVar6;
                    local_50 = fVar9;
                    BoxCollider.set_size(lVar7,&local_58,0);

                    if ((lVar5 = GameController.CheckShowSpeHero?.areaBranchDefenceUpgradeLeftTime) != null) {
                      lVar5 = GameObject.get_transform(lVar5,0);
                      if (lVar5 != null) {
                        lVar5 = Transform.Find(lVar5,"AreaUIPanel",0);
                        if (lVar5 != null) {
                          uVar6 = Component.get_gameObject(lVar5,0);
                          lVar5 = GameController.CheckShowSpeHero;
                          if (lVar5 != null) {
                            uVar10 = lVar5.areaTreasurePriceData;
                            uVar6 = GlobalData.AddChild(uVar6,uVar10,0);
                            this.areaUIRoot = uVar6;
                            if (this.areaUIRoot != null) {
                              lVar5 = GameObject.get_transform(this.areaUIRoot,0);
                              if (lVar5 != null) {
                                lVar5 = Transform.Find(lVar5,"AreaUI",0);
                                if (lVar5 != null) {
                                  lVar5 = Transform.Find(lVar5,"ForceIcon",0);
                                  if (lVar5 != null) {
                                    uVar6 = Component.get_gameObject(lVar5,0);
                                    this.areaForceIcon = uVar6;
                                    if (this.areaUIRoot != null) {
                                      lVar5 = GameObject.get_transform(this.areaUIRoot,0);
                                      if (lVar5 != null) {
                                        lVar5 = Transform.Find(lVar5,"AreaUI",0);
                                        if (lVar5 != null) {
                                          lVar5 = Transform.Find(lVar5,"AreaName",0);
                                          if (lVar5 != null) {
                                            uVar6 = Component.get_gameObject(lVar5,0);
                                            this.areaNameLabel = uVar6;
                                            if (this.areaUIRoot != null) {
                                              lVar5 = GameObject.get_transform
                                                                (this.areaUIRoot,0);
                                              if (lVar5 != null) {
                                                lVar5 = Transform.Find(lVar5,"MissionTarget",0);
                                                if (lVar5 != null) {
                                                  uVar6 = Component.GetComponent(lVar5,DAT_181e777b8);
                                                  this.missionTarget = uVar6;
                                                  il2cpp_internal((uint64 *)(this + 56),uVar6
                                                                     );
                                                  if (this.areaNameLabel != null) {
                                                    lVar5 = GameObject.get_transform
                                                                      (this.areaNameLabel,0);
                                                    if (lVar5 != null) {
                                                      lVar5 = Transform.Find(lVar5,"Label",0);
                                                      if (lVar5 != null) {
                                                        uVar6 = Component.GetComponent
                                                                          (lVar5,DAT_181e79538);
                                                        lVar5 = this.areaData;
                                                        if (lVar5 != null) {
                                                          cVar4 = FUN_180ad1200(*(uint64 *)
                                                                                 (lVar5 + 0x128),0);
                                                          if (!cVar4) {
                                                            uVar10 = lVar5.setAreaName;
                                                          }
                                                          else {
                                                            uVar10 = lVar5.areaName;
                                                          }
                                                          LTLocalization.SetText(uVar6,uVar10,0);
                                                          if (this.areaUIRoot != null) {
                                                            lVar5 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 32),0);
                                                            if (lVar5 != null) {
                                                              lVar5 = Transform.Find(lVar5,"AreaUI",
                                                                                      0);
                                                              if (lVar5 != null) {
                                                                uVar6 = Component.GetComponent
                                                                                  (lVar5,DAT_181e782b8);
                                                                if (((*(byte *)(DAT_181e65070 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181e65070 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }

                                                        LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                  (uVar6,0);
                                                        lVar5 = *(int64 *)
                                                                 (*(int64 *)(DAT_181e538e8 + 184) +
                                                                 0x438);
                                                        if ((this.areaData != null) &&
                                                           (lVar5 != null)) {
                                                          uVar2 = *(uint32 *)(this.areaData
                                                                           + 72);
                                                          if (lVar5.areaName <= uVar2) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          this.safeRange =
                                                               *(uint32 *)
                                                                (lVar5.areaID + 32 +
                                                                (int64)(int)uVar2 * 4);
                                                          if (this.areaSafeRange != null) {
                                                            lVar5 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 64),0);
                                                            fVar9 = this.safeRange;
                                                            puVar8 = (uint64 *)
                                                                     Vector3.get_one(local_28,0);
                                                            local_48 = *puVar8;
                                                            local_40 = *(float *)(puVar8 + 1);
                                                            local_50 = local_40 * fVar9;
                                                            local_58 = CONCAT44((float)((uint64)
                                                                                        local_48 >> 32)
                                                                                * fVar9,(float)local_48 *
                                                                                        fVar9);
                                                            if (lVar5 != null) {
                                                              local_48 = local_58;
                                                              local_40 = local_50;
                                                              Transform.set_localScale(lVar5,&local_48,0)
                                                              ;
                                                              AreaIconController.EnsureRefs(this,0);
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

    // Token : 0x6000A73
    // RVA   : 0x51DFF0   Offset: 0x51CDF0   Length: 0x163
    public void SetSafeRange()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x438);
        fVar1 = local_40;
        if ((this.areaData != null) && (lVar3 != null)) {
          uVar2 = this.areaData.areaType;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          this.safeRange =
               lVar3[uVar2];
          fVar1 = local_40;
          if (this.areaSafeRange != null) {
            lVar3 = GameObject.get_transform(this.areaSafeRange,0);
            fVar1 = this.safeRange;
            puVar4 = (uint64 *)Vector3.get_one(local_28,0);
            local_48 = *puVar4;
            local_40 = *(float *)(puVar4 + 1) * fVar1;
            local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar1,(float)local_48 * fVar1);
            fVar1 = *(float *)(puVar4 + 1);
            if (lVar3 != null) {
              local_48 = local_58;
              Transform.set_localScale(lVar3,&local_48,0);
              return;
            }
          }
        }
        local_40 = fVar1;
    }

    // Token : 0x6000A74
    // RVA   : 0x51D210   Offset: 0x51C010   Length: 0x41E
    private void EnsureRefs()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.spriteVisible;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) goto LAB_18051d629;
          lVar2 = Transform.Find(lVar2,"Sprite",0);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (cVar1) {
            if (lVar2 == null) goto LAB_18051d629;
            uVar3 = Component.GetComponent(lVar2,DAT_181e79238);
            this.spriteVisible = uVar3;
          }
        }
        uVar3 = this.areaNameText;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.areaNameLabel;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (((this.areaNameLabel == null) ||
                (lVar2 = GameObject.get_transform(this.areaNameLabel,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"Label",0)) == null) goto LAB_18051d629;
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            this.areaNameText = uVar3;
          }
        }
        uVar3 = this.areaCoverImage;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.areaNameLabel;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (((this.areaNameLabel == null) ||
                (lVar2 = GameObject.get_transform(this.areaNameLabel,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"Cover",0)) == null) goto LAB_18051d629;
            uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
            this.areaCoverImage = uVar3;
          }
        }
        uVar3 = this.areaForceImage;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.areaForceIcon;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.areaForceIcon == null) goto LAB_18051d629;
            uVar3 = GameObject.GetComponent(this.areaForceIcon,DAT_181e54f48);
            this.areaForceImage = uVar3;
          }
        }
        uVar3 = this.areaSafeSpriteTrans;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.areaSafeRange;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if ((this.areaSafeRange != null) &&
               (lVar2 = GameObject.get_transform(this.areaSafeRange,0)) != null) {
              uVar3 = Transform.Find(lVar2,"AreaSafeSprite",0);
              this.areaSafeSpriteTrans = uVar3;
              return;
            }
        LAB_18051d629:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000A75
    // RVA   : 0x51E310   Offset: 0x51D110   Length: 0x9A8
    private void Update()
    {
        bool cVar1;
        byte uVar2;
        int iVar3;
        long lVar4;
        long lVar6;
        ulong uVar8;
        ulong uVar9;
        float fVar11;
        float fVar12;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        AreaIconController.EnsureRefs(this,0);
        if (this.spriteVisible == null) goto LAB_18051ecb3;
        if (!this.spriteVisible.visible) {
          if (this.areaUIRoot == null) goto LAB_18051ecb3;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          if (lVar4 == null) goto LAB_18051ecb3;
          puVar5 = (uint64 *)Transform.get_localScale(local_38,lVar4,0);
          uVar8 = *puVar5;
          fVar11 = *(float *)(puVar5 + 1);
          puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
          local_68 = *puVar5;
          local_60 = *(float *)(puVar5 + 1);
          local_58 = uVar8;
          local_50 = fVar11;
          cVar1 = Vector3.op_Inequality(&local_58,&local_68,0);
          if (cVar1) {
            if (this.areaUIRoot == null) goto LAB_18051ecb3;
            lVar4 = GameObject.get_transform(this.areaUIRoot,0);
            puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
            if (lVar4 == null) goto LAB_18051ecb3;
            local_50 = *(float *)(puVar5 + 1);
            local_58 = *puVar5;
            Transform.set_localScale(lVar4,&local_58,0);
          }
        }
        else {
          lVar4 = GameController.CheckShowSpeHero;
          if (lVar4 == null) goto LAB_18051ecb3;
          fVar11 = (float)BigMapController.BigMapNowScale(lVar4,0);
          if (this.areaUIRoot == null) goto LAB_18051ecb3;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) goto LAB_18051ecb3;
          puVar5 = (uint64 *)Transform.get_position(&local_28,lVar6,0);
          local_50 = *(float *)(this + 108);
          local_58 = *(uint64 *)(this + 100);
          local_48 = *puVar5;
          local_40 = *(float *)(puVar5 + 1);
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * fVar11 +
                              (float)((uint64)local_48 >> 32),
                              (float)local_58 * fVar11 + (float)local_48);
          local_60 = local_50 * fVar11 + local_40;
          if (lVar4 == null) goto LAB_18051ecb3;
          local_48 = local_68;
          local_40 = local_60;
          Transform.set_position(lVar4,&local_48,0);
          puVar5 = (uint64 *)Vector3.get_one(&local_28,0);
          fVar11 = fVar11 + 0.5;
          local_48 = *puVar5;
          local_40 = *(float *)(puVar5 + 1);
          local_68 = CONCAT44(((float)((uint64)local_48 >> 32) * fVar11) / 1.5,
                              ((float)local_48 * fVar11) / 1.5);
          local_60 = (local_40 * fVar11) / 1.5;
          if (this.areaUIRoot == null) goto LAB_18051ecb3;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          fVar11 = local_60;
          uVar8 = local_68;
          if (lVar4 == null) goto LAB_18051ecb3;
          local_48 = local_68;
          local_40 = local_60;
          puVar5 = (uint64 *)Transform.get_localScale(&local_28,lVar4,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          cVar1 = Vector3.op_Inequality(&local_58,&local_48,0);
          if (cVar1) {
            if (this.areaUIRoot == null) goto LAB_18051ecb3;
            lVar4 = GameObject.get_transform(this.areaUIRoot,0);
            if (lVar4 == null) goto LAB_18051ecb3;
            local_48 = uVar8;
            local_40 = fVar11;
            Transform.set_localScale(lVar4,&local_48,0);
          }
          fVar11 = this.refreshTime;
          fVar12 = (float)RealTime.get_deltaTime(0);
          fVar11 = fVar11 - fVar12;
          this.refreshTime = fVar11;
          if (0.0 < fVar11) goto LAB_18051ea4a;
          this.refreshTime = 0x3e4ccccd;
          if (this.areaData == null) goto LAB_18051ecb3;
          lVar4 = AreaData.GetForce(this.areaData,0);
          if ((lVar4 == null) || (iVar3 = lVar4.xScale, iVar3 < 0)) {
            if (this.areaData == null) goto LAB_18051ecb3;
            iVar3 = this.areaData.belongForceID;
          }
          if (this.showBelongForceID == iVar3) {
            if (this.areaData == null) goto LAB_18051ecb3;
            if (!(this.areaData.areaIconDirty))
            {
              }
              else {
            }
            lVar4 = this.areaData;
            uVar8 = this.areaNameText;
            this.showBelongForceID = iVar3;
            if (lVar4 == null) goto LAB_18051ecb3;
            cVar1 = FUN_180ad1200(lVar4.setAreaName,0);
            if (!cVar1) {
              uVar9 = lVar4.setAreaName;
            }
            else {
              uVar9 = lVar4.areaName;
            }
            LTLocalization.SetText(uVar8,uVar9,0);
            if (this.areaData == null) goto LAB_18051ecb3;
            this.areaData.areaIconDirty = 0;
            if (this.showBelongForceID == -1) {
              plVar10 = this.areaCoverImage;
              puVar7 = (uint32 *)FUN_180f24d00(&local_28,0);
              if (plVar10 == (int64 *)0) goto LAB_18051ecb3;
              local_28 = *puVar7;
              uStack_24 = puVar7[1];
              uStack_20 = puVar7[2];
              uStack_1c = puVar7[3];
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
              plVar10 = this.areaForceImage;
              puVar7 = (uint32 *)FUN_180af4e90(&local_28,0);
              if (plVar10 == (int64 *)0) goto LAB_18051ecb3;
              local_28 = *puVar7;
              uStack_24 = puVar7[1];
              uStack_20 = puVar7[2];
              uStack_1c = puVar7[3];
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
            }
            else {
              lVar4 = FUN_1802106e0(0);
              if ((lVar4 == null) || (lVar4.areaStartLv == null)) goto LAB_18051ecb3;
              lVar4 = WorldData.GetForce(lVar4.areaStartLv,this.showBelongForceID,0);
              if (lVar4 == null) goto LAB_18051ecb3;
              uVar8 = String.Concat("#",lVar4.people,0);
              ColorUtility.TryParseHtmlString(uVar8,this + 80,0);
              plVar10 = this.areaCoverImage;
              if (plVar10 == (int64 *)0) goto LAB_18051ecb3;
              local_28 = this.temp;
              uStack_24 = *(uint32 *)(this + 84);
              uStack_20 = *(uint32 *)(this + 88);
              uStack_1c = *(uint32 *)(this + 92);
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
              lVar6 = this.areaForceImage;
              uVar8 = ForceData.GetForceIcon(lVar4,0);
              if (lVar6 == null) goto LAB_18051ecb3;
              Image.set_sprite(lVar6,uVar8,0);
            }
          }
          lVar4 = this.areaData;
          if (lVar4 == null) goto LAB_18051ecb3;
          if (lVar4.plotNumCount < 1) {
            iVar3 = 0;
            if (0 < lVar4.missionNumCount) {
              iVar3 = 2;
            }
          }
          else {
            iVar3 = 1;
          }
          if (this.missionState != iVar3) {
            plVar10 = this.missionTarget;
            this.missionState = iVar3;
            if (iVar3 == 1) {
              lVar4 = FUN_180210d00(0);
              if (lVar4 == null) goto LAB_18051ecb3;
              uVar8 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","问号",0);
              if (plVar10 == (int64 *)0) goto LAB_18051ecb3;
              Image.set_sprite(plVar10,uVar8,0);
              plVar10 = this.missionTarget;
              puVar7 = (uint32 *)Color.get_yellow(&local_28,0);
            }
            else if (iVar3 == 2) {
              lVar4 = FUN_180210d00(0);
              if (lVar4 == null) goto LAB_18051ecb3;
              uVar8 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","任务目标",0);
              if (plVar10 == (int64 *)0) goto LAB_18051ecb3;
              Image.set_sprite(plVar10,uVar8,0);
              plVar10 = this.missionTarget;
              puVar7 = (uint32 *)FUN_180f24d00(&local_28,0);
            }
            else {
              puVar7 = (uint32 *)FUN_180af4e90(&local_28,0);
            }
            if (plVar10 == (int64 *)0) goto LAB_18051ecb3;
            local_28 = *puVar7;
            uStack_24 = puVar7[1];
            uStack_20 = puVar7[2];
            uStack_1c = puVar7[3];
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
          }
        }
        LAB_18051ea4a:
        uVar8 = this.playerArmyNpc;
        cVar1 = Object.op_Equality(uVar8,0,0);
        if (cVar1) {
          lVar4 = GameController.CheckShowSpeHero;
          if (lVar4 == null) goto LAB_18051ecb3;
          uVar8 = lVar4.support;
          cVar1 = Object.op_Inequality(uVar8,0,0);
          if (cVar1) {
            lVar4 = FUN_180210220(0);
            if ((lVar4 == null) || (lVar4.support == null)) goto LAB_18051ecb3;
            uVar8 = GameObject.GetComponent(lVar4.support,DAT_181e53760);
            this.playerArmyNpc = uVar8;
          }
        }
        uVar8 = this.playerArmyNpc;
        cVar1 = Object.op_Inequality(uVar8,0,0);
        if (cVar1) {
          if (this.playerArmyNpc == null) {
        LAB_18051ecb3:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar8 = this.playerArmyNpc.areaSafeRange;
          uVar9 = this.areaSafeRange;
          cVar1 = Object.op_Equality(uVar8,uVar9,0);
          if (cVar1) {
            uVar2 = 1;
            goto LAB_18051ec1a;
          }
        }
        uVar8 = MouseController.get_hoveredObject(0);
        uVar9 = Component.get_gameObject(this,0);
        uVar2 = Object.op_Equality(uVar8,uVar9,0);
        LAB_18051ec1a:
        AreaIconController.ShowAreaSafeSprite(this,uVar2,0);
    }

    // Token : 0x6000A76
    // RVA   : 0x51DE60   Offset: 0x51CC60   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90e50 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          BigMapController.SetPlayerMoveTargetArea(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000A77
    // RVA   : 0x51E160   Offset: 0x51CF60   Length: 0x1A6
    public void ShowAreaSafeSprite(bool show)
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        uVar4 = this.areaSafeSpriteTrans;
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (cVar2) {
          uVar4 = this.areaSafeRange;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (cVar2) {
            if ((this.areaSafeRange == null) ||
               (lVar3 = GameObject.get_transform(this.areaSafeRange,0)) == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar4 = Transform.Find(lVar3,"AreaSafeSprite",0);
            *puVar1 = uVar4;
            il2cpp_internal(puVar1,uVar4);
          }
        }
        if (!show) {
          if (!this.showAreaSafeSprite) {
            return;
          }
          this.showAreaSafeSprite = 0;
          uVar4 = *puVar1;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            return;
          }
          uVar5 = 0;
        }
        else {
          if (this.showAreaSafeSprite) {
            return;
          }
          this.showAreaSafeSprite = 1;
          uVar4 = *puVar1;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            return;
          }
          uVar5 = 0x3f800000;
        }
        ShortcutExtensions.DOScale(*puVar1,uVar5,0x3e99999a,0);
    }

    // Token : 0x6000A78
    // RVA   : 0x51DF30   Offset: 0x51CD30   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000A79
    // RVA   : 0x51DF90   Offset: 0x51CD90   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000A7A
    // RVA   : 0x51EDE0   Offset: 0x51DBE0   Length: 0x48
    public void /*ctor*/()
    {
        *(uint64 *)(this + 100) = 0x3e800000be4ccccd;
        *(uint32 *)(this + 108) = 0;
        this.showBelongForceID = 0xfffffc19;
        this.missionState = 0xffffffff;
        FUN_180ae8740(0,0);
    }

    // Token : 0x6000A7B
    // RVA   : 0x51ECC0   Offset: 0x51DAC0   Length: 0x114
    private static void /*cctor*/()
    {
        long lVar2;
        uint local_18;
        uint local_14;
        uint local_10;
        lVar2 = il2cpp_internal(DAT_181e78ba8);
        FUN_1810f3480(lVar2,DAT_181e8e1d8);
        if (lVar2 != null) {
          local_18 = 0x40000000;
          local_14 = 0x40000000;
          local_10 = 0x3dcccccd;
          FUN_181756920(lVar2,&local_18,DAT_181e8e258);
          local_18 = 0x3fcccccd;
          local_14 = 0x3fb33333;
          local_10 = 0x3dcccccd;
          FUN_181756920(lVar2,&local_18,DAT_181e8e258);
          local_18 = 0x3fcccccd;
          local_14 = 0x3fb33333;
          local_10 = 0x3dcccccd;
          FUN_181756920(lVar2,&local_18,DAT_181e8e258);
          plVar1 = *(int64 **)(DAT_181e8c9b0 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
