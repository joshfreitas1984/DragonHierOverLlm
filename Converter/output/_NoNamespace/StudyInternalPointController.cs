// ============================================================
// Type  : StudyInternalPointController
// Token : 0x2000383
// ============================================================

public class StudyInternalPointController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CBC
    public string pointName;

    // Token: 0x4001CBD
    public float finishRate;

    // Token: 0x4001CBE
    public int hardLv;

    // Token: 0x4001CBF
    public float successRate;

    // Token: 0x4001CC0
    public bool seen;

    // Token: 0x4001CC1
    public bool crashed;

    // Token: 0x4001CC2
    public float exp;

    // Token: 0x4001CC3
    public StudyInternalSpePointType spePointType;

    // Token: 0x4001CC4
    public bool goodSpePoint;

    // Token: 0x4001CC5
    public int column;

    // Token: 0x4001CC6
    public int row;

    // Token: 0x4001CC7
    public int poolID;

    // Token: 0x4001CC8
    private GameObject pointUI;

    // Token: 0x4001CC9
    private GameObject highLight;

    // Token: 0x4001CCA
    public LineRenderer highLightLineRenderer;

    // Token: 0x4001CCB
    public GameObject chooseNextPoint;

    // Token: 0x4001CCC
    public List<GameObject> nextPoint;

    // Token: 0x4001CCD
    public List<LineRenderer> lineRendererBack;

    // Token: 0x4001CCE
    public List<LineRenderer> lineRendererBackBroken;

    // Token: 0x4001CCF
    public Sprite originSprite;

    // Token: 0x4001CD0
    public Sprite hightlightSprite;

    // Token: 0x4001CD1
    private GameObject newObj;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600225E
    // RVA   : 0xFDE880   Offset: 0xFDDC80   Length: 0x5F
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = Component.GetComponent(this,DAT_181d95de0);
        if (lVar1 != null) {
          uVar2 = SpriteRenderer.get_sprite(lVar1,0);
          this.originSprite = uVar2;
          return;
        }
    }

    // Token : 0x600225F
    // RVA   : 0xFDECF0   Offset: 0xFDE0F0   Length: 0x55A
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181da8110 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar6;
        float[] local_res8 = new float[2];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uVar3 = this.highLight;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          if (*pStatics == 0) throw; // [null/range check failed]
          if (*(char *)(*pStatics + 129) == false) {
        LAB_180fdeeba:
            if (this.highLight == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(this.highLight,0);
            if (!cVar1) goto LAB_180fdeee9;
            lVar2 = this.highLight;
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = 0;
          }
          else {
            if (((*pStatics == 0) ||
                (lVar2 = *(int64 *)(*pStatics + 136)) == null) ||
               (lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60)) == null) throw; // [null/range check failed]
            lVar2 = *(int64 *)(lVar2 + 104);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            cVar1 = FUN_18181e400(lVar2,uVar3,DAT_181d89498);
            if ((!cVar1) || (this.crashed)) goto LAB_180fdeeba;
            if (this.highLight == null) throw; // [null/range check failed]
            cVar1 = GameObject.get_activeSelf(this.highLight,0);
            if (cVar1) goto LAB_180fdeee9;
            lVar2 = this.highLight;
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = 1;
          }
          GameObject.SetActive(lVar2,uVar3,0);
        }
        LAB_180fdeee9:
        uVar3 = this.pointUI;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          return;
        }
        lVar2 = this.pointUI;
        if (1.0 <= this.finishRate) {
          if (((lVar2 == null) || (lVar2 = GameObject.get_transform(lVar2,0)) == null) ||
             (lVar2 = Transform.Find(lVar2,"Name",0)) == null) throw; // [null/range check failed]
          plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
          puVar5 = (uint32 *)Color.get_green(&local_28,0);
        }
        else {
          if (((lVar2 == null) || (lVar2 = GameObject.get_transform(lVar2,0)) == null) ||
             (lVar2 = Transform.Find(lVar2,"Name",0)) == null) throw; // [null/range check failed]
          plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
          puVar5 = (uint32 *)FUN_1810d3570(&local_28,0);
        }
        if (plVar4 != (int64 *)0) {
          local_28 = *puVar5;
          uStack_24 = puVar5[1];
          uStack_20 = puVar5[2];
          uStack_1c = puVar5[3];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
          if (*pStatics != 0) {
            uVar3 = *(uint64 *)(*pStatics + 136);
            uVar6 = Component.get_gameObject(this,0);
            cVar1 = Object.op_Equality(uVar3,uVar6,0);
            if ((!cVar1) || (1.0 < this.finishRate || this.finishRate == 1.0)
               ) {
              if ((this.pointUI != null) &&
                 ((lVar2 = GameObject.get_transform(this.pointUI,0), lVar2 != null &&
                  (lVar2 = Transform.Find(lVar2,"Rate",0)) != null))) {
                uVar6 = Component.GetComponent(lVar2,DAT_181d96160);
                uVar3 = "";
                if (((*(byte *)(DAT_181d84898 + 0x133) & 4) != 0) && (*(int *)(DAT_181d84898 + 224) == 0)
                   ) {
                  il2cpp_runtime_class_init();
                  uVar3 = "";
                }
        LAB_180fdf1c5:
                LTLocalization.SetText(uVar6,uVar3,0);
                return;
              }
            }
            else if (((this.pointUI != null) &&
                     (lVar2 = GameObject.get_transform(this.pointUI,0)) != null) &&
                    (lVar2 = Transform.Find(lVar2,"Rate",0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d96160);
              puVar5 = (uint32 *)Color.get_red(&local_28,0);
              if (plVar4 != (int64 *)0) {
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                uStack_1c = puVar5[3];
                (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
                if (((this.pointUI != null) &&
                    (lVar2 = GameObject.get_transform(this.pointUI,0)) != null) &&
                   (lVar2 = Transform.Find(lVar2,"Rate",0)) != null) {
                  uVar6 = Component.GetComponent(lVar2,DAT_181d96160);
                  local_res8[0] = this.finishRate * 100.0;
                  uVar3 = Single.ToString(local_res8,"f0",0);
                  uVar3 = String.Concat(uVar3,"%",0);
                  goto LAB_180fdf1c5;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002260
    // RVA   : 0xFDB020   Offset: 0xFDA420   Length: 0x30
    public void ChangeFinishRate(float num)
    {
        uint uVar1;
        uVar1 = FUN_1810e36c0(this.finishRate + num,0,0x3f800000,0);
        this.finishRate = uVar1;
    }

    // Token : 0x6002261
    // RVA   : 0xFDAF80   Offset: 0xFDA380   Length: 0x9D
    public void AddConnect(GameObject targetPoint)
    {
        long lVar1;
        ulong uVar2;
        if (this.nextPoint != null) {
          FUN_18181e0a0(this.nextPoint,targetPoint,DAT_181d89398);
          if (targetPoint != null) {
            lVar1 = GameObject.GetComponent(targetPoint,DAT_181d73e60);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 104);
              uVar2 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                FUN_18181e0a0(lVar1,uVar2,DAT_181d89398);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002262
    // RVA   : 0xFDCF50   Offset: 0xFDC350   Length: 0x9D
    public void RemoveConnect(GameObject targetPoint)
    {
        long lVar1;
        ulong uVar2;
        if (this.nextPoint != null) {
          FUN_1817eee00(this.nextPoint,targetPoint,DAT_181d89618);
          if (targetPoint != null) {
            lVar1 = GameObject.GetComponent(targetPoint,DAT_181d73e60);
            if (lVar1 != null) {
              lVar1 = *(int64 *)(lVar1 + 104);
              uVar2 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                FUN_1817eee00(lVar1,uVar2,DAT_181d89618);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002263
    // RVA   : 0xFDC900   Offset: 0xFDBD00   Length: 0x7F
    private void OnEnable()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.pointUI;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.pointUI == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          GameObject.SetActive(this.pointUI,1,0);
        }
    }

    // Token : 0x6002264
    // RVA   : 0xFDC880   Offset: 0xFDBC80   Length: 0x7F
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.pointUI;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.pointUI == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          GameObject.SetActive(this.pointUI,0,0);
        }
    }

    // Token : 0x6002265
    // RVA   : 0xFDBB40   Offset: 0xFDAF40   Length: 0xAF9
    public void Init()
    {
        var pStatics_8110 = *(int64*)(DAT_181da8110 + 184);
        var pStatics_8190 = *(int64*)(DAT_181da8190 + 184);
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        uint uVar10;
        float fVar11;
        float fVar12;
        ulong local_88;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        lVar4 = Component.GetComponent(this,DAT_181d95de0);
        if (lVar4 != null) {
          SpriteRenderer.set_sprite(lVar4,this.originSprite,0);
          lVar4 = Component.get_transform(this,0);
          puVar5 = (uint64 *)Quaternion.get_identity(&local_58,0);
          if (lVar4 != null) {
            local_58 = *puVar5;
            uStack_50 = puVar5[1];
            Transform.set_localRotation(lVar4,&local_58,0);
            uVar9 = 0;
            this.finishRate = 0;
            this.crashed = 0;
            fVar11 = (float)Random.Range();
            iVar1 = this.hardLv;
            if (*pStatics_8190 != 0) {
              if (*(int64 *)(*pStatics_8190 + 40) == 0) {
                fVar12 = 0.0;
              }
              else {
                if ((*pStatics_8190 == 0) ||
                   (lVar4 = *(int64 *)(*pStatics_8190 + 40)) == null)
                throw; // [null/range check failed]
                fVar12 = (float)*(int *)(lVar4 + 20) * 0.01;
              }
              this.successRate = (fVar11 - (float)iVar1 * 0.1) + fVar12;
              uVar6 = this.pointUI;
              cVar3 = Object.op_Equality(uVar6,0,0);
              if (cVar3) {
                if (*pStatics_8110 == 0) throw; // [null/range check failed]
                uVar6 = *(uint64 *)(*pStatics_8110 + 88);
                if (*pStatics_8110 == 0) throw; // [null/range check failed]
                uVar7 = *(uint64 *)(*pStatics_8110 + 48);
                uVar6 = GlobalData.AddChild(uVar6,uVar7,0);
                this.pointUI = uVar6;
              }
              if (((this.pointUI != null) &&
                  (lVar4 = GameObject.get_transform(this.pointUI,0)) != null) &&
                 (lVar4 = Transform.Find(lVar4,"Name",0)) != null) {
                uVar7 = Component.GetComponent(lVar4,DAT_181d96160);
                uVar6 = this.pointName;
                LTLocalization.SetText(uVar7,uVar6,0);
                if (this.pointUI != null) {
                  lVar4 = GameObject.get_transform(this.pointUI,0);
                  lVar8 = Component.get_transform(this,0);
                  if (lVar8 != null) {
                    puVar5 = (uint64 *)Transform.get_position(&local_58,lVar8,0);
                    local_68 = *puVar5;
                    fVar11 = *(float *)(puVar5 + 1);
                    uStack_70 = CONCAT44(uStack_70._4_4_,fVar11);
                    uStack_60 = CONCAT44(uStack_60._4_4_,fVar11);
                    local_88 = CONCAT44((float)((uint64)local_68 >> 32) + 0.05,(float)local_68 + 0.0)
                    ;
                    local_78 = local_68;
                    if (lVar4 != null) {
                      local_78 = local_88;
                      uStack_70 = CONCAT44(uStack_70._4_4_,fVar11 + 0.0);
                      Transform.set_position(lVar4,&local_78,0);
                      uVar6 = this.highLight;
                      cVar3 = Object.op_Equality(uVar6,0,0);
                      if (cVar3) {
                        uVar6 = Component.get_gameObject(this,0);
                        if (*pStatics_8110 == 0) throw; // [null/range check failed]
                        uVar7 = *(uint64 *)(*pStatics_8110 + 56);
                        uVar6 = GlobalData.AddChild(uVar6,uVar7,0);
                        this.highLight = uVar6;
                      }
                      uVar6 = this.highLightLineRenderer;
                      cVar3 = Object.op_Equality(uVar6,0,0);
                      if (cVar3) {
                        uVar6 = Component.get_gameObject(this,0);
                        if (*pStatics_8110 == 0) throw; // [null/range check failed]
                        uVar7 = *(uint64 *)(*pStatics_8110 + 64);
                        lVar4 = GlobalData.AddChild(uVar6,uVar7,0);
                        if (lVar4 == null) throw; // [null/range check failed]
                        uVar6 = GameObject.GetComponent(lVar4,DAT_181d72238);
                        this.highLightLineRenderer = uVar6;
                      }
                      if (this.lineRendererBack != null) {
                        if (this.lineRendererBack.Count == null) {
                          lVar4 = this.nextPoint;
                          uVar10 = uVar9;
                          while (lVar4 != null) {
                            if (lVar4.Count <= (int)uVar10) goto LAB_180fdc37e;
                            lVar4 = this.lineRendererBack;
                            uVar6 = Component.get_gameObject(this,0);
                            if (*pStatics_8110 == 0) {
        LAB_180fdc634:
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            uVar7 = *(uint64 *)(*pStatics_8110 + 64);
                            lVar8 = GlobalData.AddChild(uVar6,uVar7,0);
                            if ((lVar8 == null) ||
                               (uVar6 = GameObject.GetComponent(lVar8,DAT_181d72238), lVar4 == null))
                            goto LAB_180fdc634;
                            FUN_18181e0a0(lVar4,uVar6,DAT_181d92a90);
                            if (this.lineRendererBack == null) goto LAB_180fdc634;
                            lVar4 = FUN_180002f80(this.lineRendererBack,uVar10,DAT_181d92c90);
                            local_58 = 0;
                            uStack_50 = 0;
                            FUN_1809dc910(&local_58,0x3e99999a,0x3e99999a,0x3e99999a,0x3e99999a,0);
                            if (lVar4 == null) goto LAB_180fdc634;
                            local_78 = local_58;
                            uStack_70 = uStack_50;
                            LineRenderer.set_startColor(lVar4,&local_78,0);
                            if (this.lineRendererBack == null) goto LAB_180fdc634;
                            lVar4 = FUN_180002f80(this.lineRendererBack,uVar10);
                            local_68 = 0;
                            uStack_60 = 0;
                            FUN_1809dc910(&local_68,0x3e99999a,0x3e99999a,0x3e99999a,0x3e99999a,0);
                            if (lVar4 == null) goto LAB_180fdc634;
                            local_78 = local_68;
                            uStack_70 = uStack_60;
                            LineRenderer.set_endColor(lVar4);
                            uVar10 = uVar10 + 1;
                            lVar4 = this.nextPoint;
                          }
                        }
                        else {
        LAB_180fdc37e:
                          lVar4 = this.lineRendererBack;
                          if (lVar4 != null) {
                            lVar8 = 32;
                            do {
                              if (lVar4.Count <= (int)uVar9) {
                                this.seen = 0;
                                if (this.pointUI != null) {
                                  GameObject.SetActive(this.pointUI,0,0);
                                  lVar4 = Component.GetComponent(this,DAT_181d95de0);
                                  puVar5 = (uint64 *)FUN_1810d33f0(&local_58,0);
                                  local_58 = *puVar5;
                                  uStack_50 = puVar5[1];
                                  puVar5 = (uint64 *)FUN_1810d3880(&local_68,&local_58,0x3f000000,0);
                                  if (lVar4 != null) {
                                    local_58 = *puVar5;
                                    uStack_50 = puVar5[1];
                                    SpriteRenderer.set_color(lVar4,&local_58,0);
                                    lVar4 = Component.GetComponent(this,DAT_181d95560);
                                    if (lVar4 != null) {
                                      lVar4.Count = "";
                                      lVar4 = Component.get_transform(this,0);
                                      if (((lVar4 != null) &&
                                          (lVar4 = Transform.Find(lVar4,"SpePoint",0)) != null) &&
                                         (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
                                        GameObject.SetActive(lVar4,this.spePointType != null,0);
                                        lVar4 = Component.get_transform(this,0);
                                        if (((lVar4 != null) &&
                                            (lVar4 = Transform.Find(lVar4,"SpePoint",0)) != null)
                                           && (lVar4 = Transform.Find(lVar4,"Icon",0)) != null
                                           ) {
                                          lVar4 = Component.GetComponent(lVar4,DAT_181d95de0);
                                          puVar5 = (uint64 *)Color.get_yellow(&local_58,0);
                                          if (lVar4 != null) {
                                            local_58 = *puVar5;
                                            uStack_50 = puVar5[1];
                                            SpriteRenderer.set_color(lVar4,&local_58,0);
                                            return;
                                          }
                                        }
                                      }
                                    }
                                  }
                                }
                                break;
                              }
                              if (lVar4 == null) break;
                              if (lVar4.Count <= uVar9) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar2 = this.nextPoint;
                              uVar6 = *(uint64 *)(lVar8 + lVar4._items);
                              if (lVar2 == null) break;
                              if (lVar2.Count <= uVar9) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar7 = *(uint64 *)(lVar8 + lVar2._items);
                              lVar4 = new WarpText_d__8(0);
                              if (lVar4 == null) break;
                              *(int64 *)(lVar4 + 40) = this;
                              *(uint64 *)(lVar4 + 32) = uVar6;
                              *(uint64 *)(lVar4 + 48) = uVar7;
                              FUN_180d8c2e0(this);
                              lVar4 = this.lineRendererBack;
                              uVar9 = uVar9 + 1;
                              lVar8 = lVar8 + 8;
                            } while (lVar4 != null);
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

    // Token : 0x6002266
    // RVA   : 0xFDCCB0   Offset: 0xFDC0B0   Length: 0x29E
    public void RefreshInfo()
    {
        var pStatics = *(int64*)(DAT_181da8110 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        float[] local_res18 = new float[2];
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_res18[0] = 0.0;
        lVar2 = Component.GetComponent(this,DAT_181d95560);
        if (*pStatics != 0) {
          uVar4 = *(uint64 *)(*pStatics + 120);
          uVar3 = Component.get_gameObject(this,0);
          cVar1 = Object.op_Equality(uVar4,uVar3,0);
          uVar4 = "气海\n自此出发冲破穴位\n最终返回即告成功";
          if (!cVar1) {
            local_res18[0] = this.successRate * 100.0;
            uVar4 = Single.ToString(local_res18,"f0",0);
            uVar3 = Single.ToString(this + 48,"+0;-0;0",0);
            uVar4 = String.Format("冲关成功率{0}%\n经验{1}",uVar4,uVar3,0);
          }
          if (lVar2 != null) {
            *(uint64 *)(lVar2 + 24) = uVar4;
            if (this.spePointType == null) {
              return;
            }
            lVar2 = Component.GetComponent(this,DAT_181d95560);
            if (lVar2 != null) {
              uVar4 = *(uint64 *)(lVar2 + 24);
              uVar3 = StudyInternalPointController.GetSpePointDescribe(this,0);
              uVar4 = String.Concat(uVar4,"\n",uVar3,0);
              *(uint64 *)(lVar2 + 24) = uVar4;
              lVar2 = Component.get_transform(this,0);
              if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"SpePoint",0)) != null) &&
                 (lVar2 = Transform.Find(lVar2,"Icon",0)) != null) {
                lVar2 = Component.GetComponent(lVar2);
                if (!this.goodSpePoint) {
                  puVar5 = (uint32 *)Color.get_red(&local_18);
                }
                else {
                  puVar5 = (uint32 *)Color.get_green();
                }
                local_18 = *puVar5;
                uStack_14 = puVar5[1];
                uStack_10 = puVar5[2];
                uStack_c = puVar5[3];
                if (lVar2 != null) {
                  SpriteRenderer.set_color(lVar2,&local_18,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002267
    // RVA   : 0xFDD1F0   Offset: 0xFDC5F0   Length: 0x168
    public void Seen()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.seen) {
          return;
        }
        this.seen = 1;
        if (this.pointUI != null) {
          GameObject.SetActive(this.pointUI,1,0);
          lVar3 = Component.GetComponent(this,DAT_181d95de0);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
            uVar1 = this.hardLv;
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2[uVar1];
            if ((lVar2 != null) && (lVar3 != null)) {
              local_18 = *(uint32 *)(lVar2 + 24);
              uStack_14 = *(uint32 *)(lVar2 + 28);
              uStack_10 = *(uint32 *)(lVar2 + 32);
              uStack_c = *(uint32 *)(lVar2 + 36);
              SpriteRenderer.set_color(lVar3,&local_18,0);
              StudyInternalPointController.RefreshInfo(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002268
    // RVA   : 0xFDB650   Offset: 0xFDAA50   Length: 0xF8
    public string GetSpePointDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        local_res8[0] = 0;
        uVar4 = "";
        switch(this.spePointType) {
        case 1:
          if (!this.goodSpePoint) {
            uVar4 = *(uint64 *)(pStatics + 0x2d0);
            uVar3 = "内力";
          }
          else {
            uVar4 = *(uint64 *)(pStatics + 0x268);
            uVar3 = "内力";
          }
          goto LAB_180fdb7c3;
        case 2:
          if (!this.goodSpePoint) {
            uVar4 = *(uint64 *)(pStatics + 0x2d0);
          }
          else {
            uVar4 = *(uint64 *)(pStatics + 0x268);
          }
          local_res8[0] = this.hardLv * 20 + 50;
          uVar3 = "周边经验";
          if (!this.goodSpePoint) {
            local_res8[0] = -local_res8[0];
          }
          goto LAB_180fdb7e0;
        case 3:
          if (!this.goodSpePoint) {
            uVar4 = *(uint64 *)(pStatics + 0x2d0);
            uVar3 = "周边成功率";
          }
          else {
            uVar4 = *(uint64 *)(pStatics + 0x268);
            uVar3 = "周边成功率";
          }
        LAB_180fdb7c3:
          local_res8[0] = this.hardLv * 2 + 5;
          if (!this.goodSpePoint) {
            local_res8[0] = -local_res8[0];
          }
        LAB_180fdb7e0:
          uVar1 = Int32.ToString(local_res8,"+0;-0;0",0);
          uVar4 = String.Concat(uVar4,uVar3,uVar1,"%</color>",0);
          break;
        case 4:
          if (!this.goodSpePoint) {
            uVar4 = *(uint64 *)(pStatics + 0x2d0);
          }
          else {
            uVar4 = *(uint64 *)(pStatics + 0x268);
          }
          uVar3 = "随机{0}周边{1}条通路";
          uVar1 = "连接";
          if (!this.goodSpePoint) {
            uVar1 = "阻断";
          }
          local_res18[0] = Mathf.FloorToInt((float)this.hardLv * 0.5,0);
          local_res18[0] = local_res18[0] + 1;
          uVar2 = il2cpp_value_box(DAT_181d80418,local_res18);
          uVar3 = String.Format(uVar3,uVar1,uVar2,0);
          uVar4 = String.Concat(uVar4,uVar3,"</color>",0);
          break;
        case 5:
          this.goodSpePoint = 1;
          uVar4 = String.Concat(*(uint64 *)(pStatics + 0x268),
                                 "随机揭示{0}个点</color>",0);
          local_res18[0] = this.hardLv * 2 + 5;
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
          uVar4 = String.Format(uVar4,uVar3,0);
          break;
        case 6:
          this.goodSpePoint = 1;
          uVar4 = *(uint64 *)(pStatics + 0x268);
          local_res18[0] = Mathf.FloorToInt((float)this.hardLv * 0.5,0);
          local_res18[0] = local_res18[0] + 1;
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
          uVar3 = String.Format("随机打通下{0}个穴位</color>",uVar3,0);
          uVar4 = String.Concat(uVar4,uVar3,0);
        }
        return uVar4;
    }

    // Token : 0x6002269
    // RVA   : 0xFDCFF0   Offset: 0xFDC3F0   Length: 0x1FD
    public void ResetLineRenderer()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        uVar2 = this.highLightLineRenderer;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.highLightLineRenderer == null) throw; // [null/range check failed]
          LineRenderer.set_positionCount(this.highLightLineRenderer,0,0);
        }
        lVar3 = this.lineRendererBack;
        uVar5 = 0;
        uVar4 = 0;
        if (lVar3 != null) {
          lVar6 = 32;
          lVar7 = 32;
          do {
            if (lVar3.Count <= (int)uVar4) {
              FUN_1812f9a10(lVar3,DAT_181d92b10);
              lVar3 = this.lineRendererBackBroken;
              if (lVar3 != null) goto LAB_180fdd150;
              break;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar7 + lVar3._items);
            if (lVar3 == null) break;
            uVar2 = Component.get_gameObject(lVar3,0);
            Object.Destroy(uVar2);
            lVar3 = this.lineRendererBack;
            uVar4 = uVar4 + 1;
            lVar7 = lVar7 + 8;
          } while (lVar3 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar3.Count <= uVar5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar6 + lVar3._items);
          if (lVar3 == null) break;
          uVar2 = Component.get_gameObject(lVar3,0);
          Object.Destroy(uVar2);
          lVar3 = this.lineRendererBackBroken;
          uVar5 = uVar5 + 1;
          lVar6 = lVar6 + 8;
          if (lVar3 == null) break;
        LAB_180fdd150:
          if (lVar3.Count <= (int)uVar5) {
            FUN_1812f9a10(lVar3,DAT_181d92b10);
            return;
          }
          if (lVar3 == null) break;
        }
    }

    // Token : 0x600226A
    // RVA   : 0xFDE7E0   Offset: 0xFDDBE0   Length: 0x9A
    public IEnumerator ShowPointParticle(GameObject targetParticle, float delayTime)
    {
        int64 StudyInternalPointController.ShowPointParticle
                         (uint64 this,uint64 targetParticle,uint32 delayTime)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint64 *)(lVar1 + 48) = targetParticle;
          *(uint32 *)(lVar1 + 32) = delayTime;
          return lVar1;
        }
    }

    // Token : 0x600226B
    // RVA   : 0xFDE8E0   Offset: 0xFDDCE0   Length: 0x351
    public void TryCrash()
    {
        var pStatics = *(int64*)(DAT_181da4450 + 184);
        ulong uVar1;
        long lVar2;
        float fVar4;
        ulong local_38;
        float local_30;
        float local_20;
        byte[] local_18 = new byte[16];
        uVar1 = Component.get_transform(this,0);
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localScale(local_18,lVar2,0);
          local_30 = *(float *)(puVar3 + 1) * 1.6;
          local_38 = CONCAT44((float)((uint64)*puVar3 >> 32) * 1.6,(float)*puVar3 * 1.6);
          local_20 = local_30;
          uVar1 = ShortcutExtensions.DOScale(uVar1,&local_38,0x3db851ec,0);
          uVar1 = TweenSettingsExtensions.SetLoops(uVar1,2,1,DAT_181dc1330);
          TweenSettingsExtensions.SetEase(uVar1,9,DAT_181dc0f80);
          if (*pStatics != 0) {
            uVar1 = StudyInternalPointController.ShowPointParticle
                              (this,*(uint64 *)(*pStatics + 136),0,0);
            FUN_180d8c2e0(this,uVar1,0);
            if (*pStatics != 0) {
              uVar1 = StudyInternalPointController.ShowPointParticle
                                (this,*(uint64 *)(*pStatics + 152),0,0
                                );
              FUN_180d8c2e0(this,uVar1,0);
              lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
              if (lVar2 != null) {
                uVar1 = *(uint64 *)(lVar2 + 0x1f0);
                NGUITools.PlaySound(uVar1,0x3ecccccd,0);
                fVar4 = (float)Random.get_value(0);
                if (fVar4 <= this.successRate) {
                  fVar4 = (float)FUN_1810e36c0(this.finishRate + 0.2,0,0x3f800000,0);
                  this.finishRate = fVar4;
                  if (1.0 <= fVar4) {
                    StudyInternalPointController.FinishCrash(this,0);
                  }
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x600226C
    // RVA   : 0xFDB050   Offset: 0xFDA450   Length: 0x5FB
    public void FinishCrash()
    {
        var pStatics_4450 = *(int64*)(DAT_181da4450 + 184);
        var pStatics_8110 = *(int64*)(DAT_181da8110 + 184);
        var pStatics_8190 = *(int64*)(DAT_181da8190 + 184);
        ulong uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        long lVar7;
        long lVar9;
        ulong local_48;
        uint local_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (*pStatics_4450 != 0) {
          uVar5 = StudyInternalPointController.ShowPointParticle
                            (this,*(uint64 *)(*pStatics_4450 + 128),0,0);
          FUN_180d8c2e0(this,uVar5,0);
          if (*pStatics_4450 != 0) {
            uVar5 = StudyInternalPointController.ShowPointParticle
                              (this,*(uint64 *)(*pStatics_4450 + 144),0,0);
            FUN_180d8c2e0(this,uVar5,0);
            plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/LegendDrop",0);
            plVar10 = (int64 *)0;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
              plVar10 = plVar6;
            }
            NGUITools.PlaySound(plVar10,0x3f000000,0);
            if (*pStatics_8110 != 0) {
              piVar1 = (int *)(*pStatics_8110 + 32);
              *piVar1 = *piVar1 + 1;
              lVar9 = *pStatics_8110;
              if (lVar9 != null) {
                *(float *)(lVar9 + 28) = this.exp + *(float *)(lVar9 + 28);
                lVar9 = **(int64 **)(DAT_181d72cc8 + 184);
                uVar5 = Single.ToString(this + 48,0);
                uVar5 = String.Concat("冲破经验+",uVar5,0);
                lVar7 = Component.get_transform(this,0);
                if (lVar7 != null) {
                  puVar8 = (uint64 *)Transform.get_position(&local_48,lVar7,0);
                  uVar2 = *puVar8;
                  uVar3 = *(uint32 *)(puVar8 + 1);
                  lVar7 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
                  if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 56)) != null) {
                    uVar4 = this.hardLv;
                    if (*(uint32 *)(lVar7 + 24) <= uVar4) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar7 = lVar7[uVar4];
                    if ((lVar7 != null) && (lVar9 != null)) {
                      local_38 = *(uint32 *)(lVar7 + 24);
                      uStack_34 = *(uint32 *)(lVar7 + 28);
                      uStack_30 = *(uint32 *)(lVar7 + 32);
                      uStack_2c = *(uint32 *)(lVar7 + 36);
                      local_48 = uVar2;
                      local_40 = uVar3;
                      uVar5 = GameController.ShowTextAtPos(lVar9,uVar5,&local_48,18,&local_38,0);
                      this.newObj = uVar5;
                      if (this.newObj != null) {
                        lVar9 = GameObject.GetComponent(this.newObj,DAT_181dc6fc8);
                        if (lVar9 != null) {
                          Behaviour.set_enabled(lVar9,0,0);
                          if (this.newObj != null) {
                            uVar5 = GameObject.get_transform(this.newObj,0);
                            if ((*pStatics_8190 != 0) &&
                               (lVar9 = *(int64 *)(*pStatics_8190 + 80),
                               lVar9 != null)) {
                              lVar9 = Component.get_transform(lVar9,0);
                              if (lVar9 != null) {
                                puVar8 = (uint64 *)Transform.get_position(&local_38,lVar9,0);
                                local_48 = *puVar8;
                                local_40 = *(uint32 *)(puVar8 + 1);
                                uVar5 = ShortcutExtensions.DOMove(uVar5,&local_48,0x3f800000,0,0);
                                TweenSettingsExtensions.SetEase(uVar5,26,DAT_181dc0f80);
                                StudyInternalPointController.SetPointCrashed(this,0);
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

    // Token : 0x600226D
    // RVA   : 0xFDD360   Offset: 0xFDC760   Length: 0x13EC
    public void SetPointCrashed()
    {
        var plVar8 = *(int64*)(lVar8 + 184);
        var plVar9 = *(int64*)(lVar9 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_8110 = *(int64*)(DAT_181da8110 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        int iVar10;
        uint uVar11;
        int iVar12;
        int iVar13;
        long lVar14;
        ulong uVar15;
        int[] local_res8 = new int[2];
        ulong in_stack_ffffffffffffff58;
        uint uVar16;
        ulong local_98;
        ulong uStack_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        uVar11 = 0;
        local_res8[0] = 0;
        StudyInternalPointController.Seen(this,0);
        lVar3 = Component.GetComponent(this,DAT_181d95de0);
        if (lVar3 == null) goto LAB_180fde745;
        SpriteRenderer.set_sprite(lVar3,this.hightlightSprite,0);
        lVar3 = Component.GetComponent(this,DAT_181d95de0);
        puVar4 = (uint64 *)FUN_1810d3570(&local_78,0);
        if (lVar3 == null) goto LAB_180fde745;
        local_88 = *puVar4;
        uStack_80 = puVar4[1];
        SpriteRenderer.set_color(lVar3,&local_88,0);
        if (*pStatics_8110 == 0) goto LAB_180fde745;
        *(uint8 *)(*pStatics_8110 + 128) = 0;
        this.crashed = 1;
        this.finishRate = 0x3f800000;
        if (*pStatics_8110 == 0) goto LAB_180fde745;
        if (*(int *)(*pStatics_8110 + 32) < 2) {
        LAB_180fdd689:
          if (*pStatics_8110 == 0) goto LAB_180fde745;
          if (*(int *)(*pStatics_8110 + 192) < 1) {
            if (*pStatics_8110 == 0) goto LAB_180fde745;
            *(uint8 *)(*pStatics_8110 + 129) = 1;
          }
          else {
            StudyInternalPointController.RandomCrashNextPoint(this,0);
          }
        }
        else {
          lVar3 = this.nextPoint;
          if ((*pStatics_8110 == 0) || (lVar3 == null)) goto LAB_180fde745;
          cVar1 = FUN_18181e400(lVar3,*(uint64 *)(*pStatics_8110 + 120),
                                DAT_181d89498);
          if (!cVar1) goto LAB_180fdd689;
          if (*pStatics_8110 == 0) goto LAB_180fde745;
          this.chooseNextPoint = *(uint64 *)(*pStatics_8110 + 120);
          uVar5 = StudyInternalPointController.ShowHighLightLine(this,0);
          FUN_180d8c2e0(this,uVar5,0);
        }
        lVar3 = il2cpp_internal(DAT_181d92f58);
        FUN_18132faf0(lVar3,DAT_181d89298);
        lVar14 = 32;
        switch(this.spePointType) {
        case 1:
          lVar3 = FUN_1808e3de0(0);
          iVar13 = this.hardLv;
          iVar2 = 1;
          if (!this.goodSpePoint) {
            iVar2 = -1;
          }
          lVar14 = FUN_18046c0a0(0);
          if (((lVar14 == null) || (*(int64 *)(lVar14 + 32) == 0)) ||
             ((lVar14 = WorldData.Player(*(int64 *)(lVar14 + 32),0), lVar14 == null || (lVar3 == null))))
          goto LAB_180fde745;
          StudyInternalSkillController.ChangeMana
                    (lVar3,((float)iVar13 * 0.02 + 0.05) * (float)iVar2 * *(float *)(lVar14 + 0x194),0);
          break;
        case 2:
          lVar3 = this.nextPoint;
          if (lVar3 != null) {
            lVar14 = 32;
            while( true ) {
              if (lVar3.Count <= (int)uVar11) goto switchD_180fdd74e_default;
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar14 + lVar3._items);
              if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null)
              break;
              iVar13 = 1;
              if (!this.goodSpePoint) {
                iVar13 = -1;
              }
              *(float *)(lVar3 + 48) =
                   (((float)this.hardLv * 0.2 + 0.5) * (float)iVar13 + 1.0) *
                   *(float *)(lVar3 + 48);
              lVar3 = FUN_18046c0a0(0);
              uVar5 = "经验{0}%";
              local_res8[0] = this.hardLv * 20 + 50;
              if (!this.goodSpePoint) {
                local_res8[0] = -local_res8[0];
              }
              uVar6 = Int32.ToString(local_res8,"+0;-0;0",0);
              uVar5 = String.Format(uVar5,uVar6,0);
              if (((this.nextPoint == null) ||
                  (lVar8 = FUN_180002f80(this.nextPoint,uVar11,DAT_181d89918)) == null)
                 || (lVar8 = GameObject.get_transform(lVar8,0)) == null) break;
              puVar4 = (uint64 *)Transform.get_position(&local_88,lVar8,0);
              uVar6 = *puVar4;
              uVar16 = *(uint32 *)(puVar4 + 1);
              if (!this.goodSpePoint) {
                uVar7 = *(uint64 *)(pStatics_3d40 + 0x2f0);
                uVar15 = *(uint64 *)(pStatics_3d40 + 0x2f8);
              }
              else {
                uVar7 = *(uint64 *)(pStatics_3d40 + 0x288);
                uVar15 = *(uint64 *)(pStatics_3d40 + 0x290);
              }
              if (lVar3 == null) break;
              uStack_90 = CONCAT44(uStack_90._4_4_,uVar16);
              local_98 = uVar6;
              local_78 = uVar7;
              uStack_70 = uVar15;
              GameController.ShowTextAtPos(lVar3,uVar5,&local_98,16,&local_78,0);
              if (((this.nextPoint == null) ||
                  (lVar3 = FUN_180002f80(this.nextPoint,uVar11,DAT_181d89918)) == null)
                 || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null) break;
              StudyInternalPointController.RefreshInfo(lVar3,0);
              lVar3 = this.nextPoint;
              uVar11 = uVar11 + 1;
              lVar14 = lVar14 + 8;
              if (lVar3 == null) break;
            }
          }
          goto LAB_180fde745;
        case 3:
          lVar3 = this.nextPoint;
          if (lVar3 != null) {
            lVar14 = 32;
            while( true ) {
              if (lVar3.Count <= (int)uVar11) goto switchD_180fdd74e_default;
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar14 + lVar3._items);
              if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null)
              break;
              iVar13 = 1;
              if (!this.goodSpePoint) {
                iVar13 = -1;
              }
              *(float *)(lVar3 + 40) =
                   ((float)this.hardLv * 0.02 + 0.05) * (float)iVar13 +
                   *(float *)(lVar3 + 40);
              lVar3 = FUN_18046c0a0(0);
              uVar5 = "成功率{0}%";
              local_res8[0] = this.hardLv * 2 + 5;
              if (!this.goodSpePoint) {
                local_res8[0] = -local_res8[0];
              }
              uVar6 = Int32.ToString(local_res8,"+0;-0;0",0);
              uVar5 = String.Format(uVar5,uVar6,0);
              if (((this.nextPoint == null) ||
                  (lVar8 = FUN_180002f80(this.nextPoint,uVar11,DAT_181d89918)) == null)
                 || (lVar8 = GameObject.get_transform(lVar8,0)) == null) break;
              puVar4 = (uint64 *)Transform.get_position(&local_88,lVar8,0);
              uVar6 = *puVar4;
              uVar16 = *(uint32 *)(puVar4 + 1);
              if (!this.goodSpePoint) {
                uVar7 = *(uint64 *)(pStatics_3d40 + 0x2f0);
                uVar15 = *(uint64 *)(pStatics_3d40 + 0x2f8);
              }
              else {
                uVar7 = *(uint64 *)(pStatics_3d40 + 0x288);
                uVar15 = *(uint64 *)(pStatics_3d40 + 0x290);
              }
              if (lVar3 == null) break;
              uStack_90 = CONCAT44(uStack_90._4_4_,uVar16);
              local_98 = uVar6;
              local_78 = uVar7;
              uStack_70 = uVar15;
              GameController.ShowTextAtPos(lVar3,uVar5,&local_98,16,&local_78,0);
              if (((this.nextPoint == null) ||
                  (lVar3 = FUN_180002f80(this.nextPoint,uVar11)) == null) ||
                 (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null) break;
              StudyInternalPointController.RefreshInfo(lVar3,0);
              lVar3 = this.nextPoint;
              uVar11 = uVar11 + 1;
              lVar14 = lVar14 + 8;
              if (lVar3 == null) break;
            }
          }
          goto LAB_180fde745;
        case 4:
          iVar13 = Mathf.FloorToInt((float)this.hardLv * 0.5,0);
          iVar13 = iVar13 + 1;
          if (!this.goodSpePoint) {
            for (; 0 < iVar13; iVar13 = iVar13 + -1) {
              if (this.nextPoint == null) goto LAB_180fde745;
              iVar2 = this.nextPoint.Count;
              if (iVar2 < 1) break;
              uVar11 = FUN_180d95a30(0,iVar2,0);
              lVar3 = this.nextPoint;
              lVar14 = (int64)(int)uVar11;
              if (lVar3 == null) goto LAB_180fde745;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar14 * 8);
              if (((this.nextPoint == null) ||
                  (FUN_1817eee00(this.nextPoint,lVar3,DAT_181d89618), lVar3 == null)) ||
                 (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null) goto LAB_180fde745;
              lVar3 = *(int64 *)(lVar3 + 104);
              uVar5 = Component.get_gameObject(this,0);
              if (lVar3 == null) goto LAB_180fde745;
              FUN_1817eee00(lVar3,uVar5,DAT_181d89618);
              lVar3 = this.lineRendererBack;
              lVar8 = this.lineRendererBackBroken;
              if (lVar3 == null) goto LAB_180fde745;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar8 == null) goto LAB_180fde745;
              FUN_18181e0a0(lVar8,*(uint64 *)(lVar3._items + 32 + lVar14 * 8),
                            DAT_181d92a90);
              lVar3 = this.lineRendererBack;
              if (lVar3 == null) goto LAB_180fde745;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar14 * 8);
              puVar4 = (uint64 *)Color.get_red(&local_88,0);
              if (lVar3 == null) goto LAB_180fde745;
              local_78 = *puVar4;
              uStack_70 = puVar4[1];
              LineRenderer.set_startColor(lVar3,&local_78,0);
              lVar3 = this.lineRendererBack;
              if (lVar3 == null) goto LAB_180fde745;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3._items + 32 + lVar14 * 8);
              puVar4 = (uint64 *)Color.get_red(&local_98,0);
              if (lVar3 == null) goto LAB_180fde745;
              local_78 = *puVar4;
              uStack_70 = puVar4[1];
              LineRenderer.set_endColor(lVar3,&local_78,0);
              if (this.lineRendererBack == null) goto LAB_180fde745;
              FUN_181823590(this.lineRendererBack,uVar11);
            }
          }
          else {
            iVar2 = -1;
            do {
              iVar10 = -1;
              do {
                if (((iVar2 != 0) || (iVar10 != 0)) &&
                   (iVar12 = this.column + iVar10, -1 < iVar12)) {
                  lVar14 = FUN_1808e3de0(0);
                  if (lVar14 == null) goto LAB_180fde745;
                  if ((iVar12 < *(int *)(lVar14 + 168)) &&
                     (iVar12 = this.row + iVar2, -1 < iVar12)) {
                    lVar14 = FUN_1808e3de0(0);
                    if (lVar14 == null) goto LAB_180fde745;
                    if (iVar12 < *(int *)(lVar14 + 172)) {
                      lVar14 = this.nextPoint;
                      lVar8 = FUN_1808e3de0(0);
                      if (((lVar8 == null) || (*(int64 *)(lVar8 + 176) == 0)) ||
                         (uVar5 = FUN_180127f90(*(int64 *)(lVar8 + 176),
                                                (int64)(this.column + iVar10),
                                                (int64)(this.row + iVar2)), lVar14 == null
                         )) goto LAB_180fde745;
                      cVar1 = FUN_18181e400(lVar14,uVar5,DAT_181d89498);
                      if (!cVar1) {
                        lVar14 = FUN_1808e3de0(0);
                        if (((lVar14 == null) || (*(int64 *)(lVar14 + 176) == 0)) ||
                           (uVar5 = FUN_180127f90(*(int64 *)(lVar14 + 176),
                                                  (int64)(this.column + iVar10),
                                                  (int64)(this.row + iVar2)),
                           lVar3 == null)) goto LAB_180fde745;
                        FUN_18181e0a0(lVar3,uVar5,DAT_181d89398);
                      }
                    }
                  }
                }
                iVar10 = iVar10 + 1;
              } while (iVar10 < 2);
              iVar2 = iVar2 + 1;
            } while (iVar2 < 2);
            for (; 0 < iVar13; iVar13 = iVar13 + -1) {
              uVar16 = (uint32)((uint64)in_stack_ffffffffffffff58 >> 32);
              if (lVar3 == null) goto LAB_180fde745;
              if (lVar3.Count < 1) break;
              uVar11 = FUN_180d95a30(0,lVar3.Count,0);
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar14 = lVar3._items[uVar11];
              if (((this.nextPoint == null) ||
                  (FUN_18181e0a0(this.nextPoint,lVar14,DAT_181d89398), lVar14 == null)) ||
                 (lVar8 = GameObject.GetComponent(lVar14,DAT_181d73e60)) == null) {
        LAB_180fde73f:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar8 = *(int64 *)(lVar8 + 104);
              uVar5 = Component.get_gameObject(this,0);
              if (lVar8 == null) goto LAB_180fde73f;
              FUN_18181e0a0(lVar8,uVar5,DAT_181d89398);
              lVar8 = this.lineRendererBack;
              uVar5 = Component.get_gameObject(this,0);
              if (*pStatics_8110 == 0) goto LAB_180fde73f;
              uVar6 = *(uint64 *)(*pStatics_8110 + 64);
              lVar9 = GlobalData.AddChild(uVar5,uVar6,0);
              if ((lVar9 == null) || (uVar5 = GameObject.GetComponent(lVar9,DAT_181d72238), lVar8 == null))
              goto LAB_180fde73f;
              FUN_18181e0a0(lVar8,uVar5,DAT_181d92a90);
              lVar8 = this.lineRendererBack;
              if (lVar8 == null) goto LAB_180fde73f;
              lVar8 = FUN_180002f80(lVar8,lVar8.Count + -1,DAT_181d92c90);
              local_88 = 0;
              uStack_80 = 0;
              FUN_1809dc910(&local_88);
              if (lVar8 == null) goto LAB_180fde73f;
              local_78 = local_88;
              uStack_70 = uStack_80;
              LineRenderer.set_startColor(lVar8,&local_78,0);
              lVar8 = this.lineRendererBack;
              if (lVar8 == null) goto LAB_180fde73f;
              lVar8 = FUN_180002f80(lVar8,lVar8.Count + -1,DAT_181d92c90);
              uVar5 = 0;
              in_stack_ffffffffffffff58 = CONCAT44(uVar16,0x3f19999a);
              local_98 = 0;
              uStack_90 = 0;
              FUN_1809dc910(&local_98);
              if (lVar8 == null) goto LAB_180fde73f;
              local_78 = local_98;
              uStack_70 = uStack_90;
              LineRenderer.set_endColor(lVar8,&local_78,0);
              lVar8 = this.lineRendererBack;
              if (lVar8 == null) goto LAB_180fde73f;
              uVar6 = FUN_180002f80(lVar8,lVar8.Count + -1,DAT_181d92c90);
              lVar8 = this.nextPoint;
              if (lVar8 == null) goto LAB_180fde73f;
              uVar7 = FUN_180002f80(lVar8,lVar8.Count + -1,DAT_181d89918);
              uVar5 = StudyInternalPointController.TweenLine
                                (this,uVar6,uVar7,0,in_stack_ffffffffffffff58,uVar5);
              FUN_180d8c2e0(this,uVar5,0);
              FUN_1817eee00(lVar3,lVar14);
            }
          }
          break;
        case 5:
          while( true ) {
            if ((*pStatics_8110 == 0) ||
               (lVar8 = *(int64 *)(*pStatics_8110 + 184)) == null) break;
            if (lVar8.Count <= (int)uVar11) {
              iVar13 = this.hardLv * 2 + 5;
              goto joined_r0x000180fde4a5;
            }
            if ((*pStatics_8110 == 0) ||
               (lVar8 = *(int64 *)(*pStatics_8110 + 184)) == null) break;
            if (lVar8.Count <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar8 = *(int64 *)(lVar14 + lVar8._items);
            if ((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181d73e60)) == null)
            break;
            if (*(char *)(lVar8 + 44) == false) {
              lVar8 = this.nextPoint;
              lVar9 = FUN_1808e3de0(0);
              if (((lVar9 == null) || (plVar9 == 0)) ||
                 (uVar5 = FUN_180002f80(plVar9,uVar11,DAT_181d89918), lVar8 == null))
              break;
              cVar1 = FUN_18181e400(lVar8,uVar5);
              if (!cVar1) {
                lVar8 = FUN_1808e3de0(0);
                if (((lVar8 == null) || (plVar8 == 0)) ||
                   (uVar5 = FUN_180002f80(plVar8,uVar11,DAT_181d89918), lVar3 == null))
                break;
                FUN_18181e0a0(lVar3,uVar5);
              }
            }
            uVar11 = uVar11 + 1;
            lVar14 = lVar14 + 8;
          }
          goto LAB_180fde745;
        case 6:
          lVar3 = FUN_1808e3de0(0);
          if (lVar3 == null) goto LAB_180fde745;
          iVar13 = *(int *)(lVar3 + 192);
          iVar2 = Mathf.FloorToInt((float)this.hardLv * 0.5,0);
          *(int *)(lVar3 + 192) = iVar2 + 1 + iVar13;
          lVar3 = FUN_1808e3de0(0);
          if (lVar3 == null) goto LAB_180fde745;
          if (*(char *)(lVar3 + 129) != false) {
            StudyInternalPointController.RandomCrashNextPoint(this,0);
          }
        }
        switchD_180fdd74e_default:
        uVar11 = 0;
        lVar14 = 32;
        lVar3 = this.nextPoint;
        if (lVar3 != null) {
          while( true ) {
            if (lVar3.Count <= (int)uVar11) {
              return;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar14 + lVar3._items);
            if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null)
            break;
            StudyInternalPointController.Seen(lVar3,0);
            lVar3 = this.nextPoint;
            uVar11 = uVar11 + 1;
            lVar14 = lVar14 + 8;
            if (lVar3 == null) break;
          }
        }
        LAB_180fde745:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        joined_r0x000180fde4a5:
        if (iVar13 < 1) goto switchD_180fdd74e_default;
        if (lVar3 == null) goto LAB_180fde745;
        if (lVar3.Count < 1) goto switchD_180fdd74e_default;
        uVar11 = FUN_180d95a30(0,lVar3.Count,0);
        if (lVar3.Count <= uVar11) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar14 = lVar3._items[uVar11];
        if ((lVar14 == null) || (lVar14 = GameObject.GetComponent(lVar14,DAT_181d73e60)) == null)
        goto LAB_180fde745;
        StudyInternalPointController.Seen(lVar14,0);
        lVar14 = FUN_18046c0a0(0);
        lVar8 = FUN_180002f80(lVar3,uVar11,DAT_181d89918);
        if ((lVar8 == null) || (lVar8 = GameObject.get_transform(lVar8,0)) == null) goto LAB_180fde745;
        puVar4 = (uint64 *)Transform.get_position(&local_88,lVar8,0);
        uVar5 = *puVar4;
        uVar16 = *(uint32 *)(puVar4 + 1);
        if (lVar14 == null) goto LAB_180fde745;
        local_78 = *(uint64 *)(pStatics_3d40 + 0x288);
        uStack_70 = *(uint64 *)(pStatics_3d40 + 0x290);
        uStack_90 = CONCAT44(uStack_90._4_4_,uVar16);
        local_98 = uVar5;
        GameController.ShowTextAtPos(lVar14,"明",&local_98,16,&local_78,0);
        FUN_181823590(lVar3,uVar11);
        iVar13 = iVar13 + -1;
        goto joined_r0x000180fde4a5;
    }

    // Token : 0x600226E
    // RVA   : 0xFDC980   Offset: 0xFDBD80   Length: 0x32B
    public void RandomCrashNextPoint()
    {
        var pStatics = *(int64*)(DAT_181da8110 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        long lVar6;
        lVar2 = il2cpp_internal(DAT_181d92f58);
        FUN_18132faf0(lVar2);
        lVar3 = this.nextPoint;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar6 = 32;
          while ((int)uVar5 < lVar3.Count) {
            if (lVar3 == null) throw; // [null/range check failed]
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar6 + lVar3._items);
            if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d73e60)) == null)
            throw; // [null/range check failed]
            if (*(char *)(lVar3 + 45) == false) {
              if ((this.nextPoint == null) ||
                 (uVar4 = FUN_180002f80(this.nextPoint,uVar5,DAT_181d89918), lVar2 == null))
              throw; // [null/range check failed]
              FUN_18181e0a0(lVar2,uVar4);
            }
            lVar3 = this.nextPoint;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 24) < 1) {
              if (*pStatics != 0) {
                *(uint8 *)(*pStatics + 129) = 1;
                if (*pStatics != 0) {
                  *(uint32 *)(*pStatics + 192) = 0;
                  return;
                }
              }
            }
            else {
              if (*pStatics != 0) {
                *(uint8 *)(*pStatics + 129) = 0;
                uVar5 = FUN_180d95a30(0,*(uint32 *)(lVar2 + 24),0);
                if (*(uint32 *)(lVar2 + 24) <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                this.chooseNextPoint =
                     lVar2[uVar5];
                il2cpp_internal(this + 96);
                if ((this.chooseNextPoint != null) &&
                   (lVar3 = GameObject.GetComponent(this.chooseNextPoint,DAT_181d73e60),
                   lVar3 != null)) {
                  bVar7 = !DAT_181ea07ca;
                  *(uint32 *)(lVar3 + 32) = 0x3f800000;
                  if (bVar7) {
                    il2cpp_runtime_class_init(&DAT_181d897b8);
                    DAT_181ea07ca = true;
                  }
                  lVar3 = new WarpText_d__8(0,0);
                  if (lVar3 != null) {
                    *(int64 *)(lVar3 + 32) = this;
                    FUN_180d8c2e0(this,lVar3,0);
                    if (*pStatics != 0) {
                      piVar1 = (int *)(*pStatics + 192);
                      *piVar1 = *piVar1 + -1;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600226F
    // RVA   : 0xFDEC40   Offset: 0xFDE040   Length: 0xA4
    public IEnumerator TweenLine(LineRenderer targetRenderer, GameObject targetPoint)
    {
        int64 StudyInternalPointController.TweenLine
                         (uint64 this,uint64 targetRenderer,uint64 targetPoint)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint64 *)(lVar1 + 32) = targetRenderer;
          *(uint64 *)(lVar1 + 48) = targetPoint;
          return lVar1;
        }
    }

    // Token : 0x6002270
    // RVA   : 0xFDE770   Offset: 0xFDDB70   Length: 0x6C
    public IEnumerator ShowHighLightLine()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002271
    // RVA   : 0xFDC640   Offset: 0xFDBA40   Length: 0x239
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181da8110 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (*pStatics != 0) {
          if (*(char *)(*pStatics + 129) == false) {
            return;
          }
          if (((*pStatics != 0) &&
              (lVar2 = *(int64 *)(*pStatics + 136)) != null) &&
             (lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60)) != null) {
            lVar2 = *(int64 *)(lVar2 + 104);
            uVar3 = Component.get_gameObject(this,0);
            if (lVar2 != null) {
              cVar1 = FUN_18181e400(lVar2,uVar3,DAT_181d89498);
              if (!cVar1) {
                return;
              }
              if (this.crashed) {
                return;
              }
              if (*pStatics != 0) {
                *(uint8 *)(*pStatics + 129) = 0;
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 136)) != null) {
                  lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60);
                  uVar3 = Component.get_gameObject(this,0);
                  if (lVar2 != null) {
                    *(uint64 *)(lVar2 + 96) = uVar3;
                    if (((*pStatics != 0) &&
                        (lVar2 = *(int64 *)(*pStatics + 136)) != null)
                       && (lVar2 = GameObject.GetComponent(lVar2,DAT_181d73e60)) != null) {
                      uVar3 = StudyInternalPointController.ShowHighLightLine(lVar2,0);
                      FUN_180d8c2e0(this,uVar3,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002272
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
