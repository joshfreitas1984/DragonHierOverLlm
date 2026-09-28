// ============================================================
// Type  : ItemListController
// Token : 0x20002F2
// ============================================================

public class ItemListController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400185E
    public GameObject itemGrid;

    // Token: 0x400185F
    public ItemListInteractType itemListInteractType;

    // Token: 0x4001860
    public ItemListType forceItemListType;

    // Token: 0x4001861
    public ItemListType nowItemListType;

    // Token: 0x4001862
    public ItemListData targetItemList;

    // Token: 0x4001863
    public GameObject showAllButton;

    // Token: 0x4001864
    public bool noEquipedItem;

    // Token: 0x4001865
    public bool recordSortType;

    // Token: 0x4001866
    public Dropdown sortTypeDropDown;

    // Token: 0x4001867
    public ItemSortType itemSortType;

    // Token: 0x4001868
    public bool reverseOrder;

    // Token: 0x4001869
    private bool isRefreshing;

    // Token: 0x400186A
    private ScrollRect scrollRect;

    // Token: 0x400186B
    private RectTransform contentRect;

    // Token: 0x400186C
    private RectTransform viewportRect;

    // Token: 0x400186D
    private readonly List<ItemData> currentDataList;

    // Token: 0x400186E
    private readonly Dictionary<int, GameObject> activeItemMap;

    // Token: 0x400186F
    private float cellWidth;

    // Token: 0x4001870
    private float cellHeight;

    // Token: 0x4001871
    private float spacingX;

    // Token: 0x4001872
    private float spacingY;

    // Token: 0x4001873
    private int paddingLeft;

    // Token: 0x4001874
    private int paddingRight;

    // Token: 0x4001875
    private int paddingTop;

    // Token: 0x4001876
    private int paddingBottom;

    // Token: 0x4001877
    private int columnCount;

    // Token: 0x4001878
    private Constraint gridConstraint;

    // Token: 0x4001879
    private int gridConstraintCount;

    // Token: 0x400187A
    private TextAnchor gridChildAlignment;

    // Token: 0x400187B
    private static readonly Queue<GameObject> sharedItemIconPool;

    // Token: 0x400187C
    private const int MaxSharedPoolSize;

    // Token: 0x400187D
    private static Transform poolRoot;

    // Token: 0x400187E
    private readonly List<int> toRemoveCache;

    // Token: 0x400187F
    private int lastMinIndex;

    // Token: 0x4001880
    private int lastMaxIndex;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001889
    // RVA   : 0xCA6BD0   Offset: 0xCA5FD0   Length: 0x18E
    private static Transform GetPoolRoot()
    {
        var pStatics = *(int64*)(DAT_181d82198 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(pStatics + 8);
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = new GameObject("[SharedItemIconPool]",0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = GameObject.get_transform(lVar2,0);
          puVar4 = (uint64 *)(pStatics + 8);
          *puVar4 = uVar3;
          il2cpp_internal(puVar4,uVar3);
          Object.DontDestroyOnLoad(lVar2,0);
        }
        return *(uint64 *)(pStatics + 8);
    }

    // Token : 0x600188A
    // RVA   : 0xCA58B0   Offset: 0xCA4CB0   Length: 0x502
    private void Awake()
    {
        bool cVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        if (this.itemGrid == null) throw; // [null/range check failed]
        uVar3 = GameObject.GetComponent(this.itemGrid,DAT_181d72bc8);
        this.contentRect = uVar3;
        uVar3 = Component.GetComponentInParent(this,DAT_181d97b60);
        this.scrollRect = uVar3;
        uVar3 = this.scrollRect;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          if (this.itemGrid == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform();
          if (lVar4 == null) throw; // [null/range check failed]
          uVar3 = FUN_180da9a20(lVar4);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.itemGrid == null) throw; // [null/range check failed]
            lVar4 = GameObject.get_transform();
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = FUN_180da9a20(lVar4);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar3 = FUN_180da9a20(lVar4);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              if (this.itemGrid == null) throw; // [null/range check failed]
              lVar4 = GameObject.get_transform(this.itemGrid,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = FUN_180da9a20(lVar4,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = FUN_180da9a20(lVar4,0);
              if (lVar4 == null) throw; // [null/range check failed]
              uVar3 = Component.GetComponent(lVar4,DAT_181d951e0);
              this.scrollRect = uVar3;
            }
          }
        }
        uVar3 = this.scrollRect;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          if (this.scrollRect == null) throw; // [null/range check failed]
          uVar3 = *(uint64 *)(this.scrollRect + 56);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          lVar4 = this.scrollRect;
          if (!cVar1) {
            if (lVar4 == null) throw; // [null/range check failed]
            plVar5 = (int64 *)Component.get_transform();
            plVar6 = (int64 *)0;
            if (plVar5 != (int64 *)0) {
              if (*plVar5 == DAT_181d9a580) {
                plVar6 = plVar5;
              }
              if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar5,DAT_181d9a580);
              }
            }
          }
          else {
            if (lVar4 == null) throw; // [null/range check failed]
            plVar6 = *(int64 **)(lVar4 + 56);
          }
          this.viewportRect = plVar6;
          if (this.scrollRect == null) throw; // [null/range check failed]
          lVar4 = *(int64 *)(this.scrollRect + 96);
          uVar3 = new OnTooltipCB(this,DAT_181d7d2e8,DAT_181d7c098);
          if (lVar4 == null) throw; // [null/range check failed]
          FUN_180feab20(lVar4,uVar3,DAT_181d7d008);
        }
        if (this.itemGrid == null) throw; // [null/range check failed]
        lVar4 = GameObject.GetComponent(this.itemGrid,DAT_181d71798);
        cVar1 = Object.op_Inequality(lVar4,0,0);
        if (cVar1) {
          if (lVar4 == null) throw; // [null/range check failed]
          this.cellWidth = *(uint32 *)(lVar4 + 96);
          this.cellHeight = *(uint32 *)(lVar4 + 100);
          this.spacingX = *(uint32 *)(lVar4 + 104);
          this.spacingY = *(uint32 *)(lVar4 + 108);
          if (*(int64 *)(lVar4 + 24) == 0) throw; // [null/range check failed]
          uVar2 = RectOffset.get_left(*(int64 *)(lVar4 + 24),0);
          this.paddingLeft = uVar2;
          if (*(int64 *)(lVar4 + 24) == 0) throw; // [null/range check failed]
          uVar2 = RectOffset.get_right(*(int64 *)(lVar4 + 24),0);
          this.paddingRight = uVar2;
          if (*(int64 *)(lVar4 + 24) == 0) throw; // [null/range check failed]
          uVar2 = RectOffset.get_top(*(int64 *)(lVar4 + 24),0);
          this.paddingTop = uVar2;
          if (*(int64 *)(lVar4 + 24) == 0) throw; // [null/range check failed]
          uVar2 = RectOffset.get_bottom(*(int64 *)(lVar4 + 24),0);
          this.paddingBottom = uVar2;
          this.gridConstraint = *(uint32 *)(lVar4 + 112);
          this.gridConstraintCount = *(uint32 *)(lVar4 + 116);
          this.gridChildAlignment = *(uint32 *)(lVar4 + 32);
          Behaviour.set_enabled(lVar4,0,0);
        }
        if (this.itemGrid != null) {
          lVar4 = GameObject.GetComponent(this.itemGrid,DAT_181dc81d8);
          cVar1 = Object.op_Inequality(lVar4,0,0);
          if (cVar1) {
            if (lVar4 == null) throw; // [null/range check failed]
            Behaviour.set_enabled(lVar4,0,0);
          }
          return;
        }
    }

    // Token : 0x600188B
    // RVA   : 0xCA6D60   Offset: 0xCA6160   Length: 0xF2
    private void OnDestroy()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uVar3 = this.scrollRect;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          return;
        }
        if (this.scrollRect != null) {
          lVar1 = *(int64 *)(this.scrollRect + 96);
          uVar3 = new OnTooltipCB(this,DAT_181d7d2e8,DAT_181d7c098);
          if (lVar1 != null) {
            FUN_180fec6d0(lVar1,uVar3,DAT_181d7d108);
            return;
          }
        }
    }

    // Token : 0x600188C
    // RVA   : 0xCA6060   Offset: 0xCA5460   Length: 0x139
    public void ChangeListType(GameObject ButtonClicked)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if (!this.isRefreshing) {
          if ((ButtonClicked == null) || (lVar4 = GameObject.GetComponent(ButtonClicked,DAT_181d743b0)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(lVar4 + 0x118) != false) {
            iVar1 = this.nowItemListType;
            uVar5 = Object.get_name(ButtonClicked,0);
            iVar2 = Int32.Parse(uVar5,0);
            if (iVar1 != iVar2) {
              uVar5 = Object.get_name(ButtonClicked,0);
              uVar3 = Int32.Parse(uVar5,0);
              this.nowItemListType = uVar3;
              ItemListController.RefreshItemList
                        (this,this.targetItemList,this.itemListInteractType,1,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
            }
          }
        }
    }

    // Token : 0x600188D
    // RVA   : 0xCA8030   Offset: 0xCA7430   Length: 0xCD
    public void ResetListType()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = this.showAllButton;
        this.nowItemListType = 7;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if ((this.showAllButton != null) &&
           (lVar3 = GameObject.GetComponent(this.showAllButton,DAT_181d743b0)) != null) {
          Selectable.set_interactable(lVar3,1,0);
          if ((this.showAllButton != null) &&
             (lVar3 = GameObject.GetComponent(this.showAllButton,DAT_181d743b0)) != null)
          {
            Toggle.set_isOn(lVar3,1,0);
            return;
          }
        }
    }

    // Token : 0x600188E
    // RVA   : 0xCA6740   Offset: 0xCA5B40   Length: 0x39B
    public void ClearAllItem()
    {
        var pStatics = *(int64*)(DAT_181d8b790 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong local_60;
        ulong uStack_58;
        ulong local_50;
        ulong uStack_48;
        ulong local_40;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        uVar3 = *(uint64 *)(pStatics + 72);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          lVar2 = *(int64 *)(pStatics + 72);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = GameObject.get_transform(lVar2,0);
          if (this.itemGrid == null) throw; // [null/range check failed]
          uVar3 = GameObject.get_transform(this.itemGrid,0);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = Transform.IsChildOf(lVar2,uVar3,0);
          if (cVar1) {
            puVar4 = (uint64 *)(pStatics + 72);
            *puVar4 = 0;
            il2cpp_internal(puVar4,0);
            uVar3 = FUN_180c95aa0(0);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              lVar2 = FUN_180c95aa0(0);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2 = Component.get_gameObject(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              cVar1 = GameObject.get_activeSelf(lVar2,0);
              if (cVar1) {
                lVar2 = FUN_180c95aa0(0);
                if (lVar2 == null) throw; // [null/range check failed]
                lVar2 = Component.get_gameObject(lVar2,0);
                if (lVar2 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar2,0,0);
              }
            }
          }
        }
        if (this.activeItemMap != null) {
          FUN_1808abff0(&local_38,this.activeItemMap,DAT_181db9dc0);
          local_60 = local_38;
          uStack_58 = uStack_30;
          local_50 = local_28;
          uStack_48 = uStack_20;
          local_40 = local_18;
          while( true ) {
            cVar1 = FUN_1811c5af0(&local_60,DAT_181d985d8);
            if (!cVar1) break;
            ItemListController.RecycleIcon(this,uStack_48,0);
          }
          ZhSegment.Initialize(&local_60,DAT_181d98558);
          if (this.activeItemMap != null) {
            Dictionary_2.Clear(this.activeItemMap,DAT_181db9cb0);
            if (this.currentDataList != null) {
              FUN_1812f9a10(this.currentDataList,DAT_181d90b18);
              return;
            }
          }
        }
    }

    // Token : 0x600188F
    // RVA   : 0xCA7310   Offset: 0xCA6710   Length: 0x485
    private void RecycleIcon(GameObject iconGo)
    {
        var pStatics_2198 = *(int64*)(DAT_181d82198 + 184);
        var pStatics_b790 = *(int64*)(DAT_181d8b790 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        cVar1 = Object.op_Equality(iconGo,0,0);
        if (cVar1) {
          return;
        }
        if (iconGo == null) throw; // [null/range check failed]
        GameObject.SetActive(iconGo,0,0);
        uVar4 = *(uint64 *)(pStatics_b790 + 72);
        cVar1 = Object.op_Equality(uVar4,iconGo,0);
        if (cVar1) {
          puVar5 = (uint64 *)(pStatics_b790 + 72);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
        }
        lVar2 = GameObject.GetComponent(iconGo,DAT_181d720a0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 == null) throw; // [null/range check failed]
          lVar3 = Component.get_transform(lVar2,0);
          puVar5 = (uint64 *)Vector3.get_one(local_18,0);
          if (lVar3 == null) throw; // [null/range check failed]
          local_20 = *(uint32 *)(puVar5 + 1);
          local_28 = *puVar5;
          Transform.set_localScale(lVar3,&local_28,0);
          *(uint64 *)(lVar2 + 32) = 0;
          *(uint64 *)(lVar2 + 56) = 0;
          *(uint32 *)(lVar2 + 24) = 0xffffffff;
          *(uint64 *)(lVar2 + 40) = 1;
          *(uint32 *)(lVar2 + 52) = 0x1000000;
          *(uint32 *)(lVar2 + 48) = 0;
        }
        if (*pStatics_2198 != 0) {
          if (59 < *(int *)(*pStatics_2198 + 32)) {
            Object.Destroy(iconGo,0);
            return;
          }
          lVar2 = GameObject.get_transform(iconGo,0);
          uVar4 = *(uint64 *)(pStatics_2198 + 8);
          cVar1 = Object.op_Equality(uVar4,0,0);
          if (cVar1) {
            lVar3 = new GameObject("[SharedItemIconPool]",0);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar4 = GameObject.get_transform(lVar3,0);
            puVar5 = (uint64 *)(pStatics_2198 + 8);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            Object.DontDestroyOnLoad(lVar3,0);
          }
          if (lVar2 != null) {
            Transform.SetParent(lVar2,*(uint64 *)(pStatics_2198 + 8),0,0);
            if (*pStatics_2198 != 0) {
              FUN_181661f90(*pStatics_2198,iconGo,DAT_181dc0820);
              return;
            }
          }
        }
    }

    // Token : 0x6001890
    // RVA   : 0xCA7E10   Offset: 0xCA7210   Length: 0x21B
    private GameObject RentIcon()
    {
        var pStatics_2198 = *(int64*)(DAT_181d82198 + 184);
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        do {
          if (*pStatics_2198 == 0) throw; // [null/range check failed]
          lVar3 = 0;
          if (*(int *)(*pStatics_2198 + 32) < 1) break;
          if (*pStatics_2198 == 0) throw; // [null/range check failed]
          lVar3 = FUN_181661be0(*pStatics_2198,DAT_181dc07a0);
          cVar2 = Object.op_Inequality(lVar3,0,0);
        } while (!cVar2);
        cVar2 = Object.op_Inequality(lVar3,0,0);
        if (!cVar2) {
          uVar5 = this.itemGrid;
          if (*pStatics_2ee8 != 0) {
            uVar1 = *(uint64 *)(*pStatics_2ee8 + 160);
            lVar3 = GlobalData.AddChild(uVar5,uVar1,0);
            return lVar3;
          }
        }
        else if (lVar3 != null) {
          lVar4 = GameObject.get_transform(lVar3,0);
          if ((this.itemGrid != null) &&
             (uVar5 = GameObject.get_transform(this.itemGrid,0), lVar4 != null)) {
            Transform.SetParent(lVar4,uVar5,0,0);
            GameObject.SetActive(lVar3,1,0);
            return lVar3;
          }
        }
    }

    // Token : 0x6001891
    // RVA   : 0xCA77D0   Offset: 0xCA6BD0   Length: 0x23
    public void RefreshItemList(bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,uint64 resetPos,int param_3,char param_4)
        {
        char cVar1;
        uint8 uVar2;
        int iVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        uint32 uVar9;
        uint32 uVar10;
        uint32 local_48 [2];
        int64 local_40;
        uVar10 = 0;
        local_40 = 0;
        local_48[0] = 0;
        if (!this.isRefreshing) {
          this.isRefreshing = 1;
          this.itemListInteractType = param_3;
          uVar5 = this.showAllButton;
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (cVar1) {
            uVar9 = uVar10;
            if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Component.GetComponent(lVar4,DAT_181d962e0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                Selectable.set_interactable(lVar4);
                uVar9 = uVar9 + 1;
              }
            }
            else {
              this.nowItemListType = this.forceItemListType;
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = Component.TryGetComponent(lVar4);
                if (cVar1) {
                  uVar5 = Object.get_name(lVar4,0);
                  local_48[0] = this.forceItemListType;
                  uVar6 = Int32.ToString(local_48,0);
                  uVar2 = FUN_18171e540(uVar5,uVar6);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Toggle.set_isOn(local_40,uVar2);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Selectable.set_interactable();
                }
                uVar9 = uVar9 + 1;
              }
            }
          }
          this.targetItemList = resetPos;
          lVar4 = this.targetItemList;
          if (lVar4 == null) {
            ItemListController.ClearAllItem(this,0);
            this.isRefreshing = 0;
          }
          else {
            uVar9 = this.nowItemListType;
            if (uVar9 == 7) {
              lVar4 = lVar4.allItem;
            }
            else {
              lVar4 = lVar4.itemTypeList;
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar4.money <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.heroID[uVar9];
            }
            if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1812f9a10(this.currentDataList,DAT_181d90b18);
            while( true ) {
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((int)lVar4.money <= (int)uVar10) break;
              if (lVar4.money <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = lVar4.heroID[uVar10];
              if (!this.noEquipedItem) {
        LAB_180ca7b99:
                if (param_3 < 2 || 5 < param_3) {
        LAB_180ca7c19:
                  if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_18181e0a0();
                }
                else {
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar7 = FUN_18046c6c0();
                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int *)(lVar7 + 168) <= iVar3) {
                    iVar3 = *(int *)(lVar8 + 60);
                    lVar8 = FUN_18046c6c0();
                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180ca7c19;
                  }
                }
              }
              else {
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = ItemData.Equiped();
                if (!cVar1) goto LAB_180ca7b99;
              }
              uVar10 = uVar10 + 1;
            }
            ItemListController.ResetSortType(this,0);
            ItemListController.CalculateLayout(this,0);
            if (param_4) {
              uVar5 = this.scrollRect;
              cVar1 = Object.op_Inequality(uVar5,0,0);
              if (cVar1) {
                if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar5 = *(uint64 *)(this.scrollRect + 72);
                cVar1 = Object.op_Inequality(uVar5,0,0);
                if (cVar1) {
                  if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar4 = *(int64 *)(this.scrollRect + 72);
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Scrollbar.set_value(lVar4,0x3f800000,0);
                }
              }
            }
            ItemListController.UpdateVisibleCells(this,1,0);
            this.isRefreshing = 0;
          }
        }
    }

    // Token : 0x6001892
    // RVA   : 0xCA7DF0   Offset: 0xCA71F0   Length: 0x1F
    public void RefreshItemList(ItemListData _targetItemList, bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,uint64 _targetItemList,int resetPos,char param_4)
        {
        char cVar1;
        uint8 uVar2;
        int iVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        uint32 uVar9;
        uint32 uVar10;
        uint32 local_48 [2];
        int64 local_40;
        uVar10 = 0;
        local_40 = 0;
        local_48[0] = 0;
        if (!this.isRefreshing) {
          this.isRefreshing = 1;
          this.itemListInteractType = resetPos;
          uVar5 = this.showAllButton;
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (cVar1) {
            uVar9 = uVar10;
            if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Component.GetComponent(lVar4,DAT_181d962e0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                Selectable.set_interactable(lVar4);
                uVar9 = uVar9 + 1;
              }
            }
            else {
              this.nowItemListType = this.forceItemListType;
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = Component.TryGetComponent(lVar4);
                if (cVar1) {
                  uVar5 = Object.get_name(lVar4,0);
                  local_48[0] = this.forceItemListType;
                  uVar6 = Int32.ToString(local_48,0);
                  uVar2 = FUN_18171e540(uVar5,uVar6);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Toggle.set_isOn(local_40,uVar2);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Selectable.set_interactable();
                }
                uVar9 = uVar9 + 1;
              }
            }
          }
          this.targetItemList = _targetItemList;
          lVar4 = this.targetItemList;
          if (lVar4 == null) {
            ItemListController.ClearAllItem(this,0);
            this.isRefreshing = 0;
          }
          else {
            uVar9 = this.nowItemListType;
            if (uVar9 == 7) {
              lVar4 = lVar4.allItem;
            }
            else {
              lVar4 = lVar4.itemTypeList;
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar4.money <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.heroID[uVar9];
            }
            if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1812f9a10(this.currentDataList,DAT_181d90b18);
            while( true ) {
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((int)lVar4.money <= (int)uVar10) break;
              if (lVar4.money <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = lVar4.heroID[uVar10];
              if (!this.noEquipedItem) {
        LAB_180ca7b99:
                if (resetPos < 2 || 5 < resetPos) {
        LAB_180ca7c19:
                  if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_18181e0a0();
                }
                else {
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar7 = FUN_18046c6c0();
                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int *)(lVar7 + 168) <= iVar3) {
                    iVar3 = *(int *)(lVar8 + 60);
                    lVar8 = FUN_18046c6c0();
                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180ca7c19;
                  }
                }
              }
              else {
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = ItemData.Equiped();
                if (!cVar1) goto LAB_180ca7b99;
              }
              uVar10 = uVar10 + 1;
            }
            ItemListController.ResetSortType(this,0);
            ItemListController.CalculateLayout(this,0);
            if (param_4) {
              uVar5 = this.scrollRect;
              cVar1 = Object.op_Inequality(uVar5,0,0);
              if (cVar1) {
                if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar5 = *(uint64 *)(this.scrollRect + 72);
                cVar1 = Object.op_Inequality(uVar5,0,0);
                if (cVar1) {
                  if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar4 = *(int64 *)(this.scrollRect + 72);
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Scrollbar.set_value(lVar4,0x3f800000,0);
                }
              }
            }
            ItemListController.UpdateVisibleCells(this,1,0);
            this.isRefreshing = 0;
          }
        }
    }

    // Token : 0x6001893
    // RVA   : 0xCA77A0   Offset: 0xCA6BA0   Length: 0x22
    public void RefreshItemList(ItemListInteractType _itemListInteractType, bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,uint64 _itemListInteractType,int resetPos,char param_4)
        {
        char cVar1;
        uint8 uVar2;
        int iVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        uint32 uVar9;
        uint32 uVar10;
        uint32 local_48 [2];
        int64 local_40;
        uVar10 = 0;
        local_40 = 0;
        local_48[0] = 0;
        if (!this.isRefreshing) {
          this.isRefreshing = 1;
          this.itemListInteractType = resetPos;
          uVar5 = this.showAllButton;
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (cVar1) {
            uVar9 = uVar10;
            if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Component.GetComponent(lVar4,DAT_181d962e0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                Selectable.set_interactable(lVar4);
                uVar9 = uVar9 + 1;
              }
            }
            else {
              this.nowItemListType = this.forceItemListType;
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = Component.TryGetComponent(lVar4);
                if (cVar1) {
                  uVar5 = Object.get_name(lVar4,0);
                  local_48[0] = this.forceItemListType;
                  uVar6 = Int32.ToString(local_48,0);
                  uVar2 = FUN_18171e540(uVar5,uVar6);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Toggle.set_isOn(local_40,uVar2);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Selectable.set_interactable();
                }
                uVar9 = uVar9 + 1;
              }
            }
          }
          this.targetItemList = _itemListInteractType;
          lVar4 = this.targetItemList;
          if (lVar4 == null) {
            ItemListController.ClearAllItem(this,0);
            this.isRefreshing = 0;
          }
          else {
            uVar9 = this.nowItemListType;
            if (uVar9 == 7) {
              lVar4 = lVar4.allItem;
            }
            else {
              lVar4 = lVar4.itemTypeList;
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar4.money <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.heroID[uVar9];
            }
            if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1812f9a10(this.currentDataList,DAT_181d90b18);
            while( true ) {
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((int)lVar4.money <= (int)uVar10) break;
              if (lVar4.money <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = lVar4.heroID[uVar10];
              if (!this.noEquipedItem) {
        LAB_180ca7b99:
                if (resetPos < 2 || 5 < resetPos) {
        LAB_180ca7c19:
                  if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_18181e0a0();
                }
                else {
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar7 = FUN_18046c6c0();
                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int *)(lVar7 + 168) <= iVar3) {
                    iVar3 = *(int *)(lVar8 + 60);
                    lVar8 = FUN_18046c6c0();
                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180ca7c19;
                  }
                }
              }
              else {
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = ItemData.Equiped();
                if (!cVar1) goto LAB_180ca7b99;
              }
              uVar10 = uVar10 + 1;
            }
            ItemListController.ResetSortType(this,0);
            ItemListController.CalculateLayout(this,0);
            if (param_4) {
              uVar5 = this.scrollRect;
              cVar1 = Object.op_Inequality(uVar5,0,0);
              if (cVar1) {
                if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar5 = *(uint64 *)(this.scrollRect + 72);
                cVar1 = Object.op_Inequality(uVar5,0,0);
                if (cVar1) {
                  if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar4 = *(int64 *)(this.scrollRect + 72);
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Scrollbar.set_value(lVar4,0x3f800000,0);
                }
              }
            }
            ItemListController.UpdateVisibleCells(this,1,0);
            this.isRefreshing = 0;
          }
        }
    }

    // Token : 0x6001894
    // RVA   : 0xCA7800   Offset: 0xCA6C00   Length: 0x5E3
    public void RefreshItemList(ItemListData _targetItemList, ItemListInteractType _itemListInteractType, bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,uint64 _targetItemList,int _itemListInteractType,char resetPos)
        {
        char cVar1;
        uint8 uVar2;
        int iVar3;
        int64 lVar4;
        uint64 uVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        uint32 uVar9;
        uint32 uVar10;
        uint32 local_48 [2];
        int64 local_40;
        uVar10 = 0;
        local_40 = 0;
        local_48[0] = 0;
        if (!this.isRefreshing) {
          this.isRefreshing = 1;
          this.itemListInteractType = _itemListInteractType;
          uVar5 = this.showAllButton;
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (cVar1) {
            uVar9 = uVar10;
            if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Component.GetComponent(lVar4,DAT_181d962e0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                Selectable.set_interactable(lVar4);
                uVar9 = uVar9 + 1;
              }
            }
            else {
              this.nowItemListType = this.forceItemListType;
              while( true ) {
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar3 = Transform.get_childCount(lVar4,0);
                if (iVar3 <= (int)uVar9) break;
                if (this.showAllButton == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = GameObject.get_transform(this.showAllButton,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180da9a20(lVar4,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = Transform.GetChild(lVar4,uVar9,0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = Component.TryGetComponent(lVar4);
                if (cVar1) {
                  uVar5 = Object.get_name(lVar4,0);
                  local_48[0] = this.forceItemListType;
                  uVar6 = Int32.ToString(local_48,0);
                  uVar2 = FUN_18171e540(uVar5,uVar6);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Toggle.set_isOn(local_40,uVar2);
                  if (local_40 == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Selectable.set_interactable();
                }
                uVar9 = uVar9 + 1;
              }
            }
          }
          this.targetItemList = _targetItemList;
          lVar4 = this.targetItemList;
          if (lVar4 == null) {
            ItemListController.ClearAllItem(this,0);
            this.isRefreshing = 0;
          }
          else {
            uVar9 = this.nowItemListType;
            if (uVar9 == 7) {
              lVar4 = lVar4.allItem;
            }
            else {
              lVar4 = lVar4.itemTypeList;
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar4.money <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.heroID[uVar9];
            }
            if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1812f9a10(this.currentDataList,DAT_181d90b18);
            while( true ) {
              if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((int)lVar4.money <= (int)uVar10) break;
              if (lVar4.money <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = lVar4.heroID[uVar10];
              if (!this.noEquipedItem) {
        LAB_180ca7b99:
                if (_itemListInteractType < 2 || 5 < _itemListInteractType) {
        LAB_180ca7c19:
                  if (this.currentDataList == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  FUN_18181e0a0();
                }
                else {
                  if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar7 = FUN_18046c6c0();
                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int *)(lVar7 + 168) <= iVar3) {
                    iVar3 = *(int *)(lVar8 + 60);
                    lVar8 = FUN_18046c6c0();
                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180ca7c19;
                  }
                }
              }
              else {
                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                cVar1 = ItemData.Equiped();
                if (!cVar1) goto LAB_180ca7b99;
              }
              uVar10 = uVar10 + 1;
            }
            ItemListController.ResetSortType(this,0);
            ItemListController.CalculateLayout(this,0);
            if (resetPos) {
              uVar5 = this.scrollRect;
              cVar1 = Object.op_Inequality(uVar5,0,0);
              if (cVar1) {
                if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar5 = *(uint64 *)(this.scrollRect + 72);
                cVar1 = Object.op_Inequality(uVar5,0,0);
                if (cVar1) {
                  if (this.scrollRect == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar4 = *(int64 *)(this.scrollRect + 72);
                  if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  Scrollbar.set_value(lVar4,0x3f800000,0);
                }
              }
            }
            ItemListController.UpdateVisibleCells(this,1,0);
            this.isRefreshing = 0;
          }
        }
    }

    // Token : 0x6001895
    // RVA   : 0xCA5DC0   Offset: 0xCA51C0   Length: 0x295
    private void CalculateLayout()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;
        long lVar7;
        float fVar8;
        ulong local_48;
        ulong uStack_40;
        byte[] local_38 = new byte[48];
        local_48 = 0;
        uStack_40 = 0;
        if (this.gridConstraint == 1) {
          uVar3 = this.gridConstraintCount;
        }
        else if (this.gridConstraint == 2) {
          iVar4 = Mathf.Max(1,this.gridConstraintCount);
          if (this.currentDataList == null) throw; // [null/range check failed]
          uVar3 = Mathf.CeilToInt((float)this.currentDataList.Count / (float)iVar4,0)
          ;
        }
        else {
          uVar1 = this.viewportRect;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            lVar7 = this.contentRect;
          }
          else {
            lVar7 = this.viewportRect;
          }
          if (lVar7 == null) throw; // [null/range check failed]
          puVar6 = (uint64 *)RectTransform.get_rect(local_38,lVar7,0);
          local_48 = *puVar6;
          uStack_40 = puVar6[1];
          fVar8 = (float)FUN_180d98fa0(&local_48,0);
          uVar3 = Mathf.FloorToInt((this.spacingX +
                                    ((fVar8 - (float)this.paddingLeft) -
                                    (float)this.paddingRight)) /
                                    (this.spacingX + this.cellWidth),0);
        }
        uVar3 = Mathf.Max(1,uVar3);
        this.columnCount = uVar3;
        if (this.currentDataList != null) {
          Mathf.CeilToInt((float)this.currentDataList.Count /
                           (float)this.columnCount,0);
          uVar1 = this.viewportRect;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.viewportRect == null) throw; // [null/range check failed]
            puVar6 = (uint64 *)RectTransform.get_rect(local_38,this.viewportRect,0);
            local_48 = *puVar6;
            uStack_40 = puVar6[1];
            FUN_18044e2b0(&local_48,0);
          }
          uVar3 = Mathf.Max();
          lVar7 = this.contentRect;
          if (lVar7 != null) {
            uVar5 = RectTransform.get_sizeDelta(lVar7,0);
            RectTransform.set_sizeDelta(lVar7,CONCAT44(uVar3,uVar5),0);
            return;
          }
        }
    }

    // Token : 0x6001896
    // RVA   : 0xCA6E60   Offset: 0xCA6260   Length: 0x11
    private void OnScroll(Vector2 pos)
    {
        void FUN_180ca6e60(int64 this)
        {
        if (!this.isRefreshing) {
          ItemListController.UpdateVisibleCells(this,0,0);
          return;
        }
    }

    // Token : 0x6001897
    // RVA   : 0xCA8510   Offset: 0xCA7910   Length: 0x77E
    private void UpdateVisibleCells(bool forceRebind)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        float extraout_var;
        uint64 *puVar6;
        int64 lVar7;
        uint64 uVar8;
        int64 *plVar9;
        uint32 *puVar10;
        int64 lVar11;
        uint32 uVar12;
        float fVar13;
        float fVar14;
        uint64 local_d8;
        uint32 uStack_d0;
        uint32 uStack_cc;
        int local_c8;
        uint64 local_c0;
        uint64 uStack_b8;
        uint64 local_b0;
        uint64 uStack_a8;
        uint64 local_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uint64 local_70;
        uint64 uStack_68;
        local_70 = 0;
        uStack_68 = 0;
        if (this.currentDataList != null) {
          if (this.currentDataList.Count == null) {
            if (this.activeItemMap != null) {
              FUN_1808abff0(&local_98,this.activeItemMap,DAT_181db9dc0);
              local_c0 = local_98;
              uStack_b8 = uStack_90;
              local_b0 = local_88;
              uStack_a8 = uStack_80;
              local_a0 = local_78;
              while (cVar3 = FUN_1811c5af0(&local_c0,DAT_181d985d8), cVar3) {
                ItemListController.RecycleIcon(this,uStack_a8,0);
              }
              ZhSegment.Initialize(&local_c0,DAT_181d98558);
              if (this.activeItemMap != null) {
                Dictionary_2.Clear(this.activeItemMap,DAT_181db9cb0);
                return;
              }
            }
          }
          else if (this.contentRect != null) {
            RectTransform.get_anchoredPosition(this.contentRect,0);
            uVar8 = this.viewportRect;
            cVar3 = Object.op_Inequality(uVar8,0,0);
            if (!cVar3) {
              fVar13 = 600.0;
            }
            else {
              if (this.viewportRect == null) goto LAB_180ca8c78;
              puVar6 = (uint64 *)RectTransform.get_rect(&local_d8,this.viewportRect,0);
              local_70 = *puVar6;
              uStack_68 = puVar6[1];
              fVar13 = (float)FUN_18044e2b0(&local_70,0);
            }
            fVar14 = this.spacingY + this.cellHeight;
            iVar4 = Mathf.FloorToInt((extraout_var - (float)this.paddingTop) / fVar14,0);
            iVar4 = Mathf.Max(0,iVar4 + -1,0);
            iVar5 = Mathf.CeilToInt(((extraout_var + fVar13) - (float)this.paddingTop) / fVar14,
                                     0);
            if (this.currentDataList != null) {
              iVar4 = Mathf.Clamp(this.columnCount * iVar4,0,
                                   this.currentDataList.Count + -1,0);
              if (this.currentDataList != null) {
                iVar5 = Mathf.Clamp((iVar5 + 1) * this.columnCount + -1,0,
                                     this.currentDataList.Count + -1,0);
                if (((!forceRebind) && (iVar4 == this.lastMinIndex)) &&
                   (iVar5 == this.lastMaxIndex)) {
                  return;
                }
                this.lastMinIndex = iVar4;
                this.lastMaxIndex = iVar5;
                local_c8 = iVar5;
                if (this.toRemoveCache != null) {
                  FUN_1812f9a10(this.toRemoveCache,DAT_181d8f318);
                  if (this.activeItemMap != null) {
                    FUN_1808abff0(&local_98,this.activeItemMap,DAT_181db9dc0);
                    local_c0 = local_98;
                    uStack_b8 = uStack_90;
                    local_b0 = local_88;
                    uStack_a8 = uStack_80;
                    local_a0 = local_78;
                    while (cVar3 = FUN_1811c5af0(&local_c0,DAT_181d985d8), cVar3) {
                      uStack_d0 = (uint32)uStack_a8;
                      uStack_cc = uStack_a8._4_4_;
                      local_d8 = local_b0;
                      if (((forceRebind) || ((int)local_b0 < iVar4)) || (iVar5 < (int)local_b0)) {
                        ItemListController.RecycleIcon(this,uStack_a8,0);
                        if (this.toRemoveCache == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        FUN_18182a0b0(this.toRemoveCache,local_d8 & 0xffffffff);
                      }
                    }
                    ZhSegment.Initialize(&local_c0,DAT_181d98558);
                    uVar12 = 0;
                    lVar7 = this.toRemoveCache;
                    if (lVar7 != null) {
                      lVar11 = 32;
                      do {
                        if (lVar7.Count <= (int)uVar12) {
                          iVar1 = this.itemListInteractType;
                          goto LAB_180ca89a9;
                        }
                        lVar2 = this.activeItemMap;
                        if (lVar7 == null) break;
                        if (lVar7.Count <= uVar12) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        if (lVar2 == null) break;
                        FUN_18175d7a0(lVar2,*(uint32 *)(lVar7._items + lVar11),
                                      DAT_181db9e48);
                        uVar12 = uVar12 + 1;
                        lVar11 = lVar11 + 4;
                        lVar7 = this.toRemoveCache;
                      } while (lVar7 != null);
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180ca8c78:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180ca89a9:
        if (iVar5 < iVar4) {
          return;
        }
        if (this.activeItemMap == null) goto LAB_180ca8c78;
        cVar3 = FUN_1808ab490(this.activeItemMap,iVar4,DAT_181db9d38);
        if (!cVar3) {
          lVar7 = ItemListController.RentIcon(this,0);
          if (lVar7 == null) goto LAB_180ca8c78;
          uVar8 = GameObject.GetComponent(lVar7,DAT_181d72bc8);
          ItemListController.PositionItem(this,uVar8,iVar4,0);
          lVar11 = GameObject.GetComponent(lVar7,DAT_181d720a0);
          if ((this.currentDataList == null) ||
             (uVar8 = FUN_180002f80(this.currentDataList,iVar4,DAT_181d90f18), lVar11 == null))
          goto LAB_180ca8c78;
          *(uint64 *)(lVar11 + 32) = uVar8;
          *(int *)(lVar11 + 24) = iVar4;
          if (iVar1 < 2 || 5 < iVar1) {
            *(uint32 *)(lVar11 + 40) = (uint32)(this.itemListInteractType != null);
          }
          else {
            *(uint32 *)(lVar11 + 40) = 2;
            uVar8 = DAT_181dc3520;
            local_d8 = Type.GetTypeFromHandle(uVar8,0);
            plVar9 = (int64 *)il2cpp_value_box(DAT_181d82298,this + 32);
            if (plVar9 == (int64 *)0) goto LAB_180ca8c78;
            uVar8 = (**(code **)(*plVar9 + 0x168))(plVar9,*(uint64 *)(*plVar9 + 0x170));
            puVar10 = (uint32 *)il2cpp_object_unbox(plVar9);
            this.itemListInteractType = *puVar10;
            plVar9 = (int64 *)Enum.Parse(local_d8,uVar8,0);
            if (plVar9 == (int64 *)0) goto LAB_180ca8c78;
            if (*(int64 *)(*plVar9 + 64) != *(int64 *)(DAT_181dad2f8 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar9,DAT_181dad2f8);
            }
            puVar10 = (uint32 *)il2cpp_object_unbox();
            *(uint32 *)(lVar11 + 44) = *puVar10;
            *(uint8 *)(lVar11 + 55) = 1;
          }
          ItemIconController.AutoSetName
                    (lVar11,this.itemSortType,this.reverseOrder,0);
          if (this.activeItemMap == null) goto LAB_180ca8c78;
          FUN_1808ab370(this.activeItemMap,iVar4,lVar7);
        }
        iVar4 = iVar4 + 1;
        goto LAB_180ca89a9;
    }

    // Token : 0x6001898
    // RVA   : 0xCA6E80   Offset: 0xCA6280   Length: 0x482
    private void PositionItem(RectTransform rt, int index)
    {
        int iVar1;
        int iVar2;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float local_res8;
        float fStackX_c;
        float local_c8;
        float fStack_c4;
        uint64 local_c0;
        uint64 local_b0;
        uint64 uStack_a8;
        iVar6 = index / this.columnCount;
        index = index % this.columnCount;
        if (this.contentRect != null) {
          puVar3 = (uint64 *)RectTransform.get_rect(&local_c0,this.contentRect,0);
          local_b0 = *puVar3;
          uStack_a8 = puVar3[1];
          fVar7 = (float)FUN_180d98fa0(&local_b0,0);
          if (this.contentRect != null) {
            puVar3 = (uint64 *)RectTransform.get_rect(&local_c0,this.contentRect,0);
            local_b0 = *puVar3;
            uStack_a8 = puVar3[1];
            fVar8 = (float)FUN_18044e2b0(&local_b0,0);
            if (this.contentRect != null) {
              uVar4 = RectTransform.get_pivot(this.contentRect,0);
              fStackX_c = (float)((uint64)uVar4 >> 32);
              local_res8 = (float)uVar4;
              iVar2 = this.gridChildAlignment;
              fVar12 = -local_res8;
              fVar11 = (1.0 - fStackX_c) * fVar8;
              if (((iVar2 == 1) || (iVar2 == 4)) || (iVar2 == 7)) {
                if (this.currentDataList == null) throw; // [null/range check failed]
                iVar2 = this.currentDataList.Count;
                iVar1 = this.columnCount;
                if (iVar2 < iVar1) {
                  iVar1 = Mathf.Max(1,iVar2,0);
                }
                fVar9 = this.cellWidth;
                iVar2 = Mathf.Max(0,iVar1 + -1,0);
                fVar9 = -((float)iVar1 * fVar9 + this.spacingX * (float)iVar2) * 0.5 +
                        this.cellWidth * 0.5 +
                        (this.cellWidth + this.spacingX) * (float)index;
              }
              else {
                fVar9 = (this.cellWidth + this.spacingX) * (float)index +
                        (float)this.paddingLeft + fVar12 * fVar7 +
                        this.cellWidth * 0.5;
              }
              iVar2 = this.gridChildAlignment;
              if (this.currentDataList != null) {
                iVar1 = Mathf.CeilToInt((float)this.currentDataList.Count /
                                         (float)this.columnCount,0);
                if (((iVar2 == 3 || iVar2 == 4) || iVar2 == 5) && (0 < iVar1)) {
                  fVar10 = this.cellHeight;
                  iVar2 = Mathf.Max(0,iVar1 + -1,0);
                  fVar10 = ((((float)iVar1 * fVar10 + this.spacingY * (float)iVar2) * 0.5 +
                            (0.5 - fStackX_c) * fVar8) - this.cellHeight * 0.5) -
                           (this.cellHeight + this.spacingY) * (float)iVar6;
                }
                else {
                  fVar10 = ((fVar11 - (float)this.paddingTop) -
                           (this.cellHeight + this.spacingY) * (float)iVar6) -
                           this.cellHeight * 0.5;
                }
                if (rt != null) {
                  local_c0 = RectTransform.get_pivot(rt,0);
                  uVar4 = RectTransform.get_anchorMin(rt,0);
                  uVar5 = RectTransform.get_anchorMax(rt,0);
                  local_res8 = (float)uVar5;
                  fStackX_c = (float)((uint64)uVar5 >> 32);
                  local_c8 = (float)uVar4;
                  fStack_c4 = (float)((uint64)uVar4 >> 32);
                  RectTransform.set_anchoredPosition
                            (rt,CONCAT44(((local_c0._4_4_ - 0.5) * this.cellHeight +
                                              fVar10) - ((fStackX_c + fStack_c4) * 0.5 * fVar8 +
                                                        (fVar11 - fVar8)),
                                              (((float)local_c0 - 0.5) * this.cellWidth +
                                              fVar9) - ((local_res8 + local_c8) * 0.5 * fVar7 +
                                                       fVar12 * fVar7)),0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001899
    // RVA   : 0xCA6AE0   Offset: 0xCA5EE0   Length: 0xEC
    public void FreshList(bool resetPos)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ItemListController.ResetSortType(this,0);
        if (resetPos) {
          uVar1 = this.scrollRect;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            if (this.scrollRect == null) {
        LAB_180ca6bc7:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint64 *)(this.scrollRect + 72);
            cVar3 = Object.op_Inequality(uVar1,0,0);
            if (cVar3) {
              if ((this.scrollRect == null) ||
                 (lVar2 = *(int64 *)(this.scrollRect + 72)) == null)
              goto LAB_180ca6bc7;
              Scrollbar.set_value(lVar2,0x3f800000,0);
            }
          }
        }
        ItemListController.UpdateVisibleCells(this,1,0);
    }

    // Token : 0x600189A
    // RVA   : 0xCA64E0   Offset: 0xCA58E0   Length: 0x256
    public void ChangeSortType()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        if (this.sortTypeDropDown == null) goto LAB_180ca6731;
        this.itemSortType = *(uint32 *)(this.sortTypeDropDown + 0x120);
        if (this.recordSortType) {
          uVar1 = **(uint64 **)(DAT_181d72cc8 + 184);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (*pStatics == 0) {
        LAB_180ca6731:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int64 *)(*pStatics + 32) != 0) {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180ca6731;
              *(uint32 *)(*(int64 *)(lVar3 + 32) + 0x250) = this.itemSortType;
            }
          }
        }
        ItemListController.ResetSortType(this,0);
        ItemListController.UpdateVisibleCells(this,1,0);
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
        plVar5 = (int64 *)0;
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
          plVar5 = plVar4;
        }
        NGUITools.PlaySound(plVar5,0x3f19999a,0);
    }

    // Token : 0x600189B
    // RVA   : 0xCA61A0   Offset: 0xCA55A0   Length: 0x336
    public void ChangeReverseType(GameObject ButtonClicked)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar5;
        uint local_18;
        float local_14;
        uint local_10;
        this.reverseOrder = !this.reverseOrder;
        if (this.recordSortType) {
          uVar3 = **(uint64 **)(DAT_181d72cc8 + 184);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (*pStatics == 0) throw; // [null/range check failed]
            if (*(int64 *)(*pStatics + 32) != 0) {
              lVar2 = FUN_18046c0a0(0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar2 + 32) + 0x254) = this.reverseOrder;
            }
          }
        }
        if (ButtonClicked != null) {
          lVar2 = GameObject.get_transform(ButtonClicked,0);
          if (lVar2 != null) {
            uVar3 = Transform.Find(lVar2,"Icon",0);
            iVar5 = -1;
            if (!this.reverseOrder) {
              iVar5 = 1;
            }
            local_18 = 0x3f800000;
            local_10 = 0x3f800000;
            local_14 = (float)iVar5;
            ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
            lVar2 = GameObject.GetComponent(ButtonClicked,DAT_181d73448);
            uVar3 = "升序";
            if (this.reverseOrder) {
              uVar3 = "降序";
            }
            if (lVar2 != null) {
              *(uint64 *)(lVar2 + 24) = uVar3;
              ItemListController.ResetSortType(this,0);
              ItemListController.UpdateVisibleCells(this,1,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar6 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                plVar6 = plVar4;
              }
              NGUITools.PlaySound(plVar6,0x3f19999a,0);
              return;
            }
          }
        }
    }

    // Token : 0x600189C
    // RVA   : 0xCA8100   Offset: 0xCA7500   Length: 0x403
    public void ResetSortType()
    {
        byte uVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        bool cVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        uint uVar11;
        long lVar12;
        long lVar13;
        uint[] local_res18 = new uint[2];
        long local_res20;
        local_res18[0] = 0;
        lVar7 = new c.DisplayClass9_0(0);
        if (this.currentDataList != null) {
          iVar3 = this.currentDataList.Count;
          if (iVar3 < 2) {
            return;
          }
          lVar13 = 0;
          if (this.targetItemList != null) {
            lVar13 = this.targetItemList.allItem;
          }
          lVar8 = il2cpp_internal(DAT_181d81de8);
          FUN_1808b1490(lVar8,iVar3,DAT_181dc2188);
          lVar12 = 32;
          local_res20 = 32;
          if (lVar13 != null) {
            for (uVar11 = 0; (int)uVar11 < (int)*(uint32 *)(lVar13 + 24); uVar11 = uVar11 + 1) {
              if (*(uint32 *)(lVar13 + 24) <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar8 == null) throw; // [null/range check failed]
              cVar6 = FUN_1808ab490(lVar8,*(uint64 *)(lVar12 + *(int64 *)(lVar13 + 16)),
                                    DAT_181dc2298);
              if (!cVar6) {
                uVar9 = FUN_180002f80(lVar13,uVar11,DAT_181d90f18);
                FUN_1808ab370(lVar8,uVar9,uVar11,DAT_181dc2210);
              }
              lVar12 = lVar12 + 8;
            }
          }
          lVar13 = 32;
          if (this.currentDataList != null) {
            uVar4 = this.currentDataList.Count;
            lVar12 = il2cpp_internal(DAT_181d81e68);
            FUN_1808b1490(lVar12,uVar4,DAT_181dc23a8);
            if (lVar7 != null) {
              plVar1 = (int64 *)(lVar7 + 16);
              *plVar1 = lVar12;
              il2cpp_internal(plVar1,lVar12);
              uVar11 = 0;
              lVar12 = this.currentDataList;
              while (lVar12 != null) {
                if (lVar12.Count <= (int)uVar11) {
                  uVar9 = new OnTooltipCB(lVar7,DAT_181da6148,DAT_181dab4b8);
                  if (lVar12 != null) {
                    List_1.Sort(lVar12,uVar9,DAT_181d90e18);
                    return;
                  }
                  break;
                }
                if (lVar12 == null) break;
                if (lVar12.Count <= uVar11) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar8 == null) break;
                cVar6 = FUN_1817c0490(lVar8,*(uint64 *)(lVar13 + lVar12._items),
                                      local_res18,DAT_181dc2320);
                if (!cVar6) {
                  local_res18[0] = uVar11;
                }
                lVar13 = *plVar1;
                if (this.currentDataList == null) break;
                uVar9 = FUN_180002f80(this.currentDataList,uVar11,DAT_181d90f18);
                if (this.currentDataList == null) break;
                uVar10 = FUN_180002f80(this.currentDataList,uVar11,DAT_181d90f18);
                uVar5 = local_res18[0];
                uVar2 = this.reverseOrder;
                uVar4 = this.itemSortType;
                uVar10 = ItemIconController.BuildSortKey(uVar10,uVar5,uVar4,uVar2,0);
                if (lVar13 == null) break;
                FUN_1808b2160(lVar13,uVar9,uVar10,DAT_181dc24b8);
                uVar11 = uVar11 + 1;
                lVar13 = local_res20 + 8;
                local_res20 = lVar13;
                lVar12 = this.currentDataList;
              }
            }
          }
        }
    }

    // Token : 0x600189D
    // RVA   : 0xCA8D10   Offset: 0xCA8110   Length: 0x17B
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d940d0);
        FUN_18132faf0(uVar1,DAT_181d90998);
        this.currentDataList = uVar1;
        uVar1 = il2cpp_internal(DAT_181d80de8);
        FUN_1808b1370(uVar1,DAT_181db9ba0);
        this.activeItemMap = uVar1;
        this.cellWidth = 0x42a00000;
        this.cellHeight = 0x42a00000;
        this.spacingX = 0x41200000;
        this.spacingY = 0x41200000;
        this.paddingLeft = 10;
        this.paddingRight = 10;
        this.paddingTop = 10;
        this.paddingBottom = 10;
        this.columnCount = 5;
        this.gridConstraintCount = 2;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.toRemoveCache = uVar1;
        this.lastMinIndex = 0x80000000;
        this.lastMaxIndex = 0x80000000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x600189E
    // RVA   : 0xCA8C90   Offset: 0xCA8090   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d9c9d0);
        FUN_1814b2e90(uVar2,DAT_181dc0718);
        puVar1 = *(uint64 **)(DAT_181d82198 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
