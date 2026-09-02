// ============================================================
// Type  : AreaIconController
// Token : 0x2000142
// ============================================================

public class AreaIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007F7
    public AreaData areaData;

    // Token: 0x40007F8
    public GameObject areaUIRoot;

    // Token: 0x40007F9
    public GameObject areaNameLabel;

    // Token: 0x40007FA
    public GameObject areaForceIcon;

    // Token: 0x40007FB
    public Image missionTarget;

    // Token: 0x40007FC
    public GameObject areaSafeRange;

    // Token: 0x40007FD
    public float safeRange;

    // Token: 0x40007FE
    public bool showAreaSafeSprite;

    // Token: 0x40007FF
    private Color temp;

    // Token: 0x4000800
    private int showBelongForceID;

    // Token: 0x4000801
    private Vector3 areaUIOffset;

    // Token: 0x4000802
    private static List<Vector3> boxColliderSize;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A71
    // RVA   : 0x7ECFF0   Offset: 0x7EB7F0   Length: 0x79D
    public void Init()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        float fVar9;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        lVar5 = Component.get_transform(this,0);
        if (lVar5 != null) {
          lVar5 = Transform.Find(lVar5,"Sprite",0);
          if (lVar5 != null) {
            lVar5 = Component.GetComponent(lVar5,DAT_181d6d540);
            if ((this.areaData != null) && (*pStatics_6270 != 0)) {
              uVar6 = TextureController.LoadAtlasSprite
                                (*pStatics_6270,"AreaIconAtlas",
                                 this.areaData.spriteName,0);
              if (lVar5 != null) {
                SpriteRenderer.set_sprite(lVar5,uVar6,0);
                lVar7 = Component.GetComponent(this,DAT_181d6adc0);
                lVar5 = this.areaData;
                if (lVar5 != null) {
                  lVar3 = lVar5.speBoxColliderSize;
                  if (lVar3 == null) {
                    if (((*(byte *)(DAT_181d87730 + 0x133) & 4) != 0) &&
                       (*(int *)(DAT_181d87730 + 224) == 0)) {
                      il2cpp_runtime_class_init(DAT_181d87730);
                      lVar5 = this.areaData;
                    }
                    lVar3 = **(int64 **)(DAT_181d87730 + 184);
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

                    if ((lVar5 = *(int64 *)(pStatics_baa8 + 16)?.areaBranchDefenceLv) != null) {
                      lVar5 = GameObject.get_transform(lVar5,0);
                      if (lVar5 != null) {
                        lVar5 = Transform.Find(lVar5,"AreaUIPanel",0);
                        if (lVar5 != null) {
                          uVar6 = Component.get_gameObject(lVar5,0);
                          lVar5 = *(int64 *)(pStatics_baa8 + 16);
                          if (lVar5 != null) {
                            uVar4 = lVar5.areaBranchDefenceUpgradeLeftTime;
                            uVar6 = GlobalData.AddChild(uVar6,uVar4,0);
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
                                                  uVar6 = Component.GetComponent(lVar5,DAT_181d6bc40);
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
                                                                          (lVar5,DAT_181d6d8c0);
                                                        if (this.areaData != null) {
                                                          LTLocalization.SetText
                                                                    (uVar6,*(uint64 *)
                                                                            (this.areaData
                                                                            + 24),0);
                                                          if (this.areaUIRoot != null) {
                                                            lVar5 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 32),0);
                                                            if (lVar5 != null) {
                                                              lVar5 = Transform.Find(lVar5,"AreaUI",
                                                                                      0);
                                                              if (lVar5 != null) {
                                                                uVar6 = Component.GetComponent
                                                                                  (lVar5,DAT_181d6c740);
                                                                if (((*(byte *)(DAT_181d5faf0 + 0x133) & 4
                                                                     ) != 0) &&
                                                                   (*(int *)(DAT_181d5faf0 + 224) == 0))
                                                                {
                                                                  il2cpp_runtime_class_init();
                                                                }

                                                        LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                  (uVar6,0);
                                                        lVar5 = *(int64 *)
                                                                 (*(int64 *)(DAT_181d4ef00 + 184) +
                                                                 0x428);
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

    // Token : 0x6000A72
    // RVA   : 0x7ED920   Offset: 0x7EC120   Length: 0x163
    public void SetSafeRange()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x428);
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

    // Token : 0x6000A73
    // RVA   : 0x7EDB80   Offset: 0x7EC380   Length: 0xA7D
    private void Update()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        uint uVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        long lVar5;
        long lVar7;
        ulong uVar9;
        ulong uVar10;
        float fVar11;
        float fVar12;
        float local_38;
        float fStack_34;
        ulong local_28;
        float local_20;
        ulong local_18;
        float fStack_10;
        uint32 uStack_c;
        lVar5 = Component.get_transform(this,0);
        if (((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Sprite",0)) == null) ||
           (lVar5 = Component.GetComponent(lVar5,DAT_181d6d5c0)) == null) throw; // [null/range check failed]
        lVar7 = this.areaUIRoot;
        if (!lVar5.areaName) {
          if (lVar7 == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(lVar7,0);
          puVar6 = (uint64 *)Vector3.get_zero(&local_28,0);
          if (lVar5 == null) throw; // [null/range check failed]
          fStack_10 = *(float *)(puVar6 + 1);
          local_18 = *puVar6;
          Transform.set_localScale(lVar5,&local_18,0);
        }
        else {
          if (lVar7 == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(lVar7,0);
          lVar7 = Component.get_transform(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          puVar6 = (uint64 *)Transform.get_position(&local_18,lVar7,0);
          local_28 = *puVar6;
          local_20 = *(float *)(puVar6 + 1);
          fVar12 = *(float *)(this + 108);
          uVar9 = *(uint64 *)(this + 100);
          lVar7 = *(int64 *)(pStatics_baa8 + 16);
          if (lVar7 == null) throw; // [null/range check failed]
          fVar11 = (float)BigMapController.BigMapNowScale(lVar7,0);
          local_38 = (float)uVar9;
          fStack_34 = (float)((uint64)uVar9 >> 32);
          local_18 = CONCAT44(fStack_34 * fVar11 + local_28._4_4_,local_38 * fVar11 + (float)local_28);
          fStack_10 = fVar12 * fVar11 + local_20;
          if (lVar5 == null) throw; // [null/range check failed]
          local_28 = local_18;
          local_20 = fStack_10;
          Transform.set_position(lVar5,&local_28,0);
          if (this.areaUIRoot == null) throw; // [null/range check failed]
          lVar5 = GameObject.get_transform(this.areaUIRoot,0);
          puVar6 = (uint64 *)Vector3.get_one(&local_28,0);
          local_18 = *puVar6;
          fStack_10 = *(float *)(puVar6 + 1);
          lVar7 = *(int64 *)(pStatics_baa8 + 16);
          if (lVar7 == null) throw; // [null/range check failed]
          fVar12 = (float)BigMapController.BigMapNowScale(lVar7,0);
          fVar12 = fVar12 + 0.5;
          local_20 = (fStack_10 * fVar12) / 1.5;
          local_28 = CONCAT44((local_18._4_4_ * fVar12) / 1.5,((float)local_18 * fVar12) / 1.5);
          if (lVar5 == null) throw; // [null/range check failed]
          local_18 = local_28;
          fStack_10 = local_20;
          Transform.set_localScale(lVar5,&local_18,0);
          if (this.areaData == null) throw; // [null/range check failed]
          lVar5 = AreaData.GetForce(this.areaData,0);
          if (lVar5 == null) {
        LAB_1807edf97:
            if (this.areaData == null) throw; // [null/range check failed]
            iVar4 = this.areaData.belongForceID;
          }
          else {
            if ((this.areaData == null) ||
               (lVar5 = AreaData.GetForce(this.areaData,0)) == null)
            throw; // [null/range check failed]
            if (lVar5.xScale < 0) goto LAB_1807edf97;
            if ((this.areaData == null) ||
               (lVar5 = AreaData.GetForce(this.areaData,0)) == null)
            throw; // [null/range check failed]
            iVar4 = lVar5.xScale;
          }
          if (this.showBelongForceID != iVar4) {
            this.showBelongForceID = iVar4;
            if (iVar4 == -1) {
              if (((this.areaNameLabel == null) ||
                  (lVar5 = GameObject.get_transform(this.areaNameLabel,0)) == null) ||
                 (lVar5 = Transform.Find(lVar5,"Cover",0)) == null) throw; // [null/range check failed]
              plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
              puVar6 = (uint64 *)FUN_181098a50(&local_18,0);
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *puVar6;
              fStack_10 = *(float *)(puVar6 + 1);
              uStack_c = *(uint32 *)((int64)puVar6 + 12);
              (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_18,*(uint64 *)(*plVar8 + 0x2b0));
              if (this.areaForceIcon == null) throw; // [null/range check failed]
              plVar8 = (int64 *)GameObject.GetComponent(this.areaForceIcon,DAT_181d9fe50);
              puVar6 = (uint64 *)FUN_180d904c0(&local_18,0);
              if (plVar8 == (int64 *)0) throw; // [null/range check failed]
              local_18 = *puVar6;
              fStack_10 = *(float *)(puVar6 + 1);
              uStack_c = *(uint32 *)((int64)puVar6 + 12);
              (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_18,*(uint64 *)(*plVar8 + 0x2b0));
            }
            else {
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (lVar5.areaStartLv == null)) ||
                 (lVar5 = WorldData.GetForce(lVar5.areaStartLv,this.showBelongForceID,
                                              0), lVar5 == null)) throw; // [null/range check failed]
              uVar9 = String.Concat("#",lVar5.people,0);
              ColorUtility.TryParseHtmlString(uVar9,this + 80,0);
              if ((((this.areaNameLabel == null) ||
                   (lVar5 = GameObject.get_transform(this.areaNameLabel,0)) == null) ||
                  (lVar5 = Transform.Find(lVar5,"Cover",0)) == null) ||
                 (plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40),
                 plVar8 == (int64 *)0)) throw; // [null/range check failed]
              local_18 = this.temp;
              fStack_10 = *(float *)(this + 88);
              uStack_c = *(uint32 *)(this + 92);
              (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_18,*(uint64 *)(*plVar8 + 0x2b0));
              if (this.areaForceIcon == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.areaForceIcon,DAT_181d9fe50);
              uVar1 = this.showBelongForceID;
              lVar7 = *pStatics_6270;
              uVar9 = GlobalData.GetForceIconName(uVar1,0);
              if ((lVar7 == null) ||
                 (uVar9 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas",uVar9,0), lVar5 == null))
              throw; // [null/range check failed]
              Image.set_sprite(lVar5,uVar9,0);
            }
          }
          lVar5 = this.areaData;
          if (lVar5 == null) throw; // [null/range check failed]
          plVar8 = this.missionTarget;
          if (lVar5.plotNumCount < 1) {
            if (lVar5.missionNumCount < 1) {
              puVar6 = (uint64 *)FUN_180d904c0(&local_18,0);
            }
            else {
              if ((*pStatics_6270 == 0) ||
                 (uVar9 = TextureController.LoadAtlasSprite
                                    (*pStatics_6270,"UIAtlas","任务目标",0),
                 plVar8 == (int64 *)0)) throw; // [null/range check failed]
              Image.set_sprite(plVar8,uVar9,0);
              plVar8 = this.missionTarget;
              puVar6 = (uint64 *)FUN_181098a50(&local_18,0);
            }
          }
          else {
            if ((*pStatics_6270 == 0) ||
               (uVar9 = TextureController.LoadAtlasSprite
                                  (*pStatics_6270,"UIAtlas","问号",0),
               plVar8 == (int64 *)0)) throw; // [null/range check failed]
            Image.set_sprite(plVar8,uVar9,0);
            plVar8 = this.missionTarget;
            puVar6 = (uint64 *)Color.get_yellow(&local_18,0);
          }
          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
          local_18 = *puVar6;
          fStack_10 = *(float *)(puVar6 + 1);
          uStack_c = *(uint32 *)((int64)puVar6 + 12);
          (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_18,*(uint64 *)(*plVar8 + 0x2b0));
        }
        lVar5 = *(int64 *)(pStatics_baa8 + 16);
        if (lVar5 != null) {
          uVar9 = lVar5.support;
          cVar2 = Object.op_Inequality(uVar9,0,0);
          if (!cVar2) {
        LAB_1807ee584:
            uVar9 = MouseController.get_hoveredObject(0);
            uVar10 = Component.get_gameObject(this,0);
            uVar3 = Object.op_Equality(uVar9,uVar10,0);
            AreaIconController.ShowAreaSafeSprite(this,uVar3,0);
            return;
          }

          if (((lVar5 = *(int64 *)(pStatics_baa8 + 16)?.support) != null) &&
             (lVar5 = GameObject.GetComponent(lVar5,DAT_181d9e910)) != null) {
            uVar9 = lVar5.mapWidth;
            uVar10 = this.areaSafeRange;
            cVar2 = Object.op_Equality(uVar9,uVar10,0);
            if (!cVar2) goto LAB_1807ee584;
            if (this.showAreaSafeSprite) {
              return;
            }
            this.showAreaSafeSprite = 1;
            if ((this.areaSafeRange != null) &&
               (lVar5 = GameObject.get_transform(this.areaSafeRange,0)) != null) {
              uVar9 = Transform.Find(lVar5,"AreaSafeSprite",0);
              ShortcutExtensions.DOScale(uVar9,0x3f800000,0x3e99999a,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000A74
    // RVA   : 0x7ED790   Offset: 0x7EBF90   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          BigMapController.SetPlayerMoveTargetArea(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000A75
    // RVA   : 0x7EDA90   Offset: 0x7EC290   Length: 0xE6
    public void ShowAreaSafeSprite(bool show)
    {
        long lVar1;
        ulong uVar2;
        if (!show) {
          if (this.showAreaSafeSprite) {
            this.showAreaSafeSprite = 0;
            if ((this.areaSafeRange != null) &&
               (lVar1 = GameObject.get_transform(this.areaSafeRange,0)) != null) {
              uVar2 = Transform.Find(lVar1,"AreaSafeSprite",0);
              ShortcutExtensions.DOScale(uVar2,0,0x3e99999a,0);
              return;
            }
        LAB_1807edb71:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else if (!this.showAreaSafeSprite) {
          this.showAreaSafeSprite = 1;
          if ((this.areaSafeRange != null) &&
             (lVar1 = GameObject.get_transform(this.areaSafeRange,0)) != null) {
            uVar2 = Transform.Find(lVar1,"AreaSafeSprite",0);
            ShortcutExtensions.DOScale(uVar2,0x3f800000,0x3e99999a,0);
            return;
          }
          goto LAB_1807edb71;
        }
    }

    // Token : 0x6000A76
    // RVA   : 0x7ED860   Offset: 0x7EC060   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000A77
    // RVA   : 0x7ED8C0   Offset: 0x7EC0C0   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000A78
    // RVA   : 0x7EE720   Offset: 0x7ECF20   Length: 0x3E
    public void /*ctor*/()
    {
        *(uint64 *)(this + 100) = 0x3e800000be4ccccd;
        *(uint32 *)(this + 108) = 0;
        this.showBelongForceID = 0xfffffc19;
        FUN_18044ef50(0,0);
    }

    // Token : 0x6000A79
    // RVA   : 0x7EE600   Offset: 0x7ECE00   Length: 0x114
    private static void /*cctor*/()
    {
        long lVar2;
        uint local_18;
        uint local_14;
        uint local_10;
        lVar2 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(lVar2,DAT_181d841f8);
        if (lVar2 != null) {
          local_18 = 0x40000000;
          local_14 = 0x40000000;
          local_10 = 0x3dcccccd;
          FUN_181805a40(lVar2,&local_18,DAT_181d84278);
          local_18 = 0x3fcccccd;
          local_14 = 0x3fb33333;
          local_10 = 0x3dcccccd;
          FUN_181805a40(lVar2,&local_18,DAT_181d84278);
          local_18 = 0x3fcccccd;
          local_14 = 0x3fb33333;
          local_10 = 0x3dcccccd;
          FUN_181805a40(lVar2,&local_18,DAT_181d84278);
          plVar1 = *(int64 **)(DAT_181d87730 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
