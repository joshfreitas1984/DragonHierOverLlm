// ============================================================
// Type  : ActionBarController
// Token : 0x2000138
// ============================================================

public class ActionBarController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000790
    public GameObject actionBarUnitRoot;

    // Token: 0x4000791
    public GameObject actionBarUnitPrefab;

    // Token: 0x4000792
    public List<GameObject> actionBarUnits;

    // Token: 0x4000793
    private static ActionBarController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A03
    // RVA   : 0x784050   Offset: 0x782E50   Length: 0x36
    public static ActionBarController get_Instance()
    {
        return **(uint64 **)(DAT_181e8a9b8 + 184);
    }

    // Token : 0x6000A04
    // RVA   : 0x7838F0   Offset: 0x7826F0   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e8a9b8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181e8a9b8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000A05
    // RVA   : 0x783DF0   Offset: 0x782BF0   Length: 0x25F
    public void SortActionBarUnit()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        uint[] local_res8 = new uint[2];
        lVar5 = this.actionBarUnitRoot;
        iVar7 = 0;
        local_res8[0] = 0;
        if (lVar5 != null) {
          while (lVar5 = GameObject.get_transform(lVar5,0)) != null {
            iVar4 = Transform.get_childCount(lVar5,0);
            lVar5 = this.actionBarUnitRoot;
            if (iVar4 <= iVar7) {
              GlobalData.SortChild(lVar5,0);
              return;
            }
            if ((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) break;
            lVar5 = Transform.GetChild(lVar5,iVar7,0);
            lVar6 = FUN_1802101c0(0);
            if (lVar6 == null) break;
            uVar1 = *(uint64 *)(lVar6 + 0x110);
            if ((((this.actionBarUnitRoot == null) ||
                 (lVar6 = GameObject.get_transform(this.actionBarUnitRoot,0)) == null) ||
                (lVar6 = Transform.GetChild(lVar6,iVar7,0)) == null) ||
               (lVar6 = Component.GetComponent(lVar6,DAT_181e763c8)) == null) break;
            uVar2 = *(uint64 *)(lVar6 + 24);
            cVar3 = Object.op_Equality(uVar1,uVar2);
            if (!cVar3) {
              if (((this.actionBarUnitRoot == null) ||
                  (lVar6 = GameObject.get_transform(this.actionBarUnitRoot,0)) == null) ||
                 ((lVar6 = Transform.GetChild(lVar6,iVar7,0), lVar6 == null ||
                  ((lVar6 = Component.GetComponent(lVar6,DAT_181e763c8), lVar6 == null ||
                   (*(int64 *)(lVar6 + 24) == 0)))))) break;
              Single.ToString(*(int64 *)(lVar6 + 24) + 180,"000.000");
            }
            else {
              local_res8[0] = 999999;
              Int32.ToString(local_res8,0);
            }
            if (lVar5 == null) break;
            Object.set_name(lVar5);
            lVar5 = this.actionBarUnitRoot;
            iVar7 = iVar7 + 1;
            if (lVar5 == null) break;
          }
        }
    }

    // Token : 0x6000A06
    // RVA   : 0x7839D0   Offset: 0x7827D0   Length: 0x56
    public void ClearActionBar()
    {
        ulong uVar1;
        uVar1 = this.actionBarUnits;
        GlobalData.DestroyAll(uVar1,0);
    }

    // Token : 0x6000A07
    // RVA   : 0x783A30   Offset: 0x782830   Length: 0x3B9
    public void GenerateActionBar(BattleUnit targetBattleUnit)
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar3 = this.actionBarUnits;
        uVar2 = this.actionBarUnitRoot;
        uVar4 = this.actionBarUnitPrefab;
        uVar2 = GlobalData.AddChild(uVar2,uVar4,0);
        if (lVar3 != null) {
          FUN_18175de30(lVar3,uVar2,DAT_181e6b6f8);
          lVar3 = this.actionBarUnits;
          if (lVar3 != null) {
            uVar1 = lVar3.Count;
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar3._items + 24 + (int64)(int)uVar1 * 8);
            if (lVar3 != null) {
              lVar3 = GameObject.GetComponent(lVar3,DAT_181e52ff0);
              if (lVar3 != null) {
                lVar3.Count = targetBattleUnit;
                lVar3 = this.actionBarUnits;
                if (lVar3 != null) {
                  uVar1 = lVar3.Count;
                  if (uVar1 <= uVar1 - 1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar3._items + 24 + (int64)(int)uVar1 * 8);
                  if (lVar3 != null) {
                    lVar3 = GameObject.get_transform(lVar3,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"TextBack",0);
                      if (lVar3 != null) {
                        lVar3 = Component.get_transform(lVar3,0);
                        if (lVar3 != null) {
                          lVar3 = Transform.Find(lVar3,"Text",0);
                          if (lVar3 != null) {
                            uVar2 = Component.GetComponent(lVar3,DAT_181e79538);
                            if ((targetBattleUnit != null) && (*(int64 *)(targetBattleUnit + 64) != 0)) {
                              uVar4 = HeroData.HeroName(*(int64 *)(targetBattleUnit + 64),1,0);
                              LTLocalization.SetText(uVar2,uVar4,0);
                              lVar3 = this.actionBarUnits;
                              if (lVar3 != null) {
                                uVar1 = lVar3.Count;
                                if (uVar1 <= uVar1 - 1) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar3 = *(int64 *)
                                         (lVar3._items + 24 + (int64)(int)uVar1 * 8);
                                if (lVar3 != null) {
                                  lVar3 = GameObject.get_transform(lVar3,0);
                                  if (lVar3 != null) {
                                    lVar3 = Transform.Find(lVar3,"Icon",0);
                                    if (lVar3 != null) {
                                      plVar5 = (int64 *)Component.GetComponent(lVar3);
                                      if (*(int64 *)(targetBattleUnit + 88) != 0) {
                                        if (*(int *)(*(int64 *)(targetBattleUnit + 88) + 16) == 0) {
                                          puVar6 = (uint32 *)Color.get_green();
                                        }
                                        else {
                                          puVar6 = (uint32 *)Color.get_red(&local_18);
                                        }
                                        if (plVar5 != (int64 *)0) {
                                          local_18 = *puVar6;
                                          uStack_14 = puVar6[1];
                                          uStack_10 = puVar6[2];
                                          uStack_c = puVar6[3];
                                          (**(code **)(*plVar5 + 0x2a8))
                                                    (plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
                                          lVar3 = this.actionBarUnits;
                                          if (lVar3 != null) {
                                            uVar1 = lVar3.Count;
                                            if (uVar1 <= uVar1 - 1) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            lVar3 = *(int64 *)
                                                     (lVar3._items + 24 +
                                                     (int64)(int)uVar1 * 8);
                                            if (lVar3 != null) {
                                              uVar2 = GameObject.GetComponent(lVar3,DAT_181e52ff0);
                                              *(uint64 *)(targetBattleUnit + 160) = uVar2;
                                              lVar3 = this.actionBarUnits;
                                              if (lVar3 != null) {
                                                uVar1 = lVar3.Count;
                                                if (uVar1 <= uVar1 - 1) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                lVar3 = *(int64 *)
                                                         (lVar3._items + 24 +
                                                         (int64)(int)uVar1 * 8);
                                                if (lVar3 != null) {
                                                  lVar3 = GameObject.GetComponent(lVar3,DAT_181e52ff0);
                                                  if (lVar3 != null) {
                                                    ActionBarUnit.RefreshActionBarUnit(lVar3,0,0);
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

    // Token : 0x6000A08
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
