// ============================================================
// Type  : SkyController
// Token : 0x200036E
// ============================================================

public class SkyController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C4E
    public List<Sprite> cloudSprites;

    // Token: 0x4001C4F
    public GameObject cloudPrefab;

    // Token: 0x4001C50
    public GameObject birdPrefab;

    // Token: 0x4001C51
    public List<GameObject> clouds;

    // Token: 0x4001C52
    public List<GameObject> birds;

    // Token: 0x4001C53
    public List<GameObject> areaClouds;

    // Token: 0x4001C54
    public List<GameObject> areaBirds;

    // Token: 0x4001C55
    private GameObject newObj;

    // Token: 0x4001C56
    private static SkyController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021DF
    // RVA   : 0x6B2C80   Offset: 0x6B1A80   Length: 0x36
    public static SkyController get_Instance()
    {
        return **(uint64 **)(DAT_181e83a28 + 184);
    }

    // Token : 0x60021E0
    // RVA   : 0x6B1240   Offset: 0x6B0040   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e83a28 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60021E1
    // RVA   : 0x6B2C10   Offset: 0x6B1A10   Length: 0x63
    private void Start()
    {
        long lVar1;
        SkyController.RefreshCloud(this,0,0);
        lVar1 = 20;
        do {
          SkyController.GenerateBird(this,0,0,0);
          lVar1 = lVar1 + -1;
        } while (lVar1 != null);
        lVar1 = 10;
        do {
          SkyController.GenerateBird(this,1,0);
          lVar1 = lVar1 + -1;
        } while (lVar1 != null);
    }

    // Token : 0x60021E2
    // RVA   : 0x6B2890   Offset: 0x6B1690   Length: 0x336
    public void RefreshCloud(bool fromStart)
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        lVar3 = BattleController.AttackAreaTypeStartMovePower;
        if ((lVar3 != null) && (lVar3 = WeatherController.GetNowWeather(lVar3,0)) != null) {
          iVar1 = Mathf.RoundToInt(*(float *)(lVar3 + 88) * 40.0,0);
          lVar3 = this.clouds;
          if (lVar3 != null) {
            while (lVar3.Count != iVar1) {
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count < iVar1) {
                SkyController.GenerateCloud(this,0,0,fromStart,0);
              }
              else {
                uVar2 = FUN_180af1860(0,lVar3.Count,0);
                lVar3 = FUN_1800024b0(lVar3,uVar2,DAT_181e6bc70);
                if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181e540f0)) == null)
                   || (*(uint8 *)(lVar3 + 72) = 1, this.clouds == null))
                throw; // [null/range check failed]
                FUN_181665e90();
              }
              lVar3 = this.clouds;
              if (lVar3 == null) throw; // [null/range check failed]
            }
            lVar3 = BattleController.AttackAreaTypeStartMovePower;
            if ((lVar3 != null) && (lVar3 = WeatherController.GetNowWeather(lVar3,0)) != null) {
              iVar1 = Mathf.RoundToInt(*(float *)(lVar3 + 88) * 20.0,0);
              lVar3 = this.areaClouds;
              if (lVar3 != null) goto LAB_1806b2b10;
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar3.Count < iVar1) {
            SkyController.GenerateCloud(this,1,0,fromStart,0);
          }
          else {
            uVar2 = FUN_180af1860(0,lVar3.Count,0);
            lVar3 = FUN_1800024b0(lVar3,uVar2,DAT_181e6bc70);
            if ((lVar3 == null) || (lVar4 = GameObject.GetComponent(lVar3,DAT_181e540f0)) == null)
            break;
            *(uint8 *)(lVar4 + 72) = 1;
            if (this.areaClouds == null) break;
            FUN_181665e90(this.areaClouds,lVar3);
          }
          lVar3 = this.areaClouds;
          if (lVar3 == null) break;
        LAB_1806b2b10:
          if (lVar3.Count == iVar1) {
            return;
          }
          if (lVar3 == null) break;
        }
    }

    // Token : 0x60021E3
    // RVA   : 0x6B1A00   Offset: 0x6B0800   Length: 0x8EA
    public GameObject GenerateCloud(SkyObjType skyObjType, bool fromBorder, bool fromStart)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        float fVar8;
        uint uVar9;
        float fVar10;
        float fVar11;
        ulong local_d8;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        local_78 = 0;
        local_88 = 0;
        uStack_80 = 0;
        uVar2 = SkyController.GetSkyObjRoot(this,skyObjType,1);
        uVar3 = this.cloudPrefab;
        uVar3 = GlobalData.AddChild(uVar2,uVar3,0);
        this.newObj = uVar3;
        fVar11 = local_c0;
        if (this.newObj != null) {
          lVar4 = GameObject.GetComponent(this.newObj,DAT_181e56c80);
          lVar5 = this.cloudSprites;
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_1806b22e5;
          uVar1 = FUN_180af1860(0,lVar5.Count,0);
          if (lVar5.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar11 = local_c0;
          if (lVar4 == null) goto LAB_1806b22e5;
          SpriteRenderer.set_sprite
                    (lVar4,lVar5._items[uVar1],
                     0);
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar5 = GameObject.get_transform(this.newObj,0);
          fVar10 = 1.0;
          if (skyObjType == null) {
            fVar11 = 1.0;
          }
          else {
            fVar11 = 0.5;
          }
          fVar8 = (float)Random.Range(0x3f800000,0x40800000,0);
          puVar6 = (uint64 *)Vector3.get_one(&local_a8,0);
          fVar8 = fVar8 * fVar11;
          local_b8 = *puVar6;
          local_b0 = *(float *)(puVar6 + 1);
          local_c0 = local_b0 * fVar8;
          local_d8 = CONCAT44((float)((uint64)local_b8 >> 32) * fVar8,(float)local_b8 * fVar8);
          local_c8 = local_b8;
          fVar11 = local_b0;
          if (lVar5 == null) goto LAB_1806b22e5;
          local_c8 = local_d8;
          Transform.set_localScale(lVar5,&local_c8,0);
          fVar11 = local_c0;
          if ((this.newObj == null) ||
             (lVar5 = GameObject.GetComponent(this.newObj,DAT_181e540f0),
             fVar11 = local_c0, lVar5 == null)) goto LAB_1806b22e5;
          lVar5.Count = skyObjType;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar5 = GameObject.GetComponent(this.newObj,DAT_181e540f0);
          uVar9 = Random.Range(0x3f333333,0x3f666666,0);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_1806b22e5;
          *(uint32 *)(lVar5 + 36) = uVar9;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar5 = GameObject.GetComponent(this.newObj,DAT_181e540f0);
          fVar8 = (float)Random.get_value(0);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_1806b22e5;
          lVar5._version = fVar8 < 0.5;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar5 = GameObject.GetComponent(this.newObj,DAT_181e540f0);
          if (skyObjType != null) {
            fVar10 = 1.5;
          }
          fVar8 = (float)Random.Range(0x3dcccccd,0x3f4ccccd,0);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_1806b22e5;
          *(float *)(lVar5 + 32) = fVar8 * fVar10;
          if (!fromBorder) {
            fVar11 = (float)SkyController.GetMapSize(this,skyObjType,1,0);
            fVar10 = (float)SkyController.GetMapSize(this,skyObjType,1,0);
            fVar10 = (float)Random.Range(fVar11 * -0.5,fVar10 * 0.5,0);
          }
          else {
            if ((this.newObj == null) ||
               (lVar5 = GameObject.GetComponent(this.newObj,DAT_181e540f0),
               fVar11 = local_c0, lVar5 == null)) goto LAB_1806b22e5;
            if (!lVar5._version) {
              fVar10 = (float)SkyController.GetMapSize(this,skyObjType,1);
              fVar11 = local_c0;
              if (((this.newObj == null) ||
                  (lVar5 = GameObject.GetComponent(this.newObj,DAT_181e56c80),
                  fVar11 = local_c0, lVar5 == null)) ||
                 (lVar5 = SpriteRenderer.get_sprite(lVar5,0), fVar11 = local_c0) == null)
              goto LAB_1806b22e5;
              puVar6 = (uint64 *)Sprite.get_bounds(&local_a8,lVar5,0);
              local_88 = *puVar6;
              uStack_80 = puVar6[1];
              local_78 = puVar6[2];
              pfVar7 = (float *)Bounds.get_size(&local_a8,&local_88,0);
              fVar8 = *pfVar7;
              fVar11 = local_c0;
              if ((this.newObj == null) ||
                 (lVar5 = GameObject.get_transform(this.newObj,0), fVar11 = local_c0,
                 lVar5 == null)) goto LAB_1806b22e5;
              pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar5,0);
              fVar10 = fVar8 * 0.5 * *pfVar7 + fVar10 * 0.5;
            }
            else {
              fVar10 = (float)SkyController.GetMapSize(this,skyObjType);
              fVar11 = local_c0;
              if (((this.newObj == null) ||
                  (lVar5 = GameObject.GetComponent(this.newObj,DAT_181e56c80),
                  fVar11 = local_c0, lVar5 == null)) ||
                 (lVar5 = SpriteRenderer.get_sprite(lVar5,0), fVar11 = local_c0) == null)
              goto LAB_1806b22e5;
              puVar6 = (uint64 *)Sprite.get_bounds(&local_a8,lVar5,0);
              local_88 = *puVar6;
              uStack_80 = puVar6[1];
              local_78 = puVar6[2];
              pfVar7 = (float *)Bounds.get_size(&local_a8,&local_88,0);
              fVar8 = *pfVar7;
              fVar11 = local_c0;
              if ((this.newObj == null) ||
                 (lVar5 = GameObject.get_transform(this.newObj,0), fVar11 = local_c0,
                 lVar5 == null)) goto LAB_1806b22e5;
              pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar5,0);
              fVar10 = fVar10 * -0.5 - fVar8 * 0.5 * *pfVar7;
            }
          }
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar5 = GameObject.get_transform(this.newObj,0);
          if (skyObjType == null) {
            lVar4 = FUN_180210220(0);
            fVar11 = local_c0;
            if (lVar4 == null) goto LAB_1806b22e5;
            fVar8 = *(float *)(lVar4 + 52);
          }
          else if (skyObjType == 1) {
            fVar8 = *(float *)(pStatics + 172);
            fVar8 = fVar8 + fVar8;
          }
          else {
            fVar8 = 0.0;
          }
          if (skyObjType == null) {
            lVar4 = FUN_180210220(0);
            fVar11 = local_c0;
            if (lVar4 == null) goto LAB_1806b22e5;
            fVar11 = *(float *)(lVar4 + 52);
          }
          else if (skyObjType == 1) {
            fVar11 = *(float *)(pStatics + 172);
            fVar11 = fVar11 + fVar11;
          }
          else {
            fVar11 = 0.0;
          }
          uVar9 = Random.Range(fVar8 * -0.5,fVar11 * 0.5,0);
          local_d8 = CONCAT44(uVar9,fVar10);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_1806b22e5;
          local_c8 = local_d8;
          local_c0 = 0.0;
          Transform.set_localPosition(lVar5,&local_c8,0);
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar5 = GameObject.get_transform(this.newObj,0);
          fVar11 = local_c0;
          if ((this.newObj == null) ||
             (lVar4 = GameObject.get_transform(this.newObj,0), fVar11 = local_c0,
             lVar4 == null)) goto LAB_1806b22e5;
          puVar6 = (uint64 *)Transform.get_localPosition(&local_a8,lVar4,0);
          local_b8 = *puVar6;
          local_b0 = *(float *)(puVar6 + 1);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_1806b22e5;
          local_c8 = local_b8;
          local_c0 = (float)((uint64)local_b8 >> 32) * 0.001 - 10.0;
          Transform.set_localPosition(lVar5,&local_c8,0);
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_1806b22e5;
          lVar4 = GameObject.GetComponent(this.newObj,DAT_181e56c80);
          lVar5 = this.newObj;
          fVar11 = local_c0;
          if (!fromStart) {
            if ((lVar5 == null) ||
               (lVar5 = GameObject.GetComponent(lVar5,DAT_181e540f0), fVar11 = local_c0) == null)
            goto LAB_1806b22e5;
            puVar6 = (uint64 *)CloudController.GetTargetColor(&local_a8,lVar5,0);
          }
          else {
            if ((lVar5 == null) ||
               (lVar5 = GameObject.GetComponent(lVar5,DAT_181e540f0), fVar11 = local_c0) == null)
            goto LAB_1806b22e5;
            puVar6 = (uint64 *)CloudController.GetTargetColor(&local_a8,lVar5,0);
            local_a8 = *puVar6;
            uStack_a0 = puVar6[1];
            puVar6 = (uint64 *)GlobalData.SetColorAlpha(&local_b8,&local_a8,0,0);
          }
          fVar11 = local_c0;
          if (lVar4 == null) goto LAB_1806b22e5;
          local_a8 = *puVar6;
          uStack_a0 = puVar6[1];
          SpriteRenderer.set_color(lVar4,&local_a8,0);
          if (skyObjType == null) {
            lVar5 = this.clouds;
          }
          else {
            if (skyObjType == 1)
            {
              lVar5 = this.areaClouds;
              }
              fVar11 = local_c0;
              if (lVar5 != null) {
              FUN_18175de30(lVar5,this.newObj,DAT_181e6b6f8);
            }
            return this.newObj;
          }
        }
        LAB_1806b22e5:
        local_c0 = fVar11;
    }

    // Token : 0x60021E4
    // RVA   : 0x6B1330   Offset: 0x6B0130   Length: 0x9F
    public void DestroyCloud(GameObject target)
    {
        if (this.clouds != null) {
          FUN_181665e90(this.clouds,target,DAT_181e6b978);
          if (this.areaClouds != null) {
            FUN_181665e90(this.areaClouds,target,DAT_181e6b978);
            Object.Destroy(target,0);
            return;
          }
        }
    }

    // Token : 0x60021E5
    // RVA   : 0x6B2BD0   Offset: 0x6B19D0   Length: 0x3B
    public Vector3 SetSkyZPos(Vector3 originPos)
    {
        float fVar1;
        fVar1 = (float)((uint64)*param_3 >> 32);
        *this = *(uint32 *)param_3;
        this[1] = fVar1;
        this[2] = fVar1 * 0.001 - 10.0;
        return this;
    }

    // Token : 0x60021E6
    // RVA   : 0x6B13D0   Offset: 0x6B01D0   Length: 0x627
    public void GenerateBird(SkyObjType skyObjType, bool fromBorder)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar5;
        float fVar6;
        uint uVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        ulong local_a8;
        ulong local_98;
        float local_90;
        byte[] local_78 = new byte[96];
        uVar1 = SkyController.GetSkyObjRoot(this,skyObjType,0);
        uVar2 = this.birdPrefab;
        uVar2 = GlobalData.AddChild(uVar1,uVar2,0);
        this.newObj = uVar2;
        fVar9 = local_90;
        if (this.newObj != null) {
          lVar3 = GameObject.get_transform(this.newObj,0);
          fVar8 = 1.0;
          if (skyObjType == null) {
            fVar9 = 1.0;
          }
          else {
            fVar9 = 0.5;
          }
          fVar6 = (float)Random.Range(0x3fcccccd,0x4019999a,0);
          puVar4 = (uint64 *)Vector3.get_one(local_78,0);
          fVar6 = fVar6 * fVar9;
          local_98 = *puVar4;
          local_90 = *(float *)(puVar4 + 1) * fVar6;
          local_a8 = CONCAT44((float)((uint64)local_98 >> 32) * fVar6,(float)local_98 * fVar6);
          fVar9 = *(float *)(puVar4 + 1);
          if (lVar3 != null) {
            local_98 = local_a8;
            Transform.set_localScale(lVar3,&local_98,0);
            fVar9 = local_90;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181e537e8),
               fVar9 = local_90, lVar3 != null)) {
              lVar3.Count = skyObjType;
              if (this.newObj != null) {
                lVar3 = GameObject.GetComponent(this.newObj,DAT_181e537e8);
                fVar6 = (float)Random.get_value(0);
                fVar9 = local_90;
                if (lVar3 != null) {
                  lVar3._version = fVar6 < 0.5;
                  if (this.newObj != null) {
                    lVar3 = GameObject.GetComponent(this.newObj,DAT_181e56c80);
                    fVar9 = local_90;
                    if (((this.newObj != null) &&
                        (lVar5 = GameObject.GetComponent(this.newObj,DAT_181e537e8),
                        fVar9 = local_90, lVar5 != null)) && (lVar3 != null)) {
                      SpriteRenderer.set_flipX(lVar3,*(char *)(lVar5 + 28) != false,0);
                      fVar9 = local_90;
                      if (this.newObj != null) {
                        lVar3 = GameObject.GetComponent(this.newObj,DAT_181e537e8);
                        if (skyObjType != null) {
                          fVar8 = 1.5;
                        }
                        fVar6 = (float)Random.Range(0x3f19999a,0x3f99999a,0);
                        fVar9 = local_90;
                        if (lVar3 != null) {
                          *(float *)(lVar3 + 32) = fVar6 * fVar8;
                          if (!fromBorder) {
                            fVar9 = (float)SkyController.GetMapSize(this,skyObjType,1,0);
                            fVar8 = (float)SkyController.GetMapSize(this,skyObjType,1,0);
                            fVar8 = (float)Random.Range(fVar9 * -0.5,fVar8 * 0.5,0);
                          }
                          else {
                            if ((this.newObj == null) ||
                               (lVar3 = GameObject.GetComponent
                                                  (this.newObj,DAT_181e537e8),
                               fVar9 = local_90, lVar3 == null)) goto LAB_1806b19f2;
                            if (!lVar3._version) {
                              fVar9 = (float)SkyController.GetMapSize(this,skyObjType,1);
                              fVar8 = fVar9 * 0.5 + 0.2;
                            }
                            else {
                              fVar9 = (float)SkyController.GetMapSize(this,skyObjType,1);
                              fVar8 = fVar9 * -0.5 - 0.2;
                            }
                          }
                          fVar9 = local_90;
                          if (this.newObj != null) {
                            lVar3 = GameObject.get_transform(this.newObj,0);
                            fVar6 = 0.0;
                            if (skyObjType == null) {
                              lVar5 = FUN_180210220(0);
                              fVar9 = local_90;
                              if (lVar5 == null) goto LAB_1806b19f2;
                              fVar10 = *(float *)(lVar5 + 52);
                            }
                            else if (skyObjType == 1) {
                              fVar10 = *(float *)(pStatics + 172);
                              fVar10 = fVar10 + fVar10;
                            }
                            else {
                              fVar10 = 0.0;
                            }
                            if (skyObjType == null) {
                              lVar5 = FUN_180210220(0);
                              fVar9 = local_90;
                              if (lVar5 == null) goto LAB_1806b19f2;
                              fVar6 = *(float *)(lVar5 + 52);
                            }
                            else if (skyObjType == 1) {
                              fVar6 = *(float *)(pStatics + 172);
                              fVar6 = fVar6 + fVar6;
                            }
                            uVar7 = Random.Range(fVar10 * -0.5,fVar6 * 0.5,0);
                            local_a8 = CONCAT44(uVar7,fVar8);
                            fVar9 = local_90;
                            if (lVar3 != null) {
                              local_98 = local_a8;
                              local_90 = 0.0;
                              Transform.set_localPosition(lVar3,&local_98,0);
                              fVar9 = local_90;
                              if (this.newObj != null) {
                                lVar3 = GameObject.get_transform(this.newObj,0);
                                fVar9 = local_90;
                                if ((this.newObj != null) &&
                                   (lVar5 = GameObject.get_transform(this.newObj,0),
                                   fVar9 = local_90, lVar5 != null)) {
                                  puVar4 = (uint64 *)Transform.get_localPosition(local_78,lVar5,0);
                                  fVar9 = local_90;
                                  if (lVar3 != null) {
                                    local_98 = *puVar4;
                                    local_90 = (float)((uint64)*puVar4 >> 32) * 0.001 - 10.0;
                                    Transform.set_localPosition(lVar3,&local_98,0);
                                    if (skyObjType == null) {
                                      lVar3 = this.birds;
                                    }
                                    else {
                                      if (skyObjType != 1) {
                                        return;
                                      }
                                      lVar3 = this.areaBirds;
                                    }
                                    fVar9 = local_90;
                                    if (lVar3 != null) {
                                      FUN_18175de30(lVar3,this.newObj,DAT_181e6b6f8);
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
        LAB_1806b19f2:
        local_90 = fVar9;
    }

    // Token : 0x60021E7
    // RVA   : 0x6B1290   Offset: 0x6B0090   Length: 0x9F
    public void DestroyBird(GameObject target)
    {
        if (this.birds != null) {
          FUN_181665e90(this.birds,target,DAT_181e6b978);
          if (this.areaBirds != null) {
            FUN_181665e90(this.areaBirds,target,DAT_181e6b978);
            Object.Destroy(target,0);
            return;
          }
        }
    }

    // Token : 0x60021E8
    // RVA   : 0x6B2720   Offset: 0x6B1520   Length: 0x16D
    public GameObject GetSkyObjRoot(SkyObjType skyObjType, bool isCloud)
    {
        long lVar1;
        ulong uVar2;
        if (skyObjType == null) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e90e50 + 184) + 16);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = *(int64 *)(lVar1 + 64);
        }
        else {
          if (skyObjType != 1) {
            return false;
          }
          lVar1 = FUN_180210060(0);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = *(int64 *)(lVar1 + 80);
        }
        if (lVar1 != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          uVar2 = "Bird";
          if (isCloud) {
            uVar2 = "Cloud";
          }
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,uVar2,0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              return uVar2;
            }
          }
        }
    }

    // Token : 0x60021E9
    // RVA   : 0x6B22F0   Offset: 0x6B10F0   Length: 0x159
    public float GetMapSize(SkyObjType skyObjType, bool mapWidth)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        float fVar1;
        long lVar2;
        if (skyObjType == null) {
          if (!mapWidth) {
            lVar2 = FUN_180210220(0);
            if (lVar2 != null) {
              return *(float *)(lVar2 + 52);
            }
          }
          else {
            lVar2 = FUN_180210220(0);
            if (lVar2 != null) {
              return *(float *)(lVar2 + 48);
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (skyObjType != 1) {
          return 0.0;
        }
        if (mapWidth) {
          fVar1 = *(float *)(pStatics + 168);
          return fVar1 + fVar1;
        }
        fVar1 = *(float *)(pStatics + 172);
        return fVar1 + fVar1;
    }

    // Token : 0x60021EA
    // RVA   : 0x6B2450   Offset: 0x6B1250   Length: 0x2CC
    public float GetScaleAlphaPercent(SkyObjType skyObjType)
    {
        var pStatics_c8b0 = *(int64*)(DAT_181e8c8b0 + 184);
        float fVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        if (skyObjType != null) {
          if (skyObjType == 1) {
            fVar4 = *(float *)(pStatics_c8b0 + 20);
            lVar2 = PlotController.SpringFestivelRewardLvTalkText;
            if (lVar2 == null) throw; // [null/range check failed]
            fVar3 = (float)AreaController.AreaMapNowScale(lVar2,0);
            fVar4 = (fVar4 - fVar3) /
                    (*(float *)(pStatics_c8b0 + 20) -
                    PlotController.livingSkillIndexCache);
          }
          else {
            fVar4 = 0.0;
          }
          return fVar4;
        }
        lVar2 = GameController.CheckShowSpeHero;
        if (lVar2 != null) {
          fVar4 = *(float *)(lVar2 + 24);
          lVar2 = GameController.CheckShowSpeHero;
          if (lVar2 != null) {
            fVar3 = (float)BigMapController.BigMapNowScale(lVar2,0);
            lVar2 = GameController.CheckShowSpeHero;
            if (lVar2 != null) {
              fVar1 = *(float *)(lVar2 + 24);
              lVar2 = GameController.CheckShowSpeHero;
              if (lVar2 != null) {
                return (fVar4 - fVar3) / (fVar1 - *(float *)(lVar2 + 28));
              }
            }
          }
        }
    }

    // Token : 0x60021EB
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
