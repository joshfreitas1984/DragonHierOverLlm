// ============================================================
// Type  : QuickTravelUIController
// Token : 0x200032C
// ============================================================

public class QuickTravelUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001993
    private bool inited;

    // Token: 0x4001994
    public QuickTravelUIType quickTravelUIType;

    // Token: 0x4001995
    public GameObject quickTravelUI;

    // Token: 0x4001996
    public GameObject playerIcon;

    // Token: 0x4001997
    public GameObject quickTravelAreaIcon;

    // Token: 0x4001998
    public GameObject quickTravelResourcePointIcon;

    // Token: 0x4001999
    public GameObject quickTravelInnIcon;

    // Token: 0x400199A
    public GameObject areaIcons;

    // Token: 0x400199B
    public GameObject quickTravelRoadPrefab;

    // Token: 0x400199C
    public GameObject roads;

    // Token: 0x400199D
    public List<Sprite> areaSprite;

    // Token: 0x400199E
    public List<Sprite> areaSpriteOutLine;

    // Token: 0x400199F
    public List<float> areaNameOffset;

    // Token: 0x40019A0
    public List<bool> showAreaType;

    // Token: 0x40019A1
    public bool showResourcePoint;

    // Token: 0x40019A2
    public bool showInn;

    // Token: 0x40019A3
    public GameObject roadToggleButton;

    // Token: 0x40019A4
    public Slider scaleSlider;

    // Token: 0x40019A5
    public List<GameObject> areaObjs;

    // Token: 0x40019A6
    public List<GameObject> resourceObjs;

    // Token: 0x40019A7
    public List<GameObject> innObjs;

    // Token: 0x40019A8
    public GameObject bigmapScaleRoot;

    // Token: 0x40019A9
    public GameObject bigmapRoot;

    // Token: 0x40019AA
    public float nowScale;

    // Token: 0x40019AB
    public float bigMapWidth;

    // Token: 0x40019AC
    public float bigMapHeight;

    // Token: 0x40019AD
    private float BaseMapScale;

    // Token: 0x40019AE
    private bool autoClose;

    // Token: 0x40019AF
    private static QuickTravelUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FAE
    // RVA   : 0xC55EF0   Offset: 0xC546F0   Length: 0x36
    public static QuickTravelUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d6ede0 + 184);
    }

    // Token : 0x6001FAF
    // RVA   : 0xC50690   Offset: 0xC4EE90   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d6ede0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001FB0
    // RVA   : 0xC559A0   Offset: 0xC541A0   Length: 0x255
    private void Start()
    {
        float fVar1;
        long lVar2;
        float fVar4;
        uint uVar5;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [32];
        if (this.quickTravelUI != null) {
          lVar2 = GameObject.get_transform(this.quickTravelUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"MapRoot",0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"BigMap",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181d6c740);
                if (lVar2 != null) {
                  puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                  local_38 = *puVar3;
                  uStack_34 = puVar3[1];
                  uStack_30 = puVar3[2];
                  uStack_2c = puVar3[3];
                  fVar4 = (float)FUN_18044e2b0(&local_38,0);
                  fVar1 = *(float *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x110);
                  this.BaseMapScale = fVar4 / (fVar1 + fVar1);
                  if (this.quickTravelUI != null) {
                    lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                    if (lVar2 != null) {
                      lVar2 = Transform.Find(lVar2,"MapRoot",0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"BigMap",0);
                        if (lVar2 != null) {
                          lVar2 = Component.GetComponent(lVar2,DAT_181d6c740);
                          if (lVar2 != null) {
                            puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                            local_38 = *puVar3;
                            uStack_34 = puVar3[1];
                            uStack_30 = puVar3[2];
                            uStack_2c = puVar3[3];
                            uVar5 = FUN_180d90480(&local_38,0);
                            this.bigMapWidth = uVar5;
                            if (this.quickTravelUI != null) {
                              lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                              if (lVar2 != null) {
                                lVar2 = Transform.Find(lVar2,"MapRoot",0);
                                if (lVar2 != null) {
                                  lVar2 = Transform.Find(lVar2,"BigMap",0);
                                  if (lVar2 != null) {
                                    lVar2 = Component.GetComponent(lVar2,DAT_181d6c740);
                                    if (lVar2 != null) {
                                      puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                                      local_38 = *puVar3;
                                      uStack_34 = puVar3[1];
                                      uStack_30 = puVar3[2];
                                      uStack_2c = puVar3[3];
                                      uVar5 = FUN_18044e2b0(&local_38,0);
                                      *(uint32 *)(this + 200) = uVar5;
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

    // Token : 0x6001FB1
    // RVA   : 0xC50840   Offset: 0xC4F040   Length: 0x144
    public void ChangePos(Vector3 deltaPos)
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        ulong local_38;
        float local_30;
        ulong local_28;
        float local_20;
        if (this.bigmapRoot != null) {
          lVar2 = GameObject.get_transform(this.bigmapRoot,0);
          if (this.bigmapRoot != null) {
            lVar3 = GameObject.get_transform(this.bigmapRoot,0);
            if (lVar3 != null) {
              local_20 = *(float *)(deltaPos + 1);
              uVar1 = *deltaPos;
              puVar4 = (uint64 *)Transform.get_localPosition(&local_38,lVar3,0);
              local_30 = *(float *)(puVar4 + 1) + *(float *)(deltaPos + 1);
              local_38 = CONCAT44((float)((uint64)*puVar4 >> 32) + (float)((uint64)uVar1 >> 32),
                                  (float)*puVar4 + (float)uVar1);
              local_28 = uVar1;
              local_20 = local_30;
              puVar4 = (uint64 *)
                       QuickTravelUIController.LimitMapPos
                                 (&local_28,this,&local_38,this.nowScale,0);
              if (lVar2 != null) {
                local_38 = *puVar4;
                local_30 = *(float *)(puVar4 + 1);
                Transform.set_localPosition(lVar2,&local_38,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001FB2
    // RVA   : 0xC50700   Offset: 0xC4EF00   Length: 0x135
    public void ChangeNowScale(float deltaScale)
    {
        float fVar3;
        float fVar4;
        plVar1 = this.scaleSlider;
        if (plVar1 != (int64 *)0) {
          fVar3 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          plVar1 = this.scaleSlider;
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x428))
                      (plVar1,(this.nowScale - 1.0) + deltaScale * 0.1,
                       *(uint64 *)(*plVar1 + 0x430));
            plVar1 = this.scaleSlider;
            if (plVar1 != (int64 *)0) {
              fVar4 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
              if (fVar3 != fVar4) {
                plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/摩擦",0);
                plVar2 = (int64 *)0;
                if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
                  plVar2 = plVar1;
                }
                NGUITools.PlaySound(plVar2,0x3d75c28f,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001FB3
    // RVA   : 0xC51FD0   Offset: 0xC507D0   Length: 0xCD
    public void ScaleSliderChange()
    {
        float fVar3;
        plVar1 = this.scaleSlider;
        if (plVar1 != (int64 *)0) {
          fVar3 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          QuickTravelUIController.SetNowScale(this,fVar3 + 1.0,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/摩擦",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0x3d23d70a,0);
          return;
        }
    }

    // Token : 0x6001FB4
    // RVA   : 0xC520A0   Offset: 0xC508A0   Length: 0x5A9
    public void SetNowScale(float scale)
    {
        var pStatics = *(int64*)(DAT_181d6ede0 + 184);
        long lVar1;
        long lVar3;
        uint uVar4;
        long lVar5;
        uint uVar6;
        uint uVar7;
        float fVar8;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[32];
        uVar7 = FUN_1810a8ba0(scale,0x3f800000,0x40000000,0);
        this.nowScale = uVar7;
        if (this.bigmapScaleRoot != null) {
          lVar1 = GameObject.get_transform(this.bigmapScaleRoot,0);
          fVar8 = this.nowScale;
          puVar2 = (uint64 *)Vector3.get_one(&local_68,0);
          local_48 = *puVar2;
          local_40 = *(float *)(puVar2 + 1);
          local_60 = local_40 * fVar8;
          local_68 = CONCAT44((float)((uint64)local_48 >> 32) * fVar8,(float)local_48 * fVar8);
          local_58 = local_48;
          local_50 = local_40;
          if (lVar1 != null) {
            local_58 = local_68;
            local_50 = local_60;
            Transform.set_localScale(lVar1,&local_58,0);
            if (this.bigmapRoot != null) {
              lVar1 = GameObject.get_transform(this.bigmapRoot,0);
              if ((this.bigmapRoot != null) &&
                 (lVar3 = GameObject.get_transform(this.bigmapRoot,0)) != null) {
                uVar7 = this.nowScale;
                puVar2 = (uint64 *)Transform.get_localPosition(&local_48,lVar3,0);
                uVar6 = 0;
                local_58 = *puVar2;
                local_50 = *(float *)(puVar2 + 1);
                puVar2 = (uint64 *)
                         QuickTravelUIController.LimitMapPos(&local_48,this,&local_58,uVar7,0);
                if (lVar1 != null) {
                  local_58 = *puVar2;
                  local_50 = *(float *)(puVar2 + 1);
                  Transform.set_localPosition(lVar1,&local_58,0);
                  lVar1 = this.areaObjs;
                  if (lVar1 != null) {
                    lVar5 = 32;
                    lVar3 = 32;
                    uVar4 = uVar6;
                    while ((int)uVar4 < lVar1.Count) {
                      if (lVar1 == null) goto LAB_180c52644;
                      if (lVar1.Count <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(lVar3 + lVar1._items);
                      if ((lVar1 == null) ||
                         (lVar1 = GameObject.GetComponent(lVar1,DAT_181da0868)) == null)
                      goto LAB_180c52644;
                      QuickTravelAreaIconController.RefreshNameScale(lVar1,0);
                      lVar1 = this.areaObjs;
                      uVar4 = uVar4 + 1;
                      lVar3 = lVar3 + 8;
                      if (lVar1 == null) goto LAB_180c52644;
                    }
                    lVar1 = this.resourceObjs;
                    if (lVar1 != null) {
                      lVar3 = 32;
                      uVar4 = uVar6;
                      goto LAB_180c52341;
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180c52644:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c52341:
        if (lVar1.Count <= (int)uVar4) {
          lVar1 = this.innObjs;
          if (lVar1 != null) goto LAB_180c524b4;
          goto LAB_180c52644;
        }
        if (lVar1 == null) goto LAB_180c52644;
        if (lVar1.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar3 + lVar1._items);
        if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181da0978)) == null)
        goto LAB_180c52644;
        lVar1 = Component.get_transform(lVar1,0);
        if (lVar1 == null) goto LAB_180c52644;
        lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
        puVar2 = (uint64 *)Vector3.get_one(local_38,0);
        local_68 = *puVar2;
        local_60 = *(float *)(puVar2 + 1);
        if (*pStatics == 0) goto LAB_180c52644;
        fVar8 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
        local_50 = local_60 / fVar8;
        local_58 = CONCAT44(local_68._4_4_ / fVar8,(float)local_68 / fVar8);
        if (lVar1 == null) goto LAB_180c52644;
        local_48 = local_58;
        local_40 = local_50;
        Transform.set_localScale(lVar1,&local_48);
        lVar1 = this.resourceObjs;
        uVar4 = uVar4 + 1;
        lVar3 = lVar3 + 8;
        if (lVar1 == null) goto LAB_180c52644;
        goto LAB_180c52341;
        LAB_180c524b4:
        if (lVar1.Count <= (int)uVar6) {
          return;
        }
        if (lVar1 == null) goto LAB_180c52644;
        if (lVar1.Count <= uVar6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar5 + lVar1._items);
        if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181da08f0)) == null)
        goto LAB_180c52644;
        lVar1 = Component.get_transform(lVar1,0);
        if (lVar1 == null) goto LAB_180c52644;
        lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
        puVar2 = (uint64 *)Vector3.get_one(local_38,0);
        local_58 = *puVar2;
        local_50 = *(float *)(puVar2 + 1);
        if (*pStatics == 0) goto LAB_180c52644;
        fVar8 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
        local_60 = local_50 / fVar8;
        local_68 = CONCAT44(local_58._4_4_ / fVar8,(float)local_58 / fVar8);
        if (lVar1 == null) goto LAB_180c52644;
        local_48 = local_68;
        local_40 = local_60;
        Transform.set_localScale(lVar1,&local_48);
        lVar1 = this.innObjs;
        uVar6 = uVar6 + 1;
        lVar5 = lVar5 + 8;
        if (lVar1 == null) goto LAB_180c52644;
        goto LAB_180c524b4;
    }

    // Token : 0x6001FB5
    // RVA   : 0xC51C20   Offset: 0xC50420   Length: 0x10B
    public Vector3 LimitMapPos(Vector3 originPos, float scale)
    {
        float * QuickTravelUIController.LimitMapPos
                        (float *this,int64 originPos,uint64 *scale,float param_4)
        {
        uint64 uVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        fVar2 = *(float *)(originPos + 196) * 0.5;
        fVar3 = *(float *)(scale + 1);
        uVar1 = *scale;
        *(uint64 *)this = uVar1;
        this[2] = fVar3;
        fVar5 = (fVar2 * param_4 - fVar2) / param_4;
        fVar4 = *this;
        if (fVar5 < *this) {
          this[1] = (float)((uint64)uVar1 >> 32);
          this[2] = fVar3;
          *this = fVar5;
          fVar4 = fVar5;
        }
        fVar3 = (fVar2 - fVar2 * param_4) / param_4;
        if (fVar4 < fVar3) {
          this[1] = (float)((uint64)*(uint64 *)this >> 32);
          this[2] = this[2];
          *this = fVar3;
        }
        fVar3 = *(float *)(originPos + 200) * 0.5;
        fVar4 = (fVar3 * param_4 - fVar3) / param_4;
        if (fVar4 < this[1]) {
          this[2] = this[2];
          this[1] = fVar4;
        }
        param_4 = (fVar3 - fVar3 * param_4) / param_4;
        if (this[1] <= param_4 && param_4 != this[1]) {
          this[2] = this[2];
          this[1] = param_4;
        }
        return this;
    }

    // Token : 0x6001FB6
    // RVA   : 0xC50BA0   Offset: 0xC4F3A0   Length: 0x1078
    private void InitQuickTravelMap()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        float fVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        long lVar11;
        long lVar12;
        long lVar13;
        int iVar14;
        uint uVar15;
        float fVar16;
        float local_res18;
        float fStackX_1c;
        uint64 local_168;
        float local_160;
        uint64 local_158;
        float local_150;
        uint32 local_148;
        uint32 uStack_144;
        uint32 uStack_140;
        uint32 uStack_13c;
        int64 local_138;
        uint32 local_128;
        uint32 local_124;
        uint32 local_120;
        uint64 local_118;
        uint64 uStack_110;
        int64 local_108;
        uint64 local_100;
        uint64 uStack_f8;
        int64 local_f0;
        int64 local_e8;
        float local_d8;
        uint64 local_c8;
        float local_c0;
        uint32 local_b8;
        uint32 uStack_b4;
        uint32 uStack_b0;
        uint32 uStack_ac;
        int64 local_a8;
        uint8 local_88 [16];
        uint8 local_78 [64];
        local_118 = 0;
        uStack_110 = 0;
        local_108 = 0;
        local_100 = 0;
        uStack_f8 = 0;
        local_f0 = 0;
        this.inited = 1;
        if (((*pStatics_df90 != 0) &&
            (lVar13 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar13 = *(int64 *)(lVar13 + 48)) != null) {
          FUN_1817ff240(&local_148,lVar13,DAT_181d550e0);
          local_b8 = local_148;
          uStack_b4 = uStack_144;
          uStack_b0 = uStack_140;
          uStack_ac = uStack_13c;
          local_a8 = local_138;
          while( true ) {
            cVar4 = FUN_180d197a0(&local_b8,DAT_181d639c8);
            lVar13 = local_a8;
            if (!cVar4) break;
            uVar8 = this.areaIcons;
            uVar2 = this.quickTravelAreaIcon;
            lVar6 = GlobalData.AddChild(uVar8,uVar2,0);
            local_e8 = lVar6;
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = GameObject.GetComponent(lVar6,DAT_181d9fe50);
            if (lVar13 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (this.areaSprite == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = FUN_180002f80(this.areaSprite,*(uint32 *)(lVar13 + 72),
                                  DAT_181d7c050);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Image.set_sprite(lVar7,uVar8,0);
            plVar9 = (int64 *)GameObject.GetComponent(lVar6,DAT_181d9fe50);
            if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620(0);
            }
            (**(code **)(*plVar9 + 0x408))(plVar9,*(uint64 *)(*plVar9 + 0x410));
            lVar7 = GameObject.GetComponent(lVar6,DAT_181da0b98);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = RectTransform.get_sizeDelta(lVar7,0);
            local_res18 = (float)uVar8;
            fStackX_1c = (float)((uint64)uVar8 >> 32);
            RectTransform.set_sizeDelta(lVar7,CONCAT44(fStackX_1c * 0.5,local_res18 * 0.5),0);
            lVar7 = GameObject.get_transform(lVar6,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"OutLine",0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Component.GetComponent(lVar7,DAT_181d6bc40);
            if (this.areaSpriteOutLine == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = FUN_180002f80(this.areaSpriteOutLine,*(uint32 *)(lVar13 + 72),
                                  DAT_181d7c050);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Image.set_sprite(lVar7,uVar8,0);
            lVar7 = GameObject.get_transform(lVar6,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"OutLine",0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar9 = (int64 *)Component.GetComponent(lVar7,DAT_181d6bc40);
            if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620(0);
            }
            (**(code **)(*plVar9 + 0x408))(plVar9,*(uint64 *)(*plVar9 + 0x410));
            lVar7 = GameObject.get_transform(lVar6,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"OutLine",0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Component.GetComponent(lVar7,DAT_181d6c740);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = RectTransform.get_sizeDelta(lVar7,0);
            local_res18 = (float)uVar8;
            fStackX_1c = (float)((uint64)uVar8 >> 32);
            RectTransform.set_sizeDelta(lVar7,CONCAT44(fStackX_1c * 0.5,local_res18 * 0.5),0);
            lVar7 = GameObject.get_transform(lVar6,0);
            fVar1 = this.BaseMapScale;
            if (*(int64 *)(lVar13 + 64) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar10 = (uint64 *)
                      BigMapPos.ToVector3(local_88,*(int64 *)(lVar13 + 64),0x3f800000,0);
            local_d8 = *(float *)(puVar10 + 1);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_c8 = CONCAT44((float)((uint64)*puVar10 >> 32) * fVar1,(float)*puVar10 * fVar1);
            local_c0 = local_d8 * fVar1;
            Transform.set_localPosition(lVar7,&local_c8,0);
            if (*(int *)(pStatics_ef00 + 8) == 1) {
              lVar7 = *(int64 *)(pStatics_ef00 + 24);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar4 = FUN_181815240(lVar7,*(uint32 *)(lVar13 + 16),DAT_181d67bf8);
              if (!cVar4) {
                plVar9 = (int64 *)GameObject.GetComponent(lVar6,DAT_181d9fe50);
                if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620(0);
                }
                (**(code **)(*plVar9 + 0x2c8))(plVar9,0,*(uint64 *)(*plVar9 + 0x2d0));
              }
            }
            lVar7 = GameObject.get_transform(lVar6,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"AreaNameBack",0);
            if (this.areaNameOffset == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar15 = FUN_1800d6780(this.areaNameOffset,*(uint32 *)(lVar13 + 72),
                                   DAT_181d796d8);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_128 = 0;
            local_120 = 0;
            local_124 = uVar15;
            Transform.set_localPosition(lVar7,&local_128,0);
            lVar7 = GameObject.get_transform(lVar6,0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"AreaNameBack",0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar7 = Transform.Find(lVar7,"AreaName",0);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
            LTLocalization.SetText(uVar8,*(uint64 *)(lVar13 + 24),0);
            lVar7 = GameObject.GetComponent(lVar6,DAT_181da0868);
            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            *(int64 *)(lVar7 + 24) = lVar13;
            if (this.areaObjs == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181827900(this.areaObjs,lVar6);
            iVar14 = 0;
            while( true ) {
              lVar6 = *(int64 *)(lVar13 + 152);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int *)(lVar6 + 24) <= iVar14) break;
              iVar5 = FUN_1800d6750(lVar6,iVar14);
              if (*(int *)(lVar13 + 16) < iVar5) {
                lVar6 = *(int64 *)(lVar13 + 64);
                lVar7 = FUN_18046c0a0(0);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar7 = *(int64 *)(lVar7 + 32);
                if (*(int64 *)(lVar13 + 152) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar15 = FUN_1800d6750(*(int64 *)(lVar13 + 152),iVar14);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar7 = WorldData.GetArea(lVar7,uVar15);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar8 = *(uint64 *)(lVar7 + 64);
                uVar2 = this.roads;
                uVar3 = this.quickTravelRoadPrefab;
                lVar7 = GlobalData.AddChild(uVar2,uVar3,0);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar11 = GameObject.get_transform(lVar7,0);
                lVar12 = GameObject.get_transform(local_e8,0);
                if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar10 = (uint64 *)Transform.get_localPosition(local_78,lVar12);
                if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_168 = *puVar10;
                local_160 = *(float *)(puVar10 + 1);
                Transform.set_localPosition(lVar11,&local_168);
                lVar11 = GameObject.GetComponent(lVar7,DAT_181da0b98);
                fVar1 = this.BaseMapScale;
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar16 = (float)BigMapPos.Distance(lVar6,uVar8);
                if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                RectTransform.set_sizeDelta(lVar11,CONCAT44(0x40400000,fVar16 * fVar1));
                lVar7 = GameObject.get_transform(lVar7,0);
                lVar6 = BigMapPos.op_Subtraction(uVar8,lVar6);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar10 = (uint64 *)BigMapPos.ToVector3(&local_148,lVar6,0x3f800000,0);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_158 = *puVar10;
                local_150 = *(float *)(puVar10 + 1);
                Transform.set_right(lVar7,&local_158);
              }
              iVar14 = iVar14 + 1;
            }
          }
          ZhSegment.Initialize(&local_b8,DAT_181d63948);
          lVar13 = FUN_18046c0a0(0);
          if (((lVar13 != null) && (*(int64 *)(lVar13 + 32) != 0)) &&
             (lVar13 = *(int64 *)(*(int64 *)(lVar13 + 32) + 64)) != null) {
            FUN_1817ff240(&local_148,lVar13,DAT_181d780d8);
            local_118 = CONCAT44(uStack_144,local_148);
            uStack_110 = CONCAT44(uStack_13c,uStack_140);
            local_108 = local_138;
            while( true ) {
              cVar4 = FUN_180d197a0(&local_118,DAT_181d6a6b8);
              lVar13 = local_108;
              if (!cVar4) break;
              uVar8 = this.areaIcons;
              uVar2 = this.quickTravelResourcePointIcon;
              lVar6 = GlobalData.AddChild(uVar8,uVar2,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = GameObject.get_transform(lVar6,0);
              fVar1 = this.BaseMapScale;
              if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar13 + 48) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              puVar10 = (uint64 *)
                        BigMapPos.ToVector3(&local_148,*(int64 *)(lVar13 + 48),0x3f800000,0);
              local_150 = *(float *)(puVar10 + 1);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_168 = CONCAT44((float)((uint64)*puVar10 >> 32) * fVar1,(float)*puVar10 * fVar1);
              local_160 = local_150 * fVar1;
              Transform.set_localPosition(lVar7,&local_168,0);
              lVar7 = GameObject.get_transform(lVar6,0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = Transform.Find(lVar7,"AreaNameBack",0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar7 = Transform.Find(lVar7,"AreaName",0);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              LTLocalization.SetText(uVar8,*(uint64 *)(lVar13 + 24),0);
              lVar7 = GameObject.GetComponent(lVar6,DAT_181da0978);
              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              *(int64 *)(lVar7 + 24) = lVar13;
              if (this.resourceObjs == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_181827900(this.resourceObjs,lVar6);
            }
            ZhSegment.Initialize(&local_118,DAT_181d6a638);
            lVar13 = FUN_18046c0a0(0);
            if (((lVar13 != null) && (*(int64 *)(lVar13 + 32) != 0)) &&
               (lVar13 = *(int64 *)(*(int64 *)(lVar13 + 32) + 56)) != null) {
              FUN_1817ff240(&local_148,lVar13,DAT_181d673f8);
              local_f0 = local_138;
              while( true ) {
                cVar4 = FUN_180d197a0(&local_100,DAT_181d671c8);
                lVar13 = local_f0;
                if (!cVar4) {
                  ZhSegment.Initialize(&local_100,DAT_181d67148);
                  return;
                }
                uVar8 = this.areaIcons;
                uVar2 = this.quickTravelInnIcon;
                lVar6 = GlobalData.AddChild(uVar8,uVar2,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar7 = GameObject.get_transform(lVar6,0);
                fVar1 = this.BaseMapScale;
                if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar13 + 48) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar10 = (uint64 *)
                          BigMapPos.ToVector3(&local_148,*(int64 *)(lVar13 + 48),0x3f800000,0);
                local_150 = *(float *)(puVar10 + 1);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_168 = CONCAT44((float)((uint64)*puVar10 >> 32) * fVar1,(float)*puVar10 * fVar1)
                ;
                local_160 = local_150 * fVar1;
                Transform.set_localPosition(lVar7,&local_168,0);
                lVar7 = GameObject.get_transform(lVar6,0);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar7 = Transform.Find(lVar7,"AreaNameBack",0);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar7 = Transform.Find(lVar7,"AreaName",0);
                if (lVar7 == null) break;
                uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                LTLocalization.SetText(uVar8,*(uint64 *)(lVar13 + 24),0);
                lVar7 = GameObject.GetComponent(lVar6,DAT_181da08f0);
                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar7 + 24) = lVar13;
                if (this.innObjs == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_181827900(this.innObjs,lVar6);
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6001FB7
    // RVA   : 0xC55E10   Offset: 0xC54610   Length: 0xE
    private void Update()
    {
        void FUN_180c55e10(int64 this)
        {
        if (!this.inited) {
          QuickTravelUIController.InitQuickTravelMap(this,0);
          return;
        }
    }

    // Token : 0x6001FB8
    // RVA   : 0xC55D30   Offset: 0xC54530   Length: 0x6B
    public void ToggleResourcePointButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        if (buttonClicked != null) {
          lVar1 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar1 != null) {
            this.showResourcePoint = *(uint8 *)(lVar1 + 0x118);
            QuickTravelUIController.RefreshAllResourceState(this,0);
            return;
          }
        }
    }

    // Token : 0x6001FB9
    // RVA   : 0xC55C00   Offset: 0xC54400   Length: 0xB6
    public void ToggleAreaTypeButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        lVar1 = this.showAreaType;
        if (buttonClicked != null) {
          uVar2 = Object.get_name(buttonClicked,0);
          uVar3 = Int32.Parse(uVar2,0);
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_181814bb0(lVar1,uVar3,*(uint8 *)(lVar4 + 0x118),DAT_181d58f90);
            QuickTravelUIController.RefreshAllAreaState(this,0);
            return;
          }
        }
    }

    // Token : 0x6001FBA
    // RVA   : 0xC55DA0   Offset: 0xC545A0   Length: 0x6F
    public void ToggleRoadButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        long lVar2;
        lVar1 = this.roads;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if ((lVar2 != null) && (lVar1 != null)) {
            GameObject.SetActive(lVar1,*(uint8 *)(lVar2 + 0x118),0);
            return;
          }
        }
    }

    // Token : 0x6001FBB
    // RVA   : 0xC55CC0   Offset: 0xC544C0   Length: 0x6B
    public void ToggleInnButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        if (buttonClicked != null) {
          lVar1 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar1 != null) {
            this.showInn = *(uint8 *)(lVar1 + 0x118);
            QuickTravelUIController.RefreshAllInnState(this,0);
            return;
          }
        }
    }

    // Token : 0x6001FBC
    // RVA   : 0xC52650   Offset: 0xC50E50   Length: 0x67
    public void SetRoadsActive(bool active)
    {
        long lVar1;
        if (this.roadToggleButton != null) {
          lVar1 = GameObject.GetComponent(this.roadToggleButton,DAT_181da2130);
          if (lVar1 != null) {
            Toggle.set_isOn(lVar1,active,0);
            return;
          }
        }
    }

    // Token : 0x6001FBD
    // RVA   : 0xC51D30   Offset: 0xC50530   Length: 0xD2
    public void RefreshAllAreaState()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.areaObjs;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181da0868)) == null)
            break;
            QuickTravelAreaIconController.RefreshState(lVar1,0);
            lVar1 = this.areaObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6001FBE
    // RVA   : 0xC51EF0   Offset: 0xC506F0   Length: 0xD2
    public void RefreshAllResourceState()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.resourceObjs;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181da0978)) == null)
            break;
            QuickTravelResourcePointController.RefreshState(lVar1,0);
            lVar1 = this.resourceObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6001FBF
    // RVA   : 0xC51E10   Offset: 0xC50610   Length: 0xD2
    public void RefreshAllInnState()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.innObjs;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          while( true ) {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar2 + lVar1._items);
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181da08f0)) == null)
            break;
            QuickTravelInnIconController.RefreshState(lVar1,0);
            lVar1 = this.innObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6001FC0
    // RVA   : 0xC506E0   Offset: 0xC4EEE0   Length: 0x11
    public void BackgroundClicked()
    {
        void FUN_180c506e0(int64 this)
        {
        if (!this.autoClose) {
          QuickTravelUIController.HideQuickTravelUI(this,0);
          return;
        }
    }

    // Token : 0x6001FC1
    // RVA   : 0xC50990   Offset: 0xC4F190   Length: 0x206
    public void HideQuickTravelUI()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.quickTravelUI != null) {
          lVar2 = GameObject.get_transform(this.quickTravelUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d6bc40);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98958);
              if (this.quickTravelUI != null) {
                lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"MapRoot",0);
                  uVar3 = ShortcutExtensions.DOScaleX(uVar3,0,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                  uVar4 = new OnTooltipCB(this,DAT_181d711f0,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181d96ee8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001FC2
    // RVA   : 0xC526C0   Offset: 0xC50EC0   Length: 0x88
    public void ShowQuickTravelUIShowType()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        bool cVar2;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          if (!cVar2) {
            QuickTravelUIController.ShowQuickTravelUI(this,0,0x3f800000,0,0);
            return;
          }
          QuickTravelUIController.ShowQuickTravelUI(this,2,0x3f800000,0,0);
          return;
        }
    }

    // Token : 0x6001FC3
    // RVA   : 0xC55970   Offset: 0xC54170   Length: 0x22
    public void ShowQuickTravelUI(QuickTravelUIType targetTravelUIType)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        void QuickTravelUIController.ShowQuickTravelUI
                     (int64 this,uint32 targetTravelUIType,int64 param_3,uint8 param_4)
        {
        char cVar1;
        uint32 uVar2;
        int iVar3;
        int64 *plVar4;
        int64 lVar5;
        int64 *plVar6;
        uint64 *puVar7;
        uint64 uVar8;
        int64 lVar9;
        int64 lVar10;
        int64 lVar11;
        uint8 *puVar12;
        uint32 *puVar13;
        int64 *plVar14;
        float fVar15;
        uint32 uVar16;
        uint32 uVar17;
        uint32 uVar18;
        uint64 local_288;
        uint64 uStack_280;
        uint64 local_278;
        float local_270;
        int64 local_268;
        float local_260;
        uint64 local_258;
        uint64 uStack_250;
        int64 local_248;
        int64 local_240;
        float local_238;
        uint32 local_230;
        uint32 uStack_22c;
        uint32 uStack_228;
        uint32 uStack_224;
        int64 local_220;
        int64 local_218 [4];
        int64 local_1f8 [2];
        uint8 local_1e8 [16];
        uint8 local_1d8 [16];
        uint8 local_1c8 [16];
        uint8 local_1b8 [16];
        uint8 local_1a8 [16];
        uint8 local_198 [16];
        uint8 local_188 [16];
        uint8 local_178 [16];
        uint8 local_168 [16];
        uint8 local_158 [16];
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint32 local_78 [4];
        uint8 local_68 [16];
        uint8 local_58 [48];
        local_218[0] = this;
        local_258 = 0;
        uStack_250 = 0;
        local_248 = 0;
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar14 = (int64 *)0;
        plVar6 = plVar14;
        if ((plVar4 != (int64 *)0) && (plVar6 = (int64 *)0, *plVar4 == DAT_181d8a228)) {
          plVar6 = plVar4;
        }
        NGUITools.PlaySound(plVar6,0);
        if (this.quickTravelUI == null) {
        LAB_180c55938:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.quickTravelUI,1,0);
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"BlackBackground",0)) == null) goto LAB_180c55938;
        plVar4 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           ((lVar5 = Transform.Find(lVar5,"BlackBackground",0), lVar5 == null ||
            (plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40), plVar6 == (int64 *)0)
            ))) goto LAB_180c55938;
        puVar7 = (uint64 *)
                 (**(code **)(*plVar6 + 0x298))(&local_288,plVar6,*(uint64 *)(*plVar6 + 0x2a0));
        local_288 = *puVar7;
        uStack_280 = puVar7[1];
        puVar7 = (uint64 *)GlobalData.SetColorAlpha(&local_278,&local_288,0,0);
        if (plVar4 == (int64 *)0) goto LAB_180c55938;
        local_288 = *puVar7;
        uStack_280 = puVar7[1];
        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288,*(uint64 *)(*plVar4 + 0x2b0));
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"BlackBackground",0)) == null) goto LAB_180c55938;
        uVar8 = Component.GetComponent(lVar5,DAT_181d6bc40);
        uVar8 = DOTweenModuleUI.DOFade(uVar8,0x3f000000,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98958);
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"MapRoot",0)) == null) goto LAB_180c55938;
        local_278 = param_3 << 32;
        local_270 = (float)param_3;
        Transform.set_localScale(lVar5,&local_278,0);
        if ((this.quickTravelUI == null) ||
           (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null)
        goto LAB_180c55938;
        uVar8 = Transform.Find(lVar5,"MapRoot",0);
        uVar8 = ShortcutExtensions.DOScaleX(uVar8,param_3,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98af0);
        this.quickTravelUIType = targetTravelUIType;
        if (this.playerIcon == null) goto LAB_180c55938;
        lVar5 = GameObject.get_transform(this.playerIcon,0);
        fVar15 = this.BaseMapScale;
        if ((((*pStatics_df90 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar9 = WorldData.Player(lVar9,0)) == null) || (*(int64 *)(lVar9 + 200) == 0))
        goto LAB_180c55938;
        plVar4 = (int64 *)BigMapPos.ToVector3(&local_288,*(int64 *)(lVar9 + 200),0x3f800000,0);
        local_240 = *plVar4;
        local_238 = *(float *)(plVar4 + 1);
        local_278 = CONCAT44((float)((uint64)local_240 >> 32) * fVar15,(float)local_240 * fVar15);
        local_270 = local_238 * fVar15;
        local_268 = local_240;
        local_260 = local_238;
        if (lVar5 == null) goto LAB_180c55938;
        local_268 = local_278;
        local_260 = local_270;
        Transform.set_localPosition(lVar5,&local_268,0);
        this.autoClose = param_4;
        lVar5 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar5,DAT_181d678f8);
        local_268 = lVar5;
        lVar9 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar9,DAT_181d678f8);
        local_278 = lVar9;
        if (this.quickTravelUIType == 3) {
          if (((*pStatics_df90 == 0) ||
              (lVar11 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar11 = *(int64 *)(lVar11 + 48)) == null) goto LAB_180c55938;
          FUN_1817ff240(&local_230,lVar11,DAT_181d550e0);
          local_258 = CONCAT44(uStack_22c,local_230);
          uStack_250 = CONCAT44(uStack_224,uStack_228);
          local_248 = local_220;
          while (cVar1 = FUN_180d197a0(&local_258,DAT_181d639c8), lVar11 = local_248, cVar1) {
            if (local_248 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = AreaData.BelongPlayerOrAlley(local_248,0);
            if (cVar1) {
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_181814fa0(lVar9,*(uint32 *)(lVar11 + 16),DAT_181d67a78);
            }
          }
          ZhSegment.Initialize(&local_258,DAT_181d63948);
          if (((*pStatics_df90 == 0) ||
              (lVar11 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar11 = *(int64 *)(lVar11 + 48)) == null) goto LAB_180c55938;
          FUN_1817ff240(&local_230,lVar11,DAT_181d550e0);
          local_258 = CONCAT44(uStack_22c,local_230);
          uStack_250 = CONCAT44(uStack_224,uStack_228);
          local_248 = local_220;
        LAB_180c52f70:
          cVar1 = FUN_180d197a0(&local_258,DAT_181d639c8);
          lVar11 = local_248;
          if (cVar1) {
            lVar10 = FUN_18046c0a0(0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar10 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar10 = HeroData.GetForce(lVar10,0);
            if (lVar11 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = ForceData.CanAttack(lVar10,*(uint32 *)(lVar11 + 112));
            plVar4 = plVar14;
            if (cVar1) {
              while( true ) {
                lVar10 = *(int64 *)(lVar11 + 152);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int *)(lVar10 + 24) <= (int)plVar4) goto LAB_180c52f70;
                uVar2 = FUN_1800d6750(lVar10,plVar4,DAT_181d68270);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = FUN_181815240(lVar9,uVar2);
                if (cVar1) break;
                plVar4 = (int64 *)(uint64)((int)plVar4 + 1);
              }
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_181814fa0(lVar5,*(uint32 *)(lVar11 + 16));
            }
            goto LAB_180c52f70;
          }
          ZhSegment.Initialize(&local_258,DAT_181d63948);
        }
        lVar11 = this.areaIcons;
        joined_r0x000180c530e5:
        if ((lVar11 == null) || (lVar11 = GameObject.get_transform(lVar11,0)) == null)
        goto LAB_180c55932;
        iVar3 = Transform.get_childCount(lVar11,0);
        if (iVar3 <= (int)plVar14) {
          QuickTravelUIController.RefreshAllAreaState(this,0);
          QuickTravelUIController.RefreshAllResourceState(this,0);
          QuickTravelUIController.RefreshAllInnState(this,0);
          return;
        }
        if (((this.areaIcons == null) ||
            (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
           (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
        uVar8 = Component.GetComponent(lVar11,DAT_181d6c540);
        cVar1 = Object.op_Inequality(uVar8,0);
        if (cVar1) {
          lVar11 = FUN_18046c0a0(0);
          if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
             (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
          goto LAB_180c55938;
          if (*(int *)(lVar11 + 132) < 0) {
        LAB_180c54773:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55938;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar12 = local_58;
        LAB_180c547d8:
            puVar7 = (uint64 *)FUN_180d904c0(puVar12,0);
        LAB_180c547e2:
            if (plVar4 == (int64 *)0) goto LAB_180c55938;
            local_288 = *puVar7;
            uStack_280 = puVar7[1];
            (**(code **)(*plVar4 + 0x2a8))(plVar4);
          }
          else {
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 112) < 0) goto LAB_180c54773;
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
            lVar11 = FUN_18046c0a0(0);
            if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
               (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
            goto LAB_180c55938;
            if (iVar3 != *(int *)(lVar11 + 132)) {
              if ((((this.areaIcons != null) &&
                   (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                  ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                   ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                    (*(int64 *)(lVar11 + 24) != 0)))))) &&
                 (lVar11 = AreaData.GetForce(*(int64 *)(lVar11 + 24),0)) != null) {
                iVar3 = *(int *)(lVar11 + 60);
                lVar11 = FUN_18046c0a0(0);
                if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                   (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                  if (iVar3 == *(int *)(lVar11 + 132)) goto LAB_180c546d2;
                  lVar11 = FUN_18046c0a0(0);
                  if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                     (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                    lVar11 = HeroData.GetForce(lVar11,0,0);
                    if (((((this.areaIcons != null) &&
                          (lVar10 = GameObject.get_transform(this.areaIcons,0),
                          lVar10 != null)) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null)
                        && ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c540), lVar10 != null &&
                            (*(int64 *)(lVar10 + 24) != 0)))) && (lVar11 != null)) {
                      fVar15 = (float)ForceData.GetForceFavor
                                                (lVar11,*(uint32 *)
                                                         (*(int64 *)(lVar10 + 24) + 112),0);
                      if (80.0 <= fVar15) {
                        if (((this.areaIcons != null) &&
                            (lVar11 = GameObject.get_transform(this.areaIcons,0),
                            lVar11 != null)) &&
                           ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                            (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                          puVar7 = (uint64 *)Color.get_blue(local_158,0);
                          goto LAB_180c547e2;
                        }
                      }
                      else {
                        lVar11 = FUN_18046c0a0(0);
                        if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                           (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                          lVar11 = HeroData.GetForce(lVar11,0,0);
                          if ((((this.areaIcons != null) &&
                               (lVar10 = GameObject.get_transform(this.areaIcons,0),
                               lVar10 != null)) &&
                              ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                               ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c540), lVar10 != null &&
                                (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar11 != null)) {
                            fVar15 = (float)ForceData.GetForceFavor
                                                      (lVar11,*(uint32 *)
                                                               (*(int64 *)(lVar10 + 24) + 112),0);
                            lVar11 = this.areaIcons;
                            if (fVar15 < 40.0) {
                              if ((((lVar11 != null) &&
                                   (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                  (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) &&
                                 (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null) {
                                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                                lVar11 = pStatics_ef00;
                                if (plVar4 != (int64 *)0) {
                                  uVar2 = *(uint32 *)(lVar11 + 0x2e8);
                                  uVar16 = *(uint32 *)(lVar11 + 0x2ec);
                                  uVar17 = *(uint32 *)(lVar11 + 0x2f0);
                                  uVar18 = *(uint32 *)(lVar11 + 0x2f4);
                                  goto LAB_180c5463c;
                                }
                              }
                            }
                            else if (((lVar11 != null) &&
                                     (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                    ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                                     (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                              puVar12 = local_168;
                              goto LAB_180c547d8;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_180c55938;
            }
        LAB_180c546d2:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55938;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            lVar11 = pStatics_ef00;
            if (plVar4 == (int64 *)0) goto LAB_180c55938;
            uVar2 = *(uint32 *)(lVar11 + 0x280);
            uVar16 = *(uint32 *)(lVar11 + 0x284);
            uVar17 = *(uint32 *)(lVar11 + 0x288);
            uVar18 = *(uint32 *)(lVar11 + 0x28c);
        LAB_180c5463c:
            local_288 = CONCAT44(uVar16,uVar2);
            uStack_280 = CONCAT44(uVar18,uVar17);
            (**(code **)(*plVar4 + 0x2a8))(plVar4);
          }
          switch(this.quickTravelUIType) {
          case 0:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               (lVar11 = Component.GetComponent(lVar11,DAT_181d6c540)) == null) goto LAB_180c55938;
            *(uint32 *)(lVar11 + 32) = 0;
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            lVar10 = this.areaIcons;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 112) == -1) {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar12 = local_138;
        LAB_180c549d2:
              puVar7 = (uint64 *)FUN_181098a50(puVar12,0);
            }
            else {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              if (((this.areaIcons == null) ||
                  (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                  ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                   (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
              puVar7 = (uint64 *)AreaData.GetForceColor(local_148,*(int64 *)(lVar11 + 24),0);
            }
            break;
          case 1:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55938;
            lVar10 = this.areaIcons;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 72) == 0) {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                  ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                   (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
              iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 16);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
              goto LAB_180c55938;
              lVar10 = this.areaIcons;
              if (iVar3 != *(int *)(lVar11 + 192)) {
                if (((lVar10 != null) && (lVar11 = GameObject.get_transform(lVar10,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar7 = (uint64 *)Color.get_green(local_118,0);
                  if (plVar4 != (int64 *)0) {
                    local_288 = *puVar7;
                    uStack_280 = puVar7[1];
                    (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                    if (((this.areaIcons != null) &&
                        (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                              (lVar11 = Component.GetComponent(lVar11)) != null))) {
                      *(uint32 *)(lVar11 + 32) = 1;
                      goto switchD_180c53add_default;
                    }
                  }
                }
                goto LAB_180c55938;
              }
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar7 = (uint64 *)Color.get_red(local_108,0);
            }
            else {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar12 = local_128;
        LAB_180c54ab7:
              puVar7 = (uint64 *)FUN_1810988d0(puVar12,0);
            }
        LAB_180c54ac1:
            if (plVar4 != (int64 *)0) {
              local_288 = *puVar7;
              uStack_280 = puVar7[1];
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
              if (((this.areaIcons != null) &&
                  (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                 ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                  (lVar11 = Component.GetComponent(lVar11)) != null))) goto LAB_180c5588e;
            }
            goto LAB_180c55938;
          case 2:
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                (lVar11 = Component.GetComponent(lVar11,DAT_181d6c540)) == null)))
            goto LAB_180c55938;
            *(uint32 *)(lVar11 + 32) = 2;
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55938;
            lVar10 = this.areaIcons;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 112) == -1) {
              if (((lVar10 != null) && (lVar11 = GameObject.get_transform(lVar10,0)) != null) &&
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar12 = local_e8;
                goto LAB_180c549d2;
              }
              goto LAB_180c55938;
            }
            if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            puVar7 = (uint64 *)AreaData.GetForceColor(local_f8,*(int64 *)(lVar11 + 24),0);
            break;
          case 3:
            QuickTravelUIController.SetRoadsActive(this,0x180000001,0);
            if (((this.areaIcons != null) &&
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                 (*(int64 *)(lVar11 + 24) != 0)))))) {
              iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
              lVar11 = FUN_18046c0a0(0);
              if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                  (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                 (lVar11 = HeroData.GetForce(lVar11,0,0)) == null) goto LAB_180c55938;
              if (iVar3 == *(int *)(lVar11 + 16)) {
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar7 = (uint64 *)Color.get_green(local_d8,0);
                  if (plVar4 != (int64 *)0) goto LAB_180c55822;
                }
                goto LAB_180c55938;
              }
              lVar11 = FUN_18046c3a0(0);
              if (lVar11 == null) goto LAB_180c55938;
              if (*(int *)(lVar11 + 32) == 0) {
        LAB_180c55196:
                if (((this.areaIcons == null) ||
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                   ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                    (((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                      (*(int64 *)(lVar11 + 24) == 0)) || (lVar5 == null)))))) goto LAB_180c55938;
                cVar1 = FUN_181815240(lVar5,*(uint32 *)(*(int64 *)(lVar11 + 24) + 16),
                                      DAT_181d67bf8);
                lVar11 = this.areaIcons;
                if (!cVar1) {
                  if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                     (((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                       ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                        (*(int64 *)(lVar11 + 24) != 0)))) && (lVar9 != null)))) {
                    cVar1 = FUN_181815240(lVar9,*(uint32 *)(*(int64 *)(lVar11 + 24) + 16),
                                          DAT_181d67bf8);
                    lVar11 = this.areaIcons;
                    if (!cVar1) {
                      if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null)
                         && (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                        plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                        puVar12 = local_b8;
                        goto LAB_180c54ab7;
                      }
                    }
                    else if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null
                             ) && (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                      plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                      puVar7 = (uint64 *)Color.get_blue(local_a8,0);
                      goto LAB_180c54ac1;
                    }
                  }
                  goto LAB_180c55938;
                }
                if (((lVar11 == null) || (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar7 = (uint64 *)Color.get_yellow(local_98,0);
              }
              else {
                if ((((this.areaIcons == null) ||
                     (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
                    || (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
                   ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                    (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55938;
                iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 16);
                lVar11 = FUN_18046c3a0(0);
                if (lVar11 == null) goto LAB_180c55938;
                if (iVar3 != *(int *)(lVar11 + 192)) goto LAB_180c55196;
                if (((this.areaIcons == null) ||
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar7 = (uint64 *)Color.get_red(local_c8,0);
              }
              if (plVar4 != (int64 *)0) {
                local_288 = *puVar7;
                uStack_280 = puVar7[1];
                (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                    (lVar11 = Component.GetComponent(lVar11)) != null))) {
                  *(uint32 *)(lVar11 + 32) = 3;
                  goto switchD_180c53add_default;
                }
              }
            }
            goto LAB_180c55938;
          case 4:
            if ((((this.areaIcons != null) &&
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) &&
               ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                (*(int64 *)(lVar11 + 24) != 0)))) {
              iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                 ((lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0), lVar11 != null &&
                  (lVar11 = HeroData.GetForce(lVar11,0,0)) != null))) {
                if (iVar3 == *(int *)(lVar11 + 16)) {
                  if ((((this.areaIcons == null) ||
                       (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
                      || (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
                     ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                      (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55932;
                  if (*(int *)(*(int64 *)(lVar11 + 24) + 72) != 2) {
                    if (((this.areaIcons != null) &&
                        (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                      plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                      puVar7 = (uint64 *)Color.get_green(local_88,0);
                      if (plVar4 != (int64 *)0) {
                        local_288 = *puVar7;
                        uStack_280 = puVar7[1];
                        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                        if ((((this.areaIcons != null) &&
                             (lVar11 = GameObject.get_transform(this.areaIcons,0),
                             lVar11 != null)) && (lVar11 = Transform.GetChild(lVar11,plVar14)) != null)
                           && (lVar11 = Component.GetComponent(lVar11)) != null) {
                          *(uint32 *)(lVar11 + 32) = 4;
                          goto switchD_180c53add_default;
                        }
                      }
                    }
                    goto LAB_180c55932;
                  }
                }
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar13 = local_78;
                  goto LAB_180c5580f;
                }
              }
            }
            goto LAB_180c55932;
          case 5:
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) {
        LAB_180c55932:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
            lVar11 = FUN_18046c0a0(0);
            if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
               (lVar11 = HeroData.GetForce(lVar11,0,0)) == null) goto LAB_180c55932;
            if (iVar3 != *(int *)(lVar11 + 16)) {
              if (((this.areaIcons == null) ||
                  (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                  ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                   (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
              if (*(int *)(*(int64 *)(lVar11 + 24) + 72) != 2) {
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar7 = (uint64 *)Color.get_green(local_68,0);
                  if (plVar4 != (int64 *)0) {
                    local_288 = *puVar7;
                    uStack_280 = puVar7[1];
                    (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                    if (((this.areaIcons != null) &&
                        (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                              (lVar11 = Component.GetComponent(lVar11)) != null))) {
                      *(uint32 *)(lVar11 + 32) = 5;
                      goto switchD_180c53add_default;
                    }
                  }
                }
                goto LAB_180c55932;
              }
            }
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar13 = &local_230;
        LAB_180c5580f:
            puVar7 = (uint64 *)FUN_1810988d0(puVar13,0);
            if (plVar4 == (int64 *)0) goto LAB_180c55932;
        LAB_180c55822:
            local_288 = *puVar7;
            uStack_280 = puVar7[1];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
            if ((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
            goto LAB_180c55932;
            lVar11 = Transform.GetChild(lVar11,plVar14);
            goto joined_r0x000180c5409b;
          default:
            goto switchD_180c53add_default;
          }
          if (plVar4 == (int64 *)0) goto LAB_180c55938;
        LAB_180c549e5:
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4);
        switchD_180c53add_default:
          plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
          lVar11 = this.areaIcons;
          goto joined_r0x000180c530e5;
        }
        if (((this.areaIcons == null) ||
            (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
           (lVar11 = Transform.GetChild(lVar11,plVar14)) == null) goto LAB_180c55932;
        uVar8 = Component.GetComponent(lVar11,DAT_181d6c640);
        cVar1 = Object.op_Inequality(uVar8,0);
        if (!cVar1) {
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14)) == null) goto LAB_180c55932;
          uVar8 = Component.GetComponent(lVar11);
          cVar1 = Object.op_Inequality(uVar8);
          if (cVar1) {
            lVar11 = this.areaIcons;
            if (this.quickTravelUIType == 2) {
              if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar7 = (uint64 *)FUN_181098a50(&local_278,0);
                if (plVar4 != (int64 *)0) {
                  local_288 = *puVar7;
                  uStack_280 = puVar7[1];
                  (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                  if (((this.areaIcons != null) &&
                      (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null)
                     && ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                         (lVar11 = Component.GetComponent(lVar11)) != null))) {
                    *(uint32 *)(lVar11 + 32) = 2;
                    goto switchD_180c53add_default;
                  }
                }
              }
            }
            else if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                    (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar7 = (uint64 *)FUN_1810988d0(local_218,0);
              if (plVar4 != (int64 *)0) {
                local_288 = *puVar7;
                uStack_280 = puVar7[1];
                (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                if ((this.areaIcons != null) &&
                   (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) {
                  lVar11 = Transform.GetChild(lVar11,plVar14);
                  goto joined_r0x000180c5409b;
                }
              }
            }
            goto LAB_180c55932;
          }
          goto switchD_180c53add_default;
        }
        lVar11 = FUN_18046c0a0(0);
        if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
           (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) goto LAB_180c55932;
        if (*(int *)(lVar11 + 132) < 0) {
        LAB_180c53a26:
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55932;
          plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          plVar4 = local_1f8;
        LAB_180c53a8b:
          puVar7 = (uint64 *)FUN_180d904c0(plVar4,0);
        LAB_180c53a95:
          if (plVar6 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar6 + 0x2a8))(plVar6);
        }
        else {
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
               (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
          if (*(int *)(*(int64 *)(lVar11 + 24) + 56) < 0) goto LAB_180c53a26;
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
               (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
          iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 56);
          lVar11 = FUN_18046c0a0(0);
          if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
             (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
          goto LAB_180c55932;
          if (iVar3 != *(int *)(lVar11 + 132)) {
            if ((((this.areaIcons != null) &&
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                 ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 != null &&
                  (*(int64 *)(lVar11 + 24) != 0)))))) &&
               (lVar11 = ResourcePointData.GetForce(*(int64 *)(lVar11 + 24),0)) != null) {
              iVar3 = *(int *)(lVar11 + 60);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                if (iVar3 == *(int *)(lVar11 + 132)) goto LAB_180c53985;
                lVar11 = FUN_18046c0a0(0);
                if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                   (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                  lVar11 = HeroData.GetForce(lVar11,0,0);
                  if (((((this.areaIcons != null) &&
                        (lVar10 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null) &&
                      ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c640), lVar10 != null &&
                       (*(int64 *)(lVar10 + 24) != 0)))) && (lVar11 != null)) {
                    fVar15 = (float)ForceData.GetForceFavor
                                              (lVar11,*(uint32 *)(*(int64 *)(lVar10 + 24) + 56)
                                               ,0);
                    if (80.0 <= fVar15) {
                      if (((this.areaIcons != null) &&
                          (lVar11 = GameObject.get_transform(this.areaIcons,0),
                          lVar11 != null)) &&
                         ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                          (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                        plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                        puVar7 = (uint64 *)Color.get_blue(&local_240,0);
                        goto LAB_180c53a95;
                      }
                    }
                    else {
                      lVar11 = FUN_18046c0a0(0);
                      if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                         (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                        lVar11 = HeroData.GetForce(lVar11,0,0);
                        if ((((this.areaIcons != null) &&
                             (lVar10 = GameObject.get_transform(this.areaIcons,0),
                             lVar10 != null)) &&
                            ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                             ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c640), lVar10 != null &&
                              (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar11 != null)) {
                          fVar15 = (float)ForceData.GetForceFavor
                                                    (lVar11,*(uint32 *)
                                                             (*(int64 *)(lVar10 + 24) + 56),0);
                          lVar11 = this.areaIcons;
                          if (fVar15 < 40.0) {
                            if ((((lVar11 != null) &&
                                 (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) &&
                               (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null) {
                              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                              lVar11 = pStatics_ef00;
                              if (plVar4 != (int64 *)0) {
                                uVar2 = *(uint32 *)(lVar11 + 0x2e8);
                                uVar16 = *(uint32 *)(lVar11 + 0x2ec);
                                uVar17 = *(uint32 *)(lVar11 + 0x2f0);
                                uVar18 = *(uint32 *)(lVar11 + 0x2f4);
                                goto LAB_180c538f2;
                              }
                            }
                          }
                          else if (((lVar11 != null) &&
                                   (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                  ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                                   (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                            plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                            plVar4 = &local_268;
                            goto LAB_180c53a8b;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180c55932;
          }
        LAB_180c53985:
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          lVar11 = pStatics_ef00;
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          uVar2 = *(uint32 *)(lVar11 + 0x280);
          uVar16 = *(uint32 *)(lVar11 + 0x284);
          uVar17 = *(uint32 *)(lVar11 + 0x288);
          uVar18 = *(uint32 *)(lVar11 + 0x28c);
        LAB_180c538f2:
          local_288 = CONCAT44(uVar16,uVar2);
          uStack_280 = CONCAT44(uVar18,uVar17);
          (**(code **)(*plVar4 + 0x2a8))(plVar4);
        }
        switch(this.quickTravelUIType) {
        case 0:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              (lVar11 = Component.GetComponent(lVar11,DAT_181d6c640)) == null))) goto LAB_180c55932;
          *(uint32 *)(lVar11 + 32) = 0;
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
              (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55932;
          lVar10 = this.areaIcons;
          if (*(int *)(*(int64 *)(lVar11 + 24) + 56) == -1) {
            if (((lVar10 != null) && (lVar11 = GameObject.get_transform(lVar10,0)) != null) &&
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar7 = (uint64 *)FUN_181098a50(local_1d8,0);
              goto joined_r0x000180c53c40;
            }
            goto LAB_180c55932;
          }
          if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
              (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55932;
          puVar7 = (uint64 *)
                   ResourcePointData.GetForceColor(local_1e8,*(int64 *)(lVar11 + 24),0);
          goto joined_r0x000180c53c40;
        case 1:
          if (((this.areaIcons != null) &&
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar7 = (uint64 *)FUN_1810988d0(local_1c8,0);
            if (plVar4 != (int64 *)0) {
              local_288 = *puVar7;
              uStack_280 = puVar7[1];
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
              if ((this.areaIcons != null) &&
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) {
                lVar11 = Transform.GetChild(lVar11,plVar14);
                break;
              }
            }
          }
          goto LAB_180c55932;
        case 2:
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             (lVar11 = Component.GetComponent(lVar11,DAT_181d6c640)) == null) goto LAB_180c55932;
          *(uint32 *)(lVar11 + 32) = 2;
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
               (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
          lVar10 = this.areaIcons;
          if (*(int *)(*(int64 *)(lVar11 + 24) + 56) == -1) {
            if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar7 = (uint64 *)FUN_181098a50(local_1a8,0);
          }
          else {
            if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
            puVar7 = (uint64 *)
                     ResourcePointData.GetForceColor(local_1b8,*(int64 *)(lVar11 + 24),0);
          }
        joined_r0x000180c53c40:
          if (plVar4 != (int64 *)0) goto LAB_180c549e5;
          goto LAB_180c55932;
        case 3:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          puVar7 = (uint64 *)FUN_1810988d0(local_198,0);
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
          if ((this.areaIcons == null) ||
             (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180c55932;
          lVar11 = Transform.GetChild(lVar11,plVar14);
          break;
        case 4:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          puVar7 = (uint64 *)FUN_1810988d0(local_188,0);
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
          if ((this.areaIcons == null) ||
             (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180c55932;
          lVar11 = Transform.GetChild(lVar11,plVar14);
          break;
        case 5:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          puVar7 = (uint64 *)FUN_1810988d0(local_178,0);
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
          if ((this.areaIcons == null) ||
             (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180c55932;
          lVar11 = Transform.GetChild(lVar11,plVar14);
          break;
        default:
          goto switchD_180c53add_default;
        }
        joined_r0x000180c5409b:
        if ((lVar11 != null) && (lVar11 = Component.GetComponent(lVar11)) != null) {
        LAB_180c5588e:
          *(uint32 *)(lVar11 + 32) = 0;
          goto switchD_180c53add_default;
        }
        goto LAB_180c55932;
    }

    // Token : 0x6001FC4
    // RVA   : 0xC52750   Offset: 0xC50F50   Length: 0x31F0
    public void ShowQuickTravelUI(QuickTravelUIType targetTravelUIType, float scale, bool _autoClose)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        void QuickTravelUIController.ShowQuickTravelUI
                     (int64 this,uint32 targetTravelUIType,int64 scale,uint8 _autoClose)
        {
        char cVar1;
        uint32 uVar2;
        int iVar3;
        int64 *plVar4;
        int64 lVar5;
        int64 *plVar6;
        uint64 *puVar7;
        uint64 uVar8;
        int64 lVar9;
        int64 lVar10;
        int64 lVar11;
        uint8 *puVar12;
        uint32 *puVar13;
        int64 *plVar14;
        float fVar15;
        uint32 uVar16;
        uint32 uVar17;
        uint32 uVar18;
        uint64 local_288;
        uint64 uStack_280;
        uint64 local_278;
        float local_270;
        int64 local_268;
        float local_260;
        uint64 local_258;
        uint64 uStack_250;
        int64 local_248;
        int64 local_240;
        float local_238;
        uint32 local_230;
        uint32 uStack_22c;
        uint32 uStack_228;
        uint32 uStack_224;
        int64 local_220;
        int64 local_218 [4];
        int64 local_1f8 [2];
        uint8 local_1e8 [16];
        uint8 local_1d8 [16];
        uint8 local_1c8 [16];
        uint8 local_1b8 [16];
        uint8 local_1a8 [16];
        uint8 local_198 [16];
        uint8 local_188 [16];
        uint8 local_178 [16];
        uint8 local_168 [16];
        uint8 local_158 [16];
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint32 local_78 [4];
        uint8 local_68 [16];
        uint8 local_58 [48];
        local_218[0] = this;
        local_258 = 0;
        uStack_250 = 0;
        local_248 = 0;
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar14 = (int64 *)0;
        plVar6 = plVar14;
        if ((plVar4 != (int64 *)0) && (plVar6 = (int64 *)0, *plVar4 == DAT_181d8a228)) {
          plVar6 = plVar4;
        }
        NGUITools.PlaySound(plVar6,0);
        if (this.quickTravelUI == null) {
        LAB_180c55938:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.quickTravelUI,1,0);
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"BlackBackground",0)) == null) goto LAB_180c55938;
        plVar4 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           ((lVar5 = Transform.Find(lVar5,"BlackBackground",0), lVar5 == null ||
            (plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40), plVar6 == (int64 *)0)
            ))) goto LAB_180c55938;
        puVar7 = (uint64 *)
                 (**(code **)(*plVar6 + 0x298))(&local_288,plVar6,*(uint64 *)(*plVar6 + 0x2a0));
        local_288 = *puVar7;
        uStack_280 = puVar7[1];
        puVar7 = (uint64 *)GlobalData.SetColorAlpha(&local_278,&local_288,0,0);
        if (plVar4 == (int64 *)0) goto LAB_180c55938;
        local_288 = *puVar7;
        uStack_280 = puVar7[1];
        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288,*(uint64 *)(*plVar4 + 0x2b0));
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"BlackBackground",0)) == null) goto LAB_180c55938;
        uVar8 = Component.GetComponent(lVar5,DAT_181d6bc40);
        uVar8 = DOTweenModuleUI.DOFade(uVar8,0x3f000000,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98958);
        if (((this.quickTravelUI == null) ||
            (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null) ||
           (lVar5 = Transform.Find(lVar5,"MapRoot",0)) == null) goto LAB_180c55938;
        local_278 = scale << 32;
        local_270 = (float)scale;
        Transform.set_localScale(lVar5,&local_278,0);
        if ((this.quickTravelUI == null) ||
           (lVar5 = GameObject.get_transform(this.quickTravelUI,0)) == null)
        goto LAB_180c55938;
        uVar8 = Transform.Find(lVar5,"MapRoot",0);
        uVar8 = ShortcutExtensions.DOScaleX(uVar8,scale,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98af0);
        this.quickTravelUIType = targetTravelUIType;
        if (this.playerIcon == null) goto LAB_180c55938;
        lVar5 = GameObject.get_transform(this.playerIcon,0);
        fVar15 = this.BaseMapScale;
        if ((((*pStatics_df90 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar9 = WorldData.Player(lVar9,0)) == null) || (*(int64 *)(lVar9 + 200) == 0))
        goto LAB_180c55938;
        plVar4 = (int64 *)BigMapPos.ToVector3(&local_288,*(int64 *)(lVar9 + 200),0x3f800000,0);
        local_240 = *plVar4;
        local_238 = *(float *)(plVar4 + 1);
        local_278 = CONCAT44((float)((uint64)local_240 >> 32) * fVar15,(float)local_240 * fVar15);
        local_270 = local_238 * fVar15;
        local_268 = local_240;
        local_260 = local_238;
        if (lVar5 == null) goto LAB_180c55938;
        local_268 = local_278;
        local_260 = local_270;
        Transform.set_localPosition(lVar5,&local_268,0);
        this.autoClose = _autoClose;
        lVar5 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar5,DAT_181d678f8);
        local_268 = lVar5;
        lVar9 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar9,DAT_181d678f8);
        local_278 = lVar9;
        if (this.quickTravelUIType == 3) {
          if (((*pStatics_df90 == 0) ||
              (lVar11 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar11 = *(int64 *)(lVar11 + 48)) == null) goto LAB_180c55938;
          FUN_1817ff240(&local_230,lVar11,DAT_181d550e0);
          local_258 = CONCAT44(uStack_22c,local_230);
          uStack_250 = CONCAT44(uStack_224,uStack_228);
          local_248 = local_220;
          while (cVar1 = FUN_180d197a0(&local_258,DAT_181d639c8), lVar11 = local_248, cVar1) {
            if (local_248 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = AreaData.BelongPlayerOrAlley(local_248,0);
            if (cVar1) {
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_181814fa0(lVar9,*(uint32 *)(lVar11 + 16),DAT_181d67a78);
            }
          }
          ZhSegment.Initialize(&local_258,DAT_181d63948);
          if (((*pStatics_df90 == 0) ||
              (lVar11 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar11 = *(int64 *)(lVar11 + 48)) == null) goto LAB_180c55938;
          FUN_1817ff240(&local_230,lVar11,DAT_181d550e0);
          local_258 = CONCAT44(uStack_22c,local_230);
          uStack_250 = CONCAT44(uStack_224,uStack_228);
          local_248 = local_220;
        LAB_180c52f70:
          cVar1 = FUN_180d197a0(&local_258,DAT_181d639c8);
          lVar11 = local_248;
          if (cVar1) {
            lVar10 = FUN_18046c0a0(0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(lVar10 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar10 = HeroData.GetForce(lVar10,0);
            if (lVar11 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = ForceData.CanAttack(lVar10,*(uint32 *)(lVar11 + 112));
            plVar4 = plVar14;
            if (cVar1) {
              while( true ) {
                lVar10 = *(int64 *)(lVar11 + 152);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int *)(lVar10 + 24) <= (int)plVar4) goto LAB_180c52f70;
                uVar2 = FUN_1800d6750(lVar10,plVar4,DAT_181d68270);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = FUN_181815240(lVar9,uVar2);
                if (cVar1) break;
                plVar4 = (int64 *)(uint64)((int)plVar4 + 1);
              }
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_181814fa0(lVar5,*(uint32 *)(lVar11 + 16));
            }
            goto LAB_180c52f70;
          }
          ZhSegment.Initialize(&local_258,DAT_181d63948);
        }
        lVar11 = this.areaIcons;
        joined_r0x000180c530e5:
        if ((lVar11 == null) || (lVar11 = GameObject.get_transform(lVar11,0)) == null)
        goto LAB_180c55932;
        iVar3 = Transform.get_childCount(lVar11,0);
        if (iVar3 <= (int)plVar14) {
          QuickTravelUIController.RefreshAllAreaState(this,0);
          QuickTravelUIController.RefreshAllResourceState(this,0);
          QuickTravelUIController.RefreshAllInnState(this,0);
          return;
        }
        if (((this.areaIcons == null) ||
            (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
           (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
        uVar8 = Component.GetComponent(lVar11,DAT_181d6c540);
        cVar1 = Object.op_Inequality(uVar8,0);
        if (cVar1) {
          lVar11 = FUN_18046c0a0(0);
          if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
             (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
          goto LAB_180c55938;
          if (*(int *)(lVar11 + 132) < 0) {
        LAB_180c54773:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55938;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar12 = local_58;
        LAB_180c547d8:
            puVar7 = (uint64 *)FUN_180d904c0(puVar12,0);
        LAB_180c547e2:
            if (plVar4 == (int64 *)0) goto LAB_180c55938;
            local_288 = *puVar7;
            uStack_280 = puVar7[1];
            (**(code **)(*plVar4 + 0x2a8))(plVar4);
          }
          else {
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 112) < 0) goto LAB_180c54773;
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
            lVar11 = FUN_18046c0a0(0);
            if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
               (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
            goto LAB_180c55938;
            if (iVar3 != *(int *)(lVar11 + 132)) {
              if ((((this.areaIcons != null) &&
                   (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                  ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                   ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                    (*(int64 *)(lVar11 + 24) != 0)))))) &&
                 (lVar11 = AreaData.GetForce(*(int64 *)(lVar11 + 24),0)) != null) {
                iVar3 = *(int *)(lVar11 + 60);
                lVar11 = FUN_18046c0a0(0);
                if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                   (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                  if (iVar3 == *(int *)(lVar11 + 132)) goto LAB_180c546d2;
                  lVar11 = FUN_18046c0a0(0);
                  if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                     (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                    lVar11 = HeroData.GetForce(lVar11,0,0);
                    if (((((this.areaIcons != null) &&
                          (lVar10 = GameObject.get_transform(this.areaIcons,0),
                          lVar10 != null)) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null)
                        && ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c540), lVar10 != null &&
                            (*(int64 *)(lVar10 + 24) != 0)))) && (lVar11 != null)) {
                      fVar15 = (float)ForceData.GetForceFavor
                                                (lVar11,*(uint32 *)
                                                         (*(int64 *)(lVar10 + 24) + 112),0);
                      if (80.0 <= fVar15) {
                        if (((this.areaIcons != null) &&
                            (lVar11 = GameObject.get_transform(this.areaIcons,0),
                            lVar11 != null)) &&
                           ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                            (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                          puVar7 = (uint64 *)Color.get_blue(local_158,0);
                          goto LAB_180c547e2;
                        }
                      }
                      else {
                        lVar11 = FUN_18046c0a0(0);
                        if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                           (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                          lVar11 = HeroData.GetForce(lVar11,0,0);
                          if ((((this.areaIcons != null) &&
                               (lVar10 = GameObject.get_transform(this.areaIcons,0),
                               lVar10 != null)) &&
                              ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                               ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c540), lVar10 != null &&
                                (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar11 != null)) {
                            fVar15 = (float)ForceData.GetForceFavor
                                                      (lVar11,*(uint32 *)
                                                               (*(int64 *)(lVar10 + 24) + 112),0);
                            lVar11 = this.areaIcons;
                            if (fVar15 < 40.0) {
                              if ((((lVar11 != null) &&
                                   (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                  (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) &&
                                 (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null) {
                                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                                lVar11 = pStatics_ef00;
                                if (plVar4 != (int64 *)0) {
                                  uVar2 = *(uint32 *)(lVar11 + 0x2e8);
                                  uVar16 = *(uint32 *)(lVar11 + 0x2ec);
                                  uVar17 = *(uint32 *)(lVar11 + 0x2f0);
                                  uVar18 = *(uint32 *)(lVar11 + 0x2f4);
                                  goto LAB_180c5463c;
                                }
                              }
                            }
                            else if (((lVar11 != null) &&
                                     (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                    ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                                     (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                              puVar12 = local_168;
                              goto LAB_180c547d8;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_180c55938;
            }
        LAB_180c546d2:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55938;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            lVar11 = pStatics_ef00;
            if (plVar4 == (int64 *)0) goto LAB_180c55938;
            uVar2 = *(uint32 *)(lVar11 + 0x280);
            uVar16 = *(uint32 *)(lVar11 + 0x284);
            uVar17 = *(uint32 *)(lVar11 + 0x288);
            uVar18 = *(uint32 *)(lVar11 + 0x28c);
        LAB_180c5463c:
            local_288 = CONCAT44(uVar16,uVar2);
            uStack_280 = CONCAT44(uVar18,uVar17);
            (**(code **)(*plVar4 + 0x2a8))(plVar4);
          }
          switch(this.quickTravelUIType) {
          case 0:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               (lVar11 = Component.GetComponent(lVar11,DAT_181d6c540)) == null) goto LAB_180c55938;
            *(uint32 *)(lVar11 + 32) = 0;
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            lVar10 = this.areaIcons;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 112) == -1) {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar12 = local_138;
        LAB_180c549d2:
              puVar7 = (uint64 *)FUN_181098a50(puVar12,0);
            }
            else {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              if (((this.areaIcons == null) ||
                  (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                  ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                   (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
              puVar7 = (uint64 *)AreaData.GetForceColor(local_148,*(int64 *)(lVar11 + 24),0);
            }
            break;
          case 1:
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55938;
            lVar10 = this.areaIcons;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 72) == 0) {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                  ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                   (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
              iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 16);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
              goto LAB_180c55938;
              lVar10 = this.areaIcons;
              if (iVar3 != *(int *)(lVar11 + 192)) {
                if (((lVar10 != null) && (lVar11 = GameObject.get_transform(lVar10,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar7 = (uint64 *)Color.get_green(local_118,0);
                  if (plVar4 != (int64 *)0) {
                    local_288 = *puVar7;
                    uStack_280 = puVar7[1];
                    (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                    if (((this.areaIcons != null) &&
                        (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                              (lVar11 = Component.GetComponent(lVar11)) != null))) {
                      *(uint32 *)(lVar11 + 32) = 1;
                      goto switchD_180c53add_default;
                    }
                  }
                }
                goto LAB_180c55938;
              }
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar7 = (uint64 *)Color.get_red(local_108,0);
            }
            else {
              if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar12 = local_128;
        LAB_180c54ab7:
              puVar7 = (uint64 *)FUN_1810988d0(puVar12,0);
            }
        LAB_180c54ac1:
            if (plVar4 != (int64 *)0) {
              local_288 = *puVar7;
              uStack_280 = puVar7[1];
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
              if (((this.areaIcons != null) &&
                  (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                 ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                  (lVar11 = Component.GetComponent(lVar11)) != null))) goto LAB_180c5588e;
            }
            goto LAB_180c55938;
          case 2:
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                (lVar11 = Component.GetComponent(lVar11,DAT_181d6c540)) == null)))
            goto LAB_180c55938;
            *(uint32 *)(lVar11 + 32) = 2;
            if ((((this.areaIcons == null) ||
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
               ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55938;
            lVar10 = this.areaIcons;
            if (*(int *)(*(int64 *)(lVar11 + 24) + 112) == -1) {
              if (((lVar10 != null) && (lVar11 = GameObject.get_transform(lVar10,0)) != null) &&
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar12 = local_e8;
                goto LAB_180c549d2;
              }
              goto LAB_180c55938;
            }
            if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55938;
            puVar7 = (uint64 *)AreaData.GetForceColor(local_f8,*(int64 *)(lVar11 + 24),0);
            break;
          case 3:
            QuickTravelUIController.SetRoadsActive(this,0x180000001,0);
            if (((this.areaIcons != null) &&
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                 (*(int64 *)(lVar11 + 24) != 0)))))) {
              iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
              lVar11 = FUN_18046c0a0(0);
              if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                  (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                 (lVar11 = HeroData.GetForce(lVar11,0,0)) == null) goto LAB_180c55938;
              if (iVar3 == *(int *)(lVar11 + 16)) {
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar7 = (uint64 *)Color.get_green(local_d8,0);
                  if (plVar4 != (int64 *)0) goto LAB_180c55822;
                }
                goto LAB_180c55938;
              }
              lVar11 = FUN_18046c3a0(0);
              if (lVar11 == null) goto LAB_180c55938;
              if (*(int *)(lVar11 + 32) == 0) {
        LAB_180c55196:
                if (((this.areaIcons == null) ||
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                   ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                    (((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                      (*(int64 *)(lVar11 + 24) == 0)) || (lVar5 == null)))))) goto LAB_180c55938;
                cVar1 = FUN_181815240(lVar5,*(uint32 *)(*(int64 *)(lVar11 + 24) + 16),
                                      DAT_181d67bf8);
                lVar11 = this.areaIcons;
                if (!cVar1) {
                  if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                     (((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                       ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                        (*(int64 *)(lVar11 + 24) != 0)))) && (lVar9 != null)))) {
                    cVar1 = FUN_181815240(lVar9,*(uint32 *)(*(int64 *)(lVar11 + 24) + 16),
                                          DAT_181d67bf8);
                    lVar11 = this.areaIcons;
                    if (!cVar1) {
                      if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null)
                         && (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                        plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                        puVar12 = local_b8;
                        goto LAB_180c54ab7;
                      }
                    }
                    else if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null
                             ) && (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                      plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                      puVar7 = (uint64 *)Color.get_blue(local_a8,0);
                      goto LAB_180c54ac1;
                    }
                  }
                  goto LAB_180c55938;
                }
                if (((lVar11 == null) || (lVar11 = GameObject.get_transform(lVar11,0)) == null) ||
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar7 = (uint64 *)Color.get_yellow(local_98,0);
              }
              else {
                if ((((this.areaIcons == null) ||
                     (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
                    || (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
                   ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                    (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55938;
                iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 16);
                lVar11 = FUN_18046c3a0(0);
                if (lVar11 == null) goto LAB_180c55938;
                if (iVar3 != *(int *)(lVar11 + 192)) goto LAB_180c55196;
                if (((this.areaIcons == null) ||
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55938;
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar7 = (uint64 *)Color.get_red(local_c8,0);
              }
              if (plVar4 != (int64 *)0) {
                local_288 = *puVar7;
                uStack_280 = puVar7[1];
                (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                    (lVar11 = Component.GetComponent(lVar11)) != null))) {
                  *(uint32 *)(lVar11 + 32) = 3;
                  goto switchD_180c53add_default;
                }
              }
            }
            goto LAB_180c55938;
          case 4:
            if ((((this.areaIcons != null) &&
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) &&
               ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 != null &&
                (*(int64 *)(lVar11 + 24) != 0)))) {
              iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                 ((lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0), lVar11 != null &&
                  (lVar11 = HeroData.GetForce(lVar11,0,0)) != null))) {
                if (iVar3 == *(int *)(lVar11 + 16)) {
                  if ((((this.areaIcons == null) ||
                       (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
                      || (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
                     ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                      (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55932;
                  if (*(int *)(*(int64 *)(lVar11 + 24) + 72) != 2) {
                    if (((this.areaIcons != null) &&
                        (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                      plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                      puVar7 = (uint64 *)Color.get_green(local_88,0);
                      if (plVar4 != (int64 *)0) {
                        local_288 = *puVar7;
                        uStack_280 = puVar7[1];
                        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                        if ((((this.areaIcons != null) &&
                             (lVar11 = GameObject.get_transform(this.areaIcons,0),
                             lVar11 != null)) && (lVar11 = Transform.GetChild(lVar11,plVar14)) != null)
                           && (lVar11 = Component.GetComponent(lVar11)) != null) {
                          *(uint32 *)(lVar11 + 32) = 4;
                          goto switchD_180c53add_default;
                        }
                      }
                    }
                    goto LAB_180c55932;
                  }
                }
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar13 = local_78;
                  goto LAB_180c5580f;
                }
              }
            }
            goto LAB_180c55932;
          case 5:
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) {
        LAB_180c55932:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 112);
            lVar11 = FUN_18046c0a0(0);
            if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
               (lVar11 = HeroData.GetForce(lVar11,0,0)) == null) goto LAB_180c55932;
            if (iVar3 != *(int *)(lVar11 + 16)) {
              if (((this.areaIcons == null) ||
                  (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                  ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c540), lVar11 == null ||
                   (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
              if (*(int *)(*(int64 *)(lVar11 + 24) + 72) != 2) {
                if (((this.areaIcons != null) &&
                    (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                  plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                  puVar7 = (uint64 *)Color.get_green(local_68,0);
                  if (plVar4 != (int64 *)0) {
                    local_288 = *puVar7;
                    uStack_280 = puVar7[1];
                    (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                    if (((this.areaIcons != null) &&
                        (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                              (lVar11 = Component.GetComponent(lVar11)) != null))) {
                      *(uint32 *)(lVar11 + 32) = 5;
                      goto switchD_180c53add_default;
                    }
                  }
                }
                goto LAB_180c55932;
              }
            }
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar13 = &local_230;
        LAB_180c5580f:
            puVar7 = (uint64 *)FUN_1810988d0(puVar13,0);
            if (plVar4 == (int64 *)0) goto LAB_180c55932;
        LAB_180c55822:
            local_288 = *puVar7;
            uStack_280 = puVar7[1];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
            if ((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
            goto LAB_180c55932;
            lVar11 = Transform.GetChild(lVar11,plVar14);
            goto joined_r0x000180c5409b;
          default:
            goto switchD_180c53add_default;
          }
          if (plVar4 == (int64 *)0) goto LAB_180c55938;
        LAB_180c549e5:
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4);
        switchD_180c53add_default:
          plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
          lVar11 = this.areaIcons;
          goto joined_r0x000180c530e5;
        }
        if (((this.areaIcons == null) ||
            (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
           (lVar11 = Transform.GetChild(lVar11,plVar14)) == null) goto LAB_180c55932;
        uVar8 = Component.GetComponent(lVar11,DAT_181d6c640);
        cVar1 = Object.op_Inequality(uVar8,0);
        if (!cVar1) {
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14)) == null) goto LAB_180c55932;
          uVar8 = Component.GetComponent(lVar11);
          cVar1 = Object.op_Inequality(uVar8);
          if (cVar1) {
            lVar11 = this.areaIcons;
            if (this.quickTravelUIType == 2) {
              if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                 (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
                plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                puVar7 = (uint64 *)FUN_181098a50(&local_278,0);
                if (plVar4 != (int64 *)0) {
                  local_288 = *puVar7;
                  uStack_280 = puVar7[1];
                  (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                  if (((this.areaIcons != null) &&
                      (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null)
                     && ((lVar11 = Transform.GetChild(lVar11,plVar14), lVar11 != null &&
                         (lVar11 = Component.GetComponent(lVar11)) != null))) {
                    *(uint32 *)(lVar11 + 32) = 2;
                    goto switchD_180c53add_default;
                  }
                }
              }
            }
            else if (((lVar11 != null) && (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                    (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar7 = (uint64 *)FUN_1810988d0(local_218,0);
              if (plVar4 != (int64 *)0) {
                local_288 = *puVar7;
                uStack_280 = puVar7[1];
                (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
                if ((this.areaIcons != null) &&
                   (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) {
                  lVar11 = Transform.GetChild(lVar11,plVar14);
                  goto joined_r0x000180c5409b;
                }
              }
            }
            goto LAB_180c55932;
          }
          goto switchD_180c53add_default;
        }
        lVar11 = FUN_18046c0a0(0);
        if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
           (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) goto LAB_180c55932;
        if (*(int *)(lVar11 + 132) < 0) {
        LAB_180c53a26:
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55932;
          plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          plVar4 = local_1f8;
        LAB_180c53a8b:
          puVar7 = (uint64 *)FUN_180d904c0(plVar4,0);
        LAB_180c53a95:
          if (plVar6 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar6 + 0x2a8))(plVar6);
        }
        else {
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
               (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
          if (*(int *)(*(int64 *)(lVar11 + 24) + 56) < 0) goto LAB_180c53a26;
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
               (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
          iVar3 = *(int *)(*(int64 *)(lVar11 + 24) + 56);
          lVar11 = FUN_18046c0a0(0);
          if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
             (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
          goto LAB_180c55932;
          if (iVar3 != *(int *)(lVar11 + 132)) {
            if ((((this.areaIcons != null) &&
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                 ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 != null &&
                  (*(int64 *)(lVar11 + 24) != 0)))))) &&
               (lVar11 = ResourcePointData.GetForce(*(int64 *)(lVar11 + 24),0)) != null) {
              iVar3 = *(int *)(lVar11 + 60);
              lVar11 = FUN_18046c0a0(0);
              if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                if (iVar3 == *(int *)(lVar11 + 132)) goto LAB_180c53985;
                lVar11 = FUN_18046c0a0(0);
                if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                   (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                  lVar11 = HeroData.GetForce(lVar11,0,0);
                  if (((((this.areaIcons != null) &&
                        (lVar10 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null) &&
                      ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c640), lVar10 != null &&
                       (*(int64 *)(lVar10 + 24) != 0)))) && (lVar11 != null)) {
                    fVar15 = (float)ForceData.GetForceFavor
                                              (lVar11,*(uint32 *)(*(int64 *)(lVar10 + 24) + 56)
                                               ,0);
                    if (80.0 <= fVar15) {
                      if (((this.areaIcons != null) &&
                          (lVar11 = GameObject.get_transform(this.areaIcons,0),
                          lVar11 != null)) &&
                         ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                          (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                        plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                        puVar7 = (uint64 *)Color.get_blue(&local_240,0);
                        goto LAB_180c53a95;
                      }
                    }
                    else {
                      lVar11 = FUN_18046c0a0(0);
                      if (((lVar11 != null) && (*(int64 *)(lVar11 + 32) != 0)) &&
                         (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) != null) {
                        lVar11 = HeroData.GetForce(lVar11,0,0);
                        if ((((this.areaIcons != null) &&
                             (lVar10 = GameObject.get_transform(this.areaIcons,0),
                             lVar10 != null)) &&
                            ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                             ((lVar10 = Component.GetComponent(lVar10,DAT_181d6c640), lVar10 != null &&
                              (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar11 != null)) {
                          fVar15 = (float)ForceData.GetForceFavor
                                                    (lVar11,*(uint32 *)
                                                             (*(int64 *)(lVar10 + 24) + 56),0);
                          lVar11 = this.areaIcons;
                          if (fVar15 < 40.0) {
                            if ((((lVar11 != null) &&
                                 (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) &&
                               (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null) {
                              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                              lVar11 = pStatics_ef00;
                              if (plVar4 != (int64 *)0) {
                                uVar2 = *(uint32 *)(lVar11 + 0x2e8);
                                uVar16 = *(uint32 *)(lVar11 + 0x2ec);
                                uVar17 = *(uint32 *)(lVar11 + 0x2f0);
                                uVar18 = *(uint32 *)(lVar11 + 0x2f4);
                                goto LAB_180c538f2;
                              }
                            }
                          }
                          else if (((lVar11 != null) &&
                                   (lVar11 = GameObject.get_transform(lVar11,0)) != null) &&
                                  ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 != null &&
                                   (lVar11 = Transform.Find(lVar11,"OutLine",0)) != null))) {
                            plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
                            plVar4 = &local_268;
                            goto LAB_180c53a8b;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180c55932;
          }
        LAB_180c53985:
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             (lVar11 = Transform.Find(lVar11,"OutLine",0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          lVar11 = pStatics_ef00;
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          uVar2 = *(uint32 *)(lVar11 + 0x280);
          uVar16 = *(uint32 *)(lVar11 + 0x284);
          uVar17 = *(uint32 *)(lVar11 + 0x288);
          uVar18 = *(uint32 *)(lVar11 + 0x28c);
        LAB_180c538f2:
          local_288 = CONCAT44(uVar16,uVar2);
          uStack_280 = CONCAT44(uVar18,uVar17);
          (**(code **)(*plVar4 + 0x2a8))(plVar4);
        }
        switch(this.quickTravelUIType) {
        case 0:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              (lVar11 = Component.GetComponent(lVar11,DAT_181d6c640)) == null))) goto LAB_180c55932;
          *(uint32 *)(lVar11 + 32) = 0;
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
              (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55932;
          lVar10 = this.areaIcons;
          if (*(int *)(*(int64 *)(lVar11 + 24) + 56) == -1) {
            if (((lVar10 != null) && (lVar11 = GameObject.get_transform(lVar10,0)) != null) &&
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
              puVar7 = (uint64 *)FUN_181098a50(local_1d8,0);
              goto joined_r0x000180c53c40;
            }
            goto LAB_180c55932;
          }
          if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
              (*(int64 *)(lVar11 + 24) == 0)))) goto LAB_180c55932;
          puVar7 = (uint64 *)
                   ResourcePointData.GetForceColor(local_1e8,*(int64 *)(lVar11 + 24),0);
          goto joined_r0x000180c53c40;
        case 1:
          if (((this.areaIcons != null) &&
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) &&
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) != null) {
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar7 = (uint64 *)FUN_1810988d0(local_1c8,0);
            if (plVar4 != (int64 *)0) {
              local_288 = *puVar7;
              uStack_280 = puVar7[1];
              (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
              if ((this.areaIcons != null) &&
                 (lVar11 = GameObject.get_transform(this.areaIcons,0)) != null) {
                lVar11 = Transform.GetChild(lVar11,plVar14);
                break;
              }
            }
          }
          goto LAB_180c55932;
        case 2:
          if ((((this.areaIcons == null) ||
               (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) ||
             (lVar11 = Component.GetComponent(lVar11,DAT_181d6c640)) == null) goto LAB_180c55932;
          *(uint32 *)(lVar11 + 32) = 2;
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
              ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
               (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
          lVar10 = this.areaIcons;
          if (*(int *)(*(int64 *)(lVar11 + 24) + 56) == -1) {
            if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            puVar7 = (uint64 *)FUN_181098a50(local_1a8,0);
          }
          else {
            if (((lVar10 == null) || (lVar11 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
            plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
            if (((this.areaIcons == null) ||
                (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar11 = Transform.GetChild(lVar11,plVar14,0), lVar11 == null ||
                ((lVar11 = Component.GetComponent(lVar11,DAT_181d6c640), lVar11 == null ||
                 (*(int64 *)(lVar11 + 24) == 0)))))) goto LAB_180c55932;
            puVar7 = (uint64 *)
                     ResourcePointData.GetForceColor(local_1b8,*(int64 *)(lVar11 + 24),0);
          }
        joined_r0x000180c53c40:
          if (plVar4 != (int64 *)0) goto LAB_180c549e5;
          goto LAB_180c55932;
        case 3:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          puVar7 = (uint64 *)FUN_1810988d0(local_198,0);
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
          if ((this.areaIcons == null) ||
             (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180c55932;
          lVar11 = Transform.GetChild(lVar11,plVar14);
          break;
        case 4:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          puVar7 = (uint64 *)FUN_1810988d0(local_188,0);
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
          if ((this.areaIcons == null) ||
             (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180c55932;
          lVar11 = Transform.GetChild(lVar11,plVar14);
          break;
        case 5:
          if (((this.areaIcons == null) ||
              (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar11 = Transform.GetChild(lVar11,plVar14,0)) == null) goto LAB_180c55932;
          plVar4 = (int64 *)Component.GetComponent(lVar11,DAT_181d6bc40);
          puVar7 = (uint64 *)FUN_1810988d0(local_178,0);
          if (plVar4 == (int64 *)0) goto LAB_180c55932;
          local_288 = *puVar7;
          uStack_280 = puVar7[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_288);
          if ((this.areaIcons == null) ||
             (lVar11 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180c55932;
          lVar11 = Transform.GetChild(lVar11,plVar14);
          break;
        default:
          goto switchD_180c53add_default;
        }
        joined_r0x000180c5409b:
        if ((lVar11 != null) && (lVar11 = Component.GetComponent(lVar11)) != null) {
        LAB_180c5588e:
          *(uint32 *)(lVar11 + 32) = 0;
          goto switchD_180c53add_default;
        }
        goto LAB_180c55932;
    }

    // Token : 0x6001FC5
    // RVA   : 0xC55E20   Offset: 0xC54620   Length: 0xC6
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6cb30);
        FUN_180f58a90(lVar1,DAT_181d58d10);
        if (lVar1 != null) {
          FUN_181805880(lVar1,1,DAT_181d58d90);
          FUN_181805880(lVar1,1,DAT_181d58d90);
          FUN_181805880(lVar1,1,DAT_181d58d90);
          this.showAreaType = lVar1;
          this.showInn = 1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x6001FC6
    // RVA   : 0x478350   Offset: 0x476B50   Length: 0x20
    private void <HideQuickTravelUI>b__49_0()
    {
        if (this.quickTravelUI != null) {
          GameObject.SetActive(this.quickTravelUI,0,0);
          return;
        }
    }

}
