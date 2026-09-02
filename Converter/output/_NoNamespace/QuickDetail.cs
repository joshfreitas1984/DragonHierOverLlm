// ============================================================
// Type  : QuickDetail
// Token : 0x2000324
// ============================================================

public class QuickDetail
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001958
    public GameObject Back;

    // Token: 0x4001959
    public GameObject equipDetail;

    // Token: 0x400195A
    public List<GameObject> equipDetailCompare;

    // Token: 0x400195B
    public GameObject medfoodDetail;

    // Token: 0x400195C
    public GameObject bookDetail;

    // Token: 0x400195D
    public GameObject treasureDetail;

    // Token: 0x400195E
    public GameObject materialDetail;

    // Token: 0x400195F
    public GameObject horseDetail;

    // Token: 0x4001960
    public GameObject horseDetailCompare;

    // Token: 0x4001961
    public GameObject skillDetail;

    // Token: 0x4001962
    public GameObject heroDetail;

    // Token: 0x4001963
    public GameObject obstacleDetail;

    // Token: 0x4001964
    public GameObject areaDetail;

    // Token: 0x4001965
    public GameObject resourcePointDetail;

    // Token: 0x4001966
    public GameObject eventDetail;

    // Token: 0x4001967
    public GameObject missionDetail;

    // Token: 0x4001968
    public GameObject exploreTileDetail;

    // Token: 0x4001969
    public GameObject tagDetail;

    // Token: 0x400196A
    public GameObject describeGrid;

    // Token: 0x400196B
    public GameObject skillRangeUI;

    // Token: 0x400196C
    public GameObject nowShowObject;

    // Token: 0x400196D
    public bool detailDirty;

    // Token: 0x400196E
    public bool describePosDirty;

    // Token: 0x400196F
    public bool forceUp;

    // Token: 0x4001970
    public float refreshTimeLeft;

    // Token: 0x4001971
    public GameObject skillDetailLittleDescrbePrefab;

    // Token: 0x4001972
    public GameObject canvasRoot;

    // Token: 0x4001973
    private GameObject newObj;

    // Token: 0x4001974
    private static QuickDetail _instance;

    // Token: 0x4001975
    private static readonly List<float> SummonFollowDetailOffset;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F6D
    // RVA   : 0xBEE000   Offset: 0xBEC800   Length: 0x57
    public static QuickDetail get_Instance()
    {
        return **(uint64 **)(DAT_181d6ece0 + 184);
    }

    // Token : 0x6001F6E
    // RVA   : 0xBDF590   Offset: 0xBDDD90   Length: 0x61
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d6ece0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001F6F
    // RVA   : 0xBEAA20   Offset: 0xBE9220   Length: 0x395
    private void Start()
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        int iVar5;
        float fVar6;
        float[] local_48 = new float[4];
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        local_38 = 0;
        uStack_30 = 0;
        uVar1 = GameObject.FindGameObjectWithTag("UICanvas",0);
        this.canvasRoot = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.equipDetailCompare = uVar1;
        iVar5 = 0;
        do {
          lVar3 = this.equipDetail;
          if (lVar3 == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(lVar3,0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar1 = FUN_180da0f00(lVar2,0);
          uVar1 = Object.Instantiate(lVar3,uVar1,DAT_181d6a078);
          this.newObj = uVar1;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(this.newObj,0);
          if (this.equipDetail == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(this.equipDetail,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Back",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.GetComponent(lVar2,DAT_181d6c740);
          if (lVar2 == null) throw; // [null/range check failed]
          puVar4 = (uint64 *)RectTransform.get_rect(local_28,lVar2,0);
          iVar5 = iVar5 + 1;
          local_38 = *puVar4;
          uStack_30 = puVar4[1];
          fVar6 = (float)FUN_180d90480(&local_38,0);
          if (lVar3 == null) throw; // [null/range check failed]
          local_48[1] = 0.0;
          local_48[2] = 0.0;
          local_48[0] = -fVar6 * (float)iVar5;
          Transform.set_localPosition(lVar3,local_48,0);
          if (this.equipDetailCompare == null) throw; // [null/range check failed]
          FUN_181827900(this.equipDetailCompare,this.newObj,DAT_181d61bf8);
        } while (iVar5 < 2);
        lVar3 = this.horseDetail;
        if (lVar3 != null) {
          lVar2 = GameObject.get_transform(lVar3,0);
          if (lVar2 != null) {
            uVar1 = FUN_180da0f00(lVar2,0);
            uVar1 = Object.Instantiate(lVar3,uVar1,DAT_181d6a078);
            this.horseDetailCompare = uVar1;
            if (this.horseDetailCompare != null) {
              lVar3 = GameObject.get_transform(this.horseDetailCompare,0);
              if (this.horseDetail != null) {
                lVar2 = GameObject.get_transform(this.horseDetail,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"Back",0);
                  if (lVar2 != null) {
                    lVar2 = Component.GetComponent(lVar2,DAT_181d6c740);
                    if (lVar2 != null) {
                      puVar4 = (uint64 *)RectTransform.get_rect(local_28,lVar2,0);
                      local_38 = *puVar4;
                      uStack_30 = puVar4[1];
                      fVar6 = (float)FUN_180d90480(&local_38,0);
                      if (lVar3 != null) {
                        local_48[1] = 0.0;
                        local_48[2] = 0.0;
                        local_48[0] = -fVar6;
                        Transform.set_localPosition(lVar3,local_48,0);
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

    // Token : 0x6001F70
    // RVA   : 0xBEADC0   Offset: 0xBE95C0   Length: 0x30D4
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d66570 + 184);
        bool cVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        uint uVar13;
        float fVar14;
        float fVar15;
        ulong local_58;
        uint local_50;
        byte[] local_48 = new byte[32];
        lVar3 = this.nowShowObject;
        cVar2 = Object.op_Inequality(lVar3,0,0);
        if (cVar2) {
          fVar15 = this.refreshTimeLeft;
          fVar14 = (float)RealTime.get_deltaTime(0);
          fVar15 = fVar15 - fVar14;
          this.refreshTimeLeft = fVar15;
          if ((this.describePosDirty) || (fVar15 <= 0.0)) {
            this.refreshTimeLeft = fVar15 + 0.01;
            lVar3 = Component.get_transform(this,0);
            puVar4 = (uint64 *)Vector3.get_one(local_48,0);
            if (lVar3 == null) goto LAB_180bede8c;
            local_50 = *(uint32 *)(puVar4 + 1);
            local_58 = *puVar4;
            Transform.set_localScale(lVar3,&local_58,0);
            QuickDetail.RefreshPosition(this,0);
            this.describePosDirty = 0;
          }
        }
        cVar2 = FUN_1804625b0(0x130,0);
        if ((cVar2) || (cVar2 = FUN_180462630(0x130,0), cVar2)) {
          this.detailDirty = 1;
        }
        uVar5 = MouseController.get_hoveredObject(0);
        cVar2 = Object.op_Inequality(uVar5,0,0);
        if (!cVar2) {
          uVar5 = *(uint64 *)(pStatics + 72);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (!cVar2) {
            QuickDetail.DisableDescribe(this,0);
            return;
          }
          if (!this.detailDirty) {
            lVar3 = *plVar1;
            uVar5 = *(uint64 *)(pStatics + 72);
            cVar2 = Object.op_Inequality(uVar5,lVar3,0);
            if (!cVar2) {
              return;
            }
          }
          lVar3 = *plVar1;
          this.detailDirty = 0;
          lVar6 = *(int64 *)(pStatics + 72);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181da0070);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (!cVar2) {
        LAB_180beb803:
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181d9fd40);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fd40)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fd40)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 24) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  uVar5 = this.horseDetail;
                  if ((*plVar1 == 0) ||
                     (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9fd40)) == null)
                  goto LAB_180bede8c;
                  QuickDetail.ShowHorseQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0,0,0);
                  this.describePosDirty = 1;
                  goto LAB_180beddb8;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da1630);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da1630)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da1630)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 32) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  uVar5 = this.skillDetail;
                  if ((*plVar1 == 0) ||
                     (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da1630)) == null)
                  goto LAB_180bede8c;
                  uVar11 = *(uint64 *)(lVar6 + 32);
                  if ((*plVar1 == 0) ||
                     (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da1630)) == null)
                  goto LAB_180bede8c;
                  QuickDetail.ShowSkillQuickDetail(this,uVar5,uVar11,*(int *)(lVar6 + 40) == 3,0);
                  this.describePosDirty = 1;
                  goto LAB_180beddb8;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da1530);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da1530)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da1530)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 24) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  uVar5 = this.skillDetail;
                  if ((*plVar1 == 0) ||
                     (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da1530)) == null)
                  goto LAB_180bede8c;
                  QuickDetail.ShowSkillQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0,0);
                  this.describePosDirty = 1;
                  goto LAB_180beddb8;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181d9fb20);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fb20)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fb20)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 32) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  uVar5 = this.heroDetail;
                  if ((*plVar1 == 0) ||
                     (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9fb20)) == null)
                  goto LAB_180bede8c;
                  QuickDetail.ShowHeroQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 32),0);
                  this.describePosDirty = 1;
                  goto LAB_180beddb8;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181d9f988);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f988)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f988)) == null)
                goto LAB_180bede8c;
                cVar2 = FUN_180d6ca90(*(uint64 *)(lVar6 + 24),0);
                if (!cVar2) {
                  lVar6 = *(int64 *)(pStatics + 72);
                  if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f988)) == null)
                  goto LAB_180bede8c;
                  cVar2 = String.op_Inequality(*(uint64 *)(lVar6 + 24),"掌门亲启",0);
                  if (cVar2) {
                    lVar6 = FUN_18046c0a0(0);
                    if (lVar6 == null) goto LAB_180bede8c;
                    lVar6 = *(int64 *)(lVar6 + 32);
                    lVar10 = *(int64 *)(pStatics + 72);
                    if (((lVar10 == null) ||
                        (lVar10 = GameObject.GetComponent(lVar10,DAT_181d9f988)) == null) ||
                       (lVar6 == null)) goto LAB_180bede8c;
                    lVar6 = WorldData.GetHero(lVar6,*(uint64 *)(lVar10 + 24),0);
                    if (lVar6 != null) {
                      *plVar1 = *(int64 *)(pStatics + 72);
                      il2cpp_internal(plVar1);
                      QuickDetail.SetAllDisactive(this,0);
                      uVar5 = this.heroDetail;
                      lVar6 = FUN_18046c0a0(0);
                      if (lVar6 == null) goto LAB_180bede8c;
                      lVar6 = *(int64 *)(lVar6 + 32);
                      lVar10 = *(int64 *)(pStatics + 72);
                      if (((lVar10 == null) ||
                          (lVar10 = GameObject.GetComponent(lVar10,DAT_181d9f988)) == null) ||
                         (lVar6 == null)) goto LAB_180bede8c;
                      uVar11 = WorldData.GetHero(lVar6,*(uint64 *)(lVar10 + 24),0);
                      QuickDetail.ShowHeroQuickDetail(this,uVar5,uVar11,0);
                      this.describePosDirty = 1;
                      goto LAB_180beddb8;
                    }
                  }
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da0868);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0868)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (!cVar2) goto LAB_180bec43e;
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0868)) == null)
              goto LAB_180bede8c;
              if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180bec43e;
              *plVar1 = *(int64 *)(pStatics + 72);
              il2cpp_internal(plVar1);
              QuickDetail.SetAllDisactive(this,0);
              lVar6 = *plVar1;
              uVar5 = this.areaDetail;
              uVar11 = DAT_181da0868;
        joined_r0x000180bec42c:
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,uVar11)) == null)
              goto LAB_180bede8c;
              QuickDetail.ShowAreaQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
              this.describePosDirty = 1;
              goto LAB_180beddb8;
            }
        LAB_180bec43e:
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da1130);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da1130)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da1130)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 24) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  lVar6 = *plVar1;
                  uVar5 = this.areaDetail;
                  uVar11 = DAT_181da1130;
                  goto joined_r0x000180bec42c;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da0978);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0978)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0978)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 24) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  lVar6 = *plVar1;
                  uVar5 = this.resourcePointDetail;
                  uVar11 = DAT_181da0978;
                  goto joined_r0x000180bed754;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da0e30);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0e30)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0e30)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 24) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  lVar6 = *plVar1;
                  uVar5 = this.resourcePointDetail;
                  uVar11 = DAT_181da0e30;
                  goto joined_r0x000180bed754;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181da0538);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0538)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0538)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 24) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  uVar5 = this.missionDetail;
                  if ((*plVar1 == 0) ||
                     (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0538)) == null)
                  goto LAB_180bede8c;
                  QuickDetail.ShowMissionQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
                  this.describePosDirty = 1;
                  goto LAB_180beddb8;
                }
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181d9e338);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e338)) == null)
              goto LAB_180bede8c;
              if (*(int64 *)(lVar6 + 24) != 0) {
                *plVar1 = *(int64 *)(pStatics + 72);
                il2cpp_internal(plVar1);
                QuickDetail.SetAllDisactive(this,0);
                uVar5 = this.eventDetail;
                lVar6 = *(int64 *)(pStatics + 72);
                uVar11 = DAT_181d9e338;
        joined_r0x000180bed9f2:
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,uVar11)) == null)
                goto LAB_180bede8c;
                QuickDetail.ShowEventQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
                this.describePosDirty = 0x101;
                goto LAB_180beddb8;
              }
            }
            lVar6 = *(int64 *)(pStatics + 72);
            if (lVar6 == null) goto LAB_180bede8c;
            uVar5 = GameObject.GetComponent(lVar6,DAT_181d9fcb8);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = *(int64 *)(pStatics + 72);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fcb8)) == null)
              goto LAB_180bede8c;
              cVar2 = Behaviour.get_enabled(lVar6,0);
              if (cVar2) {
                lVar6 = *(int64 *)(pStatics + 72);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fcb8)) == null)
                goto LAB_180bede8c;
                if (*(int64 *)(lVar6 + 32) != 0) {
                  *plVar1 = *(int64 *)(pStatics + 72);
                  il2cpp_internal(plVar1);
                  QuickDetail.SetAllDisactive(this,0);
                  uVar5 = this.tagDetail;
                  if (*plVar1 == 0) goto LAB_180bede8c;
                  uVar11 = GameObject.GetComponent(*plVar1,DAT_181d9fcb8);
                  QuickDetail.ShowTagQuickDetail(this,uVar5,uVar11,0);
                  this.describePosDirty = 0x101;
                  goto LAB_180beddb8;
                }
              }
            }
            goto LAB_180bedda1;
          }
          lVar6 = *(int64 *)(pStatics + 72);
          if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0070)) == null)
          goto LAB_180bede8c;
          cVar2 = Behaviour.get_enabled(lVar6,0);
          if (!cVar2) goto LAB_180beb803;
          lVar6 = *(int64 *)(pStatics + 72);
          if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0070)) == null)
          goto LAB_180bede8c;
          if (*(int64 *)(lVar6 + 32) == 0) goto LAB_180beb803;
          *plVar1 = *(int64 *)(pStatics + 72);
          il2cpp_internal(plVar1);
          QuickDetail.SetAllDisactive(this,0);
          lVar6 = *(int64 *)(pStatics + 72);
          if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0070)) == null) ||
             (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180bede8c;
          switch(*(uint32 *)(*(int64 *)(lVar6 + 32) + 20)) {
          case 0:
            uVar5 = this.equipDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
            goto LAB_180bede8c;
            uVar11 = *(uint64 *)(lVar6 + 32);
            if (*plVar1 == 0) goto LAB_180bede8c;
            uVar9 = GameObject.GetComponent(*plVar1,DAT_181da0070);
            uVar12 = 0;
            QuickDetail.ShowEquipmentQuickDetail(this,uVar5,uVar11,0,uVar9,0);
            cVar2 = FUN_1804625f0(0x130,0);
            if (!cVar2) goto switchD_180beb3e1_default;
            if ((((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
                || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = QuickDetail.FindPlayerEquipment
                                  (this,*(uint32 *)(*(int64 *)(lVar6 + 32) + 24),0),
               lVar6 == null)) goto LAB_180bede8c;
            lVar10 = 32;
            uVar13 = uVar12;
            for (; (int)uVar12 < (int)*(uint32 *)(lVar6 + 24); uVar12 = uVar12 + 1) {
              if (this.equipDetailCompare == null) goto LAB_180bede8c;
              if (this.equipDetailCompare.Count <= (int)uVar13) break;
              if (*(uint32 *)(lVar6 + 24) <= uVar12) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int64 *)(lVar10 + *(int64 *)(lVar6 + 16)) != 0) {
                lVar7 = FUN_180002f80(lVar6,uVar12);
                lVar8 = *(int64 *)(pStatics + 72);
                if ((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
                goto LAB_180bede8c;
                if (lVar7 != *(int64 *)(lVar8 + 32)) {
                  if (this.equipDetailCompare == null) goto LAB_180bede8c;
                  uVar5 = FUN_180002f80(this.equipDetailCompare,uVar13,DAT_181d62178);
                  uVar11 = FUN_180002f80(lVar6,uVar12,DAT_181d69770);
                  QuickDetail.ShowEquipmentQuickDetail(this,uVar5,uVar11,1,0,0);
                  uVar13 = uVar13 + 1;
                }
              }
              lVar10 = lVar10 + 8;
            }
            this.describePosDirty = 1;
            break;
          case 1:
          case 2:
            uVar5 = this.medfoodDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
            goto LAB_180bede8c;
            QuickDetail.ShowMedFoodQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 32),0);
            this.describePosDirty = 1;
            break;
          case 3:
            uVar5 = this.bookDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
            goto LAB_180bede8c;
            QuickDetail.ShowBookQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 32),0);
            this.describePosDirty = 1;
            break;
          case 4:
            uVar5 = this.treasureDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
            goto LAB_180bede8c;
            QuickDetail.ShowTreasureQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 32),0);
            this.describePosDirty = 1;
            break;
          case 5:
            uVar5 = this.materialDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
            goto LAB_180bede8c;
            QuickDetail.ShowMaterialQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 32),0);
            this.describePosDirty = 1;
            break;
          case 6:
            uVar5 = this.horseDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
            goto LAB_180bede8c;
            uVar11 = *(uint64 *)(lVar6 + 32);
            if (*plVar1 == 0) goto LAB_180bede8c;
            uVar9 = GameObject.GetComponent(*plVar1,DAT_181da0070);
            QuickDetail.ShowHorseQuickDetail(this,uVar5,uVar11,0,uVar9,0);
            cVar2 = FUN_1804625f0(0x130,0);
            if (cVar2) {
              if (((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null
                  ) || (*(int64 *)(lVar6 + 32) == 0)) goto LAB_180bede8c;
              if (*(int *)(*(int64 *)(lVar6 + 32) + 24) == 0) {
                lVar6 = QuickDetail.GetTargetHero(this,0);
                if (lVar6 == null) goto LAB_180bede8c;
                lVar6 = *(int64 *)(lVar6 + 0x208);
              }
              else {
                lVar6 = QuickDetail.GetTargetHero(this,0);
                if (lVar6 == null) goto LAB_180bede8c;
                lVar6 = *(int64 *)(lVar6 + 0x218);
              }
              if (lVar6 != null) {
                if ((*plVar1 == 0) ||
                   (lVar10 = GameObject.GetComponent(*plVar1,DAT_181da0070)) == null)
                goto LAB_180bede8c;
                if (lVar6 != *(int64 *)(lVar10 + 32)) {
                  QuickDetail.ShowHorseQuickDetail(this,this.horseDetailCompare,lVar6,1,0,0);
                  this.describePosDirty = 1;
                  break;
                }
              }
            }
          default:
        switchD_180beb3e1_default:
            this.describePosDirty = 1;
          }
        }
        else {
          if (!this.detailDirty) {
            uVar5 = MouseController.get_hoveredObject(0);
            lVar3 = *plVar1;
            cVar2 = Object.op_Inequality(uVar5,lVar3,0);
            if (!cVar2) {
              return;
            }
          }
          lVar3 = *plVar1;
          this.detailDirty = 0;
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9e910);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e910)) == null)
            goto LAB_180bede8c;
            cVar2 = Behaviour.get_enabled(lVar6,0);
            if (!cVar2) goto LAB_180bed015;
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e910)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180bed015;
            lVar6 = MouseController.get_hoveredObject(0);
            *plVar1 = lVar6;
            il2cpp_internal(plVar1,lVar6);
            QuickDetail.SetAllDisactive(this,0);
            uVar5 = this.heroDetail;
            if ((*plVar1 == 0) || (lVar6 = GameObject.GetComponent(*plVar1,DAT_181d9e910)) == null)
            goto LAB_180bede8c;
            uVar11 = *(uint64 *)(lVar6 + 24);
        LAB_180bed199:
            QuickDetail.ShowHeroQuickDetail(this,uVar5,uVar11,0);
            this.describePosDirty = 1;
            goto LAB_180beddb8;
          }
        LAB_180bed015:
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9f7f0);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f7f0)) == null) ||
               (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180bede8c;
            uVar5 = *(uint64 *)(*(int64 *)(lVar6 + 24) + 24);
            cVar2 = Object.op_Inequality(uVar5,0,0);
            if (cVar2) {
              lVar6 = MouseController.get_hoveredObject(0);
              *plVar1 = lVar6;
              il2cpp_internal(plVar1,lVar6);
              QuickDetail.SetAllDisactive(this,0);
              uVar5 = this.heroDetail;
              lVar6 = MouseController.get_hoveredObject(0);
              if ((((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f7f0)) == null)
                  || (*(int64 *)(lVar6 + 24) == 0)) ||
                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 24)) == null)
              goto LAB_180bede8c;
              uVar11 = *(uint64 *)(lVar6 + 64);
              goto LAB_180bed199;
            }
          }
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9f7f0);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f7f0)) == null) ||
               (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180bede8c;
            if (*(int *)(*(int64 *)(lVar6 + 24) + 20) != 2) {
              lVar6 = MouseController.get_hoveredObject(0);
              if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f7f0)) == null) ||
                 ((*(int64 *)(lVar6 + 24) == 0 ||
                  (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 56)) == null)))
              goto LAB_180bede8c;
              if (*(int *)(lVar6 + 16) == 0) goto LAB_180bed4f7;
              lVar6 = MouseController.get_hoveredObject(0);
              if ((((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f7f0)) == null)
                  || (*(int64 *)(lVar6 + 24) == 0)) ||
                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 56)) == null)
              goto LAB_180bede8c;
              if (-1 < *(int *)(lVar6 + 48)) {
                lVar6 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
                if (lVar6 == null) goto LAB_180bede8c;
                lVar6 = *(int64 *)(lVar6 + 112);
                lVar10 = MouseController.get_hoveredObject(0);
                if ((((lVar10 == null) ||
                     (lVar10 = GameObject.GetComponent(lVar10,DAT_181d9f7f0)) == null) ||
                    (*(int64 *)(lVar10 + 24) == 0)) ||
                   ((lVar10 = *(int64 *)(*(int64 *)(lVar10 + 24) + 56), lVar10 == null ||
                    (lVar6 == null)))) goto LAB_180bede8c;
                uVar12 = *(uint32 *)(lVar10 + 48);
                if (*(uint32 *)(lVar6 + 24) <= uVar12) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = lVar6[uVar12];
                if (lVar6 == null) goto LAB_180bede8c;
                if (*(char *)(lVar6 + 20) == false) goto LAB_180bed4f7;
              }
            }
            lVar6 = MouseController.get_hoveredObject(0);
            *plVar1 = lVar6;
            il2cpp_internal(plVar1,lVar6);
            QuickDetail.SetAllDisactive(this,0);
            uVar5 = this.obstacleDetail;
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f7f0)) == null)
            goto LAB_180bede8c;
            QuickDetail.ShowBattleGridQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
            this.describePosDirty = 1;
            goto LAB_180beddb8;
          }
        LAB_180bed4f7:
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9e3c0);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e3c0)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) != 0) {
              lVar6 = MouseController.get_hoveredObject(0);
              *plVar1 = lVar6;
              il2cpp_internal(plVar1,lVar6);
              QuickDetail.SetAllDisactive(this,0);
              uVar5 = this.areaDetail;
              lVar6 = MouseController.get_hoveredObject(0);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e3c0)) == null)
              goto LAB_180bede8c;
              QuickDetail.ShowAreaQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
              this.describePosDirty = 1;
              goto LAB_180beddb8;
            }
          }
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181da0db0);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181da0db0)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180bed790;
            lVar6 = MouseController.get_hoveredObject(0);
            *plVar1 = lVar6;
            il2cpp_internal(plVar1,lVar6);
            QuickDetail.SetAllDisactive(this,0);
            uVar5 = this.resourcePointDetail;
            lVar6 = MouseController.get_hoveredObject(0);
            uVar11 = DAT_181da0db0;
        joined_r0x000180bed754:
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,uVar11)) == null)
            goto LAB_180bede8c;
            QuickDetail.ShowResourcePointQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
            goto switchD_180beb3e1_default;
          }
        LAB_180bed790:
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9e800);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e800)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) != 0) {
              lVar6 = MouseController.get_hoveredObject(0);
              *plVar1 = lVar6;
              il2cpp_internal(plVar1,lVar6);
              QuickDetail.SetAllDisactive(this,0);
              uVar5 = this.eventDetail;
              lVar6 = MouseController.get_hoveredObject(0);
              if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e800)) == null)
              goto LAB_180bede8c;
              QuickDetail.ShowEventQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
              this.describePosDirty = 0x101;
              goto LAB_180beddb8;
            }
          }
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9e448);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9e448)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180beda30;
            lVar6 = MouseController.get_hoveredObject(0);
            *plVar1 = lVar6;
            il2cpp_internal(plVar1,lVar6);
            QuickDetail.SetAllDisactive(this,0);
            uVar5 = this.eventDetail;
            lVar6 = MouseController.get_hoveredObject(0);
            uVar11 = DAT_181d9e448;
            goto joined_r0x000180bed9f2;
          }
        LAB_180beda30:
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9fdc8);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fdc8)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) != 0) {
              lVar6 = MouseController.get_hoveredObject(0);
              if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fdc8)) == null) ||
                 (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180bede8c;
              if (*(int64 *)(*(int64 *)(lVar6 + 24) + 0x208) != 0) {
                lVar6 = MouseController.get_hoveredObject(0);
                *plVar1 = lVar6;
                il2cpp_internal(plVar1,lVar6);
                QuickDetail.SetAllDisactive(this,0);
                uVar5 = this.horseDetail;
                lVar6 = MouseController.get_hoveredObject(0);
                if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9fdc8)) == null)
                   || (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180bede8c;
                QuickDetail.ShowHorseQuickDetail
                          (this,uVar5,*(uint64 *)(*(int64 *)(lVar6 + 24) + 0x208),0,0,0);
                this.describePosDirty = 1;
                goto LAB_180beddb8;
              }
            }
          }
          lVar6 = MouseController.get_hoveredObject(0);
          if (lVar6 == null) goto LAB_180bede8c;
          uVar5 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = MouseController.get_hoveredObject(0);
            if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0)) == null)
            goto LAB_180bede8c;
            if (*(int64 *)(lVar6 + 24) != 0) {
              lVar6 = MouseController.get_hoveredObject(0);
              if (((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0)) == null) ||
                 (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180bede8c;
              if (*(char *)(*(int64 *)(lVar6 + 24) + 88) != false) {
                lVar6 = MouseController.get_hoveredObject(0);
                *plVar1 = lVar6;
                il2cpp_internal(plVar1,lVar6);
                QuickDetail.SetAllDisactive(this,0);
                uVar5 = this.exploreTileDetail;
                lVar6 = MouseController.get_hoveredObject(0);
                if ((lVar6 == null) || (lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0)) == null)
                goto LAB_180bede8c;
                QuickDetail.ShowExploreTileQuickDetail(this,uVar5,*(uint64 *)(lVar6 + 24),0);
                this.describePosDirty = 1;
                goto LAB_180beddb8;
              }
            }
          }
        LAB_180bedda1:
          QuickDetail.DisableDescribe(this,0);
          if (!this.describePosDirty) {
            return;
          }
        }
        LAB_180beddb8:
        lVar6 = *plVar1;
        cVar2 = Object.op_Inequality(lVar6,lVar3,0);
        if (cVar2) {
          lVar3 = *plVar1;
          cVar2 = Object.op_Inequality(lVar3,0,0);
          if (cVar2) {
            lVar3 = FUN_18046c100(0);
            if (lVar3 == null) {
        LAB_180bede8c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar5 = *(uint64 *)(lVar3 + 0x1f0);
            NGUITools.PlaySound(uVar5,0x3dcccccd,0);
          }
        }
    }

    // Token : 0x6001F71
    // RVA   : 0xBDF680   Offset: 0xBDDE80   Length: 0x171
    private List<ItemData> FindPlayerEquipment(int type)
    {
        ulong uVar1;
        long lVar2;
        if (type == null) {
          lVar2 = QuickDetail.GetTargetHero(this,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1f8) != 0)) {
            return *(uint64 *)(*(int64 *)(lVar2 + 0x1f8) + 32);
          }
        }
        else if (type == 1) {
          lVar2 = QuickDetail.GetTargetHero(this,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1f8) != 0)) {
            return *(uint64 *)(*(int64 *)(lVar2 + 0x1f8) + 56);
          }
        }
        else if (type == 2) {
          lVar2 = QuickDetail.GetTargetHero(this,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1f8) != 0)) {
            return *(uint64 *)(*(int64 *)(lVar2 + 0x1f8) + 80);
          }
        }
        else if (type == 3) {
          lVar2 = QuickDetail.GetTargetHero(this,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1f8) != 0)) {
            return *(uint64 *)(*(int64 *)(lVar2 + 0x1f8) + 104);
          }
        }
        else {
          if (type != 4) {
            uVar1 = il2cpp_internal(DAT_181d6f430);
            FUN_180f58a90(uVar1,DAT_181d691f0);
            return uVar1;
          }
          lVar2 = QuickDetail.GetTargetHero(this,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1f8) != 0)) {
            return *(uint64 *)(*(int64 *)(lVar2 + 0x1f8) + 128);
          }
        }
    }

    // Token : 0x6001F72
    // RVA   : 0xBDF950   Offset: 0xBDE150   Length: 0xA8
    private bool HavePlayerEquipment(int type)
    {
        ulong uVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        uVar1 = QuickDetail.FindPlayerEquipment(this,type,0);
        uVar3 = 0;
        if (uVar1 != 0) {
          lVar4 = 32;
          uVar2 = uVar1;
          while( true ) {
            if ((int)*(uint32 *)(uVar1 + 24) <= (int)uVar3) {
              return uVar2 & 0xffffffffffffff00;
            }
            if (*(uint32 *)(uVar1 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(uVar1 + 16);
            if (*(int64 *)(lVar4 + uVar2) != 0) break;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
          }
          return CONCAT71((int7)(uVar2 >> 8),1);
        }
    }

    // Token : 0x6001F73
    // RVA   : 0xBDFA00   Offset: 0xBDE200   Length: 0x45
    private bool HavePlayerHorse(int type)
    {
        long lVar1;
        if (type == null) {
          lVar1 = QuickDetail.GetTargetHero(this,0);
          if (lVar1 != null) {
            return *(int64 *)(lVar1 + 0x208) != 0;
          }
        }
        else {
          lVar1 = QuickDetail.GetTargetHero(this,0);
          if (lVar1 != null) {
            return *(int64 *)(lVar1 + 0x218) != 0;
          }
        }
    }

    // Token : 0x6001F74
    // RVA   : 0xBDF800   Offset: 0xBDE000   Length: 0x141
    public HeroData GetTargetHero()
    {
        var pStatics_0f00 = *(int64*)(DAT_181d50f00 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if ((*pStatics_0f00 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_0f00 + 32)) != null) {
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          if (!cVar2) {
            if ((*pStatics_df90 != 0) &&
               (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              uVar3 = WorldData.Player(lVar1,0);
              return uVar3;
            }
          }
          else {
            if (*pStatics_0f00 != 0) {
              return *(uint64 *)(*pStatics_0f00 + 96);
            }
          }
        }
    }

    // Token : 0x6001F75
    // RVA   : 0xBDFAC0   Offset: 0xBDE2C0   Length: 0x12CA
    private void RefreshPosition()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar6;
        float extraout_var;
        float *pfVar7;
        uint32 *puVar8;
        int64 lVar9;
        uint32 uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint32 uVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        uint64 local_108;
        uint32 local_100;
        uint64 local_f8;
        uint32 local_f0;
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint64 local_c8;
        uint64 uStack_c0;
        uint8 local_b8 [16];
        uint8 local_a8 [144];
        fVar15 = 0.0;
        local_c8 = 0;
        uStack_c0 = 0;
        if (this.nowShowObject == null) throw; // [null/range check failed]
        uVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181d9f7f0);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
        LAB_180bdfe09:
          if (this.nowShowObject == null) throw; // [null/range check failed]
          uVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181d9e910);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if ((this.nowShowObject == null) ||
               (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
            throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_position(&local_f8,lVar4,0);
            local_f8 = *puVar5;
            local_f0 = *(uint32 *)(puVar5 + 1);
            if ((float)((uint64)local_f8 >> 32) <= 0.0) {
              fVar15 = 1.0;
              goto LAB_180be0196;
            }
          }
          if (this.nowShowObject == null) throw; // [null/range check failed]
          uVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181d9fdc8);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if ((this.nowShowObject == null) ||
               (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
            throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_position(&local_f8,lVar4,0);
            local_f8 = *puVar5;
            local_f0 = *(uint32 *)(puVar5 + 1);
            if ((float)((uint64)local_f8 >> 32) <= 0.0) {
              fVar15 = 1.3;
              goto LAB_180be0196;
            }
          }
          if (this.nowShowObject == null) throw; // [null/range check failed]
          uVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181da0b98);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          lVar4 = this.nowShowObject;
          if (!cVar1) {
            if (lVar4 == null) throw; // [null/range check failed]
            uVar3 = GameObject.GetComponent(lVar4,DAT_181d9eaa8);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            lVar4 = this.nowShowObject;
            if (!cVar1) {
              if (lVar4 == null) throw; // [null/range check failed]
              uVar3 = GameObject.GetComponent(lVar4,DAT_181d9eb30);
              cVar1 = Object.op_Inequality(uVar3,0,0);
              lVar4 = this.nowShowObject;
              if (!cVar1) {
                if (lVar4 == null) throw; // [null/range check failed]
                uVar3 = GameObject.GetComponent(lVar4,DAT_181da1830);
                cVar1 = Object.op_Inequality(uVar3,0,0);
                if (cVar1) {
                  if ((this.nowShowObject == null) ||
                     (lVar4 = GameObject.GetComponent(this.nowShowObject,DAT_181da1830),
                     lVar4 == null)) throw; // [null/range check failed]
                  fVar15 = (float)SphereCollider.get_radius(lVar4,0);
                }
              }
              else {
                if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9eb30)) == null)
                throw; // [null/range check failed]
                BoxCollider2D.get_size(lVar4,0);
                fVar15 = extraout_var;
              }
            }
            else {
              if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9eaa8)) == null)
              throw; // [null/range check failed]
              puVar5 = (uint64 *)BoxCollider.get_size(&local_f8,lVar4,0);
              local_f8 = *puVar5;
              fVar15 = (float)((uint64)local_f8 >> 32);
              local_f0 = *(uint32 *)(puVar5 + 1);
            }
          }
          else {
            if ((lVar4 == null) || (lVar4 = GameObject.GetComponent(lVar4,DAT_181da0b98)) == null)
            throw; // [null/range check failed]
            puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
            local_c8 = *puVar5;
            uStack_c0 = puVar5[1];
            fVar15 = (float)FUN_18044e2b0(&local_c8,0);
          }
        }
        else {
          if (((this.nowShowObject == null) ||
              (lVar4 = GameObject.GetComponent(this.nowShowObject,DAT_181d9f7f0)) == null)
             || (lVar4.Count == null)) throw; // [null/range check failed]
          uVar3 = *(uint64 *)(lVar4.Count + 24);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) goto LAB_180bdfe09;
          if ((this.nowShowObject == null) ||
             (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(&local_f8,lVar4,0);
          local_f8 = *puVar5;
          local_f0 = *(uint32 *)(puVar5 + 1);
          if (0.0 < (float)((uint64)local_f8 >> 32)) goto LAB_180bdfe09;
          fVar15 = 3.0;
          if ((((this.nowShowObject == null) ||
               (lVar4 = GameObject.GetComponent(this.nowShowObject,DAT_181d9f7f0)) == null
               ) || (lVar4.Count == null)) ||
             ((lVar4 = *(int64 *)(lVar4.Count + 24), lVar4 == null ||
              (lVar4 = *(int64 *)(lVar4 + 64)) == null))) throw; // [null/range check failed]
          if (lVar4._items) {
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d6ece0 + 184) + 8);
            if ((((this.nowShowObject == null) ||
                 (lVar6 = GameObject.GetComponent(this.nowShowObject,DAT_181d9f7f0),
                 lVar6 == null)) || (*(int64 *)(lVar6 + 24) == 0)) ||
               (((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 24), lVar6 == null ||
                 (lVar6 = *(int64 *)(lVar6 + 64)) == null) || (lVar4 == null)))) throw; // [null/range check failed]
            fVar15 = (float)FUN_1800d6780(lVar4,*(uint32 *)(lVar6 + 20),DAT_181d796d8);
            fVar15 = fVar15 + 3.0;
          }
        }
        LAB_180be0196:
        if ((this.Back != null) &&
           (lVar4 = GameObject.GetComponent(this.Back,DAT_181da0b98)) != null) {
          puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
          local_c8 = *puVar5;
          uStack_c0 = puVar5[1];
          fVar11 = (float)FUN_18044e2b0(&local_c8,0);
          lVar4 = Component.get_transform(this,0);
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_lossyScale(&local_f8,lVar4,0);
            local_108 = *puVar5;
            local_100 = *(uint32 *)(puVar5 + 1);
            if ((this.nowShowObject != null) &&
               (lVar4 = GameObject.get_transform(this.nowShowObject,0)) != null) {
              puVar5 = (uint64 *)Transform.get_lossyScale(&local_f8,lVar4,0);
              fVar17 = 0.5;
              local_f8 = *puVar5;
              local_f0 = *(uint32 *)(puVar5 + 1);
              fVar15 = ((float)((uint64)local_f8 >> 32) * fVar15 + local_108._4_4_ * fVar11) * 0.5;
              if (!this.forceUp) {
                if ((this.nowShowObject == null) ||
                   (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
                throw; // [null/range check failed]
                puVar5 = (uint64 *)Transform.get_position(&local_f8,lVar4,0);
                local_f8 = *puVar5;
                local_f0 = *(uint32 *)(puVar5 + 1);
                if (0.0 < (float)((uint64)local_f8 >> 32)) {
                  fVar15 = -fVar15;
                }
              }
              if ((this.canvasRoot != null) &&
                 (lVar4 = GameObject.GetComponent(this.canvasRoot,DAT_181da0b98),
                 lVar4 != null)) {
                puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
                local_c8 = *puVar5;
                uStack_c0 = puVar5[1];
                fVar11 = (float)FUN_180d90480(&local_c8,0);
                if ((this.canvasRoot != null) &&
                   (lVar4 = GameObject.GetComponent(this.canvasRoot,DAT_181da0b98),
                   lVar4 != null)) {
                  pfVar7 = (float *)Transform.get_lossyScale(&local_f8,lVar4,0);
                  fVar16 = *pfVar7;
                  if ((this.Back != null) &&
                     (lVar4 = GameObject.GetComponent(this.Back,DAT_181da0b98),
                     lVar4 != null)) {
                    puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
                    local_c8 = *puVar5;
                    uStack_c0 = puVar5[1];
                    fVar12 = (float)FUN_180d90480(&local_c8,0);
                    lVar4 = Component.get_transform(this,0);
                    if (lVar4 != null) {
                      pfVar7 = (float *)Transform.get_lossyScale(&local_f8,lVar4,0);
                      fVar11 = (fVar16 * fVar11 - fVar12 * *pfVar7) * 0.5;
                      fVar16 = -fVar11;
                      if ((this.describeGrid != null) &&
                         (lVar4 = GameObject.get_transform(this.describeGrid,0)) != null)
                      {
                        iVar2 = Transform.get_childCount(lVar4,0);
                        if (0 < iVar2) {
                          if ((((this.describeGrid == null) ||
                               (lVar4 = GameObject.get_transform(this.describeGrid,0),
                               lVar4 == null)) || (lVar4 = Transform.GetChild(lVar4,0,0)) == null) ||
                             (lVar4 = Component.GetComponent(lVar4,DAT_181d6c740)) == null)
                          throw; // [null/range check failed]
                          puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
                          local_c8 = *puVar5;
                          uStack_c0 = puVar5[1];
                          fVar12 = (float)FUN_180d90480(&local_c8,0);
                          lVar4 = Component.get_transform(this,0);
                          if (lVar4 == null) throw; // [null/range check failed]
                          pfVar7 = (float *)Transform.get_lossyScale(&local_f8,lVar4,0);
                          fVar11 = fVar11 - fVar12 * *pfVar7;
                        }
                        if (this.skillRangeUI != null) {
                          cVar1 = GameObject.get_activeSelf(this.skillRangeUI,0);
                          if (cVar1) {
                            if (((this.skillRangeUI == null) ||
                                (lVar4 = GameObject.get_transform(this.skillRangeUI,0),
                                lVar4 == null)) ||
                               ((lVar4 = Transform.GetChild(lVar4,0,0), lVar4 == null ||
                                (lVar4 = Component.GetComponent(lVar4,DAT_181d6c740)) == null)))
                            throw; // [null/range check failed]
                            puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
                            local_c8 = *puVar5;
                            uStack_c0 = puVar5[1];
                            fVar12 = (float)FUN_180d90480(&local_c8,0);
                            lVar4 = Component.get_transform(this,0);
                            if (lVar4 == null) throw; // [null/range check failed]
                            pfVar7 = (float *)Transform.get_lossyScale(&local_f8,lVar4,0);
                            fVar16 = fVar16 + fVar12 * *pfVar7;
                          }
                          if ((this.canvasRoot != null) &&
                             (lVar4 = GameObject.GetComponent
                                                (this.canvasRoot,DAT_181da0b98), lVar4 != null)
                             ) {
                            puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
                            local_c8 = *puVar5;
                            uStack_c0 = puVar5[1];
                            fVar12 = (float)FUN_18044e2b0(&local_c8,0);
                            if ((this.canvasRoot != null) &&
                               (lVar4 = GameObject.GetComponent
                                                  (this.canvasRoot,DAT_181da0b98),
                               lVar4 != null)) {
                              puVar5 = (uint64 *)Transform.get_lossyScale(&local_f8,lVar4,0);
                              local_108 = *puVar5;
                              local_100 = *(uint32 *)(puVar5 + 1);
                              if ((this.Back != null) &&
                                 (lVar4 = GameObject.GetComponent
                                                    (this.Back,DAT_181da0b98),
                                 lVar4 != null)) {
                                puVar5 = (uint64 *)RectTransform.get_rect(local_d8,lVar4,0);
                                local_c8 = *puVar5;
                                uStack_c0 = puVar5[1];
                                fVar13 = (float)FUN_18044e2b0(&local_c8,0);
                                lVar4 = Component.get_transform(this,0);
                                if (lVar4 != null) {
                                  puVar5 = (uint64 *)Transform.get_lossyScale(&local_f8,lVar4,0);
                                  local_f8 = *puVar5;
                                  local_f0 = *(uint32 *)(puVar5 + 1);
                                  fVar12 = (local_108._4_4_ * fVar12 -
                                           (float)((uint64)local_f8 >> 32) * fVar13) * 0.5;
                                  lVar4 = Component.get_transform(this,0);
                                  if ((this.nowShowObject != null) &&
                                     (lVar6 = GameObject.get_transform(this.nowShowObject,0),
                                     lVar6 != null)) {
                                    pfVar7 = (float *)Transform.get_position(&local_f8,lVar6,0);
                                    uVar14 = FUN_1810a8ba0(*pfVar7 + 0.0,CONCAT44(0x80000000,fVar16),
                                                           fVar11,0);
                                    if ((this.nowShowObject != null) &&
                                       (lVar6 = GameObject.get_transform(this.nowShowObject,0)
                                       , lVar6 != null)) {
                                      puVar5 = (uint64 *)Transform.get_position(&local_f8,lVar6,0);
                                      local_108 = CONCAT44(local_108._4_4_,uVar14);
                                      local_f8 = *puVar5;
                                      local_f0 = *(uint32 *)(puVar5 + 1);
                                      uVar14 = FUN_1810a8ba0((float)((uint64)local_f8 >> 32) + fVar15
                                                             ,CONCAT44(0x80000000,-fVar12),fVar12,0);
                                      local_108 = CONCAT44(uVar14,(uint32)local_108);
                                      local_100 = 0;
                                      if (lVar4 != null) {
                                        local_f8 = local_108;
                                        local_f0 = 0;
                                        Transform.set_position(lVar4,&local_f8,0);
                                        if (this.describeGrid != null) {
                                          lVar4 = GameObject.get_transform
                                                            (this.describeGrid,0);
                                          if ((this.describeGrid != null) &&
                                             (lVar6 = GameObject.get_transform
                                                                (this.describeGrid,0),
                                             lVar6 != null)) {
                                            puVar8 = (uint32 *)
                                                     Transform.get_localPosition(&local_f8,lVar6,0);
                                            uVar14 = *puVar8;
                                            if ((this.Back != null) &&
                                               (lVar6 = GameObject.GetComponent
                                                                  (this.Back,
                                                                   DAT_181da0b98), lVar6 != null)) {
                                              puVar5 = (uint64 *)
                                                       RectTransform.get_rect(local_d8,lVar6,0);
                                              local_c8 = *puVar5;
                                              uStack_c0 = puVar5[1];
                                              fVar15 = (float)FUN_18044e2b0(&local_c8,0);
                                              if (lVar4 != null) {
                                                local_108 = CONCAT44(fVar15 * 0.5,uVar14);
                                                local_100 = 0;
                                                Transform.set_localPosition(lVar4,&local_108,0);
                                                if (this.skillRangeUI != null) {
                                                  lVar4 = GameObject.get_transform
                                                                    (this.skillRangeUI,0);
                                                  if ((this.skillRangeUI != null) &&
                                                     (lVar6 = GameObject.get_transform
                                                                        (this.skillRangeUI,0),
                                                     lVar6 != null)) {
                                                    puVar8 = (uint32 *)
                                                             Transform.get_localPosition
                                                                       (&local_f8,lVar6,0);
                                                    uVar14 = *puVar8;
                                                    if ((this.Back != null) &&
                                                       (lVar6 = GameObject.GetComponent
                                                                          (this.Back,
                                                                           DAT_181da0b98), lVar6 != null)) {
                                                      puVar5 = (uint64 *)
                                                               RectTransform.get_rect(local_d8,lVar6,0);
                                                      local_c8 = *puVar5;
                                                      uStack_c0 = puVar5[1];
                                                      fVar15 = (float)FUN_18044e2b0(&local_c8,0);
                                                      if (lVar4 != null) {
                                                        local_108 = CONCAT44(fVar15 * 0.5,uVar14);
                                                        local_100 = 0;
                                                        Transform.set_localPosition(lVar4,&local_108,0);
                                                        lVar4 = this.equipDetailCompare;
                                                        uVar10 = 0;
                                                        if (lVar4 != null) {
                                                          lVar6 = 32;
                                                          while ((int)uVar10 < lVar4.Count) {
                                                            if (lVar4 == null) throw; // [null/range check failed]
                                                            if (lVar4.Count <= uVar10) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        lVar4 = *(int64 *)
                                                                 (lVar6 + lVar4._items);
                                                        if (lVar4 == null) throw; // [null/range check failed]
                                                        cVar1 = GameObject.get_activeSelf(lVar4,0);
                                                        if (cVar1) {
                                                          if ((this.Back == null) ||
                                                             (lVar4 = GameObject.GetComponent
                                                                                (*(int64 *)
                                                                                  (this + 24),
                                                                                 DAT_181da0b98),
                                                             lVar4 == null)) throw; // [null/range check failed]
                                                          puVar5 = (uint64 *)
                                                                   RectTransform.get_rect
                                                                             (local_b8,lVar4,0);
                                                          local_c8 = *puVar5;
                                                          uStack_c0 = puVar5[1];
                                                          fVar15 = (float)FUN_18044e2b0(&local_c8,0);
                                                          if ((this.equipDetailCompare == null) ||
                                                             ((((lVar4 = FUN_180002f80(*(int64 *)
                                                                                        (this + 40),
                                                                                       uVar10,
                                                        DAT_181d62178), lVar4 == null ||
                                                        (lVar4 = GameObject.get_transform(lVar4,0),
                                                        lVar4 == null)) ||
                                                        (lVar4 = Transform.Find(lVar4,"Back",0),
                                                        lVar4 == null)) ||
                                                        (lVar4 = Component.GetComponent
                                                                           (lVar4,DAT_181d6c740),
                                                        lVar4 == null)))) throw; // [null/range check failed]
                                                        puVar5 = (uint64 *)
                                                                 RectTransform.get_rect(local_a8,lVar4,0)
                                                        ;
                                                        local_c8 = *puVar5;
                                                        uStack_c0 = puVar5[1];
                                                        fVar11 = (float)FUN_18044e2b0(&local_c8,0);
                                                        if ((this.equipDetailCompare == null) ||
                                                           (lVar4 = FUN_180002f80(*(int64 *)
                                                                                   (this + 40),uVar10
                                                                                  ,DAT_181d62178),
                                                           lVar4 == null)) throw; // [null/range check failed]
                                                        lVar4 = GameObject.get_transform(lVar4,0);
                                                        if ((this.equipDetailCompare == null) ||
                                                           ((lVar9 = FUN_180002f80(*(int64 *)
                                                                                    (this + 40),
                                                                                   uVar10), lVar9 == null ||
                                                            (lVar9 = GameObject.get_transform(lVar9,0),
                                                            lVar9 == null)))) throw; // [null/range check failed]
                                                        puVar8 = (uint32 *)
                                                                 Transform.get_localPosition
                                                                           (local_e8,lVar9);
                                                        uVar14 = *puVar8;
                                                        if ((this.nowShowObject == null) ||
                                                           (lVar9 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 184),0),
                                                           lVar9 == null)) throw; // [null/range check failed]
                                                        lVar9 = Transform.get_position(local_d8,lVar9);
                                                        if (*(float *)(lVar9 + 4) <= 0.0) {
                                                          fVar16 = -0.5;
                                                        }
                                                        else {
                                                          fVar16 = 0.5;
                                                        }
                                                        if (lVar4 == null) throw; // [null/range check failed]
                                                        local_108 = CONCAT44(fVar16 * (fVar15 - fVar11),
                                                                             uVar14);
                                                        local_100 = 0;
                                                        Transform.set_localPosition(lVar4);
                                                        }
                                                        lVar4 = this.equipDetailCompare;
                                                        uVar10 = uVar10 + 1;
                                                        lVar6 = lVar6 + 8;
                                                        if (lVar4 == null) throw; // [null/range check failed]
                                                        }
                                                        if (this.horseDetailCompare != null) {
                                                          cVar1 = GameObject.get_activeSelf
                                                                            (this.horseDetailCompare
                                                                             ,0);
                                                          if (!cVar1) {
                                                            return;
                                                          }
                                                          if ((this.Back != null) &&
                                                             (lVar4 = GameObject.GetComponent
                                                                                (*(int64 *)
                                                                                  (this + 24),
                                                                                 DAT_181da0b98),
                                                             lVar4 != null)) {
                                                            puVar5 = (uint64 *)
                                                                     RectTransform.get_rect
                                                                               (local_a8,lVar4,0);
                                                            local_c8 = *puVar5;
                                                            uStack_c0 = puVar5[1];
                                                            fVar15 = (float)FUN_18044e2b0(&local_c8,0);
                                                            if ((this.horseDetailCompare != null) &&
                                                               (((lVar4 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 88),0),
                                                                 lVar4 != null &&
                                                                 (lVar4 = Transform.Find(lVar4,
                                                        "Back",0), lVar4 != null)) &&
                                                        (lVar4 = Component.GetComponent
                                                                           (lVar4,DAT_181d6c740),
                                                        lVar4 != null)))) {
                                                          puVar5 = (uint64 *)
                                                                   RectTransform.get_rect
                                                                             (local_a8,lVar4,0);
                                                          local_c8 = *puVar5;
                                                          uStack_c0 = puVar5[1];
                                                          fVar11 = (float)FUN_18044e2b0(&local_c8,0);
                                                          if (this.horseDetailCompare != null) {
                                                            lVar4 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 88),0);
                                                            if ((this.horseDetailCompare != null) &&
                                                               (lVar6 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 88),0),
                                                               lVar6 != null)) {
                                                              puVar8 = (uint32 *)
                                                                       Transform.get_localPosition
                                                                                 (local_d8,lVar6,0);
                                                              uVar14 = *puVar8;
                                                              if ((this.nowShowObject != null) &&
                                                                 (lVar6 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 184),0),
                                                                 lVar6 != null)) {
                                                                lVar6 = Transform.get_position
                                                                                  (local_d8,lVar6,0);
                                                                if (*(float *)(lVar6 + 4) <= 0.0) {
                                                                  fVar17 = -0.5;
                                                                }
                                                                if (lVar4 != null) {
                                                                  local_108 = CONCAT44(fVar17 * (fVar15 - 
                                                        fVar11),uVar14);
                                                        local_100 = 0;
                                                        Transform.set_localPosition(lVar4,&local_108,0);
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

    // Token : 0x6001F76
    // RVA   : 0xBE0F70   Offset: 0xBDF770   Length: 0x28F
    public void SetAllDisactive()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        this.forceUp = 0;
        if (this.equipDetail != null) {
          GameObject.SetActive(this.equipDetail,0,0);
          if (this.medfoodDetail != null) {
            GameObject.SetActive(this.medfoodDetail,0,0);
            if (this.bookDetail != null) {
              GameObject.SetActive(this.bookDetail,0,0);
              if (this.treasureDetail != null) {
                GameObject.SetActive(this.treasureDetail,0,0);
                if (this.materialDetail != null) {
                  GameObject.SetActive(this.materialDetail,0,0);
                  if (this.horseDetail != null) {
                    GameObject.SetActive(this.horseDetail,0,0);
                    if (this.skillDetail != null) {
                      GameObject.SetActive(this.skillDetail,0,0);
                      if (this.heroDetail != null) {
                        GameObject.SetActive(this.heroDetail,0,0);
                        if (this.obstacleDetail != null) {
                          GameObject.SetActive(this.obstacleDetail,0,0);
                          if (this.areaDetail != null) {
                            GameObject.SetActive(this.areaDetail,0,0);
                            if (this.resourcePointDetail != null) {
                              GameObject.SetActive(this.resourcePointDetail,0,0);
                              if (this.eventDetail != null) {
                                GameObject.SetActive(this.eventDetail,0,0);
                                if (this.missionDetail != null) {
                                  GameObject.SetActive(this.missionDetail,0,0);
                                  if (this.exploreTileDetail != null) {
                                    GameObject.SetActive(this.exploreTileDetail,0,0);
                                    if (this.tagDetail != null) {
                                      GameObject.SetActive(this.tagDetail,0,0);
                                      lVar2 = this.equipDetailCompare;
                                      uVar3 = 0;
                                      if (lVar2 != null) {
                                        lVar4 = 32;
                                        do {
                                          if (lVar2.Count <= (int)uVar3) {
                                            if (this.horseDetailCompare != null) {
                                              GameObject.SetActive(this.horseDetailCompare,0,0);
                                              uVar1 = this.describeGrid;
                                              GlobalData.DeleteAllChild(uVar1,0);
                                              if (this.skillRangeUI != null) {
                                                GameObject.SetActive(this.skillRangeUI,0,0);
                                                return;
                                              }
                                            }
                                            break;
                                          }
                                          if (lVar2 == null) break;
                                          if (lVar2.Count <= uVar3) {
                                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          }
                                          lVar2 = *(int64 *)(lVar4 + lVar2._items);
                                          if (lVar2 == null) break;
                                          GameObject.SetActive(lVar2,0,0);
                                          lVar2 = this.equipDetailCompare;
                                          uVar3 = uVar3 + 1;
                                          lVar4 = lVar4 + 8;
                                        } while (lVar2 != null);
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

    // Token : 0x6001F77
    // RVA   : 0xBE51C0   Offset: 0xBE39C0   Length: 0x28C
    public void ShowEventQuickDetail(GameObject target, EventData eventData)
    {
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar3 = GameObject.get_transform(target,0);
          if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
            lVar3 = Component.get_gameObject(lVar3,0);
            this.Back = lVar3;
            if ((*plVar1 != 0) &&
               (((lVar3 = GameObject.get_transform(*plVar1,0), lVar3 != null &&
                 (lVar3 = Transform.Find(lVar3,"Text",0)) != null) &&
                (uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0), eventData != null)))) {
              uVar5 = String.Concat("<size=17>",*(uint64 *)(eventData + 24),"</size>",0);
              LTLocalization.SetText(uVar4,uVar5,0);
              if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                uVar2 = *(uint32 *)(eventData + 108);
                uVar5 = GlobalData.GetDifficultyStarString(uVar2,0);
                uVar5 = String.Concat("\n",uVar5,0);
                LTLocalization.AddText(uVar4,uVar5,0);
                if (*(int *)(eventData + 104) < 1) {
                  return;
                }
                if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                  uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                  uVar5 = Int32.ToString(eventData + 104,0);
                  uVar5 = String.Concat("\n",uVar5,"天",0);
                  LTLocalization.AddText(uVar4,uVar5,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F78
    // RVA   : 0xBE87C0   Offset: 0xBE6FC0   Length: 0x295
    public void ShowMissionQuickDetail(GameObject target, MissionData missionData)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar4 = GameObject.get_transform(target,0);
          if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Back",0)) != null) {
            uVar5 = Component.get_gameObject(lVar4,0);
            this.Back = uVar5;
            if ((this.Back != null) &&
               (((lVar4 = GameObject.get_transform(this.Back,0), lVar4 != null &&
                 (lVar4 = Transform.Find(lVar4,"Text",0)) != null) &&
                (uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0), missionData != null)))) {
              iVar2 = *(int *)(missionData + 76);
              uVar7 = "";
              if (iVar2 < 0) {
        LAB_180be8a06:
                uVar6 = MissionData.GetMissionDescribe(missionData,0);
                uVar7 = String.Concat(uVar7,uVar6,0);
                LTLocalization.SetText(uVar5,uVar7,0);
                return;
              }
              lVar4 = *(int64 *)(pStatics + 0x458);
              if (lVar4 != null) {
                uVar7 = "";
                if (*(int *)(lVar4 + 24) <= iVar2) goto LAB_180be8a06;
                lVar4 = *(int64 *)(pStatics + 0x458);
                if (lVar4 != null) {
                  uVar3 = *(uint32 *)(missionData + 76);
                  if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar7 = lVar4[uVar3];
                  lVar4 = *(int64 *)(pStatics + 0x460);
                  if (lVar4 != null) {
                    if (*(uint32 *)(lVar4 + 24) <= *(uint32 *)(missionData + 76)) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    puVar1 = (uint32 *)(lVar4 + ((int64)(int)*(uint32 *)(missionData + 76) + 2) * 16)
                    ;
                    local_18 = *puVar1;
                    uStack_14 = puVar1[1];
                    uStack_10 = puVar1[2];
                    uStack_c = puVar1[3];
                    uVar6 = ColorUtility.ToHtmlStringRGB(&local_18,0);
                    uVar7 = String.Format("<color=#{1}><b>[{0}任务]</b></color>\n",uVar7,uVar6,0);
                    goto LAB_180be8a06;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F79
    // RVA   : 0xBE99B0   Offset: 0xBE81B0   Length: 0x320
    public void ShowTagQuickDetail(GameObject target, HeroTagIconController tagIconController)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        float fVar5;
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar1 = GameObject.get_transform(target,0);
          if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Back",0)) != null) {
            uVar2 = Component.get_gameObject(lVar1,0);
            this.Back = uVar2;
            if ((this.Back != null) &&
               (((lVar1 = GameObject.get_transform(this.Back,0), lVar1 != null &&
                 (lVar1 = Transform.Find(lVar1,"Text",0)) != null) &&
                (uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0), tagIconController != null)))) {
              uVar3 = HeroTagIconController.GetDescribe(tagIconController,0);
              LTLocalization.SetText(uVar2,uVar3,0);
              iVar4 = 0;
              while( true ) {
                lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 144)) == null) break;
                if (*(int *)(lVar1 + 24) <= iVar4) {
                  return;
                }
                lVar1 = FUN_18046c100(0);
                if (((lVar1 == null) || (*(int64 *)(lVar1 + 144) == 0)) ||
                   (lVar1 = FUN_180002f80(*(int64 *)(lVar1 + 144),iVar4,DAT_181d64878)) == null)
                break;
                if (*(char *)(lVar1 + 89) != false) {
                  if ((*(int64 *)(tagIconController + 32) == 0) ||
                     (lVar1 = HeroTagData.DataBase(*(int64 *)(tagIconController + 32),0)) == null) break;
                  if (*(int64 *)(lVar1 + 88) != 0) {
                    if (((*(int64 *)(tagIconController + 32) == 0) ||
                        (lVar1 = HeroTagData.DataBase(*(int64 *)(tagIconController + 32),0)) == null) ||
                       (*(int64 *)(lVar1 + 88) == 0)) break;
                    fVar5 = (float)HeroSpeAddData.Get(*(int64 *)(lVar1 + 88),iVar4,0);
                    if (fVar5 != 0.0) {
                      lVar1 = FUN_18046c100(0);
                      if (((lVar1 == null) || (*(int64 *)(lVar1 + 144) == 0)) ||
                         (lVar1 = FUN_180002f80(*(int64 *)(lVar1 + 144),iVar4,DAT_181d64878),
                         lVar1 == null)) break;
                      uVar2 = HeroSpeAddDataBase.GetDescribe(lVar1,0);
                      QuickDetail.AddDescribeTab(this,uVar2,0);
                    }
                  }
                }
                iVar4 = iVar4 + 1;
              }
            }
          }
        }
    }

    // Token : 0x6001F7A
    // RVA   : 0xBE8A60   Offset: 0xBE7260   Length: 0x67F
    public void ShowResourcePointQuickDetail(GameObject target, ResourcePointData resourcePointData)
    {
        int iVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        float[] local_res10 = new float[2];
        ulong uVar10;
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar4 = GameObject.get_transform(target,0);
          if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Back",0)) != null) {
            lVar4 = Component.get_gameObject(lVar4,0);
            this.Back = lVar4;
            uVar9 = "<size=18>";
            uVar8 = "</size>";
            if (resourcePointData != null) {
              uVar3 = *(uint64 *)(resourcePointData + 32);
              uVar5 = "";
              if (*(int *)(resourcePointData + 56) != -1) {
                lVar4 = ResourcePointData.GetForce(resourcePointData,0);
                if (lVar4 == null) throw; // [null/range check failed]
                uVar5 = String.Concat("\n势力 ",*(uint64 *)(lVar4 + 24),0);
              }
              lVar4 = String.Concat(uVar9,uVar3,uVar8,uVar5,0);
              plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,9);
              if (plVar6 != (int64 *)0) {
                if ((lVar4 != null) &&
                   (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if ((int)plVar6[3] == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[4] = lVar4;
                il2cpp_internal(plVar6 + 4,lVar4);
                if (("\n\n每月产出\n" != 0) &&
                   (lVar4 = il2cpp_internal("\n\n每月产出\n",*(uint64 *)(*plVar6 + 64)), lVar4 == null
                   )) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar4 = "\n\n每月产出\n";
                if (*(uint32 *)(plVar6 + 3) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[5] = "\n\n每月产出\n";
                il2cpp_internal(plVar6 + 5,lVar4);
                uVar8 = ResourcePointData.GetTotalChangeResource(resourcePointData,0);
                uVar10 = 0;
                lVar4 = GlobalData.GetResourceDescribe(uVar8,1,1,1,0);
                if ((lVar4 != null) &&
                   (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(plVar6 + 3) < 3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[6] = lVar4;
                il2cpp_internal(plVar6 + 6,lVar4);
                if (("\n\n生产效率\n" != 0) &&
                   (lVar4 = il2cpp_internal("\n\n生产效率\n",*(uint64 *)(*plVar6 + 64)), lVar4 == null
                   )) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar4 = "\n\n生产效率\n";
                if (*(uint32 *)(plVar6 + 3) < 4) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[7] = "\n\n生产效率\n";
                il2cpp_internal(plVar6 + 7,lVar4);
                local_res10[0] = (float)ResourcePointData.GetProduceRate(resourcePointData,0);
                local_res10[0] = local_res10[0] * 100.0;
                lVar4 = Single.ToString(local_res10,0);
                if ((lVar4 != null) &&
                   (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(plVar6 + 3) < 5) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[8] = lVar4;
                il2cpp_internal(plVar6 + 8,lVar4);
                if (("%\n\n特殊效果\n" != 0) &&
                   (lVar4 = il2cpp_internal("%\n\n特殊效果\n",*(uint64 *)(*plVar6 + 64)), lVar4 == null
                   )) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar4 = "%\n\n特殊效果\n";
                if (*(uint32 *)(plVar6 + 3) < 6) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar6[9] = "%\n\n特殊效果\n";
                il2cpp_internal(plVar6 + 9,lVar4);
                if (*(int64 *)(resourcePointData + 72) != 0) {
                  lVar4 = ForceSpeAddData.GetDescribe(*(int64 *)(resourcePointData + 72),0);
                  if ((lVar4 != null) &&
                     (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar6 + 3) < 7) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar6[10] = lVar4;
                  il2cpp_internal(plVar6 + 10,lVar4);
                  iVar2 = *(int *)(resourcePointData + 56);
                  lVar4 = ResourcePointData.GetArea(resourcePointData,0);
                  if (lVar4 != null) {
                    uVar8 = "";
                    if (iVar2 != *(int *)(lVar4 + 112)) {
                      uVar8 = "(无效)";
                    }
                    lVar4 = String.Format("\n守城效果{0}\n",uVar8,0);
                    if ((lVar4 != null) &&
                       (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(plVar6 + 3) < 8) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    plVar6[11] = lVar4;
                    il2cpp_internal(plVar6 + 11,lVar4);
                    lVar7 = ResourcePointData.GetDefenceSpeAddData(resourcePointData,0);
                    lVar4 = "无";
                    if (lVar7 != null) {
                      lVar4 = ResourcePointData.GetDefenceSpeAddData(resourcePointData,0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = HeroSpeAddData.GetDescribe(lVar4,1,1,1,uVar10 & 0xffffffffffffff00,0);
                    }
                    if ((lVar4 != null) &&
                       (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(plVar6 + 3) < 9) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    plVar6[12] = lVar4;
                    il2cpp_internal(plVar6 + 12,lVar4);
                    uVar8 = String.Concat(plVar6,0);
                    if (((*plVar1 != 0) && (lVar4 = GameObject.get_transform(*plVar1,0)) != null) &&
                       (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                      uVar9 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar9,uVar8,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F7B
    // RVA   : 0xBE1200   Offset: 0xBDFA00   Length: 0x1F65
    public void ShowAreaQuickDetail(GameObject target, AreaData areaData)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        byte uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar10;
        ulong uVar11;
        ulong uVar12;
        ulong uVar13;
        ulong uVar14;
        int iVar15;
        uint uVar16;
        float fVar17;
        uint uVar18;
        uint uVar19;
        uint uVar20;
        uint uVar21;
        uint[] local_res10 = new uint[2];
        uint local_88;
        int[] local_84 = new int[3];
        ulong local_78;
        uint uStack_70;
        uint32 uStack_6c;
        int64 local_68;
        uint8 local_60 [40];
        local_84[0] = 0;
        local_res10[0] = 0;
        local_88 = 0;
        if (target == null) goto LAB_180be2dfa;
        GameObject.SetActive(target,1,0);
        lVar3 = GameObject.get_transform(target,0);
        if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Back",0)) == null)
        goto LAB_180be2dfa;
        uVar4 = Component.get_gameObject(lVar3,0);
        this.Back = uVar4;
        plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
        if (plVar5 == (int64 *)0) goto LAB_180be2dfa;
        if (("<size=18>" != 0) &&
           (lVar3 = il2cpp_internal("<size=18>",*(uint64 *)(*plVar5 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar3 = "<size=18>";
        if ((int)plVar5[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar5[4] = "<size=18>";
        il2cpp_internal(plVar5 + 4,lVar3);
        lVar3 = *(int64 *)(pStatics_ef00 + 0x420);
        if ((areaData == null) || (lVar3 == null)) goto LAB_180be2dfa;
        uVar16 = *(uint32 *)(areaData + 72);
        if (*(uint32 *)(lVar3 + 24) <= uVar16) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar3 = lVar3[uVar16];
        if ((lVar3 != null) &&
           (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        if (*(uint32 *)(plVar5 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar5[5] = lVar3;
        il2cpp_internal(plVar5 + 5,lVar3);
        if ((" " != 0) &&
           (lVar3 = il2cpp_internal(" ",*(uint64 *)(*plVar5 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar3 = " ";
        if (*(uint32 *)(plVar5 + 3) < 3) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar5[6] = " ";
        il2cpp_internal(plVar5 + 6,lVar3);
        lVar3 = *(int64 *)(areaData + 24);
        if ((lVar3 != null) &&
           (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        if (*(uint32 *)(plVar5 + 3) < 4) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar5[7] = lVar3;
        il2cpp_internal(plVar5 + 7,lVar3);
        if (("</size>" != 0) &&
           (lVar3 = il2cpp_internal("</size>",*(uint64 *)(*plVar5 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar3 = "</size>";
        if (*(uint32 *)(plVar5 + 3) < 5) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar5[8] = "</size>";
        il2cpp_internal(plVar5 + 8,lVar3);
        lVar3 = String.Concat(plVar5,0);
        uVar4 = " [{0}]";
        if (*(int *)(areaData + 72) == 2) {
        LAB_180be1719:
          if (((*pStatics_df90 == 0) ||
              (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar6 = WorldData.Player(lVar6,0)) == null) goto LAB_180be2dfa;
          if (-1 < *(int *)(lVar6 + 132)) {
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180be2dfa;
            if (*(int *)(lVar6 + 132) != *(int *)(areaData + 112)) {
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                  (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                 (lVar6 = HeroData.GetForce(lVar6,0,0)) == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar17 = (float)ForceData.GetForceFavor(lVar6,*(uint32 *)(areaData + 112),0);
              local_78 = CONCAT44(local_78._4_4_,(int)fVar17);
              uVar4 = il2cpp_value_box(DAT_181d5b2f8,&local_78);
              uVar4 = String.Format(" ♥{0}",uVar4,0);
              lVar3 = String.Concat(lVar3,uVar4,0);
            }
          }
        }
        else {
          uVar8 = "无";
          if (*(int *)(areaData + 112) != -1) {
            lVar6 = AreaData.GetForce(areaData,0);
            if (lVar6 == null) goto LAB_180be2dfa;
            uVar8 = *(uint64 *)(lVar6 + 24);
          }
          uVar4 = String.Format(uVar4,uVar8,0);
          lVar3 = String.Concat(lVar3,uVar4,0);
          if (*(int *)(areaData + 72) == 2) goto LAB_180be1719;
        }
        if (((*pStatics_df90 == 0) ||
            (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar6 = WorldData.Player(lVar6,0)) == null) goto LAB_180be2dfa;
        if (-1 < *(int *)(lVar6 + 132)) {
          if ((((*pStatics_df90 == 0) ||
               (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar6 = WorldData.Player(lVar6,0)) == null) ||
             (lVar6 = HeroData.GetForce(lVar6,0,0)) == null) goto LAB_180be2dfa;
          lVar6 = ForceData.GetForceRelationshipText(lVar6,*(uint32 *)(areaData + 112),1,0);
          if (lVar6 != null) {
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
               ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 == null ||
                (lVar6 = HeroData.GetForce(lVar6,0,0)) == null))) goto LAB_180be2dfa;
            uVar4 = ForceData.GetForceRelationshipText(lVar6,*(uint32 *)(areaData + 112),1,0);
            uVar4 = String.Format("\n<b>{0}</b>",uVar4,0);
            lVar3 = String.Concat(lVar3,uVar4,0);
          }
        }
        lVar6 = AreaData.GetCenterBuilding(areaData,0);
        if (lVar6 != null) {
          lVar6 = AreaData.GetCenterBuilding(areaData,0);
          if (lVar6 == null) goto LAB_180be2dfa;
          uVar18 = *(uint32 *)(lVar6 + 20);
          uVar4 = GlobalData.GetNumText(uVar18,0);
          lVar3 = String.Concat(lVar3,"\n等级 ",uVar4,0);
        }
        lVar6 = 32;
        local_68 = 32;
        if (*(int *)(areaData + 72) == 2) {
          lVar7 = AreaData.GetForce(areaData,0);
          if (lVar7 == null) goto LAB_180be2dfa;
          lVar7 = ForceData.GetLeader(lVar7,0);
          uVar4 = "\n掌门 ";
          uVar8 = "无";
          if (lVar7 != null) {
            lVar7 = AreaData.GetForce(areaData,0);
            if ((lVar7 == null) || (lVar7 = ForceData.GetLeader(lVar7,0)) == null) goto LAB_180be2dfa;
            uVar8 = HeroData.HeroName(lVar7,0,0);
          }
          uVar4 = String.Concat(lVar3,uVar4,uVar8,0);
          lVar3 = AreaData.GetForce(areaData,0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 96) == 0)) goto LAB_180be2dfa;
          local_84[0] = *(int *)(*(int64 *)(lVar3 + 96) + 24);
          uVar8 = Int32.ToString(local_84,"f0",0);
          uVar4 = String.Concat(uVar4,"\n领地 ",uVar8,0);
          lVar3 = AreaData.GetForce(areaData,0);
          if (lVar3 == null) goto LAB_180be2dfa;
          uVar8 = Int32.ToString(lVar3 + 132,"f0",0);
          uVar4 = String.Concat(uVar4,"\n弟子 ",uVar8,0);
        }
        else {
          lVar7 = AreaData.DataBase();
          if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x108) == 0)) goto LAB_180be2dfa;
          if (0 < *(int *)(*(int64 *)(lVar7 + 0x108) + 24)) {
            lVar3 = String.Concat(lVar3,"\n特产",0);
            uVar16 = 0;
            while ((lVar7 = AreaData.DataBase(areaData,0), lVar7 != null &&
                   (*(int64 *)(lVar7 + 0x108) != 0))) {
              if (*(int *)(*(int64 *)(lVar7 + 0x108) + 24) <= (int)uVar16) goto LAB_180be1c12;
              lVar7 = AreaData.DataBase(areaData,0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x108) == 0)) break;
              if (*(uint32 *)(*(int64 *)(lVar7 + 0x108) + 24) <= uVar16) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = String.Concat(lVar3);
              uVar16 = uVar16 + 1;
            }
            goto LAB_180be2dfa;
          }
        LAB_180be1c12:
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,7);
          if (plVar5 == (int64 *)0) goto LAB_180be2dfa;
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if ((int)plVar5[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[4] = lVar3;
          il2cpp_internal(plVar5 + 4,lVar3);
          if (("\n人口 " != 0) &&
             (lVar3 = il2cpp_internal("\n人口 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "\n人口 ";
          if (*(uint32 *)(plVar5 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[5] = "\n人口 ";
          il2cpp_internal(plVar5 + 5,lVar3);
          lVar3 = Single.ToString(areaData + 80,"f0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 3) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[6] = lVar3;
          il2cpp_internal(plVar5 + 6,lVar3);
          if (("/" != 0) &&
             (lVar3 = il2cpp_internal("/",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "/";
          if (*(uint32 *)(plVar5 + 3) < 4) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[7] = "/";
          il2cpp_internal(plVar5 + 7,lVar3);
          lVar3 = Single.ToString(areaData + 76,"f0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[8] = lVar3;
          il2cpp_internal(plVar5 + 8,lVar3);
          if ((" " != 0) &&
             (lVar3 = il2cpp_internal(" ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = " ";
          if (*(uint32 *)(plVar5 + 3) < 6) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[9] = " ";
          il2cpp_internal(plVar5 + 9,lVar3);
          local_res10[0] = AreaData.GetChangeAreaState(areaData,3);
          lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 7) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[10] = lVar3;
          il2cpp_internal(plVar5 + 10,lVar3);
          lVar3 = String.Concat(plVar5,0);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (plVar5 == (int64 *)0) goto LAB_180be2dfa;
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if ((int)plVar5[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[4] = lVar3;
          il2cpp_internal(plVar5 + 4,lVar3);
          if (("\n治安 " != 0) &&
             (lVar3 = il2cpp_internal("\n治安 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "\n治安 ";
          if (*(uint32 *)(plVar5 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[5] = "\n治安 ";
          il2cpp_internal(plVar5 + 5,lVar3);
          lVar3 = Single.ToString(areaData + 84,"f0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 3) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[6] = lVar3;
          il2cpp_internal(plVar5 + 6,lVar3);
          if (("/100 " != 0) &&
             (lVar3 = il2cpp_internal("/100 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "/100 ";
          if (*(uint32 *)(plVar5 + 3) < 4) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[7] = "/100 ";
          il2cpp_internal(plVar5 + 7,lVar3);
          local_res10[0] = AreaData.GetChangeAreaState(areaData,0,0);
          lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[8] = lVar3;
          il2cpp_internal(plVar5 + 8,lVar3);
          lVar3 = String.Concat(plVar5,0);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (plVar5 == (int64 *)0) goto LAB_180be2dfa;
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if ((int)plVar5[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[4] = lVar3;
          il2cpp_internal(plVar5 + 4,lVar3);
          if (("\n民心 " != 0) &&
             (lVar3 = il2cpp_internal("\n民心 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "\n民心 ";
          if (*(uint32 *)(plVar5 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[5] = "\n民心 ";
          il2cpp_internal(plVar5 + 5,lVar3);
          lVar3 = Single.ToString(areaData + 88,"f0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 3) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[6] = lVar3;
          il2cpp_internal(plVar5 + 6,lVar3);
          if (("/100 " != 0) &&
             (lVar3 = il2cpp_internal("/100 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "/100 ";
          if (*(uint32 *)(plVar5 + 3) < 4) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[7] = "/100 ";
          il2cpp_internal(plVar5 + 7,lVar3);
          local_res10[0] = AreaData.GetChangeAreaState(areaData,1);
          lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[8] = lVar3;
          il2cpp_internal(plVar5 + 8,lVar3);
          lVar3 = String.Concat(plVar5,0);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
          if (plVar5 == (int64 *)0) goto LAB_180be2dfa;
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if ((int)plVar5[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[4] = lVar3;
          il2cpp_internal(plVar5 + 4,lVar3);
          if (("\n防御 " != 0) &&
             (lVar3 = il2cpp_internal("\n防御 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "\n防御 ";
          if (*(uint32 *)(plVar5 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[5] = "\n防御 ";
          il2cpp_internal(plVar5 + 5,lVar3);
          lVar3 = Single.ToString(areaData + 92,"f0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 3) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[6] = lVar3;
          il2cpp_internal(plVar5 + 6,lVar3);
          if (("/100 " != 0) &&
             (lVar3 = il2cpp_internal("/100 ",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar3 = "/100 ";
          if (*(uint32 *)(plVar5 + 3) < 4) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[7] = "/100 ";
          il2cpp_internal(plVar5 + 7,lVar3);
          local_res10[0] = AreaData.GetChangeAreaState(areaData,2);
          lVar3 = Single.ToString(local_res10,"+0;-0;+0",0);
          if ((lVar3 != null) &&
             (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar5[8] = lVar3;
          il2cpp_internal(plVar5 + 8,lVar3);
          uVar4 = String.Concat(plVar5,0);
        }
        iVar15 = 0;
        while (lVar3 = *(int64 *)(areaData + 224)) != null {
          if (*(int *)(lVar3 + 24) <= iVar15) {
            if (((this.Back != null) &&
                (lVar3 = GameObject.get_transform(this.Back,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
              uVar8 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              LTLocalization.SetText(uVar8,uVar4,0);
              uVar16 = 0;
              goto LAB_180be24c0;
            }
            break;
          }
          lVar3 = FUN_180002f80(lVar3,iVar15,DAT_181d55758);
          if (lVar3 == null) break;
          AreaTreasurePriceData.GetDescribe(lVar3,0);
          uVar4 = String.Concat(uVar4);
          iVar15 = iVar15 + 1;
        }
        LAB_180be2dfa:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180be24c0:
        if (*(int64 *)(areaData + 128) == 0) goto LAB_180be2dfa;
        lVar3 = this.Back;
        if (*(int *)(*(int64 *)(areaData + 128) + 24) <= (int)uVar16) {
          lVar7 = new WarpText_d__8(0,0);
          if (lVar7 != null) {
            *(int64 *)(lVar7 + 32) = lVar3;
            FUN_180d837c0(this,lVar7,0);
            uVar16 = 0;
            local_78 = 0;
            goto LAB_180be2830;
          }
          goto LAB_180be2dfa;
        }
        if (lVar3 == null) goto LAB_180be2dfa;
        lVar3 = GameObject.get_transform(lVar3,0);
        local_84[0] = (int)local_88 / 2;
        uVar4 = Int32.ToString(local_84,0);
        uVar4 = String.Concat("Line",uVar4,0);
        if (lVar3 == null) goto LAB_180be2dfa;
        lVar3 = Transform.Find(lVar3,uVar4,0);
        uVar4 = Int32.ToString(&local_88,0);
        if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) goto LAB_180be2dfa;
        uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
        lVar3 = *(int64 *)(areaData + 128);
        lVar7 = (int64)(int)local_88;
        if (lVar3 == null) goto LAB_180be2dfa;
        if (*(uint32 *)(lVar3 + 24) <= local_88) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        local_res10[0] = *(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar7 * 4);
        uVar8 = Single.ToString(local_res10,"+0;-0;0",0);
        LTLocalization.SetText(uVar4,uVar8,0);
        if (this.Back == null) goto LAB_180be2dfa;
        lVar3 = GameObject.get_transform(this.Back,0);
        local_84[0] = (int)local_88 / 2;
        uVar4 = Int32.ToString(local_84,0);
        uVar4 = String.Concat("Line",uVar4,0);
        if (lVar3 == null) goto LAB_180be2dfa;
        lVar3 = Transform.Find(lVar3,uVar4,0);
        uVar4 = Int32.ToString(&local_88,0);
        if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"Text",0)) == null) goto LAB_180be2dfa;
        plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
        lVar3 = *(int64 *)(areaData + 128);
        uVar13 = (uint64)(int)local_88;
        if (lVar3 == null) goto LAB_180be2dfa;
        uVar14 = uVar13;
        if (*(uint32 *)(lVar3 + 24) <= local_88) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
          uVar14 = (uint64)local_88;
        }
        if (*(float *)(*(int64 *)(lVar3 + 16) + 32 + uVar13 * 4) == 0.0) {
          puVar9 = (uint32 *)FUN_1810988d0(local_60,0);
          uVar18 = *puVar9;
          uVar19 = puVar9[1];
          uVar20 = puVar9[2];
          uVar21 = puVar9[3];
        }
        else {
          if (*(int64 *)(areaData + 128) == 0) goto LAB_180be2dfa;
          fVar17 = (float)FUN_1800d6780(*(int64 *)(areaData + 128),uVar14,DAT_181d796d8);
          if (fVar17 <= 0.0) {
            lVar3 = pStatics_ef00;
            uVar18 = *(uint32 *)(lVar3 + 0x2f8);
            uVar19 = *(uint32 *)(lVar3 + 0x2fc);
            uVar20 = *(uint32 *)(lVar3 + 0x300);
            uVar21 = *(uint32 *)(lVar3 + 0x304);
          }
          else {
            lVar3 = pStatics_ef00;
            uVar18 = *(uint32 *)(lVar3 + 0x290);
            uVar19 = *(uint32 *)(lVar3 + 0x294);
            uVar20 = *(uint32 *)(lVar3 + 0x298);
            uVar21 = *(uint32 *)(lVar3 + 0x29c);
          }
        }
        if (plVar5 == (int64 *)0) goto LAB_180be2dfa;
        local_78 = CONCAT44(uVar19,uVar18);
        uStack_70 = uVar20;
        uStack_6c = uVar21;
        (**(code **)(*plVar5 + 0x2a8))(plVar5);
        uVar16 = local_88 + 1;
        local_88 = uVar16;
        goto LAB_180be24c0;
        LAB_180be2830:
        lVar7 = local_78;
        lVar3 = *(int64 *)(areaData + 192);
        if (lVar3 != null) {
          if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar16) {
            if (local_78 != 0) {
              uVar4 = AreaBuildingData.Name(local_78,0,0);
              uVar18 = *(uint32 *)(lVar7 + 20);
              uVar10 = GlobalData.GetNumText(uVar18,0);
              uVar8 = "<b>{0}</b>[{1}级]\n{2}";
              if (*(int *)(lVar7 + 68) == 0) {
                uVar11 = *(uint64 *)(pStatics_ef00 + 0x268);
                uVar12 = "{0}已拥有</color>";
              }
              else {
                uVar11 = *(uint64 *)(pStatics_ef00 + 0x2d0);
                uVar12 = "{0}未拥有</color>";
              }
              uVar11 = String.Format(uVar12,uVar11,0);
              uVar4 = String.Format(uVar8,uVar4,uVar10,uVar11,0);
              QuickDetail.AddDescribeTab(this,uVar4,0);
            }
            return;
          }
          if (*(uint32 *)(lVar3 + 24) <= uVar16) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(*(int64 *)(lVar3 + 16) + lVar6) == 0) {
        LAB_180be2cb9:
            uVar16 = uVar16 + 1;
            lVar6 = lVar6 + 8;
            local_68 = lVar6;
          }
          else {
            if ((*(int64 *)(areaData + 192) == 0) || (lVar3 = FUN_180002f80()) == null)
            goto LAB_180be2dfa;
            if (*(int64 *)(lVar3 + 40) == 0) goto LAB_180be2cb9;
            if (((*(int64 *)(areaData + 192) == 0) || (lVar3 = FUN_180002f80()) == null) ||
               (*(int64 *)(lVar3 + 40) == 0)) goto LAB_180be2dfa;
            if (*(int *)(*(int64 *)(lVar3 + 40) + 16) < 0) goto LAB_180be2cb9;
            if (((*(int64 *)(areaData + 192) == 0) ||
                (lVar3 = FUN_180002f80(*(int64 *)(areaData + 192),uVar16,DAT_181d554e0)) == null)
               || ((*(int64 *)(lVar3 + 40) == 0 ||
                   (lVar3 = AreaBuildingData.DataBase(*(int64 *)(lVar3 + 40),0)) == null)))
            goto LAB_180be2dfa;
            if (*(int *)(lVar3 + 48) == 6) {
              iVar15 = 0;
              lVar3 = "";
              while( true ) {
                if (((*(int64 *)(areaData + 192) == 0) ||
                    (lVar6 = FUN_180002f80(*(int64 *)(areaData + 192),uVar16,DAT_181d554e0), lVar6 == null
                    )) || ((*(int64 *)(lVar6 + 40) == 0 ||
                           ((lVar6 = AreaBuildingData.DataBase(*(int64 *)(lVar6 + 40),0), lVar6 == null
                            || (*(int64 *)(lVar6 + 64) == 0)))))) goto LAB_180be2dfa;
                lVar7 = *(int64 *)(areaData + 192);
                if (*(int *)(*(int64 *)(lVar6 + 64) + 24) <= iVar15) break;
                if (((((lVar7 == null) || (lVar6 = FUN_180002f80(lVar7,uVar16,DAT_181d554e0)) == null) ||
                     (*(int64 *)(lVar6 + 40) == 0)) ||
                    ((lVar6 = AreaBuildingData.DataBase(*(int64 *)(lVar6 + 40),0), lVar6 == null ||
                     (*(int64 *)(lVar6 + 64) == 0)))) ||
                   (lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 64),iVar15,DAT_181d54a60)) == null)
                goto LAB_180be2dfa;
                uVar4 = *(uint64 *)(lVar6 + 40);
                if (((*(int64 *)(areaData + 192) == 0) ||
                    (lVar6 = FUN_180002f80(*(int64 *)(areaData + 192),uVar16,DAT_181d554e0), lVar6 == null
                    )) || ((*(int64 *)(lVar6 + 40) == 0 ||
                           (((lVar6 = AreaBuildingData.DataBase(*(int64 *)(lVar6 + 40),0),
                             lVar6 == null || (*(int64 *)(lVar6 + 64) == 0)) ||
                            (lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 64),iVar15,DAT_181d54a60),
                            lVar6 == null)))))) goto LAB_180be2dfa;
                uVar1 = *(uint8 *)(lVar6 + 32);
                if ((*(int64 *)(areaData + 192) == 0) ||
                   (lVar6 = FUN_180002f80(*(int64 *)(areaData + 192),uVar16,DAT_181d554e0)) == null
                   ) goto LAB_180be2dfa;
                uVar8 = *(uint64 *)(lVar6 + 40);
                cVar2 = GameController.MeetCondition(uVar4,uVar1,uVar8,0);
                if (cVar2) {
                  cVar2 = FUN_1816fd990(lVar3,"",0);
                  lVar6 = "/";
                  if (cVar2) {
                    lVar6 = "";
                  }
                  if (((*(int64 *)(areaData + 192) == 0) ||
                      (lVar7 = FUN_180002f80(*(int64 *)(areaData + 192),uVar16,DAT_181d554e0),
                      lVar7 == null)) ||
                     ((*(int64 *)(lVar7 + 40) == 0 ||
                      (((lVar7 = AreaBuildingData.DataBase(*(int64 *)(lVar7 + 40),0), lVar7 == null ||
                        (*(int64 *)(lVar7 + 64) == 0)) ||
                       (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 64),iVar15,DAT_181d54a60),
                       lVar7 == null)))))) goto LAB_180be2dfa;
                  lVar3 = String.Concat(lVar3,lVar6,*(uint64 *)(lVar7 + 16));
                }
                iVar15 = iVar15 + 1;
              }
              if (((lVar7 != null) && (lVar6 = FUN_180002f80(lVar7,uVar16,DAT_181d554e0)) != null) &&
                 (*(int64 *)(lVar6 + 40) != 0)) {
                uVar4 = AreaBuildingData.Name(*(int64 *)(lVar6 + 40),0,0);
                if (((*(int64 *)(areaData + 192) != 0) &&
                    (lVar6 = FUN_180002f80(*(int64 *)(areaData + 192),uVar16,DAT_181d554e0), lVar6 != null
                    )) && (*(int64 *)(lVar6 + 40) != 0)) {
                  uVar18 = *(uint32 *)(*(int64 *)(lVar6 + 40) + 20);
                  uVar8 = GlobalData.GetNumText(uVar18,0);
                  String.Format("<b>{0}</b>[{1}级]\n{2}",uVar4,uVar8,lVar3,0);
                  QuickDetail.AddDescribeTab(this);
                  lVar6 = local_68;
                  goto LAB_180be2cb9;
                }
              }
              goto LAB_180be2dfa;
            }
            if (((*(int64 *)(areaData + 192) == 0) || (lVar3 = FUN_180002f80()) == null) ||
               (*(int64 *)(lVar3 + 40) == 0)) goto LAB_180be2dfa;
            if (*(int *)(*(int64 *)(lVar3 + 40) + 16) != 73) goto LAB_180be2cb9;
            if ((*(int64 *)(areaData + 192) == 0) || (lVar3 = FUN_180002f80()) == null)
            goto LAB_180be2dfa;
            local_78 = *(int64 *)(lVar3 + 40);
            uVar16 = uVar16 + 1;
            lVar6 = lVar6 + 8;
            local_68 = lVar6;
          }
          goto LAB_180be2830;
        }
        goto LAB_180be2dfa;
    }

    // Token : 0x6001F7C
    // RVA   : 0xBDFA50   Offset: 0xBDE250   Length: 0x6C
    public static IEnumerator RebuildTargetLayout(GameObject target)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = target;
          return lVar1;
        }
    }

    // Token : 0x6001F7D
    // RVA   : 0xBE3170   Offset: 0xBE1970   Length: 0x547
    public void ShowBattleGridQuickDetail(GameObject target, GridUnitData gridUnitData)
    {
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        float fVar11;
        float[] local_res10 = new float[2];
        float[] local_48 = new float[8];
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar3 = GameObject.get_transform(target,0);
          if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
            lVar3 = Component.get_gameObject(lVar3,0);
            this.Back = lVar3;
            if (gridUnitData != null) {
              lVar3 = *plVar1;
              if (*(int *)(gridUnitData + 20) == 2) {
                if (((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                  uVar7 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                  uVar4 = "\n";
                  lVar3 = *(int64 *)(gridUnitData + 48);
                  if (lVar3 != null) {
                    uVar5 = *(uint64 *)(lVar3 + 24);
                    uVar6 = "大型";
                    if (*(char *)(lVar3 + 48) == false) {
                      uVar6 = "";
                    }
                    uVar8 = "无法破坏";
                    if (*(float *)(lVar3 + 40) != -1.0) {
                      uVar8 = Single.ToString(lVar3 + 36,"f0",0);
                      if (*(int64 *)(gridUnitData + 48) == 0) throw; // [null/range check failed]
                      uVar9 = Single.ToString(*(int64 *)(gridUnitData + 48) + 40,"f0",0);
                      uVar8 = String.Concat(uVar8,"/",uVar9,0);
                    }
                    uVar4 = String.Concat(uVar6,uVar5,uVar4,uVar8,0);
                    LTLocalization.SetText(uVar7,uVar4,0);
                    if (*(int64 *)(gridUnitData + 48) != 0) {
                      if (*(char *)(*(int64 *)(gridUnitData + 48) + 66) == false) {
                        return;
                      }
                      if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null)
                         && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                        uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                        if (*(int64 *)(gridUnitData + 48) != 0) {
                          fVar11 = (float)ObstacleData.GetExtraExplodeRate
                                                    (*(int64 *)(gridUnitData + 48),0);
                          if ((*(int64 *)(gridUnitData + 48) != 0) &&
                             (lVar3 = ObstacleData.GetObstacleDataBase(*(int64 *)(gridUnitData + 48),0),
                             lVar3 != null)) {
                            local_res10[0] = fVar11 * *(float *)(lVar3 + 88) * 100.0;
                            uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
                            lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3b0);
                            if (((*(int64 *)(gridUnitData + 48) != 0) &&
                                (lVar10 = ObstacleData.GetObstacleDataBase
                                                    (*(int64 *)(gridUnitData + 48),0), lVar10 != null)) &&
                               (lVar3 != null)) {
                              uVar2 = *(uint32 *)(lVar10 + 92);
                              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar5 = *(uint64 *)
                                       (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                              if (*(int64 *)(gridUnitData + 48) != 0) {
                                local_48[0] = (float)ObstacleData.GetExtraExplodeRate
                                                               (*(int64 *)(gridUnitData + 48),0);
                                if ((*(int64 *)(gridUnitData + 48) != 0) &&
                                   (lVar3 = ObstacleData.GetObstacleDataBase
                                                      (*(int64 *)(gridUnitData + 48),0), lVar3 != null)) {
                                  local_48[0] = local_48[0] * *(float *)(lVar3 + 96);
                                  uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_48);
                                  uVar7 = String.Format("\n摧毁时伤害周围\n生命-{0}% {1}+{2}",uVar7,uVar5,uVar6,0);
                                  LTLocalization.AddText(uVar4,uVar7,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                  }
                }
              }
              else if (((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                      (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                lVar3 = *(int64 *)(gridUnitData + 56);
                if (lVar3 != null) {
                  uVar7 = *(uint64 *)(lVar3 + 24);
                  uVar5 = "";
                  if (*(int *)(lVar3 + 48) != -1) {
                    uVar5 = "绿";
                    if (*(int *)(lVar3 + 48) != 0) {
                      uVar5 = "红";
                    }
                    uVar5 = String.Format("({0}方陷阱)",uVar5,0);
                    lVar3 = *(int64 *)(gridUnitData + 56);
                    if (lVar3 == null) throw; // [null/range check failed]
                  }
                  if (*(int64 *)(lVar3 + 32) != 0) {
                    uVar6 = String.Replace(*(int64 *)(lVar3 + 32),"\\n","\n",0);
                    uVar7 = String.Concat(uVar7,uVar5,"\n",uVar6,0);
                    LTLocalization.SetText(uVar4,uVar7,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F7E
    // RVA   : 0xBE5F20   Offset: 0xBE4720   Length: 0x9FF
    public void ShowHeroQuickDetail(GameObject target, HeroData heroData)
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_2ba0 = *(int64*)(DAT_181da2ba0 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        byte uVar2;
        byte uVar3;
        bool cVar4;
        byte uVar5;
        byte uVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar11;
        float fVar12;
        uint[] local_res18 = new uint[4];
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint64 local_68;
        uint32 local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        uint64 local_50;
        local_res18[0] = 0;
        if (heroData != null) {
          HeroData.CheckHeroDetailDirty(heroData,1,0);
          if (target != null) {
            GameObject.SetActive(target,1,0);
            lVar7 = GameObject.get_transform(target,0);
            if ((lVar7 != null) && (lVar7 = Transform.Find(lVar7,"Back",0)) != null) {
              uVar8 = Component.get_gameObject(lVar7,0);
              this.Back = uVar8;
              if ((this.Back != null) &&
                 ((lVar7 = GameObject.get_transform(this.Back,0), lVar7 != null &&
                  (lVar7 = Transform.Find(lVar7,"Text",0)) != null))) {
                uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                uVar2 = FUN_1804625f0(0x130,0);
                if ((*pStatics_2ba0 != 0) &&
                   (lVar7 = *(int64 *)(*pStatics_2ba0 + 32)) != null) {
                  uVar3 = GameObject.get_activeSelf(lVar7,0);
                  if ((*pStatics_2370 != 0) &&
                     (lVar7 = *(int64 *)(*pStatics_2370 + 24)) != null) {
                    cVar4 = GameObject.get_activeInHierarchy(lVar7,0);
                    if (!cVar4) {
                      uVar5 = 0;
                    }
                    else {
                      if (*pStatics_2370 == 0) throw; // [null/range check failed]
                      uVar5 = FUN_1816fd990(*(uint64 *)(*pStatics_2370 + 88),
                                            "ChooseManageTagTargetResult",0);
                    }
                    if ((*pStatics_2370 != 0) &&
                       (lVar7 = *(int64 *)(*pStatics_2370 + 24)) != null)
                    {
                      uVar6 = GameObject.get_activeInHierarchy(lVar7,0);
                      uVar9 = HeroData.GetQuickDetail(heroData,uVar2,uVar3,uVar5,uVar6,0);
                      LTLocalization.SetText(uVar8,uVar9,0);
                      if ((*(char *)(heroData + 16) == false) &&
                         (cVar4 = FUN_1804625f0(0x130,0), !cVar4)) {
                        if (((this.Back == null) ||
                            (lVar7 = GameObject.get_transform(this.Back,0),
                            lVar7 == null)) || (lVar7 = Transform.Find(lVar7,"Text",0)) == null)
                        throw; // [null/range check failed]
                        uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                        LTLocalization.AddText(uVar8,"\n<i><color=grey>左Shift查看详情</color></i>",0);
                      }
                      if ((*(int64 *)(heroData + 0x2c0) != 0) &&
                         (lVar7 = HeroSpeAddData.GetKeys(*(int64 *)(heroData + 0x2c0),0)) != null)
                      {
                        FUN_181808140(&local_60,lVar7,DAT_181d67cf8);
                        local_78 = local_60;
                        uStack_74 = uStack_5c;
                        uStack_70 = uStack_58;
                        uStack_6c = uStack_54;
                        local_68 = local_50;
                        while( true ) {
                          do {
                            do {
                              cVar4 = FUN_180d19a30(&local_78,DAT_181d675c8);
                              uVar1 = local_68;
                              if (!cVar4) {
                                ZhSegment.Initialize(&local_78,DAT_181d67548);
                                return;
                              }
                              lVar7 = FUN_18046c100(0);
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar1 & 0xffffffff,
                                                    DAT_181d64878);
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                            } while (*(int *)(lVar7 + 60) == 0);
                            if (*(int64 *)(heroData + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(heroData + 0x2c0),
                                                                uVar1 & 0xffffffff,0);
                          } while (fVar12 <= 0.0);
                          plVar10 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
                          lVar7 = FUN_18046c100(0);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar1 & 0xffffffff,
                                                DAT_181d64878);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          if (*(char *)(lVar7 + 64) == false) {
                            lVar7 = *(int64 *)(pStatics_ef00 + 0x2c8);
                          }
                          else {
                            lVar7 = *(int64 *)(pStatics_ef00 + 0x260);
                          }
                          if (plVar10 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          if ((lVar7 != null) &&
                             (lVar11 = il2cpp_internal(lVar7,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          FUN_180002fd0(plVar10,0,lVar7);
                          lVar7 = FUN_18046c100(0);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar1 & 0xffffffff,
                                                DAT_181d64878);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar7 = *(int64 *)(lVar7 + 16);
                          if ((lVar7 != null) &&
                             (lVar11 = il2cpp_internal(lVar7,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          if (*(uint32 *)(plVar10 + 3) < 2) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          plVar10[5] = lVar7;
                          il2cpp_internal(plVar10 + 5,lVar7);
                          lVar7 = HeroData.GetBuffLevelString(heroData,uVar1 & 0xffffffff,0);
                          if ((lVar7 != null) &&
                             (lVar11 = il2cpp_internal(lVar7,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          if (*(uint32 *)(plVar10 + 3) < 3) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          plVar10[6] = lVar7;
                          il2cpp_internal(plVar10 + 6,lVar7);
                          if (*(int64 *)(heroData + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(heroData + 0x2c0),
                                                              uVar1 & 0xffffffff,0);
                          lVar7 = "(永久)";
                          if (fVar12 < 999.0) {
                            lVar7 = FUN_18046c100(0);
                            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar1 & 0xffffffff,
                                                  DAT_181d64878);
                            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            uVar8 = "[{0}合]";
                            if (*(int *)(lVar7 + 60) == -1) {
                              uVar8 = "({0}秒)";
                            }
                            if (*(int64 *)(heroData + 0x2c0) == 0) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            local_res18[0] =
                                 HeroSpeAddData.Get(*(int64 *)(heroData + 0x2c0),uVar1 & 0xffffffff,0);
                            uVar9 = Single.ToString(local_res18,"f0",0);
                            lVar7 = String.Format(uVar8,uVar9,0);
                          }
                          if ((lVar7 != null) &&
                             (lVar11 = il2cpp_internal(lVar7,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          FUN_180002fd0(plVar10,3,lVar7);
                          if (("</color>\n" != 0) &&
                             (lVar7 = il2cpp_internal("</color>\n",*(uint64 *)(*plVar10 + 64)),
                             lVar7 == null)) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          lVar7 = "</color>\n";
                          if (*(uint32 *)(plVar10 + 3) < 5) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          plVar10[8] = "</color>\n";
                          il2cpp_internal(plVar10 + 8,lVar7);
                          lVar7 = FUN_18046c100(0);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar1 & 0xffffffff,
                                                DAT_181d64878);
                          if (lVar7 == null) break;
                          lVar7 = *(int64 *)(lVar7 + 24);
                          if ((lVar7 != null) &&
                             (lVar11 = il2cpp_internal(lVar7,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          if (*(uint32 *)(plVar10 + 3) < 6) {
                            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar8,0);
                          }
                          plVar10[9] = lVar7;
                          il2cpp_internal(plVar10 + 9,lVar7);
                          uVar8 = String.Concat(plVar10,0);
                          if (this == 0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          QuickDetail.AddDescribeTab(this,uVar8,0);
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F7F
    // RVA   : 0xBDF330   Offset: 0xBDDB30   Length: 0x25A
    private void AddDescribeTab(string _text)
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        ulong uVar6;
        float fVar7;
        float local_58;
        uint uStack_54;
        uint local_50;
        ulong local_48;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.describeGrid != null) {
          lVar2 = GameObject.get_transform(this.describeGrid,0);
          if (this.Back != null) {
            lVar3 = GameObject.GetComponent(this.Back,DAT_181da0b98);
            if (lVar3 != null) {
              puVar4 = (uint32 *)RectTransform.get_rect(&local_38,lVar3,0);
              local_28 = *puVar4;
              uStack_24 = puVar4[1];
              uStack_20 = puVar4[2];
              uStack_1c = puVar4[3];
              fVar7 = (float)FUN_180d90480(&local_28,0);
              if (this.describeGrid != null) {
                lVar3 = GameObject.get_transform(this.describeGrid,0);
                if (lVar3 != null) {
                  puVar5 = (uint64 *)Transform.get_localPosition(&local_38,lVar3,0);
                  local_48 = *puVar5;
                  if (this.describeGrid != null) {
                    lVar3 = GameObject.get_transform(this.describeGrid,0);
                    if (lVar3 != null) {
                      puVar5 = (uint64 *)Transform.get_localPosition(&local_58,lVar3,0);
                      local_58 = fVar7 * 0.5;
                      local_38 = *puVar5;
                      local_50 = *(uint32 *)(puVar5 + 1);
                      uStack_54 = local_48._4_4_;
                      local_30 = local_50;
                      if (lVar2 != null) {
                        local_38 = CONCAT44(local_48._4_4_,local_58);
                        Transform.set_localPosition(lVar2,&local_38,0);
                        uVar6 = this.describeGrid;
                        uVar1 = *(uint64 *)(this + 200);
                        uVar6 = GlobalData.AddChild(uVar6,uVar1,0);
                        this.newObj = uVar6;
                        if (this.newObj != null) {
                          lVar2 = GameObject.get_transform(this.newObj,0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Text",0);
                            if (lVar2 != null) {
                              uVar6 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                              LTLocalization.SetText(uVar6,_text,0);
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

    // Token : 0x6001F80
    // RVA   : 0xBE0D90   Offset: 0xBDF590   Length: 0x1D7
    private void RefreshSkillRangeUI(KungfuSkillLvData skillLvData)
    {
        long lVar1;
        long lVar2;
        float fVar5;
        float local_58;
        uint uStack_54;
        uint local_50;
        ulong local_48;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.skillRangeUI != null) {
          GameObject.SetActive(this.skillRangeUI,1,0);
          if (this.skillRangeUI != null) {
            lVar1 = GameObject.get_transform(this.skillRangeUI,0);
            if (this.Back != null) {
              lVar2 = GameObject.GetComponent(this.Back,DAT_181da0b98);
              if (lVar2 != null) {
                puVar3 = (uint32 *)RectTransform.get_rect(&local_38,lVar2,0);
                local_28 = *puVar3;
                uStack_24 = puVar3[1];
                uStack_20 = puVar3[2];
                uStack_1c = puVar3[3];
                fVar5 = (float)FUN_180d90480(&local_28,0);
                if (this.skillRangeUI != null) {
                  lVar2 = GameObject.get_transform(this.skillRangeUI,0);
                  if (lVar2 != null) {
                    puVar4 = (uint64 *)Transform.get_localPosition(&local_38,lVar2,0);
                    local_48 = *puVar4;
                    if (this.skillRangeUI != null) {
                      lVar2 = GameObject.get_transform(this.skillRangeUI,0);
                      if (lVar2 != null) {
                        puVar4 = (uint64 *)Transform.get_localPosition(&local_58,lVar2,0);
                        local_58 = fVar5 * -0.5;
                        local_38 = *puVar4;
                        local_50 = *(uint32 *)(puVar4 + 1);
                        uStack_54 = local_48._4_4_;
                        local_30 = local_50;
                        if (lVar1 != null) {
                          local_38 = CONCAT44(local_48._4_4_,local_58);
                          Transform.set_localPosition(lVar1,&local_38,0);
                          if (this.skillRangeUI != null) {
                            lVar1 = GameObject.GetComponent(this.skillRangeUI,DAT_181da16b0);
                            if (lVar1 != null) {
                              SkillRangeUIController.RefreshSkillRange(lVar1,skillLvData,0);
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

    // Token : 0x6001F81
    // RVA   : 0xBE90E0   Offset: 0xBE78E0   Length: 0x8C8
    private void ShowSkillQuickDetail(GameObject target, KungfuSkillLvData skillLvData, bool showUseTime)
    {
        uint uVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        ulong uVar8;
        int iVar9;
        float fVar10;
        if (target == null) throw; // [null/range check failed]
        GameObject.SetActive(target,1,0);
        lVar4 = GameObject.get_transform(target,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Back",0)) == null)
        throw; // [null/range check failed]
        uVar5 = Component.get_gameObject(lVar4,0);
        this.Back = uVar5;
        if ((this.Back == null) ||
           ((lVar4 = GameObject.get_transform(this.Back,0), lVar4 == null ||
            (lVar4 = Transform.Find(lVar4,"Text",0)) == null))) throw; // [null/range check failed]
        uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
        if (plVar6 == (int64 *)0) throw; // [null/range check failed]
        if (("<size=18>" != 0) &&
           (lVar4 = il2cpp_internal("<size=18>",*(uint64 *)(*plVar6 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar4 = "<size=18>";
        if ((int)plVar6[3] == 0) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6[4] = "<size=18>";
        il2cpp_internal(plVar6 + 4,lVar4);
        if (skillLvData == null) throw; // [null/range check failed]
        lVar4 = KungfuSkillLvData.Name(skillLvData,0,0);
        if ((lVar4 != null) &&
           (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar6 + 3) < 2) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6[5] = lVar4;
        il2cpp_internal(plVar6 + 5,lVar4);
        if (("</size>\n" != 0) &&
           (lVar4 = il2cpp_internal("</size>\n",*(uint64 *)(*plVar6 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar4 = "</size>\n";
        if (*(uint32 *)(plVar6 + 3) < 3) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6[6] = "</size>\n";
        il2cpp_internal(plVar6 + 6,lVar4);
        lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
        if (lVar4 == null) throw; // [null/range check failed]
        lVar4 = KungfuSkillData.TypeDescribe(lVar4,0);
        if ((lVar4 != null) &&
           (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar6 + 3) < 4) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6[7] = lVar4;
        il2cpp_internal(plVar6 + 7,lVar4);
        if (("\n" != 0) &&
           (lVar4 = il2cpp_internal("\n",*(uint64 *)(*plVar6 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar4 = "\n";
        if (*(uint32 *)(plVar6 + 3) < 5) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6[8] = "\n";
        il2cpp_internal(plVar6 + 8,lVar4);
        uVar1 = *(uint32 *)(skillLvData + 20);
        uVar8 = GlobalData.GetNumText(uVar1,0);
        lVar4 = String.Format("第{0}重",uVar8,0);
        if ((lVar4 != null) &&
           (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar6 + 3) < 6) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar6[9] = lVar4;
        il2cpp_internal(plVar6 + 9,lVar4);
        uVar8 = String.Concat(plVar6,0);
        LTLocalization.SetText(uVar5,uVar8,0);
        if (*(int *)(skillLvData + 20) != 10) {
          lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(char *)(lVar4 + 16) == false) {
            cVar2 = KungfuSkillLvData.CanUpgrade(skillLvData,0);
            if ((!cVar2) ||
               (cVar2 = KungfuSkillLvData.SkillMeetObstacleLv(skillLvData,0), !cVar2)) {
              cVar2 = FUN_1804625f0(0x130,0);
              if (!cVar2) goto LAB_180be95ce;
              if (((this.Back == null) ||
                  (lVar4 = GameObject.get_transform(this.Back,0)) == null) ||
                 (lVar4 = Transform.Find(lVar4,"Text",0)) == null) throw; // [null/range check failed]
              uVar8 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              uVar5 = KungfuSkillLvData.GetExpDescribe(skillLvData,0);
              lVar4 = "\n";
            }
            else {
              if (((this.Back == null) ||
                  (lVar4 = GameObject.get_transform(this.Back,0)) == null) ||
                 (lVar4 = Transform.Find(lVar4,"Text",0)) == null) throw; // [null/range check failed]
              uVar8 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              lVar4 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x2c8);
              uVar5 = "\n(抵达瓶颈 需要突破)</color>";
            }
            uVar5 = String.Concat(lVar4,uVar5,0);
            LTLocalization.AddText(uVar8,uVar5,0);
          }
        }
        LAB_180be95ce:
        if ((this.Back != null) &&
           (lVar4 = GameObject.get_transform(this.Back,0)) != null) {
          lVar4 = Transform.Find(lVar4,"Text",0);
          if (lVar4 != null) {
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            uVar3 = FUN_1804625f0(0x130,0);
            iVar9 = 0;
            uVar8 = KungfuSkillLvData.GetSkillDescribe(skillLvData,uVar3,1,0,0);
            LTLocalization.AddText(uVar5,uVar8,0);
            QuickDetail.RefreshSkillRangeUI(this,skillLvData,0);
            do {
              lVar4 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
              if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 144)) == null) break;
              if (*(int *)(lVar4 + 24) <= iVar9) {
                return;
              }
              lVar4 = FUN_18046c100(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
                 (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),iVar9,DAT_181d64878)) == null)
              break;
              if (*(char *)(lVar4 + 89) == false) goto LAB_180be98bf;
              lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
              if (lVar4 == null) break;
              if (*(int64 *)(lVar4 + 104) == 0) {
        LAB_180be979e:
                lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
                if (lVar4 == null) break;
                if (*(int64 *)(lVar4 + 96) != 0) {
                  lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 96) == 0)) break;
                  fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(lVar4 + 96),iVar9,0);
                  if (fVar10 != 0.0) goto LAB_180be9852;
                }
                if ((*(int64 *)(skillLvData + 80) != 0) &&
                   (fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(skillLvData + 80),iVar9,0),
                   fVar10 != 0.0)) goto LAB_180be9852;
                lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
                if (lVar4 == null) break;
                if (*(int64 *)(lVar4 + 88) != 0) {
                  lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) break;
                  fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(lVar4 + 88),iVar9,0);
                  if (fVar10 != 0.0) goto LAB_180be9852;
                }
              }
              else {
                lVar4 = KungfuSkillLvData.DataBase(skillLvData,0);
                if ((lVar4 == null) || (*(int64 *)(lVar4 + 104) == 0)) break;
                fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(lVar4 + 104),iVar9,0);
                if (fVar10 == 0.0) goto LAB_180be979e;
        LAB_180be9852:
                lVar4 = FUN_18046c100(0);
                if (((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
                   (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),iVar9,DAT_181d64878)) == null)
                break;
                uVar5 = HeroSpeAddDataBase.GetDescribe(lVar4,0);
                QuickDetail.AddDescribeTab(this,uVar5,0);
              }
        LAB_180be98bf:
              iVar9 = iVar9 + 1;
            } while( true );
          }
        }
    }

    // Token : 0x6001F82
    // RVA   : 0xBE36C0   Offset: 0xBE1EC0   Length: 0xAB7
    private void ShowBookQuickDetail(GameObject target, ItemData bookData)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar2;
        byte uVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        int iVar11;
        float fVar12;
        uint[] local_res10 = new uint[2];
        uint[] local_58 = new uint[8];
        if (target == null) throw; // [null/range check failed]
        GameObject.SetActive(target,1,0);
        lVar5 = GameObject.get_transform(target,0);
        if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Back",0)) == null)
        throw; // [null/range check failed]
        lVar5 = Component.get_gameObject(lVar5,0);
        this.Back = lVar5;
        if ((((*pStatics_df90 == 0) ||
             (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar5 = WorldData.Player(lVar5,0), bookData == null)) ||
           ((*(int64 *)(bookData + 112) == 0 || (lVar5 == null)))) throw; // [null/range check failed]
        lVar5 = HeroData.FindSkill(lVar5,*(uint32 *)(*(int64 *)(bookData + 112) + 16),0);
        if (*(int64 *)(bookData + 112) == 0) throw; // [null/range check failed]
        lVar6 = BookData.DataBase(*(int64 *)(bookData + 112),0);
        if (((*plVar1 == 0) || (lVar7 = GameObject.get_transform(*plVar1,0)) == null) ||
           (lVar7 = Transform.Find(lVar7,"Text",0)) == null) throw; // [null/range check failed]
        uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
        uVar9 = ItemData.Name(bookData,0,0);
        uVar9 = String.Format("<size=18>《{0}》</size>",uVar9,0);
        uVar10 = ItemData.GetItemTypeDescribe(bookData,1,0);
        uVar9 = String.Concat(uVar9,"\n",uVar10,0);
        LTLocalization.SetText(uVar8,uVar9,0);
        lVar7 = *plVar1;
        if (lVar5 == null) {
          if (((lVar7 == null) || (lVar5 = GameObject.get_transform(lVar7,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"Text",0)) == null) throw; // [null/range check failed]
          uVar10 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          uVar8 = String.Format("\n{0}({1})</color>",
                                 *(uint64 *)(pStatics_ef00 + 0x2c8),
                                 "未习得",0);
        LAB_180be3c46:
          LTLocalization.AddText(uVar10,uVar8,0);
        }
        else {
          if (((lVar7 == null) || (lVar7 = GameObject.get_transform(lVar7,0)) == null) ||
             (lVar7 = Transform.Find(lVar7,"Text",0)) == null) throw; // [null/range check failed]
          uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
          uVar9 = *(uint64 *)(pStatics_ef00 + 0x260);
          uVar10 = GlobalData.GetNumText(*(uint32 *)(lVar5 + 20),0);
          uVar9 = String.Format("\n{0}(已习得 第{1}重)</color>",uVar9,uVar10,0);
          LTLocalization.AddText(uVar8,uVar9,0);
          if (*(int *)(lVar5 + 20) != 10) {
            cVar4 = KungfuSkillLvData.CanUpgrade(lVar5,0);
            if ((!cVar4) ||
               (cVar4 = KungfuSkillLvData.SkillMeetObstacleLv(lVar5,0), !cVar4)) {
              if ((*plVar1 == 0) ||
                 ((lVar7 = GameObject.get_transform(*plVar1,0), lVar7 == null ||
                  (lVar7 = Transform.Find(lVar7,"Text",0)) == null))) throw; // [null/range check failed]
              uVar10 = Component.GetComponent(lVar7,DAT_181d6d8c0);
              uVar9 = KungfuSkillLvData.GetExpDescribe(lVar5,0);
              uVar8 = "\n";
            }
            else {
              if (((*plVar1 == 0) || (lVar5 = GameObject.get_transform(*plVar1,0)) == null) ||
                 (lVar5 = Transform.Find(lVar5,"Text",0)) == null) throw; // [null/range check failed]
              uVar10 = Component.GetComponent(lVar5,DAT_181d6d8c0);
              uVar8 = *(uint64 *)(pStatics_ef00 + 0x2c8);
              uVar9 = "\n(抵达瓶颈 需要突破)</color>";
            }
            uVar8 = String.Concat(uVar8,uVar9,0);
            goto LAB_180be3c46;
          }
        }
        if ((((*plVar1 != 0) && (lVar5 = GameObject.get_transform(*plVar1,0)) != null) &&
            (lVar5 = Transform.Find(lVar5,"Text",0)) != null) &&
           (uVar8 = Component.GetComponent(lVar5,DAT_181d6d8c0), lVar6 != null)) {
          uVar2 = *(uint32 *)(lVar6 + 20);
          lVar5 = new KungfuSkillLvData(uVar2,0);
          uVar3 = FUN_1804625f0(0x130,0);
          if (lVar5 != null) {
            iVar11 = 0;
            uVar9 = KungfuSkillLvData.GetSkillDescribe(lVar5,uVar3,0,1,0);
            LTLocalization.AddText(uVar8,uVar9,0);
            if ((*(float *)(bookData + 76) <= 0.0) ||
               (cVar4 = ItemData.DetectPoisonNum(bookData,0), !cVar4)) {
              if ((*plVar1 == 0) ||
                 ((lVar5 = GameObject.get_transform(*plVar1,0), lVar5 == null ||
                  (lVar5 = Transform.Find(lVar5,"Text",0)) == null))) throw; // [null/range check failed]
              uVar8 = Component.GetComponent(lVar5,DAT_181d6d8c0);
              LTLocalization.AddText(uVar8,"\n",0);
            }
            else {
              if (((*plVar1 == 0) || (lVar5 = GameObject.get_transform(*plVar1,0)) == null) ||
                 (lVar5 = Transform.Find(lVar5,"Text",0)) == null) throw; // [null/range check failed]
              uVar8 = Component.GetComponent(lVar5,DAT_181d6d8c0);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                  (lVar5 = *(int64 *)(lVar5 + 0x168)) == null))) throw; // [null/range check failed]
              if (*(uint32 *)(lVar5 + 24) < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar9 = "\n\n{1}有毒 {0}</color>";
              uVar10 = "???";
              if (*(float *)(bookData + 76) <= *(float *)(*(int64 *)(lVar5 + 16) + 36)) {
                uVar10 = Single.ToString(bookData + 76,"f0",0);
              }
              uVar9 = String.Format(uVar9,uVar10,
                                     *(uint64 *)(pStatics_ef00 + 0x2c8),0);
              LTLocalization.AddText(uVar8,uVar9,0);
            }
            if (((*plVar1 == 0) || (lVar5 = GameObject.get_transform(*plVar1,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"Text",0)) == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = Component.GetComponent(lVar5,DAT_181d6d8c0);
            local_res10[0] = *(uint32 *)(bookData + 68);
            uVar9 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
            local_58[0] = *(uint32 *)(bookData + 56);
            uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_58);
            uVar9 = String.Format("\n重量{0}\n价值{1}",uVar9,uVar10,0);
            LTLocalization.AddText(uVar8,uVar9,0);
            uVar2 = *(uint32 *)(lVar6 + 20);
            uVar8 = new KungfuSkillLvData(uVar2,0);
            QuickDetail.RefreshSkillRangeUI(this,uVar8,0);
            while( true ) {
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
              if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 144)) == null) break;
              if (*(int *)(lVar5 + 24) <= iVar11) {
                return;
              }
              lVar5 = FUN_18046c100(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 144) == 0)) ||
                 (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),iVar11,DAT_181d64878)) == null)
              break;
              if ((*(char *)(lVar5 + 89) != false) &&
                 ((((*(int64 *)(lVar6 + 104) != 0 &&
                    (fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(lVar6 + 104),iVar11,0),
                    fVar12 != 0.0)) ||
                   ((*(int64 *)(lVar6 + 96) != 0 &&
                    (fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(lVar6 + 96),iVar11,0),
                    fVar12 != 0.0)))) ||
                  ((*(int64 *)(lVar6 + 88) != 0 &&
                   (fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(lVar6 + 88),iVar11,0),
                   fVar12 != 0.0)))))) {
                lVar5 = FUN_18046c100(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 144) == 0)) ||
                   (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),iVar11,DAT_181d64878)) == null)
                break;
                uVar8 = HeroSpeAddDataBase.GetDescribe(lVar5,0);
                QuickDetail.AddDescribeTab(this,uVar8,0);
              }
              iVar11 = iVar11 + 1;
            }
          }
        }
    }

    // Token : 0x6001F83
    // RVA   : 0xBE5450   Offset: 0xBE3C50   Length: 0xAC9
    private void ShowExploreTileQuickDetail(GameObject target, ExploreTileData exploreTileData)
    {
        var pStatics_0c98 = *(int64*)(DAT_181da0c98 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        uint[] local_res10 = new uint[2];
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar4 = GameObject.get_transform(target,0);
          if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Back",0)) != null) {
            uVar5 = Component.get_gameObject(lVar4,0);
            this.Back = uVar5;
            if (exploreTileData != null) {
              lVar4 = this.Back;
              if (*(int *)(exploreTileData + 48) == 2) {
                if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                   (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                  uVar7 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                  uVar5 = "大门\n{0}";
                  uVar6 = "已开启";
                  if (*(char *)(exploreTileData + 52) == false) {
                    lVar4 = FUN_18046be80(0);
                    if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_res10[0] = ExploreController.GetOpenLockCost(lVar4,0);
                    uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                    uVar6 = String.Format("钥匙-1/耐力-{0}",uVar6,0);
                  }
                  uVar5 = String.Format(uVar5,uVar6,0);
                  LTLocalization.SetText(uVar7,uVar5,0);
                  return;
                }
              }
              else if (*(int *)(exploreTileData + 48) == 1) {
                if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                   (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                  uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                  LTLocalization.SetText(uVar5,"墙壁",0);
                  return;
                }
              }
              else if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                      (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                lVar4 = FUN_18046be80(0);
                if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 32)) != null) {
                  uVar2 = *(uint32 *)(exploreTileData + 72);
                  if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar4[uVar2];
                  if (lVar4 != null) {
                    LTLocalization.SetText(uVar5,*(uint64 *)(lVar4 + 16),0);
                    lVar4 = FUN_18046be80(0);
                    if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 32)) != null) {
                      uVar2 = *(uint32 *)(exploreTileData + 72);
                      if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = lVar4[uVar2]
                      ;
                      if (lVar4 != null) {
                        if (*(int *)(lVar4 + 24) != 0) {
                          if (((this.Back == null) ||
                              (lVar4 = GameObject.get_transform(this.Back,0),
                              lVar4 == null)) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null
                             ) {
        LAB_180be5f08:
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                          lVar4 = FUN_18046be80(0);
                          if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 32)) == null)
                          goto LAB_180be5f08;
                          uVar2 = *(uint32 *)(exploreTileData + 72);
                          if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar4 = *(int64 *)
                                   (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar2 * 8);
                          if (lVar4 == null) goto LAB_180be5f08;
                          local_res10[0] = *(uint32 *)(lVar4 + 24);
                          uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                          uVar6 = String.Format(" (耐力-{0})",uVar6,0);
                          LTLocalization.AddText(uVar5,uVar6,0);
                        }
                        if ((*(int64 *)(exploreTileData + 80) == 0) ||
                           (*(int *)(*(int64 *)(exploreTileData + 80) + 20) == 0)) {
                          if ((*(int *)(exploreTileData + 56) < 1) || (*(char *)(exploreTileData + 53) != false)) {
                            if (*(int *)(exploreTileData + 56) != -1) {
                              return;
                            }
                            if (((this.Back != null) &&
                                (lVar4 = GameObject.get_transform(this.Back,0),
                                lVar4 != null)) &&
                               (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                              uVar6 = String.Format("\n{0}终点</color>",
                                                     *(uint64 *)
                                                      (pStatics_ef00 + 0x2c8),0);
        LAB_180be5d1d:
                              LTLocalization.AddText(uVar5,uVar6,0);
                              return;
                            }
                          }
                          else if (((this.Back != null) &&
                                   (lVar4 = GameObject.get_transform(this.Back,0),
                                   lVar4 != null)) &&
                                  (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                            lVar4 = FUN_18046be80(0);
                            if (((lVar4 != null) && (*(int64 *)(lVar4 + 40) != 0)) &&
                               (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 40),
                                                      *(uint32 *)(exploreTileData + 56),DAT_181d5ff78),
                               lVar4 != null)) {
                              uVar6 = String.Format("\n{0}",*(uint64 *)(lVar4 + 16),0);
                              LTLocalization.AddText(uVar5,uVar6,0);
                              lVar4 = FUN_18046be80(0);
                              if (((lVar4 != null) && (*(int64 *)(lVar4 + 40) != 0)) &&
                                 (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 40),
                                                        *(uint32 *)(exploreTileData + 56),DAT_181d5ff78),
                                 lVar4 != null)) {
                                cVar3 = FUN_1816fd990(*(uint64 *)(lVar4 + 16),"凶险",0);
                                if (cVar3) {
                                  if (((this.Back == null) ||
                                      (lVar4 = GameObject.get_transform(this.Back,0),
                                      lVar4 == null)) ||
                                     (lVar4 = Transform.Find(lVar4,"Text",0)) == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                  uVar1 = *(uint32 *)(exploreTileData + 60);
                                  uVar6 = GlobalData.GetDifficultyStarString(uVar1,0);
                                  local_res10[0] = *(uint32 *)(exploreTileData + 64);
                                  uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                                  uVar6 = String.Format("\n<size=17>{0}\n<b>敌人x{1}</b></size>",uVar6,uVar7,0);
                                  LTLocalization.AddText(uVar5,uVar6,0);
                                }
                                lVar4 = FUN_18046be80(0);
                                if (((lVar4 != null) && (*(int64 *)(lVar4 + 40) != 0)) &&
                                   (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 40),
                                                          *(uint32 *)(exploreTileData + 56),DAT_181d5ff78),
                                   lVar4 != null)) {
                                  cVar3 = FUN_1816fd990(*(uint64 *)(lVar4 + 16),"采集",0);
                                  if (!cVar3) {
                                    return;
                                  }
                                  if (((this.Back != null) &&
                                      (lVar4 = GameObject.get_transform(this.Back,0),
                                      lVar4 != null)) &&
                                     (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                                    uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                                    lVar4 = *(int64 *)(pStatics_ef00 + 0x430);
                                    if (lVar4 != null) {
                                      uVar6 = FUN_180002f80(lVar4,*(uint32 *)(exploreTileData + 68),
                                                            DAT_181d7c9c0);
                                      goto LAB_180be5d1d;
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                        else if (((this.Back != null) &&
                                 (lVar4 = GameObject.get_transform(this.Back,0),
                                 lVar4 != null)) &&
                                (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
                          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                          if ((*(int64 *)(exploreTileData + 80) != 0) &&
                             (*pStatics_0c98 != 0)) {
                            uVar6 = FUN_180002f80(*pStatics_0c98,
                                                  *(uint32 *)(*(int64 *)(exploreTileData + 80) + 16),
                                                  DAT_181d7c9c0);
                            lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
                            if ((*(int64 *)(exploreTileData + 80) != 0) && (lVar4 != null)) {
                              uVar7 = FUN_180002f80(lVar4,*(uint32 *)
                                                           (*(int64 *)(exploreTileData + 80) + 16),
                                                    DAT_181d7c9c0);
                              if (*(int64 *)(exploreTileData + 80) != 0) {
                                uVar8 = Int32.ToString(*(int64 *)(exploreTileData + 80) + 20,0);
                                uVar7 = String.Concat(uVar7,uVar8,0);
                                lVar4 = FUN_18046be80(0);
                                if (lVar4 != null) {
                                  cVar3 = ExploreController.PlayerCanPassObstacle(lVar4,exploreTileData,0,0);
                                  uVar8 = "\n{0}\n通行{2}{1}</color>";
                                  if (!cVar3) {
                                    lVar4 = FUN_18046be80(0);
                                    if (lVar4 == null) throw; // [null/range check failed]
                                    cVar3 = ExploreController.PlayerCanPassObstacle(lVar4,exploreTileData,1,0);
                                    if (!cVar3) {
                                      uVar9 = *(uint64 *)(pStatics_ef00 + 0x2c8)
                                      ;
                                    }
                                    else {
                                      uVar9 = *(uint64 *)(pStatics_ef00 + 0x240)
                                      ;
                                    }
                                  }
                                  else {
                                    uVar9 = *(uint64 *)(pStatics_ef00 + 0x260);
                                  }
                                  uVar6 = String.Format(uVar8,uVar6,uVar7,uVar9,0);
                                  goto LAB_180be5d1d;
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

    // Token : 0x6001F84
    // RVA   : 0xBE6920   Offset: 0xBE5120   Length: 0x9C6
    private void ShowHorseQuickDetail(GameObject target, ItemData horseData, bool isCompare, ItemIconController targetItemIconController)
    {
        void QuickDetail.ShowHorseQuickDetail
                     (int64 this,int64 target,int64 horseData,char isCompare,int64 targetItemIconController)
        {
        char cVar1;
        int64 lVar2;
        uint64 uVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint64 uVar7;
        uint32 uVar8;
        float fVar9;
        int local_res10 [2];
        uint32 local_38;
        uint32 local_34;
        uint32 local_30 [2];
        local_res10[0] = 0;
        if (target != null) {
          GameObject.SetActive(target,1,0);
          if (!isCompare) {
            lVar2 = GameObject.get_transform(target,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Back",0)) == null)
            throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar2,0);
            this.Back = uVar3;
          }
          lVar2 = GameObject.get_transform(target,0);
          if (((((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Back",0)) == null) ||
               (lVar2 = Component.get_gameObject(lVar2,0)) == null) ||
              ((lVar4 = GameObject.get_transform(lVar2,0), lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"Text",0)) == null))) ||
             (uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0), horseData == null)) throw; // [null/range check failed]
          uVar5 = ItemData.Name(horseData,0,0);
          uVar6 = ItemData.GetItemTypeDescribe(horseData,1,0);
          uVar5 = String.Concat("<size=18>",uVar5,"</size>\n",uVar6,0);
          LTLocalization.SetText(uVar3,uVar5,0);
          lVar4 = GameObject.get_transform(lVar2,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
          throw; // [null/range check failed]
          uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          uVar3 = "\n\n";
          uVar5 = "";
          if (*(int *)(horseData + 24) == 0) {
            if (*(int64 *)(horseData + 136) == 0) throw; // [null/range check failed]
            local_res10[0] = (int)(*(float *)(*(int64 *)(horseData + 136) + 60) * 100.0);
            uVar5 = Int32.ToString(local_res10,0);
            uVar5 = String.Concat("驯服 ",uVar5,"%\n\n",0);
          }
          if (*(int64 *)(horseData + 136) == 0) {
        LAB_180be72d5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar7 = HorseData.GetDescribe(*(int64 *)(horseData + 136),0);
          uVar3 = String.Concat(uVar3,uVar5,uVar7,0);
          LTLocalization.AddText(uVar6,uVar3,0);
          lVar4 = GameObject.get_transform(lVar2,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
          goto LAB_180be72d5;
          uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          uVar8 = ItemData.GetHorseMaxWeightAdd(horseData,0);
          local_38 = Mathf.RoundToInt(uVar8,0);
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
          fVar9 = (float)ItemData.GetHorseStepAddRate(horseData,0);
          local_34 = Mathf.RoundToInt(fVar9 * 100.0,0);
          uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_34);
          fVar9 = (float)ItemData.GetHorseSeeRange(horseData,0);
          local_30[0] = Mathf.RoundToInt(fVar9 * 100.0,0);
          uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_30);
          uVar5 = String.Format("\n\n负重上限+{0}\n视野范围+{2}%\n探索耐力+{1}%",uVar5,uVar6,uVar7,0);
          LTLocalization.AddText(uVar3,uVar5,0);
          if ((*(float *)(horseData + 76) <= 0.0) ||
             (cVar1 = ItemData.DetectPoisonNum(horseData,0), !cVar1)) {
            lVar4 = GameObject.get_transform(lVar2,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
            throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            uVar3 = "\n";
          }
          else {
            lVar4 = GameObject.get_transform(lVar2,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
            throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 0x168)) == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar4 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = "\n\n{1}有毒 {0}</color>";
            uVar6 = "???";
            if (*(float *)(horseData + 76) <= *(float *)(*(int64 *)(lVar4 + 16) + 36)) {
              uVar6 = Single.ToString(horseData + 76,"f0",0);
            }
            uVar3 = String.Format(uVar3,uVar6,
                                   *(uint64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x2c8),0);
          }
          LTLocalization.AddText(uVar5,uVar3,0);
          lVar4 = GameObject.get_transform(lVar2,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          local_30[0] = *(uint32 *)(horseData + 68);
          uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_30);
          local_34 = *(uint32 *)(horseData + 56);
          uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_34);
          uVar5 = String.Format("\n重量{0}\n价值{1}",uVar5,uVar6,0);
          LTLocalization.AddText(uVar3,uVar5,0);
          cVar1 = String.op_Inequality(*(uint64 *)(horseData + 48),"",0);
          if ((cVar1) && (*(int64 *)(horseData + 48) != 0)) {
            lVar4 = GameObject.get_transform(lVar2,0);
            if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
            throw; // [null/range check failed]
            uVar3 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            uVar5 = String.Concat("\n\n<color=grey><i>",*(uint64 *)(horseData + 48),"</i></color>",0);
            LTLocalization.AddText(uVar3,uVar5,0);
          }
          if (this.nowShowObject == null) throw; // [null/range check failed]
          uVar3 = GameObject.GetComponent();
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
            if (*(int *)(horseData + 24) == 0) {
              lVar4 = QuickDetail.GetTargetHero(this);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 0x208);
            }
            else {
              lVar4 = QuickDetail.GetTargetHero(this);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 0x218);
            }
            if (lVar4 == null) {
              return;
            }
            if (!isCompare) {
              uVar3 = QuickDetail.GetTargetHero(this,0);
              cVar1 = ItemData.IsHeroEquip(horseData,uVar3,0);
              if (!cVar1) {
                lVar2 = GameObject.get_transform(lVar2,0);
                if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
                throw; // [null/range check failed]
                uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                cVar1 = FUN_1804625f0(0x130,0);
                if (cVar1) {
                  cVar1 = Object.op_Inequality(targetItemIconController,0,0);
                  if (cVar1) {
                    if (targetItemIconController == null) throw; // [null/range check failed]
                    uVar5 = "\n<i><color=grey>单击替换装备</color></i>";
                    if (*(int *)(targetItemIconController + 40) == 0) goto LAB_180be724a;
                  }
                }
                uVar5 = "\n<i><color=grey>左Shift对比当前装备</color></i>";
                goto LAB_180be724a;
              }
            }
            lVar2 = GameObject.get_transform(lVar2,0);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
            throw; // [null/range check failed]
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            lVar2 = QuickDetail.GetTargetHero(this,0);
          }
          else {
            lVar2 = GameObject.get_transform(lVar2);
            if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
            throw; // [null/range check failed]
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if ((this.nowShowObject == null) ||
               (lVar2 = GameObject.GetComponent(this.nowShowObject,DAT_181d9fdc8)) == null
               ) throw; // [null/range check failed]
            lVar2 = *(int64 *)(lVar2 + 24);
          }
          if (lVar2 != null) {
            uVar5 = HeroData.HeroName(lVar2,0,0);
            uVar5 = String.Format("\n<i><color=grey>{0}当前装备</color></i>",uVar5,0);
        LAB_180be724a:
            LTLocalization.AddText(uVar3,uVar5,0);
            return;
          }
        }
    }

    // Token : 0x6001F85
    // RVA   : 0xBE72F0   Offset: 0xBE5AF0   Length: 0x7C4
    private void ShowMaterialQuickDetail(GameObject target, ItemData materialData)
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        float fVar8;
        float[] local_res10 = new float[2];
        ulong uVar9;
        uint local_38;
        uint[] local_34 = new uint[7];
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar3 = GameObject.get_transform(target,0);
          if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
            lVar3 = Component.get_gameObject(lVar3,0);
            this.Back = lVar3;
            if ((*plVar1 != 0) &&
               (((lVar3 = GameObject.get_transform(*plVar1,0), lVar3 != null &&
                 (lVar3 = Transform.Find(lVar3,"Text",0)) != null) &&
                (uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0), materialData != null)))) {
              uVar5 = ItemData.Name(materialData,0,0);
              uVar6 = ItemData.GetItemTypeDescribe(materialData,1,0);
              iVar7 = 0;
              uVar9 = 0;
              uVar5 = String.Concat("<size=18>",uVar5,"</size>\n",uVar6,0);
              LTLocalization.SetText(uVar4,uVar5,0);
              if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                local_res10[0] = (float)ItemData.GetMaterialExtraCraftRate(materialData,0);
                local_res10[0] = local_res10[0] * 100.0;
                uVar5 = Single.ToString(local_res10,"f0",0);
                uVar5 = String.Concat("\n\n制作效率+",uVar5,"%",0);
                LTLocalization.AddText(uVar4,uVar5,0);
                if ((*(int64 *)(materialData + 128) != 0) &&
                   (lVar3 = *(int64 *)(*(int64 *)(materialData + 128) + 16)) != null) {
                  cVar2 = HeroSpeAddData.isEmpty(lVar3,0);
                  if (!cVar2) {
                    if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null) &&
                       (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                      uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                      if ((*(int64 *)(materialData + 128) != 0) &&
                         (lVar3 = *(int64 *)(*(int64 *)(materialData + 128) + 16)) != null) {
                        uVar5 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,uVar9 & 0xffffffffffffff00,0);
                        uVar5 = String.Concat("\n\n<i>",uVar5,"</i>",0);
                        LTLocalization.AddText(uVar4,uVar5,0);
                        while( true ) {
                          lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                          if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 144)) == null) break;
                          if (*(int *)(lVar3 + 24) <= iVar7) goto LAB_180be7839;
                          lVar3 = FUN_18046c100(0);
                          if (((lVar3 == null) || (*(int64 *)(lVar3 + 144) == 0)) ||
                             (lVar3 = FUN_180002f80()) == null) break;
                          if (*(char *)(lVar3 + 89) != false) {
                            if (*(int64 *)(materialData + 128) == 0) break;
                            if ((*(int64 *)(*(int64 *)(materialData + 128) + 16) != 0) &&
                               (fVar8 = (float)HeroSpeAddData.Get(), fVar8 != 0.0)) {
                              lVar3 = FUN_18046c100(0);
                              if (((lVar3 == null) || (*(int64 *)(lVar3 + 144) == 0)) ||
                                 (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),iVar7)) == null)
                              break;
                              HeroSpeAddDataBase.GetDescribe(lVar3,0);
                              QuickDetail.AddDescribeTab(this);
                            }
                          }
                          iVar7 = iVar7 + 1;
                        }
                      }
                    }
                  }
                  else {
        LAB_180be7839:
                    if ((*(float *)(materialData + 76) <= 0.0) ||
                       (cVar2 = ItemData.DetectPoisonNum(materialData,0), !cVar2)) {
                      if ((*plVar1 != 0) &&
                         ((lVar3 = GameObject.get_transform(*plVar1,0), lVar3 != null &&
                          (lVar3 = Transform.Find(lVar3,"Text",0)) != null))) {
                        uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                        uVar4 = "\n";
        LAB_180be79db:
                        LTLocalization.AddText(uVar5,uVar4,0);
                        if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null)
                           && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                          local_38 = *(uint32 *)(materialData + 68);
                          uVar5 = il2cpp_value_box(DAT_181d7d0b8,&local_38);
                          local_34[0] = *(uint32 *)(materialData + 56);
                          uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_34);
                          uVar5 = String.Format("\n重量{0}\n价值{1}",uVar5,uVar6,0);
                          LTLocalization.AddText(uVar4,uVar5,0);
                          return;
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                    else if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null
                             ) && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                      uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                      lVar3 = FUN_18046c0a0(0);
                      if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                         ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 != null &&
                          (lVar3 = *(int64 *)(lVar3 + 0x168)) != null))) {
                        if (*(uint32 *)(lVar3 + 24) < 2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar4 = "\n\n{1}有毒 {0}</color>";
                        uVar6 = "???";
                        if (*(float *)(materialData + 76) <= *(float *)(*(int64 *)(lVar3 + 16) + 36))
                        {
                          uVar6 = Single.ToString(materialData + 76,"f0",0);
                        }
                        uVar4 = String.Format(uVar4,uVar6,
                                               *(uint64 *)
                                                (*(int64 *)(DAT_181d4ef00 + 184) + 0x2c8),0);
                        goto LAB_180be79db;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F86
    // RVA   : 0xBE9CE0   Offset: 0xBE84E0   Length: 0xD34
    private void ShowTreasureQuickDetail(GameObject target, ItemData treasureData)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        uint uVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        ulong uVar12;
        uint uVar13;
        uint[] local_res10 = new uint[2];
        uint[] local_38 = new uint[4];
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar2 = GameObject.get_transform(target,0);
          if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Back",0)) != null) {
            uVar3 = Component.get_gameObject(lVar2,0);
            this.Back = uVar3;
            if ((((*pStatics_df90 != 0) &&
                 (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                (lVar2 = WorldData.Player(lVar2,0)) != null) &&
               (uVar13 = HeroData.GetIdentifyKnowledge(lVar2,0), treasureData != null)) {
              ItemData.ManagePlayerGuessTreasureLv(treasureData,uVar13,0);
              if (((this.Back != null) &&
                  (lVar2 = GameObject.get_transform(this.Back,0)) != null) &&
                 (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
                uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
                if (plVar4 != (int64 *)0) {
                  if (("<size=18>" != 0) &&
                     (lVar2 = il2cpp_internal("<size=18>",*(uint64 *)(*plVar4 + 64)),
                     lVar2 == null)) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  lVar2 = "<size=18>";
                  if ((int)plVar4[3] == 0) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  plVar4[4] = "<size=18>";
                  il2cpp_internal(plVar4 + 4,lVar2);
                  lVar2 = ItemData.Name(treasureData,0,0);
                  if ((lVar2 != null) &&
                     (lVar5 = il2cpp_internal(lVar2,*(uint64 *)(*plVar4 + 64))) == null) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  if (*(uint32 *)(plVar4 + 3) < 2) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  plVar4[5] = lVar2;
                  il2cpp_internal(plVar4 + 5,lVar2);
                  if (("</size>\n" != 0) &&
                     (lVar2 = il2cpp_internal("</size>\n",*(uint64 *)(*plVar4 + 64)),
                     lVar2 == null)) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  lVar2 = "</size>\n";
                  if (*(uint32 *)(plVar4 + 3) < 3) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  plVar4[6] = "</size>\n";
                  il2cpp_internal(plVar4 + 6,lVar2);
                  lVar2 = ItemData.GetItemTypeDescribe(treasureData,1,0);
                  if ((lVar2 != null) &&
                     (lVar5 = il2cpp_internal(lVar2,*(uint64 *)(*plVar4 + 64))) == null) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  if (*(uint32 *)(plVar4 + 3) < 4) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  plVar4[7] = lVar2;
                  il2cpp_internal(plVar4 + 7,lVar2);
                  if (("\n" != 0) &&
                     (lVar2 = il2cpp_internal("\n",*(uint64 *)(*plVar4 + 64)),
                     lVar2 == null)) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  lVar2 = "\n";
                  if (*(uint32 *)(plVar4 + 3) < 5) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  plVar4[8] = "\n";
                  il2cpp_internal(plVar4 + 8,lVar2);
                  uVar6 = String.Concat(plVar4,0);
                  LTLocalization.SetText(uVar3,uVar6,0);
                  if (*(int64 *)(treasureData + 120) != 0) {
                    if (*(char *)(*(int64 *)(treasureData + 120) + 16) == false) {
                      if (((this.Back == null) ||
                          (lVar2 = GameObject.get_transform(this.Back,0)) == null
                          ) || (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
                      throw; // [null/range check failed]
                      uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                      if (*(int64 *)(treasureData + 120) == 0) throw; // [null/range check failed]
                      uVar6 = Single.ToString(*(int64 *)(treasureData + 120) + 20,0);
                      uVar6 = String.Concat("鉴定学识 ",uVar6,"\n",0);
                      LTLocalization.AddText(uVar3,uVar6,0);
                    }
                    uVar12 = 0;
                    uVar9 = uVar12;
                    uVar11 = uVar12;
                    while( true ) {
                      lVar2 = *(int64 *)(treasureData + 120);
                      if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) throw; // [null/range check failed]
                      uVar8 = (uint32)uVar9;
                      if (*(int *)(*(int64 *)(lVar2 + 24) + 24) <= (int)uVar8) break;
                      lVar2 = *(int64 *)(lVar2 + 40);
                      if (lVar2 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar2 + 24) <= uVar8) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = this.Back;
                      if (*(char *)(*(int64 *)(lVar2 + 16) + 32 + uVar11) == false) {
                        if (((lVar5 == null) || (lVar2 = GameObject.get_transform(lVar5,0)) == null) ||
                           (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
                        throw; // [null/range check failed]
                        uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                        lVar2 = *(int64 *)(pStatics_ef00 + 0x518);
                        if (lVar2 == null) throw; // [null/range check failed]
                        uVar6 = FUN_180002f80(lVar2,uVar9,DAT_181d7c9c0);
                        uVar6 = String.Concat("\n",uVar6," ?(");
                        LTLocalization.AddText(uVar3,uVar6,0);
                        uVar10 = uVar12;
                        while( true ) {
                          if (((*(int64 *)(treasureData + 120) == 0) ||
                              (lVar2 = *(int64 *)(*(int64 *)(treasureData + 120) + 48)) == null)
                             || (lVar2 = FUN_180002f80(lVar2,uVar9)) == null) throw; // [null/range check failed]
                          lVar5 = this.Back;
                          if (*(int *)(lVar2 + 24) <= (int)uVar10) break;
                          if (((lVar5 == null) || (lVar2 = GameObject.get_transform(lVar5,0)) == null)
                             || (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
                          throw; // [null/range check failed]
                          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          lVar2 = *(int64 *)(pStatics_ef00 + 0x520);
                          if ((((*(int64 *)(treasureData + 120) == 0) ||
                               (lVar5 = *(int64 *)(*(int64 *)(treasureData + 120) + 48)) == null)
                              || (lVar5 = FUN_180002f80(lVar5,uVar9,DAT_181d51688)) == null) ||
                             (uVar13 = FUN_1800d6750(lVar5,uVar10,DAT_181d68270), lVar2 == null))
                          throw; // [null/range check failed]
                          uVar6 = FUN_180002f80(lVar2,uVar13,DAT_181d7c9c0);
                          if (((*(int64 *)(treasureData + 120) == 0) ||
                              (lVar2 = *(int64 *)(*(int64 *)(treasureData + 120) + 48)) == null)
                             || (lVar2 = FUN_180002f80(lVar2,uVar9,DAT_181d51688)) == null)
                          throw; // [null/range check failed]
                          uVar13 = FUN_1800d6750(lVar2,uVar10,DAT_181d68270);
                          uVar6 = GlobalData.GenerateRareLvColorText(uVar6,uVar13,0);
                          LTLocalization.AddText(uVar3,uVar6,0);
                          uVar10 = (uint64)((int)uVar10 + 1);
                        }
                        if (((lVar5 == null) || (lVar2 = GameObject.get_transform(lVar5,0)) == null) ||
                           (lVar2 = Transform.Find(lVar2,"Text")) == null) throw; // [null/range check failed]
                        uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                        LTLocalization.AddText(uVar3);
                        uVar9 = (uint64)(uVar8 + 1);
                        uVar11 = uVar11 + 1;
                      }
                      else {
                        if (((lVar5 == null) || (lVar2 = GameObject.get_transform(lVar5,0)) == null) ||
                           (lVar2 = Transform.Find(lVar2,"Text",0)) == null)
                        throw; // [null/range check failed]
                        uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                        lVar2 = *(int64 *)(pStatics_ef00 + 0x518);
                        if (lVar2 == null) throw; // [null/range check failed]
                        uVar6 = FUN_180002f80(lVar2,uVar9,DAT_181d7c9c0);
                        lVar2 = *(int64 *)(pStatics_ef00 + 0x520);
                        if (((*(int64 *)(treasureData + 120) == 0) ||
                            (lVar5 = *(int64 *)(*(int64 *)(treasureData + 120) + 24)) == null) ||
                           (uVar13 = FUN_1800d6750(lVar5,uVar9,DAT_181d68270), lVar2 == null))
                        throw; // [null/range check failed]
                        uVar7 = FUN_180002f80(lVar2,uVar13,DAT_181d7c9c0);
                        if ((*(int64 *)(treasureData + 120) == 0) ||
                           (lVar2 = *(int64 *)(*(int64 *)(treasureData + 120) + 24)) == null)
                        throw; // [null/range check failed]
                        uVar13 = FUN_1800d6750(lVar2,uVar9,DAT_181d68270);
                        uVar7 = GlobalData.GenerateRareLvColorText(uVar7,uVar13,0);
                        String.Concat("\n",uVar6," ",uVar7,0);
                        LTLocalization.AddText(uVar3);
                        uVar9 = (uint64)(uVar8 + 1);
                        uVar11 = uVar11 + 1;
                      }
                    }
                    if ((*(float *)(treasureData + 76) <= 0.0) ||
                       (cVar1 = ItemData.DetectPoisonNum(treasureData,0), !cVar1)) {
                      if ((this.Back != null) &&
                         ((lVar2 = GameObject.get_transform(this.Back,0), lVar2 != null
                          && (lVar2 = Transform.Find(lVar2,"Text",0)) != null))) {
                        uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                        lVar2 = "\n";
        LAB_180bea7ec:
                        LTLocalization.AddText(uVar3,lVar2,0);
                        if (((this.Back != null) &&
                            (lVar2 = GameObject.get_transform(this.Back,0),
                            lVar2 != null)) && (lVar2 = Transform.Find(lVar2,"Text",0)) != null)
                        {
                          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          local_res10[0] = *(uint32 *)(treasureData + 68);
                          uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
                          local_38[0] = *(uint32 *)(treasureData + 56);
                          uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_38);
                          uVar6 = String.Format("\n重量{0}\n价值{1}",uVar6,uVar7,0);
                          LTLocalization.AddText(uVar3,uVar6,0);
                          if (*(int64 *)(treasureData + 120) != 0) {
                            if (*(char *)(*(int64 *)(treasureData + 120) + 16) == false) {
                              if (((this.Back == null) ||
                                  (lVar2 = GameObject.get_transform(this.Back,0),
                                  lVar2 == null)) ||
                                 (lVar2 = Transform.Find(lVar2,"Text",0)) == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                              local_res10[0] = ItemData.GetTreasureValue(treasureData,1,0);
                              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                              uVar6 = String.Format("({0}?)",uVar6,0);
                              LTLocalization.AddText(uVar3,uVar6,0);
                            }
                            return;
                          }
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                    else if (((this.Back != null) &&
                             (lVar2 = GameObject.get_transform(this.Back,0),
                             lVar2 != null)) && (lVar2 = Transform.Find(lVar2,"Text",0)) != null)
                    {
                      uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                      lVar2 = FUN_18046c0a0(0);
                      if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                         ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 != null &&
                          (lVar2 = *(int64 *)(lVar2 + 0x168)) != null))) {
                        if (*(uint32 *)(lVar2 + 24) < 2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar6 = "\n\n{1}有毒 {0}</color>";
                        uVar7 = "???";
                        if (*(float *)(treasureData + 76) <= *(float *)(*(int64 *)(lVar2 + 16) + 36))
                        {
                          uVar7 = Single.ToString(treasureData + 76,"f0",0);
                        }
                        lVar2 = String.Format(uVar6,uVar7,
                                               *(uint64 *)
                                                (pStatics_ef00 + 0x2c8),0);
                        goto LAB_180bea7ec;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F87
    // RVA   : 0xBE7AC0   Offset: 0xBE62C0   Length: 0xCF0
    private void ShowMedFoodQuickDetail(GameObject target, ItemData medFoodData)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        int iVar9;
        float fVar10;
        float fVar11;
        int[] local_res10 = new int[2];
        ulong uVar12;
        uint[] local_58 = new uint[12];
        if (target != null) {
          GameObject.SetActive(target,1,0);
          lVar2 = GameObject.get_transform(target,0);
          if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Back",0)) != null) {
            uVar3 = Component.get_gameObject(lVar2,0);
            this.Back = uVar3;
            if ((this.Back != null) &&
               (((lVar2 = GameObject.get_transform(this.Back,0), lVar2 != null &&
                 (lVar2 = Transform.Find(lVar2,"Text",0)) != null) &&
                (uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0), medFoodData != null)))) {
              uVar4 = ItemData.Name(medFoodData,0,0);
              uVar7 = "<size=18>";
              uVar6 = "</size>";
              if (*(int64 *)(medFoodData + 104) != 0) {
                piVar8 = (int *)(*(int64 *)(medFoodData + 104) + 16);
                uVar5 = "";
                if (0 < *piVar8) {
                  uVar5 = Int32.ToString(piVar8,"+0",0);
                }
                iVar9 = 0;
                uVar12 = 0;
                uVar6 = String.Concat(uVar7,uVar4,uVar6,uVar5,0);
                LTLocalization.SetText(uVar3,uVar6,0);
                if (((this.Back != null) &&
                    (lVar2 = GameObject.get_transform(this.Back,0)) != null) &&
                   (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
                  uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                  uVar6 = ItemData.GetItemTypeDescribe(medFoodData,1,0);
                  uVar6 = String.Concat("\n",uVar6,0);
                  LTLocalization.AddText(uVar3,uVar6,0);
                  if (((this.Back != null) &&
                      (lVar2 = GameObject.get_transform(this.Back,0)) != null) &&
                     (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
                    uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                    if ((*(int64 *)(medFoodData + 104) != 0) &&
                       (lVar2 = MedFoodData.GetChangeHeroStateData(*(int64 *)(medFoodData + 104),0),
                       lVar2 != null)) {
                      uVar6 = ChangeHeroStateData.GetDescribe(lVar2,0);
                      uVar6 = String.Concat("\n\n",uVar6,0);
                      LTLocalization.AddText(uVar3,uVar6,0);
                      if ((*(int64 *)(medFoodData + 104) != 0) &&
                         (lVar2 = *(int64 *)(*(int64 *)(medFoodData + 104) + 40)) != null) {
                        cVar1 = HeroSpeAddData.isEmpty(lVar2,0);
                        if (!cVar1) {
                          if (((this.Back == null) ||
                              (lVar2 = GameObject.get_transform(this.Back,0),
                              lVar2 == null)) || (lVar2 = Transform.Find(lVar2,"Text",0)) == null
                             ) throw; // [null/range check failed]
                          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          if ((*(int64 *)(medFoodData + 104) == 0) ||
                             (lVar2 = *(int64 *)(*(int64 *)(medFoodData + 104) + 40)) == null)
                          throw; // [null/range check failed]
                          uVar6 = HeroSpeAddData.GetDescribe(lVar2,1,1,1,uVar12 & 0xffffffffffffff00,0);
                          uVar6 = String.Concat("\n\n<i>",uVar6,"</i>",0);
                          LTLocalization.AddText(uVar3,uVar6,0);
                        }
                        if ((*(float *)(medFoodData + 76) <= 0.0) ||
                           (cVar1 = ItemData.DetectPoisonNum(medFoodData,0), !cVar1)) {
                          if ((this.Back == null) ||
                             ((lVar2 = GameObject.get_transform(this.Back,0),
                              lVar2 == null || (lVar2 = Transform.Find(lVar2,"Text",0)) == null))
                             ) throw; // [null/range check failed]
                          uVar6 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          uVar3 = "\n";
                        }
                        else {
                          if (((this.Back == null) ||
                              (lVar2 = GameObject.get_transform(this.Back,0),
                              lVar2 == null)) || (lVar2 = Transform.Find(lVar2,"Text",0)) == null
                             ) throw; // [null/range check failed]
                          uVar6 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          lVar2 = FUN_18046c0a0(0);
                          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                             ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 == null ||
                              (lVar2 = *(int64 *)(lVar2 + 0x168)) == null))) throw; // [null/range check failed]
                          if (*(uint32 *)(lVar2 + 24) < 2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          uVar3 = "\n\n{1}有毒 {0}</color>";
                          uVar7 = "???";
                          if (*(float *)(medFoodData + 76) <= *(float *)(*(int64 *)(lVar2 + 16) + 36)
                             ) {
                            uVar7 = Single.ToString(medFoodData + 76,"f0",0);
                          }
                          uVar3 = String.Format(uVar3,uVar7,
                                                 *(uint64 *)
                                                  (pStatics + 0x2c8),0);
                        }
                        LTLocalization.AddText(uVar6,uVar3,0);
                        if (((this.Back != null) &&
                            (lVar2 = GameObject.get_transform(this.Back,0),
                            lVar2 != null)) && (lVar2 = Transform.Find(lVar2,"Text",0)) != null)
                        {
                          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                          local_res10[0] = *(int *)(medFoodData + 68);
                          uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
                          local_58[0] = *(uint32 *)(medFoodData + 56);
                          uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_58);
                          uVar6 = String.Format("\n重量{0}\n价值{1}",uVar6,uVar7,0);
                          LTLocalization.AddText(uVar3,uVar6,0);
                          if ((*(int64 *)(medFoodData + 104) != 0) &&
                             (lVar2 = MedFoodData.GetChangeHeroStateData(*(int64 *)(medFoodData + 104),0)
                             , lVar2 != null)) {
                            if (0.0 < *(float *)(lVar2 + 20)) {
                              if ((*(int64 *)(medFoodData + 104) == 0) ||
                                 (lVar2 = MedFoodData.GetChangeHeroStateData
                                                    (*(int64 *)(medFoodData + 104),0), lVar2 == null))
                              throw; // [null/range check failed]
                              fVar10 = (float)ChangeHeroStateData.GetMaxChangeMaxHp(lVar2,0);
                              lVar2 = QuickDetail.GetTargetHero(this,0);
                              if (lVar2 == null) throw; // [null/range check failed]
                              fVar11 = (float)HeroData.GetExtraMaxHp(lVar2,0);
                              uVar3 = "{0}";
                              if (fVar10 < fVar11) {
                                uVar3 = String.Concat(*(uint64 *)
                                                        (pStatics + 0x2d0),
                                                       "{0}</color>",0);
                              }
                              if ((*(int64 *)(medFoodData + 104) == 0) ||
                                 (lVar2 = MedFoodData.GetChangeHeroStateData
                                                    (*(int64 *)(medFoodData + 104),0), lVar2 == null)) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              fVar10 = (float)ChangeHeroStateData.GetMaxChangeMaxHp(lVar2,0);
                              local_res10[0] = (int)fVar10;
                              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                              uVar6 = String.Format("额外生命>{0}时\n提升效果-90%",uVar6,0);
                              uVar3 = String.Format(uVar3,uVar6,0);
                              QuickDetail.AddDescribeTab(this,uVar3,0);
                            }
                            if ((*(int64 *)(medFoodData + 104) == 0) ||
                               (lVar2 = MedFoodData.GetChangeHeroStateData
                                                  (*(int64 *)(medFoodData + 104),0), lVar2 == null))
                            throw; // [null/range check failed]
                            if (0.0 < *(float *)(lVar2 + 28)) {
                              if ((*(int64 *)(medFoodData + 104) == 0) ||
                                 (lVar2 = MedFoodData.GetChangeHeroStateData
                                                    (*(int64 *)(medFoodData + 104),0), lVar2 == null))
                              throw; // [null/range check failed]
                              fVar10 = (float)ChangeHeroStateData.GetMaxChangeMaxMp(lVar2,0);
                              lVar2 = QuickDetail.GetTargetHero(this,0);
                              if (lVar2 == null) throw; // [null/range check failed]
                              fVar11 = (float)HeroData.GetExtraMaxMana(lVar2,0);
                              uVar3 = "{0}";
                              if (fVar10 < fVar11) {
                                uVar3 = String.Concat(*(uint64 *)
                                                        (pStatics + 0x2d0),
                                                       "{0}</color>",0);
                              }
                              if ((*(int64 *)(medFoodData + 104) == 0) ||
                                 (lVar2 = MedFoodData.GetChangeHeroStateData
                                                    (*(int64 *)(medFoodData + 104),0), lVar2 == null)) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              fVar10 = (float)ChangeHeroStateData.GetMaxChangeMaxMp(lVar2,0);
                              local_res10[0] = (int)fVar10;
                              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                              uVar6 = String.Format("额外内力>{0}时\n提升效果-90%",uVar6,0);
                              uVar3 = String.Format(uVar3,uVar6,0);
                              QuickDetail.AddDescribeTab(this,uVar3,0);
                            }
                            if ((*(int64 *)(medFoodData + 104) != 0) &&
                               (lVar2 = MedFoodData.GetChangeHeroStateData
                                                  (*(int64 *)(medFoodData + 104),0), lVar2 != null)) {
                              if (*(float *)(lVar2 + 40) <= 0.0 && *(float *)(lVar2 + 40) != 0.0) {
                                if ((*(int64 *)(medFoodData + 104) == 0) ||
                                   (lVar2 = MedFoodData.GetChangeHeroStateData
                                                      (*(int64 *)(medFoodData + 104),0), lVar2 == null)) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                local_res10[0] = -(int)*(float *)(lVar2 + 40);
                                uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                                uVar3 = String.Format("外伤超过{0}时，治疗效果-75%",uVar3,0);
                                QuickDetail.AddDescribeTab(this,uVar3,0);
                              }
                              if ((*(int64 *)(medFoodData + 104) != 0) &&
                                 (lVar2 = MedFoodData.GetChangeHeroStateData
                                                    (*(int64 *)(medFoodData + 104),0), lVar2 != null)) {
                                if (*(float *)(lVar2 + 44) <= 0.0 && *(float *)(lVar2 + 44) != 0.0) {
                                  if ((*(int64 *)(medFoodData + 104) == 0) ||
                                     (lVar2 = MedFoodData.GetChangeHeroStateData
                                                        (*(int64 *)(medFoodData + 104),0), lVar2 == null)) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  local_res10[0] = -(int)*(float *)(lVar2 + 44);
                                  uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                                  uVar3 = String.Format("内伤超过{0}时，治疗效果-75%",uVar3,0);
                                  QuickDetail.AddDescribeTab(this,uVar3,0);
                                }
                                if ((*(int64 *)(medFoodData + 104) != 0) &&
                                   (lVar2 = MedFoodData.GetChangeHeroStateData
                                                      (*(int64 *)(medFoodData + 104),0), lVar2 != null)) {
                                  if (*(float *)(lVar2 + 48) <= 0.0 && *(float *)(lVar2 + 48) != 0.0)
                                  {
                                    if ((*(int64 *)(medFoodData + 104) == 0) ||
                                       (lVar2 = MedFoodData.GetChangeHeroStateData
                                                          (*(int64 *)(medFoodData + 104),0), lVar2 == null))
                                    {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    local_res10[0] = -(int)*(float *)(lVar2 + 48);
                                    uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                                    uVar3 = String.Format("中毒超过{0}时，治疗效果-75%",uVar3,0);
                                    QuickDetail.AddDescribeTab(this,uVar3,0);
                                  }
                                  while( true ) {
                                    lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                                    if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 144)) == null)
                                    break;
                                    if (*(int *)(lVar2 + 24) <= iVar9) {
                                      return;
                                    }
                                    lVar2 = FUN_18046c100(0);
                                    if (((lVar2 == null) || (*(int64 *)(lVar2 + 144) == 0)) ||
                                       (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 144),iVar9,
                                                              DAT_181d64878), lVar2 == null)) break;
                                    if (*(char *)(lVar2 + 89) != false) {
                                      if (*(int64 *)(medFoodData + 104) == 0) break;
                                      lVar2 = *(int64 *)(*(int64 *)(medFoodData + 104) + 40);
                                      if ((lVar2 != null) &&
                                         (fVar10 = (float)HeroSpeAddData.Get(lVar2,iVar9,0),
                                         fVar10 != 0.0)) {
                                        lVar2 = FUN_18046c100(0);
                                        if (((lVar2 == null) || (*(int64 *)(lVar2 + 144) == 0)) ||
                                           (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 144),iVar9,
                                                                  DAT_181d64878), lVar2 == null)) break;
                                        uVar3 = HeroSpeAddDataBase.GetDescribe(lVar2,0);
                                        QuickDetail.AddDescribeTab(this,uVar3,0);
                                      }
                                    }
                                    iVar9 = iVar9 + 1;
                                  }
                                }
                              }
                            }
                            throw; // [null/range check failed]
                          }
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001F88
    // RVA   : 0xBE4180   Offset: 0xBE2980   Length: 0x1034
    private void ShowEquipmentQuickDetail(GameObject target, ItemData equipmentData, bool isCompare, ItemIconController targetItemIconController)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        void QuickDetail.ShowEquipmentQuickDetail
                     (int64 this,int64 target,int64 equipmentData,char isCompare,int64 targetItemIconController)
        {
        uint32 uVar1;
        char cVar2;
        int64 lVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        uint64 uVar8;
        uint64 uVar9;
        int64 *plVar10;
        int64 lVar11;
        uint32 uVar12;
        uint32 uVar13;
        float fVar14;
        uint32 local_res10 [2];
        uint64 uVar15;
        if (target != null) {
          GameObject.SetActive(target,1,0);
          if (!isCompare) {
            lVar3 = GameObject.get_transform(target,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Back",0)) == null)
            throw; // [null/range check failed]
            uVar4 = Component.get_gameObject(lVar3,0);
            this.Back = uVar4;
          }
          lVar3 = GameObject.get_transform(target,0);
          if (((((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) &&
               (lVar3 = Component.get_gameObject(lVar3,0)) != null) &&
              ((lVar5 = GameObject.get_transform(lVar3,0), lVar5 != null &&
               (lVar5 = Transform.Find(lVar5,"Text",0)) != null))) &&
             (uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0), equipmentData != null)) {
            cVar2 = FUN_180d6ca90(*(uint64 *)(equipmentData + 88),0);
            uVar9 = "<size=18>";
            if (!cVar2) {
              uVar6 = ItemData.Name(equipmentData,0,0);
            }
            else {
              if (*(int64 *)(equipmentData + 96) == 0) throw; // [null/range check failed]
              uVar6 = EquipmentData.GetExtraAddName(*(int64 *)(equipmentData + 96),0);
              uVar7 = ItemData.Name(equipmentData,0,0);
              uVar6 = String.Concat(uVar6,uVar7,0);
            }
            uVar7 = "</size>";
            lVar5 = *(int64 *)(equipmentData + 96);
            if (lVar5 != null) {
              uVar8 = "";
              if (0 < *(int *)(lVar5 + 16)) {
                uVar8 = Int32.ToString(lVar5 + 16,"+0",0);
              }
              uVar13 = 0;
              uVar15 = 0;
              uVar9 = String.Concat(uVar9,uVar6,uVar7,uVar8,0);
              LTLocalization.SetText(uVar4,uVar9,0);
              if (*(int64 *)(equipmentData + 96) != 0) {
                if (0 < *(int *)(*(int64 *)(equipmentData + 96) + 72)) {
                  lVar5 = GameObject.get_transform(lVar3,0);
                  if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null) {
        LAB_180be5113:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                  if (*(int64 *)(equipmentData + 96) == 0) goto LAB_180be5113;
                  local_res10[0] = *(uint32 *)(*(int64 *)(equipmentData + 96) + 72);
                  uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                  uVar9 = String.Format("\n[天工+{0}]",uVar9,0);
                  LTLocalization.AddText(uVar4,uVar9,0);
                }
                lVar5 = GameObject.get_transform(lVar3,0);
                if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
                  uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                  uVar9 = ItemData.GetItemTypeDescribe(equipmentData,1,0);
                  uVar9 = String.Concat("\n",uVar9,0);
                  LTLocalization.AddText(uVar4,uVar9,0);
                  if ((*(int64 *)(equipmentData + 96) != 0) &&
                     (lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 32)) != null) {
                    cVar2 = HeroSpeAddData.isEmpty(lVar5,0);
                    if (!cVar2) {
                      lVar5 = GameObject.get_transform(lVar3,0);
                      if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
                      throw; // [null/range check failed]
                      uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                      if ((*(int64 *)(equipmentData + 96) == 0) ||
                         (lVar5 = EquipmentData.GetBaseAddData(*(int64 *)(equipmentData + 96),0),
                         lVar5 == null)) throw; // [null/range check failed]
                      uVar15 = uVar15 & 0xffffffffffffff00;
                      uVar9 = HeroSpeAddData.GetDescribe(lVar5,0,1,1,uVar15,0);
                      uVar9 = String.Concat("\n\n",uVar9,0);
                      LTLocalization.AddText(uVar4,uVar9,0);
                    }
                    if ((*(int64 *)(equipmentData + 96) != 0) &&
                       (lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 40)) != null) {
                      cVar2 = HeroSpeAddData.isEmpty(lVar5,0);
                      if (!cVar2) {
                        lVar5 = GameObject.get_transform(lVar3,0);
                        if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
                        throw; // [null/range check failed]
                        uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                        if ((*(int64 *)(equipmentData + 96) == 0) ||
                           (lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 40)) == null)
                        throw; // [null/range check failed]
                        uVar15 = uVar15 & 0xffffffffffffff00;
                        uVar9 = HeroSpeAddData.GetDescribe(lVar5,1,1,1,uVar15,0);
                        uVar9 = String.Concat("\n\n<i>",uVar9,"</i>",0);
                        LTLocalization.AddText(uVar4,uVar9,0);
                      }
                      if ((*(int64 *)(equipmentData + 96) != 0) &&
                         (lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 64)) != null) {
                        if (0.0 < *(float *)(lVar5 + 16)) {
                          lVar5 = GameObject.get_transform(lVar3,0);
                          if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Text",0)) == null
                             ) throw; // [null/range check failed]
                          uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                          plVar10 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
                          if (plVar10 == (int64 *)0) throw; // [null/range check failed]
                          if (("\n\n" != 0) &&
                             (lVar5 = il2cpp_internal("\n\n",*(uint64 *)(*plVar10 + 64)),
                             lVar5 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          lVar5 = "\n\n";
                          if ((int)plVar10[3] == 0) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar10[4] = "\n\n";
                          il2cpp_internal(plVar10 + 4,lVar5);
                          lVar5 = *(int64 *)(pStatics + 0x260);
                          if ((lVar5 != null) &&
                             (lVar11 = il2cpp_internal(lVar5,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          if (*(uint32 *)(plVar10 + 3) < 2) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar10[5] = lVar5;
                          il2cpp_internal(plVar10 + 5,lVar5);
                          if (("[淬毒" != 0) &&
                             (lVar5 = il2cpp_internal("[淬毒",*(uint64 *)(*plVar10 + 64)),
                             lVar5 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          lVar5 = "[淬毒";
                          if (*(uint32 *)(plVar10 + 3) < 3) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar10[6] = "[淬毒";
                          il2cpp_internal(plVar10 + 6,lVar5);
                          if ((*(int64 *)(equipmentData + 96) == 0) ||
                             (lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 64)) == null)
                          throw; // [null/range check failed]
                          lVar5 = Single.ToString(lVar5 + 16,"0",0);
                          if ((lVar5 != null) &&
                             (lVar11 = il2cpp_internal(lVar5,*(uint64 *)(*plVar10 + 64)),
                             lVar11 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          if (*(uint32 *)(plVar10 + 3) < 4) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar10[7] = lVar5;
                          il2cpp_internal(plVar10 + 7,lVar5);
                          if (("]</color>" != 0) &&
                             (lVar5 = il2cpp_internal("]</color>",*(uint64 *)(*plVar10 + 64)),
                             lVar5 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          lVar5 = "]</color>";
                          if (*(uint32 *)(plVar10 + 3) < 5) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar10[8] = "]</color>";
                          il2cpp_internal(plVar10 + 8,lVar5);
                          uVar9 = String.Concat(plVar10,0);
                          LTLocalization.AddText(uVar4,uVar9,0);
                          if (((*(int64 *)(equipmentData + 96) == 0) ||
                              (lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 64)) == null)
                             || (lVar5 = *(int64 *)(lVar5 + 24)) == null) throw; // [null/range check failed]
                          cVar2 = HeroSpeAddData.isEmpty(lVar5,0);
                          if (!cVar2) {
                            lVar5 = GameObject.get_transform(lVar3,0);
                            if ((lVar5 == null) ||
                               (lVar5 = Transform.Find(lVar5,"Text",0)) == null)
                            throw; // [null/range check failed]
                            uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                            if ((*(int64 *)(equipmentData + 96) == 0) ||
                               ((lVar5 = *(int64 *)(*(int64 *)(equipmentData + 96) + 64), lVar5 == null
                                || (lVar5 = EquipPoisonData.GetPoisonBuffData(lVar5,0)) == null)))
                            throw; // [null/range check failed]
                            uVar9 = HeroSpeAddData.GetDescribe(lVar5,1,1,1,uVar15 & 0xffffffffffffff00,0)
                            ;
                            uVar9 = String.Concat("\n<i>",uVar9,"</i>",0);
                            LTLocalization.AddText(uVar4,uVar9,0);
                          }
                        }
                        if ((*(float *)(equipmentData + 76) <= 0.0) ||
                           (cVar2 = ItemData.DetectPoisonNum(equipmentData,0), !cVar2)) {
                          lVar5 = GameObject.get_transform(lVar3,0);
                          if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null
                             ) {
                            uVar9 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                            uVar4 = "\n";
        LAB_180be4c46:
                            LTLocalization.AddText(uVar9,uVar4,0);
                            lVar5 = GameObject.get_transform(lVar3,0);
                            if ((lVar5 != null) &&
                               (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
                              uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                              uVar9 = Single.ToString(equipmentData + 68,"0.#",0);
                              local_res10[0] = *(uint32 *)(equipmentData + 56);
                              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                              uVar9 = String.Format("\n重量{0}\n价值{1}",uVar9,uVar6,0);
                              LTLocalization.AddText(uVar4,uVar9,0);
                              uVar1 = *(uint32 *)(equipmentData + 24);
                              lVar5 = QuickDetail.FindPlayerEquipment(this,uVar1,0);
                              if (lVar5 != null) {
                                lVar11 = 32;
                                for (uVar12 = uVar13; (int)uVar12 < (int)*(uint32 *)(lVar5 + 24);
                                    uVar12 = uVar12 + 1) {
                                  if (*(uint32 *)(lVar5 + 24) <= uVar12) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  if (*(int64 *)(lVar11 + *(int64 *)(lVar5 + 16)) != 0) {
                                    if (!isCompare) {
                                      uVar4 = QuickDetail.GetTargetHero(this,0);
                                      cVar2 = ItemData.IsHeroEquip(equipmentData,uVar4,0);
                                      if (cVar2) goto LAB_180be4e3b;
                                      lVar3 = GameObject.get_transform(lVar3,0);
                                      if ((lVar3 == null) ||
                                         (lVar3 = Transform.Find(lVar3,"Text",0)) == null)
                                      throw; // [null/range check failed]
                                      uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                      cVar2 = FUN_1804625f0(0x130,0);
                                      if (!cVar2) {
        LAB_180be4e2f:
                                        uVar9 = "\n<i><color=grey>左Shift对比当前装备</color></i>";
                                      }
                                      else {
                                        cVar2 = Object.op_Inequality(targetItemIconController,0,0);
                                        if (!cVar2) goto LAB_180be4e2f;
                                        if (targetItemIconController == null) throw; // [null/range check failed]
                                        uVar9 = "\n<i><color=grey>单击替换装备</color></i>";
                                        if (*(int *)(targetItemIconController + 40) != 0) goto LAB_180be4e2f;
                                      }
                                    }
                                    else {
        LAB_180be4e3b:
                                      lVar3 = GameObject.get_transform(lVar3,0);
                                      if ((lVar3 == null) ||
                                         (lVar3 = Transform.Find(lVar3,"Text",0)) == null)
                                      throw; // [null/range check failed]
                                      uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                      lVar3 = QuickDetail.GetTargetHero(this,0);
                                      if (lVar3 == null) throw; // [null/range check failed]
                                      uVar9 = HeroData.HeroName(lVar3,0,0);
                                      uVar9 = String.Format("\n<i><color=grey>{0}当前装备</color></i>",uVar9,0);
                                    }
                                    LTLocalization.AddText(uVar4,uVar9,0);
                                    break;
                                  }
                                  lVar11 = lVar11 + 8;
                                }
                                do {
                                  lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                                  if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 144)) == null)
                                  throw; // [null/range check failed]
                                  if (*(int *)(lVar3 + 24) <= (int)uVar13) {
                                    return;
                                  }
                                  lVar3 = FUN_18046c100(0);
                                  if (((lVar3 == null) || (*(int64 *)(lVar3 + 144) == 0)) ||
                                     (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),uVar13,
                                                            DAT_181d64878), lVar3 == null))
                                  throw; // [null/range check failed]
                                  if (*(char *)(lVar3 + 89) == false) goto LAB_180be50d6;
                                  if (*(int64 *)(equipmentData + 96) == 0) throw; // [null/range check failed]
                                  lVar3 = *(int64 *)(*(int64 *)(equipmentData + 96) + 32);
                                  if ((lVar3 == null) ||
                                     (fVar14 = (float)HeroSpeAddData.Get(lVar3,uVar13,0), fVar14 == 0.0))
                                  {
                                    if (*(int64 *)(equipmentData + 96) == 0) throw; // [null/range check failed]
                                    lVar3 = *(int64 *)(*(int64 *)(equipmentData + 96) + 40);
                                    if ((lVar3 != null) &&
                                       (fVar14 = (float)HeroSpeAddData.Get(lVar3,uVar13,0), fVar14 != 0.0
                                       )) goto LAB_180be5069;
                                    if ((*(int64 *)(equipmentData + 96) == 0) ||
                                       (lVar3 = *(int64 *)(*(int64 *)(equipmentData + 96) + 64),
                                       lVar3 == null)) throw; // [null/range check failed]
                                    lVar3 = EquipPoisonData.GetPoisonBuffData(lVar3,0);
                                    if (lVar3 != null) {
                                      if (((*(int64 *)(equipmentData + 96) == 0) ||
                                          (lVar3 = *(int64 *)(*(int64 *)(equipmentData + 96) + 64),
                                          lVar3 == null)) ||
                                         (lVar3 = EquipPoisonData.GetPoisonBuffData(lVar3,0)) == null
                                         ) throw; // [null/range check failed]
                                      fVar14 = (float)HeroSpeAddData.Get(lVar3,uVar13,0);
                                      if (fVar14 != 0.0) goto LAB_180be5069;
                                    }
                                  }
                                  else {
        LAB_180be5069:
                                    lVar3 = FUN_18046c100(0);
                                    if (((lVar3 == null) || (*(int64 *)(lVar3 + 144) == 0)) ||
                                       (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 144),uVar13,
                                                              DAT_181d64878), lVar3 == null))
                                    throw; // [null/range check failed]
                                    uVar4 = HeroSpeAddDataBase.GetDescribe(lVar3,0);
                                    QuickDetail.AddDescribeTab(this,uVar4,0);
                                  }
        LAB_180be50d6:
                                  uVar13 = uVar13 + 1;
                                } while( true );
                              }
                            }
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                        }
                        else {
                          lVar5 = GameObject.get_transform(lVar3,0);
                          if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null
                             ) {
                            uVar9 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                            lVar5 = FUN_18046c0a0(0);
                            if ((((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                                (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) != null) &&
                               (lVar5 = *(int64 *)(lVar5 + 0x168)) != null) {
                              if (*(uint32 *)(lVar5 + 24) < 2) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar4 = "\n\n{1}[有毒{0}]</color>";
                              uVar6 = "???";
                              if (*(float *)(equipmentData + 76) <=
                                  *(float *)(*(int64 *)(lVar5 + 16) + 36)) {
                                uVar6 = Single.ToString(equipmentData + 76,"f0",0);
                              }
                              uVar4 = String.Format(uVar4,uVar6,
                                                     *(uint64 *)
                                                      (pStatics + 0x2c8),0);
                              goto LAB_180be4c46;
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

    // Token : 0x6001F89
    // RVA   : 0xBDF600   Offset: 0xBDDE00   Length: 0x78
    public void DisableDescribe()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.nowShowObject = 0;
        lVar1 = Component.get_transform(this,0);
        puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
        if (lVar1 != null) {
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          this.forceUp = 0;
          return;
        }
    }

    // Token : 0x6001F8A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001F8B
    // RVA   : 0xBEDEB0   Offset: 0xBEC6B0   Length: 0x14D
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar1,DAT_181d79358);
        if (lVar1 != null) {
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          FUN_181805690(lVar1,0xbf800000,DAT_181d79458);
          FUN_181805690(lVar1,0,DAT_181d79458);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d6ece0 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
