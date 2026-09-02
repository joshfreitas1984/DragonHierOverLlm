// ============================================================
// Type  : InnIconController
// Token : 0x20002E5
// ============================================================

public class InnIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400174D
    public InnData innData;

    // Token: 0x400174E
    public GameObject areaUIRoot;

    // Token: 0x400174F
    public GameObject areaNameLabel;

    // Token: 0x4001750
    public GameObject areaForceIcon;

    // Token: 0x4001751
    public Image missionTarget;

    // Token: 0x4001752
    public GameObject areaSafeRange;

    // Token: 0x4001753
    public static float safeRange;

    // Token: 0x4001754
    public bool showAreaSafeSprite;

    // Token: 0x4001755
    private Vector3 innUIOffset;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600182D
    // RVA   : 0xB6FFA0   Offset: 0xB6E7A0   Length: 0x6A5
    public void Init()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong local_28;
        float local_20;
        float local_18;
        float fStack_14;
        float fStack_10;
        float fStack_c;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Sprite",0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6d540);
            if ((this.innData != null) && (*pStatics_6270 != 0)) {
              uVar3 = TextureController.LoadAtlasSprite
                                (*pStatics_6270,"AreaIconAtlas",
                                 this.innData.innName,0);
              if (lVar2 != null) {
                SpriteRenderer.set_sprite(lVar2,uVar3,0);
                lVar2 = *(int64 *)(pStatics_baa8 + 16);
                if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 208)) != null) {
                  lVar2 = GameObject.get_transform(lVar2,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"AreaUIPanel",0);
                    if (lVar2 != null) {
                      uVar3 = Component.get_gameObject(lVar2,0);
                      lVar2 = *(int64 *)(pStatics_baa8 + 16);
                      if (lVar2 != null) {
                        uVar1 = *(uint64 *)(lVar2 + 216);
                        uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
                        this.areaUIRoot = uVar3;
                        if (this.areaUIRoot != null) {
                          lVar2 = GameObject.get_transform(this.areaUIRoot,0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"AreaUI",0);
                            if (lVar2 != null) {
                              lVar2 = Transform.Find(lVar2,"ForceIcon",0);
                              if (lVar2 != null) {
                                uVar3 = Component.get_gameObject(lVar2,0);
                                this.areaForceIcon = uVar3;
                                if (this.areaUIRoot != null) {
                                  lVar2 = GameObject.get_transform(this.areaUIRoot,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"AreaUI",0);
                                    if (lVar2 != null) {
                                      lVar2 = Transform.Find(lVar2,"AreaName",0);
                                      if (lVar2 != null) {
                                        uVar3 = Component.get_gameObject(lVar2,0);
                                        this.areaNameLabel = uVar3;
                                        if (this.areaNameLabel != null) {
                                          plVar4 = (int64 *)
                                                   GameObject.GetComponent
                                                             (this.areaNameLabel,DAT_181d9fe50)
                                          ;
                                          pfVar5 = (float *)FUN_181098a50(&local_18,0);
                                          if (plVar4 != (int64 *)0) {
                                            local_18 = *pfVar5;
                                            fStack_14 = pfVar5[1];
                                            fStack_10 = pfVar5[2];
                                            fStack_c = pfVar5[3];
                                            (**(code **)(*plVar4 + 0x2a8))
                                                      (plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
                                            if (this.areaForceIcon != null) {
                                              plVar4 = (int64 *)
                                                       GameObject.GetComponent
                                                                 (this.areaForceIcon,
                                                                  DAT_181d9fe50);
                                              pfVar5 = (float *)FUN_180d904c0(&local_18,0);
                                              if (plVar4 != (int64 *)0) {
                                                local_18 = *pfVar5;
                                                fStack_14 = pfVar5[1];
                                                fStack_10 = pfVar5[2];
                                                fStack_c = pfVar5[3];
                                                (**(code **)(*plVar4 + 0x2a8))
                                                          (plVar4,&local_18,
                                                           *(uint64 *)(*plVar4 + 0x2b0));
                                                if (this.areaUIRoot != null) {
                                                  lVar2 = GameObject.get_transform
                                                                    (this.areaUIRoot,0);
                                                  if (lVar2 != null) {
                                                    lVar2 = Transform.Find(lVar2,"MissionTarget",0);
                                                    if (lVar2 != null) {
                                                      uVar3 = Component.GetComponent(lVar2,DAT_181d6bc40)
                                                      ;
                                                      this.missionTarget = uVar3;
                                                      il2cpp_internal((uint64 *)(this + 56),
                                                                          uVar3);
                                                      if (this.areaNameLabel != null) {
                                                        lVar2 = GameObject.get_transform
                                                                          (this.areaNameLabel,0
                                                                          );
                                                        if (lVar2 != null) {
                                                          lVar2 = Transform.Find(lVar2,"Label",0);
                                                          if (lVar2 != null) {
                                                            uVar3 = Component.GetComponent
                                                                              (lVar2,DAT_181d6d8c0);
                                                            if (this.innData != null) {
                                                              LTLocalization.SetText
                                                                        (uVar3,*(uint64 *)
                                                                                (*(int64 *)
                                                                                  (this + 24) + 24)
                                                                         ,0);
                                                              if (this.areaUIRoot != null) {
                                                                lVar2 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0);
                                                                if (lVar2 != null) {
                                                                  lVar2 = Transform.Find(lVar2,
                                                        "AreaUI",0);
                                                        if (lVar2 != null) {
                                                          uVar3 = Component.GetComponent
                                                                            (lVar2,DAT_181d6c740);
                                                          LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                    (uVar3,0);
                                                          if (this.areaSafeRange != null) {
                                                            lVar2 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 64),0);
                                                            puVar6 = (uint64 *)
                                                                     Vector3.get_one(&local_18,0);
                                                            local_28 = *puVar6;
                                                            local_20 = *(float *)(puVar6 + 1);
                                                            fStack_10 = **(float **)(DAT_181d5a7f8 + 184)
                                                            ;
                                                            local_18 = (float)local_28 * fStack_10;
                                                            fStack_14 = local_28._4_4_ * fStack_10;
                                                            fStack_10 = local_20 * fStack_10;
                                                            if (lVar2 != null) {
                                                              local_28 = CONCAT44(fStack_14,local_18);
                                                              local_20 = fStack_10;
                                                              Transform.set_localScale(lVar2,&local_28,0)
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
    }

    // Token : 0x600182E
    // RVA   : 0xB70720   Offset: 0xB6EF20   Length: 0xF0
    public void SetSafeRange()
    {
        long lVar1;
        ulong local_28;
        float local_20;
        float local_18;
        float fStack_14;
        float local_10;
        if (this.areaSafeRange != null) {
          lVar1 = GameObject.get_transform(this.areaSafeRange,0);
          puVar2 = (uint64 *)Vector3.get_one(&local_18,0);
          local_28 = *puVar2;
          local_20 = *(float *)(puVar2 + 1);
          local_10 = **(float **)(DAT_181d5a7f8 + 184);
          local_18 = (float)local_28 * local_10;
          fStack_14 = local_28._4_4_ * local_10;
          local_10 = local_20 * local_10;
          if (lVar1 != null) {
            local_28 = CONCAT44(fStack_14,local_18);
            local_20 = local_10;
            Transform.set_localScale(lVar1,&local_28,0);
            return;
          }
        }
    }

    // Token : 0x600182F
    // RVA   : 0xB70910   Offset: 0xB6F110   Length: 0x9CC
    private void Update()
    {
        var pStatics_6270 = *(int64*)(DAT_181d86270 + 184);
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        bool cVar1;
        byte uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar7;
        float fVar9;
        float fVar10;
        ulong local_68;
        ulong local_58;
        float local_50;
        ulong local_48;
        float fStack_40;
        uint32 uStack_3c;
        lVar3 = *(int64 *)(pStatics_baa8 + 16);
        if (lVar3 == null) throw; // [null/range check failed]
        fVar9 = (float)BigMapController.BigMapNowScale(lVar3,0);
        lVar3 = this.areaUIRoot;
        if (fVar9 < 0.3) {
          if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9f080)) == null)
          throw; // [null/range check failed]
          fVar9 = (float)CanvasGroup.get_alpha(lVar3,0);
          if (fVar9 != 0.0) {
            if (this.areaUIRoot == null) throw; // [null/range check failed]
            uVar4 = GameObject.GetComponent(this.areaUIRoot,DAT_181d9f080);
            cVar1 = DOTween.IsTweening(uVar4,1,0);
            if (!cVar1) {
              if (this.areaUIRoot == null) throw; // [null/range check failed]
              uVar4 = GameObject.GetComponent(this.areaUIRoot,DAT_181d9f080);
              DOTweenModuleUI.DOFade(uVar4,0,0x3e4ccccd,0);
            }
            if (this.areaUIRoot == null) throw; // [null/range check failed]
            lVar3 = GameObject.get_transform(this.areaUIRoot,0);
            lVar5 = Component.get_transform(this,0);
            if (lVar5 == null) throw; // [null/range check failed]
            puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
            local_58 = *puVar6;
            local_50 = *(float *)(puVar6 + 1);
            local_48 = this.innUIOffset;
            fStack_40 = *(float *)(this + 84);
            lVar5 = FUN_18046bbe0(0);
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)BigMapController.BigMapNowScale(lVar5,0);
            local_68 = CONCAT44(local_48._4_4_ * fVar9 + local_58._4_4_,
                                (float)local_48 * fVar9 + (float)local_58);
            if (lVar3 == null) throw; // [null/range check failed]
            local_48 = local_68;
            fStack_40 = fStack_40 * fVar9 + local_50;
            Transform.set_position(lVar3,&local_48,0);
          }
        }
        else {
          if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9f080)) == null)
          throw; // [null/range check failed]
          fVar9 = (float)CanvasGroup.get_alpha(lVar3,0);
          if (fVar9 != 1.0) {
            if (this.areaUIRoot == null) throw; // [null/range check failed]
            uVar4 = GameObject.GetComponent(this.areaUIRoot,DAT_181d9f080);
            cVar1 = DOTween.IsTweening(uVar4,1,0);
            if (!cVar1) {
              if (this.areaUIRoot == null) throw; // [null/range check failed]
              uVar4 = GameObject.GetComponent(this.areaUIRoot,DAT_181d9f080);
              DOTweenModuleUI.DOFade(uVar4,0x3f800000,0x3ecccccd,0);
            }
          }
          if (this.areaUIRoot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.areaUIRoot,0);
          lVar5 = Component.get_transform(this,0);
          if (lVar5 == null) throw; // [null/range check failed]
          puVar6 = (uint64 *)Transform.get_position(&local_48,lVar5,0);
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          fVar9 = *(float *)(this + 84);
          uVar4 = this.innUIOffset;
          lVar5 = *(int64 *)(pStatics_baa8 + 16);
          if (lVar5 == null) throw; // [null/range check failed]
          fVar10 = (float)BigMapController.BigMapNowScale(lVar5,0);
          local_68._0_4_ = (float)uVar4;
          local_68._4_4_ = (float)((uint64)uVar4 >> 32);
          local_48 = CONCAT44(local_68._4_4_ * fVar10 + local_58._4_4_,
                              (float)local_68 * fVar10 + (float)local_58);
          fStack_40 = fVar9 * fVar10 + local_50;
          if (lVar3 == null) throw; // [null/range check failed]
          local_58 = local_48;
          local_50 = fStack_40;
          Transform.set_position(lVar3,&local_58,0);
          if (this.areaUIRoot == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.areaUIRoot,0);
          puVar6 = (uint64 *)Vector3.get_one(&local_58,0);
          local_48 = *puVar6;
          fStack_40 = *(float *)(puVar6 + 1);
          lVar5 = *(int64 *)(pStatics_baa8 + 16);
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)BigMapController.BigMapNowScale(lVar5,0);
          fVar9 = fVar9 + 1.0;
          local_50 = fStack_40 * fVar9 * 0.5;
          local_58 = CONCAT44(local_48._4_4_ * fVar9 * 0.5,(float)local_48 * fVar9 * 0.5);
          if (lVar3 == null) throw; // [null/range check failed]
          local_48 = local_58;
          fStack_40 = local_50;
          Transform.set_localScale(lVar3,&local_48,0);
          lVar3 = this.innData;
          if (lVar3 == null) throw; // [null/range check failed]
          plVar8 = this.missionTarget;
          if (lVar3.plotNumCount < 1) {
            if (lVar3.missionNumCount < 1) {
              puVar6 = (uint64 *)FUN_180d904c0(&local_48,0);
            }
            else {
              if ((*pStatics_6270 == 0) ||
                 (uVar4 = TextureController.LoadAtlasSprite
                                    (*pStatics_6270,"UIAtlas","任务目标",0),
                 plVar8 == (int64 *)0)) throw; // [null/range check failed]
              Image.set_sprite(plVar8,uVar4,0);
              plVar8 = this.missionTarget;
              puVar6 = (uint64 *)FUN_181098a50(&local_48,0);
            }
          }
          else {
            if ((*pStatics_6270 == 0) ||
               (uVar4 = TextureController.LoadAtlasSprite
                                  (*pStatics_6270,"UIAtlas","问号",0),
               plVar8 == (int64 *)0)) throw; // [null/range check failed]
            Image.set_sprite(plVar8,uVar4,0);
            plVar8 = this.missionTarget;
            puVar6 = (uint64 *)Color.get_yellow(&local_48,0);
          }
          if (plVar8 == (int64 *)0) throw; // [null/range check failed]
          local_48 = *puVar6;
          fStack_40 = *(float *)(puVar6 + 1);
          uStack_3c = *(uint32 *)((int64)puVar6 + 12);
          (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_48,*(uint64 *)(*plVar8 + 0x2b0));
        }
        lVar3 = *(int64 *)(pStatics_baa8 + 16);
        if (lVar3 != null) {
          uVar4 = *(uint64 *)(lVar3 + 88);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) {
        LAB_180b71263:
            uVar4 = MouseController.get_hoveredObject(0);
            uVar7 = Component.get_gameObject(this,0);
            uVar2 = Object.op_Equality(uVar4,uVar7,0);
            InnIconController.ShowAreaSafeSprite(this,uVar2,0);
            return;
          }
          lVar3 = *(int64 *)(pStatics_baa8 + 16);
          if (((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) &&
             (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9e910)) != null) {
            uVar4 = *(uint64 *)(lVar3 + 184);
            uVar7 = this.areaSafeRange;
            cVar1 = Object.op_Equality(uVar4,uVar7,0);
            if (!cVar1) goto LAB_180b71263;
            if (this.showAreaSafeSprite) {
              return;
            }
            this.showAreaSafeSprite = 1;
            if ((this.areaSafeRange != null) &&
               (lVar3 = GameObject.get_transform(this.areaSafeRange,0)) != null) {
              uVar4 = Transform.Find(lVar3,"AreaSafeSprite",0);
              ShortcutExtensions.DOScale(uVar4,0x3f800000,0x3e99999a,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001830
    // RVA   : 0xB70650   Offset: 0xB6EE50   Length: 0xCC
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

    // Token : 0x6001831
    // RVA   : 0xB70820   Offset: 0xB6F020   Length: 0xE6
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
        LAB_180b70901:
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
          goto LAB_180b70901;
        }
    }

    // Token : 0x6001832
    // RVA   : 0x7ED860   Offset: 0x7EC060   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6001833
    // RVA   : 0x7ED8C0   Offset: 0x7EC0C0   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6001834
    // RVA   : 0xB71320   Offset: 0xB6FB20   Length: 0x37
    public void /*ctor*/()
    {
        this.innUIOffset = 0x3e4ccccdbdcccccd;
        *(uint32 *)(this + 84) = 0;
        FUN_18044ef50(0,0);
    }

    // Token : 0x6001835
    // RVA   : 0xB712E0   Offset: 0xB6FAE0   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181d5a7f8 + 184) = 0x3e99999a;
    }

}
