// ============================================================
// Type  : ShowRoomController
// Token : 0x200034E
// ============================================================

public class ShowRoomController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A70
    public ShowRoomType showRoomType;

    // Token: 0x4001A71
    public GameObject showRoomPanel;

    // Token: 0x4001A72
    public GameObject showRoomSpacePrefab;

    // Token: 0x4001A73
    public Text showRoomTotalChangeText;

    // Token: 0x4001A74
    public ForceData targetForce;

    // Token: 0x4001A75
    public List<List<ItemData>> targetShowRoomItems;

    // Token: 0x4001A76
    public List<Sprite> itemTypeSprite;

    // Token: 0x4001A77
    public static int FameToMoneyRate;

    // Token: 0x4001A78
    public static List<ItemType> ShowRoomItemType;

    // Token: 0x4001A79
    public static List<string> ShowRoomTitleText;

    // Token: 0x4001A7A
    public static List<string> ShowRoomQuestionText;

    // Token: 0x4001A7B
    private bool inited;

    // Token: 0x4001A7C
    private GameObject temp;

    // Token: 0x4001A7D
    private static ShowRoomController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002083
    // RVA   : 0x96CFB0   Offset: 0x96B7B0   Length: 0x58
    public static ShowRoomController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d7ce38 + 184) + 32);
    }

    // Token : 0x6002084
    // RVA   : 0x96BB90   Offset: 0x96A390   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d7ce38 + 184);
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

    // Token : 0x6002085
    // RVA   : 0x96CB00   Offset: 0x96B300   Length: 0x280
    private void Update()
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint[] local_res8 = new uint[2];
        if (this.showRoomPanel != null) {
          cVar3 = GameObject.get_activeSelf(this.showRoomPanel,0);
          if (cVar3) {
            if (this.showRoomType == null) {
              uVar2 = this.showRoomTotalChangeText;
              if (this.targetForce != null) {
                fVar1 = this.targetForce.showRoomChangeFame;
                local_res8[0] = Mathf.RoundToInt((float)**(int **)(DAT_181d7ce38 + 184) * fVar1,0);
                uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
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
                local_res8[0] = Mathf.RoundToInt((float)**(int **)(DAT_181d7ce38 + 184) * fVar1 * 5.0,0)
                ;
                uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
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
          return;
        }
    }

    // Token : 0x6002086
    // RVA   : 0x96BDE0   Offset: 0x96A5E0   Length: 0x3B0
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
        LAB_18096c18b:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar1 = GameObject.get_transform(this.showRoomPanel,0);
            uVar2 = Int32.ToString(local_res8,0);
            if (lVar1 == null) goto LAB_18096c18b;
            lVar1 = Transform.Find(lVar1,uVar2,0);
            if (lVar1 == null) goto LAB_18096c18b;
            uVar3 = Component.get_gameObject(lVar1,0);
            uVar2 = this.showRoomSpacePrefab;
            uVar2 = GlobalData.AddChild(uVar3,uVar2,0);
            this.temp = uVar2;
            lVar1 = this.temp;
            uVar2 = Int32.ToString(local_res18,0);
            if (lVar1 == null) goto LAB_18096c18b;
            Object.set_name(lVar1,uVar2,0);
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if (lVar1 == null) goto LAB_18096c18b;
            *(int *)(lVar1 + 24) = local_res8[0];
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if (lVar1 == null) goto LAB_18096c18b;
            *(int *)(lVar1 + 28) = local_res18[0];
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if (this.temp == null) goto LAB_18096c18b;
            lVar4 = GameObject.get_transform(this.temp,0);
            if (lVar4 == null) goto LAB_18096c18b;
            lVar4 = Transform.Find(lVar4,"ItemIcon",0);
            if (lVar4 == null) goto LAB_18096c18b;
            uVar2 = Component.get_gameObject(lVar4,0);
            lVar4 = FUN_18046c1a0(0);
            if (lVar4 == null) goto LAB_18096c18b;
            uVar2 = GlobalData.AddChild(uVar2,*(uint64 *)(lVar4 + 160),0);
            if (lVar1 == null) goto LAB_18096c18b;
            *(uint64 *)(lVar1 + 48) = uVar2;
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 48) == 0)) goto LAB_18096c18b;
            GameObject.SetActive(*(int64 *)(lVar1 + 48),0,0);
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 48) == 0)) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(*(int64 *)(lVar1 + 48),DAT_181da0070);
            if (lVar1 == null) goto LAB_18096c18b;
            *(uint32 *)(lVar1 + 40) = 1;
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 40) == 0)) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181d9fe50);
            if (this.itemTypeSprite == null) goto LAB_18096c18b;
            uVar2 = FUN_180002f80(this.itemTypeSprite,local_res8[0],DAT_181d7c050);
            if (lVar1 == null) goto LAB_18096c18b;
            Image.set_sprite(lVar1,uVar2,0);
            if (this.temp == null) goto LAB_18096c18b;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181da1230);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 40) == 0)) goto LAB_18096c18b;
            plVar5 = (int64 *)GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181d9fe50);
            if (plVar5 == (int64 *)0) goto LAB_18096c18b;
            (**(code **)(*plVar5 + 0x408))(plVar5);
            local_res18[0] = local_res18[0] + 1;
          } while (local_res18[0] < 5);
          local_res8[0] = local_res8[0] + 1;
          if (2 < local_res8[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x6002087
    // RVA   : 0x96C990   Offset: 0x96B190   Length: 0x168
    public void ShowShowRoomUI(ShowRoomType _showRoomType, ForceData _targetForce)
    {
        long lVar2;
        ulong uVar4;
        if (!this.inited) {
          ShowRoomController.Init(this,0);
        }
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBox",0);
        plVar3 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
          plVar3 = plVar1;
        }
        NGUITools.PlaySound(plVar3,0);
        if (this.showRoomPanel == null) {
        LAB_18096caf3:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.showRoomPanel,1,0);
        this.showRoomType = _showRoomType;
        this.targetForce = _targetForce;
        if (this.showRoomType == null) {
          if (this.targetForce == null) goto LAB_18096caf3;
          uVar4 = this.targetForce.showRoomItems;
        }
        else {
          if (this.showRoomType == 1)
          {
            lVar2 = FUN_18046c0a0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) goto LAB_18096caf3;
            uVar4 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 0x160);
            }
            this.targetShowRoomItems = uVar4;
          }
        ShowRoomController.RefreshShowRoomPanel(this,0);
    }

    // Token : 0x6002088
    // RVA   : 0x478350   Offset: 0x476B50   Length: 0x20
    public void UnshowRoomUI()
    {
        if (this.showRoomPanel != null) {
          GameObject.SetActive(this.showRoomPanel,0,0);
          return;
        }
    }

    // Token : 0x6002089
    // RVA   : 0x96C330   Offset: 0x96AB30   Length: 0x659
    public void RefreshShowRoomPanel()
    {
        var pStatics = *(int64*)(DAT_181d7ce38 + 184);
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        if (this.showRoomPanel != null) {
          lVar3 = GameObject.get_transform(this.showRoomPanel,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"Title",0);
            if (lVar3 != null) {
              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              lVar3 = *(int64 *)(pStatics + 16);
              if (lVar3 != null) {
                uVar1 = this.showRoomType;
                if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                LTLocalization.SetText
                          (uVar4,*(uint64 *)
                                  (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar1 * 8),0);
                if (this.showRoomPanel != null) {
                  lVar3 = GameObject.get_transform(this.showRoomPanel,0);
                  if (lVar3 != null) {
                    lVar3 = Transform.Find(lVar3,"Question",0);
                    if (lVar3 != null) {
                      lVar5 = Component.GetComponent(lVar3,DAT_181d6ccc0);
                      lVar3 = *(int64 *)(pStatics + 24);
                      if (lVar3 != null) {
                        uVar1 = this.showRoomType;
                        if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        if (lVar5 != null) {
                          *(uint64 *)(lVar5 + 24) =
                               *(uint64 *)
                                (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar1 * 8);
                          il2cpp_internal();
                          local_res18[0] = 0;
                          do {
                            local_res8[0] = 0;
                            do {
                              if (this.showRoomPanel == null) throw; // [null/range check failed]
                              lVar3 = GameObject.get_transform(this.showRoomPanel,0);
                              uVar4 = Int32.ToString(local_res18,0);
                              if (lVar3 == null) throw; // [null/range check failed]
                              lVar3 = Transform.Find(lVar3,uVar4,0);
                              uVar4 = Int32.ToString(local_res8,0);
                              if (lVar3 == null) throw; // [null/range check failed]
                              lVar3 = Transform.Find(lVar3,uVar4,0);
                              if (lVar3 == null) throw; // [null/range check failed]
                              lVar3 = Component.GetComponent(lVar3,DAT_181d6cc40);
                              if (this.targetShowRoomItems == null) throw; // [null/range check failed]
                              lVar5 = FUN_180002f80(this.targetShowRoomItems,local_res18[0],
                                                    DAT_181d51888);
                              if (lVar5 == null) throw; // [null/range check failed]
                              uVar4 = FUN_180002f80(lVar5,local_res8[0]);
                              if (lVar3 == null) throw; // [null/range check failed]
                              ShowRoomSpaceController.SetShowRoomSpaceItem(lVar3,uVar4);
                              cVar2 = ShowRoomController.MeetUnlockNeed(this,local_res8[0]);
                              lVar3 = this.showRoomPanel;
                              if (!cVar2) {
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = GameObject.get_transform(lVar3,0);
                                uVar4 = Int32.ToString(local_res18,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                uVar4 = Int32.ToString(local_res8,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181d6af40);
                                if (lVar3 == null) throw; // [null/range check failed]
                                Selectable.set_interactable(lVar3,0);
                                if (this.showRoomPanel == null) throw; // [null/range check failed]
                                lVar3 = GameObject.get_transform(this.showRoomPanel,0);
                                uVar4 = Int32.ToString(local_res18,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                uVar4 = Int32.ToString(local_res8,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Unlock",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.get_gameObject(lVar3,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar3,1);
                                if (this.showRoomPanel == null) throw; // [null/range check failed]
                                lVar3 = GameObject.get_transform(this.showRoomPanel,0);
                                uVar4 = Int32.ToString(local_res18,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                uVar4 = Int32.ToString(local_res8,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Unlock",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Text",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                ShowRoomController.GetUnlockNeed(this,local_res8[0]);
                                LTLocalization.SetText(uVar4);
                              }
                              else {
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = GameObject.get_transform(lVar3,0);
                                uVar4 = Int32.ToString(local_res18,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                uVar4 = Int32.ToString(local_res8,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.GetComponent(lVar3,DAT_181d6af40);
                                if (lVar3 == null) throw; // [null/range check failed]
                                Selectable.set_interactable(lVar3,1);
                                if (this.showRoomPanel == null) throw; // [null/range check failed]
                                lVar3 = GameObject.get_transform(this.showRoomPanel,0);
                                uVar4 = Int32.ToString(local_res18,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                uVar4 = Int32.ToString(local_res8,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,uVar4,0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Transform.Find(lVar3,"Unlock",0);
                                if (lVar3 == null) throw; // [null/range check failed]
                                lVar3 = Component.get_gameObject(lVar3);
                                if (lVar3 == null) throw; // [null/range check failed]
                                GameObject.SetActive(lVar3);
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

    // Token : 0x600208A
    // RVA   : 0x96BCB0   Offset: 0x96A4B0   Length: 0x34
    public float GetUnlockItemNeedFame(int itemID)
    {
        float fVar1;
        if (itemID == null) {
          return 0.0;
        }
        fVar1 = (float)FUN_1801f7f00(0x40000000);
        return fVar1 * 200.0;
    }

    // Token : 0x600208B
    // RVA   : 0x96C1A0   Offset: 0x96A9A0   Length: 0x18A
    public bool MeetUnlockNeed(int itemID)
    {
        long lVar1;
        float fVar2;
        if (this.showRoomType == null) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
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
              fVar2 = (float)FUN_1801f7f00();
              return fVar2 * 200.0 <= *(float *)(lVar1 + 0x1c4);
            }
          }
        }
    }

    // Token : 0x600208C
    // RVA   : 0x96BCF0   Offset: 0x96A4F0   Length: 0xE2
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
            local_res8[0] = (float)FUN_1801f7f00(0x40000000);
            local_res8[0] = local_res8[0] * 200.0;
          }
          uVar1 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
          uVar2 = "声望{0}解锁";
        }
        String.Format(uVar2,uVar1,0);
    }

    // Token : 0x600208D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600208E
    // RVA   : 0x96CD90   Offset: 0x96B590   Length: 0x215
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d7ce38 + 184);
        long lVar1;
        **(uint32 **)(DAT_181d7ce38 + 184) = 10;
        lVar1 = il2cpp_internal(DAT_181d6f530);
        FUN_180f58a90(lVar1,DAT_181d69a70);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0,DAT_181d69af0);
          FUN_181814fa0(lVar1,3,DAT_181d69af0);
          FUN_181814fa0(lVar1,4,DAT_181d69af0);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"门派展厅",DAT_181d7c3d0);
            FUN_181827900(lVar1,"个人展厅",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 16);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar1,DAT_181d7c250);
            if (lVar1 != null) {
              FUN_181827900(lVar1,"♦在门派展厅中摆放珍贵物品加以展示，可以每月获取门派银两和门派威望\n♦珍宝产出较高，装备/秘籍产出较少",DAT_181d7c3d0);
              FUN_181827900(lVar1,"♦在个人展厅中摆放珍贵物品加以展示，可以每月获取银两和声望\n♦珍宝产出较高，装备/秘籍产出较少",DAT_181d7c3d0);
              plVar2 = (int64 *)(pStatics + 24);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

}
