// ============================================================
// Type  : QuickTravelUIController
// Token : 0x200033D
// ============================================================

public class QuickTravelUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B05
    private bool inited;

    // Token: 0x4001B06
    public QuickTravelUIType quickTravelUIType;

    // Token: 0x4001B07
    public GameObject quickTravelUI;

    // Token: 0x4001B08
    public GameObject playerIcon;

    // Token: 0x4001B09
    public GameObject quickTravelAreaIcon;

    // Token: 0x4001B0A
    public GameObject quickTravelResourcePointIcon;

    // Token: 0x4001B0B
    public GameObject quickTravelInnIcon;

    // Token: 0x4001B0C
    public GameObject areaIcons;

    // Token: 0x4001B0D
    public GameObject quickTravelRoadPrefab;

    // Token: 0x4001B0E
    public GameObject roads;

    // Token: 0x4001B0F
    public List<Sprite> areaSprite;

    // Token: 0x4001B10
    public List<Sprite> areaSpriteOutLine;

    // Token: 0x4001B11
    public List<float> areaNameOffset;

    // Token: 0x4001B12
    public List<bool> showAreaType;

    // Token: 0x4001B13
    public bool showResourcePoint;

    // Token: 0x4001B14
    public bool showInn;

    // Token: 0x4001B15
    public GameObject roadToggleButton;

    // Token: 0x4001B16
    public Slider scaleSlider;

    // Token: 0x4001B17
    public List<GameObject> areaObjs;

    // Token: 0x4001B18
    public List<GameObject> resourceObjs;

    // Token: 0x4001B19
    public List<GameObject> innObjs;

    // Token: 0x4001B1A
    public GameObject bigmapScaleRoot;

    // Token: 0x4001B1B
    public GameObject bigmapRoot;

    // Token: 0x4001B1C
    public float nowScale;

    // Token: 0x4001B1D
    public float bigMapWidth;

    // Token: 0x4001B1E
    public float bigMapHeight;

    // Token: 0x4001B1F
    private float BaseMapScale;

    // Token: 0x4001B20
    private bool autoClose;

    // Token: 0x4001B21
    private static QuickTravelUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020CD
    // RVA   : 0xA601F0   Offset: 0xA5EFF0   Length: 0x36
    public static QuickTravelUIController get_Instance()
    {
        return **(uint64 **)(DAT_181e743e8 + 184);
    }

    // Token : 0x60020CE
    // RVA   : 0xA5A7A0   Offset: 0xA595A0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e743e8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020CF
    // RVA   : 0xA5FCA0   Offset: 0xA5EAA0   Length: 0x255
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
                lVar2 = Component.GetComponent(lVar2,DAT_181e782b8);
                if (lVar2 != null) {
                  puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                  local_38 = *puVar3;
                  uStack_34 = puVar3[1];
                  uStack_30 = puVar3[2];
                  uStack_2c = puVar3[3];
                  fVar4 = (float)FUN_180af4db0(&local_38,0);
                  fVar1 = *(float *)(*(int64 *)(DAT_181e538e8 + 184) + 0x110);
                  this.BaseMapScale = fVar4 / (fVar1 + fVar1);
                  if (this.quickTravelUI != null) {
                    lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                    if (lVar2 != null) {
                      lVar2 = Transform.Find(lVar2,"MapRoot",0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"BigMap",0);
                        if (lVar2 != null) {
                          lVar2 = Component.GetComponent(lVar2,DAT_181e782b8);
                          if (lVar2 != null) {
                            puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                            local_38 = *puVar3;
                            uStack_34 = puVar3[1];
                            uStack_30 = puVar3[2];
                            uStack_2c = puVar3[3];
                            uVar5 = FUN_180af4e40(&local_38,0);
                            this.bigMapWidth = uVar5;
                            if (this.quickTravelUI != null) {
                              lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                              if (lVar2 != null) {
                                lVar2 = Transform.Find(lVar2,"MapRoot",0);
                                if (lVar2 != null) {
                                  lVar2 = Transform.Find(lVar2,"BigMap",0);
                                  if (lVar2 != null) {
                                    lVar2 = Component.GetComponent(lVar2,DAT_181e782b8);
                                    if (lVar2 != null) {
                                      puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                                      local_38 = *puVar3;
                                      uStack_34 = puVar3[1];
                                      uStack_30 = puVar3[2];
                                      uStack_2c = puVar3[3];
                                      uVar5 = FUN_180af4db0(&local_38,0);
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

    // Token : 0x60020D0
    // RVA   : 0xA5A950   Offset: 0xA59750   Length: 0x144
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

    // Token : 0x60020D1
    // RVA   : 0xA5A810   Offset: 0xA59610   Length: 0x135
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
                if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
                  plVar2 = plVar1;
                }
                NGUITools.PlaySound(plVar2,0x3d75c28f,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x60020D2
    // RVA   : 0xA5C0A0   Offset: 0xA5AEA0   Length: 0xCD
    public void ScaleSliderChange()
    {
        float fVar3;
        plVar1 = this.scaleSlider;
        if (plVar1 != (int64 *)0) {
          fVar3 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          QuickTravelUIController.SetNowScale(this,fVar3 + 1.0,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/摩擦",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0x3d23d70a,0);
          return;
        }
    }

    // Token : 0x60020D3
    // RVA   : 0xA5C170   Offset: 0xA5AF70   Length: 0x5A9
    public void SetNowScale(float scale)
    {
        var pStatics = *(int64*)(DAT_181e743e8 + 184);
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
        uVar7 = FUN_180f34e60(scale,0x3f800000,0x40000000,0);
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
                      if (lVar1 == null) goto LAB_180a5c714;
                      if (lVar1.Count <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(lVar3 + lVar1._items);
                      if ((lVar1 == null) ||
                         (lVar1 = GameObject.GetComponent(lVar1,DAT_181e55960)) == null)
                      goto LAB_180a5c714;
                      QuickTravelAreaIconController.RefreshNameScale(lVar1,0);
                      lVar1 = this.areaObjs;
                      uVar4 = uVar4 + 1;
                      lVar3 = lVar3 + 8;
                      if (lVar1 == null) goto LAB_180a5c714;
                    }
                    lVar1 = this.resourceObjs;
                    if (lVar1 != null) {
                      lVar3 = 32;
                      uVar4 = uVar6;
                      goto LAB_180a5c411;
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180a5c714:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_180a5c411:
        if (lVar1.Count <= (int)uVar4) {
          lVar1 = this.innObjs;
          if (lVar1 != null) goto LAB_180a5c584;
          goto LAB_180a5c714;
        }
        if (lVar1 == null) goto LAB_180a5c714;
        if (lVar1.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar3 + lVar1._items);
        if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181e55a70)) == null)
        goto LAB_180a5c714;
        lVar1 = Component.get_transform(lVar1,0);
        if (lVar1 == null) goto LAB_180a5c714;
        lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
        puVar2 = (uint64 *)Vector3.get_one(local_38,0);
        local_68 = *puVar2;
        local_60 = *(float *)(puVar2 + 1);
        if (*pStatics == 0) goto LAB_180a5c714;
        fVar8 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
        local_50 = local_60 / fVar8;
        local_58 = CONCAT44(local_68._4_4_ / fVar8,(float)local_68 / fVar8);
        if (lVar1 == null) goto LAB_180a5c714;
        local_48 = local_58;
        local_40 = local_50;
        Transform.set_localScale(lVar1,&local_48);
        lVar1 = this.resourceObjs;
        uVar4 = uVar4 + 1;
        lVar3 = lVar3 + 8;
        if (lVar1 == null) goto LAB_180a5c714;
        goto LAB_180a5c411;
        LAB_180a5c584:
        if (lVar1.Count <= (int)uVar6) {
          return;
        }
        if (lVar1 == null) goto LAB_180a5c714;
        if (lVar1.Count <= uVar6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar5 + lVar1._items);
        if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181e559e8)) == null)
        goto LAB_180a5c714;
        lVar1 = Component.get_transform(lVar1,0);
        if (lVar1 == null) goto LAB_180a5c714;
        lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
        puVar2 = (uint64 *)Vector3.get_one(local_38,0);
        local_58 = *puVar2;
        local_50 = *(float *)(puVar2 + 1);
        if (*pStatics == 0) goto LAB_180a5c714;
        fVar8 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
        local_60 = local_50 / fVar8;
        local_68 = CONCAT44(local_58._4_4_ / fVar8,(float)local_58 / fVar8);
        if (lVar1 == null) goto LAB_180a5c714;
        local_48 = local_68;
        local_40 = local_60;
        Transform.set_localScale(lVar1,&local_48);
        lVar1 = this.innObjs;
        uVar6 = uVar6 + 1;
        lVar5 = lVar5 + 8;
        if (lVar1 == null) goto LAB_180a5c714;
        goto LAB_180a5c584;
    }

    // Token : 0x60020D4
    // RVA   : 0xA5BCF0   Offset: 0xA5AAF0   Length: 0x10B
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

    // Token : 0x60020D5
    // RVA   : 0xA5ACB0   Offset: 0xA59AB0   Length: 0x103D
    private void InitQuickTravelMap()
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar10;
        long lVar11;
        long lVar12;
        ulong uVar13;
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
        if (((GameController._instance != null) &&
            (lVar12 = GameController._instance.worldData) != null) &&
           (lVar12 = lVar12.Areas) != null) {
          FUN_1816629a0(&local_148,lVar12,DAT_181e5e548);
          local_b8 = local_148;
          uStack_b4 = uStack_144;
          uStack_b0 = uStack_140;
          uStack_ac = uStack_13c;
          local_a8 = local_138;
          while( true ) {
            cVar3 = FUN_1807b3f30(&local_b8,DAT_181e6b948);
            lVar12 = local_a8;
            if (!cVar3) break;
            uVar7 = this.areaIcons;
            uVar13 = this.quickTravelAreaIcon;
            lVar5 = GlobalData.AddChild(uVar7,uVar13,0);
            local_e8 = lVar5;
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = GameObject.GetComponent(lVar5,DAT_181e54f48);
            if (lVar12 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (this.areaSprite == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar7 = FUN_1800024b0(this.areaSprite,lVar12.Forces,
                                  DAT_181e85ff0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            Image.set_sprite(lVar6,uVar7,0);
            plVar8 = (int64 *)GameObject.GetComponent(lVar5,DAT_181e54f48);
            if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300(0);
            }
            (**(code **)(*plVar8 + 0x408))(plVar8,*(uint64 *)(*plVar8 + 0x410));
            lVar6 = GameObject.GetComponent(lVar5,DAT_181e55c90);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar7 = RectTransform.get_sizeDelta(lVar6,0);
            local_res18 = (float)uVar7;
            fStackX_1c = (float)((uint64)uVar7 >> 32);
            RectTransform.set_sizeDelta(lVar6,CONCAT44(fStackX_1c * 0.5,local_res18 * 0.5),0);
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = Transform.Find(lVar6,"OutLine",0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = Component.GetComponent(lVar6,DAT_181e777b8);
            if (this.areaSpriteOutLine == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar7 = FUN_1800024b0(this.areaSpriteOutLine,lVar12.Forces,
                                  DAT_181e85ff0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            Image.set_sprite(lVar6,uVar7,0);
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = Transform.Find(lVar6,"OutLine",0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300(0);
            }
            (**(code **)(*plVar8 + 0x408))(plVar8,*(uint64 *)(*plVar8 + 0x410));
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = Transform.Find(lVar6,"OutLine",0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = Component.GetComponent(lVar6,DAT_181e782b8);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar7 = RectTransform.get_sizeDelta(lVar6,0);
            local_res18 = (float)uVar7;
            fStackX_1c = (float)((uint64)uVar7 >> 32);
            RectTransform.set_sizeDelta(lVar6,CONCAT44(fStackX_1c * 0.5,local_res18 * 0.5),0);
            lVar6 = GameObject.get_transform(lVar5,0);
            fVar1 = this.BaseMapScale;
            if (lVar12.ResourcePoints == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            puVar9 = (uint64 *)
                     BigMapPos.ToVector3(local_88,lVar12.ResourcePoints,0x3f800000,0);
            local_d8 = *(float *)(puVar9 + 1);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_c8 = CONCAT44((float)((uint64)*puVar9 >> 32) * fVar1,(float)*puVar9 * fVar1);
            local_c0 = local_d8 * fVar1;
            Transform.set_localPosition(lVar6,&local_c8,0);
            if (PlotController.fightSkillIndexCache == 1) {
              lVar6 = PlotController._instance;
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              cVar3 = FUN_18176a2d0(lVar6,lVar12.chapter,DAT_181e71570);
              if (!cVar3) {
                plVar8 = (int64 *)GameObject.GetComponent(lVar5,DAT_181e54f48);
                if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300(0);
                }
                (**(code **)(*plVar8 + 0x2c8))(plVar8,0,*(uint64 *)(*plVar8 + 0x2d0));
              }
            }
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6 = Transform.Find(lVar6,"AreaNameBack",0);
            if (this.areaNameOffset == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar15 = FUN_1800024e0(this.areaNameOffset,lVar12.Forces,
                                   DAT_181e83530);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_128 = 0;
            local_120 = 0;
            local_124 = uVar15;
            Transform.set_localPosition(lVar6,&local_128,0);
            lVar6 = GameObject.GetComponent(lVar5,DAT_181e55960);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar6.plotHappen = lVar12;
            if (this.areaObjs == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_18175de30(this.areaObjs,lVar5);
            iVar14 = 0;
            while( true ) {
              lVar5 = lVar12.cheating;
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(int *)(lVar5 + 24) <= iVar14) break;
              iVar4 = FUN_180002480(lVar5,iVar14);
              if (lVar12.chapter < iVar4) {
                lVar5 = lVar12.ResourcePoints;
                lVar6 = FUN_1802106e0(0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = lVar6.plotPanel;
                if (lVar12.cheating == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                uVar15 = FUN_180002480(lVar12.cheating,iVar14);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = WorldData.GetArea(lVar6,uVar15);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                uVar7 = lVar6.plotAutoButton;
                uVar13 = this.roads;
                uVar2 = this.quickTravelRoadPrefab;
                lVar6 = GlobalData.AddChild(uVar13,uVar2,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar10 = GameObject.get_transform(lVar6,0);
                lVar11 = GameObject.get_transform(local_e8,0);
                if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                puVar9 = (uint64 *)Transform.get_localPosition(local_78,lVar11);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                local_168 = *puVar9;
                local_160 = *(float *)(puVar9 + 1);
                Transform.set_localPosition(lVar10,&local_168);
                lVar10 = GameObject.GetComponent(lVar6,DAT_181e55c90);
                fVar1 = this.BaseMapScale;
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                fVar16 = (float)BigMapPos.Distance(lVar5,uVar7);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                RectTransform.set_sizeDelta(lVar10,CONCAT44(0x40400000,fVar16 * fVar1));
                lVar6 = GameObject.get_transform(lVar6,0);
                lVar5 = BigMapPos.op_Subtraction(uVar7,lVar5);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                puVar9 = (uint64 *)BigMapPos.ToVector3(&local_148,lVar5,0x3f800000,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                local_158 = *puVar9;
                local_150 = *(float *)(puVar9 + 1);
                Transform.set_right(lVar6,&local_158);
              }
              iVar14 = iVar14 + 1;
            }
          }
          ZhSegment.Initialize(&local_b8,DAT_181e6b8c8);
          lVar12 = FUN_1802106e0(0);
          if (((lVar12 != null) && (lVar12.villageAreaID != null)) &&
             (lVar12 = *(int64 *)(lVar12.villageAreaID + 64)) != null) {
            FUN_1816629a0(&local_148,lVar12,DAT_181e81fd0);
            local_118 = CONCAT44(uStack_144,local_148);
            uStack_110 = CONCAT44(uStack_13c,uStack_140);
            local_108 = local_138;
            while( true ) {
              cVar3 = FUN_1807b3f30(&local_118,DAT_181e72640);
              lVar12 = local_108;
              if (!cVar3) break;
              uVar7 = this.areaIcons;
              uVar13 = this.quickTravelResourcePointIcon;
              lVar5 = GlobalData.AddChild(uVar7,uVar13,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar6 = GameObject.get_transform(lVar5,0);
              fVar1 = this.BaseMapScale;
              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (lVar12.forceAreaID == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              puVar9 = (uint64 *)
                       BigMapPos.ToVector3(&local_148,lVar12.forceAreaID,0x3f800000,0);
              local_150 = *(float *)(puVar9 + 1);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              local_168 = CONCAT44((float)((uint64)*puVar9 >> 32) * fVar1,(float)*puVar9 * fVar1);
              local_160 = local_150 * fVar1;
              Transform.set_localPosition(lVar6,&local_168,0);
              lVar6 = GameObject.get_transform(lVar5,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar6 = Transform.Find(lVar6,"AreaNameBack",0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar6 = Transform.Find(lVar6,"AreaName",0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar13 = Component.GetComponent(lVar6,DAT_181e79538);
              uVar7 = lVar12.cityAreaID;
              LTLocalization.SetText(uVar13,uVar7,0);
              lVar6 = GameObject.GetComponent(lVar5,DAT_181e55a70);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar6.plotHappen = lVar12;
              if (this.resourceObjs == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              FUN_18175de30(this.resourceObjs,lVar5);
            }
            ZhSegment.Initialize(&local_118,DAT_181e725c0);
            lVar12 = FUN_1802106e0(0);
            if (((lVar12 != null) && (lVar12.villageAreaID != null)) &&
               (lVar12 = *(int64 *)(lVar12.villageAreaID + 56)) != null) {
              FUN_1816629a0(&local_148,lVar12,DAT_181e70d70);
              local_f0 = local_138;
              while( true ) {
                cVar3 = FUN_1807b3f30(&local_100,DAT_181e6f140);
                lVar12 = local_f0;
                if (!cVar3) {
                  ZhSegment.Initialize(&local_100,DAT_181e6f0c0);
                  return;
                }
                uVar7 = this.areaIcons;
                uVar13 = this.quickTravelInnIcon;
                lVar5 = GlobalData.AddChild(uVar7,uVar13,0);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = GameObject.get_transform(lVar5,0);
                fVar1 = this.BaseMapScale;
                if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if (lVar12.Areas == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                puVar9 = (uint64 *)
                         BigMapPos.ToVector3(&local_148,lVar12.Areas,0x3f800000,0);
                local_150 = *(float *)(puVar9 + 1);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                local_168 = CONCAT44((float)((uint64)*puVar9 >> 32) * fVar1,(float)*puVar9 * fVar1);
                local_160 = local_150 * fVar1;
                Transform.set_localPosition(lVar6,&local_168,0);
                lVar6 = GameObject.get_transform(lVar5,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"AreaNameBack",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6 = Transform.Find(lVar6,"AreaName",0);
                if (lVar6 == null) break;
                uVar13 = Component.GetComponent(lVar6,DAT_181e79538);
                uVar7 = lVar12.cityAreaID;
                LTLocalization.SetText(uVar13,uVar7,0);
                lVar6 = GameObject.GetComponent(lVar5,DAT_181e559e8);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar6.plotHappen = lVar12;
                if (this.innObjs == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_18175de30(this.innObjs,lVar5);
              }
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
          }
        }
    }

    // Token : 0x60020D6
    // RVA   : 0xA60110   Offset: 0xA5EF10   Length: 0xE
    private void Update()
    {
        void FUN_180a60110(int64 this)
        {
        if (!this.inited) {
          QuickTravelUIController.InitQuickTravelMap(this,0);
          return;
        }
    }

    // Token : 0x60020D7
    // RVA   : 0xA60030   Offset: 0xA5EE30   Length: 0x6B
    public void ToggleResourcePointButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        if (buttonClicked != null) {
          lVar1 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if (lVar1 != null) {
            this.showResourcePoint = *(uint8 *)(lVar1 + 0x118);
            QuickTravelUIController.RefreshAllResourceState(this,0);
            return;
          }
        }
    }

    // Token : 0x60020D8
    // RVA   : 0xA5FF00   Offset: 0xA5ED00   Length: 0xB6
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
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_18166b1c0(lVar1,uVar3,*(uint8 *)(lVar4 + 0x118),DAT_181e627f8);
            QuickTravelUIController.RefreshAllAreaState(this,0);
            return;
          }
        }
    }

    // Token : 0x60020D9
    // RVA   : 0xA600A0   Offset: 0xA5EEA0   Length: 0x6F
    public void ToggleRoadButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        long lVar2;
        lVar1 = this.roads;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if ((lVar2 != null) && (lVar1 != null)) {
            GameObject.SetActive(lVar1,*(uint8 *)(lVar2 + 0x118),0);
            return;
          }
        }
    }

    // Token : 0x60020DA
    // RVA   : 0xA5FFC0   Offset: 0xA5EDC0   Length: 0x6B
    public void ToggleInnButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        if (buttonClicked != null) {
          lVar1 = GameObject.GetComponent(buttonClicked,DAT_181e57478);
          if (lVar1 != null) {
            this.showInn = *(uint8 *)(lVar1 + 0x118);
            QuickTravelUIController.RefreshAllInnState(this,0);
            return;
          }
        }
    }

    // Token : 0x60020DB
    // RVA   : 0xA5C720   Offset: 0xA5B520   Length: 0x67
    public void SetRoadsActive(bool active)
    {
        long lVar1;
        if (this.roadToggleButton != null) {
          lVar1 = GameObject.GetComponent(this.roadToggleButton,DAT_181e57478);
          if (lVar1 != null) {
            Toggle.set_isOn(lVar1,active,0);
            return;
          }
        }
    }

    // Token : 0x60020DC
    // RVA   : 0xA5BE00   Offset: 0xA5AC00   Length: 0xD2
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
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181e55960)) == null)
            break;
            QuickTravelAreaIconController.RefreshState(lVar1,0);
            lVar1 = this.areaObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60020DD
    // RVA   : 0xA5BFC0   Offset: 0xA5ADC0   Length: 0xD2
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
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181e55a70)) == null)
            break;
            QuickTravelResourcePointController.RefreshState(lVar1,0);
            lVar1 = this.resourceObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60020DE
    // RVA   : 0xA5BEE0   Offset: 0xA5ACE0   Length: 0xD2
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
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181e559e8)) == null)
            break;
            QuickTravelInnIconController.RefreshState(lVar1,0);
            lVar1 = this.innObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60020DF
    // RVA   : 0xA5A7F0   Offset: 0xA595F0   Length: 0x11
    public void BackgroundClicked()
    {
        void FUN_180a5a7f0(int64 this)
        {
        if (!this.autoClose) {
          QuickTravelUIController.HideQuickTravelUI(this,0);
          return;
        }
    }

    // Token : 0x60020E0
    // RVA   : 0xA5AAA0   Offset: 0xA598A0   Length: 0x206
    public void HideQuickTravelUI()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.quickTravelUI != null) {
          lVar2 = GameObject.get_transform(this.quickTravelUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea5848);
              if (this.quickTravelUI != null) {
                lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"MapRoot",0);
                  uVar3 = ShortcutExtensions.DOScaleX(uVar3,0,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea59e0);
                  uVar4 = new OnTooltipCB(this,DAT_181e7d568,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181ea3dc0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020E1
    // RVA   : 0xA5C790   Offset: 0xA5B590   Length: 0x88
    public void ShowQuickTravelUIShowType()
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
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

    // Token : 0x60020E2
    // RVA   : 0xA5FC70   Offset: 0xA5EA70   Length: 0x22
    public void ShowQuickTravelUI(QuickTravelUIType targetTravelUIType)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        void QuickTravelUIController.ShowQuickTravelUI
                     (int64 this,uint32 targetTravelUIType,int64 param_3,uint8 param_4)
        {
        int64 lVar1;
        char cVar2;
        uint32 uVar3;
        int iVar4;
        int64 *plVar5;
        int64 lVar6;
        int64 *plVar7;
        uint64 uVar8;
        int64 lVar9;
        int64 lVar10;
        uint64 uVar11;
        uint8 *puVar12;
        uint32 *puVar13;
        int64 *plVar14;
        float fVar15;
        float fVar16;
        uint32 uVar17;
        uint64 local_298;
        uint32 uStack_290;
        uint32 uStack_28c;
        uint64 local_288;
        int64 lStack_280;
        int64 local_278;
        float local_270;
        uint64 local_268;
        uint64 uStack_260;
        int64 local_258;
        int64 local_250;
        uint8 local_240 [16];
        uint32 local_230;
        uint32 uStack_22c;
        uint32 uStack_228;
        uint32 uStack_224;
        int64 local_220;
        uint8 local_208 [16];
        uint8 local_1f8 [16];
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
        local_298 = this;
        local_268 = 0;
        uStack_260 = 0;
        local_258 = 0;
        plVar14 = (int64 *)0;
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar7 = plVar14;
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
          plVar7 = plVar5;
        }
        NGUITools.PlaySound(plVar7,0);
        fVar15 = local_270;
        if (this.quickTravelUI == null) {
        LAB_180a5fc39:
          local_270 = fVar15;
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameObject.SetActive(this.quickTravelUI,1,0);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180a5fc39;
        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           ((lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270, lVar6 == null ||
            (plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8), fVar15 = local_270,
            plVar7 == (int64 *)0)))) goto LAB_180a5fc39;
        plVar7 = (int64 *)
                 (**(code **)(*plVar7 + 0x298))(&local_288,plVar7,*(uint64 *)(*plVar7 + 0x2a0));
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        plVar7 = (int64 *)GlobalData.SetColorAlpha(&local_278,&local_288,0,0);
        fVar15 = local_270;
        if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_288,*(uint64 *)(*plVar5 + 0x2b0));
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180a5fc39;
        uVar8 = Component.GetComponent(lVar6,DAT_181e777b8);
        uVar8 = DOTweenModuleUI.DOFade(uVar8,0x3f000000,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea5848);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"MapRoot",0), fVar15 = local_270) == null)
        goto LAB_180a5fc39;
        local_288 = param_3 << 32;
        lStack_280 = CONCAT44(lStack_280._4_4_,(int)param_3);
        Transform.set_localScale(lVar6,&local_288,0);
        fVar15 = local_270;
        if ((this.quickTravelUI == null) ||
           (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
           lVar6 == null)) goto LAB_180a5fc39;
        uVar8 = Transform.Find(lVar6,"MapRoot",0);
        uVar8 = ShortcutExtensions.DOScaleX(uVar8,param_3,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea59e0);
        this.quickTravelUIType = targetTravelUIType;
        fVar15 = local_270;
        if (this.playerIcon == null) goto LAB_180a5fc39;
        lVar6 = GameObject.get_transform(this.playerIcon,0);
        fVar16 = this.BaseMapScale;
        fVar15 = local_270;
        if ((((GameController._instance == null) ||
             (lVar9 = GameController._instance.worldData) == null) ||
            (lVar9 = WorldData.Player(lVar9,0), fVar15 = local_270) == null) ||
           (lVar9.playerServantForceTime == 0)) goto LAB_180a5fc39;
        plVar5 = (int64 *)BigMapPos.ToVector3(local_240,lVar9.playerServantForceTime,0x3f800000,0);
        local_250 = *plVar5;
        local_288 = CONCAT44((float)((uint64)local_250 >> 32) * fVar16,(float)local_250 * fVar16);
        local_270 = *(float *)(plVar5 + 1) * fVar16;
        lStack_280 = CONCAT44((int)((uint64)lStack_280 >> 32),local_270);
        local_278 = local_250;
        fVar15 = *(float *)(plVar5 + 1);
        if (lVar6 == null) goto LAB_180a5fc39;
        local_278 = local_288;
        Transform.set_localPosition(lVar6,&local_278,0);
        this.autoClose = param_4;
        lVar6 = il2cpp_internal(DAT_181e73cb8);
        local_250 = lVar6;
        FUN_1810f3480(lVar6,DAT_181e71270);
        local_278 = lVar6;
        lVar9 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar9,DAT_181e71270);
        local_288 = lVar9;
        if (this.quickTravelUIType == 3) {
          fVar15 = local_270;
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (lVar1 = lVar1.Areas) == null) goto LAB_180a5fc39;
          FUN_1816629a0(&local_230,lVar1,DAT_181e5e548);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
          while (cVar2 = FUN_1807b3f30(&local_268,DAT_181e6b948), lVar1 = local_258, cVar2) {
            if (local_258 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = AreaData.BelongPlayerOrAlley(local_258,0);
            if (cVar2) {
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              FUN_181769fe0(lVar9,lVar1.chapter,DAT_181e713f0);
            }
          }
          ZhSegment.Initialize(&local_268,DAT_181e6b8c8);
          fVar15 = local_270;
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (lVar1 = lVar1.Areas) == null) goto LAB_180a5fc39;
          FUN_1816629a0(&local_230,lVar1,DAT_181e5e548);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
        LAB_180a5d062:
          cVar2 = FUN_1807b3f30(&local_268,DAT_181e6b948);
          lVar1 = local_258;
          if (cVar2) {
            lVar10 = FUN_1802106e0(0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar10 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar10 = HeroData.GetForce(lVar10,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = ForceData.CanAttack(lVar10,lVar1.lastRandomWorldEventDay);
            plVar5 = plVar14;
            if (cVar2) {
              while( true ) {
                lVar10 = lVar1.cheating;
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if (*(int *)(lVar10 + 24) <= (int)plVar5) goto LAB_180a5d062;
                uVar3 = FUN_180002480(lVar10,plVar5,DAT_181e71bf0);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                cVar2 = FUN_18176a2d0(lVar9,uVar3);
                if (cVar2) break;
                plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              }
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              FUN_181769fe0(lVar6,lVar1.chapter);
            }
            goto LAB_180a5d062;
          }
          ZhSegment.Initialize(&local_268,DAT_181e6b8c8);
        }
        lVar1 = local_298;
        lVar6 = this.areaIcons;
        joined_r0x000180a5d1c1:
        if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) goto LAB_180a5fc33;
        iVar4 = Transform.get_childCount(lVar6,0);
        if (iVar4 <= (int)plVar14) {
          QuickTravelUIController.RefreshAllAreaState(this,0);
          QuickTravelUIController.RefreshAllResourceState(this,0);
          QuickTravelUIController.RefreshAllInnState(this,0);
          return;
        }
        fVar15 = local_270;
        if (((this.areaIcons == null) ||
            (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
            lVar6 == null)) || (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null
           ) goto LAB_180a5fc39;
        uVar8 = Component.GetComponent(lVar6,DAT_181e780b8);
        cVar2 = Object.op_Inequality(uVar8,0);
        lVar6 = lVar1.Forces;
        if (cVar2) {
          fVar15 = local_270;
          if (((lVar6 == null) ||
              (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
              ((lVar6 = Transform.Find(lVar6,"AreaNameBack",0), fVar15 = local_270, lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"AreaName",0), fVar15 = local_270) == null)))))
          goto LAB_180a5fc39;
          uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
          fVar15 = local_270;
          if ((this.areaIcons == null) ||
             ((((lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270) == null) ||
              (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180a5fc39;
          uVar11 = AreaData.GetAreaName(*(int64 *)(lVar6 + 24),0);
          LTLocalization.SetText(uVar8,uVar11,0);
          lVar6 = FUN_1802106e0(0);
          fVar15 = local_270;
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
          goto LAB_180a5fc39;
          cVar2 = HeroData.HaveForce(lVar6,0);
          if (!cVar2) {
        LAB_180a5e963:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            puVar12 = local_158;
        LAB_180a5e9c8:
            plVar7 = (int64 *)FUN_180af4e90(puVar12,0);
        LAB_180a5e9d2:
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
            local_298 = *plVar7;
            uStack_290 = (uint32)plVar7[1];
            uStack_28c = *(uint32 *)((int64)plVar7 + 12);
            (**(code **)(*plVar5 + 0x2a8))(plVar5);
          }
          else {
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            if (!cVar2) goto LAB_180a5e963;
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_1802106e0(0);
            fVar15 = local_270;
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            if (iVar4 != *(int *)(lVar6 + 132)) {
              if ((((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270
                   , lVar6 != null)) &&
                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 != null &&
                   ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 != null
                    && (*(int64 *)(lVar6 + 24) != 0)))))) &&
                 (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 24),0), fVar15 = local_270,
                 lVar6 != null)) {
                iVar4 = *(int *)(lVar6 + 60);
                lVar6 = FUN_1802106e0(0);
                fVar15 = local_270;
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                   lVar6 != null)) {
                  if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180a5e8c2;
                  lVar6 = FUN_1802106e0(0);
                  fVar15 = local_270;
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                     lVar6 != null)) {
                    lVar6 = HeroData.GetForce(lVar6,0,0);
                    fVar15 = local_270;
                    if (((((this.areaIcons != null) &&
                          (lVar10 = GameObject.get_transform(this.areaIcons,0),
                          fVar15 = local_270, lVar10 != null)) &&
                         (lVar10 = Transform.GetChild(lVar10,plVar14,0), fVar15 = local_270) != null
                         ) && ((lVar10 = Component.GetComponent(lVar10,DAT_181e780b8), fVar15 = local_270
                               , lVar10 != null && (*(int64 *)(lVar10 + 24) != 0)))) && (lVar6 != null)) {
                      fVar15 = (float)ForceData.GetForceFavor
                                                (lVar6,*(uint32 *)
                                                        (*(int64 *)(lVar10 + 24) + 112),0);
                      if (80.0 <= fVar15) {
                        fVar15 = local_270;
                        if (((this.areaIcons != null) &&
                            (lVar6 = GameObject.get_transform(this.areaIcons,0),
                            fVar15 = local_270, lVar6 != null)) &&
                           ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 != null
                            && (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                               lVar6 != null)))) {
                          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                          plVar7 = (int64 *)Color.get_blue(local_58,0);
                          goto LAB_180a5e9d2;
                        }
                      }
                      else {
                        lVar6 = FUN_1802106e0(0);
                        fVar15 = local_270;
                        if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                           lVar6 != null)) {
                          lVar6 = HeroData.GetForce(lVar6,0,0);
                          fVar15 = local_270;
                          if ((((this.areaIcons != null) &&
                               (lVar10 = GameObject.get_transform(this.areaIcons,0),
                               fVar15 = local_270, lVar10 != null)) &&
                              ((lVar10 = Transform.GetChild(lVar10,plVar14,0), fVar15 = local_270,
                               lVar10 != null &&
                               ((lVar10 = Component.GetComponent(lVar10,DAT_181e780b8),
                                fVar15 = local_270, lVar10 != null && (*(int64 *)(lVar10 + 24) != 0)))))
                              ) && (lVar6 != null)) {
                            fVar16 = (float)ForceData.GetForceFavor
                                                      (lVar6,*(uint32 *)
                                                              (*(int64 *)(lVar10 + 24) + 112),0);
                            lVar6 = lVar1.Forces;
                            fVar15 = local_270;
                            if (fVar16 < 40.0) {
                              if ((((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270,
                                   lVar6 != null)) &&
                                  (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270,
                                  lVar6 != null)) &&
                                 (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                                 lVar6 != null)) {
                                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                                lVar6 = pStatics_38e8;
                                fVar15 = local_270;
                                if (plVar5 != (int64 *)0) {
                                  uVar3 = *(uint32 *)(lVar6 + 0x2f8);
                                  uVar17 = *(uint32 *)(lVar6 + 0x2fc);
                                  uStack_290 = *(uint32 *)(lVar6 + 0x300);
                                  uStack_28c = *(uint32 *)(lVar6 + 0x304);
                                  goto LAB_180a5e82c;
                                }
                              }
                            }
                            else if (((lVar6 != null) &&
                                     (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270,
                                     lVar6 != null)) &&
                                    ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270,
                                     lVar6 != null &&
                                     (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                                     lVar6 != null)))) {
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                              puVar12 = local_168;
                              goto LAB_180a5e9c8;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_180a5fc39;
            }
        LAB_180a5e8c2:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            lVar6 = pStatics_38e8;
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
            uVar3 = *(uint32 *)(lVar6 + 0x290);
            uVar17 = *(uint32 *)(lVar6 + 0x294);
            uStack_290 = *(uint32 *)(lVar6 + 0x298);
            uStack_28c = *(uint32 *)(lVar6 + 0x29c);
        LAB_180a5e82c:
            local_298 = CONCAT44(uVar17,uVar3);
            (**(code **)(*plVar5 + 0x2a8))(plVar5);
          }
          fVar15 = local_270;
          switch(this.quickTravelUIType) {
          case 0:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            *(uint32 *)(lVar6 + 32) = 0;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = lVar1.Forces;
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              puVar12 = local_138;
        LAB_180a5ebc7:
              plVar7 = (int64 *)FUN_180f24d00(puVar12,0);
            }
            else {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
              plVar7 = (int64 *)AreaData.GetForceColor(local_148,*(int64 *)(lVar6 + 24),0);
            }
            break;
          case 1:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180a5fc39;
            lVar10 = lVar1.Forces;
            if (*(int *)(*(int64 *)(lVar6 + 24) + 72) == 0) {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
              lVar6 = FUN_1802106e0(0);
              fVar15 = local_270;
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270, lVar6 == null
                 )) goto LAB_180a5fc39;
              lVar10 = lVar1.Forces;
              if (iVar4 != *(int *)(lVar6 + 192)) {
                if (((lVar10 != null) &&
                    (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  plVar7 = (int64 *)Color.get_green(local_118,0);
                  fVar15 = local_270;
                  if (plVar5 != (int64 *)0) {
                    local_298 = *plVar7;
                    uStack_290 = (uint32)plVar7[1];
                    uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                    fVar15 = local_270;
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0),
                        fVar15 = local_270, lVar6 != null)) &&
                       ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                        (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null))) {
                      *(uint32 *)(lVar6 + 32) = 1;
                      goto switchD_180a5dbbe_default;
                    }
                  }
                }
                goto LAB_180a5fc39;
              }
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)Color.get_red(local_108,0);
            }
            else {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)FUN_180f24b80(local_128,0);
            }
            fVar15 = local_270;
            if (plVar5 != (int64 *)0) {
              local_298 = *plVar7;
              uStack_290 = (uint32)plVar7[1];
              uStack_28c = *(uint32 *)((int64)plVar7 + 12);
              (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
              fVar15 = local_270;
              if (((this.areaIcons != null) &&
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 != null)) &&
                 ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                  (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null)))
              goto LAB_180a5fb89;
            }
            goto LAB_180a5fc39;
          case 2:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            *(uint32 *)(lVar6 + 32) = 2;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = lVar1.Forces;
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 != null) &&
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                puVar12 = local_e8;
                goto LAB_180a5ebc7;
              }
              goto LAB_180a5fc39;
            }
            if (((lVar6 == null) ||
                (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            plVar7 = (int64 *)AreaData.GetForceColor(local_f8,*(int64 *)(lVar6 + 24),0);
            break;
          case 3:
            QuickTravelUIController.SetRoadsActive(this,1,0);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_1802106e0(0);
            fVar15 = local_270;
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null
                ) || (lVar6 = HeroData.GetForce(lVar6,0,0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              lVar6 = FUN_1802109d0(0);
              fVar15 = local_270;
              if (lVar6 == null) goto LAB_180a5fc39;
              if (*(int *)(lVar6 + 32) != 0) {
                if (((this.areaIcons == null) ||
                    (lVar6 = GameObject.get_transform(this.areaIcons,0),
                    fVar15 = local_270, lVar6 == null)) ||
                   ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                    ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                     || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
                iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
                lVar6 = FUN_1802109d0(0);
                fVar15 = local_270;
                if (lVar6 == null) goto LAB_180a5fc39;
                if (iVar4 == *(int *)(lVar6 + 192)) {
                  if (((this.areaIcons != null) &&
                      (lVar6 = GameObject.get_transform(this.areaIcons,0),
                      fVar15 = local_270, lVar6 != null)) &&
                     (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                    plVar7 = (int64 *)Color.get_red(local_c8,0);
                    fVar15 = local_270;
                    if (plVar5 != (int64 *)0) {
                      local_298 = *plVar7;
                      uStack_290 = (uint32)plVar7[1];
                      uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                      (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                      fVar15 = local_270;
                      if (((this.areaIcons != null) &&
                          (lVar6 = GameObject.get_transform(this.areaIcons,0),
                          fVar15 = local_270, lVar6 != null)) &&
                         ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                          (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null))) {
                        *(uint32 *)(lVar6 + 32) = 3;
                        goto switchD_180a5dbbe_default;
                      }
                    }
                  }
                  goto LAB_180a5fc39;
                }
              }
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  (((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                    || (*(int64 *)(lVar6 + 24) == 0)) || (local_250 == 0)))))) goto LAB_180a5fc39;
              cVar2 = FUN_18176a2d0(local_250,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181e71570);
              lVar6 = lVar1.Forces;
              fVar15 = local_270;
              if (cVar2) {
                if (((lVar6 != null) &&
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  plVar7 = (int64 *)Color.get_yellow(local_98,0);
                  fVar15 = local_270;
                  if (plVar5 != (int64 *)0) {
                    local_298 = *plVar7;
                    uStack_290 = (uint32)plVar7[1];
                    uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                    fVar15 = local_270;
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0),
                        fVar15 = local_270, lVar6 != null)) &&
                       ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                        (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null))) {
                      *(uint32 *)(lVar6 + 32) = 3;
                      goto switchD_180a5dbbe_default;
                    }
                  }
                }
                goto LAB_180a5fc39;
              }
              if (((((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))) || (lVar9 == null)) goto LAB_180a5fc39;
              cVar2 = FUN_18176a2d0(lVar9,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181e71570);
              lVar6 = lVar1.Forces;
              if (!cVar2) {
                if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                plVar7 = (int64 *)FUN_180f24b80(local_b8,0);
              }
              else {
                fVar15 = local_270;
                if (((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
                goto LAB_180a5fc39;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                plVar7 = (int64 *)Color.get_blue(local_a8,0);
              }
              if (plVar5 != (int64 *)0) {
                local_298 = *plVar7;
                uStack_290 = (uint32)plVar7[1];
                uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14)) != null) {
                  lVar6 = Component.GetComponent(lVar6);
                  goto joined_r0x000180a5f58f;
                }
              }
              goto LAB_180a5fc33;
            }
            if (((this.areaIcons != null) &&
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)Color.get_green(local_d8,0);
              goto LAB_180a5fb14;
            }
            goto LAB_180a5fc33;
          case 4:
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
               ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 != null &&
                (*(int64 *)(lVar6 + 24) != 0)))) {
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 != null &&
                  (lVar6 = HeroData.GetForce(lVar6,0,0)) != null))) {
                if (iVar4 == *(int *)(lVar6 + 16)) {
                  if ((((this.areaIcons == null) ||
                       (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
                      || (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
                     ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 == null ||
                      (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180a5fc33;
                  if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null)
                       && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                      plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                      plVar7 = (int64 *)Color.get_green(local_88,0);
                      if (plVar5 != (int64 *)0) {
                        local_298 = *plVar7;
                        uStack_290 = (uint32)plVar7[1];
                        uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                        if ((((this.areaIcons != null) &&
                             (lVar6 = GameObject.get_transform(this.areaIcons,0),
                             lVar6 != null)) && (lVar6 = Transform.GetChild(lVar6,plVar14)) != null) &&
                           (lVar6 = Component.GetComponent(lVar6)) != null) {
                          *(uint32 *)(lVar6 + 32) = 4;
                          goto switchD_180a5dbbe_default;
                        }
                      }
                    }
                    goto LAB_180a5fc33;
                  }
                }
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  puVar13 = local_78;
                  goto LAB_180a5fb0a;
                }
              }
            }
            goto LAB_180a5fc33;
          case 5:
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) {
        LAB_180a5fc33:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_1802106e0(0);
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
               (lVar6 = HeroData.GetForce(lVar6,0,0)) == null) goto LAB_180a5fc33;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 == null ||
                   (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
              if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  plVar7 = (int64 *)Color.get_green(local_68,0);
                  if (plVar5 != (int64 *)0) {
                    local_298 = *plVar7;
                    uStack_290 = (uint32)plVar7[1];
                    uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null)
                       && ((lVar6 = Transform.GetChild(lVar6,plVar14), lVar6 != null &&
                           (lVar6 = Component.GetComponent(lVar6)) != null))) {
                      *(uint32 *)(lVar6 + 32) = 5;
                      goto switchD_180a5dbbe_default;
                    }
                  }
                }
                goto LAB_180a5fc33;
              }
            }
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            puVar13 = &local_230;
        LAB_180a5fb0a:
            plVar7 = (int64 *)FUN_180f24b80(puVar13,0);
        LAB_180a5fb14:
            if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
            local_298 = *plVar7;
            uStack_290 = (uint32)plVar7[1];
            uStack_28c = *(uint32 *)((int64)plVar7 + 12);
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
            if ((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
            goto LAB_180a5fc33;
            lVar6 = Transform.GetChild(lVar6,plVar14);
            goto joined_r0x000180a5e17c;
          default:
            goto switchD_180a5dbbe_default;
          }
          fVar15 = local_270;
          if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
        LAB_180a5ebda:
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        switchD_180a5dbbe_default:
          plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
          lVar6 = this.areaIcons;
          goto joined_r0x000180a5d1c1;
        }
        if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
           (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180a5fc33;
        uVar8 = Component.GetComponent(lVar6,DAT_181e781b8);
        cVar2 = Object.op_Inequality(uVar8,0);
        if (!cVar2) {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180a5fc33;
          uVar8 = Component.GetComponent(lVar6);
          cVar2 = Object.op_Inequality(uVar8);
          if (!cVar2) goto switchD_180a5dbbe_default;
          lVar6 = lVar1.Forces;
          if (this.quickTravelUIType != 2) {
            if (((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)FUN_180f24b80(&local_288,0);
              if (plVar5 != (int64 *)0) {
                local_298 = *plVar7;
                uStack_290 = (uint32)plVar7[1];
                uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                if ((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) {
                  lVar6 = Transform.GetChild(lVar6,plVar14);
                  goto joined_r0x000180a5e17c;
                }
              }
            }
            goto LAB_180a5fc33;
          }
          if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24d00(&local_278,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14), lVar6 == null ||
              (lVar6 = Component.GetComponent(lVar6)) == null))) goto LAB_180a5fc33;
          *(uint32 *)(lVar6 + 32) = 2;
          goto switchD_180a5dbbe_default;
        }
        lVar6 = FUN_1802106e0(0);
        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180a5fc33;
        cVar2 = HeroData.HaveForce(lVar6,0);
        if (!cVar2) {
        LAB_180a5db0e:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          puVar12 = local_1f8;
        LAB_180a5db73:
          plVar7 = (int64 *)FUN_180af4e90(puVar12,0);
        LAB_180a5db7d:
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        else {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) goto LAB_180a5db0e;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 48);
          lVar6 = FUN_1802106e0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180a5fc33;
          if (iVar4 != *(int *)(lVar6 + 132)) {
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                 ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 != null &&
                  (*(int64 *)(lVar6 + 24) != 0)))))) &&
               (lVar6 = ResourcePointData.GetForce(*(int64 *)(lVar6 + 24),0)) != null) {
              iVar4 = *(int *)(lVar6 + 60);
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180a5da6d;
                lVar6 = FUN_1802106e0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  lVar6 = HeroData.GetForce(lVar6,0,0);
                  if (((((this.areaIcons != null) &&
                        (lVar10 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null) &&
                      ((lVar10 = Component.GetComponent(lVar10,DAT_181e781b8), lVar10 != null &&
                       (*(int64 *)(lVar10 + 24) != 0)))) && (lVar6 != null)) {
                    fVar15 = (float)ForceData.GetForceFavor
                                              (lVar6,*(uint32 *)(*(int64 *)(lVar10 + 24) + 48),
                                               0);
                    if (80.0 <= fVar15) {
                      if (((this.areaIcons != null) &&
                          (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null
                          ) && ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                        plVar7 = (int64 *)Color.get_blue(local_208,0);
                        goto LAB_180a5db7d;
                      }
                    }
                    else {
                      lVar6 = FUN_1802106e0(0);
                      if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                         (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                        lVar6 = HeroData.GetForce(lVar6,0,0);
                        if ((((this.areaIcons != null) &&
                             (lVar10 = GameObject.get_transform(this.areaIcons,0),
                             lVar10 != null)) &&
                            ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                             ((lVar10 = Component.GetComponent(lVar10,DAT_181e781b8), lVar10 != null &&
                              (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar6 != null)) {
                          fVar15 = (float)ForceData.GetForceFavor
                                                    (lVar6,*(uint32 *)
                                                            (*(int64 *)(lVar10 + 24) + 48),0);
                          lVar6 = lVar1.Forces;
                          if (fVar15 < 40.0) {
                            if ((((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null
                                 ) && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
                               (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                              lVar6 = pStatics_38e8;
                              if (plVar5 != (int64 *)0) {
                                uVar3 = *(uint32 *)(lVar6 + 0x2f8);
                                uVar17 = *(uint32 *)(lVar6 + 0x2fc);
                                uStack_290 = *(uint32 *)(lVar6 + 0x300);
                                uStack_28c = *(uint32 *)(lVar6 + 0x304);
                                goto LAB_180a5d9d7;
                              }
                            }
                          }
                          else if (((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
                                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                   (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                            puVar12 = local_240;
                            goto LAB_180a5db73;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180a5fc33;
          }
        LAB_180a5da6d:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          lVar6 = pStatics_38e8;
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          uVar3 = *(uint32 *)(lVar6 + 0x290);
          uVar17 = *(uint32 *)(lVar6 + 0x294);
          uStack_290 = *(uint32 *)(lVar6 + 0x298);
          uStack_28c = *(uint32 *)(lVar6 + 0x29c);
        LAB_180a5d9d7:
          local_298 = CONCAT44(uVar17,uVar3);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        switch(this.quickTravelUIType) {
        case 0:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181e781b8)) == null) goto LAB_180a5fc33;
          *(uint32 *)(lVar6 + 32) = 0;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          lVar10 = lVar1.Forces;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) != -1) {
            if (((lVar10 != null) && (lVar6 = GameObject.get_transform(lVar10,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              if (((this.areaIcons != null) &&
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 != null &&
                   (*(int64 *)(lVar6 + 24) != 0)))))) {
                plVar7 = (int64 *)
                         ResourcePointData.GetForceColor(local_1e8,*(int64 *)(lVar6 + 24),0);
                goto joined_r0x000180a5dd7f;
              }
            }
            goto LAB_180a5fc33;
          }
          if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24d00(local_1d8,0);
          goto joined_r0x000180a5dd7f;
        case 1:
          if (((this.areaIcons != null) &&
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            plVar7 = (int64 *)FUN_180f24b80(local_1c8,0);
            if (plVar5 != (int64 *)0) {
              local_298 = *plVar7;
              uStack_290 = (uint32)plVar7[1];
              uStack_28c = *(uint32 *)((int64)plVar7 + 12);
              (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
              if ((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) {
                lVar6 = Transform.GetChild(lVar6,plVar14);
                break;
              }
            }
          }
          goto LAB_180a5fc33;
        case 2:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181e781b8)) == null) goto LAB_180a5fc33;
          *(uint32 *)(lVar6 + 32) = 2;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          lVar10 = lVar1.Forces;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            plVar7 = (int64 *)FUN_180f24d00(local_1a8,0);
          }
          else {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
            plVar7 = (int64 *)ResourcePointData.GetForceColor(local_1b8,*(int64 *)(lVar6 + 24),0)
            ;
          }
        joined_r0x000180a5dd7f:
          if (plVar5 != (int64 *)0) goto LAB_180a5ebda;
          goto LAB_180a5fc33;
        case 3:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24b80(local_198,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180a5fc33;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 4:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24b80(local_188,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180a5fc33;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 5:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24b80(local_178,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180a5fc33;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        default:
          goto switchD_180a5dbbe_default;
        }
        joined_r0x000180a5e17c:
        if (lVar6 != null) {
          lVar6 = Component.GetComponent(lVar6);
        joined_r0x000180a5f58f:
          if (lVar6 != null) {
        LAB_180a5fb89:
            *(uint32 *)(lVar6 + 32) = 0;
            goto switchD_180a5dbbe_default;
          }
        }
        goto LAB_180a5fc33;
    }

    // Token : 0x60020E3
    // RVA   : 0xA5C820   Offset: 0xA5B620   Length: 0x3420
    public void ShowQuickTravelUI(QuickTravelUIType targetTravelUIType, float scale, bool _autoClose)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        void QuickTravelUIController.ShowQuickTravelUI
                     (int64 this,uint32 targetTravelUIType,int64 scale,uint8 _autoClose)
        {
        int64 lVar1;
        char cVar2;
        uint32 uVar3;
        int iVar4;
        int64 *plVar5;
        int64 lVar6;
        int64 *plVar7;
        uint64 uVar8;
        int64 lVar9;
        int64 lVar10;
        uint64 uVar11;
        uint8 *puVar12;
        uint32 *puVar13;
        int64 *plVar14;
        float fVar15;
        float fVar16;
        uint32 uVar17;
        uint64 local_298;
        uint32 uStack_290;
        uint32 uStack_28c;
        uint64 local_288;
        int64 lStack_280;
        int64 local_278;
        float local_270;
        uint64 local_268;
        uint64 uStack_260;
        int64 local_258;
        int64 local_250;
        uint8 local_240 [16];
        uint32 local_230;
        uint32 uStack_22c;
        uint32 uStack_228;
        uint32 uStack_224;
        int64 local_220;
        uint8 local_208 [16];
        uint8 local_1f8 [16];
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
        local_298 = this;
        local_268 = 0;
        uStack_260 = 0;
        local_258 = 0;
        plVar14 = (int64 *)0;
        plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar7 = plVar14;
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
          plVar7 = plVar5;
        }
        NGUITools.PlaySound(plVar7,0);
        fVar15 = local_270;
        if (this.quickTravelUI == null) {
        LAB_180a5fc39:
          local_270 = fVar15;
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameObject.SetActive(this.quickTravelUI,1,0);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180a5fc39;
        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           ((lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270, lVar6 == null ||
            (plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8), fVar15 = local_270,
            plVar7 == (int64 *)0)))) goto LAB_180a5fc39;
        plVar7 = (int64 *)
                 (**(code **)(*plVar7 + 0x298))(&local_288,plVar7,*(uint64 *)(*plVar7 + 0x2a0));
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        plVar7 = (int64 *)GlobalData.SetColorAlpha(&local_278,&local_288,0,0);
        fVar15 = local_270;
        if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_288,*(uint64 *)(*plVar5 + 0x2b0));
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180a5fc39;
        uVar8 = Component.GetComponent(lVar6,DAT_181e777b8);
        uVar8 = DOTweenModuleUI.DOFade(uVar8,0x3f000000,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea5848);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"MapRoot",0), fVar15 = local_270) == null)
        goto LAB_180a5fc39;
        local_288 = scale << 32;
        lStack_280 = CONCAT44(lStack_280._4_4_,(int)scale);
        Transform.set_localScale(lVar6,&local_288,0);
        fVar15 = local_270;
        if ((this.quickTravelUI == null) ||
           (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
           lVar6 == null)) goto LAB_180a5fc39;
        uVar8 = Transform.Find(lVar6,"MapRoot",0);
        uVar8 = ShortcutExtensions.DOScaleX(uVar8,scale,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea59e0);
        this.quickTravelUIType = targetTravelUIType;
        fVar15 = local_270;
        if (this.playerIcon == null) goto LAB_180a5fc39;
        lVar6 = GameObject.get_transform(this.playerIcon,0);
        fVar16 = this.BaseMapScale;
        fVar15 = local_270;
        if ((((GameController._instance == null) ||
             (lVar9 = GameController._instance.worldData) == null) ||
            (lVar9 = WorldData.Player(lVar9,0), fVar15 = local_270) == null) ||
           (lVar9.playerServantForceTime == 0)) goto LAB_180a5fc39;
        plVar5 = (int64 *)BigMapPos.ToVector3(local_240,lVar9.playerServantForceTime,0x3f800000,0);
        local_250 = *plVar5;
        local_288 = CONCAT44((float)((uint64)local_250 >> 32) * fVar16,(float)local_250 * fVar16);
        local_270 = *(float *)(plVar5 + 1) * fVar16;
        lStack_280 = CONCAT44((int)((uint64)lStack_280 >> 32),local_270);
        local_278 = local_250;
        fVar15 = *(float *)(plVar5 + 1);
        if (lVar6 == null) goto LAB_180a5fc39;
        local_278 = local_288;
        Transform.set_localPosition(lVar6,&local_278,0);
        this.autoClose = _autoClose;
        lVar6 = il2cpp_internal(DAT_181e73cb8);
        local_250 = lVar6;
        FUN_1810f3480(lVar6,DAT_181e71270);
        local_278 = lVar6;
        lVar9 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar9,DAT_181e71270);
        local_288 = lVar9;
        if (this.quickTravelUIType == 3) {
          fVar15 = local_270;
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (lVar1 = lVar1.Areas) == null) goto LAB_180a5fc39;
          FUN_1816629a0(&local_230,lVar1,DAT_181e5e548);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
          while (cVar2 = FUN_1807b3f30(&local_268,DAT_181e6b948), lVar1 = local_258, cVar2) {
            if (local_258 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = AreaData.BelongPlayerOrAlley(local_258,0);
            if (cVar2) {
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              FUN_181769fe0(lVar9,lVar1.chapter,DAT_181e713f0);
            }
          }
          ZhSegment.Initialize(&local_268,DAT_181e6b8c8);
          fVar15 = local_270;
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (lVar1 = lVar1.Areas) == null) goto LAB_180a5fc39;
          FUN_1816629a0(&local_230,lVar1,DAT_181e5e548);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
        LAB_180a5d062:
          cVar2 = FUN_1807b3f30(&local_268,DAT_181e6b948);
          lVar1 = local_258;
          if (cVar2) {
            lVar10 = FUN_1802106e0(0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(int64 *)(lVar10 + 32) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0);
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar10 = HeroData.GetForce(lVar10,0);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = ForceData.CanAttack(lVar10,lVar1.lastRandomWorldEventDay);
            plVar5 = plVar14;
            if (cVar2) {
              while( true ) {
                lVar10 = lVar1.cheating;
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                if (*(int *)(lVar10 + 24) <= (int)plVar5) goto LAB_180a5d062;
                uVar3 = FUN_180002480(lVar10,plVar5,DAT_181e71bf0);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                cVar2 = FUN_18176a2d0(lVar9,uVar3);
                if (cVar2) break;
                plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              }
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              FUN_181769fe0(lVar6,lVar1.chapter);
            }
            goto LAB_180a5d062;
          }
          ZhSegment.Initialize(&local_268,DAT_181e6b8c8);
        }
        lVar1 = local_298;
        lVar6 = this.areaIcons;
        joined_r0x000180a5d1c1:
        if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) goto LAB_180a5fc33;
        iVar4 = Transform.get_childCount(lVar6,0);
        if (iVar4 <= (int)plVar14) {
          QuickTravelUIController.RefreshAllAreaState(this,0);
          QuickTravelUIController.RefreshAllResourceState(this,0);
          QuickTravelUIController.RefreshAllInnState(this,0);
          return;
        }
        fVar15 = local_270;
        if (((this.areaIcons == null) ||
            (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
            lVar6 == null)) || (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null
           ) goto LAB_180a5fc39;
        uVar8 = Component.GetComponent(lVar6,DAT_181e780b8);
        cVar2 = Object.op_Inequality(uVar8,0);
        lVar6 = lVar1.Forces;
        if (cVar2) {
          fVar15 = local_270;
          if (((lVar6 == null) ||
              (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
              ((lVar6 = Transform.Find(lVar6,"AreaNameBack",0), fVar15 = local_270, lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"AreaName",0), fVar15 = local_270) == null)))))
          goto LAB_180a5fc39;
          uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
          fVar15 = local_270;
          if ((this.areaIcons == null) ||
             ((((lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270) == null) ||
              (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180a5fc39;
          uVar11 = AreaData.GetAreaName(*(int64 *)(lVar6 + 24),0);
          LTLocalization.SetText(uVar8,uVar11,0);
          lVar6 = FUN_1802106e0(0);
          fVar15 = local_270;
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
          goto LAB_180a5fc39;
          cVar2 = HeroData.HaveForce(lVar6,0);
          if (!cVar2) {
        LAB_180a5e963:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            puVar12 = local_158;
        LAB_180a5e9c8:
            plVar7 = (int64 *)FUN_180af4e90(puVar12,0);
        LAB_180a5e9d2:
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
            local_298 = *plVar7;
            uStack_290 = (uint32)plVar7[1];
            uStack_28c = *(uint32 *)((int64)plVar7 + 12);
            (**(code **)(*plVar5 + 0x2a8))(plVar5);
          }
          else {
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            if (!cVar2) goto LAB_180a5e963;
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_1802106e0(0);
            fVar15 = local_270;
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            if (iVar4 != *(int *)(lVar6 + 132)) {
              if ((((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270
                   , lVar6 != null)) &&
                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 != null &&
                   ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 != null
                    && (*(int64 *)(lVar6 + 24) != 0)))))) &&
                 (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 24),0), fVar15 = local_270,
                 lVar6 != null)) {
                iVar4 = *(int *)(lVar6 + 60);
                lVar6 = FUN_1802106e0(0);
                fVar15 = local_270;
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                   lVar6 != null)) {
                  if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180a5e8c2;
                  lVar6 = FUN_1802106e0(0);
                  fVar15 = local_270;
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                     lVar6 != null)) {
                    lVar6 = HeroData.GetForce(lVar6,0,0);
                    fVar15 = local_270;
                    if (((((this.areaIcons != null) &&
                          (lVar10 = GameObject.get_transform(this.areaIcons,0),
                          fVar15 = local_270, lVar10 != null)) &&
                         (lVar10 = Transform.GetChild(lVar10,plVar14,0), fVar15 = local_270) != null
                         ) && ((lVar10 = Component.GetComponent(lVar10,DAT_181e780b8), fVar15 = local_270
                               , lVar10 != null && (*(int64 *)(lVar10 + 24) != 0)))) && (lVar6 != null)) {
                      fVar15 = (float)ForceData.GetForceFavor
                                                (lVar6,*(uint32 *)
                                                        (*(int64 *)(lVar10 + 24) + 112),0);
                      if (80.0 <= fVar15) {
                        fVar15 = local_270;
                        if (((this.areaIcons != null) &&
                            (lVar6 = GameObject.get_transform(this.areaIcons,0),
                            fVar15 = local_270, lVar6 != null)) &&
                           ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 != null
                            && (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                               lVar6 != null)))) {
                          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                          plVar7 = (int64 *)Color.get_blue(local_58,0);
                          goto LAB_180a5e9d2;
                        }
                      }
                      else {
                        lVar6 = FUN_1802106e0(0);
                        fVar15 = local_270;
                        if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                           lVar6 != null)) {
                          lVar6 = HeroData.GetForce(lVar6,0,0);
                          fVar15 = local_270;
                          if ((((this.areaIcons != null) &&
                               (lVar10 = GameObject.get_transform(this.areaIcons,0),
                               fVar15 = local_270, lVar10 != null)) &&
                              ((lVar10 = Transform.GetChild(lVar10,plVar14,0), fVar15 = local_270,
                               lVar10 != null &&
                               ((lVar10 = Component.GetComponent(lVar10,DAT_181e780b8),
                                fVar15 = local_270, lVar10 != null && (*(int64 *)(lVar10 + 24) != 0)))))
                              ) && (lVar6 != null)) {
                            fVar16 = (float)ForceData.GetForceFavor
                                                      (lVar6,*(uint32 *)
                                                              (*(int64 *)(lVar10 + 24) + 112),0);
                            lVar6 = lVar1.Forces;
                            fVar15 = local_270;
                            if (fVar16 < 40.0) {
                              if ((((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270,
                                   lVar6 != null)) &&
                                  (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270,
                                  lVar6 != null)) &&
                                 (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                                 lVar6 != null)) {
                                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                                lVar6 = pStatics_38e8;
                                fVar15 = local_270;
                                if (plVar5 != (int64 *)0) {
                                  uVar3 = *(uint32 *)(lVar6 + 0x2f8);
                                  uVar17 = *(uint32 *)(lVar6 + 0x2fc);
                                  uStack_290 = *(uint32 *)(lVar6 + 0x300);
                                  uStack_28c = *(uint32 *)(lVar6 + 0x304);
                                  goto LAB_180a5e82c;
                                }
                              }
                            }
                            else if (((lVar6 != null) &&
                                     (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270,
                                     lVar6 != null)) &&
                                    ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270,
                                     lVar6 != null &&
                                     (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                                     lVar6 != null)))) {
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                              puVar12 = local_168;
                              goto LAB_180a5e9c8;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_180a5fc39;
            }
        LAB_180a5e8c2:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            lVar6 = pStatics_38e8;
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
            uVar3 = *(uint32 *)(lVar6 + 0x290);
            uVar17 = *(uint32 *)(lVar6 + 0x294);
            uStack_290 = *(uint32 *)(lVar6 + 0x298);
            uStack_28c = *(uint32 *)(lVar6 + 0x29c);
        LAB_180a5e82c:
            local_298 = CONCAT44(uVar17,uVar3);
            (**(code **)(*plVar5 + 0x2a8))(plVar5);
          }
          fVar15 = local_270;
          switch(this.quickTravelUIType) {
          case 0:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            *(uint32 *)(lVar6 + 32) = 0;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = lVar1.Forces;
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              puVar12 = local_138;
        LAB_180a5ebc7:
              plVar7 = (int64 *)FUN_180f24d00(puVar12,0);
            }
            else {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
              plVar7 = (int64 *)AreaData.GetForceColor(local_148,*(int64 *)(lVar6 + 24),0);
            }
            break;
          case 1:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180a5fc39;
            lVar10 = lVar1.Forces;
            if (*(int *)(*(int64 *)(lVar6 + 24) + 72) == 0) {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
              lVar6 = FUN_1802106e0(0);
              fVar15 = local_270;
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270, lVar6 == null
                 )) goto LAB_180a5fc39;
              lVar10 = lVar1.Forces;
              if (iVar4 != *(int *)(lVar6 + 192)) {
                if (((lVar10 != null) &&
                    (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  plVar7 = (int64 *)Color.get_green(local_118,0);
                  fVar15 = local_270;
                  if (plVar5 != (int64 *)0) {
                    local_298 = *plVar7;
                    uStack_290 = (uint32)plVar7[1];
                    uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                    fVar15 = local_270;
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0),
                        fVar15 = local_270, lVar6 != null)) &&
                       ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                        (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null))) {
                      *(uint32 *)(lVar6 + 32) = 1;
                      goto switchD_180a5dbbe_default;
                    }
                  }
                }
                goto LAB_180a5fc39;
              }
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)Color.get_red(local_108,0);
            }
            else {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180a5fc39;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)FUN_180f24b80(local_128,0);
            }
            fVar15 = local_270;
            if (plVar5 != (int64 *)0) {
              local_298 = *plVar7;
              uStack_290 = (uint32)plVar7[1];
              uStack_28c = *(uint32 *)((int64)plVar7 + 12);
              (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
              fVar15 = local_270;
              if (((this.areaIcons != null) &&
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 != null)) &&
                 ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                  (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null)))
              goto LAB_180a5fb89;
            }
            goto LAB_180a5fc39;
          case 2:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            *(uint32 *)(lVar6 + 32) = 2;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = lVar1.Forces;
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 != null) &&
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                puVar12 = local_e8;
                goto LAB_180a5ebc7;
              }
              goto LAB_180a5fc39;
            }
            if (((lVar6 == null) ||
                (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            plVar7 = (int64 *)AreaData.GetForceColor(local_f8,*(int64 *)(lVar6 + 24),0);
            break;
          case 3:
            QuickTravelUIController.SetRoadsActive(this,1,0);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_1802106e0(0);
            fVar15 = local_270;
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null
                ) || (lVar6 = HeroData.GetForce(lVar6,0,0), fVar15 = local_270) == null)
            goto LAB_180a5fc39;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              lVar6 = FUN_1802109d0(0);
              fVar15 = local_270;
              if (lVar6 == null) goto LAB_180a5fc39;
              if (*(int *)(lVar6 + 32) != 0) {
                if (((this.areaIcons == null) ||
                    (lVar6 = GameObject.get_transform(this.areaIcons,0),
                    fVar15 = local_270, lVar6 == null)) ||
                   ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                    ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                     || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc39;
                iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
                lVar6 = FUN_1802109d0(0);
                fVar15 = local_270;
                if (lVar6 == null) goto LAB_180a5fc39;
                if (iVar4 == *(int *)(lVar6 + 192)) {
                  if (((this.areaIcons != null) &&
                      (lVar6 = GameObject.get_transform(this.areaIcons,0),
                      fVar15 = local_270, lVar6 != null)) &&
                     (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                    plVar7 = (int64 *)Color.get_red(local_c8,0);
                    fVar15 = local_270;
                    if (plVar5 != (int64 *)0) {
                      local_298 = *plVar7;
                      uStack_290 = (uint32)plVar7[1];
                      uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                      (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                      fVar15 = local_270;
                      if (((this.areaIcons != null) &&
                          (lVar6 = GameObject.get_transform(this.areaIcons,0),
                          fVar15 = local_270, lVar6 != null)) &&
                         ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                          (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null))) {
                        *(uint32 *)(lVar6 + 32) = 3;
                        goto switchD_180a5dbbe_default;
                      }
                    }
                  }
                  goto LAB_180a5fc39;
                }
              }
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  (((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                    || (*(int64 *)(lVar6 + 24) == 0)) || (local_250 == 0)))))) goto LAB_180a5fc39;
              cVar2 = FUN_18176a2d0(local_250,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181e71570);
              lVar6 = lVar1.Forces;
              fVar15 = local_270;
              if (cVar2) {
                if (((lVar6 != null) &&
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  plVar7 = (int64 *)Color.get_yellow(local_98,0);
                  fVar15 = local_270;
                  if (plVar5 != (int64 *)0) {
                    local_298 = *plVar7;
                    uStack_290 = (uint32)plVar7[1];
                    uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                    fVar15 = local_270;
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0),
                        fVar15 = local_270, lVar6 != null)) &&
                       ((lVar6 = Transform.GetChild(lVar6,plVar14), fVar15 = local_270, lVar6 != null &&
                        (lVar6 = Component.GetComponent(lVar6), fVar15 = local_270) != null))) {
                      *(uint32 *)(lVar6 + 32) = 3;
                      goto switchD_180a5dbbe_default;
                    }
                  }
                }
                goto LAB_180a5fc39;
              }
              if (((((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))) || (lVar9 == null)) goto LAB_180a5fc39;
              cVar2 = FUN_18176a2d0(lVar9,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181e71570);
              lVar6 = lVar1.Forces;
              if (!cVar2) {
                if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                plVar7 = (int64 *)FUN_180f24b80(local_b8,0);
              }
              else {
                fVar15 = local_270;
                if (((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
                goto LAB_180a5fc39;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                plVar7 = (int64 *)Color.get_blue(local_a8,0);
              }
              if (plVar5 != (int64 *)0) {
                local_298 = *plVar7;
                uStack_290 = (uint32)plVar7[1];
                uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14)) != null) {
                  lVar6 = Component.GetComponent(lVar6);
                  goto joined_r0x000180a5f58f;
                }
              }
              goto LAB_180a5fc33;
            }
            if (((this.areaIcons != null) &&
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)Color.get_green(local_d8,0);
              goto LAB_180a5fb14;
            }
            goto LAB_180a5fc33;
          case 4:
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
               ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 != null &&
                (*(int64 *)(lVar6 + 24) != 0)))) {
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 != null &&
                  (lVar6 = HeroData.GetForce(lVar6,0,0)) != null))) {
                if (iVar4 == *(int *)(lVar6 + 16)) {
                  if ((((this.areaIcons == null) ||
                       (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
                      || (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
                     ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 == null ||
                      (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180a5fc33;
                  if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null)
                       && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                      plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                      plVar7 = (int64 *)Color.get_green(local_88,0);
                      if (plVar5 != (int64 *)0) {
                        local_298 = *plVar7;
                        uStack_290 = (uint32)plVar7[1];
                        uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                        if ((((this.areaIcons != null) &&
                             (lVar6 = GameObject.get_transform(this.areaIcons,0),
                             lVar6 != null)) && (lVar6 = Transform.GetChild(lVar6,plVar14)) != null) &&
                           (lVar6 = Component.GetComponent(lVar6)) != null) {
                          *(uint32 *)(lVar6 + 32) = 4;
                          goto switchD_180a5dbbe_default;
                        }
                      }
                    }
                    goto LAB_180a5fc33;
                  }
                }
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  puVar13 = local_78;
                  goto LAB_180a5fb0a;
                }
              }
            }
            goto LAB_180a5fc33;
          case 5:
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) {
        LAB_180a5fc33:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_1802106e0(0);
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
               (lVar6 = HeroData.GetForce(lVar6,0,0)) == null) goto LAB_180a5fc33;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e780b8), lVar6 == null ||
                   (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
              if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                  plVar7 = (int64 *)Color.get_green(local_68,0);
                  if (plVar5 != (int64 *)0) {
                    local_298 = *plVar7;
                    uStack_290 = (uint32)plVar7[1];
                    uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                    (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null)
                       && ((lVar6 = Transform.GetChild(lVar6,plVar14), lVar6 != null &&
                           (lVar6 = Component.GetComponent(lVar6)) != null))) {
                      *(uint32 *)(lVar6 + 32) = 5;
                      goto switchD_180a5dbbe_default;
                    }
                  }
                }
                goto LAB_180a5fc33;
              }
            }
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            puVar13 = &local_230;
        LAB_180a5fb0a:
            plVar7 = (int64 *)FUN_180f24b80(puVar13,0);
        LAB_180a5fb14:
            if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
            local_298 = *plVar7;
            uStack_290 = (uint32)plVar7[1];
            uStack_28c = *(uint32 *)((int64)plVar7 + 12);
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
            if ((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
            goto LAB_180a5fc33;
            lVar6 = Transform.GetChild(lVar6,plVar14);
            goto joined_r0x000180a5e17c;
          default:
            goto switchD_180a5dbbe_default;
          }
          fVar15 = local_270;
          if (plVar5 == (int64 *)0) goto LAB_180a5fc39;
        LAB_180a5ebda:
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        switchD_180a5dbbe_default:
          plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
          lVar6 = this.areaIcons;
          goto joined_r0x000180a5d1c1;
        }
        if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
           (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180a5fc33;
        uVar8 = Component.GetComponent(lVar6,DAT_181e781b8);
        cVar2 = Object.op_Inequality(uVar8,0);
        if (!cVar2) {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180a5fc33;
          uVar8 = Component.GetComponent(lVar6);
          cVar2 = Object.op_Inequality(uVar8);
          if (!cVar2) goto switchD_180a5dbbe_default;
          lVar6 = lVar1.Forces;
          if (this.quickTravelUIType != 2) {
            if (((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              plVar7 = (int64 *)FUN_180f24b80(&local_288,0);
              if (plVar5 != (int64 *)0) {
                local_298 = *plVar7;
                uStack_290 = (uint32)plVar7[1];
                uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                if ((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) {
                  lVar6 = Transform.GetChild(lVar6,plVar14);
                  goto joined_r0x000180a5e17c;
                }
              }
            }
            goto LAB_180a5fc33;
          }
          if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24d00(&local_278,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14), lVar6 == null ||
              (lVar6 = Component.GetComponent(lVar6)) == null))) goto LAB_180a5fc33;
          *(uint32 *)(lVar6 + 32) = 2;
          goto switchD_180a5dbbe_default;
        }
        lVar6 = FUN_1802106e0(0);
        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180a5fc33;
        cVar2 = HeroData.HaveForce(lVar6,0);
        if (!cVar2) {
        LAB_180a5db0e:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          puVar12 = local_1f8;
        LAB_180a5db73:
          plVar7 = (int64 *)FUN_180af4e90(puVar12,0);
        LAB_180a5db7d:
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        else {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) goto LAB_180a5db0e;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 48);
          lVar6 = FUN_1802106e0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180a5fc33;
          if (iVar4 != *(int *)(lVar6 + 132)) {
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                 ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 != null &&
                  (*(int64 *)(lVar6 + 24) != 0)))))) &&
               (lVar6 = ResourcePointData.GetForce(*(int64 *)(lVar6 + 24),0)) != null) {
              iVar4 = *(int *)(lVar6 + 60);
              lVar6 = FUN_1802106e0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180a5da6d;
                lVar6 = FUN_1802106e0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  lVar6 = HeroData.GetForce(lVar6,0,0);
                  if (((((this.areaIcons != null) &&
                        (lVar10 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null) &&
                      ((lVar10 = Component.GetComponent(lVar10,DAT_181e781b8), lVar10 != null &&
                       (*(int64 *)(lVar10 + 24) != 0)))) && (lVar6 != null)) {
                    fVar15 = (float)ForceData.GetForceFavor
                                              (lVar6,*(uint32 *)(*(int64 *)(lVar10 + 24) + 48),
                                               0);
                    if (80.0 <= fVar15) {
                      if (((this.areaIcons != null) &&
                          (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null
                          ) && ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                        plVar7 = (int64 *)Color.get_blue(local_208,0);
                        goto LAB_180a5db7d;
                      }
                    }
                    else {
                      lVar6 = FUN_1802106e0(0);
                      if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                         (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                        lVar6 = HeroData.GetForce(lVar6,0,0);
                        if ((((this.areaIcons != null) &&
                             (lVar10 = GameObject.get_transform(this.areaIcons,0),
                             lVar10 != null)) &&
                            ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                             ((lVar10 = Component.GetComponent(lVar10,DAT_181e781b8), lVar10 != null &&
                              (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar6 != null)) {
                          fVar15 = (float)ForceData.GetForceFavor
                                                    (lVar6,*(uint32 *)
                                                            (*(int64 *)(lVar10 + 24) + 48),0);
                          lVar6 = lVar1.Forces;
                          if (fVar15 < 40.0) {
                            if ((((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null
                                 ) && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
                               (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                              lVar6 = pStatics_38e8;
                              if (plVar5 != (int64 *)0) {
                                uVar3 = *(uint32 *)(lVar6 + 0x2f8);
                                uVar17 = *(uint32 *)(lVar6 + 0x2fc);
                                uStack_290 = *(uint32 *)(lVar6 + 0x300);
                                uStack_28c = *(uint32 *)(lVar6 + 0x304);
                                goto LAB_180a5d9d7;
                              }
                            }
                          }
                          else if (((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
                                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                   (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
                            puVar12 = local_240;
                            goto LAB_180a5db73;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180a5fc33;
          }
        LAB_180a5da6d:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          lVar6 = pStatics_38e8;
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          uVar3 = *(uint32 *)(lVar6 + 0x290);
          uVar17 = *(uint32 *)(lVar6 + 0x294);
          uStack_290 = *(uint32 *)(lVar6 + 0x298);
          uStack_28c = *(uint32 *)(lVar6 + 0x29c);
        LAB_180a5d9d7:
          local_298 = CONCAT44(uVar17,uVar3);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        switch(this.quickTravelUIType) {
        case 0:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181e781b8)) == null) goto LAB_180a5fc33;
          *(uint32 *)(lVar6 + 32) = 0;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          lVar10 = lVar1.Forces;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) != -1) {
            if (((lVar10 != null) && (lVar6 = GameObject.get_transform(lVar10,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
              if (((this.areaIcons != null) &&
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 != null &&
                   (*(int64 *)(lVar6 + 24) != 0)))))) {
                plVar7 = (int64 *)
                         ResourcePointData.GetForceColor(local_1e8,*(int64 *)(lVar6 + 24),0);
                goto joined_r0x000180a5dd7f;
              }
            }
            goto LAB_180a5fc33;
          }
          if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24d00(local_1d8,0);
          goto joined_r0x000180a5dd7f;
        case 1:
          if (((this.areaIcons != null) &&
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            plVar7 = (int64 *)FUN_180f24b80(local_1c8,0);
            if (plVar5 != (int64 *)0) {
              local_298 = *plVar7;
              uStack_290 = (uint32)plVar7[1];
              uStack_28c = *(uint32 *)((int64)plVar7 + 12);
              (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
              if ((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) {
                lVar6 = Transform.GetChild(lVar6,plVar14);
                break;
              }
            }
          }
          goto LAB_180a5fc33;
        case 2:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181e781b8)) == null) goto LAB_180a5fc33;
          *(uint32 *)(lVar6 + 32) = 2;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
          lVar10 = lVar1.Forces;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            plVar7 = (int64 *)FUN_180f24d00(local_1a8,0);
          }
          else {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181e781b8), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180a5fc33;
            plVar7 = (int64 *)ResourcePointData.GetForceColor(local_1b8,*(int64 *)(lVar6 + 24),0)
            ;
          }
        joined_r0x000180a5dd7f:
          if (plVar5 != (int64 *)0) goto LAB_180a5ebda;
          goto LAB_180a5fc33;
        case 3:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24b80(local_198,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180a5fc33;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 4:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24b80(local_188,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180a5fc33;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 5:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180a5fc33;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181e777b8);
          plVar7 = (int64 *)FUN_180f24b80(local_178,0);
          if (plVar5 == (int64 *)0) goto LAB_180a5fc33;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180a5fc33;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        default:
          goto switchD_180a5dbbe_default;
        }
        joined_r0x000180a5e17c:
        if (lVar6 != null) {
          lVar6 = Component.GetComponent(lVar6);
        joined_r0x000180a5f58f:
          if (lVar6 != null) {
        LAB_180a5fb89:
            *(uint32 *)(lVar6 + 32) = 0;
            goto switchD_180a5dbbe_default;
          }
        }
        goto LAB_180a5fc33;
    }

    // Token : 0x60020E4
    // RVA   : 0xA60120   Offset: 0xA5EF20   Length: 0xC6
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e71638);
        FUN_1810f3480(lVar1,DAT_181e624f8);
        if (lVar1 != null) {
          FUN_181660e60(lVar1,1,DAT_181e625f8);
          FUN_181660e60(lVar1,1,DAT_181e625f8);
          FUN_181660e60(lVar1,1,DAT_181e625f8);
          this.showAreaType = lVar1;
          this.showInn = 1;
          FUN_180ae8740(this,0);
          return;
        }
    }

    // Token : 0x60020E5
    // RVA   : 0x5EBA30   Offset: 0x5EA830   Length: 0x20
    private void <HideQuickTravelUI>b__49_0()
    {
        if (this.quickTravelUI != null) {
          GameObject.SetActive(this.quickTravelUI,0,0);
          return;
        }
    }

}
