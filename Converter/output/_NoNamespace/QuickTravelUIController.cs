// ============================================================
// Type  : QuickTravelUIController
// Token : 0x2000333
// ============================================================

public class QuickTravelUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A8A
    private bool inited;

    // Token: 0x4001A8B
    public QuickTravelUIType quickTravelUIType;

    // Token: 0x4001A8C
    public GameObject quickTravelUI;

    // Token: 0x4001A8D
    public GameObject playerIcon;

    // Token: 0x4001A8E
    public GameObject quickTravelAreaIcon;

    // Token: 0x4001A8F
    public GameObject quickTravelResourcePointIcon;

    // Token: 0x4001A90
    public GameObject quickTravelInnIcon;

    // Token: 0x4001A91
    public GameObject areaIcons;

    // Token: 0x4001A92
    public GameObject quickTravelRoadPrefab;

    // Token: 0x4001A93
    public GameObject roads;

    // Token: 0x4001A94
    public List<Sprite> areaSprite;

    // Token: 0x4001A95
    public List<Sprite> areaSpriteOutLine;

    // Token: 0x4001A96
    public List<float> areaNameOffset;

    // Token: 0x4001A97
    public List<bool> showAreaType;

    // Token: 0x4001A98
    public bool showResourcePoint;

    // Token: 0x4001A99
    public bool showInn;

    // Token: 0x4001A9A
    public GameObject roadToggleButton;

    // Token: 0x4001A9B
    public Slider scaleSlider;

    // Token: 0x4001A9C
    public List<GameObject> areaObjs;

    // Token: 0x4001A9D
    public List<GameObject> resourceObjs;

    // Token: 0x4001A9E
    public List<GameObject> innObjs;

    // Token: 0x4001A9F
    public GameObject bigmapScaleRoot;

    // Token: 0x4001AA0
    public GameObject bigmapRoot;

    // Token: 0x4001AA1
    public float nowScale;

    // Token: 0x4001AA2
    public float bigMapWidth;

    // Token: 0x4001AA3
    public float bigMapHeight;

    // Token: 0x4001AA4
    private float BaseMapScale;

    // Token: 0x4001AA5
    private bool autoClose;

    // Token: 0x4001AA6
    private static QuickTravelUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600202E
    // RVA   : 0xD06F80   Offset: 0xD06380   Length: 0x36
    public static QuickTravelUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d94000 + 184);
    }

    // Token : 0x600202F
    // RVA   : 0xD01530   Offset: 0xD00930   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d94000 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002030
    // RVA   : 0xD06A30   Offset: 0xD05E30   Length: 0x255
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
                lVar2 = Component.GetComponent(lVar2,DAT_181d94f60);
                if (lVar2 != null) {
                  puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                  local_38 = *puVar3;
                  uStack_34 = puVar3[1];
                  uStack_30 = puVar3[2];
                  uStack_2c = puVar3[3];
                  fVar4 = (float)FUN_18044e2b0(&local_38,0);
                  fVar1 = *(float *)(*(int64 *)(DAT_181d73d40 + 184) + 0x110);
                  this.BaseMapScale = fVar4 / (fVar1 + fVar1);
                  if (this.quickTravelUI != null) {
                    lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                    if (lVar2 != null) {
                      lVar2 = Transform.Find(lVar2,"MapRoot",0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"BigMap",0);
                        if (lVar2 != null) {
                          lVar2 = Component.GetComponent(lVar2,DAT_181d94f60);
                          if (lVar2 != null) {
                            puVar3 = (uint32 *)RectTransform.get_rect(local_28,lVar2,0);
                            local_38 = *puVar3;
                            uStack_34 = puVar3[1];
                            uStack_30 = puVar3[2];
                            uStack_2c = puVar3[3];
                            uVar5 = FUN_180d98fa0(&local_38,0);
                            this.bigMapWidth = uVar5;
                            if (this.quickTravelUI != null) {
                              lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                              if (lVar2 != null) {
                                lVar2 = Transform.Find(lVar2,"MapRoot",0);
                                if (lVar2 != null) {
                                  lVar2 = Transform.Find(lVar2,"BigMap",0);
                                  if (lVar2 != null) {
                                    lVar2 = Component.GetComponent(lVar2,DAT_181d94f60);
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

    // Token : 0x6002031
    // RVA   : 0xD016E0   Offset: 0xD00AE0   Length: 0x144
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

    // Token : 0x6002032
    // RVA   : 0xD015A0   Offset: 0xD009A0   Length: 0x135
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
                if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
                  plVar2 = plVar1;
                }
                NGUITools.PlaySound(plVar2,0x3d75c28f,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6002033
    // RVA   : 0xD02E30   Offset: 0xD02230   Length: 0xCD
    public void ScaleSliderChange()
    {
        float fVar3;
        plVar1 = this.scaleSlider;
        if (plVar1 != (int64 *)0) {
          fVar3 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          QuickTravelUIController.SetNowScale(this,fVar3 + 1.0,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/摩擦",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0x3d23d70a,0);
          return;
        }
    }

    // Token : 0x6002034
    // RVA   : 0xD02F00   Offset: 0xD02300   Length: 0x5A9
    public void SetNowScale(float scale)
    {
        var pStatics = *(int64*)(DAT_181d94000 + 184);
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
        uVar7 = FUN_1810e36c0(scale,0x3f800000,0x40000000,0);
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
                      if (lVar1 == null) goto LAB_180d034a4;
                      if (lVar1.Count <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(lVar3 + lVar1._items);
                      if ((lVar1 == null) ||
                         (lVar1 = GameObject.GetComponent(lVar1,DAT_181d72898)) == null)
                      goto LAB_180d034a4;
                      QuickTravelAreaIconController.RefreshNameScale(lVar1,0);
                      lVar1 = this.areaObjs;
                      uVar4 = uVar4 + 1;
                      lVar3 = lVar3 + 8;
                      if (lVar1 == null) goto LAB_180d034a4;
                    }
                    lVar1 = this.resourceObjs;
                    if (lVar1 != null) {
                      lVar3 = 32;
                      uVar4 = uVar6;
                      goto LAB_180d031a1;
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180d034a4:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180d031a1:
        if (lVar1.Count <= (int)uVar4) {
          lVar1 = this.innObjs;
          if (lVar1 != null) goto LAB_180d03314;
          goto LAB_180d034a4;
        }
        if (lVar1 == null) goto LAB_180d034a4;
        if (lVar1.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar3 + lVar1._items);
        if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181d729a8)) == null)
        goto LAB_180d034a4;
        lVar1 = Component.get_transform(lVar1,0);
        if (lVar1 == null) goto LAB_180d034a4;
        lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
        puVar2 = (uint64 *)Vector3.get_one(local_38,0);
        local_68 = *puVar2;
        local_60 = *(float *)(puVar2 + 1);
        if (*pStatics == 0) goto LAB_180d034a4;
        fVar8 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
        local_50 = local_60 / fVar8;
        local_58 = CONCAT44(local_68._4_4_ / fVar8,(float)local_68 / fVar8);
        if (lVar1 == null) goto LAB_180d034a4;
        local_48 = local_58;
        local_40 = local_50;
        Transform.set_localScale(lVar1,&local_48);
        lVar1 = this.resourceObjs;
        uVar4 = uVar4 + 1;
        lVar3 = lVar3 + 8;
        if (lVar1 == null) goto LAB_180d034a4;
        goto LAB_180d031a1;
        LAB_180d03314:
        if (lVar1.Count <= (int)uVar6) {
          return;
        }
        if (lVar1 == null) goto LAB_180d034a4;
        if (lVar1.Count <= uVar6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar5 + lVar1._items);
        if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181d72920)) == null)
        goto LAB_180d034a4;
        lVar1 = Component.get_transform(lVar1,0);
        if (lVar1 == null) goto LAB_180d034a4;
        lVar1 = Transform.Find(lVar1,"AreaNameBack",0);
        puVar2 = (uint64 *)Vector3.get_one(local_38,0);
        local_58 = *puVar2;
        local_50 = *(float *)(puVar2 + 1);
        if (*pStatics == 0) goto LAB_180d034a4;
        fVar8 = *(float *)(*pStatics + 192) * 0.5 + 0.5;
        local_60 = local_50 / fVar8;
        local_68 = CONCAT44(local_58._4_4_ / fVar8,(float)local_58 / fVar8);
        if (lVar1 == null) goto LAB_180d034a4;
        local_48 = local_68;
        local_40 = local_60;
        Transform.set_localScale(lVar1,&local_48);
        lVar1 = this.innObjs;
        uVar6 = uVar6 + 1;
        lVar5 = lVar5 + 8;
        if (lVar1 == null) goto LAB_180d034a4;
        goto LAB_180d03314;
    }

    // Token : 0x6002035
    // RVA   : 0xD02A80   Offset: 0xD01E80   Length: 0x10B
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

    // Token : 0x6002036
    // RVA   : 0xD01A40   Offset: 0xD00E40   Length: 0x5B8
    private void InitQuickTravelMap()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if (((*pStatics_2cc8 != 0) &&
            (lVar12 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
           (lVar12 = *(int64 *)(lVar12 + 48)) != null) {
          FUN_1817eb420(&local_148,lVar12,DAT_181d7c660);
          local_b8 = local_148;
          uStack_b4 = uStack_144;
          uStack_b0 = uStack_140;
          uStack_ac = uStack_13c;
          local_a8 = local_138;
          while( true ) {
            cVar3 = FUN_180c74f00(&local_b8,DAT_181d89e68);
            lVar12 = local_a8;
            if (!cVar3) break;
            uVar7 = this.areaIcons;
            uVar13 = this.quickTravelAreaIcon;
            lVar5 = GlobalData.AddChild(uVar7,uVar13,0);
            local_e8 = lVar5;
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = GameObject.GetComponent(lVar5,DAT_181d71e80);
            if (lVar12 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (this.areaSprite == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar7 = FUN_180002f80(this.areaSprite,*(uint32 *)(lVar12 + 72),
                                  DAT_181da39d8);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Image.set_sprite(lVar6,uVar7,0);
            plVar8 = (int64 *)GameObject.GetComponent(lVar5,DAT_181d71e80);
            if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620(0);
            }
            (**(code **)(*plVar8 + 0x408))(plVar8,*(uint64 *)(*plVar8 + 0x410));
            lVar6 = GameObject.GetComponent(lVar5,DAT_181d72bc8);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar7 = RectTransform.get_sizeDelta(lVar6,0);
            local_res18 = (float)uVar7;
            fStackX_1c = (float)((uint64)uVar7 >> 32);
            RectTransform.set_sizeDelta(lVar6,CONCAT44(fStackX_1c * 0.5,local_res18 * 0.5),0);
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Transform.Find(lVar6,"OutLine",0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Component.GetComponent(lVar6,DAT_181d94460);
            if (this.areaSpriteOutLine == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar7 = FUN_180002f80(this.areaSpriteOutLine,*(uint32 *)(lVar12 + 72),
                                  DAT_181da39d8);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Image.set_sprite(lVar6,uVar7,0);
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Transform.Find(lVar6,"OutLine",0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620(0);
            }
            (**(code **)(*plVar8 + 0x408))(plVar8,*(uint64 *)(*plVar8 + 0x410));
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Transform.Find(lVar6,"OutLine",0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Component.GetComponent(lVar6,DAT_181d94f60);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar7 = RectTransform.get_sizeDelta(lVar6,0);
            local_res18 = (float)uVar7;
            fStackX_1c = (float)((uint64)uVar7 >> 32);
            RectTransform.set_sizeDelta(lVar6,CONCAT44(fStackX_1c * 0.5,local_res18 * 0.5),0);
            lVar6 = GameObject.get_transform(lVar5,0);
            fVar1 = this.BaseMapScale;
            if (*(int64 *)(lVar12 + 64) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar9 = (uint64 *)
                     BigMapPos.ToVector3(local_88,*(int64 *)(lVar12 + 64),0x3f800000,0);
            local_d8 = *(float *)(puVar9 + 1);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_c8 = CONCAT44((float)((uint64)*puVar9 >> 32) * fVar1,(float)*puVar9 * fVar1);
            local_c0 = local_d8 * fVar1;
            Transform.set_localPosition(lVar6,&local_c8,0);
            if (*(int *)(pStatics_3d40 + 8) == 1) {
              lVar6 = *(int64 *)(pStatics_3d40 + 24);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar3 = FUN_18182a3a0(lVar6,*(uint32 *)(lVar12 + 16),DAT_181d8f398);
              if (!cVar3) {
                plVar8 = (int64 *)GameObject.GetComponent(lVar5,DAT_181d71e80);
                if (plVar8 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620(0);
                }
                (**(code **)(*plVar8 + 0x2c8))(plVar8,0,*(uint64 *)(*plVar8 + 0x2d0));
              }
            }
            lVar6 = GameObject.get_transform(lVar5,0);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = Transform.Find(lVar6,"AreaNameBack",0);
            if (this.areaNameOffset == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar15 = FUN_1800d6790(this.areaNameOffset,*(uint32 *)(lVar12 + 72),
                                   DAT_181da1078);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_128 = 0;
            local_120 = 0;
            local_124 = uVar15;
            Transform.set_localPosition(lVar6,&local_128,0);
            lVar6 = GameObject.GetComponent(lVar5,DAT_181d72898);
            if (lVar6 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            *(int64 *)(lVar6 + 24) = lVar12;
            if (this.areaObjs == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_18181e0a0(this.areaObjs,lVar5);
            iVar14 = 0;
            while( true ) {
              lVar5 = *(int64 *)(lVar12 + 152);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int *)(lVar5 + 24) <= iVar14) break;
              iVar4 = FUN_1800d6760(lVar5,iVar14);
              if (*(int *)(lVar12 + 16) < iVar4) {
                lVar5 = *(int64 *)(lVar12 + 64);
                lVar6 = FUN_18046c0a0(0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = *(int64 *)(lVar6 + 32);
                if (*(int64 *)(lVar12 + 152) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar15 = FUN_1800d6760(*(int64 *)(lVar12 + 152),iVar14);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = WorldData.GetArea(lVar6,uVar15);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar7 = *(uint64 *)(lVar6 + 64);
                uVar13 = this.roads;
                uVar2 = this.quickTravelRoadPrefab;
                lVar6 = GlobalData.AddChild(uVar13,uVar2,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar10 = GameObject.get_transform(lVar6,0);
                lVar11 = GameObject.get_transform(local_e8,0);
                if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar9 = (uint64 *)Transform.get_localPosition(local_78,lVar11);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_168 = *puVar9;
                local_160 = *(float *)(puVar9 + 1);
                Transform.set_localPosition(lVar10,&local_168);
                lVar10 = GameObject.GetComponent(lVar6,DAT_181d72bc8);
                fVar1 = this.BaseMapScale;
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar16 = (float)BigMapPos.Distance(lVar5,uVar7);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                RectTransform.set_sizeDelta(lVar10,CONCAT44(0x40400000,fVar16 * fVar1));
                lVar6 = GameObject.get_transform(lVar6,0);
                lVar5 = BigMapPos.op_Subtraction(uVar7,lVar5);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar9 = (uint64 *)BigMapPos.ToVector3(&local_148,lVar5,0x3f800000,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_158 = *puVar9;
                local_150 = *(float *)(puVar9 + 1);
                Transform.set_right(lVar6,&local_158);
              }
              iVar14 = iVar14 + 1;
            }
          }
          ZhSegment.Initialize(&local_b8,DAT_181d89de8);
          lVar12 = FUN_18046c0a0(0);
          if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
             (lVar12 = *(int64 *)(*(int64 *)(lVar12 + 32) + 64)) != null) {
            FUN_1817eb420(&local_148,lVar12,DAT_181d9fa78);
            local_118 = CONCAT44(uStack_144,local_148);
            uStack_110 = CONCAT44(uStack_13c,uStack_140);
            local_108 = local_138;
            while( true ) {
              cVar3 = FUN_180c74f00(&local_118,DAT_181d90b68);
              lVar12 = local_108;
              if (!cVar3) break;
              uVar7 = this.areaIcons;
              uVar13 = this.quickTravelResourcePointIcon;
              lVar5 = GlobalData.AddChild(uVar7,uVar13,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = GameObject.get_transform(lVar5,0);
              fVar1 = this.BaseMapScale;
              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar12 + 40) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              puVar9 = (uint64 *)
                       BigMapPos.ToVector3(&local_148,*(int64 *)(lVar12 + 40),0x3f800000,0);
              local_150 = *(float *)(puVar9 + 1);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_168 = CONCAT44((float)((uint64)*puVar9 >> 32) * fVar1,(float)*puVar9 * fVar1);
              local_160 = local_150 * fVar1;
              Transform.set_localPosition(lVar6,&local_168,0);
              lVar6 = GameObject.get_transform(lVar5,0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = Transform.Find(lVar6,"AreaNameBack",0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = Transform.Find(lVar6,"AreaName",0);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar13 = Component.GetComponent(lVar6,DAT_181d96160);
              uVar7 = *(uint64 *)(lVar12 + 24);
              LTLocalization.SetText(uVar13,uVar7,0);
              lVar6 = GameObject.GetComponent(lVar5,DAT_181d729a8);
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              *(int64 *)(lVar6 + 24) = lVar12;
              if (this.resourceObjs == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_18181e0a0(this.resourceObjs,lVar5);
            }
            ZhSegment.Initialize(&local_118,DAT_181d90ae8);
            lVar12 = FUN_18046c0a0(0);
            if (((lVar12 != null) && (*(int64 *)(lVar12 + 32) != 0)) &&
               (lVar12 = *(int64 *)(*(int64 *)(lVar12 + 32) + 56)) != null) {
              FUN_1817eb420(&local_148,lVar12,DAT_181d8eb98);
              local_f0 = local_138;
              while( true ) {
                cVar3 = FUN_180c74f00(&local_100,DAT_181d8d668);
                lVar12 = local_f0;
                if (!cVar3) {
                  ZhSegment.Initialize(&local_100,DAT_181d8d5e8);
                  return;
                }
                uVar7 = this.areaIcons;
                uVar13 = this.quickTravelInnIcon;
                lVar5 = GlobalData.AddChild(uVar7,uVar13,0);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = GameObject.get_transform(lVar5,0);
                fVar1 = this.BaseMapScale;
                if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar12 + 48) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar9 = (uint64 *)
                         BigMapPos.ToVector3(&local_148,*(int64 *)(lVar12 + 48),0x3f800000,0);
                local_150 = *(float *)(puVar9 + 1);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_168 = CONCAT44((float)((uint64)*puVar9 >> 32) * fVar1,(float)*puVar9 * fVar1);
                local_160 = local_150 * fVar1;
                Transform.set_localPosition(lVar6,&local_168,0);
                lVar6 = GameObject.get_transform(lVar5,0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"AreaNameBack",0);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar6 = Transform.Find(lVar6,"AreaName",0);
                if (lVar6 == null) break;
                uVar13 = Component.GetComponent(lVar6,DAT_181d96160);
                uVar7 = *(uint64 *)(lVar12 + 24);
                LTLocalization.SetText(uVar13,uVar7,0);
                lVar6 = GameObject.GetComponent(lVar5,DAT_181d72920);
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar6 + 24) = lVar12;
                if (this.innObjs == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_18181e0a0(this.innObjs,lVar5);
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6002037
    // RVA   : 0xD06EA0   Offset: 0xD062A0   Length: 0xE
    private void Update()
    {
        void FUN_180d06ea0(int64 this)
        {
        if (!this.inited) {
          QuickTravelUIController.InitQuickTravelMap(this,0);
          return;
        }
    }

    // Token : 0x6002038
    // RVA   : 0xD06DC0   Offset: 0xD061C0   Length: 0x6B
    public void ToggleResourcePointButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        if (buttonClicked != null) {
          lVar1 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
          if (lVar1 != null) {
            this.showResourcePoint = *(uint8 *)(lVar1 + 0x118);
            QuickTravelUIController.RefreshAllResourceState(this,0);
            return;
          }
        }
    }

    // Token : 0x6002039
    // RVA   : 0xD06C90   Offset: 0xD06090   Length: 0xB6
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
          lVar4 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
          if ((lVar4 != null) && (lVar1 != null)) {
            FUN_1817f42f0(lVar1,uVar3,*(uint8 *)(lVar4 + 0x118),DAT_181d80720);
            QuickTravelUIController.RefreshAllAreaState(this,0);
            return;
          }
        }
    }

    // Token : 0x600203A
    // RVA   : 0xD06E30   Offset: 0xD06230   Length: 0x6F
    public void ToggleRoadButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        long lVar2;
        lVar1 = this.roads;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
          if ((lVar2 != null) && (lVar1 != null)) {
            GameObject.SetActive(lVar1,*(uint8 *)(lVar2 + 0x118),0);
            return;
          }
        }
    }

    // Token : 0x600203B
    // RVA   : 0xD06D50   Offset: 0xD06150   Length: 0x6B
    public void ToggleInnButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        if (buttonClicked != null) {
          lVar1 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
          if (lVar1 != null) {
            this.showInn = *(uint8 *)(lVar1 + 0x118);
            QuickTravelUIController.RefreshAllInnState(this,0);
            return;
          }
        }
    }

    // Token : 0x600203C
    // RVA   : 0xD034B0   Offset: 0xD028B0   Length: 0x67
    public void SetRoadsActive(bool active)
    {
        long lVar1;
        if (this.roadToggleButton != null) {
          lVar1 = GameObject.GetComponent(this.roadToggleButton,DAT_181d743b0);
          if (lVar1 != null) {
            Toggle.set_isOn(lVar1,active,0);
            return;
          }
        }
    }

    // Token : 0x600203D
    // RVA   : 0xD02B90   Offset: 0xD01F90   Length: 0xD2
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
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181d72898)) == null)
            break;
            QuickTravelAreaIconController.RefreshState(lVar1,0);
            lVar1 = this.areaObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x600203E
    // RVA   : 0xD02D50   Offset: 0xD02150   Length: 0xD2
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
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181d729a8)) == null)
            break;
            QuickTravelResourcePointController.RefreshState(lVar1,0);
            lVar1 = this.resourceObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x600203F
    // RVA   : 0xD02C70   Offset: 0xD02070   Length: 0xD2
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
            if ((lVar1 == null) || (lVar1 = GameObject.GetComponent(lVar1,DAT_181d72920)) == null)
            break;
            QuickTravelInnIconController.RefreshState(lVar1,0);
            lVar1 = this.innObjs;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6002040
    // RVA   : 0xD01580   Offset: 0xD00980   Length: 0x11
    public void BackgroundClicked()
    {
        void FUN_180d01580(int64 this)
        {
        if (!this.autoClose) {
          QuickTravelUIController.HideQuickTravelUI(this,0);
          return;
        }
    }

    // Token : 0x6002041
    // RVA   : 0xD01830   Offset: 0xD00C30   Length: 0x206
    public void HideQuickTravelUI()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.quickTravelUI != null) {
          lVar2 = GameObject.get_transform(this.quickTravelUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d94460);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1c20);
              if (this.quickTravelUI != null) {
                lVar2 = GameObject.get_transform(this.quickTravelUI,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"MapRoot",0);
                  uVar3 = ShortcutExtensions.DOScaleX(uVar3,0,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1db0);
                  uVar4 = new OnTooltipCB(this,DAT_181d9a090,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc01d0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002042
    // RVA   : 0xD03520   Offset: 0xD02920   Length: 0x88
    public void ShowQuickTravelUIShowType()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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

    // Token : 0x6002043
    // RVA   : 0xD06A00   Offset: 0xD05E00   Length: 0x22
    public void ShowQuickTravelUI(QuickTravelUIType targetTravelUIType)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
          plVar7 = plVar5;
        }
        NGUITools.PlaySound(plVar7,0);
        fVar15 = local_270;
        if (this.quickTravelUI == null) {
        LAB_180d069c9:
          local_270 = fVar15;
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.quickTravelUI,1,0);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180d069c9;
        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           ((lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270, lVar6 == null ||
            (plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460), fVar15 = local_270,
            plVar7 == (int64 *)0)))) goto LAB_180d069c9;
        plVar7 = (int64 *)
                 (**(code **)(*plVar7 + 0x298))(&local_288,plVar7,*(uint64 *)(*plVar7 + 0x2a0));
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        plVar7 = (int64 *)GlobalData.SetColorAlpha(&local_278,&local_288,0,0);
        fVar15 = local_270;
        if (plVar5 == (int64 *)0) goto LAB_180d069c9;
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_288,*(uint64 *)(*plVar5 + 0x2b0));
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180d069c9;
        uVar8 = Component.GetComponent(lVar6,DAT_181d94460);
        uVar8 = DOTweenModuleUI.DOFade(uVar8,0x3f000000,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1c20);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"MapRoot",0), fVar15 = local_270) == null)
        goto LAB_180d069c9;
        local_288 = param_3 << 32;
        lStack_280 = CONCAT44(lStack_280._4_4_,(int)param_3);
        Transform.set_localScale(lVar6,&local_288,0);
        fVar15 = local_270;
        if ((this.quickTravelUI == null) ||
           (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
           lVar6 == null)) goto LAB_180d069c9;
        uVar8 = Transform.Find(lVar6,"MapRoot",0);
        uVar8 = ShortcutExtensions.DOScaleX(uVar8,param_3,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1db0);
        this.quickTravelUIType = targetTravelUIType;
        fVar15 = local_270;
        if (this.playerIcon == null) goto LAB_180d069c9;
        lVar6 = GameObject.get_transform(this.playerIcon,0);
        fVar16 = this.BaseMapScale;
        fVar15 = local_270;
        if ((((*pStatics_2cc8 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (lVar9 = WorldData.Player(lVar9,0), fVar15 = local_270) == null) ||
           (*(int64 *)(lVar9 + 200) == 0)) goto LAB_180d069c9;
        plVar5 = (int64 *)BigMapPos.ToVector3(local_240,*(int64 *)(lVar9 + 200),0x3f800000,0);
        local_250 = *plVar5;
        local_288 = CONCAT44((float)((uint64)local_250 >> 32) * fVar16,(float)local_250 * fVar16);
        local_270 = *(float *)(plVar5 + 1) * fVar16;
        lStack_280 = CONCAT44((int)((uint64)lStack_280 >> 32),local_270);
        local_278 = local_250;
        fVar15 = *(float *)(plVar5 + 1);
        if (lVar6 == null) goto LAB_180d069c9;
        local_278 = local_288;
        Transform.set_localPosition(lVar6,&local_278,0);
        this.autoClose = param_4;
        lVar6 = il2cpp_internal(DAT_181d93cd0);
        local_250 = lVar6;
        FUN_18132faf0(lVar6,DAT_181d8f098);
        local_278 = lVar6;
        lVar9 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar9,DAT_181d8f098);
        local_288 = lVar9;
        if (this.quickTravelUIType == 3) {
          fVar15 = local_270;
          if (((*pStatics_2cc8 == 0) ||
              (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 48)) == null) goto LAB_180d069c9;
          FUN_1817eb420(&local_230,lVar1,DAT_181d7c660);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
          while (cVar2 = FUN_180c74f00(&local_268,DAT_181d89e68), lVar1 = local_258, cVar2) {
            if (local_258 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = AreaData.BelongPlayerOrAlley(local_258,0);
            if (cVar2) {
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_18182a0b0(lVar9,*(uint32 *)(lVar1 + 16),DAT_181d8f218);
            }
          }
          ZhSegment.Initialize(&local_268,DAT_181d89de8);
          fVar15 = local_270;
          if (((*pStatics_2cc8 == 0) ||
              (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 48)) == null) goto LAB_180d069c9;
          FUN_1817eb420(&local_230,lVar1,DAT_181d7c660);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
        LAB_180d03df2:
          cVar2 = FUN_180c74f00(&local_268,DAT_181d89e68);
          lVar1 = local_258;
          if (cVar2) {
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
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = ForceData.CanAttack(lVar10,*(uint32 *)(lVar1 + 112));
            plVar5 = plVar14;
            if (cVar2) {
              while( true ) {
                lVar10 = *(int64 *)(lVar1 + 152);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int *)(lVar10 + 24) <= (int)plVar5) goto LAB_180d03df2;
                uVar3 = FUN_1800d6760(lVar10,plVar5,DAT_181d8fa18);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar2 = FUN_18182a3a0(lVar9,uVar3);
                if (cVar2) break;
                plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              }
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_18182a0b0(lVar6,*(uint32 *)(lVar1 + 16));
            }
            goto LAB_180d03df2;
          }
          ZhSegment.Initialize(&local_268,DAT_181d89de8);
        }
        lVar1 = local_298;
        lVar6 = this.areaIcons;
        joined_r0x000180d03f51:
        if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) goto LAB_180d069c3;
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
           ) goto LAB_180d069c9;
        uVar8 = Component.GetComponent(lVar6,DAT_181d94d60);
        cVar2 = Object.op_Inequality(uVar8,0);
        lVar6 = *(int64 *)(lVar1 + 72);
        if (cVar2) {
          fVar15 = local_270;
          if (((lVar6 == null) ||
              (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
              ((lVar6 = Transform.Find(lVar6,"AreaNameBack",0), fVar15 = local_270, lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"AreaName",0), fVar15 = local_270) == null)))))
          goto LAB_180d069c9;
          uVar8 = Component.GetComponent(lVar6,DAT_181d96160);
          fVar15 = local_270;
          if ((this.areaIcons == null) ||
             ((((lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270) == null) ||
              (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180d069c9;
          uVar11 = AreaData.GetAreaName(*(int64 *)(lVar6 + 24),0);
          LTLocalization.SetText(uVar8,uVar11,0);
          lVar6 = FUN_18046c0a0(0);
          fVar15 = local_270;
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
          goto LAB_180d069c9;
          cVar2 = HeroData.HaveForce(lVar6,0);
          if (!cVar2) {
        LAB_180d056f3:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            puVar12 = local_158;
        LAB_180d05758:
            plVar7 = (int64 *)FUN_180d98fe0(puVar12,0);
        LAB_180d05762:
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180d069c9;
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
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            if (!cVar2) goto LAB_180d056f3;
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_18046c0a0(0);
            fVar15 = local_270;
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            if (iVar4 != *(int *)(lVar6 + 132)) {
              if ((((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270
                   , lVar6 != null)) &&
                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 != null &&
                   ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 != null
                    && (*(int64 *)(lVar6 + 24) != 0)))))) &&
                 (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 24),0), fVar15 = local_270,
                 lVar6 != null)) {
                iVar4 = *(int *)(lVar6 + 60);
                lVar6 = FUN_18046c0a0(0);
                fVar15 = local_270;
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                   lVar6 != null)) {
                  if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180d05652;
                  lVar6 = FUN_18046c0a0(0);
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
                         ) && ((lVar10 = Component.GetComponent(lVar10,DAT_181d94d60), fVar15 = local_270
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
                          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                          plVar7 = (int64 *)Color.get_blue(local_58,0);
                          goto LAB_180d05762;
                        }
                      }
                      else {
                        lVar6 = FUN_18046c0a0(0);
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
                               ((lVar10 = Component.GetComponent(lVar10,DAT_181d94d60),
                                fVar15 = local_270, lVar10 != null && (*(int64 *)(lVar10 + 24) != 0)))))
                              ) && (lVar6 != null)) {
                            fVar16 = (float)ForceData.GetForceFavor
                                                      (lVar6,*(uint32 *)
                                                              (*(int64 *)(lVar10 + 24) + 112),0);
                            lVar6 = *(int64 *)(lVar1 + 72);
                            fVar15 = local_270;
                            if (fVar16 < 40.0) {
                              if ((((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270,
                                   lVar6 != null)) &&
                                  (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270,
                                  lVar6 != null)) &&
                                 (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                                 lVar6 != null)) {
                                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                                lVar6 = pStatics_3d40;
                                fVar15 = local_270;
                                if (plVar5 != (int64 *)0) {
                                  uVar3 = *(uint32 *)(lVar6 + 0x2f0);
                                  uVar17 = *(uint32 *)(lVar6 + 0x2f4);
                                  uStack_290 = *(uint32 *)(lVar6 + 0x2f8);
                                  uStack_28c = *(uint32 *)(lVar6 + 0x2fc);
                                  goto LAB_180d055bc;
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
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                              puVar12 = local_168;
                              goto LAB_180d05758;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_180d069c9;
            }
        LAB_180d05652:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            lVar6 = pStatics_3d40;
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180d069c9;
            uVar3 = *(uint32 *)(lVar6 + 0x288);
            uVar17 = *(uint32 *)(lVar6 + 0x28c);
            uStack_290 = *(uint32 *)(lVar6 + 0x290);
            uStack_28c = *(uint32 *)(lVar6 + 0x294);
        LAB_180d055bc:
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
               (lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            *(uint32 *)(lVar6 + 32) = 0;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = *(int64 *)(lVar1 + 72);
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              puVar12 = local_138;
        LAB_180d05957:
              plVar7 = (int64 *)FUN_1810d3570(puVar12,0);
            }
            else {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
              plVar7 = (int64 *)AreaData.GetForceColor(local_148,*(int64 *)(lVar6 + 24),0);
            }
            break;
          case 1:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180d069c9;
            lVar10 = *(int64 *)(lVar1 + 72);
            if (*(int *)(*(int64 *)(lVar6 + 24) + 72) == 0) {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
              lVar6 = FUN_18046c0a0(0);
              fVar15 = local_270;
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270, lVar6 == null
                 )) goto LAB_180d069c9;
              lVar10 = *(int64 *)(lVar1 + 72);
              if (iVar4 != *(int *)(lVar6 + 192)) {
                if (((lVar10 != null) &&
                    (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                      goto switchD_180d0494e_default;
                    }
                  }
                }
                goto LAB_180d069c9;
              }
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)Color.get_red(local_108,0);
            }
            else {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)FUN_1810d33f0(local_128,0);
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
              goto LAB_180d06919;
            }
            goto LAB_180d069c9;
          case 2:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            *(uint32 *)(lVar6 + 32) = 2;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = *(int64 *)(lVar1 + 72);
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 != null) &&
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                puVar12 = local_e8;
                goto LAB_180d05957;
              }
              goto LAB_180d069c9;
            }
            if (((lVar6 == null) ||
                (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            plVar7 = (int64 *)AreaData.GetForceColor(local_f8,*(int64 *)(lVar6 + 24),0);
            break;
          case 3:
            QuickTravelUIController.SetRoadsActive(this,1,0);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_18046c0a0(0);
            fVar15 = local_270;
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null
                ) || (lVar6 = HeroData.GetForce(lVar6,0,0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              lVar6 = FUN_18046c360(0);
              fVar15 = local_270;
              if (lVar6 == null) goto LAB_180d069c9;
              if (*(int *)(lVar6 + 32) != 0) {
                if (((this.areaIcons == null) ||
                    (lVar6 = GameObject.get_transform(this.areaIcons,0),
                    fVar15 = local_270, lVar6 == null)) ||
                   ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                    ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                     || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
                iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
                lVar6 = FUN_18046c360(0);
                fVar15 = local_270;
                if (lVar6 == null) goto LAB_180d069c9;
                if (iVar4 == *(int *)(lVar6 + 192)) {
                  if (((this.areaIcons != null) &&
                      (lVar6 = GameObject.get_transform(this.areaIcons,0),
                      fVar15 = local_270, lVar6 != null)) &&
                     (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                        goto switchD_180d0494e_default;
                      }
                    }
                  }
                  goto LAB_180d069c9;
                }
              }
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  (((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                    || (*(int64 *)(lVar6 + 24) == 0)) || (local_250 == 0)))))) goto LAB_180d069c9;
              cVar2 = FUN_18182a3a0(local_250,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181d8f398);
              lVar6 = *(int64 *)(lVar1 + 72);
              fVar15 = local_270;
              if (cVar2) {
                if (((lVar6 != null) &&
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                      goto switchD_180d0494e_default;
                    }
                  }
                }
                goto LAB_180d069c9;
              }
              if (((((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))) || (lVar9 == null)) goto LAB_180d069c9;
              cVar2 = FUN_18182a3a0(lVar9,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181d8f398);
              lVar6 = *(int64 *)(lVar1 + 72);
              if (!cVar2) {
                if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                plVar7 = (int64 *)FUN_1810d33f0(local_b8,0);
              }
              else {
                fVar15 = local_270;
                if (((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
                goto LAB_180d069c9;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                  goto joined_r0x000180d0631f;
                }
              }
              goto LAB_180d069c3;
            }
            if (((this.areaIcons != null) &&
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)Color.get_green(local_d8,0);
              goto LAB_180d068a4;
            }
            goto LAB_180d069c3;
          case 4:
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
               ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 != null &&
                (*(int64 *)(lVar6 + 24) != 0)))) {
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 != null &&
                  (lVar6 = HeroData.GetForce(lVar6,0,0)) != null))) {
                if (iVar4 == *(int *)(lVar6 + 16)) {
                  if ((((this.areaIcons == null) ||
                       (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
                      || (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
                     ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 == null ||
                      (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180d069c3;
                  if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null)
                       && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                      plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                          goto switchD_180d0494e_default;
                        }
                      }
                    }
                    goto LAB_180d069c3;
                  }
                }
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                  puVar13 = local_78;
                  goto LAB_180d0689a;
                }
              }
            }
            goto LAB_180d069c3;
          case 5:
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) {
        LAB_180d069c3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_18046c0a0(0);
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
               (lVar6 = HeroData.GetForce(lVar6,0,0)) == null) goto LAB_180d069c3;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 == null ||
                   (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
              if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                      goto switchD_180d0494e_default;
                    }
                  }
                }
                goto LAB_180d069c3;
              }
            }
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            puVar13 = &local_230;
        LAB_180d0689a:
            plVar7 = (int64 *)FUN_1810d33f0(puVar13,0);
        LAB_180d068a4:
            if (plVar5 == (int64 *)0) goto LAB_180d069c3;
            local_298 = *plVar7;
            uStack_290 = (uint32)plVar7[1];
            uStack_28c = *(uint32 *)((int64)plVar7 + 12);
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
            if ((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
            goto LAB_180d069c3;
            lVar6 = Transform.GetChild(lVar6,plVar14);
            goto joined_r0x000180d04f0c;
          default:
            goto switchD_180d0494e_default;
          }
          fVar15 = local_270;
          if (plVar5 == (int64 *)0) goto LAB_180d069c9;
        LAB_180d0596a:
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        switchD_180d0494e_default:
          plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
          lVar6 = this.areaIcons;
          goto joined_r0x000180d03f51;
        }
        if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
           (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180d069c3;
        uVar8 = Component.GetComponent(lVar6,DAT_181d94e60);
        cVar2 = Object.op_Inequality(uVar8,0);
        if (!cVar2) {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180d069c3;
          uVar8 = Component.GetComponent(lVar6);
          cVar2 = Object.op_Inequality(uVar8);
          if (!cVar2) goto switchD_180d0494e_default;
          lVar6 = *(int64 *)(lVar1 + 72);
          if (this.quickTravelUIType != 2) {
            if (((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)FUN_1810d33f0(&local_288,0);
              if (plVar5 != (int64 *)0) {
                local_298 = *plVar7;
                uStack_290 = (uint32)plVar7[1];
                uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                if ((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) {
                  lVar6 = Transform.GetChild(lVar6,plVar14);
                  goto joined_r0x000180d04f0c;
                }
              }
            }
            goto LAB_180d069c3;
          }
          if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d3570(&local_278,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14), lVar6 == null ||
              (lVar6 = Component.GetComponent(lVar6)) == null))) goto LAB_180d069c3;
          *(uint32 *)(lVar6 + 32) = 2;
          goto switchD_180d0494e_default;
        }
        lVar6 = FUN_18046c0a0(0);
        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180d069c3;
        cVar2 = HeroData.HaveForce(lVar6,0);
        if (!cVar2) {
        LAB_180d0489e:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          puVar12 = local_1f8;
        LAB_180d04903:
          plVar7 = (int64 *)FUN_180d98fe0(puVar12,0);
        LAB_180d0490d:
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        else {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) goto LAB_180d0489e;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 48);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180d069c3;
          if (iVar4 != *(int *)(lVar6 + 132)) {
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                 ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 != null &&
                  (*(int64 *)(lVar6 + 24) != 0)))))) &&
               (lVar6 = ResourcePointData.GetForce(*(int64 *)(lVar6 + 24),0)) != null) {
              iVar4 = *(int *)(lVar6 + 60);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180d047fd;
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  lVar6 = HeroData.GetForce(lVar6,0,0);
                  if (((((this.areaIcons != null) &&
                        (lVar10 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null) &&
                      ((lVar10 = Component.GetComponent(lVar10,DAT_181d94e60), lVar10 != null &&
                       (*(int64 *)(lVar10 + 24) != 0)))) && (lVar6 != null)) {
                    fVar15 = (float)ForceData.GetForceFavor
                                              (lVar6,*(uint32 *)(*(int64 *)(lVar10 + 24) + 48),
                                               0);
                    if (80.0 <= fVar15) {
                      if (((this.areaIcons != null) &&
                          (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null
                          ) && ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                        plVar7 = (int64 *)Color.get_blue(local_208,0);
                        goto LAB_180d0490d;
                      }
                    }
                    else {
                      lVar6 = FUN_18046c0a0(0);
                      if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                         (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                        lVar6 = HeroData.GetForce(lVar6,0,0);
                        if ((((this.areaIcons != null) &&
                             (lVar10 = GameObject.get_transform(this.areaIcons,0),
                             lVar10 != null)) &&
                            ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                             ((lVar10 = Component.GetComponent(lVar10,DAT_181d94e60), lVar10 != null &&
                              (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar6 != null)) {
                          fVar15 = (float)ForceData.GetForceFavor
                                                    (lVar6,*(uint32 *)
                                                            (*(int64 *)(lVar10 + 24) + 48),0);
                          lVar6 = *(int64 *)(lVar1 + 72);
                          if (fVar15 < 40.0) {
                            if ((((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null
                                 ) && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
                               (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                              lVar6 = pStatics_3d40;
                              if (plVar5 != (int64 *)0) {
                                uVar3 = *(uint32 *)(lVar6 + 0x2f0);
                                uVar17 = *(uint32 *)(lVar6 + 0x2f4);
                                uStack_290 = *(uint32 *)(lVar6 + 0x2f8);
                                uStack_28c = *(uint32 *)(lVar6 + 0x2fc);
                                goto LAB_180d04767;
                              }
                            }
                          }
                          else if (((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
                                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                   (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                            puVar12 = local_240;
                            goto LAB_180d04903;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180d069c3;
          }
        LAB_180d047fd:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          lVar6 = pStatics_3d40;
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          uVar3 = *(uint32 *)(lVar6 + 0x288);
          uVar17 = *(uint32 *)(lVar6 + 0x28c);
          uStack_290 = *(uint32 *)(lVar6 + 0x290);
          uStack_28c = *(uint32 *)(lVar6 + 0x294);
        LAB_180d04767:
          local_298 = CONCAT44(uVar17,uVar3);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        switch(this.quickTravelUIType) {
        case 0:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d94e60)) == null) goto LAB_180d069c3;
          *(uint32 *)(lVar6 + 32) = 0;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          lVar10 = *(int64 *)(lVar1 + 72);
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) != -1) {
            if (((lVar10 != null) && (lVar6 = GameObject.get_transform(lVar10,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              if (((this.areaIcons != null) &&
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 != null &&
                   (*(int64 *)(lVar6 + 24) != 0)))))) {
                plVar7 = (int64 *)
                         ResourcePointData.GetForceColor(local_1e8,*(int64 *)(lVar6 + 24),0);
                goto joined_r0x000180d04b0f;
              }
            }
            goto LAB_180d069c3;
          }
          if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d3570(local_1d8,0);
          goto joined_r0x000180d04b0f;
        case 1:
          if (((this.areaIcons != null) &&
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            plVar7 = (int64 *)FUN_1810d33f0(local_1c8,0);
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
          goto LAB_180d069c3;
        case 2:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d94e60)) == null) goto LAB_180d069c3;
          *(uint32 *)(lVar6 + 32) = 2;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          lVar10 = *(int64 *)(lVar1 + 72);
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            plVar7 = (int64 *)FUN_1810d3570(local_1a8,0);
          }
          else {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
            plVar7 = (int64 *)ResourcePointData.GetForceColor(local_1b8,*(int64 *)(lVar6 + 24),0)
            ;
          }
        joined_r0x000180d04b0f:
          if (plVar5 != (int64 *)0) goto LAB_180d0596a;
          goto LAB_180d069c3;
        case 3:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d33f0(local_198,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180d069c3;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 4:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d33f0(local_188,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180d069c3;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 5:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d33f0(local_178,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180d069c3;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        default:
          goto switchD_180d0494e_default;
        }
        joined_r0x000180d04f0c:
        if (lVar6 != null) {
          lVar6 = Component.GetComponent(lVar6);
        joined_r0x000180d0631f:
          if (lVar6 != null) {
        LAB_180d06919:
            *(uint32 *)(lVar6 + 32) = 0;
            goto switchD_180d0494e_default;
          }
        }
        goto LAB_180d069c3;
    }

    // Token : 0x6002044
    // RVA   : 0xD035B0   Offset: 0xD029B0   Length: 0x3420
    public void ShowQuickTravelUI(QuickTravelUIType targetTravelUIType, float scale, bool _autoClose)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
          plVar7 = plVar5;
        }
        NGUITools.PlaySound(plVar7,0);
        fVar15 = local_270;
        if (this.quickTravelUI == null) {
        LAB_180d069c9:
          local_270 = fVar15;
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.quickTravelUI,1,0);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180d069c9;
        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           ((lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270, lVar6 == null ||
            (plVar7 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460), fVar15 = local_270,
            plVar7 == (int64 *)0)))) goto LAB_180d069c9;
        plVar7 = (int64 *)
                 (**(code **)(*plVar7 + 0x298))(&local_288,plVar7,*(uint64 *)(*plVar7 + 0x2a0));
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        plVar7 = (int64 *)GlobalData.SetColorAlpha(&local_278,&local_288,0,0);
        fVar15 = local_270;
        if (plVar5 == (int64 *)0) goto LAB_180d069c9;
        local_288 = *plVar7;
        lStack_280 = plVar7[1];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_288,*(uint64 *)(*plVar5 + 0x2b0));
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"BlackBackground",0), fVar15 = local_270) == null)
        goto LAB_180d069c9;
        uVar8 = Component.GetComponent(lVar6,DAT_181d94460);
        uVar8 = DOTweenModuleUI.DOFade(uVar8,0x3f000000,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1c20);
        fVar15 = local_270;
        if (((this.quickTravelUI == null) ||
            (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
            lVar6 == null)) ||
           (lVar6 = Transform.Find(lVar6,"MapRoot",0), fVar15 = local_270) == null)
        goto LAB_180d069c9;
        local_288 = scale << 32;
        lStack_280 = CONCAT44(lStack_280._4_4_,(int)scale);
        Transform.set_localScale(lVar6,&local_288,0);
        fVar15 = local_270;
        if ((this.quickTravelUI == null) ||
           (lVar6 = GameObject.get_transform(this.quickTravelUI,0), fVar15 = local_270,
           lVar6 == null)) goto LAB_180d069c9;
        uVar8 = Transform.Find(lVar6,"MapRoot",0);
        uVar8 = ShortcutExtensions.DOScaleX(uVar8,scale,0x3e800000,0);
        TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1db0);
        this.quickTravelUIType = targetTravelUIType;
        fVar15 = local_270;
        if (this.playerIcon == null) goto LAB_180d069c9;
        lVar6 = GameObject.get_transform(this.playerIcon,0);
        fVar16 = this.BaseMapScale;
        fVar15 = local_270;
        if ((((*pStatics_2cc8 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (lVar9 = WorldData.Player(lVar9,0), fVar15 = local_270) == null) ||
           (*(int64 *)(lVar9 + 200) == 0)) goto LAB_180d069c9;
        plVar5 = (int64 *)BigMapPos.ToVector3(local_240,*(int64 *)(lVar9 + 200),0x3f800000,0);
        local_250 = *plVar5;
        local_288 = CONCAT44((float)((uint64)local_250 >> 32) * fVar16,(float)local_250 * fVar16);
        local_270 = *(float *)(plVar5 + 1) * fVar16;
        lStack_280 = CONCAT44((int)((uint64)lStack_280 >> 32),local_270);
        local_278 = local_250;
        fVar15 = *(float *)(plVar5 + 1);
        if (lVar6 == null) goto LAB_180d069c9;
        local_278 = local_288;
        Transform.set_localPosition(lVar6,&local_278,0);
        this.autoClose = _autoClose;
        lVar6 = il2cpp_internal(DAT_181d93cd0);
        local_250 = lVar6;
        FUN_18132faf0(lVar6,DAT_181d8f098);
        local_278 = lVar6;
        lVar9 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar9,DAT_181d8f098);
        local_288 = lVar9;
        if (this.quickTravelUIType == 3) {
          fVar15 = local_270;
          if (((*pStatics_2cc8 == 0) ||
              (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 48)) == null) goto LAB_180d069c9;
          FUN_1817eb420(&local_230,lVar1,DAT_181d7c660);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
          while (cVar2 = FUN_180c74f00(&local_268,DAT_181d89e68), lVar1 = local_258, cVar2) {
            if (local_258 == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = AreaData.BelongPlayerOrAlley(local_258,0);
            if (cVar2) {
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_18182a0b0(lVar9,*(uint32 *)(lVar1 + 16),DAT_181d8f218);
            }
          }
          ZhSegment.Initialize(&local_268,DAT_181d89de8);
          fVar15 = local_270;
          if (((*pStatics_2cc8 == 0) ||
              (lVar1 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 48)) == null) goto LAB_180d069c9;
          FUN_1817eb420(&local_230,lVar1,DAT_181d7c660);
          local_268 = CONCAT44(uStack_22c,local_230);
          uStack_260 = CONCAT44(uStack_224,uStack_228);
          local_258 = local_220;
        LAB_180d03df2:
          cVar2 = FUN_180c74f00(&local_268,DAT_181d89e68);
          lVar1 = local_258;
          if (cVar2) {
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
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (lVar10 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = ForceData.CanAttack(lVar10,*(uint32 *)(lVar1 + 112));
            plVar5 = plVar14;
            if (cVar2) {
              while( true ) {
                lVar10 = *(int64 *)(lVar1 + 152);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int *)(lVar10 + 24) <= (int)plVar5) goto LAB_180d03df2;
                uVar3 = FUN_1800d6760(lVar10,plVar5,DAT_181d8fa18);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar2 = FUN_18182a3a0(lVar9,uVar3);
                if (cVar2) break;
                plVar5 = (int64 *)(uint64)((int)plVar5 + 1);
              }
              if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_18182a0b0(lVar6,*(uint32 *)(lVar1 + 16));
            }
            goto LAB_180d03df2;
          }
          ZhSegment.Initialize(&local_268,DAT_181d89de8);
        }
        lVar1 = local_298;
        lVar6 = this.areaIcons;
        joined_r0x000180d03f51:
        if ((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) goto LAB_180d069c3;
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
           ) goto LAB_180d069c9;
        uVar8 = Component.GetComponent(lVar6,DAT_181d94d60);
        cVar2 = Object.op_Inequality(uVar8,0);
        lVar6 = *(int64 *)(lVar1 + 72);
        if (cVar2) {
          fVar15 = local_270;
          if (((lVar6 == null) ||
              (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
              ((lVar6 = Transform.Find(lVar6,"AreaNameBack",0), fVar15 = local_270, lVar6 == null ||
               (lVar6 = Transform.Find(lVar6,"AreaName",0), fVar15 = local_270) == null)))))
          goto LAB_180d069c9;
          uVar8 = Component.GetComponent(lVar6,DAT_181d96160);
          fVar15 = local_270;
          if ((this.areaIcons == null) ||
             ((((lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270) == null) ||
              (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180d069c9;
          uVar11 = AreaData.GetAreaName(*(int64 *)(lVar6 + 24),0);
          LTLocalization.SetText(uVar8,uVar11,0);
          lVar6 = FUN_18046c0a0(0);
          fVar15 = local_270;
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
          goto LAB_180d069c9;
          cVar2 = HeroData.HaveForce(lVar6,0);
          if (!cVar2) {
        LAB_180d056f3:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            puVar12 = local_158;
        LAB_180d05758:
            plVar7 = (int64 *)FUN_180d98fe0(puVar12,0);
        LAB_180d05762:
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180d069c9;
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
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            if (!cVar2) goto LAB_180d056f3;
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_18046c0a0(0);
            fVar15 = local_270;
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            if (iVar4 != *(int *)(lVar6 + 132)) {
              if ((((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270
                   , lVar6 != null)) &&
                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 != null &&
                   ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 != null
                    && (*(int64 *)(lVar6 + 24) != 0)))))) &&
                 (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 24),0), fVar15 = local_270,
                 lVar6 != null)) {
                iVar4 = *(int *)(lVar6 + 60);
                lVar6 = FUN_18046c0a0(0);
                fVar15 = local_270;
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270,
                   lVar6 != null)) {
                  if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180d05652;
                  lVar6 = FUN_18046c0a0(0);
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
                         ) && ((lVar10 = Component.GetComponent(lVar10,DAT_181d94d60), fVar15 = local_270
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
                          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                          plVar7 = (int64 *)Color.get_blue(local_58,0);
                          goto LAB_180d05762;
                        }
                      }
                      else {
                        lVar6 = FUN_18046c0a0(0);
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
                               ((lVar10 = Component.GetComponent(lVar10,DAT_181d94d60),
                                fVar15 = local_270, lVar10 != null && (*(int64 *)(lVar10 + 24) != 0)))))
                              ) && (lVar6 != null)) {
                            fVar16 = (float)ForceData.GetForceFavor
                                                      (lVar6,*(uint32 *)
                                                              (*(int64 *)(lVar10 + 24) + 112),0);
                            lVar6 = *(int64 *)(lVar1 + 72);
                            fVar15 = local_270;
                            if (fVar16 < 40.0) {
                              if ((((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270,
                                   lVar6 != null)) &&
                                  (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270,
                                  lVar6 != null)) &&
                                 (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270,
                                 lVar6 != null)) {
                                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                                lVar6 = pStatics_3d40;
                                fVar15 = local_270;
                                if (plVar5 != (int64 *)0) {
                                  uVar3 = *(uint32 *)(lVar6 + 0x2f0);
                                  uVar17 = *(uint32 *)(lVar6 + 0x2f4);
                                  uStack_290 = *(uint32 *)(lVar6 + 0x2f8);
                                  uStack_28c = *(uint32 *)(lVar6 + 0x2fc);
                                  goto LAB_180d055bc;
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
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                              puVar12 = local_168;
                              goto LAB_180d05758;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_180d069c9;
            }
        LAB_180d05652:
            fVar15 = local_270;
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.Find(lVar6,"OutLine",0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            lVar6 = pStatics_3d40;
            fVar15 = local_270;
            if (plVar5 == (int64 *)0) goto LAB_180d069c9;
            uVar3 = *(uint32 *)(lVar6 + 0x288);
            uVar17 = *(uint32 *)(lVar6 + 0x28c);
            uStack_290 = *(uint32 *)(lVar6 + 0x290);
            uStack_28c = *(uint32 *)(lVar6 + 0x294);
        LAB_180d055bc:
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
               (lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            *(uint32 *)(lVar6 + 32) = 0;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = *(int64 *)(lVar1 + 72);
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              puVar12 = local_138;
        LAB_180d05957:
              plVar7 = (int64 *)FUN_1810d3570(puVar12,0);
            }
            else {
              if (((lVar6 == null) ||
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
              plVar7 = (int64 *)AreaData.GetForceColor(local_148,*(int64 *)(lVar6 + 24),0);
            }
            break;
          case 1:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180d069c9;
            lVar10 = *(int64 *)(lVar1 + 72);
            if (*(int *)(*(int64 *)(lVar6 + 24) + 72) == 0) {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
              lVar6 = FUN_18046c0a0(0);
              fVar15 = local_270;
              if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270, lVar6 == null
                 )) goto LAB_180d069c9;
              lVar10 = *(int64 *)(lVar1 + 72);
              if (iVar4 != *(int *)(lVar6 + 192)) {
                if (((lVar10 != null) &&
                    (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                      goto switchD_180d0494e_default;
                    }
                  }
                }
                goto LAB_180d069c9;
              }
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)Color.get_red(local_108,0);
            }
            else {
              if (((lVar10 == null) ||
                  (lVar6 = GameObject.get_transform(lVar10,0), fVar15 = local_270) == null) ||
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
              goto LAB_180d069c9;
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)FUN_1810d33f0(local_128,0);
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
              goto LAB_180d06919;
            }
            goto LAB_180d069c9;
          case 2:
            if ((((this.areaIcons == null) ||
                 (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                 lVar6 == null)) ||
                (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            *(uint32 *)(lVar6 + 32) = 2;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            cVar2 = AreaData.HaveForce(*(int64 *)(lVar6 + 24),0);
            lVar6 = *(int64 *)(lVar1 + 72);
            fVar15 = local_270;
            if (!cVar2) {
              if (((lVar6 != null) &&
                  (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                 (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                puVar12 = local_e8;
                goto LAB_180d05957;
              }
              goto LAB_180d069c9;
            }
            if (((lVar6 == null) ||
                (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            plVar7 = (int64 *)AreaData.GetForceColor(local_f8,*(int64 *)(lVar6 + 24),0);
            break;
          case 3:
            QuickTravelUIController.SetRoadsActive(this,1,0);
            fVar15 = local_270;
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                lVar6 == null)) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_18046c0a0(0);
            fVar15 = local_270;
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), fVar15 = local_270) == null
                ) || (lVar6 = HeroData.GetForce(lVar6,0,0), fVar15 = local_270) == null)
            goto LAB_180d069c9;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              lVar6 = FUN_18046c360(0);
              fVar15 = local_270;
              if (lVar6 == null) goto LAB_180d069c9;
              if (*(int *)(lVar6 + 32) != 0) {
                if (((this.areaIcons == null) ||
                    (lVar6 = GameObject.get_transform(this.areaIcons,0),
                    fVar15 = local_270, lVar6 == null)) ||
                   ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                    ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                     || (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c9;
                iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 16);
                lVar6 = FUN_18046c360(0);
                fVar15 = local_270;
                if (lVar6 == null) goto LAB_180d069c9;
                if (iVar4 == *(int *)(lVar6 + 192)) {
                  if (((this.areaIcons != null) &&
                      (lVar6 = GameObject.get_transform(this.areaIcons,0),
                      fVar15 = local_270, lVar6 != null)) &&
                     (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                        goto switchD_180d0494e_default;
                      }
                    }
                  }
                  goto LAB_180d069c9;
                }
              }
              fVar15 = local_270;
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0), fVar15 = local_270,
                  lVar6 == null)) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270, lVar6 == null ||
                  (((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                    || (*(int64 *)(lVar6 + 24) == 0)) || (local_250 == 0)))))) goto LAB_180d069c9;
              cVar2 = FUN_18182a3a0(local_250,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181d8f398);
              lVar6 = *(int64 *)(lVar1 + 72);
              fVar15 = local_270;
              if (cVar2) {
                if (((lVar6 != null) &&
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                      goto switchD_180d0494e_default;
                    }
                  }
                }
                goto LAB_180d069c9;
              }
              if (((((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null) ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), fVar15 = local_270, lVar6 == null
                   || (*(int64 *)(lVar6 + 24) == 0)))) || (lVar9 == null)) goto LAB_180d069c9;
              cVar2 = FUN_18182a3a0(lVar9,*(uint32 *)(*(int64 *)(lVar6 + 24) + 16),
                                    DAT_181d8f398);
              lVar6 = *(int64 *)(lVar1 + 72);
              if (!cVar2) {
                if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                plVar7 = (int64 *)FUN_1810d33f0(local_b8,0);
              }
              else {
                fVar15 = local_270;
                if (((lVar6 == null) ||
                    (lVar6 = GameObject.get_transform(lVar6,0), fVar15 = local_270) == null) ||
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0), fVar15 = local_270) == null)
                goto LAB_180d069c9;
                plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                  goto joined_r0x000180d0631f;
                }
              }
              goto LAB_180d069c3;
            }
            if (((this.areaIcons != null) &&
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)Color.get_green(local_d8,0);
              goto LAB_180d068a4;
            }
            goto LAB_180d069c3;
          case 4:
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
               ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 != null &&
                (*(int64 *)(lVar6 + 24) != 0)))) {
              iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 != null &&
                  (lVar6 = HeroData.GetForce(lVar6,0,0)) != null))) {
                if (iVar4 == *(int *)(lVar6 + 16)) {
                  if ((((this.areaIcons == null) ||
                       (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
                      || (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
                     ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 == null ||
                      (*(int64 *)(lVar6 + 24) == 0)))) goto LAB_180d069c3;
                  if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                    if (((this.areaIcons != null) &&
                        (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null)
                       && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                      plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                          goto switchD_180d0494e_default;
                        }
                      }
                    }
                    goto LAB_180d069c3;
                  }
                }
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                  puVar13 = local_78;
                  goto LAB_180d0689a;
                }
              }
            }
            goto LAB_180d069c3;
          case 5:
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) {
        LAB_180d069c3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 112);
            lVar6 = FUN_18046c0a0(0);
            if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
               (lVar6 = HeroData.GetForce(lVar6,0,0)) == null) goto LAB_180d069c3;
            if (iVar4 != *(int *)(lVar6 + 16)) {
              if (((this.areaIcons == null) ||
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94d60), lVar6 == null ||
                   (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
              if (*(int *)(*(int64 *)(lVar6 + 24) + 72) != 2) {
                if (((this.areaIcons != null) &&
                    (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                   (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
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
                      goto switchD_180d0494e_default;
                    }
                  }
                }
                goto LAB_180d069c3;
              }
            }
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            puVar13 = &local_230;
        LAB_180d0689a:
            plVar7 = (int64 *)FUN_1810d33f0(puVar13,0);
        LAB_180d068a4:
            if (plVar5 == (int64 *)0) goto LAB_180d069c3;
            local_298 = *plVar7;
            uStack_290 = (uint32)plVar7[1];
            uStack_28c = *(uint32 *)((int64)plVar7 + 12);
            (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
            if ((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
            goto LAB_180d069c3;
            lVar6 = Transform.GetChild(lVar6,plVar14);
            goto joined_r0x000180d04f0c;
          default:
            goto switchD_180d0494e_default;
          }
          fVar15 = local_270;
          if (plVar5 == (int64 *)0) goto LAB_180d069c9;
        LAB_180d0596a:
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        switchD_180d0494e_default:
          plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
          lVar6 = this.areaIcons;
          goto joined_r0x000180d03f51;
        }
        if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
           (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180d069c3;
        uVar8 = Component.GetComponent(lVar6,DAT_181d94e60);
        cVar2 = Object.op_Inequality(uVar8,0);
        if (!cVar2) {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14)) == null) goto LAB_180d069c3;
          uVar8 = Component.GetComponent(lVar6);
          cVar2 = Object.op_Inequality(uVar8);
          if (!cVar2) goto switchD_180d0494e_default;
          lVar6 = *(int64 *)(lVar1 + 72);
          if (this.quickTravelUIType != 2) {
            if (((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              plVar7 = (int64 *)FUN_1810d33f0(&local_288,0);
              if (plVar5 != (int64 *)0) {
                local_298 = *plVar7;
                uStack_290 = (uint32)plVar7[1];
                uStack_28c = *(uint32 *)((int64)plVar7 + 12);
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
                if ((this.areaIcons != null) &&
                   (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) {
                  lVar6 = Transform.GetChild(lVar6,plVar14);
                  goto joined_r0x000180d04f0c;
                }
              }
            }
            goto LAB_180d069c3;
          }
          if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d3570(&local_278,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14), lVar6 == null ||
              (lVar6 = Component.GetComponent(lVar6)) == null))) goto LAB_180d069c3;
          *(uint32 *)(lVar6 + 32) = 2;
          goto switchD_180d0494e_default;
        }
        lVar6 = FUN_18046c0a0(0);
        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
           (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180d069c3;
        cVar2 = HeroData.HaveForce(lVar6,0);
        if (!cVar2) {
        LAB_180d0489e:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          puVar12 = local_1f8;
        LAB_180d04903:
          plVar7 = (int64 *)FUN_180d98fe0(puVar12,0);
        LAB_180d0490d:
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        else {
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) goto LAB_180d0489e;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          iVar4 = *(int *)(*(int64 *)(lVar6 + 24) + 48);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180d069c3;
          if (iVar4 != *(int *)(lVar6 + 132)) {
            if ((((this.areaIcons != null) &&
                 (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                 ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 != null &&
                  (*(int64 *)(lVar6 + 24) != 0)))))) &&
               (lVar6 = ResourcePointData.GetForce(*(int64 *)(lVar6 + 24),0)) != null) {
              iVar4 = *(int *)(lVar6 + 60);
              lVar6 = FUN_18046c0a0(0);
              if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                 (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                if (iVar4 == *(int *)(lVar6 + 132)) goto LAB_180d047fd;
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  lVar6 = HeroData.GetForce(lVar6,0,0);
                  if (((((this.areaIcons != null) &&
                        (lVar10 = GameObject.get_transform(this.areaIcons,0)) != null
                        ) && (lVar10 = Transform.GetChild(lVar10,plVar14,0)) != null) &&
                      ((lVar10 = Component.GetComponent(lVar10,DAT_181d94e60), lVar10 != null &&
                       (*(int64 *)(lVar10 + 24) != 0)))) && (lVar6 != null)) {
                    fVar15 = (float)ForceData.GetForceFavor
                                              (lVar6,*(uint32 *)(*(int64 *)(lVar10 + 24) + 48),
                                               0);
                    if (80.0 <= fVar15) {
                      if (((this.areaIcons != null) &&
                          (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null
                          ) && ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                        plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                        plVar7 = (int64 *)Color.get_blue(local_208,0);
                        goto LAB_180d0490d;
                      }
                    }
                    else {
                      lVar6 = FUN_18046c0a0(0);
                      if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                         (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                        lVar6 = HeroData.GetForce(lVar6,0,0);
                        if ((((this.areaIcons != null) &&
                             (lVar10 = GameObject.get_transform(this.areaIcons,0),
                             lVar10 != null)) &&
                            ((lVar10 = Transform.GetChild(lVar10,plVar14,0), lVar10 != null &&
                             ((lVar10 = Component.GetComponent(lVar10,DAT_181d94e60), lVar10 != null &&
                              (*(int64 *)(lVar10 + 24) != 0)))))) && (lVar6 != null)) {
                          fVar15 = (float)ForceData.GetForceFavor
                                                    (lVar6,*(uint32 *)
                                                            (*(int64 *)(lVar10 + 24) + 48),0);
                          lVar6 = *(int64 *)(lVar1 + 72);
                          if (fVar15 < 40.0) {
                            if ((((lVar6 != null) && (lVar6 = GameObject.get_transform(lVar6,0)) != null
                                 ) && (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) &&
                               (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null) {
                              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                              lVar6 = pStatics_3d40;
                              if (plVar5 != (int64 *)0) {
                                uVar3 = *(uint32 *)(lVar6 + 0x2f0);
                                uVar17 = *(uint32 *)(lVar6 + 0x2f4);
                                uStack_290 = *(uint32 *)(lVar6 + 0x2f8);
                                uStack_28c = *(uint32 *)(lVar6 + 0x2fc);
                                goto LAB_180d04767;
                              }
                            }
                          }
                          else if (((lVar6 != null) &&
                                   (lVar6 = GameObject.get_transform(lVar6,0)) != null) &&
                                  ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                                   (lVar6 = Transform.Find(lVar6,"OutLine",0)) != null))) {
                            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
                            puVar12 = local_240;
                            goto LAB_180d04903;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180d069c3;
          }
        LAB_180d047fd:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Transform.Find(lVar6,"OutLine",0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          lVar6 = pStatics_3d40;
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          uVar3 = *(uint32 *)(lVar6 + 0x288);
          uVar17 = *(uint32 *)(lVar6 + 0x28c);
          uStack_290 = *(uint32 *)(lVar6 + 0x290);
          uStack_28c = *(uint32 *)(lVar6 + 0x294);
        LAB_180d04767:
          local_298 = CONCAT44(uVar17,uVar3);
          (**(code **)(*plVar5 + 0x2a8))(plVar5);
        }
        switch(this.quickTravelUIType) {
        case 0:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d94e60)) == null) goto LAB_180d069c3;
          *(uint32 *)(lVar6 + 32) = 0;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          lVar10 = *(int64 *)(lVar1 + 72);
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) != -1) {
            if (((lVar10 != null) && (lVar6 = GameObject.get_transform(lVar10,0)) != null) &&
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
              if (((this.areaIcons != null) &&
                  (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
                 ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 != null &&
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 != null &&
                   (*(int64 *)(lVar6 + 24) != 0)))))) {
                plVar7 = (int64 *)
                         ResourcePointData.GetForceColor(local_1e8,*(int64 *)(lVar6 + 24),0);
                goto joined_r0x000180d04b0f;
              }
            }
            goto LAB_180d069c3;
          }
          if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d3570(local_1d8,0);
          goto joined_r0x000180d04b0f;
        case 1:
          if (((this.areaIcons != null) &&
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) != null) &&
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) != null) {
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            plVar7 = (int64 *)FUN_1810d33f0(local_1c8,0);
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
          goto LAB_180d069c3;
        case 2:
          if ((((this.areaIcons == null) ||
               (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
              (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) ||
             (lVar6 = Component.GetComponent(lVar6,DAT_181d94e60)) == null) goto LAB_180d069c3;
          *(uint32 *)(lVar6 + 32) = 2;
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
              ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
               (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
          lVar10 = *(int64 *)(lVar1 + 72);
          if (*(int *)(*(int64 *)(lVar6 + 24) + 48) == -1) {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            plVar7 = (int64 *)FUN_1810d3570(local_1a8,0);
          }
          else {
            if (((lVar10 == null) || (lVar6 = GameObject.get_transform(lVar10,0)) == null) ||
               (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
            plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
            if (((this.areaIcons == null) ||
                (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
               ((lVar6 = Transform.GetChild(lVar6,plVar14,0), lVar6 == null ||
                ((lVar6 = Component.GetComponent(lVar6,DAT_181d94e60), lVar6 == null ||
                 (*(int64 *)(lVar6 + 24) == 0)))))) goto LAB_180d069c3;
            plVar7 = (int64 *)ResourcePointData.GetForceColor(local_1b8,*(int64 *)(lVar6 + 24),0)
            ;
          }
        joined_r0x000180d04b0f:
          if (plVar5 != (int64 *)0) goto LAB_180d0596a;
          goto LAB_180d069c3;
        case 3:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d33f0(local_198,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180d069c3;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 4:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d33f0(local_188,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180d069c3;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        case 5:
          if (((this.areaIcons == null) ||
              (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null) ||
             (lVar6 = Transform.GetChild(lVar6,plVar14,0)) == null) goto LAB_180d069c3;
          plVar5 = (int64 *)Component.GetComponent(lVar6,DAT_181d94460);
          plVar7 = (int64 *)FUN_1810d33f0(local_178,0);
          if (plVar5 == (int64 *)0) goto LAB_180d069c3;
          local_298 = *plVar7;
          uStack_290 = (uint32)plVar7[1];
          uStack_28c = *(uint32 *)((int64)plVar7 + 12);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_298);
          if ((this.areaIcons == null) ||
             (lVar6 = GameObject.get_transform(this.areaIcons,0)) == null)
          goto LAB_180d069c3;
          lVar6 = Transform.GetChild(lVar6,plVar14);
          break;
        default:
          goto switchD_180d0494e_default;
        }
        joined_r0x000180d04f0c:
        if (lVar6 != null) {
          lVar6 = Component.GetComponent(lVar6);
        joined_r0x000180d0631f:
          if (lVar6 != null) {
        LAB_180d06919:
            *(uint32 *)(lVar6 + 32) = 0;
            goto switchD_180d0494e_default;
          }
        }
        goto LAB_180d069c3;
    }

    // Token : 0x6002045
    // RVA   : 0xD06EB0   Offset: 0xD062B0   Length: 0xC6
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d917d8);
        FUN_18132faf0(lVar1,DAT_181d804a0);
        if (lVar1 != null) {
          FUN_1817e98e0(lVar1,1,DAT_181d80520);
          FUN_1817e98e0(lVar1,1,DAT_181d80520);
          FUN_1817e98e0(lVar1,1,DAT_181d80520);
          this.showAreaType = lVar1;
          this.showInn = 1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x6002046
    // RVA   : 0x8CBD70   Offset: 0x8CB170   Length: 0x20
    private void <HideQuickTravelUI>b__49_0()
    {
        if (this.quickTravelUI != null) {
          GameObject.SetActive(this.quickTravelUI,0,0);
          return;
        }
    }

}
