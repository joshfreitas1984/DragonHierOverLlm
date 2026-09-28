// ============================================================
// Type  : BigMapController
// Token : 0x2000194
// ============================================================

public class BigMapController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AF3
    public float maxScale;

    // Token: 0x4000AF4
    public float minScale;

    // Token: 0x4000AF5
    public float nowScale;

    // Token: 0x4000AF6
    public static float showTextScale;

    // Token: 0x4000AF7
    public static float FocusMapScale;

    // Token: 0x4000AF8
    public float scrollSpeed;

    // Token: 0x4000AF9
    public float rootWidth;

    // Token: 0x4000AFA
    public float rootHeight;

    // Token: 0x4000AFB
    public float bigMapWidth;

    // Token: 0x4000AFC
    public float bigMapHeight;

    // Token: 0x4000AFD
    public GameObject bigmapScaleRoot;

    // Token: 0x4000AFE
    public GameObject bigmapRoot;

    // Token: 0x4000AFF
    public GameObject bigmapSprite;

    // Token: 0x4000B00
    public GameObject targetIcon;

    // Token: 0x4000B01
    public GameObject playerArmy;

    // Token: 0x4000B02
    public Dictionary<int, GameObject> areaIcons;

    // Token: 0x4000B03
    public Dictionary<int, GameObject> resourcePoints;

    // Token: 0x4000B04
    public Dictionary<int, ResourcePointController> resourcePointControllers;

    // Token: 0x4000B05
    public Dictionary<int, GameObject> innIcons;

    // Token: 0x4000B06
    public List<GameObject> bigmapRandomEventIcons;

    // Token: 0x4000B07
    public List<GameObject> bigmapNormalNpcIcons;

    // Token: 0x4000B08
    public List<GameObject> bigmapTempNpcIcons;

    // Token: 0x4000B09
    public List<HeroData> needRemoveBigMapNpc;

    // Token: 0x4000B0A
    public GameObject playerTargetIcon;

    // Token: 0x4000B0B
    public Vector2 tweenFocusTarget;

    // Token: 0x4000B0C
    public GameObject backForceButton;

    // Token: 0x4000B0D
    public GameObject focusSelfButton;

    // Token: 0x4000B0E
    public GameObject playerRestButton;

    // Token: 0x4000B0F
    public GameObject fastmodeButton;

    // Token: 0x4000B10
    public GameObject horseUI;

    // Token: 0x4000B11
    public GameObject bigmapUIPanel;

    // Token: 0x4000B12
    public GameObject areaUIPrefab;

    // Token: 0x4000B13
    public bool playerResting;

    // Token: 0x4000B14
    private static float BigMapZPosScale;

    // Token: 0x4000B15
    public bool fastMode;

    // Token: 0x4000B16
    private static BigMapController _instance;

    // Token: 0x4000B17
    private BigMapPos targetPos;

    // Token: 0x4000B18
    private Vector2 nextPos;

    // Token: 0x4000B19
    public bool bigMapControlAniming;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CE2
    // RVA   : 0x8E3D40   Offset: 0x8E3140   Length: 0x116
    public static BigMapController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181db0bc8 + 184) + 16);
    }

    // Token : 0x6000CE3
    // RVA   : 0x8D7A10   Offset: 0x8D6E10   Length: 0x159
    private void Awake()
    {
        float fVar1;
        ulong uVar2;
        long lVar3;
        float fStack_34;
        byte[] local_28 = new byte[32];
        plVar6 = (int64 *)(*(int64 *)(DAT_181db0bc8 + 184) + 16);
        *plVar6 = this;
        il2cpp_internal(plVar6,this);
        if (this.bigmapSprite != null) {
          lVar3 = GameObject.GetComponent(this.bigmapSprite,DAT_181dc7848);
          if (lVar3 != null) {
            pfVar4 = (float *)BoxCollider.get_size(local_28,lVar3,0);
            fVar1 = *pfVar4;
            if (this.bigmapSprite != null) {
              lVar3 = GameObject.get_transform(this.bigmapSprite,0);
              if (lVar3 != null) {
                pfVar4 = (float *)Transform.get_localScale(local_28,lVar3,0);
                this.bigMapWidth = fVar1 * *pfVar4;
                if (this.bigmapSprite != null) {
                  lVar3 = GameObject.GetComponent(this.bigmapSprite,DAT_181dc7848);
                  if (lVar3 != null) {
                    puVar5 = (uint64 *)BoxCollider.get_size(local_28,lVar3,0);
                    uVar2 = *puVar5;
                    if (this.bigmapSprite != null) {
                      lVar3 = GameObject.get_transform(this.bigmapSprite,0);
                      if (lVar3 != null) {
                        lVar3 = Transform.get_localScale(local_28,lVar3,0);
                        fStack_34 = (float)((uint64)uVar2 >> 32);
                        this.bigMapHeight = fStack_34 * *(float *)(lVar3 + 4);
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

    // Token : 0x6000CE4
    // RVA   : 0x8D9190   Offset: 0x8D8590   Length: 0x190
    public GameObject FindBigMapNPC(HeroData targetHero)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        if (targetHero != null) {
          uVar4 = 0;
          if (*(char *)(targetHero + 0x3cc) == false) {
            lVar3 = this.bigmapNormalNpcIcons;
            if (lVar3 != null) {
              lVar5 = 32;
              while( true ) {
                if (lVar3.Count <= (int)uVar4) {
                  return 0;
                }
                if (lVar3 == null) break;
                if (lVar3.Count <= uVar4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar5 + lVar3._items);
                if ((lVar3 == null) || (lVar1 = GameObject.GetComponent(lVar3,DAT_181dc76b0)) == null)
                break;
                lVar3 = this.bigmapNormalNpcIcons;
                if (*(int64 *)(lVar1 + 24) == targetHero) goto LAB_1808d92e9;
                uVar4 = uVar4 + 1;
                lVar5 = lVar5 + 8;
                if (lVar3 == null) break;
              }
            }
          }
          else {
            lVar3 = this.bigmapTempNpcIcons;
            if (lVar3 != null) {
              lVar5 = 32;
              while( true ) {
                if (lVar3.Count <= (int)uVar4) {
                  return 0;
                }
                if (lVar3 == null) break;
                if (lVar3.Count <= uVar4) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar5 + lVar3._items);
                if ((lVar3 == null) || (lVar1 = GameObject.GetComponent(lVar3,DAT_181dc76b0)) == null)
                break;
                lVar3 = this.bigmapTempNpcIcons;
                if (*(int64 *)(lVar1 + 24) == targetHero) goto LAB_1808d92e9;
                uVar4 = uVar4 + 1;
                lVar5 = lVar5 + 8;
                if (lVar3 == null) break;
              }
            }
          }
        }
        LAB_1808d931b:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1808d92e9:
        if (lVar3 != null) {
          uVar2 = FUN_180002f80(lVar3,uVar4,DAT_181d89918);
          return uVar2;
        }
        goto LAB_1808d931b;
    }

    // Token : 0x6000CE5
    // RVA   : 0x8DBE10   Offset: 0x8DB210   Length: 0x18F9
    public void InitBigMap()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        bool cVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        ulong uVar13;
        float fVar14;
        uint uVar15;
        float fVar16;
        int[] local_res18 = new int[4];
        float local_218;
        float fStack_214;
        float local_210;
        ulong local_208;
        float local_200;
        uint8 local_1f8 [16];
        uint64 local_1e8;
        float local_1e0;
        uint64 local_1d8;
        float local_1d0;
        uint64 local_1c8;
        float local_1c0;
        uint64 local_1b8;
        uint64 uStack_1b0;
        uint32 local_1a8;
        uint32 uStack_1a4;
        int64 local_1a0;
        uint64 local_198;
        uint64 uStack_190;
        int64 local_188;
        uint64 local_180;
        uint64 uStack_178;
        uint64 local_170;
        uint64 local_168;
        uint32 local_160;
        uint64 local_158;
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint64 local_128;
        uint64 uStack_120;
        int64 local_118;
        uint64 local_f8;
        uint64 uStack_f0;
        uint8 local_e8 [16];
        uint8 local_d8 [176];
        local_1a0 = this;
        local_198 = 0;
        uStack_190 = 0;
        local_188 = 0;
        local_180 = 0;
        uStack_178 = 0;
        local_170 = 0;
        local_res18[0] = 0;
        lVar5 = GameObject.FindGameObjectWithTag("UICanvas",0);
        if ((lVar5 != null) && (lVar5 = GameObject.GetComponent(lVar5,DAT_181d72bc8)) != null) {
          puVar6 = (uint64 *)RectTransform.get_rect(&local_1b8,lVar5,0);
          local_f8 = *puVar6;
          uStack_f0 = puVar6[1];
          fVar14 = (float)FUN_18044e2b0(&local_f8,0);
          iVar2 = Screen.get_height(0);
          fVar14 = (fVar14 * 0.01) / (float)iVar2;
          iVar2 = Screen.get_height(0);
          this.rootHeight = (float)iVar2 * fVar14;
          iVar2 = Screen.get_width(0);
          this.rootWidth = (float)iVar2 * fVar14;
          uVar7 = il2cpp_internal(DAT_181d80de8);
          FUN_1808b1370(uVar7,DAT_181db9ba0);
          this.areaIcons = uVar7;
          uVar7 = il2cpp_internal(DAT_181d80de8);
          FUN_1808b1370(uVar7,DAT_181db9ba0);
          this.innIcons = uVar7;
          uVar7 = il2cpp_internal(DAT_181d80de8);
          FUN_1808b1370(uVar7,DAT_181db9ba0);
          this.resourcePoints = uVar7;
          uVar7 = il2cpp_internal(DAT_181d81468);
          FUN_1808b1370(uVar7,DAT_181dbd558);
          this.resourcePointControllers = uVar7;
          if (((*pStatics_2cc8 != 0) &&
              (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar5 = *(int64 *)(lVar5 + 48)) != null) {
            FUN_1817eb420(&local_1b8,lVar5,DAT_181d7c660);
            local_128 = local_1b8;
            uStack_120 = uStack_1b0;
            local_118 = CONCAT44(uStack_1a4,local_1a8);
            while (cVar1 = FUN_180c74f00(&local_128,DAT_181d89e68), lVar5 = local_118, cVar1) {
              if (this.bigmapRoot == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar8 = GameObject.get_transform(this.bigmapRoot,0);
              if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar8 = Transform.Find(lVar8,"Area",0);
              if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar7 = Component.get_gameObject(lVar8,0);
              if (*pStatics_2ee8 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar13 = *(uint64 *)(*pStatics_2ee8 + 88);
              lVar8 = GlobalData.AddChild(uVar7,uVar13,0);
              if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar9 = GameObject.get_transform(lVar8,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int64 *)(lVar5 + 64) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              puVar6 = (uint64 *)BigMapPos.ToVector3(local_1f8,*(int64 *)(lVar5 + 64),0);
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_208 = *puVar6;
              local_200 = *(float *)(puVar6 + 1);
              Transform.set_localPosition(lVar9,&local_208,0);
              lVar9 = GameObject.get_transform(lVar8,0);
              lVar10 = GameObject.get_transform(lVar8,0);
              if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              pfVar11 = (float *)Transform.get_localPosition(&local_1c8,lVar10,0);
              fVar14 = *pfVar11;
              lVar10 = GameObject.get_transform(lVar8,0);
              if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              puVar6 = (uint64 *)Transform.get_localPosition(&local_1d8,lVar10,0);
              local_1e8 = *puVar6;
              local_1e0 = *(float *)(puVar6 + 1);
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_1e8._4_4_ = (float)((uint64)local_1e8 >> 32);
              fStack_214 = local_1e8._4_4_;
              local_210 = 1.0;
              local_218 = fVar14;
              Transform.set_localPosition(lVar9,&local_218,0);
              lVar9 = GameObject.GetComponent(lVar8,DAT_181dc7160);
              if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              *(int64 *)(lVar9 + 24) = lVar5;
              if (*(int *)(pStatics_3d40 + 8) == 1) {
                lVar9 = *(int64 *)(pStatics_3d40 + 24);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = FUN_18182a3a0(lVar9,*(uint32 *)(lVar5 + 16),DAT_181d8f398);
                if (!(cVar1))
                {
                  GameObject.SetActive(lVar8,0,0);
                  }
                  else {
                }
                lVar8 = GameObject.GetComponent(lVar8,DAT_181dc7160);
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                AreaIconController.Init(lVar8,0);
              }
              if (this.areaIcons == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_1808ab370(this.areaIcons,*(uint32 *)(lVar5 + 16));
            }
            ZhSegment.Initialize(&local_128,DAT_181d89de8);
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 56)) != null) {
              FUN_1817eb420(&local_1b8,lVar5,DAT_181d8eb98);
              local_198 = local_1b8;
              uStack_190 = uStack_1b0;
              local_188 = CONCAT44(uStack_1a4,local_1a8);
              while (cVar1 = FUN_180c74f00(&local_198,DAT_181d8d668), lVar5 = local_188, cVar1) {
                if (this.bigmapRoot == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar8 = GameObject.get_transform(this.bigmapRoot,0);
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar8 = Transform.Find(lVar8,"Inn",0);
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar7 = Component.get_gameObject(lVar8,0);
                if (*pStatics_2ee8 == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar13 = *(uint64 *)(*pStatics_2ee8 + 112);
                lVar8 = GlobalData.AddChild(uVar7,uVar13,0);
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar9 = GameObject.get_transform(lVar8,0);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar5 + 48) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar6 = (uint64 *)BigMapPos.ToVector3(local_1f8,*(int64 *)(lVar5 + 48),0);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_208 = *puVar6;
                local_200 = *(float *)(puVar6 + 1);
                Transform.set_localPosition(lVar9,&local_208,0);
                lVar9 = GameObject.get_transform(lVar8,0);
                lVar10 = GameObject.get_transform(lVar8,0);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                pfVar11 = (float *)Transform.get_localPosition(&local_1c8,lVar10,0);
                fVar14 = *pfVar11;
                lVar10 = GameObject.get_transform(lVar8,0);
                if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                puVar6 = (uint64 *)Transform.get_localPosition(&local_1d8,lVar10,0);
                local_1e8 = *puVar6;
                local_1e0 = *(float *)(puVar6 + 1);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_1e8._4_4_ = (float)((uint64)local_1e8 >> 32);
                fStack_214 = local_1e8._4_4_;
                local_210 = 1.0;
                local_218 = fVar14;
                Transform.set_localPosition(lVar9,&local_218,0);
                lVar9 = GameObject.GetComponent(lVar8,DAT_181d71f90);
                if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                *(int64 *)(lVar9 + 24) = lVar5;
                if (*(int *)(pStatics_3d40 + 8) == 1) {
                  lVar9 = *(int64 *)(pStatics_3d40 + 40);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  cVar1 = FUN_18182a3a0(lVar9,*(uint32 *)(lVar5 + 16),DAT_181d8f398);
                  if (!(cVar1))
                  {
                    GameObject.SetActive(lVar8,0,0);
                    }
                    else {
                  }
                  lVar8 = GameObject.GetComponent(lVar8,DAT_181d71f90);
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  InnIconController.Init(lVar8,0);
                }
                if (this.innIcons == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_1808ab370(this.innIcons,*(uint32 *)(lVar5 + 16));
              }
              ZhSegment.Initialize(&local_198,DAT_181d8d5e8);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                 (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 64)) != null) {
                FUN_1817eb420(&local_1b8,lVar5,DAT_181d9fa78);
                local_180 = local_1b8;
                uStack_178 = uStack_1b0;
                local_170 = CONCAT44(uStack_1a4,local_1a8);
                while (cVar1 = FUN_180c74f00(&local_180,DAT_181d90b68), lVar5 = local_170, cVar1)
                {
                  if (this.bigmapRoot == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar8 = GameObject.get_transform(this.bigmapRoot,0);
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar8 = Transform.Find(lVar8,"ResourcePoint",0);
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar7 = Component.get_gameObject(lVar8,0);
                  if (*pStatics_2ee8 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar13 = *(uint64 *)(*pStatics_2ee8 + 96);
                  lVar8 = GlobalData.AddChild(uVar7,uVar13,0);
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar9 = GameObject.get_transform(lVar8,0);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(lVar5 + 40) == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  puVar6 = (uint64 *)BigMapPos.ToVector3(local_e8,*(int64 *)(lVar5 + 40),0);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_168 = *puVar6;
                  local_160 = *(uint32 *)(puVar6 + 1);
                  Transform.set_localPosition(lVar9,&local_168,0);
                  lVar9 = GameObject.get_transform(lVar8,0);
                  lVar10 = GameObject.get_transform(lVar8,0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  puVar12 = (uint32 *)Transform.get_localPosition(local_d8,lVar10,0);
                  uVar15 = *puVar12;
                  lVar10 = GameObject.get_transform(lVar8,0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  puVar6 = (uint64 *)Transform.get_localPosition(local_148,lVar10,0);
                  local_158 = *puVar6;
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_158._4_4_ = (uint32)((uint64)local_158 >> 32);
                  local_208 = CONCAT44(local_158._4_4_,uVar15);
                  local_200 = 1.0;
                  Transform.set_localPosition(lVar9,&local_208,0);
                  lVar9 = GameObject.GetComponent(lVar8,DAT_181d72ef8);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  *(int64 *)(lVar9 + 24) = lVar5;
                  lVar9 = GameObject.get_transform(lVar8,0);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar9 = Transform.Find(lVar9,"Line",0);
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar9 = Component.GetComponent(lVar9,DAT_181d94860);
                  if (this.areaIcons == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar10 = FUN_1817d9e10(this.areaIcons,*(uint32 *)(lVar5 + 52),
                                         DAT_181db9ed0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar10 = GameObject.get_transform(lVar10,0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  puVar6 = (uint64 *)Transform.get_localPosition(local_138,lVar10,0);
                  local_1e8 = *puVar6;
                  local_1e0 = *(float *)(puVar6 + 1);
                  lVar10 = GameObject.get_transform(lVar8,0);
                  if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  puVar6 = (uint64 *)Transform.get_localPosition(&local_1b8,lVar10,0);
                  local_1d8 = *puVar6;
                  local_1d0 = *(float *)(puVar6 + 1);
                  local_218 = (float)local_1e8 - (float)local_1d8;
                  fStack_214 = local_1e8._4_4_ - (float)((uint64)local_1d8 >> 32);
                  local_210 = local_1e0 - local_1d0;
                  if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_1c8 = CONCAT44(fStack_214,local_218);
                  local_1c0 = local_210;
                  LineRenderer.SetPosition(lVar9,1,&local_1c8);
                  if (this.resourcePoints == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_1808ab370(this.resourcePoints,*(uint32 *)(lVar5 + 16),lVar8,
                                DAT_181db9c28);
                  if (this.resourcePointControllers == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_1808ab370(this.resourcePointControllers,*(uint32 *)(lVar5 + 16));
                  if (*(int *)(pStatics_3d40 + 8) == 1) {
                    lVar9 = *(int64 *)(pStatics_3d40 + 24);
                    if (lVar9 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    cVar1 = FUN_18182a3a0(lVar9,*(uint32 *)(lVar5 + 52));
                    if (!cVar1) {
                      GameObject.SetActive(lVar8,0);
                    }
                  }
                }
                ZhSegment.Initialize(&local_180,DAT_181d90ae8);
                iVar2 = 0;
                lVar5 = this.bigmapRoot;
                if (lVar5 != null) {
                  while( true ) {
                    lVar5 = GameObject.get_transform(lVar5,0);
                    if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Tree",0)) == null)
                    goto LAB_1808dd704;
                    iVar3 = Transform.get_childCount(lVar5,0);
                    if (iVar3 <= iVar2) break;
                    iVar3 = 0;
                    while( true ) {
                      if ((((this.bigmapRoot == null) ||
                           (lVar5 = GameObject.get_transform(this.bigmapRoot,0), lVar5 == null
                           )) || (lVar5 = Transform.Find(lVar5,"Tree")) == null) ||
                         (lVar5 = Transform.GetChild(lVar5)) == null) goto LAB_1808dd704;
                      iVar4 = Transform.get_childCount(lVar5);
                      lVar5 = this.bigmapRoot;
                      if (iVar4 <= iVar3) break;
                      if ((((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                          ((lVar5 = Transform.Find(lVar5,"Tree"), lVar5 == null ||
                           ((lVar5 = Transform.GetChild(lVar5,iVar2), lVar5 == null ||
                            (lVar5 = Transform.GetChild(lVar5,iVar3)) == null))))) ||
                         (lVar5 = Component.get_gameObject(lVar5,0)) == null) goto LAB_1808dd704;
                      lVar8 = GameObject.get_transform(lVar5,0);
                      lVar9 = GameObject.get_transform(lVar5,0);
                      if (lVar9 == null) goto LAB_1808dd704;
                      puVar12 = (uint32 *)Transform.get_localPosition(&local_1b8,lVar9);
                      uVar15 = *puVar12;
                      lVar9 = GameObject.get_transform(lVar5,0);
                      if (lVar9 == null) goto LAB_1808dd704;
                      puVar6 = (uint64 *)Transform.get_localPosition(local_138,lVar9);
                      local_1d8 = *puVar6;
                      local_1d0 = *(float *)(puVar6 + 1);
                      lVar5 = GameObject.get_transform(lVar5,0);
                      if (lVar5 == null) goto LAB_1808dd704;
                      puVar6 = (uint64 *)Transform.get_localPosition(local_148,lVar5);
                      local_1c8 = *puVar6;
                      local_1c0 = *(float *)(puVar6 + 1);
                      if (lVar8 == null) goto LAB_1808dd704;
                      local_208 = CONCAT44(local_1d8._4_4_,uVar15);
                      local_200 = local_1c8._4_4_ / *(float *)(*(int64 *)(DAT_181db0bc8 + 184) + 8);
                      Transform.set_localPosition(lVar8);
                      iVar3 = iVar3 + 1;
                    }
                    iVar2 = iVar2 + 1;
                    if (lVar5 == null) goto LAB_1808dd704;
                  }
                  lVar5 = FUN_18046c0a0(0);
                  if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
                    uVar7 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                    BigMapController.CreateBigMapNpc(this,uVar7,0);
                    if (*(int *)(pStatics_3d40 + 8) != 1) {
                      return;
                    }
                    if ((((this.bigmapRoot != null) &&
                         (lVar5 = GameObject.get_transform(this.bigmapRoot,0)) != null)
                        && (lVar5 = Transform.Find(lVar5,"CoverClouds",0)) != null) &&
                       (lVar5 = Component.get_gameObject(lVar5,0)) != null) {
                      GameObject.SetActive(lVar5,1,0);
                      local_res18[0] = 0;
                      lVar5 = this.bigmapRoot;
                      if (lVar5 != null) goto LAB_1808dd182;
                    }
                  }
                }
              }
            }
          }
        }
        LAB_1808dd704:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1808dd182:
        lVar5 = GameObject.get_transform(lVar5,0);
        if (lVar5 == null) goto LAB_1808dd704;
        lVar5 = Transform.Find(lVar5,"CoverClouds",0);
        uVar7 = Int32.ToString(local_res18,0);
        if (lVar5 == null) goto LAB_1808dd704;
        uVar7 = Transform.Find(lVar5,uVar7,0);
        cVar1 = Object.op_Inequality(uVar7,0,0);
        if (!cVar1) {
          return;
        }
        if ((this.bigmapRoot == null) ||
           (lVar5 = GameObject.get_transform(this.bigmapRoot,0)) == null)
        goto LAB_1808dd704;
        lVar5 = Transform.Find(lVar5,"CoverClouds",0);
        uVar7 = Int32.ToString(local_res18,0);
        if (lVar5 == null) goto LAB_1808dd704;
        uVar7 = Transform.Find(lVar5,uVar7,0);
        if ((this.bigmapRoot == null) ||
           (lVar5 = GameObject.get_transform(this.bigmapRoot,0)) == null)
        goto LAB_1808dd704;
        lVar5 = Transform.Find(lVar5,"CoverClouds",0);
        uVar13 = Int32.ToString(local_res18,0);
        if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,uVar13,0)) == null) goto LAB_1808dd704;
        puVar6 = (uint64 *)Transform.get_localScale(&local_1b8,lVar5,0);
        local_1c0 = *(float *)(puVar6 + 1);
        local_218 = (float)*puVar6 * 0.95;
        fStack_214 = (float)((uint64)*puVar6 >> 32) * 0.95;
        local_210 = local_1c0 * 0.95;
        uVar15 = GlobalData.RandomRange();
        local_1d8 = CONCAT44(fStack_214,local_218);
        local_1d0 = local_210;
        uVar7 = ShortcutExtensions.DOScale(uVar7,&local_1d8,uVar15,0);
        TweenSettingsExtensions.SetLoops(uVar7,0xffffffff,1,DAT_181dc1330);
        if ((this.bigmapRoot == null) ||
           (lVar5 = GameObject.get_transform(this.bigmapRoot,0)) == null)
        goto LAB_1808dd704;
        lVar5 = Transform.Find(lVar5,"CoverClouds",0);
        uVar7 = Int32.ToString(local_res18,0);
        if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,uVar7,0)) == null) goto LAB_1808dd704;
        uVar7 = Component.GetComponent(lVar5,DAT_181d95de0);
        if ((this.bigmapRoot == null) ||
           (lVar5 = GameObject.get_transform(this.bigmapRoot,0)) == null)
        goto LAB_1808dd704;
        lVar5 = Transform.Find(lVar5,"CoverClouds",0);
        uVar13 = Int32.ToString(local_res18,0);
        if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,uVar13,0)) == null) goto LAB_1808dd704;
        pfVar11 = (float *)Transform.get_localPosition(local_138,lVar5,0);
        fVar14 = (float)FUN_1801f8ab0(*pfVar11 + 10.0);
        if ((this.bigmapRoot == null) ||
           (lVar5 = GameObject.get_transform(this.bigmapRoot,0)) == null)
        goto LAB_1808dd704;
        lVar5 = Transform.Find(lVar5,"CoverClouds",0);
        uVar13 = Int32.ToString(local_res18,0);
        if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,uVar13,0)) == null) goto LAB_1808dd704;
        lVar5 = Transform.get_localPosition(local_148,lVar5,0);
        fVar16 = (float)FUN_1801f8ab0(*(float *)(lVar5 + 4) + 3.0);
        if (fVar16 + fVar14 < 0.0) {
          FUN_1801f9ff4();
        }
        Mathf.Min();
        GlobalData.RandomRange();
        uVar7 = DOTweenModuleSprite.DOFade(uVar7);
        TweenSettingsExtensions.SetLoops(uVar7);
        local_res18[0] = local_res18[0] + 1;
        lVar5 = this.bigmapRoot;
        if (lVar5 == null) goto LAB_1808dd704;
        goto LAB_1808dd182;
    }

    // Token : 0x6000CE6
    // RVA   : 0x8E1890   Offset: 0x8E0C90   Length: 0x144
    public void RecreatAllBigMapRandomEvent()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        ulong uVar2;
        int iVar3;
        iVar3 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar1 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 96)) == null) break;
          if (*(int *)(lVar1 + 24) <= iVar3) {
            return;
          }
          lVar1 = FUN_18046c0a0(0);
          if (((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) ||
             (lVar1 = *(int64 *)(*(int64 *)(lVar1 + 32) + 96)) == null) break;
          uVar2 = FUN_180002f80(lVar1,iVar3,DAT_181d85e20);
          BigMapController.CreateBigMapRandomEventIcon(this,uVar2,0);
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x6000CE7
    // RVA   : 0x8E19E0   Offset: 0x8E0DE0   Length: 0x594
    public void RecreateAllBigMapHeroIcon()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 1;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar2 = *(int64 *)(lVar2 + 80)) == null) break;
          if (*(int *)(lVar2 + 24) <= iVar4) {
            iVar4 = 0;
            goto LAB_1808e1cd3;
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
          lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
          if (lVar2 != null) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
            lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
            if (lVar2 == null) break;
            if (*(char *)(lVar2 + 96) == false) {
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
              lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
              if (lVar2 == null) break;
              cVar1 = HeroData.HaveArea(lVar2,0);
              if (!cVar1) {
                lVar2 = FUN_18046c0a0(0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
                if (lVar2 == null) break;
                if (*(char *)(lVar2 + 0x2f0) == false) {
                  lVar2 = FUN_18046c0a0(0);
                  if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                     (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 80)) == null) break;
                  uVar3 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
                  BigMapController.CreateBigMapNpc(this,uVar3,0);
                }
              }
            }
          }
          iVar4 = iVar4 + 1;
        }
        LAB_1808e1f6f:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1808e1cd3:
        if (((*pStatics == 0) ||
            (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar2 = *(int64 *)(lVar2 + 88)) == null) goto LAB_1808e1f6f;
        if (*(int *)(lVar2 + 24) <= iVar4) {
          return;
        }
        lVar2 = FUN_18046c0a0(0);
        if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
           (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 88)) == null) goto LAB_1808e1f6f;
        lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
        if (lVar2 != null) {
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 88)) == null) goto LAB_1808e1f6f;
          lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
          if (lVar2 == null) goto LAB_1808e1f6f;
          if (*(char *)(lVar2 + 96) == false) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 88)) == null)
            goto LAB_1808e1f6f;
            lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
            if (lVar2 == null) goto LAB_1808e1f6f;
            cVar1 = HeroData.HaveArea(lVar2,0);
            if (!cVar1) {
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 88)) == null)
              goto LAB_1808e1f6f;
              lVar2 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
              if (lVar2 == null) goto LAB_1808e1f6f;
              if (*(char *)(lVar2 + 0x2f0) == false) {
                lVar2 = FUN_18046c0a0(0);
                if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 32) + 88)) == null)
                goto LAB_1808e1f6f;
                uVar3 = FUN_180002f80(lVar2,iVar4,DAT_181d8bb98);
                BigMapController.CreateBigMapNpc(this,uVar3,0);
              }
            }
          }
        }
        iVar4 = iVar4 + 1;
        goto LAB_1808e1cd3;
    }

    // Token : 0x6000CE8
    // RVA   : 0x8DB3C0   Offset: 0x8DA7C0   Length: 0x3E5
    public BigMapPos GetAreaDirectionRandomPos()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        int64 BigMapController.GetAreaDirectionRandomPos
                         (uint64 this,int64 param_2,int param_3)
        {
        int64 lVar1;
        int64 lVar2;
        int iVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        var lVar2 = new c.DisplayClass9_0(0);
        lVar1 = *(int64 *)(pStatics + 0x430);
        if ((param_2 == 0) || (lVar1 == null)) throw; // [null/range check failed]
        if (*(uint32 *)(lVar1 + 24) <= *(uint32 *)(param_2 + 72)) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(pStatics + 0x430);
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(uint32 *)(lVar1 + 24) <= *(uint32 *)(param_2 + 72)) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        fVar5 = 0.0;
        fVar6 = 0.0;
        GlobalData.RandomRange();
        fVar4 = (float)GlobalData.RandomRange();
        if (param_3 == 0) {
          fVar5 = (float)FUN_1801e7370();
          fVar5 = fVar5 * fVar4;
        LAB_1808db307:
          fVar6 = (float)Random.get_value(0);
          iVar3 = -1;
          if (fVar6 < 0.5) {
            iVar3 = 1;
          }
          fVar6 = (float)FUN_1801e7e70();
          fVar6 = fVar6 * (float)iVar3 * fVar4;
        }
        else if (param_3 == 1) {
          fVar5 = (float)Random.get_value(0);
          iVar3 = -1;
          if (fVar5 < 0.5) {
            iVar3 = 1;
          }
          fVar5 = (float)FUN_1801e7e70();
          fVar5 = fVar5 * (float)iVar3 * fVar4;
          fVar6 = (float)FUN_1801e7370();
          fVar6 = fVar6 * -fVar4;
        }
        else {
          if (param_3 == 2) {
            fVar5 = (float)FUN_1801e7370();
            fVar5 = fVar5 * -fVar4;
            goto LAB_1808db307;
          }
          if (param_3 == 3) {
            fVar5 = (float)Random.get_value(0);
            iVar3 = -1;
            if (fVar5 < 0.5) {
              iVar3 = 1;
            }
            fVar5 = (float)FUN_1801e7e70();
            fVar5 = fVar5 * (float)iVar3 * fVar4;
            fVar6 = (float)FUN_1801e7370();
            fVar6 = fVar6 * fVar4;
          }
        }
        if ((*(int64 *)(param_2 + 64) != 0) && (lVar2 != null)) {
          *(float *)(lVar2 + 16) = fVar5 + *(float *)(*(int64 *)(param_2 + 64) + 16);
          if (*(int64 *)(param_2 + 64) != 0) {
            *(float *)(lVar2 + 20) = fVar6 + *(float *)(*(int64 *)(param_2 + 64) + 20);
            return lVar2;
          }
        }
    }

    // Token : 0x6000CE9
    // RVA   : 0x8DB020   Offset: 0x8DA420   Length: 0x39F
    public BigMapPos GetAreaDirectionRandomPos(AreaData targetArea, int direction, float baseMinRange, float baseMaxRange, float areaSafeRangeRate, bool noBorder)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        int64 BigMapController.GetAreaDirectionRandomPos
                         (uint64 this,int64 targetArea,int direction)
        {
        int64 lVar1;
        int64 lVar2;
        int iVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        var lVar2 = new c.DisplayClass9_0(0);
        lVar1 = *(int64 *)(pStatics + 0x430);
        if ((targetArea == null) || (lVar1 == null)) throw; // [null/range check failed]
        if (*(uint32 *)(lVar1 + 24) <= *(uint32 *)(targetArea + 72)) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(pStatics + 0x430);
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(uint32 *)(lVar1 + 24) <= *(uint32 *)(targetArea + 72)) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        fVar5 = 0.0;
        fVar6 = 0.0;
        GlobalData.RandomRange();
        fVar4 = (float)GlobalData.RandomRange();
        if (direction == null) {
          fVar5 = (float)FUN_1801e7370();
          fVar5 = fVar5 * fVar4;
        LAB_1808db307:
          fVar6 = (float)Random.get_value(0);
          iVar3 = -1;
          if (fVar6 < 0.5) {
            iVar3 = 1;
          }
          fVar6 = (float)FUN_1801e7e70();
          fVar6 = fVar6 * (float)iVar3 * fVar4;
        }
        else if (direction == 1) {
          fVar5 = (float)Random.get_value(0);
          iVar3 = -1;
          if (fVar5 < 0.5) {
            iVar3 = 1;
          }
          fVar5 = (float)FUN_1801e7e70();
          fVar5 = fVar5 * (float)iVar3 * fVar4;
          fVar6 = (float)FUN_1801e7370();
          fVar6 = fVar6 * -fVar4;
        }
        else {
          if (direction == 2) {
            fVar5 = (float)FUN_1801e7370();
            fVar5 = fVar5 * -fVar4;
            goto LAB_1808db307;
          }
          if (direction == 3) {
            fVar5 = (float)Random.get_value(0);
            iVar3 = -1;
            if (fVar5 < 0.5) {
              iVar3 = 1;
            }
            fVar5 = (float)FUN_1801e7e70();
            fVar5 = fVar5 * (float)iVar3 * fVar4;
            fVar6 = (float)FUN_1801e7370();
            fVar6 = fVar6 * fVar4;
          }
        }
        if ((*(int64 *)(targetArea + 64) != 0) && (lVar2 != null)) {
          *(float *)(lVar2 + 16) = fVar5 + *(float *)(*(int64 *)(targetArea + 64) + 16);
          if (*(int64 *)(targetArea + 64) != 0) {
            *(float *)(lVar2 + 20) = fVar6 + *(float *)(*(int64 *)(targetArea + 64) + 20);
            return lVar2;
          }
        }
    }

    // Token : 0x6000CEA
    // RVA   : 0x8DA990   Offset: 0x8D9D90   Length: 0x68B
    public BigMapPos GetAreaDirectionRandomPosLimitDistance(AreaData targetArea, int direction, float minDistance, float baseMinRange, float baseMaxRange, float areaSafeRangeRate, bool noBorder, bool useTimeScale)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int64 BigMapController.GetAreaDirectionRandomPosLimitDistance
                         (uint64 this,int64 targetArea,uint32 direction,float minDistance,
                         float baseMinRange,float baseMaxRange,uint32 areaSafeRangeRate,uint8 noBorder,char useTimeScale)
        {
        uint64 uVar1;
        char cVar2;
        uint32 uVar3;
        int64 lVar4;
        int64 lVar5;
        uint64 *puVar6;
        int iVar7;
        int iVar8;
        float fVar9;
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint8 local_78 [80];
        if (!useTimeScale) {
        LAB_1808dabe4:
          lVar4 = BigMapController.GetAreaDirectionRandomPos
                            (this,targetArea,direction,baseMinRange,baseMaxRange,areaSafeRangeRate,noBorder,0);
          if (minDistance <= 0.0) {
            return lVar4;
          }
          iVar8 = 20;
        LAB_1808dac40:
          if (iVar8 < 1) {
            return lVar4;
          }
          iVar8 = iVar8 + -1;
          iVar7 = 0;
          do {
            if ((targetArea == null) || (*(int64 *)(targetArea + 168) == 0)) goto LAB_1808db016;
            if (*(int *)(*(int64 *)(targetArea + 168) + 24) <= iVar7) {
              iVar7 = 0;
              goto LAB_1808dadf0;
            }
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) goto LAB_1808db016;
            lVar5 = *(int64 *)(lVar5 + 32);
            if ((((*(int64 *)(targetArea + 168) == 0) ||
                 (uVar3 = FUN_1800d6760(*(int64 *)(targetArea + 168),iVar7,DAT_181d8fa18), lVar5 == null))
                || (lVar5 = WorldData.GetResourcePoint(lVar5,uVar3,0)) == null) ||
               (*(int64 *)(lVar5 + 40) == 0)) goto LAB_1808db016;
            cVar2 = BigMapPos.IsZero(*(int64 *)(lVar5 + 40),0);
            if (!cVar2) {
              lVar5 = FUN_18046c0a0(0);
              if (lVar5 == null) goto LAB_1808db016;
              lVar5 = *(int64 *)(lVar5 + 32);
              if (((*(int64 *)(targetArea + 168) == 0) ||
                  (uVar3 = FUN_1800d6760(*(int64 *)(targetArea + 168),iVar7,DAT_181d8fa18), lVar5 == null))
                 || ((lVar5 = WorldData.GetResourcePoint(lVar5,uVar3,0), lVar5 == null ||
                     (*(int64 *)(lVar5 + 40) == 0)))) goto LAB_1808db016;
              puVar6 = (uint64 *)BigMapPos.ToVector3(local_a8,*(int64 *)(lVar5 + 40),0);
              uVar1 = *puVar6;
              if (lVar4 == null) goto LAB_1808db016;
              puVar6 = (uint64 *)BigMapPos.ToVector3(local_98,lVar4,0);
              fVar9 = (float)Vector2.Distance(uVar1,*puVar6,0);
              if (fVar9 < minDistance) goto LAB_1808daf87;
            }
            iVar7 = iVar7 + 1;
          } while( true );
        }
        if (((*pStatics != 0) &&
            (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar4 = *(int64 *)(lVar4 + 168)) != null) {
          fVar9 = (float)Mathf.Min(0x3f800000,(float)(*(int *)(lVar4 + 16) + -1) * 0.02 + 0.9,0);
          baseMinRange = baseMinRange * fVar9;
          if (((*pStatics != 0) &&
              (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar4 = *(int64 *)(lVar4 + 168)) != null) {
            fVar9 = (float)Mathf.Min(0x3f800000,(float)(*(int *)(lVar4 + 16) + -1) * 0.04 + 0.8,0);
            baseMaxRange = baseMaxRange * fVar9;
            goto LAB_1808dabe4;
          }
        }
        LAB_1808db016:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1808dadf0:
        lVar5 = FUN_18046c0a0(0);
        if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
           (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 96)) == null) goto LAB_1808db016;
        if (*(int *)(lVar5 + 24) <= iVar7) {
          return lVar4;
        }
        lVar5 = FUN_18046c0a0(0);
        if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
           ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 96), lVar5 == null ||
            (lVar5 = FUN_180002f80(lVar5,iVar7,DAT_181d85e20)) == null))) goto LAB_1808db016;
        if (*(int *)(lVar5 + 88) == *(int *)(targetArea + 16)) {
          lVar5 = FUN_18046c0a0(0);
          if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
              (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 96)) == null) ||
             ((lVar5 = FUN_180002f80(lVar5,iVar7,DAT_181d85e20), lVar5 == null ||
              (*(int64 *)(lVar5 + 80) == 0)))) goto LAB_1808db016;
          puVar6 = (uint64 *)BigMapPos.ToVector3(local_88,*(int64 *)(lVar5 + 80),0);
          uVar1 = *puVar6;
          if (lVar4 == null) goto LAB_1808db016;
          puVar6 = (uint64 *)BigMapPos.ToVector3(local_78,lVar4,0);
          fVar9 = (float)Vector2.Distance(uVar1,*puVar6,0);
          if (fVar9 < minDistance) goto LAB_1808daf87;
        }
        iVar7 = iVar7 + 1;
        goto LAB_1808dadf0;
        LAB_1808daf87:
        lVar4 = BigMapController.GetAreaDirectionRandomPos
                          (this,targetArea,direction,baseMinRange,baseMaxRange,areaSafeRangeRate,noBorder,0);
        goto LAB_1808dac40;
    }

    // Token : 0x6000CEB
    // RVA   : 0x8DBBE0   Offset: 0x8DAFE0   Length: 0x22E
    public int GetNearAreaID(BigMapPos targetPos)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        bool cVar2;
        uint uVar3;
        float fVar4;
        float fVar5;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        int64 local_48;
        uint32 local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        int64 local_30;
        uVar3 = 0xffffffff;
        fVar5 = -1.0;
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 48)) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        FUN_1817eb420(&local_40,lVar1,DAT_181d7c660);
        local_58 = local_40;
        uStack_54 = uStack_3c;
        uStack_50 = uStack_38;
        uStack_4c = uStack_34;
        local_48 = local_30;
        LAB_1808dbd22:
        cVar2 = FUN_180c74f00(&local_58,DAT_181d89e68);
        lVar1 = local_48;
        if (!cVar2) {
          ZhSegment.Initialize(&local_58,DAT_181d89de8);
          return uVar3;
        }
        if (fVar5 != -1.0) goto LAB_1808dbd43;
        goto LAB_1808dbd69;
        LAB_1808dbd43:
        if (local_48 == 0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (targetPos == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        fVar4 = (float)BigMapPos.Distance(targetPos,*(uint64 *)(local_48 + 64),0);
        if (fVar4 < fVar5) {
        LAB_1808dbd69:
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = *(uint32 *)(lVar1 + 16);
          if (targetPos == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)BigMapPos.Distance(targetPos,*(uint64 *)(lVar1 + 64),0);
        }
        goto LAB_1808dbd22;
    }

    // Token : 0x6000CEC
    // RVA   : 0x8DBA80   Offset: 0x8DAE80   Length: 0x155
    public int GetNearAreaDecoration(BigMapPos targetPos)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        ulong uVar1;
        long lVar2;
        uVar1 = BigMapController.GetNearAreaID(this,targetPos,0);
        if ((int)uVar1 == -1) {
          return uVar1;
        }
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.GetArea(lVar2,uVar1 & 0xffffffff,0);
          if (lVar2 != null) {
            lVar2 = BigMapPos.op_Subtraction(targetPos,*(uint64 *)(lVar2 + 64),0);
            if (lVar2 != null) {
              if (ABS(*(float *)(lVar2 + 16)) < ABS(*(float *)(lVar2 + 20))) {
                uVar1 = 3;
                if (*(float *)(lVar2 + 20) < 0.0) {
                  uVar1 = 1;
                }
                return uVar1;
              }
              uVar1 = 0;
              if (*(float *)(lVar2 + 16) < 0.0) {
                uVar1 = 2;
              }
              return uVar1;
            }
          }
        }
    }

    // Token : 0x6000CED
    // RVA   : 0x8DB7B0   Offset: 0x8DABB0   Length: 0x2C9
    public string GetBigMapPosDescribe(BigMapPos targetPos)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        float fVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        uint uVar8;
        if (*pStatics != 0) {
          lVar5 = *(int64 *)(*pStatics + 32);
          uVar2 = BigMapController.GetNearAreaID(this,targetPos,0);
          if (lVar5 != null) {
            lVar5 = WorldData.GetArea(lVar5,uVar2,0);
            if (lVar5 != null) {
              uVar6 = AreaData.GetAreaName(lVar5,0);
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3c8);
              iVar3 = BigMapController.GetNearAreaID(this,targetPos,0);
              if (iVar3 == -1) {
                uVar8 = 0xffffffff;
              }
              else {
                if ((*pStatics == 0) ||
                   (lVar7 = *(int64 *)(*pStatics + 32)) == null)
                throw; // [null/range check failed]
                lVar7 = WorldData.GetArea(lVar7,iVar3,0);
                if (lVar7 == null) throw; // [null/range check failed]
                lVar7 = BigMapPos.op_Subtraction(targetPos,*(uint64 *)(lVar7 + 64),0);
                if (lVar7 == null) throw; // [null/range check failed]
                fVar1 = *(float *)(lVar7 + 16);
                if (ABS(*(float *)(lVar7 + 20)) <= ABS(fVar1)) {
                  uVar8 = 0;
                  uVar4 = 2;
                }
                else {
                  uVar8 = 3;
                  uVar4 = 1;
                  fVar1 = *(float *)(lVar7 + 20);
                }
                if (fVar1 < 0.0) {
                  uVar8 = uVar4;
                }
              }
              if (lVar5 != null) {
                if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                String.Concat(uVar6,*(uint64 *)
                                      (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar8 * 8),
                               "方",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000CEE
    // RVA   : 0x8DD710   Offset: 0x8DCB10   Length: 0x167
    public void LimitBigMapNpcPos(HeroData heroData)
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        if ((heroData == null) || (lVar2 = *(int64 *)(heroData + 200)) == null) throw; // [null/range check failed]
        if ((this.bigMapWidth * 50.0 < *(float *)(lVar2 + 16)) ||
           (*(float *)(lVar2 + 16) < this.bigMapWidth * -50.0)) {
        LAB_1808dd7be:
          uVar1 = String.Format("{0} Out of Map",*(uint64 *)(heroData + 104),0);
          Debug.Log(uVar1,0);
          lVar2 = *(int64 *)(heroData + 200);
        }
        else if ((this.bigMapHeight * 50.0 < *(float *)(lVar2 + 20)) ||
                (*(float *)(lVar2 + 20) < this.bigMapHeight * -50.0)) goto LAB_1808dd7be;
        if (lVar2 != null) {
          uVar3 = FUN_1810e36c0(*(uint32 *)(lVar2 + 16),this.bigMapWidth * -50.0,
                                this.bigMapWidth * 50.0,0);
          *(uint32 *)(lVar2 + 16) = uVar3;
          lVar2 = *(int64 *)(heroData + 200);
          if (lVar2 != null) {
            uVar3 = FUN_1810e36c0(*(uint32 *)(lVar2 + 20),this.bigMapHeight * -50.0,
                                  this.bigMapHeight * 50.0,0);
            *(uint32 *)(lVar2 + 20) = uVar3;
            return;
          }
        }
    }

    // Token : 0x6000CEF
    // RVA   : 0x8D8130   Offset: 0x8D7530   Length: 0x967
    public void CreateBigMapNpc(HeroData heroData)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        float fVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        long lVar8;
        uint uVar9;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        ulong local_48;
        ulong uStack_40;
        if ((heroData == null) || (lVar5 = *(int64 *)(heroData + 200)) == null) throw; // [null/range check failed]
        if ((this.bigMapWidth * 50.0 < *(float *)(lVar5 + 16)) ||
           (*(float *)(lVar5 + 16) < this.bigMapWidth * -50.0)) {
        LAB_1808d8285:
          uVar4 = String.Format("{0} Out of Map",*(uint64 *)(heroData + 104),0);
          Debug.Log(uVar4,0);
          lVar5 = *(int64 *)(heroData + 200);
        }
        else if ((this.bigMapHeight * 50.0 < *(float *)(lVar5 + 20)) ||
                (*(float *)(lVar5 + 20) < this.bigMapHeight * -50.0)) goto LAB_1808d8285;
        if (lVar5 != null) {
          uVar9 = FUN_1810e36c0(*(uint32 *)(lVar5 + 16),this.bigMapWidth * -50.0,
                                this.bigMapWidth * 50.0,0);
          *(uint32 *)(lVar5 + 16) = uVar9;
          lVar5 = *(int64 *)(heroData + 200);
          if (lVar5 != null) {
            uVar9 = FUN_1810e36c0(*(uint32 *)(lVar5 + 20),this.bigMapHeight * -50.0,
                                  this.bigMapHeight * 50.0,0);
            *(uint32 *)(lVar5 + 20) = uVar9;
            if (this.bigmapRoot != null) {
              lVar5 = GameObject.get_transform(this.bigmapRoot,0);
              if (lVar5 != null) {
                lVar5 = Transform.Find(lVar5,"Hero",0);
                if (lVar5 != null) {
                  uVar4 = Component.get_gameObject(lVar5,0);
                  if (*pStatics != 0) {
                    uVar3 = *(uint64 *)(*pStatics + 136);
                    if (*(int64 *)(heroData + 200) != 0) {
                      puVar6 = (uint64 *)
                               BigMapPos.ToVector3(&local_58,*(int64 *)(heroData + 200),0);
                      uVar1 = *puVar6;
                      fVar2 = *(float *)(puVar6 + 1);
                      puVar6 = (uint64 *)Vector3.get_zero(&local_58,0);
                      local_68 = *puVar6;
                      local_60 = *(float *)(puVar6 + 1);
                      local_58 = uVar1;
                      local_50 = fVar2;
                      lVar5 = GlobalData.AddChild(uVar4,uVar3,&local_58,&local_68,0);
                      if (lVar5 != null) {
                        lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                        if (lVar7 != null) {
                          lVar7.Count = heroData;
                          lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                          puVar6 = (uint64 *)Vector3.get_one(&local_48,0);
                          local_60 = *(float *)(puVar6 + 1) * 0.2;
                          local_58 = CONCAT44((float)((uint64)*puVar6 >> 32) * 0.2,
                                              (float)*puVar6 * 0.2);
                          local_50 = local_60;
                          lVar8 = HeroData.GenerateHeroSkeleton(heroData,lVar5,&local_58,0);
                          if (lVar8 != null) {
                            uVar4 = Component.get_gameObject(lVar8,0);
                            if (lVar7 != null) {
                              *(uint64 *)(lVar7 + 72) = uVar4;
                              lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                              if ((lVar7 != null) && (*(int64 *)(lVar7 + 72) != 0)) {
                                lVar7 = GameObject.AddComponent
                                                  (*(int64 *)(lVar7 + 72),DAT_181dc5db8);
                                lVar8 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                                if ((lVar8 != null) && (*(int64 *)(lVar8 + 72) != 0)) {
                                  uVar4 = GameObject.GetComponent
                                                    (*(int64 *)(lVar8 + 72),DAT_181d734d0);
                                  if (lVar7 != null) {
                                    lVar7.Count = uVar4;
                                    if (*(int64 *)(heroData + 64) != 0) {
                                      if (*(int *)(*(int64 *)(heroData + 64) + 48) < 0) {
                                        lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                                        if (((lVar7 == null) || (lVar7.Count == null)) ||
                                           (lVar7 = *(int64 *)(lVar7.Count + 64),
                                           lVar7 == null)) throw; // [null/range check failed]
                                        HeroAIData.ResetBigmapWaitTime(lVar7,0);
                                      }
                                      lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                                      if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) {
                                        lVar7 = GameObject.GetComponent();
                                        if (*(char *)(heroData + 0x3cc) == false) {
                                          if (*(int *)(heroData + 88) == 0) {
                                            puVar6 = (uint64 *)Color.get_green();
                                          }
                                          else {
                                            puVar6 = (uint64 *)Color.get_blue(&local_48);
                                          }
                                        }
                                        else if (*(char *)(heroData + 0x3cd) == false) {
                                          puVar6 = (uint64 *)Color.get_yellow();
                                        }
                                        else {
                                          puVar6 = (uint64 *)Color.get_red();
                                        }
                                        uVar4 = *puVar6;
                                        uVar3 = puVar6[1];
                                        local_48 = uVar4;
                                        uStack_40 = uVar3;
                                        puVar6 = (uint64 *)
                                                 GlobalData.SetColorAlpha
                                                           (&local_58,&local_48,0x3f4ccccd,0);
                                        if (lVar7 != null) {
                                          local_48 = *puVar6;
                                          uStack_40 = puVar6[1];
                                          SpriteRenderer.set_color(lVar7,&local_48,0);
                                          lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                                          if ((lVar7 != null) && (*(int64 *)(lVar7 + 80) != 0)) {
                                            lVar7 = GameObject.GetComponent
                                                              (*(int64 *)(lVar7 + 80),DAT_181d73bb8);
                                            lVar8 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                                            if ((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) {
                                              lVar8 = GameObject.GetComponent
                                                                (*(int64 *)(lVar8 + 32),DAT_181d73bb8
                                                                );
                                              if (lVar8 != null) {
                                                puVar6 = (uint64 *)
                                                         SpriteRenderer.get_color(&local_48,lVar8,0);
                                                if (lVar7 != null) {
                                                  local_48 = *puVar6;
                                                  uStack_40 = puVar6[1];
                                                  SpriteRenderer.set_color(lVar7,&local_48,0);
                                                  lVar7 = GameObject.GetComponent(lVar5,DAT_181dc76b0);
                                                  if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0))
                                                  {
                                                    lVar7 = GameObject.get_transform
                                                                      (*(int64 *)(lVar7 + 32),0);
                                                    if (lVar7 != null) {
                                                      lVar7 = Transform.Find(lVar7,"Arrow",0);
                                                      if (lVar7 != null) {
                                                        lVar7 = Component.GetComponent
                                                                          (lVar7,DAT_181d95de0);
                                                        lVar8 = GameObject.GetComponent
                                                                          (lVar5,DAT_181dc76b0);
                                                        if ((lVar8 != null) &&
                                                           (*(int64 *)(lVar8 + 32) != 0)) {
                                                          lVar8 = GameObject.GetComponent
                                                                            (*(int64 *)(lVar8 + 32),
                                                                             DAT_181d73bb8);
                                                          if (lVar8 != null) {
                                                            puVar6 = (uint64 *)
                                                                     SpriteRenderer.get_color
                                                                               (&local_48,lVar8,0);
                                                            if (lVar7 != null) {
                                                              local_48 = *puVar6;
                                                              uStack_40 = puVar6[1];
                                                              SpriteRenderer.set_color(lVar7,&local_48,0)
                                                              ;
                                                              lVar7 = GameObject.GetComponent
                                                                                (lVar5,DAT_181dc76b0);
                                                              if ((lVar7 != null) &&
                                                                 (*(int64 *)(lVar7 + 128) != 0)) {
                                                                lVar7 = Component.get_transform
                                                                                  (*(int64 *)
                                                                                    (lVar7 + 128),0);
                                                                if (lVar7 != null) {
                                                                  lVar7 = Transform.Find(lVar7,
                                                        "SeeSprite",0);
                                                        if (lVar7 != null) {
                                                          lVar7 = Component.GetComponent
                                                                            (lVar7,DAT_181d95de0);
                                                          lVar8 = GameObject.GetComponent
                                                                            (lVar5,DAT_181dc76b0);
                                                          if ((lVar8 != null) &&
                                                             (*(int64 *)(lVar8 + 32) != 0)) {
                                                            lVar8 = GameObject.GetComponent
                                                                              (*(int64 *)(lVar8 + 32)
                                                                               ,DAT_181d73bb8);
                                                            if (lVar8 != null) {
                                                              puVar6 = (uint64 *)
                                                                       SpriteRenderer.get_color
                                                                                 (&local_48,lVar8,0);
                                                              if (lVar7 != null) {
                                                                local_48 = *puVar6;
                                                                uStack_40 = puVar6[1];
                                                                SpriteRenderer.set_color
                                                                          (lVar7,&local_48,0);
                                                                lVar7 = GameObject.GetComponent
                                                                                  (lVar5,DAT_181dc76b0);
                                                                if ((lVar7 != null) &&
                                                                   (*(int64 *)(lVar7 + 128) != 0)) {
                                                                  lVar7 = Component.get_transform
                                                                                    (*(int64 *)
                                                                                      (lVar7 + 128),0);
                                                                  if (lVar7 != null) {
                                                                    lVar7 = Transform.Find(lVar7,
                                                        "SeeRangeSprite",0);
                                                        if (lVar7 != null) {
                                                          lVar7 = Component.GetComponent
                                                                            (lVar7,DAT_181d95de0);
                                                          lVar8 = GameObject.GetComponent
                                                                            (lVar5,DAT_181dc76b0);
                                                          if ((lVar8 != null) &&
                                                             (*(int64 *)(lVar8 + 32) != 0)) {
                                                            lVar8 = GameObject.GetComponent
                                                                              (*(int64 *)(lVar8 + 32)
                                                                               ,DAT_181d73bb8);
                                                            if (lVar8 != null) {
                                                              puVar6 = (uint64 *)
                                                                       SpriteRenderer.get_color
                                                                                 (&local_48,lVar8,0);
                                                              local_48 = *puVar6;
                                                              uStack_40 = puVar6[1];
                                                              puVar6 = (uint64 *)
                                                                       GlobalData.SetColorAlpha
                                                                                 (&local_58,&local_48,
                                                                                  0x3f19999a,0);
                                                              if (lVar7 != null) {
                                                                local_48 = *puVar6;
                                                                uStack_40 = puVar6[1];
                                                                SpriteRenderer.set_color
                                                                          (lVar7,&local_48,0);
                                                                if (*(int *)(heroData + 88) == 0) {
                                                                  this.playerArmy = lVar5;
                                                                  il2cpp_internal((int64 *)
                                                                                      (this + 88),
                                                                                      lVar5);
                                                                }
                                                                else {
                                                                  if (*(char *)(heroData + 0x3cc) == false)
                                                                  {
                                                                    lVar7 = this.bigmapNormalNpcIcons;
                                                                  }
                                                                  else {
                                                                    lVar7 = this.bigmapTempNpcIcons;
                                                                  }
                                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                                  FUN_18181e0a0(lVar7,lVar5,DAT_181d89398)
                                                                  ;
                                                                }
                                                                uVar4 = GameObject.get_transform(lVar5,0)
                                                                ;
                                                                BigMapController.SetBigMapHeroZPos
                                                                          (this,uVar4,0);
                                                                lVar5 = GameObject.GetComponent
                                                                                  (lVar5,DAT_181dc76b0);
                                                                if (lVar5 != null) {
                                                                  *(uint8 *)(lVar5 + 168) = 1;
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
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000CF0
    // RVA   : 0x8E1FE0   Offset: 0x8E13E0   Length: 0x2C2
    public void RefreshBigMapNPC(HeroData target)
    {
        long lVar1;
        if (target != null) {
          lVar1 = GameObject.GetComponent(target,DAT_181dc76b0);
          if (lVar1 != null) {
            *(uint8 *)(lVar1 + 168) = 1;
            return;
          }
        }
    }

    // Token : 0x6000CF1
    // RVA   : 0x8E1F80   Offset: 0x8E1380   Length: 0x50
    public void RefreshBigMapNPC(GameObject target)
    {
        long lVar1;
        if (target != null) {
          lVar1 = GameObject.GetComponent(target,DAT_181dc76b0);
          if (lVar1 != null) {
            *(uint8 *)(lVar1 + 168) = 1;
            return;
          }
        }
    }

    // Token : 0x6000CF2
    // RVA   : 0x8E2410   Offset: 0x8E1810   Length: 0x1B7
    public void RemoveBigMapNpc(HeroData target)
    {
        bool cVar1;
        long lVar2;
        cVar1 = Object.op_Inequality(target,0,0);
        if (cVar1) {
          if (target == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(target,DAT_181dc76b0);
          if (lVar2 == null) throw; // [null/range check failed]
          BigmapNpcController.StartSelfDestroy(lVar2,0);
        }
        if (!param_3) {
          lVar2 = this.bigmapNormalNpcIcons;
        }
        else {
          lVar2 = this.bigmapTempNpcIcons;
        }
        if (lVar2 != null) {
          FUN_1817eee00(lVar2,target,DAT_181d89618);
          return;
        }
    }

    // Token : 0x6000CF3
    // RVA   : 0x8E22B0   Offset: 0x8E16B0   Length: 0x73
    public void RemoveBigMapNpc(GameObject target)
    {
        bool cVar1;
        long lVar2;
        cVar1 = Object.op_Inequality(target,0,0);
        if (cVar1) {
          if (target == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(target,DAT_181dc76b0);
          if (lVar2 == null) throw; // [null/range check failed]
          BigmapNpcController.StartSelfDestroy(lVar2,0);
        }
        if (!param_3) {
          lVar2 = this.bigmapNormalNpcIcons;
        }
        else {
          lVar2 = this.bigmapTempNpcIcons;
        }
        if (lVar2 != null) {
          FUN_1817eee00(lVar2,target,DAT_181d89618);
          return;
        }
    }

    // Token : 0x6000CF4
    // RVA   : 0x8E2330   Offset: 0x8E1730   Length: 0xDC
    public void RemoveBigMapNpc(GameObject target, bool isTempHero)
    {
        bool cVar1;
        long lVar2;
        cVar1 = Object.op_Inequality(target,0,0);
        if (cVar1) {
          if (target == null) throw; // [null/range check failed]
          lVar2 = GameObject.GetComponent(target,DAT_181dc76b0);
          if (lVar2 == null) throw; // [null/range check failed]
          BigmapNpcController.StartSelfDestroy(lVar2,0);
        }
        if (!isTempHero) {
          lVar2 = this.bigmapNormalNpcIcons;
        }
        else {
          lVar2 = this.bigmapTempNpcIcons;
        }
        if (lVar2 != null) {
          FUN_1817eee00(lVar2,target,DAT_181d89618);
          return;
        }
    }

    // Token : 0x6000CF5
    // RVA   : 0x8D8AA0   Offset: 0x8D7EA0   Length: 0x308
    public void CreateBigMapRandomEventIcon(EventData targetData)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        uint uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        ulong local_38;
        uint local_30;
        ulong local_28;
        uint local_20;
        if (this.bigmapRoot != null) {
          lVar3 = GameObject.get_transform(this.bigmapRoot,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"Event",0);
            if (lVar3 != null) {
              uVar4 = Component.get_gameObject(lVar3,0);
              if (*pStatics != 0) {
                uVar2 = *(uint64 *)(*pStatics + 128);
                lVar3 = GlobalData.AddChild(uVar4,uVar2,0);
                if (lVar3 != null) {
                  lVar5 = GameObject.get_transform(lVar3,0);
                  if ((targetData != null) && (*(int64 *)(targetData + 80) != 0)) {
                    puVar6 = (uint64 *)BigMapPos.ToVector3(&local_28,*(int64 *)(targetData + 80),0)
                    ;
                    if (lVar5 != null) {
                      local_38 = *puVar6;
                      local_30 = *(uint32 *)(puVar6 + 1);
                      Transform.set_localPosition(lVar5,&local_38,0);
                      lVar5 = GameObject.get_transform(lVar3,0);
                      lVar7 = GameObject.get_transform(lVar3,0);
                      if (lVar7 != null) {
                        puVar8 = (uint32 *)Transform.get_localPosition(&local_28,lVar7,0);
                        uVar1 = *puVar8;
                        lVar7 = GameObject.get_transform(lVar3,0);
                        if (lVar7 != null) {
                          puVar6 = (uint64 *)Transform.get_localPosition(&local_28,lVar7,0);
                          local_28 = *puVar6;
                          local_20 = *(uint32 *)(puVar6 + 1);
                          local_38 = CONCAT44((int)((uint64)local_28 >> 32),uVar1);
                          local_30 = 0x3f666666;
                          if (lVar5 != null) {
                            local_28 = local_38;
                            local_20 = 0x3f666666;
                            Transform.set_localPosition(lVar5,&local_28,0);
                            lVar5 = GameObject.get_transform(lVar3,0);
                            if (lVar5 != null) {
                              lVar5 = Transform.Find(lVar5,"SeeRange",0);
                              if (lVar5 != null) {
                                lVar5 = Component.GetComponent(lVar5,DAT_181d939e0);
                                uVar4 = Mathf.Max(0x3c23d70a,*(uint32 *)(targetData + 152),0);
                                if (lVar5 != null) {
                                  CapsuleCollider.set_radius(lVar5,uVar4,0);
                                  lVar5 = GameObject.GetComponent(lVar3,DAT_181dc75a0);
                                  if (lVar5 != null) {
                                    *(int64 *)(lVar5 + 24) = targetData;
                                    if (this.bigmapRandomEventIcons != null) {
                                      FUN_18181e0a0(this.bigmapRandomEventIcons,lVar3,DAT_181d89398);
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

    // Token : 0x6000CF6
    // RVA   : 0x8D8DB0   Offset: 0x8D81B0   Length: 0x1AC
    public void CreateBigMapRandomEvent(EventData targetData, AreaData targetArea, int direction, float seeRange)
    {
        if ((targetData != null) && (*(int64 *)(targetData + 64) != 0)) {
          FUN_1812f9a10(*(int64 *)(targetData + 64),DAT_181d8f318);
          *(uint64 *)(targetData + 88) = 0xffffffffffffffff;
          if (targetArea != null) {
            *(uint32 *)(targetData + 60) = *(uint32 *)(targetArea + 16);
            *(uint64 *)(targetData + 80) = *(uint64 *)(targetArea + 40);
            *(uint32 *)(targetData + 152) = 0x3c23d70a;
            BigMapController.CreateBigMapRandomEventIcon(this,targetData,0);
            return;
          }
        }
    }

    // Token : 0x6000CF7
    // RVA   : 0x8D8F60   Offset: 0x8D8360   Length: 0x9D
    public void CreateBigMapRandomEvent(EventData targetData, ResourcePointData targetResourcePoint)
    {
        if ((targetData != null) && (*(int64 *)(targetData + 64) != 0)) {
          FUN_1812f9a10(*(int64 *)(targetData + 64),DAT_181d8f318);
          *(uint64 *)(targetData + 88) = 0xffffffffffffffff;
          if (targetResourcePoint != null) {
            *(uint32 *)(targetData + 60) = *(uint32 *)(targetResourcePoint + 16);
            *(uint64 *)(targetData + 80) = *(uint64 *)(targetResourcePoint + 40);
            *(uint32 *)(targetData + 152) = 0x3c23d70a;
            BigMapController.CreateBigMapRandomEventIcon(this,targetData,0);
            return;
          }
        }
    }

    // Token : 0x6000CF8
    // RVA   : 0x8DD880   Offset: 0x8DCC80   Length: 0x11B
    public Vector3 LimitMapPos(Vector3 originPos, float scale)
    {
        float * BigMapController.LimitMapPos
                        (float *this,int64 originPos,uint64 *scale,float param_4)
        {
        uint64 uVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        uVar1 = *scale;
        fVar3 = *(float *)(scale + 1);
        fVar2 = *(float *)(originPos + 40) * 0.5;
        fVar5 = *(float *)(originPos + 48) * 0.5 * param_4;
        *(uint64 *)this = uVar1;
        this[2] = fVar3;
        fVar6 = (fVar5 - fVar2) / param_4;
        fVar4 = *this;
        if (fVar6 < *this) {
          this[1] = (float)((uint64)uVar1 >> 32);
          this[2] = fVar3;
          *this = fVar6;
          fVar4 = fVar6;
        }
        fVar3 = (fVar2 - fVar5) / param_4;
        if (fVar4 < fVar3) {
          this[1] = (float)((uint64)*(uint64 *)this >> 32);
          this[2] = this[2];
          *this = fVar3;
        }
        fVar3 = *(float *)(originPos + 44) * 0.5;
        fVar2 = *(float *)(originPos + 52) * 0.5 * param_4;
        fVar4 = (fVar2 - fVar3) / param_4;
        if (fVar4 < this[1]) {
          this[2] = this[2];
          this[1] = fVar4;
        }
        param_4 = (fVar3 - fVar2) / param_4;
        if (this[1] <= param_4 && param_4 != this[1]) {
          this[2] = this[2];
          this[1] = param_4;
        }
        return this;
    }

    // Token : 0x6000CF9
    // RVA   : 0x8E0F00   Offset: 0x8E0300   Length: 0x41E
    public void OnDrag(Vector3 delta)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        ulong uVar1;
        bool cVar2;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[64];
        puVar3 = (uint64 *)Vector3.get_zero(local_58,0);
        local_78 = *puVar3;
        local_70 = *(float *)(puVar3 + 1);
        local_68 = *delta;
        local_60 = *(float *)(delta + 1);
        cVar2 = Vector3.op_Inequality(&local_68,&local_78,0);
        if (cVar2) {
          if (!this.bigMapControlAniming) {
            if (this.bigmapRoot != null) {
              uVar4 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30);
              cVar2 = Object.op_Equality(uVar4,0,0);
              if (!cVar2) {
                if ((this.bigmapRoot == null) ||
                   (lVar5 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30),
                   lVar5 == null)) goto LAB_1808e1319;
                cVar2 = Behaviour.get_isActiveAndEnabled(lVar5,0);
                if (cVar2) {
                  return;
                }
              }
              if ((((*pStatics != 0) &&
                   (lVar5 = *(int64 *)(*pStatics + 32)) != null) &&
                  (lVar5 = WorldData.Player(lVar5,0)) != null) &&
                 ((*(int64 *)(lVar5 + 64) != 0 &&
                  (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 64) + 56)) != null))) {
                cVar2 = BigMapPos.IsZero(lVar5,0);
                if (!cVar2) {
                  return;
                }
                if (this.bigmapRoot != null) {
                  lVar5 = GameObject.get_transform(this.bigmapRoot,0);
                  if ((this.bigmapRoot != null) &&
                     (lVar6 = GameObject.get_transform(this.bigmapRoot,0)) != null) {
                    puVar3 = (uint64 *)Transform.get_localPosition(local_58,lVar6,0);
                    local_78 = *puVar3;
                    local_70 = *(float *)(puVar3 + 1);
                    uVar4 = *delta;
                    local_60 = *(float *)(delta + 1);
                    uVar1 = this.bigmapScaleRoot;
                    local_68 = uVar4;
                    puVar3 = (uint64 *)
                             GlobalData.TransformScreenDeltaToLocalDelta(local_48,uVar4,uVar1,0);
                    local_68 = *puVar3;
                    local_60 = *(float *)(puVar3 + 1);
                    fVar13 = (float)local_78 + (float)local_68;
                    fVar14 = local_70 + local_60;
                    fVar12 = local_78._4_4_ + (float)((uint64)local_68 >> 32);
                    if ((this.bigmapScaleRoot != null) &&
                       (lVar6 = GameObject.get_transform(this.bigmapScaleRoot,0)) != null) {
                      pfVar7 = (float *)Transform.get_localScale(local_48,lVar6,0);
                      fVar9 = *pfVar7;
                      fVar8 = this.rootWidth * 0.5;
                      fVar11 = this.bigMapWidth * 0.5 * fVar9;
                      fVar10 = (fVar11 - fVar8) / fVar9;
                      if (fVar10 < fVar13) {
                        fVar13 = fVar10;
                      }
                      fVar8 = (fVar8 - fVar11) / fVar9;
                      if (fVar13 < fVar8) {
                        fVar13 = fVar8;
                      }
                      fVar8 = this.rootHeight * 0.5;
                      fVar11 = this.bigMapHeight * 0.5 * fVar9;
                      fVar10 = (fVar11 - fVar8) / fVar9;
                      if (fVar10 < fVar12) {
                        fVar12 = fVar10;
                      }
                      fVar9 = (fVar8 - fVar11) / fVar9;
                      if (fVar12 < fVar9) {
                        fVar12 = fVar9;
                      }
                      local_78 = CONCAT44(fVar12,fVar13);
                      local_70 = fVar14;
                      if (lVar5 != null) {
                        local_68 = local_78;
                        local_60 = fVar14;
                        Transform.set_localPosition(lVar5,&local_68,0);
                        return;
                      }
                    }
                  }
                }
              }
            }
        LAB_1808e1319:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000CFA
    // RVA   : 0x8D7FA0   Offset: 0x8D73A0   Length: 0x18E
    public bool CanDrag()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        ulong in_RAX;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        if (this.bigMapControlAniming) {
        LAB_1808d8121:
          return in_RAX & 0xffffffffffffff00;
        }
        if (this.bigmapRoot == null) throw; // [null/range check failed]
        uVar2 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          if (this.bigmapRoot == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30);
          if (lVar3 == null) throw; // [null/range check failed]
          in_RAX = Behaviour.get_isActiveAndEnabled(lVar3,0);
          if ((char)in_RAX) goto LAB_1808d8121;
        }
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if ((lVar3 != null) &&
             ((*(int64 *)(lVar3 + 64) != 0 &&
              (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 64) + 56)) != null))) {
            uVar4 = BigMapPos.IsZero(lVar3,0);
            return uVar4;
          }
        }
    }

    // Token : 0x6000CFB
    // RVA   : 0x8D7F60   Offset: 0x8D7360   Length: 0x37
    public float BigMapNowScale()
    {
        long lVar1;
        byte[] local_18 = new byte[24];
        if (this.bigmapScaleRoot != null) {
          lVar1 = GameObject.get_transform(this.bigmapScaleRoot,0);
          if (lVar1 != null) {
            puVar2 = (uint32 *)Transform.get_localScale(local_18,lVar1,0);
            return *puVar2;
          }
        }
    }

    // Token : 0x6000CFC
    // RVA   : 0x8E35B0   Offset: 0x8E29B0   Length: 0x716
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        if (this.bigmapRoot == null) throw; // [null/range check failed]
        cVar1 = GameObject.get_activeInHierarchy(this.bigmapRoot,0);
        if (cVar1) {
          if (*pStatics == 0) throw; // [null/range check failed]
          cVar1 = GameController.HaveSpeUI(*pStatics,1,0);
          if (!cVar1) {
            lVar2 = FUN_18046c0a0(0);
            if ((((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) &&
               ((*(int64 *)(lVar2 + 64) != 0 &&
                (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 64) + 56)) != null))) {
              cVar1 = BigMapPos.IsZero(lVar2,0);
              if (!cVar1) {
                if (this.playerResting) {
                  this.playerResting = 0;
                  if ((this.playerRestButton == null) ||
                     (lVar2 = GameObject.GetComponent(this.playerRestButton,DAT_181dc72f8),
                     lVar2 == null)) throw; // [null/range check failed]
                  AudioSource.Stop(lVar2,0);
                }
                cVar1 = GlobalData.GetKeyDown(32);
                if (cVar1) {
                  BigMapController.PlayerStopMove(this,0);
                }
              }
              else {
                cVar1 = GlobalData.GetKeyDown(32);
                if (!cVar1) {
                  cVar1 = GlobalData.GetKeyUp(32);
                  if (cVar1) {
                    this.playerResting = 0;
                    if ((this.playerRestButton == null) ||
                       (lVar2 = GameObject.GetComponent(this.playerRestButton,DAT_181dc72f8),
                       lVar2 == null)) throw; // [null/range check failed]
                    AudioSource.Stop(lVar2,0);
                  }
                }
                else {
                  this.playerResting = 1;
                  if ((this.playerRestButton == null) ||
                     (lVar2 = GameObject.GetComponent(this.playerRestButton,DAT_181dc72f8),
                     lVar2 == null)) throw; // [null/range check failed]
                  AudioSource.Play(lVar2,0);
                }
              }
              cVar1 = GlobalData.GetKeyDown(98);
              if (cVar1) {
                if (this.backForceButton == null) throw; // [null/range check failed]
                cVar1 = GameObject.get_activeInHierarchy(this.backForceButton,0);
                if (cVar1) {
                  uVar5 = this.backForceButton;
                  uVar3 = EventSystem.get_current(0);
                  uVar4 = new PointerEventData(uVar3,0);
                  uVar3 = FUN_1807e6470(0);
                  ExecuteEvents.Execute(uVar5,uVar4,uVar3,DAT_181db8e18);
                }
              }
              cVar1 = GlobalData.GetKeyDown(110);
              if (cVar1) {
                if (this.focusSelfButton == null) throw; // [null/range check failed]
                cVar1 = GameObject.get_activeInHierarchy(this.focusSelfButton,0);
                if (cVar1) {
                  uVar5 = this.focusSelfButton;
                  uVar3 = EventSystem.get_current(0);
                  uVar4 = new PointerEventData(uVar3,0);
                  uVar3 = FUN_1807e6470(0);
                  ExecuteEvents.Execute(uVar5,uVar4,uVar3,DAT_181db8e18);
                }
              }
              cVar1 = GlobalData.GetKeyDown(109);
              if (!cVar1) {
                return;
              }
              if ((((this.horseUI != null) &&
                   (lVar2 = GameObject.get_transform(this.horseUI,0)) != null) &&
                  (lVar2 = Transform.Find(lVar2,"HorseIcon",0)) != null) &&
                 (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
                cVar1 = GameObject.get_activeInHierarchy(lVar2,0);
                if (!cVar1) {
                  return;
                }
                if (((this.horseUI != null) &&
                    (lVar2 = GameObject.get_transform(this.horseUI,0)) != null) &&
                   ((lVar2 = Transform.Find(lVar2,"HorseIcon",0), lVar2 != null &&
                    (lVar2 = Component.GetComponent(lVar2,DAT_181d941e0)) != null))) {
                  if (*(int64 *)(lVar2 + 24) == 0) {
                    return;
                  }
                  if (((this.horseUI != null) &&
                      (lVar2 = GameObject.get_transform(this.horseUI,0)) != null) &&
                     (lVar2 = Transform.Find(lVar2,"HorseIcon",0)) != null) {
                    uVar5 = Component.get_gameObject(lVar2,0);
                    uVar3 = EventSystem.get_current(0);
                    uVar4 = new PointerEventData(uVar3,0);
                    uVar3 = FUN_1807e6470(0);
                    ExecuteEvents.Execute(uVar5,uVar4,uVar3,DAT_181db8e18);
                    return;
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if (!this.playerResting) {
          return;
        }
        this.playerResting = 0;
        if ((this.playerRestButton != null) &&
           (lVar2 = GameObject.GetComponent(this.playerRestButton,DAT_181dc72f8)) != null) {
          AudioSource.Stop(lVar2,0);
          return;
        }
    }

    // Token : 0x6000CFD
    // RVA   : 0x8D9330   Offset: 0x8D8730   Length: 0x15F6
    private void FixedUpdate()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar5;
        uint uVar9;
        long lVar10;
        uint uVar11;
        float fVar13;
        uint uVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        float local_res8;
        float fStackX_c;
        uint64 local_d8;
        float local_d0;
        uint64 local_c8;
        float local_c0;
        uint8 local_b8 [8];
        float local_b0;
        uint32 local_a8;
        uint32 uStack_a4;
        uint32 uStack_a0;
        uint32 uStack_9c;
        int64 local_98;
        uint64 local_88;
        uint64 uStack_80;
        int64 local_78;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        uVar9 = 0;
        fVar19 = local_d0;
        if (this.bigmapRoot != null) {
          cVar2 = GameObject.get_activeInHierarchy(this.bigmapRoot,0);
          if (!cVar2) {
            return;
          }
          lVar3 = this.needRemoveBigMapNpc;
          fVar19 = local_d0;
          if (lVar3 != null) {
            lVar10 = 32;
            uVar11 = uVar9;
            do {
              if (lVar3.Count <= (int)uVar11) {
                FUN_1812f9a10(lVar3,DAT_181d8b618);
                fVar19 = local_d0;
                if (((*pStatics_2cc8 == 0) ||
                    (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
                   (lVar3 = WorldData.Player(lVar3,0), fVar19 = local_d0) == null) break;
                cVar2 = HeroData.HaveForce(lVar3,0);
                lVar3 = this.backForceButton;
                fVar19 = local_d0;
                if (!cVar2) {
                  if (lVar3 == null) break;
                  cVar2 = GameObject.get_activeSelf(lVar3,0);
                  if (cVar2) {
                    lVar3 = this.backForceButton;
                    fVar19 = local_d0;
                    if (lVar3 == null) break;
                    uVar5 = 0;
        LAB_1808d9629:
                    GameObject.SetActive(lVar3,uVar5,0);
                  }
                }
                else {
                  if (lVar3 == null) break;
                  cVar2 = GameObject.get_activeSelf(lVar3,0);
                  if (!cVar2) {
                    lVar3 = this.backForceButton;
                    fVar19 = local_d0;
                    if (lVar3 != null) {
                      uVar5 = 1;
                      goto LAB_1808d9629;
                    }
                    break;
                  }
                }
                fVar19 = local_d0;
                if ((this.resourcePointControllers != null) &&
                   (lVar3 = FUN_1808ae5b0(this.resourcePointControllers,DAT_181dbd6f0), fVar19 = local_d0,
                   lVar3 != null)) {
                  ValueCollection.GetEnumerator(&local_a8,lVar3,DAT_181d7f658);
                  local_88 = CONCAT44(uStack_a4,local_a8);
                  uStack_80 = CONCAT44(uStack_9c,uStack_a0);
                  local_78 = local_98;
                  while (cVar2 = FUN_1811c3f80(&local_88,DAT_181d9aad8), cVar2) {
                    if (local_78 == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    *(uint8 *)(local_78 + 56) = 0;
                  }
                  ZhSegment.Initialize(&local_88,DAT_181d9aa58);
                  lVar3 = MouseController.get_hoveredObject(0);
                  cVar2 = Object.op_Inequality(lVar3,0,0);
                  if (cVar2) {
                    fVar19 = local_d0;
                    if (lVar3 == null) break;
                    lVar10 = GameObject.GetComponent(lVar3,DAT_181d72ef8);
                    cVar2 = Object.op_Inequality(lVar10,0,0);
                    if (!cVar2) {
                      lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7160);
                      cVar2 = Object.op_Inequality(lVar3,0,0);
                      if (cVar2) {
                        fVar19 = local_d0;
                        if (lVar3 == null) break;
                        while( true ) {
                          fVar19 = local_d0;
                          if ((lVar3.Count == null) ||
                             (lVar10 = *(int64 *)(lVar3.Count + 168)) == null)
                          goto LAB_1808da913;
                          uVar11 = lVar10.entries;
                          if ((int)uVar11 <= (int)uVar9) break;
                          lVar10 = this.resourcePointControllers;
                          if (uVar11 <= uVar9) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          fVar19 = local_d0;
                          if ((lVar10 == null) ||
                             (cVar2 = FUN_1808b04c0(lVar10), fVar19 = local_d0, cVar2))
                          goto LAB_1808da913;
                          uVar9 = uVar9 + 1;
                        }
                      }
                    }
                    else {
                      fVar19 = local_d0;
                      if (lVar10 == null) break;
                      *(uint8 *)(lVar10 + 56) = 1;
                    }
                  }
                  uVar5 = this.playerTargetIcon;
                  cVar2 = Object.op_Inequality(uVar5,0,0);
                  if (cVar2) {
                    fVar19 = local_d0;
                    if ((((*pStatics_2cc8 == 0) ||
                         (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null
                         ) || (lVar3 = WorldData.Player(lVar3,0), fVar19 = local_d0) == null) ||
                       (*(int64 *)(lVar3 + 64) == 0)) break;
                    lVar3 = *(int64 *)(*(int64 *)(lVar3 + 64) + 56);
                    if (((this.playerTargetIcon == null) ||
                        (lVar10 = GameObject.get_transform(this.playerTargetIcon,0),
                        fVar19 = local_d0, lVar10 == null)) ||
                       (puVar4 = (uint64 *)Transform.get_localPosition(local_b8,lVar10,0),
                       fVar19 = local_d0, lVar3 == null)) break;
                    local_d8 = *puVar4;
                    local_d0 = *(float *)(puVar4 + 1);
                    BigMapPos.SetByVector3(lVar3,&local_d8,0);
                  }
                  fVar19 = local_d0;
                  if (*pStatics_2cc8 == 0) break;
                  cVar2 = GameController.HaveSpeUI(*pStatics_2cc8,1,0);
                  if (!cVar2) {
                    fVar19 = this.tweenFocusTarget;
                    fVar20 = *(float *)(this + 172);
                    uVar5 = Vector2.get_zero(0);
                    local_res8 = (float)uVar5;
                    fVar19 = fVar19 - local_res8;
                    fStackX_c = (float)((uint64)uVar5 >> 32);
                    fVar20 = fVar20 - fStackX_c;
                    if (9.9999994e-11 <= fVar20 * fVar20 + fVar19 * fVar19) {
                      BigMapController.TweenFocusTarget(this,0);
                    }
                    else {
                      fVar19 = local_d0;
                      if ((((*pStatics_2cc8 == 0) ||
                           (lVar3 = *(int64 *)(*pStatics_2cc8 + 32),
                           lVar3 == null)) ||
                          (lVar3 = WorldData.Player(lVar3,0), fVar19 = local_d0) == null) ||
                         ((*(int64 *)(lVar3 + 64) == 0 ||
                          (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 64) + 56)) == null)))
                      break;
                      cVar2 = BigMapPos.IsZero(lVar3,0);
                      if (!cVar2) {
                        uVar14 = this.nowScale;
                        uVar14 = FUN_1810e36c0(uVar14,**(uint32 **)(DAT_181db0bc8 + 184),
                                               this.maxScale,0);
                        this.nowScale = uVar14;
                        fVar19 = local_d0;
                        if ((this.playerArmy == null) ||
                           (lVar3 = GameObject.get_transform(this.playerArmy,0),
                           fVar19 = local_d0, lVar3 == null)) break;
                        pfVar7 = (float *)Transform.get_localPosition(local_b8,lVar3,0);
                        fVar20 = *pfVar7;
                        fVar19 = local_d0;
                        if ((this.playerArmy == null) ||
                           (lVar3 = GameObject.get_transform(this.playerArmy,0),
                           fVar19 = local_d0, lVar3 == null)) break;
                        puVar4 = (uint64 *)Transform.get_localPosition(local_b8,lVar3,0);
                        local_d8 = *puVar4;
                        local_d0 = *(float *)(puVar4 + 1);
                        fVar13 = -fVar20;
                        fVar15 = (float)(local_d8 >> 32);
                        fVar19 = local_d0;
                        if ((this.bigmapScaleRoot == null) ||
                           (lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0),
                           fVar19 = local_d0, lVar3 == null)) break;
                        pfVar7 = (float *)Transform.get_localScale(local_b8,lVar3,0);
                        fVar19 = *pfVar7;
                        local_c0 = 0.0;
                        fVar16 = this.bigMapWidth * 0.5 * fVar19;
                        fVar17 = this.rootWidth * 0.5;
                        fVar18 = (fVar16 - fVar17) / fVar19;
                        uVar1 = CONCAT44(fVar15,fVar20) ^ 0x80000000;
                        if (fVar18 < fVar13) {
                          uVar1 = CONCAT44(fVar15,fVar18);
                          fVar13 = fVar18;
                        }
                        fVar20 = (fVar17 - fVar16) / fVar19;
                        if (fVar13 < fVar20) {
                          uVar1 = CONCAT44(fVar15,fVar20);
                        }
                        local_c8 = uVar1 ^ 0x8000000000000000;
                        fVar18 = this.bigMapHeight * 0.5 * fVar19;
                        fVar13 = this.rootHeight * 0.5;
                        fVar17 = (fVar18 - fVar13) / fVar19;
                        fVar20 = -fVar15;
                        if (fVar17 < -fVar15) {
                          local_c8._0_4_ = (uint32)uVar1;
                          local_c8 = CONCAT44(fVar17,(uint32)local_c8);
                          fVar20 = fVar17;
                        }
                        fVar19 = (fVar13 - fVar18) / fVar19;
                        if (fVar20 < fVar19) {
                          local_c8 = CONCAT44(fVar19,(uint32)local_c8);
                        }
                        fVar19 = local_d0;
                        if ((this.bigmapRoot == null) ||
                           (lVar3 = GameObject.get_transform(this.bigmapRoot,0),
                           fVar20 = local_c0, uVar1 = local_c8, fVar19 = local_d0, lVar3 == null)) break;
                        local_d8 = local_c8;
                        local_d0 = local_c0;
                        puVar4 = (uint64 *)Transform.get_localPosition(local_b8,lVar3,0);
                        local_c8 = *puVar4;
                        local_c0 = *(float *)(puVar4 + 1);
                        fVar19 = (float)Vector3.Distance(&local_c8,&local_d8,0);
                        lVar3 = this.bigmapRoot;
                        fVar13 = 1.0;
                        if (1.0 < fVar19) {
                          local_d8 = uVar1;
                          local_d0 = fVar20;
                          SpringPosition.Begin(lVar3,&local_d8,0x41700000,0);
                        }
                        else {
                          fVar19 = local_d0;
                          if ((lVar3 == null) ||
                             (lVar3 = GameObject.get_transform(lVar3,0), fVar19 = local_d0) == null)
                          break;
                          local_d8 = uVar1;
                          local_d0 = fVar20;
                          Transform.set_localPosition(lVar3,&local_d8,0);
                          fVar19 = local_d0;
                          if ((this.bigmapRoot == null) ||
                             (lVar3 = GameObject.GetComponent
                                                (this.bigmapRoot,DAT_181d73b30),
                             fVar19 = local_d0, lVar3 == null)) break;
                          Behaviour.set_enabled(lVar3,0,0);
                        }
                        lVar3 = *pStatics_2cc8;
                        fVar20 = (float)Time.get_fixedDeltaTime(0);
                        if (this.fastMode) {
                          fVar13 = 2.0;
                        }
                        fVar19 = local_d0;
                        if (lVar3 == null) break;
                        GameController.ChangeHour
                                  (lVar3,fVar20 * *(float *)(pStatics_3d40 + 0x124)
                                         * fVar13,0);
                      }
                      else if (this.playerResting) {
                        lVar3 = *pStatics_2cc8;
                        fVar20 = (float)Time.get_fixedDeltaTime(0);
                        if (!this.fastMode) {
                          fVar13 = 1.0;
                        }
                        else {
                          fVar13 = 2.0;
                        }
                        fVar19 = local_d0;
                        if (lVar3 == null) break;
                        GameController.ChangeHour
                                  (lVar3,fVar20 * *(float *)(pStatics_3d40 + 0x124)
                                         * fVar13,0);
                      }
                    }
                  }
                  fVar19 = local_d0;
                  if ((((*pStatics_2cc8 == 0) ||
                       (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) == null)
                      || (lVar3 = WorldData.Player(lVar3,0), fVar19 = local_d0) == null) ||
                     ((*(int64 *)(lVar3 + 64) == 0 ||
                      (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 64) + 56)) == null))) break;
                  cVar2 = BigMapPos.IsZero(lVar3,0);
                  lVar3 = this.targetIcon;
                  fVar19 = local_d0;
                  if (!cVar2) {
                    if (lVar3 == null) break;
                    lVar3 = GameObject.GetComponent(lVar3,DAT_181d73bb8);
                    puVar6 = (uint32 *)FUN_1810d3570(&local_a8,0);
                    fVar19 = local_d0;
                    if (lVar3 == null) break;
                    local_a8 = *puVar6;
                    uStack_a4 = puVar6[1];
                    uStack_a0 = puVar6[2];
                    uStack_9c = puVar6[3];
                    SpriteRenderer.set_color(lVar3,&local_a8,0);
                    fVar19 = local_d0;
                    if (this.targetIcon == null) break;
                    lVar3 = GameObject.get_transform(this.targetIcon,0);
                    fVar19 = local_d0;
                    if (((((*pStatics_2cc8 == 0) ||
                          (lVar10 = *(int64 *)(*pStatics_2cc8 + 32),
                          lVar10 == null)) ||
                         (lVar10 = WorldData.Player(lVar10,0), fVar19 = local_d0) == null) ||
                        ((*(int64 *)(lVar10 + 64) == 0 ||
                         (lVar10 = *(int64 *)(*(int64 *)(lVar10 + 64) + 56)) == null))) ||
                       (puVar4 = (uint64 *)BigMapPos.ToVector3(local_b8,lVar10,0), fVar19 = local_d0,
                       lVar3 == null)) break;
                    local_d8 = *puVar4;
                    local_d0 = *(float *)(puVar4 + 1);
                    Transform.set_localPosition(lVar3,&local_d8,0);
                    fVar19 = local_d0;
                    if (this.targetIcon == null) break;
                    lVar3 = GameObject.get_transform(this.targetIcon,0);
                    fVar19 = local_d0;
                    if ((this.targetIcon == null) ||
                       (lVar10 = GameObject.get_transform(this.targetIcon,0),
                       fVar19 = local_d0, lVar10 == null)) break;
                    puVar6 = (uint32 *)Transform.get_localPosition(local_b8,lVar10,0);
                    uVar14 = *puVar6;
                    fVar19 = local_d0;
                    if ((this.targetIcon == null) ||
                       (lVar10 = GameObject.get_transform(this.targetIcon,0),
                       fVar19 = local_d0, lVar10 == null)) break;
                    puVar4 = (uint64 *)Transform.get_localPosition(local_b8,lVar10,0);
                    local_d8 = *puVar4;
                    local_c8 = CONCAT44((int)(local_d8 >> 32),uVar14);
                    local_c0 = 0.2;
                    fVar19 = *(float *)(puVar4 + 1);
                    if (lVar3 == null) break;
                    local_d8 = local_c8;
                    local_d0 = 0.2;
                    Transform.set_localPosition(lVar3,&local_d8,0);
                  }
                  else {
                    if (lVar3 == null) break;
                    lVar3 = GameObject.GetComponent(lVar3,DAT_181d73bb8);
                    puVar6 = (uint32 *)FUN_180d98fe0(&local_a8,0);
                    fVar19 = local_d0;
                    if (lVar3 == null) break;
                    local_a8 = *puVar6;
                    uStack_a4 = puVar6[1];
                    uStack_a0 = puVar6[2];
                    uStack_9c = puVar6[3];
                    SpriteRenderer.set_color(lVar3,&local_a8,0);
                  }
                  fVar19 = local_d0;
                  if (this.bigmapScaleRoot == null) break;
                  uVar5 = GameObject.GetComponent(this.bigmapScaleRoot,DAT_181d745d0);
                  cVar2 = Object.op_Equality(uVar5,0,0);
                  if (!cVar2) {
                    fVar19 = local_d0;
                    if ((this.bigmapScaleRoot == null) ||
                       (lVar3 = GameObject.GetComponent(this.bigmapScaleRoot,DAT_181d745d0),
                       fVar19 = local_d0, lVar3 == null)) break;
                    cVar2 = Behaviour.get_enabled(lVar3,0);
                    if (!(!cVar2))
                    {
                      }
                      else {
                    }
                    fVar19 = local_d0;
                    if ((this.bigmapScaleRoot == null) ||
                       (lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0),
                       fVar19 = local_d0, lVar3 == null)) break;
                    pfVar7 = (float *)Transform.get_localScale(local_b8,lVar3,0);
                    lVar3 = this.bigmapScaleRoot;
                    fVar19 = local_d0;
                    if (*pfVar7 <= this.nowScale && this.nowScale != *pfVar7) {
                      if ((lVar3 == null) ||
                         (lVar3 = GameObject.get_transform(lVar3,0), fVar19 = local_d0) == null)
                      break;
                      puVar4 = (uint64 *)Transform.get_localScale(&local_a8,lVar3,0);
                      uVar1 = *puVar4;
                      local_c0 = *(float *)(puVar4 + 1);
                      fVar19 = (float)RealTime.get_deltaTime(0);
                      puVar8 = (uint64 *)Vector3.get_one(&local_a8,0);
                      fVar19 = fVar19 * 2.0;
                      local_d0 = *(float *)(puVar8 + 1) * fVar19 + local_c0;
                      local_d8 = CONCAT44((float)((uint64)*puVar8 >> 32) * fVar19 +
                                          (float)(uVar1 >> 32),(float)*puVar8 * fVar19 + (float)uVar1);
                      local_c8 = uVar1;
                      local_b0 = local_d0;
                      Transform.set_localScale(lVar3,&local_d8,0);
                      fVar19 = local_d0;
                      if ((this.bigmapScaleRoot == null) ||
                         (lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0),
                         fVar19 = local_d0, lVar3 == null)) break;
                      pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar3,0);
                      bVar12 = *pfVar7 < this.nowScale;
                    }
                    else {
                      if ((lVar3 == null) ||
                         (lVar3 = GameObject.get_transform(lVar3,0), fVar19 = local_d0) == null)
                      break;
                      pfVar7 = (float *)Transform.get_localScale(local_b8,lVar3,0);
                      if (*pfVar7 < this.nowScale || *pfVar7 == this.nowScale)
                      goto LAB_1808da6e9;
                      fVar19 = local_d0;
                      if ((this.bigmapScaleRoot == null) ||
                         (lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0),
                         fVar19 = local_d0, lVar3 == null)) break;
                      puVar4 = (uint64 *)Transform.get_localScale(local_b8,lVar3,0);
                      uVar1 = *puVar4;
                      local_c0 = *(float *)(puVar4 + 1);
                      fVar19 = (float)RealTime.get_deltaTime(0);
                      puVar8 = (uint64 *)Vector3.get_one(&local_a8,0);
                      fVar19 = fVar19 * 2.0;
                      local_d0 = local_c0 - *(float *)(puVar8 + 1) * fVar19;
                      local_d8 = CONCAT44((float)(uVar1 >> 32) -
                                          (float)((uint64)*puVar8 >> 32) * fVar19,
                                          (float)uVar1 - (float)*puVar8 * fVar19);
                      local_c8 = uVar1;
                      local_b0 = local_d0;
                      Transform.set_localScale(lVar3,&local_d8,0);
                      fVar19 = local_d0;
                      if ((this.bigmapScaleRoot == null) ||
                         (lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0),
                         fVar19 = local_d0, lVar3 == null)) break;
                      pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar3,0);
                      bVar12 = this.nowScale < *pfVar7;
                    }
                    if (!bVar12) {
                      fVar19 = local_d0;
                      if (this.bigmapScaleRoot == null) break;
                      lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0);
                      fVar19 = this.nowScale;
                      puVar4 = (uint64 *)Vector3.get_one(&local_a8,0);
                      local_d8 = *puVar4;
                      local_d0 = fVar19 * *(float *)(puVar4 + 1);
                      local_c8 = CONCAT44(fVar19 * (float)(local_d8 >> 32),fVar19 * (float)local_d8);
                      fVar19 = *(float *)(puVar4 + 1);
                      local_c0 = local_d0;
                      if (lVar3 == null) break;
                      local_d8 = local_c8;
                      Transform.set_localScale(lVar3,&local_d8,0);
                    }
                  }
        LAB_1808da6e9:
                  fVar19 = local_d0;
                  if (this.bigmapRoot != null) {
                    uVar5 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30);
                    cVar2 = Object.op_Equality(uVar5,0,0);
                    if (!cVar2) {
                      fVar19 = local_d0;
                      if ((this.bigmapRoot == null) ||
                         (lVar3 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30),
                         fVar19 = local_d0, lVar3 == null)) break;
                      cVar2 = Behaviour.get_isActiveAndEnabled(lVar3,0);
                      if (cVar2) {
                        return;
                      }
                    }
                    fVar19 = local_d0;
                    if (this.bigmapRoot != null) {
                      lVar3 = GameObject.get_transform(this.bigmapRoot,0);
                      fVar19 = local_d0;
                      if ((this.bigmapRoot != null) &&
                         (lVar10 = GameObject.get_transform(this.bigmapRoot,0),
                         fVar19 = local_d0, lVar10 != null)) {
                        puVar4 = (uint64 *)Transform.get_localPosition(&local_a8,lVar10,0);
                        local_d8 = *puVar4;
                        local_d0 = *(float *)(puVar4 + 1);
                        fVar19 = local_d0;
                        if ((this.bigmapScaleRoot != null) &&
                           (lVar10 = GameObject.get_transform(this.bigmapScaleRoot,0),
                           fVar19 = local_d0, lVar10 != null)) {
                          pfVar7 = (float *)Transform.get_localScale(&local_a8,lVar10,0);
                          fVar19 = *pfVar7;
                          fVar17 = this.bigMapWidth * 0.5 * fVar19;
                          fVar13 = this.rootWidth * 0.5;
                          fVar15 = (fVar17 - fVar13) / fVar19;
                          fVar20 = (float)local_d8;
                          if (fVar15 < (float)local_d8) {
                            fVar20 = fVar15;
                          }
                          fVar13 = (fVar13 - fVar17) / fVar19;
                          if (fVar20 < fVar13) {
                            fVar20 = fVar13;
                          }
                          fVar18 = this.bigMapHeight * 0.5 * fVar19;
                          fVar15 = this.rootHeight * 0.5;
                          fVar17 = (fVar18 - fVar15) / fVar19;
                          fVar13 = local_d8._4_4_;
                          if (fVar17 < local_d8._4_4_) {
                            fVar13 = fVar17;
                          }
                          fVar19 = (fVar15 - fVar18) / fVar19;
                          if (fVar13 < fVar19) {
                            fVar13 = fVar19;
                          }
                          local_c8 = CONCAT44(fVar13,fVar20);
                          local_c0 = local_d0;
                          fVar19 = local_d0;
                          if (lVar3 != null) {
                            local_d8 = local_c8;
                            Transform.set_localPosition(lVar3,&local_d8,0);
                            return;
                          }
                        }
                      }
                    }
                  }
                }
                break;
              }
              fVar19 = local_d0;
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              BigMapController.RemoveBigMapNpc
                        (this,*(uint64 *)(lVar3._items + lVar10));
              uVar11 = uVar11 + 1;
              lVar10 = lVar10 + 8;
              lVar3 = this.needRemoveBigMapNpc;
              fVar19 = local_d0;
            } while (lVar3 != null);
          }
        }
        LAB_1808da913:
        local_d0 = fVar19;
    }

    // Token : 0x6000CFE
    // RVA   : 0x8E2F70   Offset: 0x8E2370   Length: 0x3F8
    public void TweenFocusTarget()
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint local_res8;
        uint32 uStackX_c;
        uint64 local_68;
        float local_60;
        uint64 local_58;
        float local_50;
        uint8 local_48 [64];
        this.nowScale = *(uint32 *)(*(int64 *)(DAT_181db0bc8 + 184) + 4);
        if (this.bigmapScaleRoot == null) throw; // [null/range check failed]
        uVar3 = GameObject.GetComponent(this.bigmapScaleRoot,DAT_181d745d0);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          if ((this.bigmapScaleRoot == null) ||
             (lVar4 = GameObject.GetComponent(this.bigmapScaleRoot,DAT_181d745d0)) == null)
          throw; // [null/range check failed]
          cVar2 = Behaviour.get_enabled(lVar4,0);
          if (!(!cVar2))
          {
            }
            else {
          }
          uVar3 = this.bigmapScaleRoot;
          fVar9 = this.nowScale;
          puVar5 = (uint64 *)Vector3.get_one(local_48,0);
          local_58 = *puVar5;
          local_60 = *(float *)(puVar5 + 1) * fVar9;
          local_68 = CONCAT44((float)(local_58 >> 32) * fVar9,(float)local_58 * fVar9);
          local_50 = local_60;
          lVar4 = TweenScale.Begin(uVar3,0x3e99999a,&local_68,0);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar4 + 40) = 1;
        }
        local_60 = 0.0;
        local_68 = this.tweenFocusTarget ^ 0x8000000080000000;
        puVar5 = (uint64 *)
                 BigMapController.LimitMapPos
                           (local_48,this,&local_68,this.nowScale,0);
        uVar1 = *puVar5;
        fVar9 = *(float *)(puVar5 + 1);
        if ((this.bigmapRoot != null) &&
           (lVar4 = GameObject.get_transform(this.bigmapRoot,0)) != null) {
          local_68 = uVar1;
          local_60 = fVar9;
          puVar5 = (uint64 *)Transform.get_localPosition(local_48,lVar4,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          fVar7 = (float)Vector3.Distance(&local_58,&local_68,0);
          if (0.01 < fVar7) {
            fVar9 = this.tweenFocusTarget;
            fVar7 = *(float *)(this + 172);
            if ((this.bigmapScaleRoot != null) &&
               (lVar4 = GameObject.get_transform(this.bigmapScaleRoot,0)) != null) {
              pfVar6 = (float *)Transform.get_localScale(local_48,lVar4,0);
              fVar10 = *pfVar6;
              local_60 = 0.0;
              fVar8 = this.rootWidth * 0.5;
              fVar12 = this.bigMapWidth * 0.5 * fVar10;
              fVar11 = (fVar12 - fVar8) / fVar10;
              fVar13 = -fVar9;
              if (fVar11 < -fVar9) {
                fVar13 = fVar11;
              }
              fVar9 = (fVar8 - fVar12) / fVar10;
              if (fVar13 < fVar9) {
                fVar13 = fVar9;
              }
              fVar8 = this.rootHeight * 0.5;
              fVar12 = this.bigMapHeight * 0.5 * fVar10;
              fVar11 = (fVar12 - fVar8) / fVar10;
              fVar9 = -fVar7;
              if (fVar11 < -fVar7) {
                fVar9 = fVar11;
              }
              fVar10 = (fVar8 - fVar12) / fVar10;
              if (fVar9 < fVar10) {
                fVar9 = fVar10;
              }
              local_68 = CONCAT44(fVar9,fVar13);
              local_58 = local_68;
              local_50 = 0.0;
              lVar4 = SpringPosition.Begin(this.bigmapRoot,&local_58,0x41100000,0);
              if (lVar4 != null) {
                *(uint8 *)(lVar4 + 41) = 1;
                return;
              }
            }
          }
          else if ((this.bigmapRoot != null) &&
                  (lVar4 = GameObject.get_transform(this.bigmapRoot,0)) != null) {
            local_58 = uVar1;
            local_50 = fVar9;
            Transform.set_localPosition(lVar4,&local_58,0);
            uVar3 = Vector2.get_zero(0);
            local_res8 = (uint32)uVar3;
            uStackX_c = (uint32)((uint64)uVar3 >> 32);
            this.tweenFocusTarget = local_res8;
            *(uint32 *)(this + 172) = uStackX_c;
            return;
          }
        }
    }

    // Token : 0x6000CFF
    // RVA   : 0x8DD9A0   Offset: 0x8DCDA0   Length: 0x136
    public void ManageAllHeroMove(float deltaTime)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        BigMapController.ManageHeroMove(this,this.playerArmy,deltaTime,0);
        if (this.bigmapTempNpcIcons != null) {
          uVar3 = this.bigmapTempNpcIcons.Count - 1;
          if (-1 < (int)uVar3) {
            lVar2 = (int64)(int)uVar3 * 8 + 32;
            do {
              lVar1 = this.bigmapTempNpcIcons;
              if (lVar1 == null) throw; // [null/range check failed]
              if (lVar1.Count <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              BigMapController.ManageHeroMove
                        (this,*(uint64 *)(lVar1._items + lVar2),deltaTime,0);
              lVar2 = lVar2 + -8;
              uVar3 = uVar3 - 1;
            } while (-1 < (int)uVar3);
          }
          if (this.bigmapNormalNpcIcons != null) {
            uVar3 = this.bigmapNormalNpcIcons.Count - 1;
            if (-1 < (int)uVar3) {
              lVar2 = (int64)(int)uVar3 * 8 + 32;
              do {
                lVar1 = this.bigmapNormalNpcIcons;
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                BigMapController.ManageHeroMove
                          (this,*(uint64 *)(lVar1._items + lVar2),deltaTime,0);
                lVar2 = lVar2 + -8;
                uVar3 = uVar3 - 1;
              } while (-1 < (int)uVar3);
            }
            return;
          }
        }
    }

    // Token : 0x6000D00
    // RVA   : 0x8E25D0   Offset: 0x8E19D0   Length: 0x149
    public void SetBigMapHeroZPos(Transform targetHeroIcon)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        float fVar6;
        ulong local_48;
        float local_40;
        ulong[] local_38 = new ulong[2];
        byte[] local_28 = new byte[32];
        if (targetHeroIcon != null) {
          lVar2 = Component.get_transform(targetHeroIcon,0);
          lVar3 = Component.get_transform(targetHeroIcon,0);
          if (lVar3 != null) {
            puVar4 = (uint32 *)Transform.get_localPosition(local_38,lVar3,0);
            uVar1 = *puVar4;
            lVar3 = Component.get_transform(targetHeroIcon,0);
            if (lVar3 != null) {
              puVar5 = (uint64 *)Transform.get_localPosition(&local_48,lVar3,0);
              local_38[0] = *puVar5;
              lVar3 = Component.get_transform(targetHeroIcon,0);
              if (lVar3 != null) {
                puVar5 = (uint64 *)Transform.get_localPosition(local_28,lVar3,0);
                local_48 = *puVar5;
                local_40 = *(float *)(puVar5 + 1);
                fVar6 = local_48._4_4_ / *(float *)(*(int64 *)(DAT_181db0bc8 + 184) + 8);
                if (lVar2 != null) {
                  local_48 = CONCAT44((int)((uint64)local_38[0] >> 32),uVar1);
                  local_40 = fVar6;
                  Transform.set_localPosition(lVar2,&local_48,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D01
    // RVA   : 0x8E28A0   Offset: 0x8E1CA0   Length: 0x1AE
    public void SetHorseButton(bool show)
    {
        ulong uVar2;
        uint uVar3;
        uint uVar4;
        if (this.playerRestButton != null) {
          plVar1 = (int64 *)GameObject.GetComponent(this.playerRestButton,DAT_181d71e80);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,show,*(uint64 *)(*plVar1 + 0x2d0));
            if (this.focusSelfButton != null) {
              plVar1 = (int64 *)GameObject.GetComponent(this.focusSelfButton,DAT_181d71e80);
              if (plVar1 != (int64 *)0) {
                (**(code **)(*plVar1 + 0x2c8))(plVar1,show,*(uint64 *)(*plVar1 + 0x2d0));
                if (this.backForceButton != null) {
                  plVar1 = (int64 *)
                           GameObject.GetComponent(this.backForceButton,DAT_181d71e80);
                  if (plVar1 != (int64 *)0) {
                    (**(code **)(*plVar1 + 0x2c8))(plVar1,show,*(uint64 *)(*plVar1 + 0x2d0));
                    if (this.playerRestButton != null) {
                      uVar2 = GameObject.GetComponent(this.playerRestButton,DAT_181d71e80);
                      uVar4 = 0x3f800000;
                      if (!show) {
                        uVar3 = 0;
                      }
                      else {
                        uVar3 = 0x3f800000;
                      }
                      DOTweenModuleUI.DOFade(uVar2,uVar3,0x3e4ccccd,0);
                      if (this.focusSelfButton != null) {
                        uVar2 = GameObject.GetComponent(this.focusSelfButton,DAT_181d71e80);
                        if (!show) {
                          uVar3 = 0;
                        }
                        else {
                          uVar3 = 0x3f800000;
                        }
                        DOTweenModuleUI.DOFade(uVar2,uVar3,0x3e4ccccd,0);
                        if (this.backForceButton != null) {
                          uVar2 = GameObject.GetComponent(this.backForceButton,DAT_181d71e80);
                          if (!show) {
                            uVar4 = 0;
                          }
                          DOTweenModuleUI.DOFade(uVar2,uVar4,0x3e4ccccd,0);
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

    // Token : 0x6000D02
    // RVA   : 0x8DDAE0   Offset: 0x8DCEE0   Length: 0x2005
    public void ManageHeroMove(GameObject heroIcon, float deltaTime)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar11;
        long lVar12;
        long lVar13;
        ulong uVar14;
        int iVar15;
        ulong uVar16;
        float fVar18;
        uint uVar19;
        float fVar20;
        float fVar21;
        ulong in_stack_ffffffffffffff28;
        ulong in_stack_ffffffffffffff30;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        uint local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[64];
        fVar21 = (float)deltaTime;
        if ((heroIcon == null) || (lVar4 = GameObject.GetComponent(heroIcon,DAT_181dc76b0)) == null)
        throw; // [null/range check failed]
        uVar16 = *(uint64 *)(lVar4 + 24);
        uVar6 = this.playerArmy;
        local_98 = uVar16;
        cVar2 = Object.op_Equality(heroIcon,uVar6,0);
        iVar15 = 0;
        if (((cVar2) && (iVar3 = *(int *)(lVar4 + 248), iVar3 != -1)) && (fVar21 < 24.0)) {
          if (iVar3 == 0) {
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) ||
               (((*(int64 *)(lVar11 + 32) == 0 ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                (lVar5 == null)))) throw; // [null/range check failed]
            in_stack_ffffffffffffff30 = in_stack_ffffffffffffff30 & 0xffffffffffffff00;
            HeroData.ChangeHp(lVar5,*(float *)(lVar11 + 0x17c) * -0.02 * fVar21,0,1,1,
                               in_stack_ffffffffffffff30,0);
          }
          else if (iVar3 == 1) {
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) ||
               (((*(int64 *)(lVar11 + 32) == 0 ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                (lVar5 == null)))) throw; // [null/range check failed]
            in_stack_ffffffffffffff30 = 0;
            HeroData.ChangeMana
                      (lVar5,*(float *)(lVar11 + 0x194) * -0.02 * fVar21,0,1,
                       in_stack_ffffffffffffff28 & 0xffffffffffffff00,0);
          }
          else if (iVar3 == 2) {
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) ||
               (((*(int64 *)(lVar11 + 32) == 0 ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                (lVar5 == null)))) throw; // [null/range check failed]
            uVar7 = CONCAT71((int7)(in_stack_ffffffffffffff28 >> 8),1);
            HeroData.ChangeHp(lVar5,*(float *)(lVar11 + 0x17c) * -0.01 * fVar21,0,1,uVar7,
                               in_stack_ffffffffffffff30 & 0xffffffffffffff00,0);
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
            lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
            lVar11 = FUN_18046c0a0(0);
            if ((lVar11 == null) ||
               (((*(int64 *)(lVar11 + 32) == 0 ||
                 (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null) ||
                (lVar5 == null)))) throw; // [null/range check failed]
            in_stack_ffffffffffffff30 = 0;
            HeroData.ChangeMana
                      (lVar5,*(float *)(lVar11 + 0x194) * -0.01 * fVar21,0,1,uVar7 & 0xffffffffffffff00,0)
            ;
          }
          else if (iVar3 == 3) {
            lVar5 = FUN_18046c0a0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) throw; // [null/range check failed]
            in_stack_ffffffffffffff30 = 0;
            HeroData.ChangePoisonInjury
                      (lVar5,deltaTime,0,0,in_stack_ffffffffffffff28 & 0xffffffffffffff00,0);
          }
        }
        if (0.0 < *(float *)(lVar4 + 68)) {
          *(float *)(lVar4 + 68) = *(float *)(lVar4 + 68) - fVar21;
        }
        uVar6 = *(uint64 *)(lVar4 + 48);
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (((!cVar2) || (*(int *)(lVar4 + 56) != 1)) ||
           (fVar18 = fVar21 + *(float *)(lVar4 + 60), *(float *)(lVar4 + 60) = fVar18, fVar18 < 12.0))
        {
          uVar6 = BigmapNpcController.GetHeroTargetPos(lVar4,0);
          this.targetPos = uVar6;
          if (uVar16 == 0) throw; // [null/range check failed]
        }
        else {
          BigmapNpcController.ClearHeroFollowTarget(lVar4,0);
          if (uVar16 == 0) throw; // [null/range check failed]
          if (*(char *)(uVar16 + 0x3cd) == false) {
            uVar19 = 0x40c00000;
          }
          else {
            uVar19 = 0x40400000;
          }
          *(uint32 *)(lVar4 + 68) = uVar19;
          uVar6 = BigmapNpcController.GetHeroTargetPos(lVar4,0);
          this.targetPos = uVar6;
        }
        plVar17 = &this.targetPos;
        if (*(int *)(uVar16 + 88) != 0) {
          lVar5 = *(int64 *)(uVar16 + 64);
          if (lVar5 == null) throw; // [null/range check failed]
          if ((*(int *)(lVar5 + 16) == 1) && (0.0 < *(float *)(lVar5 + 64))) {
            if (this.targetPos == null) throw; // [null/range check failed]
            cVar2 = BigMapPos.IsZero(this.targetPos,0);
            if (cVar2) {
              lVar5 = *(int64 *)(uVar16 + 64);
              if (lVar5 == null) throw; // [null/range check failed]
              *(float *)(lVar5 + 64) = *(float *)(lVar5 + 64) - fVar21;
              if (*(int64 *)(uVar16 + 64) == 0) throw; // [null/range check failed]
              if (*(float *)(*(int64 *)(uVar16 + 64) + 64) <= 0.0) {
                HeroData.RandomBigMapMovePos(uVar16,0);
              }
            }
          }
          if (*(int *)(uVar16 + 88) != 0) {
            if (*(int64 *)(uVar16 + 64) == 0) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(uVar16 + 64) + 16) == 1)
            {
              }
              }
              if (this.targetPos == null) throw; // [null/range check failed]
              cVar2 = BigMapPos.IsZero(this.targetPos,0);
              if (cVar2) {
            }
          HeroData.ManageHeroHorseRest(uVar16,deltaTime,0);
          return;
        }
        uVar7 = Vector2.get_zero(0);
        local_a8._0_4_ = (float)uVar7;
        local_a8._4_4_ = (float)(uVar7 >> 32);
        this.nextPos = (float)local_a8;
        *(float *)(this + 252) = local_a8._4_4_;
        local_a8 = uVar7;
        lVar5 = GameObject.get_transform(heroIcon,0);
        if (lVar5 == null) throw; // [null/range check failed]
        puVar8 = (uint64 *)Transform.get_localPosition(local_78,lVar5,0);
        local_a8 = *puVar8;
        local_80 = *(float *)(puVar8 + 1);
        local_88 = local_a8;
        if (this.targetPos == null) throw; // [null/range check failed]
        puVar8 = (uint64 *)BigMapPos.ToVector3(local_78,this.targetPos,0);
        local_88 = *puVar8;
        local_80 = *(float *)(puVar8 + 1);
        fVar18 = (float)Vector2.Distance(local_a8,local_88,0);
        if (fVar18 <= 0.01) {
        LAB_1808de486:
          lVar4 = GameObject.get_transform(heroIcon,0);
          if ((this.targetPos == null) ||
             (puVar8 = (uint64 *)BigMapPos.ToVector3(local_78,this.targetPos,0), lVar4 == null))
          throw; // [null/range check failed]
          local_a8 = *puVar8;
          local_a0 = *(float *)(puVar8 + 1);
          Transform.set_localPosition(lVar4,&local_a8,0);
          uVar6 = this.playerArmy;
          cVar2 = Object.op_Equality(heroIcon,uVar6,0);
          lVar4 = *(int64 *)(uVar16 + 64);
          if (!cVar2) {
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(int *)(lVar4 + 48) < 0) {
              if (*(int64 *)(lVar4 + 56) == 0) throw; // [null/range check failed]
              BigMapPos.Reset(*(int64 *)(lVar4 + 56),0);
              if (*(int64 *)(uVar16 + 64) == 0) throw; // [null/range check failed]
              HeroAIData.ResetBigmapWaitTime(*(int64 *)(uVar16 + 64),0);
            }
            else {
              lVar4 = GameObject.get_transform(heroIcon,0);
              if (lVar4 == null) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_78,lVar4,0);
              uVar7 = *puVar8;
              fVar21 = *(float *)(puVar8 + 1);
              if ((*(int64 *)(uVar16 + 64) == 0) ||
                 (lVar4 = *(int64 *)(*(int64 *)(uVar16 + 64) + 56)) == null)
              throw; // [null/range check failed]
              puVar8 = (uint64 *)BigMapPos.ToVector3(local_78,lVar4,0);
              local_98 = *puVar8;
              local_90 = (uint32)puVar8[1];
              local_a8 = uVar7;
              local_a0 = fVar21;
              cVar2 = Vector3.op_Equality(&local_a8,&local_98,0);
              if (cVar2) {
                if ((*(int64 *)(uVar16 + 64) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(uVar16 + 64) + 56)) == null)
                throw; // [null/range check failed]
                BigMapPos.Reset(lVar4,0);
                lVar4 = FUN_18046c0a0(0);
                lVar5 = FUN_18046c0a0(0);
                if ((((lVar5 == null) || (*(int64 *)(uVar16 + 64) == 0)) ||
                    (*(int64 *)(lVar5 + 32) == 0)) ||
                   (uVar6 = WorldData.GetArea(*(int64 *)(lVar5 + 32),
                                               *(uint32 *)(*(int64 *)(uVar16 + 64) + 48),0),
                   lVar4 == null)) throw; // [null/range check failed]
                GameController.HeroEnterArea(lVar4,uVar16,uVar6,0);
                BigMapController.RemoveBigMapNpc(this,heroIcon,0);
              }
            }
          }
          else {
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 56) == 0)) throw; // [null/range check failed]
            BigMapPos.Reset(*(int64 *)(lVar4 + 56),0);
            BigMapController.SetHorseButton(this,1,0);
            if ((this.bigmapRoot == null) ||
               (lVar4 = GameObject.GetComponent(this.bigmapRoot,DAT_181d73b30)) == null
               ) throw; // [null/range check failed]
            Behaviour.set_enabled(lVar4,0,0);
            lVar4 = this.playerTargetIcon;
            cVar2 = Object.op_Inequality(lVar4,0,0);
            if (cVar2) {
              if (this.bigmapScaleRoot == null) throw; // [null/range check failed]
              uVar6 = GameObject.GetComponent(this.bigmapScaleRoot,DAT_181d745d0);
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (cVar2) {
                if ((this.bigmapScaleRoot == null) ||
                   (lVar4 = GameObject.GetComponent(this.bigmapScaleRoot,DAT_181d745d0),
                   lVar4 == null)) throw; // [null/range check failed]
                Behaviour.set_enabled(lVar4,0,0);
              }
              if (this.bigmapScaleRoot == null) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(this.bigmapScaleRoot,0);
              fVar21 = this.nowScale;
              puVar8 = (uint64 *)Vector3.get_one(local_68,0);
              local_88 = *puVar8;
              local_80 = *(float *)(puVar8 + 1);
              local_a0 = local_80 * fVar21;
              local_a8 = CONCAT44((float)(local_88 >> 32) * fVar21,(float)local_88 * fVar21);
              if (lVar4 == null) throw; // [null/range check failed]
              local_88 = local_a8;
              local_80 = local_a0;
              Transform.set_localScale(lVar4,&local_88,0);
              if (this.bigmapRoot == null) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(this.bigmapRoot,0);
              lVar5 = GameObject.get_transform(heroIcon,0);
              if (lVar5 == null) throw; // [null/range check failed]
              puVar9 = (uint32 *)Transform.get_localPosition(local_68,lVar5,0);
              uVar19 = *puVar9;
              lVar5 = GameObject.get_transform(heroIcon,0);
              if (lVar5 == null) throw; // [null/range check failed]
              lVar5 = Transform.get_localPosition(local_68,lVar5,0);
              uVar1 = *(uint32 *)(lVar5 + 4);
              if ((this.bigmapScaleRoot == null) ||
                 (lVar5 = GameObject.get_transform(this.bigmapScaleRoot,0)) == null)
              throw; // [null/range check failed]
              puVar9 = (uint32 *)Transform.get_localScale(local_68,lVar5,0);
              local_a8 = CONCAT44(uVar1,uVar19) ^ 0x8000000080000000;
              local_a0 = 0.0;
              puVar8 = (uint64 *)BigMapController.LimitMapPos(local_68,this,&local_a8,*puVar9,0);
              if (lVar4 == null) throw; // [null/range check failed]
              local_88 = *puVar8;
              local_80 = *(float *)(puVar8 + 1);
              Transform.set_localPosition(lVar4,&local_88,0);
              if (this.targetPos == null) throw; // [null/range check failed]
              uVar6 = GameObject.GetComponent(this.targetPos,DAT_181dc7160);
              cVar2 = Object.op_Inequality(uVar6,0,0);
              if (!cVar2) {
                if (this.targetPos == null) throw; // [null/range check failed]
                uVar6 = GameObject.GetComponent(this.targetPos,DAT_181dc75a0);
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (cVar2) {
                  if (((this.targetPos == null) ||
                      (lVar4 = GameObject.GetComponent(this.targetPos,DAT_181dc75a0)) == null) ||
                     (*(int64 *)(lVar4 + 24) == 0)) throw; // [null/range check failed]
                  if (*(char *)(*(int64 *)(lVar4 + 24) + 97) == false) {
                    lVar4 = FUN_18046c400(0);
                    if (((this.targetPos == null) ||
                        (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181dc75a0)) == null) ||
                       (lVar4 == null)) throw; // [null/range check failed]
                    PlotController.StartPlotEvent(lVar4,*(uint64 *)(lVar5 + 24),0);
                    goto LAB_1808df210;
                  }
                }
                if (this.targetPos == null) throw; // [null/range check failed]
                uVar6 = GameObject.GetComponent(this.targetPos,DAT_181dc76b0);
                cVar2 = Object.op_Inequality(uVar6,0,0);
                lVar4 = this.targetPos;
                if (!cVar2) {
                  if (lVar4 == null) throw; // [null/range check failed]
                  uVar6 = GameObject.GetComponent(lVar4,DAT_181d71f90);
                  cVar2 = Object.op_Inequality(uVar6,0,0);
                  uVar19 = (uint32)(in_stack_ffffffffffffff30 >> 32);
                  if (cVar2) {
                    while( true ) {
                      if ((*pStatics == 0) ||
                         (lVar4 = *(int64 *)(*pStatics + 32)) == null
                         ) throw; // [null/range check failed]
                      lVar4 = WorldData.Player(lVar4,0);
                      uVar19 = (uint32)(in_stack_ffffffffffffff30 >> 32);
                      if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x2e8) == 0)) throw; // [null/range check failed]
                      if (*(int *)(*(int64 *)(lVar4 + 0x2e8) + 24) <= iVar15) break;
                      lVar4 = FUN_18046c0a0(0);
                      if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                         ((lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0), lVar4 == null ||
                          (((*(int64 *)(lVar4 + 0x2e8) == 0 || (lVar4 = FUN_180002f80()) == null)
                           || (lVar4 = *(int64 *)(lVar4 + 120)) == null))))) throw; // [null/range check failed]
                      if (*(int *)(lVar4 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                      if (lVar4 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar4 + 40) == 6) {
                        lVar4 = FUN_18046c0a0(0);
                        if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                           ((lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0), lVar4 == null ||
                            (((*(int64 *)(lVar4 + 0x2e8) == 0 ||
                              (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x2e8),iVar15)) == null) ||
                             (lVar4 = *(int64 *)(lVar4 + 120)) == null))))) throw; // [null/range check failed]
                        if (*(int *)(lVar4 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                        if (((lVar4 == null) ||
                            (iVar3 = Int32.Parse(*(uint64 *)(lVar4 + 48),0), this.targetPos == null)) ||
                           ((lVar4 = GameObject.GetComponent(), lVar4 == null ||
                            (*(int64 *)(lVar4 + 24) == 0)))) throw; // [null/range check failed]
                        if (iVar3 == *(int *)(*(int64 *)(lVar4 + 24) + 16)) {
                          lVar4 = FUN_18046c400(0);
                          lVar5 = FUN_18046c0a0(0);
                          if (((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                               (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
                              ((*(int64 *)(lVar5 + 0x2e8) == 0 ||
                               (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 0x2e8),iVar15)) == null)))
                             || (lVar5 = *(int64 *)(lVar5 + 120)) == null) throw; // [null/range check failed]
                          if (*(int *)(lVar5 + 24) == 0) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          if ((*(int64 *)(*(int64 *)(lVar5 + 16) + 32) == 0) || (lVar4 == null))
                          throw; // [null/range check failed]
                          PlotController.AddPlotEvent(lVar4);
                        }
                      }
                      iVar15 = iVar15 + 1;
                    }
                    lVar4 = FUN_18046c400(0);
                    if (lVar4 != null) {
                      cVar2 = PlotController.HaveNoPlotWait(lVar4,0);
                      if (cVar2) {
                        lVar4 = FUN_18046c0a0(0);
                        if ((((this.targetPos == null) ||
                             (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d71f90)) == null) ||
                            (*(int64 *)(lVar5 + 24) == 0)) ||
                           (uVar6 = Int32.ToString(*(int64 *)(lVar5 + 24) + 16,0), lVar4 == null))
                        throw; // [null/range check failed]
                        GameController.CheckPlotTrigger(lVar4,9,uVar6,999999,0);
                      }
                      lVar4 = FUN_18046c400(0);
                      if (lVar4 != null) {
                        cVar2 = PlotController.HaveNoPlotWait(lVar4,0);
                        uVar16 = local_98;
                        if (!cVar2) goto LAB_1808df210;
                        lVar4 = FUN_18046c400(0);
                        if (((this.targetPos != null) &&
                            (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d71f90)) != null) &&
                           (lVar4 != null)) {
                          *(uint64 *)(lVar4 + 0x180) = *(uint64 *)(lVar5 + 24);
                          lVar4 = il2cpp_internal(DAT_181d97750);
                          FUN_18132faf0(lVar4,DAT_181da3bd8);
                          if (((this.targetPos != null) &&
                              (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d71f90)) != null) &&
                             (*(int64 *)(lVar5 + 24) != 0)) {
                            uVar6 = Int32.ToString(*(int64 *)(lVar5 + 24) + 16,0);
                            uVar6 = String.Concat("交易;OpenInnShop;",uVar6,0);
                            if (lVar4 != null) {
                              FUN_18181e0a0(lVar4,uVar6,DAT_181da3d58);
                              if (((this.targetPos != null) &&
                                  (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d71f90)) != null)
                                 && (*(int64 *)(lVar5 + 24) != 0)) {
                                uVar6 = String.Concat("住宿;HotelRest;",
                                                       *(uint64 *)(*(int64 *)(lVar5 + 24) + 24)
                                                       ,0);
                                FUN_18181e0a0(lVar4,uVar6,DAT_181da3d58);
                                if (((this.targetPos != null) &&
                                    (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d71f90)) != null
                                    ) && (*(int64 *)(lVar5 + 24) != 0)) {
                                  uVar6 = String.Concat("打杂;SimpleWork;",
                                                         *(uint64 *)
                                                          (*(int64 *)(lVar5 + 24) + 24),0);
                                  FUN_18181e0a0(lVar4,uVar6,DAT_181da3d58);
                                  FUN_18181e0a0(lVar4,"离开;HideInteractUI",DAT_181da3d58);
                                  if (**(int **)(DAT_181d73d40 + 184) != 2) {
                                    if (((this.targetPos == null) ||
                                        (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d71f90),
                                        lVar5 == null)) || (*(int64 *)(lVar5 + 24) == 0))
                                    throw; // [null/range check failed]
                                    if (*(char *)(*(int64 *)(lVar5 + 24) + 64) != false) {
                                      FUN_181822520(lVar4,0,"有事发生？;StartInnSpeEvent",DAT_181da4058);
                                    }
                                  }
                                  lVar5 = FUN_18046c400(0);
                                  if (((this.targetPos != null) &&
                                      (lVar11 = GameObject.GetComponent(this.targetPos,DAT_181d71f90),
                                      lVar11 != null)) && (*(int64 *)(lVar11 + 24) != 0)) {
                                    uVar6 = String.Format("{0}",
                                                           *(uint64 *)
                                                            (*(int64 *)(lVar11 + 24) + 32),0);
                                    uVar14 = il2cpp_internal(DAT_181da24d8);
                                    SinglePlotData.ctor
                                              (uVar14,uVar6,lVar4,1,0,CONCAT44(uVar19,3),"0",1,0
                                               ,0);
                                    if (lVar5 != null) {
                                      PlotController.AddPlot(lVar5,uVar14,0);
                                      uVar16 = local_98;
                                      goto LAB_1808df210;
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                    throw; // [null/range check failed]
                  }
                  if (this.targetPos == null) throw; // [null/range check failed]
                  uVar6 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8);
                  cVar2 = Object.op_Inequality(uVar6,0,0);
                  if (cVar2) {
                    lVar4 = il2cpp_internal(DAT_181d97750);
                    FUN_18132faf0(lVar4,DAT_181da3bd8);
                    if (lVar4 == null) throw; // [null/range check failed]
                    FUN_18181e0a0(lVar4,"离开;HideInteractUI",DAT_181da3d58);
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                       (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                    throw; // [null/range check failed]
                    cVar2 = HeroData.HaveForce(lVar5,0);
                    if (cVar2) {
                      if (((this.targetPos == null) ||
                          (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                         (*(int64 *)(lVar5 + 24) == 0)) throw; // [null/range check failed]
                      if (*(char *)(*(int64 *)(lVar5 + 24) + 72) == false) {
                        if (((this.targetPos == null) ||
                            (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                           (*(int64 *)(lVar5 + 24) == 0)) throw; // [null/range check failed]
                        iVar15 = *(int *)(*(int64 *)(lVar5 + 24) + 48);
                        lVar5 = FUN_18046c0a0(0);
                        if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                           (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                        throw; // [null/range check failed]
                        if (iVar15 == *(int *)(lVar5 + 132)) {
                          if (((this.targetPos == null) ||
                              (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                             (*(int64 *)(lVar5 + 24) == 0)) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          local_a8 = CONCAT44(local_a8._4_4_,
                                              *(uint32 *)(*(int64 *)(lVar5 + 24) + 16));
                          uVar6 = il2cpp_value_box(DAT_181d80418,&local_a8);
                          uVar6 = String.Format("探索;ExploreResourcePointPlot;{0};;收集资源\n每月一次",uVar6,0);
                          FUN_181822520(lVar4,0,uVar6,DAT_181da4058);
                        }
                      }
                      if (((this.targetPos == null) ||
                          (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                         (*(int64 *)(lVar5 + 24) == 0)) throw; // [null/range check failed]
                      iVar15 = *(int *)(*(int64 *)(lVar5 + 24) + 48);
                      lVar5 = FUN_18046c0a0(0);
                      if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                         (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
                      throw; // [null/range check failed]
                      if (iVar15 != *(int *)(lVar5 + 132)) {
                        if (((this.targetPos == null) ||
                            (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                           (*(int64 *)(lVar5 + 24) == 0)) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        local_a8 = CONCAT44(local_a8._4_4_,
                                            *(uint32 *)(*(int64 *)(lVar5 + 24) + 16));
                        uVar6 = il2cpp_value_box(DAT_181d80418,&local_a8);
                        uVar6 = String.Format("进攻;AttackResourcPointPlot;{0}",uVar6,0);
                        FUN_181822520(lVar4,0,uVar6,DAT_181da4058);
                      }
                    }
                    lVar5 = FUN_18046c400(0);
                    plVar10 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
                    if ((((this.targetPos == null) ||
                         (lVar11 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                        (*(int64 *)(lVar11 + 24) == 0)) ||
                       (lVar11 = *(int64 *)(*(int64 *)(lVar11 + 24) + 24),
                       plVar10 == (int64 *)0)) throw; // [null/range check failed]
                    if ((lVar11 != null) &&
                       (lVar12 = il2cpp_internal(lVar11,*(uint64 *)(*plVar10 + 64)), lVar12 == null
                       )) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if ((int)plVar10[3] == 0) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    plVar10[4] = lVar11;
                    il2cpp_internal(plVar10 + 4,lVar11);
                    lVar11 = FUN_18046c0a0(0);
                    if (lVar11 == null) throw; // [null/range check failed]
                    lVar11 = *(int64 *)(lVar11 + 32);
                    if ((((this.targetPos == null) ||
                         (lVar12 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                        (*(int64 *)(lVar12 + 24) == 0)) ||
                       ((lVar11 == null ||
                        (lVar11 = WorldData.GetArea(lVar11,*(uint32 *)
                                                             (*(int64 *)(lVar12 + 24) + 52),0),
                        lVar11 == null)))) throw; // [null/range check failed]
                    lVar11 = AreaData.GetAreaName(lVar11,0);
                    if ((lVar11 != null) &&
                       (lVar12 = il2cpp_internal(lVar11,*(uint64 *)(*plVar10 + 64)), lVar12 == null
                       )) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if (*(uint32 *)(plVar10 + 3) < 2) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    plVar10[5] = lVar11;
                    il2cpp_internal(plVar10 + 5,lVar11);
                    if (((this.targetPos == null) ||
                        (lVar11 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                       (*(int64 *)(lVar11 + 24) == 0)) throw; // [null/range check failed]
                    cVar2 = ResourcePointData.HaveForce(*(int64 *)(lVar11 + 24),0);
                    uVar6 = "这{0}位于{1}附近，目前处在{2}掌控之下。{3}";
                    lVar11 = "无人";
                    if (cVar2) {
                      if ((((this.targetPos == null) ||
                           (lVar11 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                          (*(int64 *)(lVar11 + 24) == 0)) ||
                         (lVar11 = ResourcePointData.GetForce(*(int64 *)(lVar11 + 24),0),
                         lVar11 == null)) throw; // [null/range check failed]
                      lVar11 = ForceData.GetForceName(lVar11,1,0);
                    }
                    if ((lVar11 != null) &&
                       (lVar12 = il2cpp_internal(lVar11,*(uint64 *)(*plVar10 + 64)), lVar12 == null
                       )) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    FUN_180002fd0(plVar10,2,lVar11);
                    lVar11 = FUN_18046c0a0(0);
                    if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                       (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
                    throw; // [null/range check failed]
                    lVar12 = HeroData.GetForce(lVar11,0,0);
                    lVar11 = "";
                    if (lVar12 != null) {
                      if (((this.targetPos == null) ||
                          (lVar11 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                         (*(int64 *)(lVar11 + 24) == 0)) throw; // [null/range check failed]
                      lVar12 = ResourcePointData.GetForce(*(int64 *)(lVar11 + 24),0);
                      lVar11 = FUN_18046c0a0(0);
                      if (((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
                         (lVar11 = WorldData.Player(*(int64 *)(lVar11 + 32),0)) == null)
                      throw; // [null/range check failed]
                      lVar13 = HeroData.GetForce(lVar11,0,0);
                      lVar11 = "";
                      if (lVar12 != lVar13) {
                        if (((this.targetPos == null) ||
                            (lVar11 = GameObject.GetComponent(this.targetPos,DAT_181d72ef8)) == null) ||
                           ((*(int64 *)(lVar11 + 24) == 0 ||
                            (lVar11 = ResourcePointData.GetArea(*(int64 *)(lVar11 + 24),0),
                            lVar11 == null)))) throw; // [null/range check failed]
                        uVar14 = AreaData.GetAreaName(lVar11,0);
                        lVar11 = String.Format("\n若想攻占{0}，先拿下此地可降低后续攻城战之难度。",uVar14,0);
                      }
                    }
                    if ((lVar11 != null) &&
                       (lVar12 = il2cpp_internal(lVar11,*(uint64 *)(*plVar10 + 64)), lVar12 == null
                       )) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    FUN_180002fd0(plVar10,3,lVar11);
                    uVar6 = String.Format(uVar6,plVar10,0);
                    uVar14 = new SinglePlotData(uVar6,lVar4,1,0,CONCAT44(uVar19,3),"0",1,0,0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    PlotController.AddPlot(lVar5,uVar14,0);
                    uVar16 = local_98;
                  }
                }
                else {
                  BigMapController.MeetBigMapNpc(this,lVar4,0);
                }
              }
              else {
                lVar4 = FUN_18046c0a0(0);
                if (((this.targetPos == null) ||
                    (lVar5 = GameObject.GetComponent(this.targetPos,DAT_181dc7160)) == null) ||
                   (lVar4 == null)) throw; // [null/range check failed]
                GameController.PlayerEnterArea(lVar4,*(uint64 *)(lVar5 + 24),1,0);
              }
        LAB_1808df210:
              this.targetPos = 0;
              il2cpp_internal(plVar17,0);
            }
          }
        }
        else {
          lVar5 = GameObject.get_transform(heroIcon,0);
          if (lVar5 == null) throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(local_78,lVar5,0);
          local_a8 = *puVar8;
          local_80 = *(float *)(puVar8 + 1);
          local_88 = local_a8;
          if (this.targetPos == null) throw; // [null/range check failed]
          uVar6 = BigMapPos.ToVector2(this.targetPos,0);
          fVar18 = *(float *)(*(int64 *)(DAT_181d73d40 + 184) + 0x120);
          fVar20 = (float)BigmapNpcController.GetBigMapTravelSpeed(lVar4,0);
          uVar7 = Vector2.MoveTowards(local_a8,uVar6,fVar18 * fVar21 * fVar20,0);
          local_a8._4_4_ = (float)(uVar7 >> 32);
          local_a8._0_4_ = (float)uVar7;
          *(float *)(this + 252) = local_a8._4_4_;
          this.nextPos = (float)local_a8;
          local_a8 = uVar7;
          HeroData.ManageHeroHorseMove(uVar16,deltaTime,0);
          fVar21 = this.nextPos;
          fVar18 = *(float *)(this + 252);
          if (this.targetPos == null) throw; // [null/range check failed]
          uVar7 = BigMapPos.ToVector2(this.targetPos,0);
          local_a8._0_4_ = (float)uVar7;
          fVar21 = fVar21 - (float)local_a8;
          local_a8._4_4_ = (float)(uVar7 >> 32);
          fVar18 = fVar18 - local_a8._4_4_;
          local_a8 = uVar7;
          if (fVar18 * fVar18 + fVar21 * fVar21 < 9.9999994e-11) goto LAB_1808de486;
          lVar4 = GameObject.get_transform(heroIcon,0);
          local_98 = this.nextPos;
          local_90 = 0;
          if (lVar4 == null) throw; // [null/range check failed]
          local_a0 = 0.0;
          local_a8 = local_98;
          Transform.set_localPosition(lVar4,&local_a8,0);
        }
        lVar4 = *(int64 *)(uVar16 + 200);
        lVar5 = GameObject.get_transform(heroIcon,0);
        if ((lVar5 != null) &&
           (puVar8 = (uint64 *)Transform.get_localPosition(local_68,lVar5,0), lVar4 != null)) {
          local_88 = *puVar8;
          local_80 = (float)puVar8[1];
          BigMapPos.SetByVector3(lVar4,&local_88,0);
          uVar6 = GameObject.get_transform(heroIcon,0);
          BigMapController.SetBigMapHeroZPos(this,uVar6,0);
          return;
        }
    }

    // Token : 0x6000D03
    // RVA   : 0x8DFAF0   Offset: 0x8DEEF0   Length: 0xF93
    public void MeetBigMapNpc(GameObject target)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        bool cVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        float fVar13;
        float[] local_res10 = new float[4];
        uint[] local_res20 = new uint[2];
        int local_78;
        int[] local_74 = new int[15];
        iVar2 = 0;
        local_res10[0] = 0.0;
        local_res20[0] = 0;
        if ((target != null) && (lVar6 = GameObject.GetComponent(target,DAT_181dc76b0)) != null) {
          if (*(char *)(lVar6 + 0x12e) != false) {
            return;
          }
          lVar6 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (lVar6 != null) {
            cVar1 = PlotController.HaveNoPlotWait(lVar6,0);
            if (!cVar1) {
              return;
            }
            lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
            if ((lVar6 != null) && (*(int64 *)(lVar6 + 24) != 0)) {
              if (*(char *)(*(int64 *)(lVar6 + 24) + 0x3cc) == false) {
                lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                if (lVar6 == null) throw; // [null/range check failed]
                uVar11 = *(uint64 *)(lVar6 + 48);
                uVar9 = this.playerArmy;
                cVar1 = Object.op_Equality(uVar11,uVar9,0);
                if (!cVar1) {
                  lVar6 = FUN_18046c400(0);
                  lVar7 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
                  PlotController.ShowHeroInteractUI(lVar6,*(uint64 *)(lVar7 + 24),0);
                }
                else {
                  lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if (lVar6 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar6 + 56) == 1) {
                    lVar8 = FUN_18046c400(0);
                    lVar7 = DAT_181d8b140;
                    plVar12 = *(int64 **)(DAT_181d8b140 + 48);
                    lVar6 = *plVar12;
                    if ((*(byte *)(lVar6 + 0x132) & 1) == 0) {
                      FUN_18009a510(lVar6);
                      plVar12 = *(int64 **)(lVar7 + 48);
                    }
                    if ((*(byte *)(lVar6 + 0x133) & 4) != 0) {
                      lVar6 = *plVar12;
                      if ((*(byte *)(lVar6 + 0x132) & 1) == 0) {
                        FUN_18009a510(lVar6);
                        plVar12 = *(int64 **)(lVar7 + 48);
                      }
                      if (*(int *)(lVar6 + 224) == 0) {
                        lVar6 = *plVar12;
                        if ((*(byte *)(lVar6 + 0x132) & 1) == 0) {
                          FUN_18009a510(lVar6);
                        }
                        il2cpp_runtime_class_init(lVar6);
                      }
                    }
                    lVar6 = **(int64 **)(lVar7 + 48);
                    if ((*(byte *)(lVar6 + 0x132) & 1) == 0) {
                      FUN_18009a510(lVar6);
                    }
                    uVar11 = String.Format("#$PlayerName#你作恶多端，江湖中人人得而诛之。\n今日我便要替天行道，将你捉拿归案！",**(uint64 **)(lVar6 + 184),0);
                    lVar6 = il2cpp_internal(DAT_181d97750);
                    FUN_18132faf0(lVar6,DAT_181da3bd8);
                    if (lVar6 == null) throw; // [null/range check failed]
                    FUN_18181e0a0(lVar6,"那便来吧！;FightInteractHero;HardFight-NpcAttackPlayerResult--Hero~None",DAT_181da3d58);
                    lVar7 = GameObject.GetComponent(target,DAT_181dc76b0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) throw; // [null/range check failed]
                    uVar9 = Int32.ToString(*(int64 *)(lVar7 + 24) + 88,0);
                    uVar10 = il2cpp_internal(DAT_181da24d8);
                  }
                  else {
                    lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar6 + 56) != 2) goto LAB_1808dfe78;
                    lVar6 = il2cpp_internal(DAT_181d97750);
                    FUN_18132faf0(lVar6,DAT_181da3bd8);
                    if (lVar6 == null) throw; // [null/range check failed]
                    FUN_18181e0a0(lVar6,"出手袭击;AskSureFightInteractHero",DAT_181da3d58);
                    FUN_18181e0a0(lVar6,"......;HideInteractUI",DAT_181da3d58);
                    lVar7 = GameObject.GetComponent(target,DAT_181dc76b0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) throw; // [null/range check failed]
                    iVar2 = HeroData.GetBountyPirce(*(int64 *)(lVar7 + 24),0);
                    if (0 < iVar2) {
                      FUN_181822520(lVar6,0,"抓捕归案;FightInteractHero;DeathFight-CatchBadFameHeroResult--None~Hero",DAT_181da4058);
                    }
                    lVar8 = FUN_18046c400(0);
                    lVar7 = GameObject.GetComponent(target,DAT_181dc76b0);
                    if ((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) throw; // [null/range check failed]
                    uVar9 = Int32.ToString(*(int64 *)(lVar7 + 24) + 88,0);
                    uVar10 = il2cpp_internal(DAT_181da24d8);
                    uVar11 = "#$PlayerName#？\n你恶名昭著，我与你无话可说，快走吧！";
                  }
                  SinglePlotData.ctor(uVar10,uVar11,lVar6,3,uVar9,3,"0",0,0,0);
                  if (lVar8 == null) throw; // [null/range check failed]
                  PlotController.AddPlot(lVar8,uVar10,0);
                }
              }
              else {
                lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                if ((lVar6 == null) || (*(int64 *)(lVar6 + 24) == 0)) throw; // [null/range check failed]
                if (*(char *)(*(int64 *)(lVar6 + 24) + 0x3cd) == false) {
                  lVar6 = FUN_18046c400(0);
                  lVar7 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
                  uVar9 = *(uint64 *)(lVar7 + 104);
                }
                else {
                  lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if (((lVar6 == null) || (*(int64 *)(lVar6 + 24) == 0)) ||
                     (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 64)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar6 + 16) == 13) {
                    lVar6 = FUN_18046c400(0);
                    lVar7 = FUN_18046c0a0(0);
                    if (lVar7 != null) {
                      lVar7 = *(int64 *)(lVar7 + 32);
                      lVar8 = GameObject.GetComponent(target,DAT_181dc76b0);
                      if ((((lVar8 != null) && (*(int64 *)(lVar8 + 24) != 0)) &&
                          (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 24) + 64)) != null) &&
                         ((uVar4 = Int32.Parse(*(uint64 *)(lVar8 + 24),0), lVar7 != null &&
                          (uVar11 = WorldData.GetHero(lVar7,uVar4,0), lVar6 != null)))) {
                        PlotController.ManageMeetNpcPlot(lVar6,uVar11,0);
                        goto LAB_1808dfe78;
                      }
                    }
                    throw; // [null/range check failed]
                  }
                  lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if (lVar6 == null) throw; // [null/range check failed]
                  uVar11 = *(uint64 *)(lVar6 + 48);
                  cVar1 = Object.op_Inequality(uVar11,0,0);
                  if (cVar1) {
                    lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    uVar11 = *(uint64 *)(lVar6 + 48);
                    uVar9 = this.playerArmy;
                    cVar1 = Object.op_Equality(uVar11,uVar9,0);
                    if (cVar1) {
                      lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar6 + 56) == 2) {
                        fVar13 = (float)GlobalData.RandomRange();
                        lVar6 = GameObject.GetComponent(target,DAT_181dc76b0);
                        if ((lVar6 != null) && (*(int64 *)(lVar6 + 24) != 0)) {
                          iVar3 = HeroData.GetBountyPirce(*(int64 *)(lVar6 + 24),0);
                          uVar4 = Mathf.RoundToInt((float)iVar3 * fVar13,0);
                          iVar3 = Mathf.Max(1,uVar4);
                          while (((lVar6 = GameObject.GetComponent(target,DAT_181dc76b0), lVar6 != null &&
                                  (*(int64 *)(lVar6 + 24) != 0)) &&
                                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 0x2f8)) != null)
                                ) {
                            if (*(int *)(lVar6 + 24) <= iVar2) {
                              lVar6 = FUN_18046c400(0);
                              local_78 = iVar3;
                              uVar11 = il2cpp_value_box(DAT_181d80418,&local_78);
                              uVar11 = String.Format("#$PlayerName#大侠，久仰久仰！还望您高抬贵手，放小的一马。\n小的前些日子赚了<b>{0}</b>两银子，正好孝敬您老人家。",uVar11,0);
                              lVar7 = il2cpp_internal(DAT_181d97750);
                              FUN_18132faf0(lVar7,DAT_181da3bd8);
                              if (lVar7 != null) {
                                FUN_18181e0a0(lVar7,"恶贼受死！;FightInteractHero;HardFight-FightRandomEnemyResult-true-Hero~None",DAT_181da3d58);
                                local_74[0] = iVar3;
                                uVar9 = il2cpp_value_box(DAT_181d80418,local_74);
                                local_res10[0] =
                                     (float)iVar3 *
                                     *(float *)(pStatics + 0x200) * 0.5;
                                uVar10 = Single.ToString(local_res10,"f0",0);
                                uVar9 = String.Format("算你识相！;MercyRandomEnemy;{0};;♦增加{1}恶名",uVar9,uVar10,0);
                                FUN_18181e0a0(lVar7,uVar9,DAT_181da3d58);
                                lVar8 = GameObject.GetComponent(target,DAT_181dc76b0);
                                if ((lVar8 != null) && (*(int64 *)(lVar8 + 24) != 0)) {
                                  uVar10 = Int32.ToString(*(int64 *)(lVar8 + 24) + 88,0);
                                  uVar9 = new SinglePlotData(uVar11,lVar7,3,uVar10,3,"0",0,0,0);
                                  if (lVar6 != null) goto LAB_1808e022c;
                                }
                              }
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            fVar13 = (float)GlobalData.RandomRange();
                            lVar6 = FUN_18046c0a0(0);
                            if (lVar6 == null) break;
                            lVar6 = *(int64 *)(lVar6 + 32);
                            lVar7 = GameObject.GetComponent(target,DAT_181dc76b0);
                            if ((((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) ||
                                (lVar7 = *(int64 *)(*(int64 *)(lVar7 + 24) + 0x2f8)) == null)
                               || ((uVar4 = FUN_1800d6760(lVar7,iVar2), lVar6 == null ||
                                   (lVar6 = WorldData.GetHero(lVar6,uVar4)) == null))) break;
                            iVar5 = HeroData.GetBountyPirce(lVar6,0);
                            uVar4 = Mathf.RoundToInt((float)iVar5 * fVar13,0);
                            iVar5 = Mathf.Max(1,uVar4);
                            iVar3 = iVar3 + iVar5;
                            iVar2 = iVar2 + 1;
                          }
                        }
                        throw; // [null/range check failed]
                      }
                    }
                  }
                  lVar6 = FUN_18046c400(0);
                  lVar7 = *(int64 *)(pStatics + 0x548);
                  if (lVar7 == null) throw; // [null/range check failed]
                  uVar4 = GlobalData.RandomRange(0,*(uint32 *)(lVar7 + 24),0,0);
                  uVar11 = FUN_180002f80(lVar7,uVar4,DAT_181da4358);
                  lVar7 = il2cpp_internal(DAT_181d97750);
                  FUN_18132faf0(lVar7,DAT_181da3bd8);
                  if (lVar7 == null) throw; // [null/range check failed]
                  FUN_18181e0a0(lVar7,"恶贼受死！;FightInteractHero;HardFight-FightRandomEnemyResult-true-Hero~None",DAT_181da3d58);
                  lVar8 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
                  local_res10[0] = (float)FUN_1801f8ab0();
                  local_res10[0] = local_res10[0] * 100.0;
                  uVar9 = Single.ToString(local_res10,0);
                  uVar9 = String.Concat("乖乖交钱;GiveRandomEnemyMoney;;0/",uVar9,0);
                  FUN_18181e0a0(lVar7,uVar9,DAT_181da3d58);
                  lVar8 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if ((lVar8 == null) ||
                     ((*(int64 *)(lVar8 + 24) == 0 ||
                      (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 24) + 0x168)) == null)))
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar8 + 24) < 4) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  local_res10[0] = *(float *)(*(int64 *)(lVar8 + 16) + 44);
                  uVar9 = Single.ToString(local_res10,0);
                  uVar9 = String.Concat("求情说理;DebateRandomEnemy;;;;Speech/",uVar9,0);
                  FUN_18181e0a0(lVar7,uVar9,DAT_181da3d58);
                  lVar8 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) ||
                     (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 24) + 0x150)) == null)
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar8 + 24) < 2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  local_res20[0] =
                       Mathf.RoundToInt(*(float *)(*(int64 *)(lVar8 + 16) + 36) * 1.5,0);
                  uVar9 = Int32.ToString(local_res20,0);
                  uVar9 = String.Concat("扭头就跑;EscapeRandomEnemy;;;;Dodge/",uVar9,0);
                  FUN_18181e0a0(lVar7,uVar9,DAT_181da3d58);
                  lVar8 = GameObject.GetComponent(target,DAT_181dc76b0);
                  if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
                  uVar10 = Int32.ToString(*(int64 *)(lVar8 + 24) + 88,0);
                  uVar9 = new SinglePlotData(uVar11,lVar7,3,uVar10,3,"0",0,0,0);
                  if (lVar6 == null) throw; // [null/range check failed]
                }
        LAB_1808e022c:
                PlotController.AddPlot(lVar6,uVar9,0);
                BigMapController.RemoveBigMapNpc(this,target,0);
              }
        LAB_1808dfe78:
              BigMapController.PlayerStopMove(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D04
    // RVA   : 0x8E0A90   Offset: 0x8DFE90   Length: 0x461
    public void MovePlayerIconToArea(int areaID)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        long lVar2;
        ulong uVar4;
        float fVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[48];
        if (this.playerArmy != null) {
          lVar1 = GameObject.get_transform(this.playerArmy,0);
          if (this.areaIcons != null) {
            lVar2 = FUN_1817d9e10(this.areaIcons,areaID,DAT_181db9ed0);
            if (lVar2 != null) {
              lVar2 = GameObject.get_transform(lVar2,0);
              if (lVar2 != null) {
                puVar3 = (uint64 *)Transform.get_localPosition(local_48,lVar2,0);
                if (lVar1 != null) {
                  local_68 = *puVar3;
                  local_60 = *(float *)(puVar3 + 1);
                  Transform.set_localPosition(lVar1,&local_68,0);
                  if (this.playerArmy != null) {
                    uVar4 = GameObject.get_transform(this.playerArmy,0);
                    BigMapController.SetBigMapHeroZPos(this,uVar4,0);
                    if ((*pStatics != 0) &&
                       (lVar1 = *(int64 *)(*pStatics + 32)) != null)
                    {
                      lVar1 = WorldData.Player(lVar1,0);
                      if (lVar1 != null) {
                        lVar1 = *(int64 *)(lVar1 + 200);
                        if (this.playerArmy != null) {
                          lVar2 = GameObject.get_transform(this.playerArmy,0);
                          if (lVar2 != null) {
                            puVar3 = (uint64 *)Transform.get_localPosition(local_48,lVar2,0);
                            if (lVar1 != null) {
                              local_68 = *puVar3;
                              local_60 = *(float *)(puVar3 + 1);
                              BigMapPos.SetByVector3(lVar1,&local_68,0);
                              this.nowScale =
                                   *(uint32 *)(*(int64 *)(DAT_181db0bc8 + 184) + 4);
                              if (this.bigmapScaleRoot != null) {
                                lVar1 = GameObject.get_transform(this.bigmapScaleRoot,0);
                                fVar7 = this.nowScale;
                                puVar3 = (uint64 *)Vector3.get_one(local_38,0);
                                local_58 = *puVar3;
                                local_50 = *(float *)(puVar3 + 1);
                                local_60 = local_50 * fVar7;
                                local_68 = CONCAT44((float)(local_58 >> 32) * fVar7,
                                                    (float)local_58 * fVar7);
                                if (lVar1 != null) {
                                  local_58 = local_68;
                                  local_50 = local_60;
                                  Transform.set_localScale(lVar1,&local_58,0);
                                  if (this.bigmapRoot != null) {
                                    lVar1 = GameObject.get_transform(this.bigmapRoot,0);
                                    if (this.playerArmy != null) {
                                      lVar2 = GameObject.get_transform(this.playerArmy,0);
                                      if (lVar2 != null) {
                                        pfVar5 = (float *)Transform.get_localPosition(local_38,lVar2,0);
                                        fVar7 = *pfVar5;
                                        if (this.playerArmy != null) {
                                          lVar2 = GameObject.get_transform
                                                            (this.playerArmy,0);
                                          if (lVar2 != null) {
                                            lVar2 = Transform.get_localPosition(local_38,lVar2,0);
                                            fVar10 = *(float *)(lVar2 + 4);
                                            fVar12 = -fVar10;
                                            if (this.bigmapScaleRoot != null) {
                                              lVar2 = GameObject.get_transform
                                                                (this.bigmapScaleRoot,0);
                                              if (lVar2 != null) {
                                                pfVar5 = (float *)Transform.get_localScale
                                                                            (local_38,lVar2,0);
                                                fVar8 = *pfVar5;
                                                local_60 = 0.0;
                                                fVar11 = this.bigMapWidth * 0.5 * fVar8;
                                                fVar6 = this.rootWidth * 0.5;
                                                fVar9 = (fVar11 - fVar6) / fVar8;
                                                fVar13 = -fVar7;
                                                if (fVar9 < -fVar7) {
                                                  fVar13 = fVar9;
                                                }
                                                fVar7 = (fVar6 - fVar11) / fVar8;
                                                if (fVar13 < fVar7) {
                                                  fVar13 = fVar7;
                                                }
                                                fVar7 = this.rootHeight * 0.5;
                                                fVar6 = this.bigMapHeight * 0.5 * fVar8;
                                                local_68 = CONCAT44(fVar10,fVar13) ^ 0x8000000000000000;
                                                fVar10 = (fVar6 - fVar7) / fVar8;
                                                if (fVar10 < fVar12) {
                                                  local_68 = CONCAT44(fVar10,fVar13);
                                                  fVar12 = fVar10;
                                                }
                                                fVar8 = (fVar7 - fVar6) / fVar8;
                                                if (fVar12 < fVar8) {
                                                  local_68 = CONCAT44(fVar8,(uint32)local_68);
                                                }
                                                if (lVar1 != null) {
                                                  local_58 = local_68;
                                                  local_50 = 0.0;
                                                  Transform.set_localPosition(lVar1,&local_58,0);
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

    // Token : 0x6000D05
    // RVA   : 0x8D7B70   Offset: 0x8D6F70   Length: 0x1F2
    public void BackForceButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = **(int64 **)(DAT_181da8710 + 184);
        if (*pStatics != 0) {
          lVar3 = *(int64 *)(*pStatics + 32);
          if ((*pStatics != 0) &&
             (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
            lVar2 = WorldData.GetHeroForce(lVar2,0,0);
            if ((lVar2 != null) && (lVar3 != null)) {
              lVar3 = WorldData.GetArea(lVar3,*(uint32 *)(lVar2 + 56),0);
              if (lVar3 != null) {
                uVar4 = AreaData.GetAreaName(lVar3,0);
                uVar4 = String.Format("要返回{0}吗？",uVar4,0);
                if (lVar1 != null) {
                  SureMenu.CallSureMenu(lVar1,uVar4,"BackForceButtonSured","","BigMapController",1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D06
    // RVA   : 0x8D7D70   Offset: 0x8D7170   Length: 0x1E0
    public void BackForceButtonSured()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_4000 = *(int64*)(DAT_181d94000 + 184);
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        if ((*pStatics_2cc8 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar3 = WorldData.GetHeroForce(lVar3,0,0);
          if (lVar3 != null) {
            uVar4 = Int32.ToString(lVar3 + 56,0);
            if ((*pStatics_4000 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_4000 + 32)) != null) {
              cVar1 = GameObject.get_activeSelf(lVar3,0);
              if (cVar1) {
                if (*pStatics_4000 == 0) throw; // [null/range check failed]
                QuickTravelUIController.HideQuickTravelUI(*pStatics_4000,0);
              }
              lVar3 = this.areaIcons;
              uVar2 = Int32.Parse(uVar4,0);
              if (lVar3 != null) {
                uVar4 = FUN_1817d9e10(lVar3,uVar2,DAT_181db9ed0);
                if (!this.bigMapControlAniming) {
                  this.playerTargetIcon = uVar4;
                  BigMapController.SetHorseButton(this,0,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D07
    // RVA   : 0x8E2AD0   Offset: 0x8E1ED0   Length: 0x119
    public void SetPlayerMoveTargetArea(string areaID)
    {
        if (!this.bigMapControlAniming) {
          this.playerTargetIcon = areaID;
          BigMapController.SetHorseButton(this,0,0);
          return;
        }
    }

    // Token : 0x6000D08
    // RVA   : 0x8E2A50   Offset: 0x8E1E50   Length: 0x7A
    public void SetPlayerMoveTargetArea(int areaID)
    {
        if (!this.bigMapControlAniming) {
          this.playerTargetIcon = areaID;
          BigMapController.SetHorseButton(this,0,0);
          return;
        }
    }

    // Token : 0x6000D09
    // RVA   : 0x8E2BF0   Offset: 0x8E1FF0   Length: 0x39
    public void SetPlayerMoveTargetArea(GameObject target)
    {
        if (!this.bigMapControlAniming) {
          this.playerTargetIcon = target;
          BigMapController.SetHorseButton(this,0,0);
          return;
        }
    }

    // Token : 0x6000D0A
    // RVA   : 0x8E2DD0   Offset: 0x8E21D0   Length: 0x119
    public void SetPlayerMoveTargetResourcePoint(string areaID)
    {
        ulong uVar1;
        if (this.resourcePoints != null) {
          uVar1 = FUN_1817d9e10(this.resourcePoints,areaID,DAT_181db9ed0);
          if (!this.bigMapControlAniming) {
            this.playerTargetIcon = uVar1;
            BigMapController.SetHorseButton(this,0,0);
          }
          return;
        }
    }

    // Token : 0x6000D0B
    // RVA   : 0x8E2EF0   Offset: 0x8E22F0   Length: 0x7A
    public void SetPlayerMoveTargetResourcePoint(int areaID)
    {
        ulong uVar1;
        if (this.resourcePoints != null) {
          uVar1 = FUN_1817d9e10(this.resourcePoints,areaID,DAT_181db9ed0);
          if (!this.bigMapControlAniming) {
            this.playerTargetIcon = uVar1;
            BigMapController.SetHorseButton(this,0,0);
          }
          return;
        }
    }

    // Token : 0x6000D0C
    // RVA   : 0x8E2CB0   Offset: 0x8E20B0   Length: 0x119
    public void SetPlayerMoveTargetInn(string areaID)
    {
        ulong uVar1;
        if (this.innIcons != null) {
          uVar1 = FUN_1817d9e10(this.innIcons,areaID,DAT_181db9ed0);
          if (!this.bigMapControlAniming) {
            this.playerTargetIcon = uVar1;
            BigMapController.SetHorseButton(this,0,0);
          }
          return;
        }
    }

    // Token : 0x6000D0D
    // RVA   : 0x8E2C30   Offset: 0x8E2030   Length: 0x7A
    public void SetPlayerMoveTargetInn(int areaID)
    {
        ulong uVar1;
        if (this.innIcons != null) {
          uVar1 = FUN_1817d9e10(this.innIcons,areaID,DAT_181db9ed0);
          if (!this.bigMapControlAniming) {
            this.playerTargetIcon = uVar1;
            BigMapController.SetHorseButton(this,0,0);
          }
          return;
        }
    }

    // Token : 0x6000D0E
    // RVA   : 0x8DA930   Offset: 0x8D9D30   Length: 0x58
    public void FocusOnSelf()
    {
        ulong uVar1;
        long lVar2;
        byte[] local_18 = new byte[16];
        BigMapController.PlayerStopMove(this,0);
        if (this.playerArmy != null) {
          lVar2 = GameObject.get_transform(this.playerArmy,0);
          if (lVar2 != null) {
            puVar3 = (uint64 *)Transform.get_localPosition(local_18,lVar2,0);
            uVar1 = *puVar3;
            this.tweenFocusTarget = (int)uVar1;
            *(int *)(this + 172) = (int)((uint64)uVar1 >> 32);
            return;
          }
        }
    }

    // Token : 0x6000D0F
    // RVA   : 0x8E1660   Offset: 0x8E0A60   Length: 0x222
    public void QuickFocusOnSelf()
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        ulong uVar7;
        uint local_res8;
        uint32 uStackX_c;
        uint64 local_58;
        float local_50;
        uint64 local_48;
        float local_40;
        uint8 local_28 [32];
        this.nowScale = *(uint32 *)(*(int64 *)(DAT_181db0bc8 + 184) + 4);
        if (this.bigmapScaleRoot != null) {
          lVar3 = GameObject.get_transform(this.bigmapScaleRoot,0);
          fVar1 = this.nowScale;
          puVar4 = (uint64 *)Vector3.get_one(local_28,0);
          local_48 = *puVar4;
          local_40 = *(float *)(puVar4 + 1);
          local_50 = local_40 * fVar1;
          local_58 = CONCAT44((float)(local_48 >> 32) * fVar1,(float)local_48 * fVar1);
          if (lVar3 != null) {
            local_48 = local_58;
            local_40 = local_50;
            Transform.set_localScale(lVar3,&local_48,0);
            if (this.bigmapRoot != null) {
              lVar3 = GameObject.get_transform(this.bigmapRoot,0);
              if (this.playerArmy != null) {
                lVar5 = GameObject.get_transform(this.playerArmy,0);
                if (lVar5 != null) {
                  puVar6 = (uint32 *)Transform.get_localPosition(local_28,lVar5,0);
                  uVar2 = *puVar6;
                  if (this.playerArmy != null) {
                    lVar5 = GameObject.get_transform(this.playerArmy,0);
                    if (lVar5 != null) {
                      lVar5 = Transform.get_localPosition(local_28,lVar5,0);
                      local_58 = CONCAT44(*(uint32 *)(lVar5 + 4),uVar2) ^ 0x8000000080000000;
                      local_50 = 0.0;
                      puVar4 = (uint64 *)
                               BigMapController.LimitMapPos
                                         (local_28,this,&local_58,this.nowScale,0);
                      if (lVar3 != null) {
                        local_48 = *puVar4;
                        local_40 = (float)puVar4[1];
                        Transform.set_localPosition(lVar3,&local_48,0);
                        uVar7 = Vector2.get_zero(0);
                        local_res8 = (uint32)uVar7;
                        uStackX_c = (uint32)((uint64)uVar7 >> 32);
                        this.tweenFocusTarget = local_res8;
                        *(uint32 *)(this + 172) = uStackX_c;
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

    // Token : 0x6000D10
    // RVA   : 0x8E1560   Offset: 0x8E0960   Length: 0xFA
    public void PlayerStopMove()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((lVar1 != null) &&
             ((*(int64 *)(lVar1 + 64) != 0 &&
              (lVar1 = *(int64 *)(*(int64 *)(lVar1 + 64) + 56)) != null))) {
            BigMapPos.Reset(lVar1,0);
            this.playerTargetIcon = 0;
            BigMapController.SetHorseButton(this,1,0);
            return;
          }
        }
    }

    // Token : 0x6000D11
    // RVA   : 0x8E14C0   Offset: 0x8E08C0   Length: 0x96
    public void PlayerRestButton(bool onPress)
    {
        long lVar1;
        lVar1 = this.playerRestButton;
        this.playerResting = onPress;
        if (!onPress) {
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181dc72f8);
            if (lVar1 != null) {
              AudioSource.Stop(lVar1,0);
              return;
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = GameObject.GetComponent(lVar1,DAT_181dc72f8);
          if (lVar1 != null) {
            AudioSource.Play(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x6000D12
    // RVA   : 0x8E1320   Offset: 0x8E0720   Length: 0x199
    public void PlayBigMapControlAnim()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar4;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        byte[] local_18 = new byte[16];
        this.bigMapControlAniming = 1;
        if (this.bigmapUIPanel != null) {
          lVar1 = GameObject.get_transform(this.bigmapUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BigMapControlUI",0);
            if (lVar1 != null) {
              local_28 = 0x437a0000;
              uStack_24 = 0;
              uStack_20 = 0;
              Transform.set_localPosition(lVar1,&local_28,0);
              if (this.bigmapUIPanel != null) {
                lVar1 = GameObject.get_transform(this.bigmapUIPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"BigMapControlUI",0);
                  puVar3 = (uint64 *)Vector3.get_zero(local_18,0);
                  uStack_20 = *(uint32 *)(puVar3 + 1);
                  local_28 = (uint32)*puVar3;
                  uStack_24 = (uint32)((uint64)*puVar3 >> 32);
                  uVar2 = ShortcutExtensions.DOLocalMove(uVar2,&local_28,0x3f000000,0,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1db0);
                  uVar4 = new OnTooltipCB(this,DAT_181d8a370,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar4,DAT_181dc01d0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D13
    // RVA   : 0x8D9000   Offset: 0x8D8400   Length: 0x18A
    public void FastModeButtonClicked()
    {
        bool cVar1;
        long lVar2;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        cVar1 = this.fastMode;
        lVar2 = *(int64 *)(this + 200);
        this.fastMode = !cVar1;
        if (!cVar1) {
          if (lVar2 != null) {
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"Icon",0);
              if (lVar2 != null) {
                plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460);
                puVar4 = (uint32 *)Color.get_red(&local_18,0);
                if (plVar3 != (int64 *)0) {
                  local_18 = *puVar4;
                  uStack_14 = puVar4[1];
                  uStack_10 = puVar4[2];
                  uStack_c = puVar4[3];
                  (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar2 != null) {
          lVar2 = GameObject.get_transform(lVar2,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Icon",0);
            if (lVar2 != null) {
              plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460);
              lVar2 = *(int64 *)(DAT_181d73d40 + 184);
              if (plVar3 != (int64 *)0) {
                local_18 = *(uint32 *)(lVar2 + 0x398);
                uStack_14 = *(uint32 *)(lVar2 + 0x39c);
                uStack_10 = *(uint32 *)(lVar2 + 0x3a0);
                uStack_c = *(uint32 *)(lVar2 + 0x3a4);
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D14
    // RVA   : 0x8E2720   Offset: 0x8E1B20   Length: 0x17F
    public void SetFastModeState(bool state)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = *(int64 *)(this + 200);
        this.fastMode = state;
        if (!state) {
          if (lVar1 != null) {
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Icon",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
                lVar1 = *(int64 *)(DAT_181d73d40 + 184);
                if (plVar2 != (int64 *)0) {
                  local_18 = *(uint32 *)(lVar1 + 0x398);
                  uStack_14 = *(uint32 *)(lVar1 + 0x39c);
                  uStack_10 = *(uint32 *)(lVar1 + 0x3a0);
                  uStack_c = *(uint32 *)(lVar1 + 0x3a4);
                  (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Icon",0);
            if (lVar1 != null) {
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
              puVar3 = (uint32 *)Color.get_red(&local_18,0);
              if (plVar2 != (int64 *)0) {
                local_18 = *puVar3;
                uStack_14 = puVar3[1];
                uStack_10 = puVar3[2];
                uStack_c = puVar3[3];
                (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D15
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000D16
    // RVA   : 0x8E3CD0   Offset: 0x8E30D0   Length: 0x63
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181db0bc8 + 184);
        **(uint32 **)(DAT_181db0bc8 + 184) = 0x3f19999a;
        *(uint32 *)(pStatics + 4) = 0x3fa00000;
        *(uint32 *)(pStatics + 8) = 0x461c4000;
    }

    // Token : 0x6000D17
    // RVA   : 0x8E3370   Offset: 0x8E2770   Length: 0x232
    private void <PlayBigMapControlAnim>b__88_0()
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_dcf8 = *(int64*)(DAT_181dadcf8 + 184);
        bool cVar1;
        long lVar2;
        this.bigMapControlAniming = 0;
        if ((*pStatics_2cc8 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            cVar1 = HeroData.HaveMission(lVar2,"巴陵盗匪",0);
            if (cVar1) {
              if (*pStatics_dcf8 == 0) throw; // [null/range check failed]
              TutorialController.StartTutorial(*pStatics_dcf8,"大地图",0);
            }
            if ((*pStatics_2cc8 != 0) &&
               (lVar2 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 != null) {
                if (*(int64 *)(lVar2 + 0x208) == 0) {
                  return;
                }
                if (*pStatics_dcf8 != 0) {
                  TutorialController.StartTutorial(*pStatics_dcf8,"马匹系统",0)
                  ;
                  return;
                }
              }
            }
          }
        }
    }

}
