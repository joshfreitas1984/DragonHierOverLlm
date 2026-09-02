// ============================================================
// Type  : ItemListData
// Token : 0x2000210
// ============================================================

public class ItemListData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EA7
    public int heroID;

    // Token: 0x4000EA8
    public int forceID;

    // Token: 0x4000EA9
    public int money;

    // Token: 0x4000EAA
    public float weight;

    // Token: 0x4000EAB
    public float maxWeight;

    // Token: 0x4000EAC
    public List<ItemData> allItem;

    // Token: 0x4000EAD
    public List<List<ItemData>> itemTypeList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001019
    // RVA   : 0xB7E450   Offset: 0xB7CC50   Length: 0x23E
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        this.heroID = 0xffffffffffffffff;
        this.maxWeight = 0xbf800000;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(uVar1,DAT_181d691f0);
        this.allItem = uVar1;
        lVar2 = il2cpp_internal(DAT_181d6b630);
        FUN_180f58a90(lVar2,DAT_181d51708);
        uVar1 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(uVar1,DAT_181d691f0);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          uVar1 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(uVar1,DAT_181d691f0);
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          uVar1 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(uVar1,DAT_181d691f0);
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          uVar1 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(uVar1,DAT_181d691f0);
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          uVar1 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(uVar1,DAT_181d691f0);
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          uVar1 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(uVar1,DAT_181d691f0);
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          uVar1 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(uVar1,DAT_181d691f0);
          FUN_181827900(lVar2,uVar1,DAT_181d51788);
          this.itemTypeList = lVar2;
          return;
        }
    }

    // Token : 0x600101A
    // RVA   : 0xB7E2F0   Offset: 0xB7CAF0   Length: 0x15C
    internal void OnDeserializedMethod(StreamingContext context)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        if (this.allItem != null) {
          uVar4 = this.allItem.Count - 1;
          if (-1 < (int)uVar4) {
            lVar5 = (int64)(int)uVar4 * 8 + 32;
            do {
              lVar2 = this.allItem;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = this.allItem;
              if (*(int64 *)(lVar2._items + lVar5) == 0) {
                if (lVar1 == null) throw; // [null/range check failed]
                FUN_18182b220(lVar1,uVar4,DAT_181d695f0);
              }
              else {
                lVar2 = this.itemTypeList;
                if (lVar1 == null) throw; // [null/range check failed]
                lVar1 = FUN_180002f80(lVar1,uVar4,DAT_181d69770);
                if ((lVar1 == null) || (lVar2 == null)) throw; // [null/range check failed]
                lVar2 = FUN_180002f80(lVar2,*(uint32 *)(lVar1 + 20),DAT_181d51888);
                if (this.allItem == null) throw; // [null/range check failed]
                uVar3 = FUN_180002f80(this.allItem,uVar4,DAT_181d69770);
                if (lVar2 == null) throw; // [null/range check failed]
                FUN_181827900(lVar2,uVar3,DAT_181d692f0);
              }
              lVar5 = lVar5 + -8;
              uVar4 = uVar4 - 1;
            } while (-1 < (int)uVar4);
          }
          return;
        }
    }

    // Token : 0x600101B
    // RVA   : 0xB7CF30   Offset: 0xB7B730   Length: 0xDE
    public void ClearAllItem()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        if (this.allItem != null) {
          FUN_180f56130(this.allItem,DAT_181d69370);
          lVar1 = this.itemTypeList;
          uVar3 = 0;
          if (lVar1 != null) {
            lVar2 = 32;
            do {
              if (lVar1.Count <= (int)uVar3) {
                this.weight = 0;
                return;
              }
              if (lVar1 == null) break;
              if (lVar1.Count <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar2 + lVar1._items);
              if (lVar1 == null) break;
              FUN_180f56130(lVar1,DAT_181d69370);
              lVar1 = this.itemTypeList;
              uVar3 = uVar3 + 1;
              lVar2 = lVar2 + 8;
            } while (lVar1 != null);
          }
        }
    }

    // Token : 0x600101C
    // RVA   : 0xB7D7A0   Offset: 0xB7BFA0   Length: 0x146
    public string GetItemName()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        ulong uVar6;
        lVar2 = this.allItem;
        iVar5 = 0;
        uVar4 = "";
        do {
          if (lVar2 == null) {
        LAB_180b7d8e1:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar2.Count <= iVar5) {
        LAB_180b7d8ad:
            if (5 < lVar2.Count) {
              uVar4 = String.Concat(uVar4,"……",0);
            }
            return uVar4;
          }
          if (4 < iVar5) {
            if (lVar2 != null) goto LAB_180b7d8ad;
            goto LAB_180b7d8e1;
          }
          cVar1 = String.op_Inequality(uVar4,"",0);
          uVar6 = "";
          if (cVar1) {
            uVar6 = "/";
          }
          if ((this.allItem == null) ||
             (lVar2 = FUN_180002f80(this.allItem,iVar5,DAT_181d69770)) == null)
          goto LAB_180b7d8e1;
          uVar3 = ItemData.Name(lVar2,1,0);
          uVar4 = String.Concat(uVar4,uVar6,uVar3,0);
          iVar5 = iVar5 + 1;
          lVar2 = this.allItem;
        } while( true );
    }

    // Token : 0x600101D
    // RVA   : 0xB7D8F0   Offset: 0xB7C0F0   Length: 0xC7
    public float GetItemValue()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.allItem;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 32;
          do {
            if (lVar1.Count <= (int)uVar3) {
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar2 + lVar1._items) == 0) break;
            uVar3 = uVar3 + 1;
            lVar1 = this.allItem;
            lVar2 = lVar2 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x600101E
    // RVA   : 0xB7D9C0   Offset: 0xB7C1C0   Length: 0xAD
    private void MergeList(ItemListData target)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        if (target != null) {
          uVar3 = 0;
          lVar2 = 32;
          while( true ) {
            lVar1 = *(int64 *)(target + 40);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar3) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            ItemListData.GetItem(this,*(uint64 *)(*(int64 *)(lVar1 + 16) + lVar2),0,0);
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
          }
        }
    }

    // Token : 0x600101F
    // RVA   : 0xB7E240   Offset: 0xB7CA40   Length: 0xAD
    private void RemoveList(ItemListData target)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        if (target != null) {
          uVar3 = 0;
          lVar2 = 32;
          while( true ) {
            lVar1 = *(int64 *)(target + 40);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar3) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            ItemListData.LoseItem(this,*(uint64 *)(*(int64 *)(lVar1 + 16) + lVar2),0,0);
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
          }
        }
    }

    // Token : 0x6001020
    // RVA   : 0xB7D9C0   Offset: 0xB7C1C0   Length: 0xAD
    public void GetItem(ItemListData target)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (-1 < this.heroID) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,this.heroID,0);
          if (lVar3 != null) {
            if (target == null) throw; // [null/range check failed]
            iVar1 = *(int *)(target + 20);
            if ((iVar1 == 0) || (iVar1 == 6)) {
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,
                                              0), lVar3 == null)) || (*(int64 *)(lVar3 + 64) == 0))
              throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar3 + 64) + 44) = 1;
            }
            else if (iVar1 - 1U < 2) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,
                                              0), lVar3 == null || (*(int64 *)(lVar3 + 64) == 0))))
              throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar3 + 64) + 46) = 1;
            }
          }
        }
        if ((this.allItem != null) &&
           (FUN_181827900(this.allItem,target,DAT_181d692f0), target != null)) {
          lVar3 = this.itemTypeList;
          this.weight = *(float *)(target + 68) + this.weight;
          if (lVar3 != null) {
            uVar2 = *(uint32 *)(target + 20);
            if (lVar3.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3._items[uVar2];
            if (lVar3 != null) {
              FUN_181827900(lVar3,target,DAT_181d692f0);
              if (param_3) {
                uVar7 = "{0}仓库添加了 {1}";
                lVar3 = **(int64 **)(DAT_181d5a578 + 184);
                uVar5 = "";
                if (-1 < this.heroID) {
                  lVar4 = FUN_18046c0a0(0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
                  lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),this.heroID,0
                                            );
                  uVar5 = "";
                  if (lVar4 != null) {
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                       (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),
                                                   this.heroID,0), lVar4 == null))
                    throw; // [null/range check failed]
                    uVar5 = HeroData.HeroName(lVar4,0,0);
                  }
                }
                uVar6 = ItemData.Name(target,1,0);
                uVar7 = String.Format(uVar7,uVar5,uVar6,0);
                uVar5 = ItemData.GetItemIconName(target,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_18 = 0;
                uStack_10 = 0;
                InfoController.AddInfoTab
                          (lVar3,uVar7,"IconAtlas",uVar5,"ItemGet",0x3f800000,0x40a00000,&local_18,0
                          );
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001021
    // RVA   : 0xB7E240   Offset: 0xB7CA40   Length: 0xAD
    public void LoseItem(ItemListData target)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (target == null) {
          return;
        }
        if (-1 < this.heroID) {
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,0);
          if (lVar3 != null) {
            if (*(int *)(target + 20) == 0) {
              if (*(int64 *)(target + 96) == 0) throw; // [null/range check failed]
              cVar1 = *(char *)(*(int64 *)(target + 96) + 48);
            }
            else {
              if (*(int *)(target + 20) != 6) goto LAB_180b7e01f;
              if (*(int64 *)(target + 136) == 0) throw; // [null/range check failed]
              cVar1 = *(char *)(*(int64 *)(target + 136) + 16);
            }
            if (cVar1) {
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,
                                              0), lVar3 == null)) || (*(int64 *)(lVar3 + 64) == 0))
              throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar3 + 64) + 44) = 1;
            }
          }
        }
        LAB_180b7e01f:
        if (this.allItem != null) {
          FUN_181801c10(this.allItem,target,DAT_181d69570);
          lVar3 = this.itemTypeList;
          this.weight = this.weight - *(float *)(target + 68);
          if (lVar3 != null) {
            uVar2 = *(uint32 *)(target + 20);
            if (lVar3.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3._items[uVar2];
            if (lVar3 != null) {
              FUN_181801c10(lVar3,target,DAT_181d69570);
              if (param_3) {
                uVar7 = "{0}仓库移除了 {1}";
                lVar3 = **(int64 **)(DAT_181d5a578 + 184);
                uVar5 = "";
                if (-1 < this.heroID) {
                  lVar4 = FUN_18046c0a0(0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
                  lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),this.heroID,0
                                            );
                  uVar5 = "";
                  if (lVar4 != null) {
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                       (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),
                                                   this.heroID,0), lVar4 == null))
                    throw; // [null/range check failed]
                    uVar5 = HeroData.HeroName(lVar4,0,0);
                  }
                }
                uVar6 = ItemData.Name(target,1,0);
                uVar7 = String.Format(uVar7,uVar5,uVar6,0);
                uVar5 = ItemData.GetItemIconName(target,0);
                puVar8 = (uint64 *)Color.get_red(&local_18,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_18 = *puVar8;
                uStack_10 = puVar8[1];
                InfoController.AddInfoTab
                          (lVar3,uVar7,"IconAtlas",uVar5,"ItemLose",0x3f800000,0x40a00000,&local_18,0
                          );
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001022
    // RVA   : 0xB7DA70   Offset: 0xB7C270   Length: 0x42B
    public void GetItem(ItemData targetItem, bool showPopInfo)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (-1 < this.heroID) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(lVar3,this.heroID,0);
          if (lVar3 != null) {
            if (targetItem == null) throw; // [null/range check failed]
            iVar1 = *(int *)(targetItem + 20);
            if ((iVar1 == 0) || (iVar1 == 6)) {
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,
                                              0), lVar3 == null)) || (*(int64 *)(lVar3 + 64) == 0))
              throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar3 + 64) + 44) = 1;
            }
            else if (iVar1 - 1U < 2) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,
                                              0), lVar3 == null || (*(int64 *)(lVar3 + 64) == 0))))
              throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar3 + 64) + 46) = 1;
            }
          }
        }
        if ((this.allItem != null) &&
           (FUN_181827900(this.allItem,targetItem,DAT_181d692f0), targetItem != null)) {
          lVar3 = this.itemTypeList;
          this.weight = *(float *)(targetItem + 68) + this.weight;
          if (lVar3 != null) {
            uVar2 = *(uint32 *)(targetItem + 20);
            if (lVar3.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3._items[uVar2];
            if (lVar3 != null) {
              FUN_181827900(lVar3,targetItem,DAT_181d692f0);
              if (showPopInfo) {
                uVar7 = "{0}仓库添加了 {1}";
                lVar3 = **(int64 **)(DAT_181d5a578 + 184);
                uVar5 = "";
                if (-1 < this.heroID) {
                  lVar4 = FUN_18046c0a0(0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
                  lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),this.heroID,0
                                            );
                  uVar5 = "";
                  if (lVar4 != null) {
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                       (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),
                                                   this.heroID,0), lVar4 == null))
                    throw; // [null/range check failed]
                    uVar5 = HeroData.HeroName(lVar4,0,0);
                  }
                }
                uVar6 = ItemData.Name(targetItem,1,0);
                uVar7 = String.Format(uVar7,uVar5,uVar6,0);
                uVar5 = ItemData.GetItemIconName(targetItem,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_18 = 0;
                uStack_10 = 0;
                InfoController.AddInfoTab
                          (lVar3,uVar7,"IconAtlas",uVar5,"ItemGet",0x3f800000,0x40a00000,&local_18,0
                          );
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001023
    // RVA   : 0xB7DEA0   Offset: 0xB7C6A0   Length: 0x39B
    public void LoseItem(ItemData targetItem, bool showPopInfo)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong local_18;
        ulong uStack_10;
        if (targetItem == null) {
          return;
        }
        if (-1 < this.heroID) {
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,0);
          if (lVar3 != null) {
            if (*(int *)(targetItem + 20) == 0) {
              if (*(int64 *)(targetItem + 96) == 0) throw; // [null/range check failed]
              cVar1 = *(char *)(*(int64 *)(targetItem + 96) + 48);
            }
            else {
              if (*(int *)(targetItem + 20) != 6) goto LAB_180b7e01f;
              if (*(int64 *)(targetItem + 136) == 0) throw; // [null/range check failed]
              cVar1 = *(char *)(*(int64 *)(targetItem + 136) + 16);
            }
            if (cVar1) {
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),this.heroID,
                                              0), lVar3 == null)) || (*(int64 *)(lVar3 + 64) == 0))
              throw; // [null/range check failed]
              *(uint8 *)(*(int64 *)(lVar3 + 64) + 44) = 1;
            }
          }
        }
        LAB_180b7e01f:
        if (this.allItem != null) {
          FUN_181801c10(this.allItem,targetItem,DAT_181d69570);
          lVar3 = this.itemTypeList;
          this.weight = this.weight - *(float *)(targetItem + 68);
          if (lVar3 != null) {
            uVar2 = *(uint32 *)(targetItem + 20);
            if (lVar3.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3._items[uVar2];
            if (lVar3 != null) {
              FUN_181801c10(lVar3,targetItem,DAT_181d69570);
              if (showPopInfo) {
                uVar7 = "{0}仓库移除了 {1}";
                lVar3 = **(int64 **)(DAT_181d5a578 + 184);
                uVar5 = "";
                if (-1 < this.heroID) {
                  lVar4 = FUN_18046c0a0(0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
                  lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),this.heroID,0
                                            );
                  uVar5 = "";
                  if (lVar4 != null) {
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                       (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),
                                                   this.heroID,0), lVar4 == null))
                    throw; // [null/range check failed]
                    uVar5 = HeroData.HeroName(lVar4,0,0);
                  }
                }
                uVar6 = ItemData.Name(targetItem,1,0);
                uVar7 = String.Format(uVar7,uVar5,uVar6,0);
                uVar5 = ItemData.GetItemIconName(targetItem,0);
                puVar8 = (uint64 *)Color.get_red(&local_18,0);
                if (lVar3 == null) throw; // [null/range check failed]
                local_18 = *puVar8;
                uStack_10 = puVar8[1];
                InfoController.AddInfoTab
                          (lVar3,uVar7,"IconAtlas",uVar5,"ItemLose",0x3f800000,0x40a00000,&local_18,0
                          );
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001024
    // RVA   : 0xB7D190   Offset: 0xB7B990   Length: 0x440
    public ItemData FindRandomItem(int minItemLv, int maxItemLv, bool includeEquipment, int targetItemType, List<int> subType, int littleType, float minValue, float maxValue)
    {
        uint64
        ItemListData.FindRandomItem
                (int64 this,int minItemLv,int maxItemLv,char includeEquipment,int targetItemType,int64 subType,
                int littleType,float minValue,float maxValue)
        {
        int iVar1;
        char cVar2;
        int64 lVar3;
        int64 lVar4;
        uint32 uVar5;
        int64 lVar6;
        if (maxValue == null.0) {
          return false;
        }
        lVar3 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar3,DAT_181d678f8);
        lVar4 = this.allItem;
        uVar5 = 0;
        if (lVar4 != null) {
          lVar6 = 32;
          while ((int)uVar5 < lVar4.Count) {
            if (lVar4 == null) throw; // [null/range check failed]
            if (lVar4.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar6 + lVar4._items);
            if (lVar4 == null) throw; // [null/range check failed]
            if (minItemLv <= *(int *)(lVar4 + 60)) {
              if ((this.allItem == null) ||
                 (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar4 + 60) <= maxItemLv) {
                if (!includeEquipment) {
                  if ((this.allItem == null) ||
                     (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null)
                  throw; // [null/range check failed]
                  cVar2 = ItemData.Equiped(lVar4,0);
                  if (cVar2) goto LAB_180b7d4f8;
                }
                if (targetItemType != -1) {
                  if ((this.allItem == null) ||
                     (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar4 + 20) != targetItemType) goto LAB_180b7d4f8;
                }
                if (subType != null) {
                  if ((this.allItem == null) ||
                     (lVar4 = FUN_180002f80(this.allItem,uVar5,DAT_181d69770), lVar4 == null
                     )) throw; // [null/range check failed]
                  cVar2 = FUN_181815240(subType,lVar4.Count);
                  if (!cVar2) goto LAB_180b7d4f8;
                }
                if (littleType == -1) {
        LAB_180b7d46c:
                  if (minValue != -1.0) {
                    if ((this.allItem == null) ||
                       (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null)
                    throw; // [null/range check failed]
                    if ((float)*(int *)(lVar4 + 56) < minValue) goto LAB_180b7d4f8;
                  }
                  if (maxValue != -1.0) {
                    if ((this.allItem == null) ||
                       (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null)
                    throw; // [null/range check failed]
                    if (maxValue < (float)*(int *)(lVar4 + 56)) goto LAB_180b7d4f8;
                  }
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar3,uVar5);
                }
                else {
                  if ((this.allItem == null) ||
                     (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null)
                  throw; // [null/range check failed]
                  if (*(int64 *)(lVar4 + 96) != 0) {
                    if (((this.allItem == null) ||
                        (lVar4 = FUN_180002f80(this.allItem,uVar5)) == null) ||
                       (*(int64 *)(lVar4 + 96) == 0)) throw; // [null/range check failed]
                    if (*(int *)(*(int64 *)(lVar4 + 96) + 20) == littleType) goto LAB_180b7d46c;
                  }
                }
              }
            }
        LAB_180b7d4f8:
            lVar4 = this.allItem;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
            if (lVar4 == null) throw; // [null/range check failed]
          }
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
            if (iVar1 == 0) {
              return false;
            }
            uVar5 = GlobalData.RandomRange(0,iVar1,0,0);
            if (*(uint32 *)(lVar3 + 24) <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar4 != null) {
              uVar5 = lVar3[uVar5];
              if (lVar4.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return lVar4._items[uVar5];
            }
          }
        }
    }

    // Token : 0x6001025
    // RVA   : 0xB7CF20   Offset: 0xB7B720   Length: 0x9
    public bool BelongHero()
    {
        return this.heroID >> 31 ^ 1;
    }

    // Token : 0x6001026
    // RVA   : 0xB7D6C0   Offset: 0xB7BEC0   Length: 0xD0
    public HeroData GetHero()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        if (this.heroID < 0) {
          return 0;
        }
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          uVar2 = WorldData.GetHero(lVar1,this.heroID,0);
          return uVar2;
        }
    }

    // Token : 0x6001027
    // RVA   : 0xB7CF10   Offset: 0xB7B710   Length: 0x9
    public bool BelongForce()
    {
        return this.forceID >> 31 ^ 1;
    }

    // Token : 0x6001028
    // RVA   : 0xB7D5E0   Offset: 0xB7BDE0   Length: 0xD0
    public ForceData GetForce()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        if (this.forceID < 0) {
          return 0;
        }
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          uVar2 = WorldData.GetForce(lVar1,this.forceID,0);
          return uVar2;
        }
    }

    // Token : 0x6001029
    // RVA   : 0xB7D010   Offset: 0xB7B810   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
