// ============================================================
// Type  : ShowRoomController
// Token : 0x2000355
// ============================================================

public class ShowRoomController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B72
    public ShowRoomType showRoomType;

    // Token: 0x4001B73
    public GameObject showRoomPanel;

    // Token: 0x4001B74
    public GameObject showRoomSpacePrefab;

    // Token: 0x4001B75
    public Text showRoomTotalChangeText;

    // Token: 0x4001B76
    public ForceData targetForce;

    // Token: 0x4001B77
    public List<List<ItemData>> targetShowRoomItems;

    // Token: 0x4001B78
    public List<Sprite> itemTypeSprite;

    // Token: 0x4001B79
    public static int FameToMoneyRate;

    // Token: 0x4001B7A
    public static List<ItemType> ShowRoomItemType;

    // Token: 0x4001B7B
    public static List<string> ShowRoomTitleText;

    // Token: 0x4001B7C
    public static List<string> ShowRoomQuestionText;

    // Token: 0x4001B7D
    private bool inited;

    // Token: 0x4001B7E
    private GameObject temp;

    // Token: 0x4001B7F
    private static ShowRoomController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002104
    // RVA   : 0x980070   Offset: 0x97F470   Length: 0x58
    public static ShowRoomController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181da2070 + 184) + 32);
    }

    // Token : 0x6002105
    // RVA   : 0x97EBC0   Offset: 0x97DFC0   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181da2070 + 184);
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(pStatics + 32);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        puVar3 = (uint64 *)(pStatics + 32);
        *puVar3 = this;
        il2cpp_internal(puVar3,this);
    }

    // Token : 0x6002106
    // RVA   : 0x97FB80   Offset: 0x97EF80   Length: 0x2CE
    private void Update()
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint[] local_res8 = new uint[2];
        if (this.showRoomPanel == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar3 = GameObject.get_activeSelf(this.showRoomPanel,0);
        if (cVar3) {
          if (this.showRoomType == null) {
            uVar2 = this.showRoomTotalChangeText;
            if (this.targetForce != null) {
              fVar1 = this.targetForce.showRoomChangeFame;
              local_res8[0] = Mathf.RoundToInt((float)**(int **)(DAT_181da2070 + 184) * fVar1,0);
              uVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
              if (this.targetForce != null) {
                uVar5 = Single.ToString(this.targetForce + 0x158,"0.#",0);
                uVar4 = String.Format("每月产出\n门派银两+{0}\n门派威望+{1}",uVar4,uVar5,0);
                LTLocalization.SetText(uVar2,uVar4,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (this.showRoomType == 1) {
            uVar2 = this.showRoomTotalChangeText;
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
              fVar1 = *(float *)(*(int64 *)(lVar6 + 32) + 0x168);
              local_res8[0] = Mathf.RoundToInt((float)**(int **)(DAT_181da2070 + 184) * fVar1 * 5.0,0);
              uVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                uVar5 = Single.ToString(*(int64 *)(lVar6 + 32) + 0x168,"0.#",0);
                uVar4 = String.Format("每月产出\n银两+{0}\n声望+{1}",uVar4,uVar5,0);
                LTLocalization.SetText(uVar2,uVar4,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6002107
    // RVA   : 0x97EE10   Offset: 0x97E210   Length: 0x3B0
    public void Init()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        this.inited = 1;
        local_res8[0] = 0;
        do {
          local_res18[0] = 0;
          do {
            if (this.showRoomPanel == null) {
        LAB_18097f1bb:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar1 = GameObject.get_transform(this.showRoomPanel,0);
            uVar2 = Int32.ToString(local_res8,0);
            if (lVar1 == null) goto LAB_18097f1bb;
            lVar1 = Transform.Find(lVar1,uVar2,0);
            if (lVar1 == null) goto LAB_18097f1bb;
            uVar3 = Component.get_gameObject(lVar1,0);
            uVar2 = this.showRoomSpacePrefab;
            uVar2 = GlobalData.AddChild(uVar3,uVar2,0);
            this.temp = uVar2;
            lVar1 = this.temp;
            uVar2 = Int32.ToString(local_res18,0);
            if (lVar1 == null) goto LAB_18097f1bb;
            Object.set_name(lVar1,uVar2,0);
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if (lVar1 == null) goto LAB_18097f1bb;
            *(int *)(lVar1 + 24) = local_res8[0];
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if (lVar1 == null) goto LAB_18097f1bb;
            *(int *)(lVar1 + 28) = local_res18[0];
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if (this.temp == null) goto LAB_18097f1bb;
            lVar4 = GameObject.get_transform(this.temp,0);
            if (lVar4 == null) goto LAB_18097f1bb;
            lVar4 = Transform.Find(lVar4,"ItemIcon",0);
            if (lVar4 == null) goto LAB_18097f1bb;
            uVar2 = Component.get_gameObject(lVar4,0);
            lVar4 = FUN_18046c1a0(0);
            if (lVar4 == null) goto LAB_18097f1bb;
            uVar2 = GlobalData.AddChild(uVar2,*(uint64 *)(lVar4 + 160),0);
            if (lVar1 == null) goto LAB_18097f1bb;
            *(uint64 *)(lVar1 + 48) = uVar2;
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 48) == 0)) goto LAB_18097f1bb;
            GameObject.SetActive(*(int64 *)(lVar1 + 48),0,0);
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 48) == 0)) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(*(int64 *)(lVar1 + 48),DAT_181d720a0);
            if (lVar1 == null) goto LAB_18097f1bb;
            *(uint32 *)(lVar1 + 40) = 1;
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 40) == 0)) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181d71e80);
            if (this.itemTypeSprite == null) goto LAB_18097f1bb;
            uVar2 = FUN_180002f80(this.itemTypeSprite,local_res8[0],DAT_181da39f0);
            if (lVar1 == null) goto LAB_18097f1bb;
            Image.set_sprite(lVar1,uVar2,0);
            if (this.temp == null) goto LAB_18097f1bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181d733c0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 40) == 0)) goto LAB_18097f1bb;
            plVar5 = (int64 *)GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181d71e80);
            if (plVar5 == (int64 *)0) goto LAB_18097f1bb;
            (**(code **)(*plVar5 + 0x408))(plVar5);
            local_res18[0] = local_res18[0] + 1;
          } while (local_res18[0] < 5);
          local_res8[0] = local_res8[0] + 1;
          if (2 < local_res8[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x6002108
    // RVA   : 0x97FA10   Offset: 0x97EE10   Length: 0x168
    public void ShowShowRoomUI(ShowRoomType _showRoomType, ForceData _targetForce)
    {
        long lVar2;
        ulong uVar4;
        if (!this.inited) {
          ShowRoomController.Init(this,0);
        }
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBox",0);
        plVar3 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf360)) {
          plVar3 = plVar1;
        }
        NGUITools.PlaySound(plVar3,0);
        if (this.showRoomPanel == null) {
        LAB_18097fb73:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.showRoomPanel,1,0);
        this.showRoomType = _showRoomType;
        this.targetForce = _targetForce;
        if (this.showRoomType == null) {
          if (this.targetForce == null) goto LAB_18097fb73;
          uVar4 = this.targetForce.showRoomItems;
        }
        else {
          if (this.showRoomType == 1)
          {
            lVar2 = FUN_18046c0a0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) goto LAB_18097fb73;
            uVar4 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 0x160);
            }
            this.targetShowRoomItems = uVar4;
          }
        ShowRoomController.RefreshShowRoomPanel(this,0);
    }

    // Token : 0x6002109
    // RVA   : 0x8CBD70   Offset: 0x8CB170   Length: 0x20
    public void UnshowRoomUI()
    {
        if (this.showRoomPanel != null) {
          GameObject.SetActive(this.showRoomPanel,0,0);
          return;
        }
    }

    // Token : 0x600210A
    // RVA   : 0x97F360   Offset: 0x97E760   Length: 0x6A9
    public void RefreshShowRoomPanel()
    {
        var pStatics = *(int64*)(DAT_181da2070 + 184);
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        if (this.showRoomPanel != null) {
          lVar4 = GameObject.get_transform(this.showRoomPanel,0);
          if (lVar4 != null) {
            lVar4 = Transform.Find(lVar4,"Title",0);
            if (lVar4 != null) {
              uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
              lVar4 = *(int64 *)(pStatics + 16);
              if (lVar4 != null) {
                uVar1 = this.showRoomType;
                if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar2 = lVar4[uVar1];
                LTLocalization.SetText(uVar5,uVar2,0);
                if (this.showRoomPanel != null) {
                  lVar4 = GameObject.get_transform(this.showRoomPanel,0);
                  if (lVar4 != null) {
                    lVar4 = Transform.Find(lVar4,"Question",0);
                    if (lVar4 != null) {
                      lVar6 = Component.GetComponent(lVar4,DAT_181d95578);
                      lVar4 = *(int64 *)(pStatics + 24);
                      if (lVar4 != null) {
                        uVar1 = this.showRoomType;
                        if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        if (lVar6 != null) {
                          *(uint64 *)(lVar6 + 24) =
                               *(uint64 *)
                                (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar1 * 8);
                          il2cpp_internal();
                          local_res18[0] = 0;
                          do {
                            local_res8[0] = 0;
                            do {
                              if (this.showRoomPanel == null) throw; // [null/range check failed]
                              lVar4 = GameObject.get_transform(this.showRoomPanel,0);
                              uVar5 = Int32.ToString(local_res18,0);
                              if (lVar4 == null) throw; // [null/range check failed]
                              lVar4 = Transform.Find(lVar4,uVar5,0);
                              uVar5 = Int32.ToString(local_res8,0);
                              if (lVar4 == null) throw; // [null/range check failed]
                              lVar4 = Transform.Find(lVar4,uVar5,0);
                              if (lVar4 == null) throw; // [null/range check failed]
                              lVar4 = Component.GetComponent(lVar4,DAT_181d954f8);
                              if (this.targetShowRoomItems == null) throw; // [null/range check failed]
                              lVar6 = FUN_180002f80(this.targetShowRoomItems,local_res18[0],
                                                    DAT_181d78bc0);
                              if (lVar6 == null) throw; // [null/range check failed]
                              uVar5 = FUN_180002f80(lVar6,local_res8[0]);
                              if (lVar4 == null) throw; // [null/range check failed]
                              ShowRoomSpaceController.SetShowRoomSpaceItem(lVar4,uVar5);
                              cVar3 = ShowRoomController.MeetUnlockNeed(this,local_res8[0]);
                              lVar4 = this.showRoomPanel;
                              if (!cVar3) {
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = GameObject.get_transform(lVar4,0);
                                uVar5 = Int32.ToString(local_res18,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                uVar5 = Int32.ToString(local_res8,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Component.GetComponent(lVar4,DAT_181d93778);
                                if (lVar4 == null) throw; // [null/range check failed]
                                Selectable.set_interactable(lVar4,0);
                                if (this.showRoomPanel == null) throw; // [null/range check failed]
                                lVar4 = GameObject.get_transform(this.showRoomPanel,0);
                                uVar5 = Int32.ToString(local_res18,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                uVar5 = Int32.ToString(local_res8,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,"Unlock",0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Component.get_gameObject(lVar4,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar4,1);
                                if (this.showRoomPanel == null) throw; // [null/range check failed]
                                lVar4 = GameObject.get_transform(this.showRoomPanel,0);
                                uVar5 = Int32.ToString(local_res18,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                uVar5 = Int32.ToString(local_res8,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,"Unlock",0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,"Text",0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
                                ShowRoomController.GetUnlockNeed(this,local_res8[0]);
                                LTLocalization.SetText(uVar5);
                              }
                              else {
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = GameObject.get_transform(lVar4,0);
                                uVar5 = Int32.ToString(local_res18,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                uVar5 = Int32.ToString(local_res8,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Component.GetComponent(lVar4,DAT_181d93778);
                                if (lVar4 == null) throw; // [null/range check failed]
                                Selectable.set_interactable(lVar4,1);
                                if (this.showRoomPanel == null) throw; // [null/range check failed]
                                lVar4 = GameObject.get_transform(this.showRoomPanel,0);
                                uVar5 = Int32.ToString(local_res18,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                uVar5 = Int32.ToString(local_res8,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,uVar5,0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Transform.Find(lVar4,"Unlock",0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                lVar4 = Component.get_gameObject(lVar4);
                                if (lVar4 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar4);
                              }
                              local_res8[0] = local_res8[0] + 1;
                            } while (local_res8[0] < 5);
                            local_res18[0] = local_res18[0] + 1;
                            if (2 < local_res18[0]) {
                              return;
                            }
                          } while( true );
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

    // Token : 0x600210B
    // RVA   : 0x97ECE0   Offset: 0x97E0E0   Length: 0x34
    public float GetUnlockItemNeedFame(int itemID)
    {
        float fVar1;
        if (itemID == null) {
          return 0.0;
        }
        fVar1 = (float)FUN_1801f8ab0(0x40000000);
        return fVar1 * 200.0;
    }

    // Token : 0x600210C
    // RVA   : 0x97F1D0   Offset: 0x97E5D0   Length: 0x18A
    public bool MeetUnlockNeed(int itemID)
    {
        long lVar1;
        float fVar2;
        if (this.showRoomType == null) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181db4020 + 184) + 8);
          if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 24)) != null) {
            return (float)itemID <= (float)*(int *)(lVar1 + 20) * 0.5;
          }
        }
        else {
          if (itemID == null) {
            return true;
          }
          lVar1 = FUN_18046c0a0(0);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 32) != 0)) {
            lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0);
            if (lVar1 != null) {
              fVar2 = (float)FUN_1801f8ab0();
              return fVar2 * 200.0 <= *(float *)(lVar1 + 0x1c4);
            }
          }
        }
    }

    // Token : 0x600210D
    // RVA   : 0x97ED20   Offset: 0x97E120   Length: 0xE2
    public string GetUnlockNeed(int itemID)
    {
        ulong uVar1;
        ulong uVar2;
        float[] local_res8 = new float[2];
        if (this.showRoomType == null) {
          uVar1 = GlobalData.GetNumText(itemID * 2,0);
          uVar2 = "建筑{0}级解锁";
        }
        else {
          if (itemID == null) {
            local_res8[0] = 0.0;
          }
          else {
            local_res8[0] = (float)FUN_1801f8ab0(0x40000000);
            local_res8[0] = local_res8[0] * 200.0;
          }
          uVar1 = il2cpp_value_box(DAT_181da22f0,local_res8);
          uVar2 = "声望{0}解锁";
        }
        String.Format(uVar2,uVar1,0);
    }

    // Token : 0x600210E
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600210F
    // RVA   : 0x97FE50   Offset: 0x97F250   Length: 0x215
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181da2070 + 184);
        long lVar1;
        **(uint32 **)(DAT_181da2070 + 184) = 10;
        lVar1 = il2cpp_internal(DAT_181d941e8);
        FUN_181330100(lVar1,DAT_181d91230);
        if (lVar1 != null) {
          FUN_18182a6c0(lVar1,0,DAT_181d912b0);
          FUN_18182a6c0(lVar1,3,DAT_181d912b0);
          FUN_18182a6c0(lVar1,4,DAT_181d912b0);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar1,DAT_181da3bf0);
          if (lVar1 != null) {
            FUN_18181e6b0(lVar1,"门派展厅",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"个人展厅",DAT_181da3d70);
            plVar2 = (int64 *)(pStatics + 16);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar1,DAT_181da3bf0);
            if (lVar1 != null) {
              FUN_18181e6b0(lVar1,"♦在门派展厅中摆放珍贵物品加以展示，可以每月获取门派银两和门派威望\n♦珍宝产出较高，装备/秘籍产出较少",DAT_181da3d70);
              FUN_18181e6b0(lVar1,"♦在个人展厅中摆放珍贵物品加以展示，可以每月获取银两和声望\n♦珍宝产出较高，装备/秘籍产出较少",DAT_181da3d70);
              plVar2 = (int64 *)(pStatics + 24);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

}
