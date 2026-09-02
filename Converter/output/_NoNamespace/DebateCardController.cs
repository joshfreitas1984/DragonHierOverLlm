// ============================================================
// Type  : DebateCardController
// Token : 0x2000257
// ============================================================

public class DebateCardController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001240
    public DebateCardData cardData;

    // Token: 0x4001241
    public List<Sprite> speCardSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001343
    // RVA   : 0xA5C860   Offset: 0xA5B060   Length: 0x71C
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d9aa08 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        byte[] local_18 = new byte[16];
        lVar3 = this.cardData;
        if (lVar3 == null) throw; // [null/range check failed]
        if (!lVar3.isPlayerCard) {
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"Back",0)) == null)
          throw; // [null/range check failed]
          local_28 = 0xbf800000;
          uStack_24 = 0x3f800000;
          uStack_20 = 0x3f800000;
          Transform.set_localScale(lVar3,&local_28,0);
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Back",0);
          lVar4 = Component.get_transform(this,0);
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Back",0)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint32 *)Transform.get_localPosition(&local_28,lVar4,0);
          if (lVar3 == null) throw; // [null/range check failed]
          uStack_24 = 0;
          uStack_20 = 0;
          local_28 = *puVar5 ^ 0x80000000;
          Transform.set_localPosition(lVar3,&local_28,0);
          lVar3 = this.cardData;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        if (!lVar3.isSpeCard) {
          if (lVar3.attriLv < 1) {
            lVar3 = Component.get_transform(this);
            if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
              uVar6 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              uVar7 = "弃权";
        LAB_180a5ccc7:
              LTLocalization.SetText(uVar6,uVar7,0);
              return;
            }
          }
          else {
            lVar3 = Component.get_transform(this);
            if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
              uVar6 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              if (this.cardData != null) {
                uVar1 = this.cardData.targetAttriID;
                uVar7 = GlobalData.GetBaseAttriName(uVar1,0);
                if (this.cardData != null) {
                  uVar8 = Int32.ToString(this.cardData + 28,0);
                  uVar7 = String.Concat(uVar7," ",uVar8,0);
                  LTLocalization.SetText(uVar6,uVar7,0);
                  lVar3 = Component.get_transform(this,0);
                  if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
                    lVar3 = Transform.Find(lVar3,"RareLv",0);
                    puVar9 = (uint64 *)Vector3.get_one(local_18,0);
                    if (lVar3 != null) {
                      uStack_20 = *(uint32 *)(puVar9 + 1);
                      local_28 = (uint32)*puVar9;
                      uStack_24 = (uint32)((uint64)*puVar9 >> 32);
                      Transform.set_localScale(lVar3,&local_28,0);
                      lVar3 = Component.get_transform(this,0);
                      if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null)
                         && (lVar3 = Transform.Find(lVar3,"RareLv",0)) != null) {
                        lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
                        lVar4 = **(int64 **)(DAT_181d86270 + 184);
                        if (this.cardData != null) {
                          uVar6 = Int32.ToString(this.cardData + 20,0);
                          uVar6 = String.Concat("RareLv",uVar6,0);
                          if ((lVar4 != null) &&
                             (uVar6 = TextureController.LoadAtlasSprite(lVar4,"IconAtlas",uVar6,0),
                             lVar3 != null)) {
                            Image.set_sprite(lVar3,uVar6,0);
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
        else {
          lVar3 = Component.get_transform(this);
          if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
            lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
            if ((this.cardData != null) &&
               (lVar4 = this.speCardSprite) != null) {
              uVar2 = this.cardData.rareLv;
              if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar3 != null) {
                Image.set_sprite(lVar3,*(uint64 *)
                                         (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar2 * 8),0
                                 );
                lVar3 = Component.get_transform(this,0);
                if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
                  lVar3 = Transform.Find(lVar3,"Decoration",0);
                  puVar9 = (uint64 *)Vector3.get_one(local_18,0);
                  if (lVar3 != null) {
                    uStack_20 = *(uint32 *)(puVar9 + 1);
                    local_28 = (uint32)*puVar9;
                    uStack_24 = (uint32)((uint64)*puVar9 >> 32);
                    Transform.set_localScale(lVar3,&local_28,0);
                    lVar3 = Component.get_transform(this,0);
                    if (((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Back",0)) != null) &&
                       (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                      lVar3 = GameObject.AddComponent(lVar3,DAT_181d9cf90);
                      lVar4 = *(int64 *)(pStatics + 8);
                      if ((this.cardData != null) && (lVar4 != null)) {
                        uVar2 = this.cardData.rareLv;
                        if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        if (lVar3 != null) {
                          lVar3.targetAttriID =
                               *(uint64 *)
                                (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar2 * 8);
                          il2cpp_internal();
                          lVar3 = Component.get_transform(this,0);
                          if ((((lVar3 != null) &&
                               (lVar3 = Transform.Find(lVar3,"Back",0)) != null) &&
                              (lVar3 = Component.get_gameObject(lVar3,0)) != null) &&
                             (lVar3 = GameObject.GetComponent(lVar3,DAT_181da12b0)) != null) {
                            *(uint8 *)(lVar3 + 40) = 1;
                            lVar3 = Component.get_transform(this,0);
                            if ((lVar3 != null) &&
                               (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
                              uVar6 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                              lVar3 = *pStatics;
                              if ((this.cardData != null) && (lVar3 != null)) {
                                uVar2 = this.cardData.rareLv;
                                if (lVar3.targetAttriID <= uVar2) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                uVar7 = *(uint64 *)
                                         (lVar3.isPlayerCard + 32 + (int64)(int)uVar2 * 8);
                                goto LAB_180a5ccc7;
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

    // Token : 0x6001344
    // RVA   : 0xA5D050   Offset: 0xA5B850   Length: 0x2CE
    public void RefreshButtonState()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        lVar2 = Component.get_transform(this,0);
        if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,"Back",0)) == null) ||
           (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40)) == null) throw; // [null/range check failed]
        Selectable.set_interactable(lVar2,0,0);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d9aa90 + 184) + 32);
        if (lVar2 == null) throw; // [null/range check failed]
        if (*(char *)(lVar2 + 136) != false) {
          return;
        }
        if (this.cardData == null) throw; // [null/range check failed]
        if (!this.cardData.isPlayerCard) {
          return;
        }
        lVar2 = FUN_18046be20(0);
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.targetAttriID == 2) {
          lVar2 = FUN_18046be20(0);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 116) != false)
          {
            }
            else {
          }
          lVar2 = FUN_18046be20(0);
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.targetAttriID != 3) {
            return;
          }
          lVar2 = FUN_18046be20(0);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 116) != false) {
            return;
          }
        }
        lVar3 = FUN_18046be20(0);
        lVar2 = this.cardData;
        if ((lVar3 != null) && (lVar2 != null)) {
          if (!lVar2.isPlayerCard) {
            iVar1 = *(int *)(lVar3 + 132);
          }
          else {
            iVar1 = *(int *)(lVar3 + 124);
          }
          if (iVar1 < 1) {
            if (!lVar2.isSpeCard) {
              if ((*(int *)(lVar3 + 108) != -1) && (lVar2.targetAttriID == *(int *)(lVar3 + 108))) {
                return;
              }
              if ((*(int *)(lVar3 + 112) != -1) && (lVar2.targetAttriID != *(int *)(lVar3 + 112))) {
                return;
              }
            }
          }
          else if ((!lVar2.isSpeCard) || (lVar2.rareLv != 4)) {
            return;
          }
          lVar2 = Component.get_transform(this,0);
          if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"Back",0)) != null) &&
             (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40)) != null) {
            Selectable.set_interactable(lVar2,1,0);
            return;
          }
        }
    }

    // Token : 0x6001345
    // RVA   : 0xA5CF80   Offset: 0xA5B780   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d9aa90 + 184) + 32);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          DebateUIController.UseDebateCard(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6001346
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
