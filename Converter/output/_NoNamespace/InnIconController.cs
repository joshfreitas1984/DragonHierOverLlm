// ============================================================
// Type  : InnIconController
// Token : 0x20002F4
// ============================================================

public class InnIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001856
    public InnData innData;

    // Token: 0x4001857
    public GameObject areaUIRoot;

    // Token: 0x4001858
    public GameObject areaNameLabel;

    // Token: 0x4001859
    public GameObject areaForceIcon;

    // Token: 0x400185A
    public Image missionTarget;

    // Token: 0x400185B
    public GameObject areaSafeRange;

    // Token: 0x400185C
    public static float safeRange;

    // Token: 0x400185D
    public bool showAreaSafeSprite;

    // Token: 0x400185E
    private Vector3 innUIOffset;

    // Token: 0x400185F
    private CanvasGroup areaCanvasGroup;

    // Token: 0x4001860
    private Transform areaSafeSpriteTrans;

    // Token: 0x4001861
    private BigmapNpcController playerArmyNpc;

    // Token: 0x4001862
    private int missionState;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018ED
    // RVA   : 0xA1C1D0   Offset: 0xA1AFD0   Length: 0x701
    public void Init()
    {
        var pStatics_b8e8 = *(int64*)(DAT_181e8b8e8 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong local_38;
        float local_30;
        float local_28;
        float fStack_24;
        float fStack_20;
        float fStack_1c;
        this.areaCanvasGroup = 0;
        this.missionState = 0xffffffff;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Sprite",0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181e791b8);
            if ((this.innData != null) && (*pStatics_b8e8 != 0)) {
              uVar3 = TextureController.LoadAtlasSprite
                                (*pStatics_b8e8,"AreaIconAtlas",
                                 this.innData.innName,0);
              if (lVar2 != null) {
                SpriteRenderer.set_sprite(lVar2,uVar3,0);
                lVar2 = GameController.CheckShowSpeHero;
                if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 216)) != null) {
                  lVar2 = GameObject.get_transform(lVar2,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"AreaUIPanel",0);
                    if (lVar2 != null) {
                      uVar3 = Component.get_gameObject(lVar2,0);
                      lVar2 = GameController.CheckShowSpeHero;
                      if (lVar2 != null) {
                        uVar1 = *(uint64 *)(lVar2 + 224);
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
                                                             (this.areaNameLabel,DAT_181e54f48)
                                          ;
                                          pfVar5 = (float *)FUN_180f24d00(&local_28,0);
                                          if (plVar4 != (int64 *)0) {
                                            local_28 = *pfVar5;
                                            fStack_24 = pfVar5[1];
                                            fStack_20 = pfVar5[2];
                                            fStack_1c = pfVar5[3];
                                            (**(code **)(*plVar4 + 0x2a8))
                                                      (plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
                                            if (this.areaForceIcon != null) {
                                              plVar4 = (int64 *)
                                                       GameObject.GetComponent
                                                                 (this.areaForceIcon,
                                                                  DAT_181e54f48);
                                              pfVar5 = (float *)FUN_180af4e90(&local_28,0);
                                              if (plVar4 != (int64 *)0) {
                                                local_28 = *pfVar5;
                                                fStack_24 = pfVar5[1];
                                                fStack_20 = pfVar5[2];
                                                fStack_1c = pfVar5[3];
                                                (**(code **)(*plVar4 + 0x2a8))
                                                          (plVar4,&local_28,
                                                           *(uint64 *)(*plVar4 + 0x2b0));
                                                if (this.areaUIRoot != null) {
                                                  lVar2 = GameObject.get_transform
                                                                    (this.areaUIRoot,0);
                                                  if (lVar2 != null) {
                                                    lVar2 = Transform.Find(lVar2,"MissionTarget",0);
                                                    if (lVar2 != null) {
                                                      uVar3 = Component.GetComponent(lVar2,DAT_181e777b8)
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
                                                                              (lVar2,DAT_181e79538);
                                                            if (this.innData != null) {
                                                              uVar1 = *(uint64 *)
                                                                       (this.innData +
                                                                       24);
                                                              if (((*(byte *)(DAT_181e64c70 + 0x133) & 4)
                                                                   != 0) &&
                                                                 (*(int *)(DAT_181e64c70 + 224) == 0)) {
                                                                il2cpp_runtime_class_init();
                                                              }
                                                              LTLocalization.SetText(uVar3,uVar1,0);
                                                              if (this.areaUIRoot != null) {
                                                                lVar2 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0);
                                                                if (lVar2 != null) {
                                                                  lVar2 = Transform.Find(lVar2,
                                                        "AreaUI",0);
                                                        if (lVar2 != null) {
                                                          uVar3 = Component.GetComponent
                                                                            (lVar2,DAT_181e782b8);
                                                          LayoutRebuilder.ForceRebuildLayoutImmediate
                                                                    (uVar3,0);
                                                          if (this.areaSafeRange != null) {
                                                            lVar2 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 64),0);
                                                            puVar6 = (uint64 *)
                                                                     Vector3.get_one(&local_28,0);
                                                            local_38 = *puVar6;
                                                            local_30 = *(float *)(puVar6 + 1);
                                                            fStack_20 = **(float **)(DAT_181e5fd08 + 184)
                                                            ;
                                                            local_28 = (float)local_38 * fStack_20;
                                                            fStack_24 = local_38._4_4_ * fStack_20;
                                                            fStack_20 = local_30 * fStack_20;
                                                            if (lVar2 != null) {
                                                              local_38 = CONCAT44(fStack_24,local_28);
                                                              local_30 = fStack_20;
                                                              Transform.set_localScale(lVar2,&local_38,0)
                                                              ;
                                                              InnIconController.EnsureRefs(this,0);
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

    // Token : 0x60018EE
    // RVA   : 0xA1C9B0   Offset: 0xA1B7B0   Length: 0xF0
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
          local_10 = **(float **)(DAT_181e5fd08 + 184);
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

    // Token : 0x60018EF
    // RVA   : 0xA1C040   Offset: 0xA1AE40   Length: 0x187
    private void EnsureRefs()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uVar2 = this.areaCanvasGroup;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.areaUIRoot;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.areaUIRoot == null) goto LAB_180a1c1c2;
            uVar2 = GameObject.GetComponent(this.areaUIRoot,DAT_181e53ed0);
            this.areaCanvasGroup = uVar2;
          }
        }
        uVar2 = this.areaSafeSpriteTrans;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.areaSafeRange;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if ((this.areaSafeRange != null) &&
               (lVar3 = GameObject.get_transform(this.areaSafeRange,0)) != null) {
              uVar2 = Transform.Find(lVar3,"AreaSafeSprite",0);
              this.areaSafeSpriteTrans = uVar2;
              return;
            }
        LAB_180a1c1c2:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x60018F0
    // RVA   : 0xA1CC60   Offset: 0xA1BA60   Length: 0x845
    private void Update()
    {
        var pStatics_b8e8 = *(int64*)(DAT_181e8b8e8 + 184);
        bool cVar1;
        byte uVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar8;
        ulong uVar9;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        InnIconController.EnsureRefs(this,0);
        lVar4 = GameController.CheckShowSpeHero;
        uVar8 = local_58;
        fVar12 = local_50;
        if (lVar4 == null) goto LAB_180a1d4a0;
        fVar11 = (float)BigMapController.BigMapNowScale(lVar4,0);
        lVar4 = this.areaCanvasGroup;
        uVar8 = local_58;
        fVar12 = local_50;
        if (fVar11 < 0.3) {
          if (lVar4 == null) goto LAB_180a1d4a0;
          fVar12 = (float)CanvasGroup.get_alpha(lVar4,0);
          if (fVar12 != 0.0) {
            uVar8 = this.areaCanvasGroup;
            cVar1 = DOTween.IsTweening(uVar8,1,0);
            if (!cVar1) {
              DOTweenModuleUI.DOFade(this.areaCanvasGroup,0,0x3e4ccccd,0);
            }
            uVar8 = local_58;
            fVar12 = local_50;
            if (this.areaUIRoot == null) goto LAB_180a1d4a0;
            lVar4 = GameObject.get_transform(this.areaUIRoot,0);
            lVar5 = Component.get_transform(this,0);
            uVar8 = local_58;
            fVar12 = local_50;
            if (lVar5 == null) goto LAB_180a1d4a0;
            puVar6 = (uint64 *)Transform.get_position(&local_38,lVar5,0);
            uVar8 = this.innUIOffset;
            local_60 = *(float *)(puVar6 + 1);
            local_58 = CONCAT44((float)((uint64)uVar8 >> 32) * fVar11 +
                                (float)((uint64)*puVar6 >> 32),(float)uVar8 * fVar11 + (float)*puVar6
                               );
            local_50 = *(float *)(this + 84) * fVar11 + local_60;
            fVar12 = *(float *)(this + 84);
            if (lVar4 == null) goto LAB_180a1d4a0;
            Transform.set_position(lVar4,&local_58,0);
          }
        }
        else {
          if (lVar4 == null) goto LAB_180a1d4a0;
          fVar12 = (float)CanvasGroup.get_alpha(lVar4,0);
          if (fVar12 != 1.0) {
            uVar8 = this.areaCanvasGroup;
            cVar1 = DOTween.IsTweening(uVar8,1,0);
            if (!cVar1) {
              DOTweenModuleUI.DOFade(this.areaCanvasGroup,0x3f800000,0x3ecccccd,0);
            }
          }
          uVar8 = local_58;
          fVar12 = local_50;
          if (this.areaUIRoot == null) goto LAB_180a1d4a0;
          lVar4 = GameObject.get_transform(this.areaUIRoot,0);
          lVar5 = Component.get_transform(this,0);
          uVar8 = local_58;
          fVar12 = local_50;
          if (lVar5 == null) goto LAB_180a1d4a0;
          puVar6 = (uint64 *)Transform.get_position(&local_38,lVar5,0);
          local_60 = *(float *)(this + 84);
          local_68 = this.innUIOffset;
          uVar8 = *puVar6;
          local_58 = CONCAT44((float)((uint64)local_68 >> 32) * fVar11 +
                              (float)((uint64)uVar8 >> 32),(float)local_68 * fVar11 + (float)uVar8);
          local_50 = local_60 * fVar11 + *(float *)(puVar6 + 1);
          fVar12 = *(float *)(puVar6 + 1);
          if (lVar4 == null) goto LAB_180a1d4a0;
          Transform.set_position(lVar4,&local_58,0);
          puVar6 = (uint64 *)Vector3.get_one(&local_38,0);
          fVar11 = fVar11 + 1.0;
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          fVar14 = (float)((uint64)local_58 >> 32);
          fVar13 = (float)local_58 * fVar11 * 0.5;
          uVar9 = CONCAT44(fVar14 * fVar11 * 0.5,fVar13);
          fVar11 = local_50 * fVar11 * 0.5;
          uVar8 = local_58;
          fVar12 = local_50;
          if ((this.areaUIRoot == null) ||
             (lVar4 = GameObject.get_transform
                                (this.areaUIRoot,0,(float)local_58,CONCAT44(fVar14,fVar13),
                                 uVar9,fVar11), uVar8 = local_58, fVar12 = local_50, lVar4 == null))
          goto LAB_180a1d4a0;
          local_58 = uVar9;
          local_50 = fVar11;
          puVar6 = (uint64 *)Transform.get_localScale(&local_38,lVar4,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1);
          cVar1 = Vector3.op_Inequality(&local_68,&local_58,0);
          if (cVar1) {
            uVar8 = local_58;
            fVar12 = local_50;
            if ((this.areaUIRoot == null) ||
               (lVar4 = GameObject.get_transform(this.areaUIRoot,0), uVar8 = local_58,
               fVar12 = local_50, lVar4 == null)) goto LAB_180a1d4a0;
            local_58 = uVar9;
            local_50 = fVar11;
            Transform.set_localScale(lVar4,&local_58,0);
          }
          lVar4 = this.innData;
          uVar8 = local_58;
          fVar12 = local_50;
          if (lVar4 == null) goto LAB_180a1d4a0;
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
              uVar8 = local_58;
              fVar12 = local_50;
              if ((*pStatics_b8e8 == 0) ||
                 (uVar9 = TextureController.LoadAtlasSprite
                                    (*pStatics_b8e8,"UIAtlas","问号",0),
                 uVar8 = local_58, fVar12 = local_50, plVar10 == (int64 *)0)) goto LAB_180a1d4a0;
              Image.set_sprite(plVar10,uVar9,0);
              plVar10 = this.missionTarget;
              puVar7 = (uint32 *)Color.get_yellow(&local_38,0);
            }
            else if (iVar3 == 2) {
              lVar4 = FUN_180210d00(0);
              uVar8 = local_58;
              fVar12 = local_50;
              if ((lVar4 == null) ||
                 (uVar9 = TextureController.LoadAtlasSprite(lVar4,"UIAtlas","任务目标",0),
                 uVar8 = local_58, fVar12 = local_50, plVar10 == (int64 *)0)) goto LAB_180a1d4a0;
              Image.set_sprite(plVar10,uVar9,0);
              plVar10 = this.missionTarget;
              puVar7 = (uint32 *)FUN_180f24d00(&local_38,0);
            }
            else {
              puVar7 = (uint32 *)FUN_180af4e90(&local_38,0);
            }
            uVar8 = local_58;
            fVar12 = local_50;
            if (plVar10 == (int64 *)0) goto LAB_180a1d4a0;
            local_38 = *puVar7;
            uStack_34 = puVar7[1];
            uStack_30 = puVar7[2];
            uStack_2c = puVar7[3];
            (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_38,*(uint64 *)(*plVar10 + 0x2b0));
          }
        }
        uVar8 = this.playerArmyNpc;
        cVar1 = Object.op_Equality(uVar8,0,0);
        if (cVar1) {
          lVar4 = GameController.CheckShowSpeHero;
          uVar8 = local_58;
          fVar12 = local_50;
          if (lVar4 == null) goto LAB_180a1d4a0;
          uVar8 = *(uint64 *)(lVar4 + 88);
          cVar1 = Object.op_Inequality(uVar8,0,0);
          if (cVar1) {
            lVar4 = FUN_180210220(0);
            uVar8 = local_58;
            fVar12 = local_50;
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) goto LAB_180a1d4a0;
            uVar8 = GameObject.GetComponent(*(int64 *)(lVar4 + 88),DAT_181e53760);
            this.playerArmyNpc = uVar8;
          }
        }
        uVar8 = this.playerArmyNpc;
        cVar1 = Object.op_Inequality(uVar8,0,0);
        if (cVar1) {
          uVar8 = local_58;
          fVar12 = local_50;
          if (this.playerArmyNpc == null) {
        LAB_180a1d4a0:
            local_50 = fVar12;
            local_58 = uVar8;
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar8 = this.playerArmyNpc.areaSafeRange;
          uVar9 = this.areaSafeRange;
          cVar1 = Object.op_Equality(uVar8,uVar9,0);
          if (cVar1) {
            uVar2 = 1;
            goto LAB_180a1d3ff;
          }
        }
        uVar8 = MouseController.get_hoveredObject(0);
        uVar9 = Component.get_gameObject(this,0);
        uVar2 = Object.op_Equality(uVar8,uVar9,0);
        LAB_180a1d3ff:
        InnIconController.ShowAreaSafeSprite(this,uVar2,0);
    }

    // Token : 0x60018F1
    // RVA   : 0xA1C8E0   Offset: 0xA1B6E0   Length: 0xCC
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

    // Token : 0x60018F2
    // RVA   : 0xA1CAB0   Offset: 0xA1B8B0   Length: 0x1A3
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

    // Token : 0x60018F3
    // RVA   : 0x51DF30   Offset: 0x51CD30   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x60018F4
    // RVA   : 0x51DF90   Offset: 0x51CD90   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x60018F5
    // RVA   : 0xA1D4F0   Offset: 0xA1C2F0   Length: 0x3E
    public void /*ctor*/()
    {
        this.innUIOffset = 0x3e4ccccdbdcccccd;
        *(uint32 *)(this + 84) = 0;
        this.missionState = 0xffffffff;
        FUN_180ae8740(0,0);
    }

    // Token : 0x60018F6
    // RVA   : 0xA1D4B0   Offset: 0xA1C2B0   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181e5fd08 + 184) = 0x3e99999a;
    }

}
