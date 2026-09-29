// ============================================================
// Type  : AreaIconController
// Token : 0x2000146
// ============================================================

public class AreaIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000816
    public AreaData areaData;

    // Token: 0x4000817
    public GameObject areaUIRoot;

    // Token: 0x4000818
    public GameObject areaNameLabel;

    // Token: 0x4000819
    public GameObject areaForceIcon;

    // Token: 0x400081A
    public Image missionTarget;

    // Token: 0x400081B
    public GameObject areaSafeRange;

    // Token: 0x400081C
    public float safeRange;

    // Token: 0x400081D
    public bool showAreaSafeSprite;

    // Token: 0x400081E
    private Color temp;

    // Token: 0x400081F
    private int showBelongForceID;

    // Token: 0x4000820
    private Vector3 areaUIOffset;

    // Token: 0x4000821
    private static List<Vector3> boxColliderSize;

    // Token: 0x4000822
    private SpriteVisibleController spriteVisible;

    // Token: 0x4000823
    private Text areaNameText;

    // Token: 0x4000824
    private Image areaCoverImage;

    // Token: 0x4000825
    private Image areaForceImage;

    // Token: 0x4000826
    private Transform areaSafeSpriteTrans;

    // Token: 0x4000827
    private BigmapNpcController playerArmyNpc;

    // Token: 0x4000828
    private int missionState;

    // Token: 0x4000829
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A93
    // RVA   : 0x7EB2C0   Offset: 0x7EA6C0   Length: 0x829
    public void Init()
    {
        var pStatics_b4a8 = *(int64*)(DAT_181dab4a8 + 184);
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
            lVar5 = Component.GetComponent(lVar5,DAT_181d95df8);
            if ((this.areaData != null) && (*pStatics_b4a8 != 0)) {
              uVar6 = TextureController.LoadAtlasSprite
                                (*pStatics_b4a8,"AreaIconAtlas",
                                 this.areaData.spriteName,0);
              if (lVar5 != null) {
                SpriteRenderer.set_sprite(lVar5,uVar6,0);
                lVar7 = Component.GetComponent(this,DAT_181d935f8);
                lVar5 = this.areaData;
                if (lVar5 != null) {
                  lVar3 = lVar5.speBoxColliderSize;
                  if (lVar3 == null) {
                    if (((*(byte *)(DAT_181dac868 + 0x133) & 4) != 0) &&
                       (*(int *)(DAT_181dac868 + 224) == 0)) {
                      il2cpp_runtime_class_init(DAT_181dac868);
                      lVar5 = this.areaData;
                    }
                    lVar3 = **(int64 **)(DAT_181dac868 + 184);
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
                                                  uVar6 = Component.GetComponent(lVar5,DAT_181d94478);
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
                                                                          (lVar5,DAT_181d96178);
                                                        lVar5 = this.areaData;
                                                        if (lVar5 != null) {
                                                          cVar4 = FUN_180d75bc0(*(uint64 *)
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
                                                                                  (lVar5,DAT_181d94f78);
                                                                if (((*(byte *)(DAT_181d84cb0 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d84cb0 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }

                                                        LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                  (uVar6,0);
                                                        lVar5 = *(int64 *)
                                                                 (*(int64 *)(DAT_181d73d40 + 184) +
                                                                 0x430);
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

    // Token : 0x6000A94
    // RVA   : 0x7EBC80   Offset: 0x7EB080   Length: 0x163
    public void SetSafeRange()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x430);
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

    // Token : 0x6000A95
    // RVA   : 0x7EAEA0   Offset: 0x7EA2A0   Length: 0x41E
    private void EnsureRefs()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.spriteVisible;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) goto LAB_1807eb2b9;
          lVar2 = Transform.Find(lVar2,"Sprite",0);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (cVar1) {
            if (lVar2 == null) goto LAB_1807eb2b9;
            uVar3 = Component.GetComponent(lVar2,DAT_181d95e78);
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
               (lVar2 = Transform.Find(lVar2,"Label",0)) == null) goto LAB_1807eb2b9;
            uVar3 = Component.GetComponent(lVar2,DAT_181d96178);
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
               (lVar2 = Transform.Find(lVar2,"Cover",0)) == null) goto LAB_1807eb2b9;
            uVar3 = Component.GetComponent(lVar2,DAT_181d94478);
            this.areaCoverImage = uVar3;
          }
        }
        uVar3 = this.areaForceImage;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.areaForceIcon;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.areaForceIcon == null) goto LAB_1807eb2b9;
            uVar3 = GameObject.GetComponent(this.areaForceIcon,DAT_181d71e80);
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
        LAB_1807eb2b9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000A96
    // RVA   : 0x7EBFA0   Offset: 0x7EB3A0   Length: 0x9A8
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
        if (this.spriteVisible == null) goto LAB_1807ec943;
        if (!this.spriteVisible.visible) {
          if (this.areaUIRoot == null) goto LAB_1807ec943;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          if (lVar4 == null) goto LAB_1807ec943;
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
            if (this.areaUIRoot == null) goto LAB_1807ec943;
            lVar4 = GameObject.get_transform(this.areaUIRoot,0);
            puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
            if (lVar4 == null) goto LAB_1807ec943;
            local_50 = *(float *)(puVar5 + 1);
            local_58 = *puVar5;
            Transform.set_localScale(lVar4,&local_58,0);
          }
        }
        else {
          lVar4 = GameController.CheckShowSpeHero;
          if (lVar4 == null) goto LAB_1807ec943;
          fVar11 = (float)BigMapController.BigMapNowScale(lVar4,0);
          if (this.areaUIRoot == null) goto LAB_1807ec943;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) goto LAB_1807ec943;
          puVar5 = (uint64 *)Transform.get_position(&local_28,lVar6,0);
          local_50 = *(float *)(this + 108);
          local_58 = *(uint64 *)(this + 100);
          local_48 = *puVar5;
          local_40 = *(float *)(puVar5 + 1);
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * fVar11 +
                              (float)((uint64)local_48 >> 32),
                              (float)local_58 * fVar11 + (float)local_48);
          local_60 = local_50 * fVar11 + local_40;
          if (lVar4 == null) goto LAB_1807ec943;
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
          if (this.areaUIRoot == null) goto LAB_1807ec943;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          fVar11 = local_60;
          uVar8 = local_68;
          if (lVar4 == null) goto LAB_1807ec943;
          local_48 = local_68;
          local_40 = local_60;
          puVar5 = (uint64 *)Transform.get_localScale(&local_28,lVar4,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          cVar1 = Vector3.op_Inequality(&local_58,&local_48,0);
          if (cVar1) {
            if (this.areaUIRoot == null) goto LAB_1807ec943;
            lVar4 = GameObject.get_transform(this.areaUIRoot,0);
            if (lVar4 == null) goto LAB_1807ec943;
            local_48 = uVar8;
            local_40 = fVar11;
            Transform.set_localScale(lVar4,&local_48,0);
          }
          fVar11 = this.refreshTime;
          fVar12 = (float)RealTime.get_deltaTime(0);
          fVar11 = fVar11 - fVar12;
          this.refreshTime = fVar11;
          if (0.0 < fVar11) goto LAB_1807ec6da;
          this.refreshTime = 0x3e4ccccd;
          if (this.areaData == null) goto LAB_1807ec943;
          lVar4 = AreaData.GetForce(this.areaData,0);
          if ((lVar4 == null) || (iVar3 = lVar4.xScale, iVar3 < 0)) {
            if (this.areaData == null) goto LAB_1807ec943;
            iVar3 = this.areaData.belongForceID;
          }
          if (this.showBelongForceID == iVar3) {
            if (this.areaData == null) goto LAB_1807ec943;
            if (!(this.areaData.areaIconDirty))
            {
              }
              else {
            }
            lVar4 = this.areaData;
            uVar8 = this.areaNameText;
            this.showBelongForceID = iVar3;
            if (lVar4 == null) goto LAB_1807ec943;
            cVar1 = FUN_180d75bc0(lVar4.setAreaName,0);
            if (!cVar1) {
              uVar9 = lVar4.setAreaName;
            }
            else {
              uVar9 = lVar4.areaName;
            }
            LTLocalization.SetText(uVar8,uVar9,0);
            if (this.areaData == null) goto LAB_1807ec943;
            this.areaData.areaIconDirty = 0;
            if (this.showBelongForceID == -1) {
              plVar10 = this.areaCoverImage;
              puVar7 = (uint32 *)FUN_1810d3b80(&local_28,0);
              if (plVar10 == (int64 *)0) goto LAB_1807ec943;
              local_28 = *puVar7;
              uStack_24 = puVar7[1];
              uStack_20 = puVar7[2];
              uStack_1c = puVar7[3];
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
              plVar10 = this.areaForceImage;
              puVar7 = (uint32 *)FUN_180d995f0(&local_28,0);
              if (plVar10 == (int64 *)0) goto LAB_1807ec943;
              local_28 = *puVar7;
              uStack_24 = puVar7[1];
              uStack_20 = puVar7[2];
              uStack_1c = puVar7[3];
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
            }
            else {
              lVar4 = FUN_18046c0a0(0);
              if ((lVar4 == null) || (lVar4.areaStartLv == null)) goto LAB_1807ec943;
              lVar4 = WorldData.GetForce(lVar4.areaStartLv,this.showBelongForceID,0);
              if (lVar4 == null) goto LAB_1807ec943;
              uVar8 = String.Concat("#",lVar4.people,0);
              ColorUtility.TryParseHtmlString(uVar8,this + 80,0);
              plVar10 = this.areaCoverImage;
              if (plVar10 == (int64 *)0) goto LAB_1807ec943;
              local_28 = this.temp;
              uStack_24 = *(uint32 *)(this + 84);
              uStack_20 = *(uint32 *)(this + 88);
              uStack_1c = *(uint32 *)(this + 92);
              (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
              lVar6 = this.areaForceImage;
              uVar8 = ForceData.GetForceIcon(lVar4,0);
              if (lVar6 == null) goto LAB_1807ec943;
              Image.set_sprite(lVar6,uVar8,0);
            }
          }
          lVar4 = this.areaData;
          if (lVar4 == null) goto LAB_1807ec943;
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
              lVar4 = FUN_18046c680(0);
              if (lVar4 == null) goto LAB_1807ec943;
              uVar8 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","问号",0);
              if (plVar10 == (int64 *)0) goto LAB_1807ec943;
              Image.set_sprite(plVar10,uVar8,0);
              plVar10 = this.missionTarget;
              puVar7 = (uint32 *)Color.get_yellow(&local_28,0);
            }
            else if (iVar3 == 2) {
              lVar4 = FUN_18046c680(0);
              if (lVar4 == null) goto LAB_1807ec943;
              uVar8 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","任务目标",0);
              if (plVar10 == (int64 *)0) goto LAB_1807ec943;
              Image.set_sprite(plVar10,uVar8,0);
              plVar10 = this.missionTarget;
              puVar7 = (uint32 *)FUN_1810d3b80(&local_28,0);
            }
            else {
              puVar7 = (uint32 *)FUN_180d995f0(&local_28,0);
            }
            if (plVar10 == (int64 *)0) goto LAB_1807ec943;
            local_28 = *puVar7;
            uStack_24 = puVar7[1];
            uStack_20 = puVar7[2];
            uStack_1c = puVar7[3];
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_28,*(uint64 *)(*plVar10 + 0x2b0));
          }
        }
        LAB_1807ec6da:
        uVar8 = this.playerArmyNpc;
        cVar1 = Object.op_Equality(uVar8,0,0);
        if (cVar1) {
          lVar4 = GameController.CheckShowSpeHero;
          if (lVar4 == null) goto LAB_1807ec943;
          uVar8 = lVar4.support;
          cVar1 = Object.op_Inequality(uVar8,0,0);
          if (cVar1) {
            lVar4 = FUN_18046bbe0(0);
            if ((lVar4 == null) || (lVar4.support == null)) goto LAB_1807ec943;
            uVar8 = GameObject.GetComponent(lVar4.support,DAT_181dc76c8);
            this.playerArmyNpc = uVar8;
          }
        }
        uVar8 = this.playerArmyNpc;
        cVar1 = Object.op_Inequality(uVar8,0,0);
        if (cVar1) {
          if (this.playerArmyNpc == null) {
        LAB_1807ec943:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar8 = this.playerArmyNpc.areaSafeRange;
          uVar9 = this.areaSafeRange;
          cVar1 = Object.op_Equality(uVar8,uVar9,0);
          if (cVar1) {
            uVar2 = 1;
            goto LAB_1807ec8aa;
          }
        }
        uVar8 = MouseController.get_hoveredObject(0);
        uVar9 = Component.get_gameObject(this,0);
        uVar2 = Object.op_Equality(uVar8,uVar9,0);
        LAB_1807ec8aa:
        AreaIconController.ShowAreaSafeSprite(this,uVar2,0);
    }

    // Token : 0x6000A97
    // RVA   : 0x7EBAF0   Offset: 0x7EAEF0   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181db0be0 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          BigMapController.SetPlayerMoveTargetArea(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000A98
    // RVA   : 0x7EBDF0   Offset: 0x7EB1F0   Length: 0x1A6
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
              FUN_1800d6620();
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

    // Token : 0x6000A99
    // RVA   : 0x7EBBC0   Offset: 0x7EAFC0   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181db0de0 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000A9A
    // RVA   : 0x7EBC20   Offset: 0x7EB020   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181db0de0 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000A9B
    // RVA   : 0x7ECA70   Offset: 0x7EBE70   Length: 0x48
    public void /*ctor*/()
    {
        *(uint64 *)(this + 100) = 0x3e800000be4ccccd;
        *(uint32 *)(this + 108) = 0;
        this.showBelongForceID = 0xfffffc19;
        this.missionState = 0xffffffff;
        FUN_18044ef50(0,0);
    }

    // Token : 0x6000A9C
    // RVA   : 0x7EC950   Offset: 0x7EBD50   Length: 0x114
    private static void /*cctor*/()
    {
        long lVar2;
        uint local_18;
        uint local_14;
        uint local_10;
        lVar2 = il2cpp_internal(DAT_181d98be8);
        FUN_181330100(lVar2,DAT_181dabbb0);
        if (lVar2 != null) {
          local_18 = 0x40000000;
          local_14 = 0x40000000;
          local_10 = 0x3dcccccd;
          FUN_181817190(lVar2,&local_18,DAT_181dabc30);
          local_18 = 0x3fcccccd;
          local_14 = 0x3fb33333;
          local_10 = 0x3dcccccd;
          FUN_181817190(lVar2,&local_18,DAT_181dabc30);
          local_18 = 0x3fcccccd;
          local_14 = 0x3fb33333;
          local_10 = 0x3dcccccd;
          FUN_181817190(lVar2,&local_18,DAT_181dabc30);
          plVar1 = *(int64 **)(DAT_181dac868 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
