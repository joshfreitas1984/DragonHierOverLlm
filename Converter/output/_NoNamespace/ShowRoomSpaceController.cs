// ============================================================
// Type  : ShowRoomSpaceController
// Token : 0x200034F
// ============================================================

public class ShowRoomSpaceController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A7E
    public int itemTypeID;

    // Token: 0x4001A7F
    public int itemID;

    // Token: 0x4001A80
    public ItemData targetItem;

    // Token: 0x4001A81
    public GameObject itemTypeObj;

    // Token: 0x4001A82
    public GameObject targetItemObj;

    // Token: 0x4001A83
    public GameObject clearButtonObj;

    // Token: 0x4001A84
    public GameObject coverObj;

    // Token: 0x4001A85
    public Text itemNameText;

    // Token: 0x4001A86
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600208F
    // RVA   : 0x96D470   Offset: 0x96BC70   Length: 0x279
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
        lVar2 = **(int64 **)(DAT_181d92370 + 184);
        lVar4 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar4,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar4 != null) {
          FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d7ce38 + 184) + 8);
          if (lVar3 != null) {
            uVar1 = this.itemTypeID;
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_res18[0] =
                 lVar3[uVar1];
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            FUN_181827900(lVar4,uVar5,DAT_181d6e0e8);
            uVar5 = Component.get_gameObject(this,0);
            if (lVar2 != null) {
              ChooseController.ShowChoosePanel(lVar2,1,lVar4,uVar5,"SelectShowRoomItem",0,0,0,0,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002090
    // RVA   : 0x96D6F0   Offset: 0x96BEF0   Length: 0x54A
    public void SelectShowRoomItem()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_ce38 = *(int64*)(DAT_181d7ce38 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        lVar5 = *(int64 *)(pStatics_ce38 + 32);
        if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 64)) != null) {
          uVar2 = this.itemTypeID;
          if (*(uint32 *)(lVar5 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5[uVar2];
          uVar3 = this.itemID;
          if ((((*pStatics_2370 != 0) &&
               (lVar4 = *(int64 *)(*pStatics_2370 + 72)) != null) &&
              (lVar4 = GameObject.GetComponent(lVar4,DAT_181da0070)) != null) && (lVar5 != null)) {
            FUN_18182f280(lVar5,uVar3,*(uint64 *)(lVar4 + 32),DAT_181d697f0);
            if ((*pStatics_df90 != 0) &&
               (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              lVar4 = *(int64 *)(pStatics_ce38 + 32);
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
                    lVar5 = *(int64 *)(pStatics_ce38 + 32);
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
                        lVar5 = *(int64 *)(pStatics_ce38 + 32);
                        if (lVar5 != null) {
                          if (*(int *)(lVar5 + 24) == 0) {
                            lVar5 = *(int64 *)(pStatics_ce38 + 32);
                            if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 56)) != null) {
                              *(uint8 *)(lVar5 + 0x10c) = 1;
                              return;
                            }
                          }
                          else {
                            if ((*pStatics_df90 != 0) &&
                               (lVar5 = *(int64 *)(*pStatics_df90 + 32),
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

    // Token : 0x6002091
    // RVA   : 0x96DC40   Offset: 0x96C440   Length: 0x3BD
    public void SetShowRoomSpaceItem(ItemData _targetItem)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        this.targetItem = _targetItem;
        if (this.targetItem == null) {
          LTLocalization.SetText(this.itemNameText,"无",0);
          if (this.itemTypeObj != null) {
            GameObject.SetActive(this.itemTypeObj,1,0);
            if (this.targetItemObj != null) {
              GameObject.SetActive(this.targetItemObj,0,0);
              if (this.clearButtonObj != null) {
                GameObject.SetActive(this.clearButtonObj,0,0);
                if (this.coverObj != null) {
                  GameObject.SetActive(this.coverObj,0,0);
                  if (this.itemNameText != null) {
                    lVar4 = Component.get_transform(this.itemNameText,0);
                    if (lVar4 != null) {
                      lVar4 = FUN_180da0f00(lVar4,0);
                      if (lVar4 != null) {
                        lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                        uVar5 = "";
                        if (lVar4 != null) {
                          puVar6 = (uint64 *)(lVar4 + 24);
                          *puVar6 = "";
        LAB_18096df38:
                          il2cpp_internal(puVar6,uVar5);
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
          uVar5 = this.itemNameText;
          uVar3 = ItemData.Name(this.targetItem,0);
          LTLocalization.SetText(uVar5,uVar3,0);
          if (this.itemTypeObj != null) {
            GameObject.SetActive(this.itemTypeObj,0,0);
            if (this.targetItemObj != null) {
              lVar4 = GameObject.GetComponent(this.targetItemObj,DAT_181da0070);
              if (lVar4 != null) {
                *(uint64 *)(lVar4 + 32) = this.targetItem;
                if (this.targetItemObj != null) {
                  lVar4 = GameObject.GetComponent(this.targetItemObj,DAT_181da0070);
                  if (lVar4 != null) {
                    *(uint8 *)(lVar4 + 52) = 0;
                    if (this.targetItemObj != null) {
                      lVar4 = GameObject.GetComponent(this.targetItemObj,DAT_181da0070);
                      if (lVar4 != null) {
                        *(uint8 *)(lVar4 + 53) = 1;
                        if (this.targetItemObj != null) {
                          GameObject.SetActive(this.targetItemObj,1,0);
                          if (this.clearButtonObj != null) {
                            GameObject.SetActive(this.clearButtonObj,1,0);
                            if (this.coverObj != null) {
                              GameObject.SetActive(this.coverObj,1,0);
                              if (this.itemNameText != null) {
                                lVar4 = Component.get_transform(this.itemNameText,0);
                                if (lVar4 != null) {
                                  lVar4 = FUN_180da0f00(lVar4,0);
                                  if (lVar4 != null) {
                                    lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                                    lVar1 = *(int64 *)(*(int64 *)(DAT_181d7ce38 + 184) + 32);
                                    if (lVar1 != null) {
                                      lVar2 = this.targetItem;
                                      if (*(int *)(lVar1 + 24) == 0) {
                                        if (lVar2 == null) throw; // [null/range check failed]
                                        local_res8[0] =
                                             ItemData.GetShowRoomFameChange(lVar2,0x3f800000,0);
                                        uVar3 = Single.ToString(local_res8,"0.#",0);
                                        uVar5 = "威望+";
                                      }
                                      else {
                                        if (lVar2 == null) throw; // [null/range check failed]
                                        local_res8[0] =
                                             ItemData.GetShowRoomFameChange(lVar2,0x3e4ccccd,0);
                                        uVar3 = Single.ToString(local_res8,"0.#",0);
                                        uVar5 = "声望+";
                                      }
                                      uVar5 = String.Concat(uVar5,uVar3,0);
                                      if (lVar4 != null) {
                                        puVar6 = (uint64 *)(lVar4 + 24);
                                        *puVar6 = uVar5;
                                        goto LAB_18096df38;
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

    // Token : 0x6002092
    // RVA   : 0x96D010   Offset: 0x96B810   Length: 0x455
    public void ClearButtonClicked()
    {
        var pStatics_ce38 = *(int64*)(DAT_181d7ce38 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        if ((*pStatics_df90 != 0) &&
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar4 = WorldData.Player(lVar4,0);
          lVar3 = *(int64 *)(pStatics_ce38 + 32);
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
                lVar4 = *(int64 *)(pStatics_ce38 + 32);
                if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 64)) != null) {
                  uVar2 = this.itemTypeID;
                  if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar4[uVar2];
                  if (lVar4 != null) {
                    FUN_18182f280(lVar4,this.itemID,0,DAT_181d697f0);
                    lVar4 = *(int64 *)(pStatics_ce38 + 32);
                    if (lVar4 != null) {
                      if (*(int *)(lVar4 + 24) == 0) {
                        lVar4 = *(int64 *)(pStatics_ce38 + 32);
                        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 56)) != null) {
                          *(uint8 *)(lVar4 + 0x10c) = 1;
        LAB_18096d43a:
                          ShowRoomSpaceController.SetShowRoomSpaceItem(this,0,0);
                          return;
                        }
                      }
                      else {
                        if ((*pStatics_df90 != 0) &&
                           (lVar4 = *(int64 *)(*pStatics_df90 + 32),
                           lVar4 != null)) {
                          fVar1 = *(float *)(lVar4 + 0x168);
                          if (this.targetItem != null) {
                            fVar5 = (float)ItemData.GetShowRoomFameChange
                                                     (this.targetItem,0x3e4ccccd,0);
                            *(float *)(lVar4 + 0x168) = fVar1 - fVar5;
                            goto LAB_18096d43a;
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

    // Token : 0x6002093
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
