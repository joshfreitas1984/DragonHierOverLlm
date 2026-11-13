// ============================================================
// Type  : ShowRoomController
// Token : 0x2000362
// ============================================================

public class ShowRoomController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BF0
    public ShowRoomType showRoomType;

    // Token: 0x4001BF1
    public GameObject showRoomPanel;

    // Token: 0x4001BF2
    public GameObject showRoomSpacePrefab;

    // Token: 0x4001BF3
    public Text showRoomTotalChangeText;

    // Token: 0x4001BF4
    public ForceData targetForce;

    // Token: 0x4001BF5
    public List<List<ItemData>> targetShowRoomItems;

    // Token: 0x4001BF6
    public List<Sprite> itemTypeSprite;

    // Token: 0x4001BF7
    public static int FameToMoneyRate;

    // Token: 0x4001BF8
    public static List<ItemType> ShowRoomItemType;

    // Token: 0x4001BF9
    public static List<string> ShowRoomTitleText;

    // Token: 0x4001BFA
    public static List<string> ShowRoomQuestionText;

    // Token: 0x4001BFB
    private bool inited;

    // Token: 0x4001BFC
    private GameObject temp;

    // Token: 0x4001BFD
    private static ShowRoomController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021AC
    // RVA   : 0x6A7670   Offset: 0x6A6470   Length: 0x58
    public static ShowRoomController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e824b8 + 184) + 32);
    }

    // Token : 0x60021AD
    // RVA   : 0x6A61C0   Offset: 0x6A4FC0   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181e824b8 + 184);
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

    // Token : 0x60021AE
    // RVA   : 0x6A7180   Offset: 0x6A5F80   Length: 0x2CE
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
          FUN_1801e0300();
        }
        cVar3 = GameObject.get_activeSelf(this.showRoomPanel,0);
        if (cVar3) {
          if (this.showRoomType == null) {
            uVar2 = this.showRoomTotalChangeText;
            if (this.targetForce != null) {
              fVar1 = this.targetForce.showRoomChangeFame;
              local_res8[0] = Mathf.RoundToInt((float)**(int **)(DAT_181e824b8 + 184) * fVar1,0);
              uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
              if (this.targetForce != null) {
                uVar5 = Single.ToString(this.targetForce + 0x158,"0.#",0);
                uVar4 = String.Format("每月产出\n门派银两+{0}\n门派威望+{1}",uVar4,uVar5,0);
                LTLocalization.SetText(uVar2,uVar4,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (this.showRoomType == 1) {
            uVar2 = this.showRoomTotalChangeText;
            lVar6 = FUN_1802106e0(0);
            if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
              fVar1 = *(float *)(*(int64 *)(lVar6 + 32) + 0x168);
              local_res8[0] = Mathf.RoundToInt((float)**(int **)(DAT_181e824b8 + 184) * fVar1 * 5.0,0);
              uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
              lVar6 = FUN_1802106e0(0);
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                uVar5 = Single.ToString(*(int64 *)(lVar6 + 32) + 0x168,"0.#",0);
                uVar4 = String.Format("每月产出\n银两+{0}\n声望+{1}",uVar4,uVar5,0);
                LTLocalization.SetText(uVar2,uVar4,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x60021AF
    // RVA   : 0x6A6410   Offset: 0x6A5210   Length: 0x3B0
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
        LAB_1806a67bb:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar1 = GameObject.get_transform(this.showRoomPanel,0);
            uVar2 = Int32.ToString(local_res8,0);
            if (lVar1 == null) goto LAB_1806a67bb;
            lVar1 = Transform.Find(lVar1,uVar2,0);
            if (lVar1 == null) goto LAB_1806a67bb;
            uVar3 = Component.get_gameObject(lVar1,0);
            uVar2 = this.showRoomSpacePrefab;
            uVar2 = GlobalData.AddChild(uVar3,uVar2,0);
            this.temp = uVar2;
            lVar1 = this.temp;
            uVar2 = Int32.ToString(local_res18,0);
            if (lVar1 == null) goto LAB_1806a67bb;
            Object.set_name(lVar1,uVar2,0);
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if (lVar1 == null) goto LAB_1806a67bb;
            *(int *)(lVar1 + 24) = local_res8[0];
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if (lVar1 == null) goto LAB_1806a67bb;
            *(int *)(lVar1 + 28) = local_res18[0];
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if (this.temp == null) goto LAB_1806a67bb;
            lVar4 = GameObject.get_transform(this.temp,0);
            if (lVar4 == null) goto LAB_1806a67bb;
            lVar4 = Transform.Find(lVar4,"ItemIcon",0);
            if (lVar4 == null) goto LAB_1806a67bb;
            uVar2 = Component.get_gameObject(lVar4,0);
            lVar4 = FUN_1802107e0(0);
            if (lVar4 == null) goto LAB_1806a67bb;
            uVar2 = GlobalData.AddChild(uVar2,*(uint64 *)(lVar4 + 160),0);
            if (lVar1 == null) goto LAB_1806a67bb;
            *(uint64 *)(lVar1 + 48) = uVar2;
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 48) == 0)) goto LAB_1806a67bb;
            GameObject.SetActive(*(int64 *)(lVar1 + 48),0,0);
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 48) == 0)) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(*(int64 *)(lVar1 + 48),DAT_181e55168);
            if (lVar1 == null) goto LAB_1806a67bb;
            *(uint32 *)(lVar1 + 40) = 1;
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 40) == 0)) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181e54f48);
            if (this.itemTypeSprite == null) goto LAB_1806a67bb;
            uVar2 = FUN_1800024b0(this.itemTypeSprite,local_res8[0],DAT_181e85ff0);
            if (lVar1 == null) goto LAB_1806a67bb;
            Image.set_sprite(lVar1,uVar2,0);
            if (this.temp == null) goto LAB_1806a67bb;
            lVar1 = GameObject.GetComponent(this.temp,DAT_181e56488);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 40) == 0)) goto LAB_1806a67bb;
            plVar5 = (int64 *)GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181e54f48);
            if (plVar5 == (int64 *)0) goto LAB_1806a67bb;
            (**(code **)(*plVar5 + 0x408))(plVar5);
            local_res18[0] = local_res18[0] + 1;
          } while (local_res18[0] < 5);
          local_res8[0] = local_res8[0] + 1;
          if (2 < local_res8[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x60021B0
    // RVA   : 0x6A7010   Offset: 0x6A5E10   Length: 0x168
    public void ShowShowRoomUI(ShowRoomType _showRoomType, ForceData _targetForce)
    {
        long lVar2;
        ulong uVar4;
        if (!this.inited) {
          ShowRoomController.Init(this,0);
        }
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBox",0);
        plVar3 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar3 = plVar1;
        }
        NGUITools.PlaySound(plVar3,0);
        if (this.showRoomPanel == null) {
        LAB_1806a7173:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameObject.SetActive(this.showRoomPanel,1,0);
        this.showRoomType = _showRoomType;
        this.targetForce = _targetForce;
        if (this.showRoomType == null) {
          if (this.targetForce == null) goto LAB_1806a7173;
          uVar4 = this.targetForce.showRoomItems;
        }
        else {
          if (this.showRoomType == 1)
          {
            lVar2 = FUN_1802106e0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) goto LAB_1806a7173;
            uVar4 = *(uint64 *)(*(int64 *)(lVar2 + 32) + 0x160);
            }
            this.targetShowRoomItems = uVar4;
          }
        ShowRoomController.RefreshShowRoomPanel(this,0);
    }

    // Token : 0x60021B1
    // RVA   : 0x5EBA30   Offset: 0x5EA830   Length: 0x20
    public void UnshowRoomUI()
    {
        if (this.showRoomPanel != null) {
          GameObject.SetActive(this.showRoomPanel,0,0);
          return;
        }
    }

    // Token : 0x60021B2
    // RVA   : 0x6A6960   Offset: 0x6A5760   Length: 0x6A9
    public void RefreshShowRoomPanel()
    {
        var pStatics = *(int64*)(DAT_181e824b8 + 184);
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
              uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
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
                      lVar6 = Component.GetComponent(lVar4,DAT_181e788b8);
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
                              lVar4 = Component.GetComponent(lVar4,DAT_181e78838);
                              if (this.targetShowRoomItems == null) throw; // [null/range check failed]
                              lVar6 = FUN_1800024b0(this.targetShowRoomItems,local_res18[0],
                                                    DAT_181e5a6e8);
                              if (lVar6 == null) throw; // [null/range check failed]
                              uVar5 = FUN_1800024b0(lVar6,local_res8[0]);
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
                                lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
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
                                uVar5 = Component.GetComponent(lVar4,DAT_181e79538);
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
                                lVar4 = Component.GetComponent(lVar4,DAT_181e76ab8);
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

    // Token : 0x60021B3
    // RVA   : 0x6A62E0   Offset: 0x6A50E0   Length: 0x34
    public float GetUnlockItemNeedFame(int itemID)
    {
        float fVar1;
        if (itemID == null) {
          return 0.0;
        }
        fVar1 = (float)FUN_1801e6830(0x40000000);
        return fVar1 * 200.0;
    }

    // Token : 0x60021B4
    // RVA   : 0x6A67D0   Offset: 0x6A55D0   Length: 0x18A
    public bool MeetUnlockNeed(int itemID)
    {
        long lVar1;
        float fVar2;
        if (this.showRoomType == null) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e942d8 + 184) + 8);
          if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 24)) != null) {
            return (float)itemID <= (float)*(int *)(lVar1 + 20) * 0.5;
          }
        }
        else {
          if (itemID == null) {
            return true;
          }
          lVar1 = FUN_1802106e0(0);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 32) != 0)) {
            lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0);
            if (lVar1 != null) {
              fVar2 = (float)FUN_1801e6830();
              return fVar2 * 200.0 <= *(float *)(lVar1 + 0x1c4);
            }
          }
        }
    }

    // Token : 0x60021B5
    // RVA   : 0x6A6320   Offset: 0x6A5120   Length: 0xE2
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
            local_res8[0] = (float)FUN_1801e6830(0x40000000);
            local_res8[0] = local_res8[0] * 200.0;
          }
          uVar1 = il2cpp_value_box(DAT_181e82730,local_res8);
          uVar2 = "声望{0}解锁";
        }
        String.Format(uVar2,uVar1,0);
    }

    // Token : 0x60021B6
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60021B7
    // RVA   : 0x6A7450   Offset: 0x6A6250   Length: 0x215
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181e824b8 + 184);
        long lVar1;
        **(uint32 **)(DAT_181e824b8 + 184) = 10;
        lVar1 = il2cpp_internal(DAT_181e741b8);
        FUN_1810f3480(lVar1,DAT_181e73470);
        if (lVar1 != null) {
          FUN_181769fe0(lVar1,0,DAT_181e734f0);
          FUN_181769fe0(lVar1,3,DAT_181e734f0);
          FUN_181769fe0(lVar1,4,DAT_181e734f0);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar1,DAT_181e861f0);
          if (lVar1 != null) {
            FUN_18175de30(lVar1,"门派展厅",DAT_181e86370);
            FUN_18175de30(lVar1,"个人展厅",DAT_181e86370);
            plVar2 = (int64 *)(pStatics + 16);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181e77728);
            FUN_1810f3480(lVar1,DAT_181e861f0);
            if (lVar1 != null) {
              FUN_18175de30(lVar1,"♦在门派展厅中摆放珍贵物品加以展示，可以每月获取门派银两和门派威望\n♦珍宝产出较高，装备/秘籍产出较少",DAT_181e86370);
              FUN_18175de30(lVar1,"♦在个人展厅中摆放珍贵物品加以展示，可以每月获取银两和声望\n♦珍宝产出较高，装备/秘籍产出较少",DAT_181e86370);
              plVar2 = (int64 *)(pStatics + 24);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

}
