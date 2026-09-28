// ============================================================
// Type  : ShowRoomSpaceController
// Token : 0x2000356
// ============================================================

public class ShowRoomSpaceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B7F
    public int itemTypeID;

    // Token: 0x4001B80
    public int itemID;

    // Token: 0x4001B81
    public ItemData targetItem;

    // Token: 0x4001B82
    public GameObject itemTypeObj;

    // Token: 0x4001B83
    public GameObject targetItemObj;

    // Token: 0x4001B84
    public GameObject clearButtonObj;

    // Token: 0x4001B85
    public GameObject coverObj;

    // Token: 0x4001B86
    public Text itemNameText;

    // Token: 0x4001B87
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002110
    // RVA   : 0x97FEA0   Offset: 0x97F2A0   Length: 0x279
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
        lVar2 = **(int64 **)(DAT_181db7518 + 184);
        lVar4 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(lVar4,DAT_181d95788);
        local_res8[0] = 0;
        uVar5 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (lVar4 != null) {
          FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181da2058 + 184) + 8);
          if (lVar3 != null) {
            uVar1 = this.itemTypeID;
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res18[0] =
                 lVar3[uVar1];
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
            FUN_18181e0a0(lVar4,uVar5,DAT_181d95888);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar2 != null) {
              ChooseController.ShowChoosePanel(lVar2,1,lVar4,uVar5,"SelectShowRoomItem",0,0,0,0,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002111
    // RVA   : 0x980120   Offset: 0x97F520   Length: 0x54A
    public void SelectShowRoomItem()
    {
        var pStatics_2058 = *(int64*)(DAT_181da2058 + 184);
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_7518 = *(int64*)(DAT_181db7518 + 184);
        float fVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        lVar5 = *(int64 *)(pStatics_2058 + 32);
        if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 64)) != null) {
          uVar2 = this.itemTypeID;
          if (*(uint32 *)(lVar5 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5[uVar2];
          uVar3 = this.itemID;
          if ((((*pStatics_7518 != 0) &&
               (lVar4 = *(int64 *)(*pStatics_7518 + 72)) != null) &&
              (lVar4 = GameObject.GetComponent(lVar4,DAT_181d720a0)) != null) && (lVar5 != null)) {
            FUN_181829cd0(lVar5,uVar3,*(uint64 *)(lVar4 + 32),DAT_181d90f98);
            if ((*pStatics_2cc8 != 0) &&
               (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              lVar4 = *(int64 *)(pStatics_2058 + 32);
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
                    lVar5 = *(int64 *)(pStatics_2058 + 32);
                    if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 64)) != null) {
                      uVar2 = this.itemTypeID;
                      if (*(uint32 *)(lVar5 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5[uVar2]
                      ;
                      if (lVar5 != null) {
                        uVar2 = this.itemID;
                        if (*(uint32 *)(lVar5 + 24) <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        ShowRoomSpaceController.SetShowRoomSpaceItem
                                  (this,*(uint64 *)
                                            (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar2 * 8
                                            ),0);
                        lVar5 = *(int64 *)(pStatics_2058 + 32);
                        if (lVar5 != null) {
                          if (*(int *)(lVar5 + 24) == 0) {
                            lVar5 = *(int64 *)(pStatics_2058 + 32);
                            if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 56)) != null) {
                              *(uint8 *)(lVar5 + 0x10c) = 1;
                              return;
                            }
                          }
                          else {
                            if ((*pStatics_2cc8 != 0) &&
                               (lVar5 = *(int64 *)(*pStatics_2cc8 + 32),
                               lVar5 != null)) {
                              fVar1 = *(float *)(lVar5 + 0x168);
                              if (this.targetItem != null) {
                                fVar6 = (float)ItemData.GetShowRoomFameChange
                                                         (this.targetItem,0x3e4ccccd,0);
                                *(float *)(lVar5 + 0x168) = fVar6 + fVar1;
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
    // RVA   : 0x980670   Offset: 0x97FA70   Length: 0x413
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
                      lVar5 = FUN_180da9a20(lVar5,0);
                      if (lVar5 != null) {
                        lVar5 = Component.GetComponent(lVar5,DAT_181d95560);
                        uVar6 = "";
                        if (lVar5 != null) {
                          puVar7 = (uint64 *)(lVar5 + 24);
                          *puVar7 = "";
        LAB_18098099e:
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
                                  lVar5 = FUN_180da9a20(lVar5,0);
                                  if (lVar5 != null) {
                                    lVar5 = Component.GetComponent(lVar5,DAT_181d95560);
                                    lVar2 = *(int64 *)(*(int64 *)(DAT_181da2058 + 184) + 32);
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
                                        goto LAB_18098099e;
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
    // RVA   : 0x97FA40   Offset: 0x97EE40   Length: 0x455
    public void ClearButtonClicked()
    {
        var pStatics_2058 = *(int64*)(DAT_181da2058 + 184);
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        float fVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        if ((*pStatics_2cc8 != 0) &&
           (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
          lVar4 = WorldData.Player(lVar4,0);
          lVar3 = *(int64 *)(pStatics_2058 + 32);
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
                lVar4 = *(int64 *)(pStatics_2058 + 32);
                if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 64)) != null) {
                  uVar2 = this.itemTypeID;
                  if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar4[uVar2];
                  if (lVar4 != null) {
                    FUN_181829cd0(lVar4,this.itemID,0,DAT_181d90f98);
                    lVar4 = *(int64 *)(pStatics_2058 + 32);
                    if (lVar4 != null) {
                      if (*(int *)(lVar4 + 24) == 0) {
                        lVar4 = *(int64 *)(pStatics_2058 + 32);
                        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 56)) != null) {
                          *(uint8 *)(lVar4 + 0x10c) = 1;
        LAB_18097fe6a:
                          ShowRoomSpaceController.SetShowRoomSpaceItem(this,0,0);
                          return;
                        }
                      }
                      else {
                        if ((*pStatics_2cc8 != 0) &&
                           (lVar4 = *(int64 *)(*pStatics_2cc8 + 32),
                           lVar4 != null)) {
                          fVar1 = *(float *)(lVar4 + 0x168);
                          if (this.targetItem != null) {
                            fVar5 = (float)ItemData.GetShowRoomFameChange
                                                     (this.targetItem,0x3e4ccccd,0);
                            *(float *)(lVar4 + 0x168) = fVar1 - fVar5;
                            goto LAB_18097fe6a;
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
