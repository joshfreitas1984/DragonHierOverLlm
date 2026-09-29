// ============================================================
// Type  : ResourcePointController
// Token : 0x2000348
// ============================================================

public class ResourcePointController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B2B
    public ResourcePointData resourcePointData;

    // Token: 0x4001B2C
    public GameObject pointUIRoot;

    // Token: 0x4001B2D
    public GameObject pointNameLabel;

    // Token: 0x4001B2E
    public GameObject pointForceIcon;

    // Token: 0x4001B2F
    public bool showLine;

    // Token: 0x4001B30
    private Color temp;

    // Token: 0x4001B31
    private int showBelongForceID;

    // Token: 0x4001B32
    private Vector3 resourceUIOffset;

    // Token: 0x4001B33
    private Vector2 lineSpeed;

    // Token: 0x4001B34
    private SpriteVisibleController spriteVisible;

    // Token: 0x4001B35
    private CanvasGroup pointCanvasGroup;

    // Token: 0x4001B36
    private Transform lineTrans;

    // Token: 0x4001B37
    private LineRenderer lineRenderer;

    // Token: 0x4001B38
    private Material lineMaterial;

    // Token: 0x4001B39
    private Image pointCoverImage;

    // Token: 0x4001B3A
    private Image pointForceImage;

    // Token: 0x4001B3B
    private Color lineColorCache;

    // Token: 0x4001B3C
    private bool lineColorCached;

    // Token: 0x4001B3D
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020C3
    // RVA   : 0xD165F0   Offset: 0xD159F0   Length: 0x4D0
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = Component.get_transform(this,0);
        if (lVar3 != null) {
          lVar3 = Transform.Find(lVar3,"Sprite",0);
          if (lVar3 != null) {
            lVar3 = Component.GetComponent(lVar3,DAT_181d95df8);
            lVar1 = **(int64 **)(DAT_181dab4a8 + 184);
            if (this.resourcePointData != null) {
              uVar4 = Int32.ToString(this.resourcePointData + 20,0);
              if (lVar1 != null) {
                uVar4 = TextureController.LoadAtlasSprite(lVar1,"ResourcePointAtlas",uVar4,0);
                if (lVar3 != null) {
                  SpriteRenderer.set_sprite(lVar3,uVar4,0);
                  lVar3 = GameController.CheckShowSpeHero;
                  if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 216)) != null) {
                    lVar3 = GameObject.get_transform(lVar3,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"AreaUIPanel",0);
                      if (lVar3 != null) {
                        uVar4 = Component.get_gameObject(lVar3,0);
                        lVar3 = GameController.CheckShowSpeHero;
                        if (lVar3 != null) {
                          uVar2 = *(uint64 *)(lVar3 + 224);
                          uVar4 = GlobalData.AddChild(uVar4,uVar2,0);
                          this.pointUIRoot = uVar4;
                          if (this.pointUIRoot != null) {
                            lVar3 = GameObject.get_transform(this.pointUIRoot,0);
                            if (lVar3 != null) {
                              lVar3 = Transform.Find(lVar3,"AreaUI",0);
                              if (lVar3 != null) {
                                lVar3 = Transform.Find(lVar3,"ForceIcon",0);
                                if (lVar3 != null) {
                                  uVar4 = Component.get_gameObject(lVar3,0);
                                  this.pointForceIcon = uVar4;
                                  if (this.pointUIRoot != null) {
                                    lVar3 = GameObject.get_transform(this.pointUIRoot,0);
                                    if (lVar3 != null) {
                                      lVar3 = Transform.Find(lVar3,"AreaUI",0);
                                      if (lVar3 != null) {
                                        lVar3 = Transform.Find(lVar3,"AreaName",0);
                                        if (lVar3 != null) {
                                          uVar4 = Component.get_gameObject(lVar3,0);
                                          this.pointNameLabel = uVar4;
                                          if (this.pointNameLabel != null) {
                                            lVar3 = GameObject.get_transform
                                                              (this.pointNameLabel,0);
                                            if (lVar3 != null) {
                                              lVar3 = Transform.Find(lVar3,"Label",0);
                                              if (lVar3 != null) {
                                                uVar4 = Component.GetComponent(lVar3,DAT_181d96178);
                                                if (this.resourcePointData != null) {
                                                  uVar2 = *(uint64 *)
                                                           (this.resourcePointData + 24);
                                                  LTLocalization.SetText(uVar4,uVar2,0);
                                                  if (this.pointUIRoot != null) {
                                                    lVar3 = GameObject.get_transform
                                                                      (this.pointUIRoot,0);
                                                    if (lVar3 != null) {
                                                      lVar3 = Transform.Find(lVar3,"AreaUI",0);
                                                      if (lVar3 != null) {
                                                        uVar4 = Component.GetComponent
                                                                          (lVar3,DAT_181d94f78);
                                                        LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                  (uVar4,0);
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

    // Token : 0x60020C4
    // RVA   : 0xD16110   Offset: 0xD15510   Length: 0x40C
    private void EnsureRefs()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.spriteVisible;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) goto LAB_180d16517;
          lVar2 = Transform.Find(lVar2,"Sprite",0);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (cVar1) {
            if (lVar2 == null) goto LAB_180d16517;
            uVar3 = Component.GetComponent(lVar2,DAT_181d95e78);
            this.spriteVisible = uVar3;
          }
        }
        uVar3 = this.pointCanvasGroup;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.pointUIRoot;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.pointUIRoot == null) goto LAB_180d16517;
            uVar3 = GameObject.GetComponent(this.pointUIRoot,DAT_181dc7e38);
            this.pointCanvasGroup = uVar3;
          }
        }
        uVar3 = this.lineTrans;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) goto LAB_180d16517;
          uVar3 = Transform.Find(lVar2,"Line",0);
          this.lineTrans = uVar3;
          uVar3 = this.lineTrans;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.lineTrans == null) goto LAB_180d16517;
            uVar3 = Component.GetComponent(this.lineTrans,DAT_181d94878);
            this.lineRenderer = uVar3;
          }
        }
        uVar3 = this.pointCoverImage;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.pointNameLabel;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.pointNameLabel == null) goto LAB_180d16517;
            lVar2 = GameObject.get_transform(this.pointNameLabel,0);
            if (lVar2 == null) goto LAB_180d16517;
            lVar2 = Transform.Find(lVar2,"Cover",0);
            if (lVar2 == null) goto LAB_180d16517;
            uVar3 = Component.GetComponent(lVar2,DAT_181d94478);
            this.pointCoverImage = uVar3;
          }
        }
        uVar3 = this.pointForceImage;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.pointForceIcon;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.pointForceIcon == null) {
        LAB_180d16517:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar3 = GameObject.GetComponent(this.pointForceIcon,DAT_181d71e80);
            this.pointForceImage = uVar3;
          }
        }
    }

    // Token : 0x60020C5
    // RVA   : 0xD16AD0   Offset: 0xD15ED0   Length: 0x9D2
    private void Update()
    {
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float local_res8;
        float fStackX_c;
        uint64 local_78;
        float local_70;
        uint64 local_68;
        float local_60;
        uint64 local_58;
        float local_50;
        uint64 local_48;
        uint64 uStack_40;
        uint64 local_38;
        uint64 uStack_30;
        ResourcePointController.EnsureRefs(this,0);
        if (this.spriteVisible == null) throw; // [null/range check failed]
        if (!this.spriteVisible.visible) {
          if ((this.pointUIRoot == null) ||
             (lVar5 = GameObject.get_transform(this.pointUIRoot,0)) == null)
          throw; // [null/range check failed]
          puVar6 = (uint64 *)Transform.get_localScale(&local_48,lVar5,0);
          uVar8 = *puVar6;
          fVar9 = *(float *)(puVar6 + 1);
          puVar6 = (uint64 *)Vector3.get_zero(&local_48,0);
          local_78 = *puVar6;
          local_70 = *(float *)(puVar6 + 1);
          local_68 = uVar8;
          local_60 = fVar9;
          cVar3 = Vector3.op_Inequality(&local_68,&local_78,0);
          if (cVar3) {
            if (this.pointUIRoot == null) throw; // [null/range check failed]
            lVar5 = GameObject.get_transform(this.pointUIRoot,0);
            puVar6 = (uint64 *)Vector3.get_zero(&local_48,0);
            if (lVar5 == null) throw; // [null/range check failed]
            local_60 = *(float *)(puVar6 + 1);
            local_68 = *puVar6;
            Transform.set_localScale(lVar5,&local_68,0);
          }
        }
        else {
          lVar5 = *(int64 *)(*(int64 *)(DAT_181db0be0 + 184) + 16);
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)BigMapController.BigMapNowScale(lVar5,0);
          lVar5 = this.pointCanvasGroup;
          if (fVar9 < **(float **)(DAT_181db0be0 + 184)) {
            if (lVar5 == null) throw; // [null/range check failed]
            fVar10 = (float)CanvasGroup.get_alpha(lVar5,0);
            if (fVar10 != 0.0) {
              uVar8 = this.pointCanvasGroup;
              cVar3 = DOTween.IsTweening(uVar8,1,0);
              if (!cVar3) {
                DOTweenModuleUI.DOFade(this.pointCanvasGroup,0,0x3e4ccccd,0);
              }
              if (this.pointUIRoot == null) throw; // [null/range check failed]
              lVar5 = GameObject.get_transform(this.pointUIRoot,0);
              lVar7 = Component.get_transform(this,0);
              if (lVar7 == null) throw; // [null/range check failed]
              puVar6 = (uint64 *)Transform.get_position(&local_38,lVar7,0);
              local_50 = *(float *)(this + 88);
              local_58 = this.resourceUIOffset;
              local_48 = *puVar6;
              local_60 = *(float *)(puVar6 + 1);
              uStack_40 = CONCAT44((int)((uint64)uStack_40 >> 32),local_60);
              local_78 = CONCAT44((float)((uint64)local_58 >> 32) * fVar9 +
                                  (float)((uint64)local_48 >> 32),
                                  (float)local_58 * fVar9 + (float)local_48);
              local_70 = local_50 * fVar9 + local_60;
              if (lVar5 == null) throw; // [null/range check failed]
              local_58 = local_78;
              local_50 = local_70;
              Transform.set_position(lVar5,&local_58,0);
            }
          }
          else {
            if (lVar5 == null) throw; // [null/range check failed]
            fVar10 = (float)CanvasGroup.get_alpha(lVar5,0);
            if (fVar10 != 1.0) {
              uVar8 = this.pointCanvasGroup;
              cVar3 = DOTween.IsTweening(uVar8,1,0);
              if (!cVar3) {
                DOTweenModuleUI.DOFade(this.pointCanvasGroup,0x3f800000,0x3ecccccd,0);
              }
            }
            if (this.pointUIRoot == null) throw; // [null/range check failed]
            lVar5 = GameObject.get_transform(this.pointUIRoot,0);
            lVar7 = Component.get_transform(this,0);
            if (lVar7 == null) throw; // [null/range check failed]
            puVar6 = (uint64 *)Transform.get_position(&local_38,lVar7,0);
            local_60 = *(float *)(this + 88);
            local_68 = this.resourceUIOffset;
            local_48 = *puVar6;
            local_50 = *(float *)(puVar6 + 1);
            uStack_40 = CONCAT44((int)((uint64)uStack_40 >> 32),local_50);
            local_78 = CONCAT44((float)((uint64)local_68 >> 32) * fVar9 +
                                (float)((uint64)local_48 >> 32),
                                (float)local_68 * fVar9 + (float)local_48);
            local_70 = local_60 * fVar9 + local_50;
            local_58 = local_48;
            if (lVar5 == null) throw; // [null/range check failed]
            local_58 = local_78;
            local_50 = local_70;
            Transform.set_position(lVar5,&local_58,0);
            puVar6 = (uint64 *)Vector3.get_one(&local_38,0);
            fVar9 = fVar9 + 0.5;
            local_50 = *(float *)(puVar6 + 1);
            local_58 = *puVar6;
            uStack_40 = CONCAT44((int)((uint64)uStack_40 >> 32),local_50);
            local_78 = CONCAT44((((float)((uint64)local_58 >> 32) * fVar9) / 1.5) / 1.5,
                                (((float)local_58 * fVar9) / 1.5) / 1.5);
            local_70 = ((local_50 * fVar9) / 1.5) / 1.5;
            local_48 = local_58;
            if ((this.pointUIRoot == null) ||
               (lVar5 = GameObject.get_transform(this.pointUIRoot,0), fVar9 = local_70,
               uVar8 = local_78, lVar5 == null)) throw; // [null/range check failed]
            local_58 = local_78;
            local_50 = local_70;
            puVar6 = (uint64 *)Transform.get_localScale(&local_38,lVar5,0);
            local_68 = *puVar6;
            local_60 = *(float *)(puVar6 + 1);
            cVar3 = Vector3.op_Inequality(&local_68,&local_58,0);
            if (cVar3) {
              if ((this.pointUIRoot == null) ||
                 (lVar5 = GameObject.get_transform(this.pointUIRoot,0)) == null)
              throw; // [null/range check failed]
              local_58 = uVar8;
              local_50 = fVar9;
              Transform.set_localScale(lVar5,&local_58,0);
            }
            fVar9 = this.refreshTime;
            fVar10 = (float)Time.get_unscaledDeltaTime(0);
            fVar9 = fVar9 - fVar10;
            this.refreshTime = fVar9;
            if (fVar9 <= 0.0) {
              this.refreshTime = 0x3e4ccccd;
              if (this.resourcePointData == null) throw; // [null/range check failed]
              lVar5 = ResourcePointData.GetForce(this.resourcePointData,0);
              if ((lVar5 == null) || (iVar4 = *(int *)(lVar5 + 60), iVar4 < 0)) {
                if (this.resourcePointData == null) throw; // [null/range check failed]
                iVar4 = this.resourcePointData.belongForceID;
              }
              if (this.showBelongForceID == iVar4) {
                if (this.resourcePointData == null) throw; // [null/range check failed]
                if (!this.resourcePointData.resourcePointIconDirty) goto LAB_180d17257;
              }
              this.showBelongForceID = iVar4;
              if (this.resourcePointData == null) throw; // [null/range check failed]
              this.resourcePointData.resourcePointIconDirty = 0;
              if (this.showBelongForceID == -1) {
                plVar1 = this.pointCoverImage;
                puVar6 = (uint64 *)FUN_1810d3b80(&local_38,0);
                if (plVar1 == (int64 *)0) throw; // [null/range check failed]
                local_38 = *puVar6;
                uStack_30 = puVar6[1];
                (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_38,*(uint64 *)(*plVar1 + 0x2b0));
                plVar1 = this.pointForceImage;
                puVar6 = (uint64 *)FUN_180d995f0(&local_38,0);
                if (plVar1 == (int64 *)0) throw; // [null/range check failed]
                local_38 = *puVar6;
                uStack_30 = puVar6[1];
                (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_38,*(uint64 *)(*plVar1 + 0x2b0));
              }
              else {
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                   (lVar5 = WorldData.GetForce(*(int64 *)(lVar5 + 32),
                                                this.showBelongForceID,0), lVar5 == null))
                throw; // [null/range check failed]
                uVar8 = String.Concat("#",*(uint64 *)(lVar5 + 80),0);
                ColorUtility.TryParseHtmlString(uVar8,this + 60,0);
                plVar1 = this.pointCoverImage;
                if (plVar1 == (int64 *)0) throw; // [null/range check failed]
                local_38 = this.temp;
                uStack_30 = *(uint64 *)(this + 68);
                (**(code **)(*plVar1 + 0x2a8))(plVar1,&local_38,*(uint64 *)(*plVar1 + 0x2b0));
                lVar7 = this.pointForceImage;
                uVar8 = ForceData.GetForceIcon(lVar5,0);
                if (lVar7 == null) throw; // [null/range check failed]
                Image.set_sprite(lVar7,uVar8,0);
              }
            }
          }
        }
        LAB_180d17257:
        lVar5 = this.lineTrans;
        if (!this.showLine) {
          if ((lVar5 != null) && (lVar5 = Component.get_gameObject(lVar5,0)) != null) {
            cVar3 = GameObject.get_activeSelf(lVar5,0);
            if (!cVar3) {
              return;
            }
            if ((this.lineTrans != null) &&
               (lVar5 = Component.get_gameObject(this.lineTrans,0)) != null) {
              GameObject.SetActive(lVar5,0,0);
              return;
            }
          }
          throw; // [null/range check failed]
        }
        if ((lVar5 == null) || (lVar5 = Component.get_gameObject(lVar5,0)) == null) throw; // [null/range check failed]
        cVar3 = GameObject.get_activeSelf(lVar5,0);
        if (!cVar3) {
          if (this.lineTrans == null) throw; // [null/range check failed]
          lVar5 = Component.get_gameObject(this.lineTrans,0);
          if (lVar5 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar5,1,0);
        }
        uVar8 = this.lineMaterial;
        cVar3 = Object.op_Equality(uVar8,0,0);
        if (cVar3) {
          if (this.lineRenderer == null) throw; // [null/range check failed]
          uVar8 = FUN_180d9dd10(this.lineRenderer,0);
          this.lineMaterial = uVar8;
        }
        lVar5 = this.lineMaterial;
        if (lVar5 == null) throw; // [null/range check failed]
        uVar8 = Material.get_mainTextureOffset(lVar5,0);
        fVar9 = this.lineSpeed;
        fVar10 = *(float *)(this + 96);
        fVar11 = (float)Time.get_deltaTime(0);
        local_res8 = (float)uVar8;
        fStackX_c = (float)((uint64)uVar8 >> 32);
        Material.set_mainTextureOffset
                  (lVar5,CONCAT44(fStackX_c - fVar11 * fVar10,local_res8 - fVar9 * fVar11),0);
        if (this.resourcePointData == null) throw; // [null/range check failed]
        lVar5 = ResourcePointData.GetArea(this.resourcePointData,0);
        if (lVar5 == null) {
        LAB_180d1742e:
          puVar6 = (uint64 *)Color.get_red(&local_38,0);
        }
        else {
          if (this.resourcePointData == null) throw; // [null/range check failed]
          if (this.resourcePointData.belongForceID != *(int *)(lVar5 + 112))
          goto LAB_180d1742e;
          puVar6 = (uint64 *)FUN_1810d3a00(&local_38,0);
        }
        uVar8 = *puVar6;
        uVar2 = puVar6[1];
        if (this.lineColorCached) {
          local_38 = this.lineColorCache;
          uStack_30 = *(uint64 *)(this + 168);
          local_48 = uVar8;
          uStack_40 = uVar2;
          cVar3 = Color.op_Inequality(&local_48,&local_38,0);
          if (!cVar3) {
            return;
          }
        }
        this.lineColorCached = 1;
        this.lineColorCache = uVar8;
        *(uint64 *)(this + 168) = uVar2;
        if (this.lineRenderer != null) {
          local_38 = uVar8;
          uStack_30 = uVar2;
          LineRenderer.set_startColor(this.lineRenderer,&local_38,0);
          return;
        }
    }

    // Token : 0x60020C6
    // RVA   : 0xD16520   Offset: 0xD15920   Length: 0xCC
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

    // Token : 0x60020C7
    // RVA   : 0x7EBBC0   Offset: 0x7EAFC0   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181db0de0 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x60020C8
    // RVA   : 0x7EBC20   Offset: 0x7EB020   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181db0de0 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x60020C9
    // RVA   : 0xD174B0   Offset: 0xD168B0   Length: 0x46
    public void /*ctor*/()
    {
        this.resourceUIOffset = 0x3dcccccdbd75c28f;
        *(uint32 *)(this + 88) = 0;
        this.showBelongForceID = 0xfffffc19;
        this.lineSpeed = 0x3dcccccd;
        FUN_18044ef50(0,0);
    }

}
