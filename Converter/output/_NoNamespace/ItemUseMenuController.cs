// ============================================================
// Type  : ItemUseMenuController
// Token : 0x20002EE
// ============================================================

public class ItemUseMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001798
    public GameObject itemUseMenuPanel;

    // Token: 0x4001799
    public GameObject itemUseChoiceButtonPrefab;

    // Token: 0x400179A
    public HeroData sourceHero;

    // Token: 0x400179B
    public ItemData targetItem;

    // Token: 0x400179C
    private GameObject temp;

    // Token: 0x400179D
    private static ItemUseMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600184D
    // RVA   : 0xB7EEB0   Offset: 0xB7D6B0   Length: 0x36
    public static ItemUseMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d5d1f8 + 184);
    }

    // Token : 0x600184E
    // RVA   : 0xB7E9E0   Offset: 0xB7D1E0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d5d1f8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600184F
    // RVA   : 0xB7EAE0   Offset: 0xB7D2E0   Length: 0x3C6
    public void Show(HeroData _sourceHero, GameObject _targetItemIcon)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar5;
        int iVar8;
        ulong local_28;
        uint local_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.itemUseMenuPanel != null) {
          GameObject.SetActive(this.itemUseMenuPanel,1,0);
          this.sourceHero = _sourceHero;
          if ((_targetItemIcon != null) && (lVar2 = GameObject.GetComponent(_targetItemIcon,DAT_181da0070)) != null) {
            this.targetItem = lVar2.summonControlable;
            if ((this.itemUseMenuPanel != null) &&
               (lVar2 = GameObject.get_transform(this.itemUseMenuPanel,0)) != null) {
              lVar2 = Transform.Find(lVar2,"ItemUseMenu",0);
              lVar3 = GameObject.get_transform(_targetItemIcon,0);
              if ((lVar3 != null) &&
                 (puVar4 = (uint64 *)Transform.get_position(&local_18,lVar3,0), lVar2 != null)) {
                local_28 = *puVar4;
                local_20 = *(uint32 *)(puVar4 + 1);
                Transform.set_position(lVar2,&local_28,0);
                if ((this.itemUseMenuPanel != null) &&
                   (lVar2 = GameObject.get_transform(this.itemUseMenuPanel,0)) != null) {
                  lVar2 = Transform.Find(lVar2,"ItemUseMenu",0);
                  puVar4 = (uint64 *)Vector3.get_zero(&local_18,0);
                  if (lVar2 != null) {
                    local_20 = *(uint32 *)(puVar4 + 1);
                    local_28 = *puVar4;
                    Transform.set_localScale(lVar2,&local_28,0);
                    if ((this.itemUseMenuPanel != null) &&
                       (lVar2 = GameObject.get_transform(this.itemUseMenuPanel,0)) != null) {
                      uVar5 = Transform.Find(lVar2,"ItemUseMenu",0);
                      ShortcutExtensions.DOScale(uVar5,0x3f800000,0x3e19999a,0);
                      if ((this.itemUseMenuPanel != null) &&
                         ((lVar2 = GameObject.get_transform(this.itemUseMenuPanel,0), lVar2 != null
                          && (lVar2 = Transform.Find(lVar2,"Back",0)) != null))) {
                        plVar6 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                        puVar7 = (uint32 *)FUN_180d904c0(&local_18,0);
                        if (plVar6 != (int64 *)0) {
                          local_18 = *puVar7;
                          uStack_14 = puVar7[1];
                          uStack_10 = puVar7[2];
                          uStack_c = puVar7[3];
                          (**(code **)(*plVar6 + 0x2a8))
                                    (plVar6,&local_18,*(uint64 *)(*plVar6 + 0x2b0));
                          if (((this.itemUseMenuPanel != null) &&
                              (lVar2 = GameObject.get_transform(this.itemUseMenuPanel,0),
                              lVar2 != null)) && (lVar2 = Transform.Find(lVar2,"Back",0)) != null
                             ) {
                            uVar5 = Component.GetComponent(lVar2,DAT_181d6bc40);
                            DOTweenModuleUI.DOFade(uVar5,0x3e800000,0x3e19999a,0);
                            ItemUseMenuController.AddChoiceButton
                                      (this,this.sourceHero,0);
                            lVar2 = this.sourceHero;
                            iVar8 = 0;
                            if (lVar2 != null) {
                              while (lVar2.teamMates != null) {
                                if (*(int *)(lVar2.teamMates + 24) <= iVar8) {
                                  return;
                                }
                                lVar2 = FUN_18046c0a0(0);
                                if (lVar2 == null) break;
                                lVar2 = lVar2.summonControlable;
                                if (((this.sourceHero == null) ||
                                    (lVar3 = this.sourceHero.teamMates,
                                    lVar3 == null)) ||
                                   (uVar1 = FUN_1800d6750(lVar3,iVar8,DAT_181d68270), lVar2 == null)) break;
                                uVar5 = WorldData.GetHero(lVar2,uVar1,0);
                                ItemUseMenuController.AddChoiceButton(this,uVar5,0);
                                lVar2 = this.sourceHero;
                                iVar8 = iVar8 + 1;
                                if (lVar2 == null) break;
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

    // Token : 0x6001850
    // RVA   : 0xB7E820   Offset: 0xB7D020   Length: 0x1B1
    public void AddChoiceButton(HeroData buttonTargetHero)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.itemUseMenuPanel != null) {
          lVar1 = GameObject.get_transform(this.itemUseMenuPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"ItemUseMenu",0);
            if (lVar1 != null) {
              uVar2 = Component.get_gameObject(lVar1,0);
              uVar3 = this.itemUseChoiceButtonPrefab;
              uVar3 = GlobalData.AddChild(uVar2,uVar3,0);
              this.temp = uVar3;
              if (this.temp != null) {
                lVar1 = GameObject.GetComponent(this.temp,DAT_181da00f8);
                if (lVar1 != null) {
                  *(int64 *)(lVar1 + 24) = buttonTargetHero;
                  if (this.temp != null) {
                    lVar1 = GameObject.get_transform(this.temp,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"Text",0);
                      if (lVar1 != null) {
                        uVar3 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                        if (buttonTargetHero != null) {
                          uVar2 = HeroData.Name(buttonTargetHero,0,0);
                          uVar2 = String.Format("{0}使用",uVar2,0);
                          LTLocalization.SetText(uVar3,uVar2,0);
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

    // Token : 0x6001851
    // RVA   : 0xB7EA30   Offset: 0xB7D230   Length: 0xAF
    public void Hide()
    {
        long lVar1;
        ulong uVar2;
        if (this.itemUseMenuPanel != null) {
          GameObject.SetActive(this.itemUseMenuPanel,0,0);
          if (this.itemUseMenuPanel != null) {
            lVar1 = GameObject.get_transform(this.itemUseMenuPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"ItemUseMenu",0);
              if (lVar1 != null) {
                uVar2 = Component.get_gameObject(lVar1,0);
                GlobalData.DeleteAllChild(uVar2,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001852
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
