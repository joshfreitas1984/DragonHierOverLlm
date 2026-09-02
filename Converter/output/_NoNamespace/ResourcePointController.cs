// ============================================================
// Type  : ResourcePointController
// Token : 0x2000341
// ============================================================

public class ResourcePointController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A33
    public ResourcePointData resourcePointData;

    // Token: 0x4001A34
    public GameObject pointUIRoot;

    // Token: 0x4001A35
    public GameObject pointNameLabel;

    // Token: 0x4001A36
    public GameObject pointForceIcon;

    // Token: 0x4001A37
    public bool showLine;

    // Token: 0x4001A38
    private Color temp;

    // Token: 0x4001A39
    private int showBelongForceID;

    // Token: 0x4001A3A
    private Vector3 resourceUIOffset;

    // Token: 0x4001A3B
    private Vector2 lineSpeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002043
    // RVA   : 0xC64680   Offset: 0xC62E80   Length: 0x496
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181d8baa8 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = Component.get_transform(this,0);
        if (lVar3 != null) {
          lVar3 = Transform.Find(lVar3,"Sprite",0);
          if (lVar3 != null) {
            lVar3 = Component.GetComponent(lVar3,DAT_181d6d540);
            lVar1 = **(int64 **)(DAT_181d86270 + 184);
            if (this.resourcePointData != null) {
              uVar4 = Int32.ToString(this.resourcePointData + 20,0);
              if (lVar1 != null) {
                uVar4 = TextureController.LoadAtlasSprite(lVar1,"ResourcePointAtlas",uVar4,0);
                if (lVar3 != null) {
                  SpriteRenderer.set_sprite(lVar3,uVar4,0);
                  lVar3 = *(int64 *)(pStatics + 16);
                  if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 208)) != null) {
                    lVar3 = GameObject.get_transform(lVar3,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"AreaUIPanel",0);
                      if (lVar3 != null) {
                        uVar4 = Component.get_gameObject(lVar3,0);
                        lVar3 = *(int64 *)(pStatics + 16);
                        if (lVar3 != null) {
                          uVar2 = *(uint64 *)(lVar3 + 216);
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
                                                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                                if (this.resourcePointData != null) {
                                                  LTLocalization.SetText
                                                            (uVar4,*(uint64 *)
                                                                    (this.resourcePointData + 24)
                                                             ,0);
                                                  if (this.pointUIRoot != null) {
                                                    lVar3 = GameObject.get_transform
                                                                      (this.pointUIRoot,0);
                                                    if (lVar3 != null) {
                                                      lVar3 = Transform.Find(lVar3,"AreaUI",0);
                                                      if (lVar3 != null) {
                                                        uVar4 = Component.GetComponent
                                                                          (lVar3,DAT_181d6c740);
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

    // Token : 0x6002044
    // RVA   : 0xC64B20   Offset: 0xC63320   Length: 0xB8D
    private void Update()
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar7;
        long lVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float local_res18;
        float fStackX_1c;
        uint64 local_68;
        uint64 local_58;
        float local_50;
        uint64 local_48;
        float fStack_40;
        uint32 uStack_3c;
        lVar4 = Component.get_transform(this,0);
        if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Sprite",0)) == null) ||
           (lVar4 = Component.GetComponent(lVar4,DAT_181d6d5c0)) == null) throw; // [null/range check failed]
        if (!lVar4.resourcePointName) {
          if (this.pointUIRoot == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(this.pointUIRoot,0);
          puVar5 = (uint64 *)Vector3.get_zero(&local_58,0);
          if (lVar4 == null) throw; // [null/range check failed]
          fStack_40 = *(float *)(puVar5 + 1);
          local_48 = *puVar5;
          Transform.set_localScale(lVar4,&local_48,0);
        }
        else {
          lVar4 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
          if (lVar4 == null) throw; // [null/range check failed]
          fVar9 = (float)BigMapController.BigMapNowScale(lVar4,0);
          lVar4 = this.pointUIRoot;
          if (fVar9 < **(float **)(DAT_181d8baa8 + 184)) {
            if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4)) == null) throw; // [null/range check failed]
            fVar9 = (float)CanvasGroup.get_alpha(lVar4);
            if (fVar9 != 0.0) {
              if (this.pointUIRoot == null) throw; // [null/range check failed]
              uVar7 = GameObject.GetComponent(this.pointUIRoot,DAT_181d9f080);
              cVar2 = DOTween.IsTweening(uVar7,1,0);
              if (!cVar2) {
                if (this.pointUIRoot == null) throw; // [null/range check failed]
                uVar7 = GameObject.GetComponent(this.pointUIRoot,DAT_181d9f080);
                DOTweenModuleUI.DOFade(uVar7,0,0x3e4ccccd,0);
              }
              if (this.pointUIRoot == null) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(this.pointUIRoot,0);
              lVar8 = Component.get_transform(this,0);
              if (lVar8 == null) throw; // [null/range check failed]
              puVar5 = (uint64 *)Transform.get_position(&local_48,lVar8,0);
              local_58 = *puVar5;
              local_50 = *(float *)(puVar5 + 1);
              local_48 = this.resourceUIOffset;
              fStack_40 = *(float *)(this + 88);
              lVar8 = FUN_18046bbe0(0);
              if (lVar8 == null) throw; // [null/range check failed]
              fVar9 = (float)BigMapController.BigMapNowScale(lVar8,0);
              local_68 = CONCAT44(local_48._4_4_ * fVar9 + local_58._4_4_,
                                  (float)local_48 * fVar9 + (float)local_58);
              if (lVar4 == null) throw; // [null/range check failed]
              local_48 = local_68;
              fStack_40 = fStack_40 * fVar9 + local_50;
              Transform.set_position(lVar4,&local_48,0);
            }
          }
          else {
            if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f080)) == null)
            throw; // [null/range check failed]
            fVar9 = (float)CanvasGroup.get_alpha(lVar4,0);
            if (fVar9 != 1.0) {
              if (this.pointUIRoot == null) throw; // [null/range check failed]
              uVar7 = GameObject.GetComponent(this.pointUIRoot,DAT_181d9f080);
              cVar2 = DOTween.IsTweening(uVar7,1,0);
              if (!cVar2) {
                if (this.pointUIRoot == null) throw; // [null/range check failed]
                uVar7 = GameObject.GetComponent(this.pointUIRoot,DAT_181d9f080);
                DOTweenModuleUI.DOFade(uVar7,0x3f800000,0x3ecccccd,0);
              }
            }
            if (this.pointUIRoot == null) throw; // [null/range check failed]
            lVar4 = GameObject.get_transform(this.pointUIRoot,0);
            lVar8 = Component.get_transform(this,0);
            if (lVar8 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_position(&local_48,lVar8,0);
            local_58 = *puVar5;
            local_50 = *(float *)(puVar5 + 1);
            uVar7 = this.resourceUIOffset;
            fVar9 = *(float *)(this + 88);
            lVar8 = FUN_18046bbe0(0);
            if (lVar8 == null) throw; // [null/range check failed]
            fVar10 = (float)BigMapController.BigMapNowScale(lVar8,0);
            local_68._0_4_ = (float)uVar7;
            local_68._4_4_ = (float)((uint64)uVar7 >> 32);
            local_48 = CONCAT44(local_68._4_4_ * fVar10 + local_58._4_4_,
                                (float)local_68 * fVar10 + (float)local_58);
            fStack_40 = fVar9 * fVar10 + local_50;
            if (lVar4 == null) throw; // [null/range check failed]
            local_58 = local_48;
            local_50 = fStack_40;
            Transform.set_position(lVar4,&local_58,0);
            if (this.pointUIRoot == null) throw; // [null/range check failed]
            lVar4 = GameObject.get_transform(this.pointUIRoot,0);
            puVar5 = (uint64 *)Vector3.get_one(&local_58,0);
            fStack_40 = *(float *)(puVar5 + 1);
            local_48 = *puVar5;
            lVar8 = FUN_18046bbe0(0);
            if (lVar8 == null) throw; // [null/range check failed]
            fVar9 = (float)BigMapController.BigMapNowScale(lVar8,0);
            fVar9 = fVar9 + 0.5;
            local_50 = ((fVar9 * fStack_40) / 1.5) / 1.5;
            local_58 = CONCAT44(((fVar9 * local_48._4_4_) / 1.5) / 1.5,
                                ((fVar9 * (float)local_48) / 1.5) / 1.5);
            if (lVar4 == null) throw; // [null/range check failed]
            local_48 = local_58;
            fStack_40 = local_50;
            Transform.set_localScale(lVar4,&local_48,0);
            if (this.resourcePointData == null) throw; // [null/range check failed]
            lVar4 = ResourcePointData.GetForce();
            if (lVar4 == null) {
        LAB_180c65000:
              if (this.resourcePointData == null) throw; // [null/range check failed]
              iVar3 = this.resourcePointData.belongForceID;
            }
            else {
              if ((this.resourcePointData == null) ||
                 (lVar4 = ResourcePointData.GetForce()) == null) throw; // [null/range check failed]
              if (lVar4.connectAreaID < 0) goto LAB_180c65000;
              if ((this.resourcePointData == null) ||
                 (lVar4 = ResourcePointData.GetForce()) == null) throw; // [null/range check failed]
              iVar3 = lVar4.connectAreaID;
            }
            if (this.showBelongForceID != iVar3) {
              this.showBelongForceID = iVar3;
              if (iVar3 == -1) {
                if (((this.pointNameLabel == null) ||
                    (lVar4 = GameObject.get_transform(this.pointNameLabel,0)) == null) ||
                   (lVar4 = Transform.Find(lVar4,"Cover",0)) == null) throw; // [null/range check failed]
                plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                puVar5 = (uint64 *)FUN_181098a50(&local_48,0);
                if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                local_48 = *puVar5;
                fStack_40 = *(float *)(puVar5 + 1);
                uStack_3c = *(uint32 *)((int64)puVar5 + 12);
                (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_48,*(uint64 *)(*plVar6 + 0x2b0));
                if (this.pointForceIcon == null) throw; // [null/range check failed]
                plVar6 = (int64 *)GameObject.GetComponent(this.pointForceIcon,DAT_181d9fe50)
                ;
                puVar5 = (uint64 *)FUN_180d904c0(&local_48,0);
                if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                local_48 = *puVar5;
                fStack_40 = *(float *)(puVar5 + 1);
                uStack_3c = *(uint32 *)((int64)puVar5 + 12);
                (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_48,*(uint64 *)(*plVar6 + 0x2b0));
              }
              else {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 == null) || (lVar4.resourcePointFullName == null)) ||
                   (lVar4 = WorldData.GetForce(lVar4.resourcePointFullName,
                                                this.showBelongForceID,0), lVar4 == null))
                throw; // [null/range check failed]
                uVar7 = String.Concat("#",lVar4.thisMonthExplored,0);
                ColorUtility.TryParseHtmlString(uVar7,this + 60,0);
                if ((((this.pointNameLabel == null) ||
                     (lVar4 = GameObject.get_transform(this.pointNameLabel,0)) == null) ||
                    (lVar4 = Transform.Find(lVar4,"Cover",0)) == null) ||
                   (plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40),
                   plVar6 == (int64 *)0)) throw; // [null/range check failed]
                local_48 = this.temp;
                fStack_40 = *(float *)(this + 68);
                uStack_3c = *(uint32 *)(this + 72);
                (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_48,*(uint64 *)(*plVar6 + 0x2b0));
                if (this.pointForceIcon == null) throw; // [null/range check failed]
                lVar4 = GameObject.GetComponent(this.pointForceIcon,DAT_181d9fe50);
                lVar8 = FUN_18046c6c0(0);
                uVar1 = this.showBelongForceID;
                uVar7 = GlobalData.GetForceIconName(uVar1,0);
                if ((lVar8 == null) ||
                   (uVar7 = TextureController.LoadAtlasSprite(lVar8,"UIAtlas",uVar7,0), lVar4 == null))
                throw; // [null/range check failed]
                Image.set_sprite(lVar4,uVar7,0);
              }
            }
          }
        }
        if (!this.showLine) {
          lVar4 = Component.get_transform(this);
          if (((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Line",0)) != null) &&
             (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
            cVar2 = GameObject.get_activeSelf(lVar4,0);
            if (cVar2) {
              lVar4 = Component.get_transform(this,0);
              if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Line",0)) == null) ||
                 (lVar4 = Component.get_gameObject(lVar4,0)) == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar4,0,0);
            }
            return;
          }
        }
        else {
          lVar4 = Component.get_transform(this);
          if (((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Line",0)) != null) &&
             (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
            cVar2 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar2) {
              lVar4 = Component.get_transform(this,0);
              if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Line",0)) == null)
              throw; // [null/range check failed]
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar4,1,0);
            }
            lVar4 = Component.get_transform(this,0);
            if ((((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Line",0)) != null) &&
                (lVar4 = Component.GetComponent(lVar4,DAT_181d6c040)) != null) &&
               (lVar4 = FUN_180d94be0(lVar4,0)) != null) {
              uVar7 = Material.get_mainTextureOffset(lVar4,0);
              fVar9 = this.lineSpeed;
              fVar10 = *(float *)(this + 96);
              fVar11 = (float)Time.get_deltaTime(0);
              local_res18 = (float)uVar7;
              fStackX_1c = (float)((uint64)uVar7 >> 32);
              Material.set_mainTextureOffset
                        (lVar4,CONCAT44(fStackX_1c - fVar10 * fVar11,local_res18 - fVar11 * fVar9),0);
              lVar4 = Component.get_transform(this,0);
              if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Line",0)) != null) {
                lVar8 = Component.GetComponent(lVar4,DAT_181d6c040);
                lVar4 = this.resourcePointData;
                if (lVar4 != null) {
                  iVar3 = lVar4.belongForceID;
                  lVar4 = ResourcePointData.GetArea(lVar4,0);
                  if (lVar4 != null) {
                    if (iVar3 == *(int *)(lVar4 + 112)) {
                      puVar5 = (uint64 *)FUN_1810988d0();
                    }
                    else {
                      puVar5 = (uint64 *)Color.get_red(&local_48,0);
                    }
                    if (lVar8 != null) {
                      local_48 = *puVar5;
                      fStack_40 = (float)*(uint32 *)(puVar5 + 1);
                      uStack_3c = *(uint32 *)((int64)puVar5 + 12);
                      LineRenderer.set_startColor(lVar8,&local_48,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002045
    // RVA   : 0xC645B0   Offset: 0xC62DB0   Length: 0xCC
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

    // Token : 0x6002046
    // RVA   : 0x7ED860   Offset: 0x7EC060   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6002047
    // RVA   : 0x7ED8C0   Offset: 0x7EC0C0   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6002048
    // RVA   : 0xC656B0   Offset: 0xC63EB0   Length: 0x46
    public void /*ctor*/()
    {
        this.resourceUIOffset = 0x3dcccccdbd75c28f;
        *(uint32 *)(this + 88) = 0;
        this.showBelongForceID = 0xfffffc19;
        this.lineSpeed = 0x3dcccccd;
        FUN_18044ef50(0,0);
    }

}
