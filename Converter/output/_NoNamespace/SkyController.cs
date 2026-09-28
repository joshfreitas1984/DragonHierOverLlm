// ============================================================
// Type  : SkyController
// Token : 0x2000361
// ============================================================

public class SkyController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BBB
    public List<Sprite> cloudSprites;

    // Token: 0x4001BBC
    public GameObject cloudPrefab;

    // Token: 0x4001BBD
    public GameObject birdPrefab;

    // Token: 0x4001BBE
    public List<GameObject> clouds;

    // Token: 0x4001BBF
    public List<GameObject> birds;

    // Token: 0x4001BC0
    public List<GameObject> areaClouds;

    // Token: 0x4001BC1
    public List<GameObject> areaBirds;

    // Token: 0x4001BC2
    private GameObject newObj;

    // Token: 0x4001BC3
    private static SkyController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002135
    // RVA   : 0x98AEA0   Offset: 0x98A2A0   Length: 0x36
    public static SkyController get_Instance()
    {
        return **(uint64 **)(DAT_181da35d0 + 184);
    }

    // Token : 0x6002136
    // RVA   : 0x989460   Offset: 0x988860   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da35d0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002137
    // RVA   : 0x98AE30   Offset: 0x98A230   Length: 0x63
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

    // Token : 0x6002138
    // RVA   : 0x98AAB0   Offset: 0x989EB0   Length: 0x336
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
                uVar2 = FUN_180d95a30(0,lVar3.Count,0);
                lVar3 = FUN_180002f80(lVar3,uVar2,DAT_181d89918);
                if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc8040)) == null)
                   || (*(uint8 *)(lVar3 + 72) = 1, this.clouds == null))
                throw; // [null/range check failed]
                FUN_1817eee00();
              }
              lVar3 = this.clouds;
              if (lVar3 == null) throw; // [null/range check failed]
            }
            lVar3 = BattleController.AttackAreaTypeStartMovePower;
            if ((lVar3 != null) && (lVar3 = WeatherController.GetNowWeather(lVar3,0)) != null) {
              iVar1 = Mathf.RoundToInt(*(float *)(lVar3 + 88) * 20.0,0);
              lVar3 = this.areaClouds;
              if (lVar3 != null) goto LAB_18098ad30;
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar3.Count < iVar1) {
            SkyController.GenerateCloud(this,1,0,fromStart,0);
          }
          else {
            uVar2 = FUN_180d95a30(0,lVar3.Count,0);
            lVar3 = FUN_180002f80(lVar3,uVar2,DAT_181d89918);
            if ((lVar3 == null) || (lVar4 = GameObject.GetComponent(lVar3,DAT_181dc8040)) == null)
            break;
            *(uint8 *)(lVar4 + 72) = 1;
            if (this.areaClouds == null) break;
            FUN_1817eee00(this.areaClouds,lVar3);
          }
          lVar3 = this.areaClouds;
          if (lVar3 == null) break;
        LAB_18098ad30:
          if (lVar3.Count == iVar1) {
            return;
          }
          if (lVar3 == null) break;
        }
    }

    // Token : 0x6002139
    // RVA   : 0x989C20   Offset: 0x989020   Length: 0x8EA
    public GameObject GenerateCloud(SkyObjType skyObjType, bool fromBorder, bool fromStart)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
          lVar4 = GameObject.GetComponent(this.newObj,DAT_181d73bb8);
          lVar5 = this.cloudSprites;
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_18098a505;
          uVar1 = FUN_180d95a30(0,lVar5.Count,0);
          if (lVar5.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar11 = local_c0;
          if (lVar4 == null) goto LAB_18098a505;
          SpriteRenderer.set_sprite
                    (lVar4,lVar5._items[uVar1],
                     0);
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_18098a505;
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
          if (lVar5 == null) goto LAB_18098a505;
          local_c8 = local_d8;
          Transform.set_localScale(lVar5,&local_c8,0);
          fVar11 = local_c0;
          if ((this.newObj == null) ||
             (lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc8040),
             fVar11 = local_c0, lVar5 == null)) goto LAB_18098a505;
          lVar5.Count = skyObjType;
          if (this.newObj == null) goto LAB_18098a505;
          lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc8040);
          uVar9 = Random.Range(0x3f333333,0x3f666666,0);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_18098a505;
          *(uint32 *)(lVar5 + 36) = uVar9;
          if (this.newObj == null) goto LAB_18098a505;
          lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc8040);
          fVar8 = (float)Random.get_value(0);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_18098a505;
          lVar5._version = fVar8 < 0.5;
          if (this.newObj == null) goto LAB_18098a505;
          lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc8040);
          if (skyObjType != null) {
            fVar10 = 1.5;
          }
          fVar8 = (float)Random.Range(0x3dcccccd,0x3f4ccccd,0);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_18098a505;
          *(float *)(lVar5 + 32) = fVar8 * fVar10;
          if (!fromBorder) {
            fVar11 = (float)SkyController.GetMapSize(this,skyObjType,1,0);
            fVar10 = (float)SkyController.GetMapSize(this,skyObjType,1,0);
            fVar10 = (float)Random.Range(fVar11 * -0.5,fVar10 * 0.5,0);
          }
          else {
            if ((this.newObj == null) ||
               (lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc8040),
               fVar11 = local_c0, lVar5 == null)) goto LAB_18098a505;
            if (!lVar5._version) {
              fVar10 = (float)SkyController.GetMapSize(this,skyObjType,1);
              fVar11 = local_c0;
              if (((this.newObj == null) ||
                  (lVar5 = GameObject.GetComponent(this.newObj,DAT_181d73bb8),
                  fVar11 = local_c0, lVar5 == null)) ||
                 (lVar5 = SpriteRenderer.get_sprite(lVar5,0), fVar11 = local_c0) == null)
              goto LAB_18098a505;
              puVar6 = (uint64 *)Sprite.get_bounds(&local_a8,lVar5,0);
              local_88 = *puVar6;
              uStack_80 = puVar6[1];
              local_78 = puVar6[2];
              pfVar7 = (float *)Bounds.get_size(&local_a8,&local_88,0);
              fVar8 = *pfVar7;
              fVar11 = local_c0;
              if ((this.newObj == null) ||
                 (lVar5 = GameObject.get_transform(this.newObj,0), fVar11 = local_c0,
                 lVar5 == null)) goto LAB_18098a505;
              pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar5,0);
              fVar10 = fVar8 * 0.5 * *pfVar7 + fVar10 * 0.5;
            }
            else {
              fVar10 = (float)SkyController.GetMapSize(this,skyObjType);
              fVar11 = local_c0;
              if (((this.newObj == null) ||
                  (lVar5 = GameObject.GetComponent(this.newObj,DAT_181d73bb8),
                  fVar11 = local_c0, lVar5 == null)) ||
                 (lVar5 = SpriteRenderer.get_sprite(lVar5,0), fVar11 = local_c0) == null)
              goto LAB_18098a505;
              puVar6 = (uint64 *)Sprite.get_bounds(&local_a8,lVar5,0);
              local_88 = *puVar6;
              uStack_80 = puVar6[1];
              local_78 = puVar6[2];
              pfVar7 = (float *)Bounds.get_size(&local_a8,&local_88,0);
              fVar8 = *pfVar7;
              fVar11 = local_c0;
              if ((this.newObj == null) ||
                 (lVar5 = GameObject.get_transform(this.newObj,0), fVar11 = local_c0,
                 lVar5 == null)) goto LAB_18098a505;
              pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar5,0);
              fVar10 = fVar10 * -0.5 - fVar8 * 0.5 * *pfVar7;
            }
          }
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_18098a505;
          lVar5 = GameObject.get_transform(this.newObj,0);
          if (skyObjType == null) {
            lVar4 = FUN_18046bbe0(0);
            fVar11 = local_c0;
            if (lVar4 == null) goto LAB_18098a505;
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
            lVar4 = FUN_18046bbe0(0);
            fVar11 = local_c0;
            if (lVar4 == null) goto LAB_18098a505;
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
          if (lVar5 == null) goto LAB_18098a505;
          local_c8 = local_d8;
          local_c0 = 0.0;
          Transform.set_localPosition(lVar5,&local_c8,0);
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_18098a505;
          lVar5 = GameObject.get_transform(this.newObj,0);
          fVar11 = local_c0;
          if ((this.newObj == null) ||
             (lVar4 = GameObject.get_transform(this.newObj,0), fVar11 = local_c0,
             lVar4 == null)) goto LAB_18098a505;
          puVar6 = (uint64 *)Transform.get_localPosition(&local_a8,lVar4,0);
          local_b8 = *puVar6;
          local_b0 = *(float *)(puVar6 + 1);
          fVar11 = local_c0;
          if (lVar5 == null) goto LAB_18098a505;
          local_c8 = local_b8;
          local_c0 = (float)((uint64)local_b8 >> 32) * 0.001 - 10.0;
          Transform.set_localPosition(lVar5,&local_c8,0);
          fVar11 = local_c0;
          if (this.newObj == null) goto LAB_18098a505;
          lVar4 = GameObject.GetComponent(this.newObj,DAT_181d73bb8);
          lVar5 = this.newObj;
          fVar11 = local_c0;
          if (!fromStart) {
            if ((lVar5 == null) ||
               (lVar5 = GameObject.GetComponent(lVar5,DAT_181dc8040), fVar11 = local_c0) == null)
            goto LAB_18098a505;
            puVar6 = (uint64 *)CloudController.GetTargetColor(&local_a8,lVar5,0);
          }
          else {
            if ((lVar5 == null) ||
               (lVar5 = GameObject.GetComponent(lVar5,DAT_181dc8040), fVar11 = local_c0) == null)
            goto LAB_18098a505;
            puVar6 = (uint64 *)CloudController.GetTargetColor(&local_a8,lVar5,0);
            local_a8 = *puVar6;
            uStack_a0 = puVar6[1];
            puVar6 = (uint64 *)GlobalData.SetColorAlpha(&local_b8,&local_a8,0,0);
          }
          fVar11 = local_c0;
          if (lVar4 == null) goto LAB_18098a505;
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
              FUN_18181e0a0(lVar5,this.newObj,DAT_181d89398);
            }
            return this.newObj;
          }
        }
        LAB_18098a505:
        local_c0 = fVar11;
    }

    // Token : 0x600213A
    // RVA   : 0x989550   Offset: 0x988950   Length: 0x9F
    public void DestroyCloud(GameObject target)
    {
        if (this.clouds != null) {
          FUN_1817eee00(this.clouds,target,DAT_181d89618);
          if (this.areaClouds != null) {
            FUN_1817eee00(this.areaClouds,target,DAT_181d89618);
            Object.Destroy(target,0);
            return;
          }
        }
    }

    // Token : 0x600213B
    // RVA   : 0x98ADF0   Offset: 0x98A1F0   Length: 0x3B
    public Vector3 SetSkyZPos(Vector3 originPos)
    {
        float fVar1;
        fVar1 = (float)((uint64)*param_3 >> 32);
        *this = *(uint32 *)param_3;
        this[1] = fVar1;
        this[2] = fVar1 * 0.001 - 10.0;
        return this;
    }

    // Token : 0x600213C
    // RVA   : 0x9895F0   Offset: 0x9889F0   Length: 0x627
    public void GenerateBird(SkyObjType skyObjType, bool fromBorder)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181dc7738),
               fVar9 = local_90, lVar3 != null)) {
              lVar3.Count = skyObjType;
              if (this.newObj != null) {
                lVar3 = GameObject.GetComponent(this.newObj,DAT_181dc7738);
                fVar6 = (float)Random.get_value(0);
                fVar9 = local_90;
                if (lVar3 != null) {
                  lVar3._version = fVar6 < 0.5;
                  if (this.newObj != null) {
                    lVar3 = GameObject.GetComponent(this.newObj,DAT_181d73bb8);
                    fVar9 = local_90;
                    if (((this.newObj != null) &&
                        (lVar5 = GameObject.GetComponent(this.newObj,DAT_181dc7738),
                        fVar9 = local_90, lVar5 != null)) && (lVar3 != null)) {
                      SpriteRenderer.set_flipX(lVar3,*(char *)(lVar5 + 28) != false,0);
                      fVar9 = local_90;
                      if (this.newObj != null) {
                        lVar3 = GameObject.GetComponent(this.newObj,DAT_181dc7738);
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
                                                  (this.newObj,DAT_181dc7738),
                               fVar9 = local_90, lVar3 == null)) goto LAB_180989c12;
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
                              lVar5 = FUN_18046bbe0(0);
                              fVar9 = local_90;
                              if (lVar5 == null) goto LAB_180989c12;
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
                              lVar5 = FUN_18046bbe0(0);
                              fVar9 = local_90;
                              if (lVar5 == null) goto LAB_180989c12;
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
                                      FUN_18181e0a0(lVar3,this.newObj,DAT_181d89398);
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
        LAB_180989c12:
        local_90 = fVar9;
    }

    // Token : 0x600213D
    // RVA   : 0x9894B0   Offset: 0x9888B0   Length: 0x9F
    public void DestroyBird(GameObject target)
    {
        if (this.birds != null) {
          FUN_1817eee00(this.birds,target,DAT_181d89618);
          if (this.areaBirds != null) {
            FUN_1817eee00(this.areaBirds,target,DAT_181d89618);
            Object.Destroy(target,0);
            return;
          }
        }
    }

    // Token : 0x600213E
    // RVA   : 0x98A940   Offset: 0x989D40   Length: 0x16D
    public GameObject GetSkyObjRoot(SkyObjType skyObjType, bool isCloud)
    {
        long lVar1;
        ulong uVar2;
        if (skyObjType == null) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181db0bc8 + 184) + 16);
          if (lVar1 == null) throw; // [null/range check failed]
          lVar1 = *(int64 *)(lVar1 + 64);
        }
        else {
          if (skyObjType != 1) {
            return false;
          }
          lVar1 = FUN_18046bac0(0);
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

    // Token : 0x600213F
    // RVA   : 0x98A510   Offset: 0x989910   Length: 0x159
    public float GetMapSize(SkyObjType skyObjType, bool mapWidth)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        float fVar1;
        long lVar2;
        if (skyObjType == null) {
          if (!mapWidth) {
            lVar2 = FUN_18046bbe0(0);
            if (lVar2 != null) {
              return *(float *)(lVar2 + 52);
            }
          }
          else {
            lVar2 = FUN_18046bbe0(0);
            if (lVar2 != null) {
              return *(float *)(lVar2 + 48);
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
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

    // Token : 0x6002140
    // RVA   : 0x98A670   Offset: 0x989A70   Length: 0x2CC
    public float GetScaleAlphaPercent(SkyObjType skyObjType)
    {
        var pStatics_c758 = *(int64*)(DAT_181dac758 + 184);
        float fVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        if (skyObjType != null) {
          if (skyObjType == 1) {
            fVar4 = *(float *)(pStatics_c758 + 20);
            lVar2 = PlotController.SpringFestivelRewardLvTalkText;
            if (lVar2 == null) throw; // [null/range check failed]
            fVar3 = (float)AreaController.AreaMapNowScale(lVar2,0);
            fVar4 = (fVar4 - fVar3) /
                    (*(float *)(pStatics_c758 + 20) -
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

    // Token : 0x6002141
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
