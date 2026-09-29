// ============================================================
// Type  : ShowRoomSpaceController
// Token : 0x2000356
// ============================================================

public class ShowRoomSpaceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B80
    public int itemTypeID;

    // Token: 0x4001B81
    public int itemID;

    // Token: 0x4001B82
    public ItemData targetItem;

    // Token: 0x4001B83
    public GameObject itemTypeObj;

    // Token: 0x4001B84
    public GameObject targetItemObj;

    // Token: 0x4001B85
    public GameObject clearButtonObj;

    // Token: 0x4001B86
    public GameObject coverObj;

    // Token: 0x4001B87
    public Text itemNameText;

    // Token: 0x4001B88
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002110
    // RVA   : 0x980530   Offset: 0x97F930   Length: 0x279
    public void OnClick()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (this.targetItem != null) {
          return;
        }
        lVar2 = **(int64 **)(DAT_181db7530 + 184);
        lVar4 = il2cpp_internal(DAT_181d94e68);
        FUN_181330100(lVar4,DAT_181d957a0);
        local_res8[0] = 0;
        uVar5 = il2cpp_value_box(DAT_181d80430,local_res8);
        if (lVar4 != null) {
          FUN_18181e6b0(lVar4,uVar5,DAT_181d958a0);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181da2070 + 184) + 8);
          if (lVar3 != null) {
            uVar1 = this.itemTypeID;
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res18[0] =
                 lVar3[uVar1];
            uVar5 = il2cpp_value_box(DAT_181d80430,local_res18);
            FUN_18181e6b0(lVar4,uVar5,DAT_181d958a0);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar2 != null) {
              ChooseController.ShowChoosePanel(lVar2,1,lVar4,uVar5,"SelectShowRoomItem",0,0,0,0,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002111
    // RVA   : 0x9807B0   Offset: 0x97FBB0   Length: 0x54A
    public void SelectShowRoomItem()
    {
        var pStatics_2070 = *(int64*)(DAT_181da2070 + 184);
        var pStatics_7530 = *(int64*)(DAT_181db7530 + 184);
        float fVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        float fVar6;

        if ((lVar5 = *(int64 *)(pStatics_2070 + 32)?.ResourcePoints) != null) {
          uVar2 = this.itemTypeID;
          if (lVar5.cityAreaID <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5.chapter[uVar2];
          uVar3 = this.itemID;
          if ((((*pStatics_7530 != 0) &&
               (lVar4 = *(int64 *)(*pStatics_7530 + 72)) != null) &&
              (lVar4 = GameObject.GetComponent(lVar4,DAT_181d720a0)) != null) && (lVar5 != null)) {
            FUN_18182a2e0(lVar5,uVar3,*(uint64 *)(lVar4 + 32),DAT_181d90fb0);
            if ((GameController._instance != null) &&
               (lVar5 = GameController._instance.worldData) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              lVar4 = *(int64 *)(pStatics_2070 + 32);
              if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 64)) != null) {
                uVar2 = this.itemTypeID;
                if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = lVar4[uVar2];
                if (lVar4 != null) {
                  uVar2 = this.itemID;
                  if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar5 != null) {
                    HeroData.LoseItem(lVar5,*(uint64 *)
                                              (*(int64 *)(lVar4 + 16) + 32 +
                                              (int64)(int)uVar2 * 8),1,0);

                    if ((lVar5 = *(int64 *)(pStatics_2070 + 32)?.ResourcePoints) != null) {
                      uVar2 = this.itemTypeID;
                      if (lVar5.cityAreaID <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5.chapter[uVar2]
                      ;
                      if (lVar5 != null) {
                        uVar2 = this.itemID;
                        if (lVar5.cityAreaID <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        ShowRoomSpaceController.SetShowRoomSpaceItem
                                  (this,*(uint64 *)
                                            (lVar5.chapter + 32 + (int64)(int)uVar2 * 8
                                            ),0);
                        lVar5 = *(int64 *)(pStatics_2070 + 32);
                        if (lVar5 != null) {
                          if (lVar5.cityAreaID == null) {

                            if ((lVar5 = *(int64 *)(pStatics_2070 + 32)?.Inns) != null) {
                              lVar5.openForceAttackBasement = 1;
                              return;
                            }
                          }
                          else {
                            if ((GameController._instance != null) &&
                               (lVar5 = GameController._instance.worldData,
                               lVar5 != null)) {
                              fVar1 = lVar5.showRoomChangeFame;
                              if (this.targetItem != null) {
                                fVar6 = (float)ItemData.GetShowRoomFameChange
                                                         (this.targetItem,0x3e4ccccd,0);
                                lVar5.showRoomChangeFame = fVar6 + fVar1;
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

    // Token : 0x6002112
    // RVA   : 0x980D00   Offset: 0x980100   Length: 0x413
    public void SetShowRoomSpaceItem(ItemData _targetItem)
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        this.targetItem = _targetItem;
        uVar6 = this.itemNameText;
        if (*plVar1 == 0) {
          LTLocalization.SetText(uVar6,"无",0);
          if (this.itemTypeObj != null) {
            GameObject.SetActive(this.itemTypeObj,1,0);
            if (this.targetItemObj != null) {
              GameObject.SetActive(this.targetItemObj,0,0);
              if (this.clearButtonObj != null) {
                GameObject.SetActive(this.clearButtonObj,0,0);
                if (this.coverObj != null) {
                  GameObject.SetActive(this.coverObj,0,0);
                  if (this.itemNameText != null) {
                    lVar5 = Component.get_transform(this.itemNameText,0);
                    if (lVar5 != null) {
                      lVar5 = FUN_180daa030(lVar5,0);
                      if (lVar5 != null) {
                        lVar5 = Component.GetComponent(lVar5,DAT_181d95578);
                        uVar6 = "";
                        if (lVar5 != null) {
                          puVar7 = (uint64 *)(lVar5 + 24);
                          *puVar7 = "";
        LAB_18098102e:
                          il2cpp_internal(puVar7,uVar6);
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
        else {
          uVar4 = ItemData.Name(*plVar1,0,0);
          LTLocalization.SetText(uVar6,uVar4,0);
          if (this.itemTypeObj != null) {
            GameObject.SetActive(this.itemTypeObj,0,0);
            if (this.targetItemObj != null) {
              lVar5 = GameObject.GetComponent(this.targetItemObj,DAT_181d720a0);
              if (lVar5 != null) {
                *(int64 *)(lVar5 + 32) = *plVar1;
                if (this.targetItemObj != null) {
                  lVar5 = GameObject.GetComponent(this.targetItemObj,DAT_181d720a0);
                  if (lVar5 != null) {
                    *(uint8 *)(lVar5 + 52) = 0;
                    if (this.targetItemObj != null) {
                      lVar5 = GameObject.GetComponent(this.targetItemObj,DAT_181d720a0);
                      if (lVar5 != null) {
                        *(uint8 *)(lVar5 + 53) = 1;
                        if (this.targetItemObj != null) {
                          GameObject.SetActive(this.targetItemObj,1,0);
                          if (this.clearButtonObj != null) {
                            GameObject.SetActive(this.clearButtonObj,1,0);
                            if (this.coverObj != null) {
                              GameObject.SetActive(this.coverObj,1,0);
                              if (this.itemNameText != null) {
                                lVar5 = Component.get_transform(this.itemNameText,0);
                                if (lVar5 != null) {
                                  lVar5 = FUN_180daa030(lVar5,0);
                                  if (lVar5 != null) {
                                    lVar5 = Component.GetComponent(lVar5,DAT_181d95578);
                                    lVar2 = *(int64 *)(*(int64 *)(DAT_181da2070 + 184) + 32);
                                    if (lVar2 != null) {
                                      lVar3 = *plVar1;
                                      if (*(int *)(lVar2 + 24) == 0) {
                                        if (lVar3 == null) throw; // [null/range check failed]
                                        local_res8[0] =
                                             ItemData.GetShowRoomFameChange(lVar3,0x3f800000,0);
                                        uVar4 = Single.ToString(local_res8,"0.#",0);
                                        uVar6 = "威望+";
                                      }
                                      else {
                                        if (lVar3 == null) throw; // [null/range check failed]
                                        local_res8[0] =
                                             ItemData.GetShowRoomFameChange(lVar3,0x3e4ccccd,0);
                                        uVar4 = Single.ToString(local_res8,"0.#",0);
                                        uVar6 = "声望+";
                                      }
                                      uVar6 = String.Concat(uVar6,uVar4,0);
                                      if (lVar5 != null) {
                                        puVar7 = (uint64 *)(lVar5 + 24);
                                        *puVar7 = uVar6;
                                        goto LAB_18098102e;
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

    // Token : 0x6002113
    // RVA   : 0x9800D0   Offset: 0x97F4D0   Length: 0x455
    public void ClearButtonClicked()
    {
        var pStatics_2070 = *(int64*)(DAT_181da2070 + 184);
        float fVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          lVar4 = WorldData.Player(lVar4,0);
          lVar3 = *(int64 *)(pStatics_2070 + 32);
          if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 64)) != null) {
            uVar2 = this.itemTypeID;
            if (*(uint32 *)(lVar3 + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3[uVar2];
            if (lVar3 != null) {
              uVar2 = this.itemID;
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar4 != null) {
                HeroData.GetItem(lVar4,*(uint64 *)
                                         (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8),1
                                  ,0,0xffffffff,0,0);

                if ((lVar4 = *(int64 *)(pStatics_2070 + 32)?.ResourcePoints) != null) {
                  uVar2 = this.itemTypeID;
                  if (lVar4.cityAreaID <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar4.chapter[uVar2];
                  if (lVar4 != null) {
                    FUN_18182a2e0(lVar4,this.itemID,0,DAT_181d90fb0);
                    lVar4 = *(int64 *)(pStatics_2070 + 32);
                    if (lVar4 != null) {
                      if (lVar4.cityAreaID == null) {

                        if ((lVar4 = *(int64 *)(pStatics_2070 + 32)?.Inns) != null) {
                          lVar4.openForceAttackBasement = 1;
        LAB_1809804fa:
                          ShowRoomSpaceController.SetShowRoomSpaceItem(this,0,0);
                          return;
                        }
                      }
                      else {
                        if ((GameController._instance != null) &&
                           (lVar4 = GameController._instance.worldData,
                           lVar4 != null)) {
                          fVar1 = lVar4.showRoomChangeFame;
                          if (this.targetItem != null) {
                            fVar5 = (float)ItemData.GetShowRoomFameChange
                                                     (this.targetItem,0x3e4ccccd,0);
                            lVar4.showRoomChangeFame = fVar1 - fVar5;
                            goto LAB_1809804fa;
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

    // Token : 0x6002114
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
