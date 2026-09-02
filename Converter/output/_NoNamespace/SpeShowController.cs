// ============================================================
// Type  : SpeShowController
// Token : 0x2000360
// ============================================================

public class SpeShowController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001ADA
    public bool showPopInfo;

    // Token: 0x4001ADB
    public int treasureChestClickTime;

    // Token: 0x4001ADC
    public float leftShowTime;

    // Token: 0x4001ADD
    public GameObject speShowUIPanel;

    // Token: 0x4001ADE
    public GameObject speShowUIRoot;

    // Token: 0x4001ADF
    public ItemListController itemList;

    // Token: 0x4001AE0
    public GameObject speShowGrid;

    // Token: 0x4001AE1
    public GameObject skillList;

    // Token: 0x4001AE2
    public GameObject treasureChest;

    // Token: 0x4001AE3
    public Sprite chestCloseSprite;

    // Token: 0x4001AE4
    public Sprite chestOpenSprite;

    // Token: 0x4001AE5
    public Sprite chestBigCloseSprite;

    // Token: 0x4001AE6
    public Sprite chestBigOpenSprite;

    // Token: 0x4001AE7
    public Sprite itemBlackBack;

    // Token: 0x4001AE8
    public GameObject showItemSmoke;

    // Token: 0x4001AE9
    public GameObject showItemSpark;

    // Token: 0x4001AEA
    public GameObject showItemFlash;

    // Token: 0x4001AEB
    public GameObject showItemImpact;

    // Token: 0x4001AEC
    private bool bigTreasure;

    // Token: 0x4001AED
    private GameObject newObj;

    // Token: 0x4001AEE
    private static SpeShowController _instance;

    // Token: 0x4001AEF
    private bool itemNumOutRange;

    // Token: 0x4001AF0
    private static float ItemAnimTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020FD
    // RVA   : 0xC6ACC0   Offset: 0xC694C0   Length: 0x57
    public static SpeShowController get_Instance()
    {
        return **(uint64 **)(DAT_181d7f230 + 184);
    }

    // Token : 0x60020FE
    // RVA   : 0xC69180   Offset: 0xC67980   Length: 0x116
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d7f230 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d7f230 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020FF
    // RVA   : 0xC6AC40   Offset: 0xC69440   Length: 0x36
    private void Update()
    {
        float fVar1;
        float fVar2;
        fVar1 = this.leftShowTime;
        if (0.0 < fVar1) {
          fVar2 = (float)RealTime.get_deltaTime(0);
          this.leftShowTime = fVar1 - fVar2;
        }
    }

    // Token : 0x6002100
    // RVA   : 0xC692A0   Offset: 0xC67AA0   Length: 0x97
    public void HideSpeShowPanel()
    {
        ulong uVar1;
        if ((this.leftShowTime <= 0.0) && (this.treasureChestClickTime < 1)) {
          if (this.speShowUIPanel == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          GameObject.SetActive(this.speShowUIPanel,0,0);
          uVar1 = this.speShowGrid;
          GlobalData.DeleteAllChild(uVar1,0);
          GlobalData.DeleteAllChild(this.skillList,0);
        }
    }

    // Token : 0x6002101
    // RVA   : 0xC6A690   Offset: 0xC68E90   Length: 0xB5
    public void ShowSpeShowUIPanel()
    {
        long lVar1;
        ulong uVar2;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.speShowUIPanel != null) {
          GameObject.SetActive(this.speShowUIPanel,1,0);
          if (this.speShowUIRoot != null) {
            lVar1 = GameObject.get_transform(this.speShowUIRoot,0);
            if (lVar1 != null) {
              local_28 = 0x3f80000000000000;
              local_20 = 0x3f800000;
              Transform.set_localScale(lVar1,&local_28,0);
              if (this.speShowUIRoot != null) {
                uVar2 = GameObject.get_transform(this.speShowUIRoot,0);
                puVar3 = (uint64 *)Vector3.get_one(local_18,0);
                local_20 = *(uint32 *)(puVar3 + 1);
                local_28 = *puVar3;
                ShortcutExtensions.DOScale(uVar2,&local_28,0x3e19999a,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002102
    // RVA   : 0xC699F0   Offset: 0xC681F0   Length: 0xAC
    public void ShowGetItem(ItemData targetData, int _treasureChestClickTime, bool _showPopInfo)
    {
        void SpeShowController.ShowGetItem
                     (int64 this,int64 targetData,int _treasureChestClickTime,uint8 _showPopInfo)
        {
        uint32 uVar1;
        int iVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 *puVar5;
        uint64 uVar6;
        int64 *plVar7;
        int iVar8;
        uint64 local_68;
        uint32 local_60;
        uint8 local_58 [16];
        uint64 local_48;
        uint64 uStack_40;
        uint64 local_38;
        uint64 uStack_30;
        this.itemNumOutRange = 0;
        if (targetData != null) {
          while (*(int64 *)(targetData + 40) != 0) {
            uVar1 = *(uint32 *)(*(int64 *)(targetData + 40) + 24);
            if ((int)uVar1 < 31) {
              SpeShowController.ShowSpeShowUIPanel(this,0);
              if (((this.speShowUIRoot != null) &&
                  (lVar3 = GameObject.get_transform(this.speShowUIRoot,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                LTLocalization.SetText(uVar4,"获得物品",0);
                if (this.itemList != null) {
                  ItemListController.RefreshItemList(this.itemList,targetData,0,0);
                  lVar3 = this.speShowGrid;
                  iVar8 = 0;
                  if (lVar3 != null) goto LAB_180c69590;
                }
              }
              break;
            }
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            ItemListData.LoseItem();
            this.itemNumOutRange = 1;
          }
        }
        LAB_180c699e9:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c69590:
        lVar3 = GameObject.get_transform(lVar3,0);
        if (lVar3 == null) goto LAB_180c699e9;
        iVar2 = Transform.get_childCount(lVar3,0);
        if (iVar2 <= iVar8) {
          this.showPopInfo = _showPopInfo;
          this.treasureChestClickTime = _treasureChestClickTime;
          if (this.treasureChest == null) goto LAB_180c699e9;
          GameObject.SetActive(this.treasureChest,0 < _treasureChestClickTime,0);
          this.bigTreasure = 1 < this.treasureChestClickTime;
          if (this.treasureChestClickTime < 1) {
            var lVar3 = new WarpText_d__8(0,0);
            if (lVar3 == null) goto LAB_180c699e9;
            *(int64 *)(lVar3 + 32) = this;
            *(uint32 *)(lVar3 + 40) = 0x3e19999a;
            FUN_180d837c0(this,lVar3,0);
          }
          else {
            if ((this.treasureChest == null) ||
               (lVar3 = GameObject.get_transform(this.treasureChest,0)) == null)
            goto LAB_180c699e9;
            local_68 = 0xc1c8000000000000;
            local_60 = 0;
            Transform.set_localPosition(lVar3,&local_68,0);
            if ((this.treasureChest == null) ||
               ((lVar3 = GameObject.get_transform(this.treasureChest,0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"Icon",0)) == null))) goto LAB_180c699e9;
            lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
            if (!this.bigTreasure) {
              uVar4 = this.chestCloseSprite;
            }
            else {
              uVar4 = this.chestBigCloseSprite;
            }
            if (lVar3 == null) goto LAB_180c699e9;
            Image.set_sprite(lVar3,uVar4,0);
            if (((this.treasureChest == null) ||
                (lVar3 = GameObject.get_transform(this.treasureChest,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"Light",0)) == null) goto LAB_180c699e9;
            plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
            puVar5 = (uint64 *)FUN_181098a50(&local_38,0);
            if (plVar7 == (int64 *)0) goto LAB_180c699e9;
            local_38 = *puVar5;
            uStack_30 = puVar5[1];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.treasureChest == null) ||
                (lVar3 = GameObject.get_transform(this.treasureChest,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"Light",0)) == null) goto LAB_180c699e9;
            uVar4 = Component.GetComponent(lVar3,DAT_181d6bc40);
            uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f4ccccd,0x3f000000,0);
            TweenSettingsExtensions.SetLoops(uVar4,0xffffffff,1,DAT_181d97f50);
            if ((this.treasureChest == null) ||
               (lVar3 = GameObject.GetComponent(this.treasureChest,DAT_181d9ee60)) == null
               ) goto LAB_180c699e9;
            Selectable.set_interactable(lVar3,1,0);
          }
          return;
        }
        if ((this.speShowGrid == null) ||
           (lVar3 = GameObject.get_transform(this.speShowGrid,0)) == null)
        goto LAB_180c699e9;
        lVar3 = Transform.GetChild(lVar3,iVar8,0);
        puVar5 = (uint64 *)Vector3.get_zero(local_58,0);
        if (lVar3 == null) goto LAB_180c699e9;
        local_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        Transform.set_localScale(lVar3,&local_68,0);
        if (((this.speShowGrid == null) ||
            (lVar3 = GameObject.get_transform(this.speShowGrid,0)) == null) ||
           (lVar3 = Transform.GetChild(lVar3,iVar8,0)) == null) goto LAB_180c699e9;
        uVar6 = Component.get_gameObject(lVar3,0);
        uVar4 = this.itemBlackBack;
        local_48 = 0;
        uStack_40 = 0;
        local_38 = 0;
        uStack_30 = 0;
        lVar3 = GlobalData.AddImage(uVar6,0,uVar4,&local_38,&local_48,0);
        if ((lVar3 == null) ||
           (plVar7 = (int64 *)GameObject.GetComponent(lVar3,DAT_181d9fe50), plVar7 == (int64 *)0)
           ) goto LAB_180c699e9;
        (**(code **)(*plVar7 + 0x408))(plVar7,*(uint64 *)(*plVar7 + 0x410));
        plVar7 = (int64 *)GameObject.GetComponent(lVar3);
        if (plVar7 == (int64 *)0) goto LAB_180c699e9;
        (**(code **)(*plVar7 + 0x2c8))(plVar7);
        lVar3 = GameObject.get_transform(lVar3);
        if (lVar3 == null) goto LAB_180c699e9;
        Transform.SetAsFirstSibling(lVar3);
        lVar3 = this.speShowGrid;
        iVar8 = iVar8 + 1;
        if (lVar3 == null) goto LAB_180c699e9;
        goto LAB_180c69590;
    }

    // Token : 0x6002103
    // RVA   : 0xC693C0   Offset: 0xC67BC0   Length: 0x62E
    public void ShowGetItem(ItemListData targetItemList, int _treasureChestClickTime, bool _showPopInfo)
    {
        void SpeShowController.ShowGetItem
                     (int64 this,int64 targetItemList,int _treasureChestClickTime,uint8 _showPopInfo)
        {
        uint32 uVar1;
        int iVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 *puVar5;
        uint64 uVar6;
        int64 *plVar7;
        int iVar8;
        uint64 local_68;
        uint32 local_60;
        uint8 local_58 [16];
        uint64 local_48;
        uint64 uStack_40;
        uint64 local_38;
        uint64 uStack_30;
        this.itemNumOutRange = 0;
        if (targetItemList != null) {
          while (*(int64 *)(targetItemList + 40) != 0) {
            uVar1 = *(uint32 *)(*(int64 *)(targetItemList + 40) + 24);
            if ((int)uVar1 < 31) {
              SpeShowController.ShowSpeShowUIPanel(this,0);
              if (((this.speShowUIRoot != null) &&
                  (lVar3 = GameObject.get_transform(this.speShowUIRoot,0)) != null) &&
                 (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                LTLocalization.SetText(uVar4,"获得物品",0);
                if (this.itemList != null) {
                  ItemListController.RefreshItemList(this.itemList,targetItemList,0,0);
                  lVar3 = this.speShowGrid;
                  iVar8 = 0;
                  if (lVar3 != null) goto LAB_180c69590;
                }
              }
              break;
            }
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            ItemListData.LoseItem();
            this.itemNumOutRange = 1;
          }
        }
        LAB_180c699e9:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c69590:
        lVar3 = GameObject.get_transform(lVar3,0);
        if (lVar3 == null) goto LAB_180c699e9;
        iVar2 = Transform.get_childCount(lVar3,0);
        if (iVar2 <= iVar8) {
          this.showPopInfo = _showPopInfo;
          this.treasureChestClickTime = _treasureChestClickTime;
          if (this.treasureChest == null) goto LAB_180c699e9;
          GameObject.SetActive(this.treasureChest,0 < _treasureChestClickTime,0);
          this.bigTreasure = 1 < this.treasureChestClickTime;
          if (this.treasureChestClickTime < 1) {
            var lVar3 = new WarpText_d__8(0,0);
            if (lVar3 == null) goto LAB_180c699e9;
            *(int64 *)(lVar3 + 32) = this;
            *(uint32 *)(lVar3 + 40) = 0x3e19999a;
            FUN_180d837c0(this,lVar3,0);
          }
          else {
            if ((this.treasureChest == null) ||
               (lVar3 = GameObject.get_transform(this.treasureChest,0)) == null)
            goto LAB_180c699e9;
            local_68 = 0xc1c8000000000000;
            local_60 = 0;
            Transform.set_localPosition(lVar3,&local_68,0);
            if ((this.treasureChest == null) ||
               ((lVar3 = GameObject.get_transform(this.treasureChest,0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"Icon",0)) == null))) goto LAB_180c699e9;
            lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
            if (!this.bigTreasure) {
              uVar4 = this.chestCloseSprite;
            }
            else {
              uVar4 = this.chestBigCloseSprite;
            }
            if (lVar3 == null) goto LAB_180c699e9;
            Image.set_sprite(lVar3,uVar4,0);
            if (((this.treasureChest == null) ||
                (lVar3 = GameObject.get_transform(this.treasureChest,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"Light",0)) == null) goto LAB_180c699e9;
            plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
            puVar5 = (uint64 *)FUN_181098a50(&local_38,0);
            if (plVar7 == (int64 *)0) goto LAB_180c699e9;
            local_38 = *puVar5;
            uStack_30 = puVar5[1];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.treasureChest == null) ||
                (lVar3 = GameObject.get_transform(this.treasureChest,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"Light",0)) == null) goto LAB_180c699e9;
            uVar4 = Component.GetComponent(lVar3,DAT_181d6bc40);
            uVar4 = DOTweenModuleUI.DOFade(uVar4,0x3f4ccccd,0x3f000000,0);
            TweenSettingsExtensions.SetLoops(uVar4,0xffffffff,1,DAT_181d97f50);
            if ((this.treasureChest == null) ||
               (lVar3 = GameObject.GetComponent(this.treasureChest,DAT_181d9ee60)) == null
               ) goto LAB_180c699e9;
            Selectable.set_interactable(lVar3,1,0);
          }
          return;
        }
        if ((this.speShowGrid == null) ||
           (lVar3 = GameObject.get_transform(this.speShowGrid,0)) == null)
        goto LAB_180c699e9;
        lVar3 = Transform.GetChild(lVar3,iVar8,0);
        puVar5 = (uint64 *)Vector3.get_zero(local_58,0);
        if (lVar3 == null) goto LAB_180c699e9;
        local_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        Transform.set_localScale(lVar3,&local_68,0);
        if (((this.speShowGrid == null) ||
            (lVar3 = GameObject.get_transform(this.speShowGrid,0)) == null) ||
           (lVar3 = Transform.GetChild(lVar3,iVar8,0)) == null) goto LAB_180c699e9;
        uVar6 = Component.get_gameObject(lVar3,0);
        uVar4 = this.itemBlackBack;
        local_48 = 0;
        uStack_40 = 0;
        local_38 = 0;
        uStack_30 = 0;
        lVar3 = GlobalData.AddImage(uVar6,0,uVar4,&local_38,&local_48,0);
        if ((lVar3 == null) ||
           (plVar7 = (int64 *)GameObject.GetComponent(lVar3,DAT_181d9fe50), plVar7 == (int64 *)0)
           ) goto LAB_180c699e9;
        (**(code **)(*plVar7 + 0x408))(plVar7,*(uint64 *)(*plVar7 + 0x410));
        plVar7 = (int64 *)GameObject.GetComponent(lVar3);
        if (plVar7 == (int64 *)0) goto LAB_180c699e9;
        (**(code **)(*plVar7 + 0x2c8))(plVar7);
        lVar3 = GameObject.get_transform(lVar3);
        if (lVar3 == null) goto LAB_180c699e9;
        Transform.SetAsFirstSibling(lVar3);
        lVar3 = this.speShowGrid;
        iVar8 = iVar8 + 1;
        if (lVar3 == null) goto LAB_180c699e9;
        goto LAB_180c69590;
    }

    // Token : 0x6002104
    // RVA   : 0xC6A750   Offset: 0xC68F50   Length: 0x48A
    public void TreasureChestButtonClicked()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar4;
        ulong local_18;
        uint local_10;
        this.treasureChestClickTime = this.treasureChestClickTime + -1;
        lVar4 = this.treasureChest;
        if (this.treasureChestClickTime < 1) {
          if ((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) {
            local_18 = 0xc0a0000000000000;
            local_10 = 0;
            Transform.set_localPosition(lVar4,&local_18,0);
            if ((this.treasureChest != null) &&
               ((lVar4 = GameObject.get_transform(this.treasureChest,0), lVar4 != null &&
                (lVar4 = Transform.Find(lVar4,"Icon",0)) != null))) {
              lVar4 = Component.GetComponent(lVar4,DAT_181d6bc40);
              if (!this.bigTreasure) {
                uVar1 = this.chestOpenSprite;
              }
              else {
                uVar1 = this.chestBigOpenSprite;
              }
              if (lVar4 != null) {
                Image.set_sprite(lVar4,uVar1,0);
                if (((this.treasureChest != null) &&
                    (lVar4 = GameObject.get_transform(this.treasureChest,0)) != null) &&
                   (lVar4 = Transform.Find(lVar4,"Light",0)) != null) {
                  uVar1 = Component.GetComponent(lVar4,DAT_181d6bc40);
                  DOTween.Kill(uVar1,0,0);
                  if (((this.treasureChest != null) &&
                      (lVar4 = GameObject.get_transform(this.treasureChest,0)) != null) &&
                     (lVar4 = Transform.Find(lVar4,"Light",0)) != null) {
                    uVar1 = Component.GetComponent(lVar4,DAT_181d6bc40);
                    DOTweenModuleUI.DOFade(uVar1,0,0x3e4ccccd,0);
                    if ((this.treasureChest != null) &&
                       (lVar4 = GameObject.GetComponent(this.treasureChest,DAT_181d9ee60),
                       lVar4 != null)) {
                      Selectable.set_interactable(lVar4,0,0);
                      if (this.treasureChest != null) {
                        uVar1 = GameObject.get_transform(this.treasureChest,0);
                        uVar1 = ShortcutExtensions.DOScale(uVar1,0x40000000,0x3e4ccccd,0);
                        TweenSettingsExtensions.SetLoops(uVar1,2,1,DAT_181d98060);
                        uVar1 = SpeShowController.ShowItemAnim(this,0x3dcccccd,0);
                        FUN_180d837c0(this,uVar1,0);
                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/BrokeWoodBox",0);
                        plVar6 = (int64 *)0;
                        plVar5 = plVar6;
                        if ((plVar3 != (int64 *)0) &&
                           (plVar5 = (int64 *)0, *plVar3 == DAT_181d8a228)) {
                          plVar5 = plVar3;
                        }
                        NGUITools.PlaySound(plVar5,0);
                        plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBox",0);
                        if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                          plVar6 = plVar3;
                        }
                        goto LAB_180c6a924;
                      }
                    }
                  }
                }
              }
            }
          }
        }
        else if (lVar4 != null) {
          uVar1 = GameObject.get_transform(lVar4,0);
          local_10 = 0x40a00000;
          local_18 = 0;
          uVar1 = ShortcutExtensions.DOShakeRotation(uVar1,0x3dcccccd,&local_18,10,0x42b40000,0,0);
          uVar1 = TweenSettingsExtensions.SetLoops(uVar1,3,1,DAT_181d980e0);
          uVar2 = new OnTooltipCB(this,DAT_181d83200,0);
          TweenSettingsExtensions.OnComplete(uVar1,uVar2,DAT_181d96ff8);
          plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/BrokeWoodBox",0);
          plVar6 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
            plVar6 = plVar3;
          }
        LAB_180c6a924:
          NGUITools.PlaySound(plVar6,0);
          return;
        }
    }

    // Token : 0x6002105
    // RVA   : 0xC6A240   Offset: 0xC68A40   Length: 0x7E
    public IEnumerator ShowItemAnim(float delayTime)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint32 *)(lVar1 + 40) = delayTime;
          return lVar1;
        }
    }

    // Token : 0x6002106
    // RVA   : 0xC69340   Offset: 0xC67B40   Length: 0x7E
    public IEnumerator PlayItemSound(GameObject targetItemIcon, float delayTime)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = targetItemIcon;
          *(uint32 *)(lVar1 + 32) = delayTime;
          return lVar1;
        }
    }

    // Token : 0x6002107
    // RVA   : 0xC6A2C0   Offset: 0xC68AC0   Length: 0xB6
    public IEnumerator ShowItemParticle(GameObject targetParticle, GameObject targetItemIcon, float delayTime)
    {
        int64 SpeShowController.ShowItemParticle
                         (uint64 this,uint64 targetParticle,uint64 targetItemIcon,uint32 delayTime)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint64 *)(lVar1 + 48) = targetParticle;
          *(uint64 *)(lVar1 + 56) = targetItemIcon;
          *(uint32 *)(lVar1 + 32) = delayTime;
          return lVar1;
        }
    }

    // Token : 0x6002108
    // RVA   : 0xC6A380   Offset: 0xC68B80   Length: 0x30D
    public void ShowSkillLevelUpParticle(GameObject targetObj, KungfuSkillLvData targetSkill)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        void SpeShowController.ShowSkillLevelUpParticle
                     (int64 this,uint64 targetObj,int64 targetSkill)
        {
        uint32 uVar1;
        int64 lVar2;
        uint64 uVar3;
        int64 lVar4;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uVar3 = this.showItemSpark;
        uVar3 = GlobalData.AddChild(targetObj,uVar3,0);
        lVar2 = *(int64 *)(pStatics + 32);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56), targetSkill != null)) {
          lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar4 != null) && (lVar2 != null)) {
            uVar1 = *(uint32 *)(lVar4 + 52);
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2[uVar1];
            if (lVar2 != null) {
              local_28 = *(uint32 *)(lVar2 + 24);
              uStack_24 = *(uint32 *)(lVar2 + 28);
              uStack_20 = *(uint32 *)(lVar2 + 32);
              uStack_1c = *(uint32 *)(lVar2 + 36);
              GlobalData.SetParticleColor(uVar3,&local_28,0);
              uVar3 = GlobalData.AddChild(targetObj,this.showItemImpact,0);
              lVar2 = *(int64 *)(pStatics + 32);
              if (lVar2 != null) {
                lVar2 = *(int64 *)(lVar2 + 56);
                lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
                if ((lVar4 != null) && (lVar2 != null)) {
                  uVar1 = *(uint32 *)(lVar4 + 52);
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    local_28 = *(uint32 *)(lVar2 + 24);
                    uStack_24 = *(uint32 *)(lVar2 + 28);
                    uStack_20 = *(uint32 *)(lVar2 + 32);
                    uStack_1c = *(uint32 *)(lVar2 + 36);
                    GlobalData.SetParticleColor(uVar3,&local_28,0);
                    uVar3 = GlobalData.AddChild(targetObj,this.showItemFlash,0);
                    lVar2 = *(int64 *)(pStatics + 32);
                    if (lVar2 != null) {
                      lVar2 = *(int64 *)(lVar2 + 56);
                      lVar4 = KungfuSkillLvData.DataBase(targetSkill,0);
                      if ((lVar4 != null) && (lVar2 != null)) {
                        uVar1 = *(uint32 *)(lVar4 + 52);
                        if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar2 = *(int64 *)
                                 (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8);
                        if (lVar2 != null) {
                          local_28 = *(uint32 *)(lVar2 + 24);
                          uStack_24 = *(uint32 *)(lVar2 + 28);
                          uStack_20 = *(uint32 *)(lVar2 + 32);
                          uStack_1c = *(uint32 *)(lVar2 + 36);
                          GlobalData.SetParticleColor(uVar3,&local_28,0);
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

    // Token : 0x6002109
    // RVA   : 0xC6A1E0   Offset: 0xC689E0   Length: 0x25
    public void ShowGetSkill(KungfuSkillLvData _targetSkill)
    {
        SpeShowController.ShowGetSkillExp(this,_targetSkill,0xbf800000,0,param_3,0);
    }

    // Token : 0x600210A
    // RVA   : 0xC6A210   Offset: 0xC68A10   Length: 0x27
    public void ShowGetSkill(KungfuSkillLvData _targetSkill, string showText)
    {
        SpeShowController.ShowGetSkillExp(this,_targetSkill,0xbf800000,0,showText,0);
    }

    // Token : 0x600210B
    // RVA   : 0xC69AA0   Offset: 0xC682A0   Length: 0x1A
    public void ShowGetSkillExp(KungfuSkillLvData _targetSkill, float _totalExp, int _expType)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        void SpeShowController.ShowGetSkillExp
                     (int64 this,int64 _targetSkill,float _totalExp,int _expType,int64 param_5)
        {
        bool bVar1;
        int64 lVar2;
        uint64 uVar3;
        uint64 uVar4;
        int64 *plVar5;
        int64 lVar6;
        int64 *plVar7;
        float fVar8;
        float local_res8 [2];
        float local_res18 [4];
        local_res18[0] = _totalExp;
        bVar1 = 0.0 <= local_res18[0];
        local_res18[0] = (float)Mathf.Max(0,local_res18[0],0);
        this.treasureChestClickTime = 0xffffffff;
        if (this.treasureChest != null) {
          GameObject.SetActive(this.treasureChest,0,0);
          SpeShowController.ShowSpeShowUIPanel(this,0);
          fVar8 = (float)Mathf.Min((*(float **)(DAT_181d7deb0 + 184))[1],
                                    local_res18[0] / **(float **)(DAT_181d7deb0 + 184),0);
          uVar3 = this.skillList;
          this.leftShowTime = fVar8 + 0.5;
          if (*pStatics != 0) {
            uVar4 = *(uint64 *)(*pStatics + 184);
            lVar2 = GlobalData.AddChild(uVar3,uVar4,0);
            this.newObj = lVar2;
            if ((*plVar5 != 0) && (lVar2 = GameObject.GetComponent(*plVar5,DAT_181da1530)) != null) {
              *(int64 *)(lVar2 + 24) = _targetSkill;
              if ((*plVar5 != 0) && (lVar2 = GameObject.GetComponent(*plVar5,DAT_181da1530)) != null)
              {
                *(float *)(lVar2 + 40) = local_res18[0];
                if ((*plVar5 != 0) &&
                   (lVar2 = GameObject.GetComponent(*plVar5,DAT_181da1530)) != null) {
                  *(int *)(lVar2 + 36) = _expType;
                  lVar2 = this.speShowUIRoot;
                  if (param_5 == 0) {
                    if (bVar1) {
                      if (((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                         (lVar2 = Transform.Find(lVar2,"Title",0)) != null) {
                        uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                        plVar5 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                        if ((_targetSkill != null) &&
                           (lVar2 = KungfuSkillLvData.Name(_targetSkill,0,0), plVar5 != (int64 *)0)) {
                          if ((lVar2 != null) &&
                             (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                             lVar6 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          if ((int)plVar5[3] == 0) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar5[4] = lVar2;
                          il2cpp_internal(plVar5 + 4,lVar2);
                          uVar4 = "{0}增加{1}经验 {2} ({3}%)";
                          lVar2 = "理论";
                          if (_expType != null) {
                            lVar2 = "实战";
                          }
                          if ((lVar2 != null) &&
                             (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                             lVar6 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          if (*(uint32 *)(plVar5 + 3) < 2) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar5[5] = lVar2;
                          il2cpp_internal(plVar5 + 5,lVar2);
                          lVar2 = Single.ToString(local_res18,"f0",0);
                          if ((lVar2 != null) &&
                             (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                             lVar6 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          if (*(uint32 *)(plVar5 + 3) < 3) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar5[6] = lVar2;
                          il2cpp_internal(plVar5 + 6,lVar2);
                          if (_expType == null) {
                            lVar2 = FUN_18046c0a0(0);
                            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
                              fVar8 = (float)HeroData.GetBookExpRate(lVar2,_targetSkill,0);
        LAB_180c6a014:
                              local_res8[0] = (fVar8 - 1.0) * 100.0;
                              lVar2 = Single.ToString(local_res8,"+0;-0;0",0);
                              if ((lVar2 != null) &&
                                 (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                                 lVar6 == null)) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar3,0);
                              }
                              if (3 < *(uint32 *)(plVar5 + 3)) {
                                plVar5[7] = lVar2;
                                il2cpp_internal(plVar5 + 7,lVar2);
                                uVar4 = String.Format(uVar4,plVar5,0);
                                LTLocalization.SetText(uVar3,uVar4,0);
                                return;
                              }
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar3,0);
                            }
                          }
                          else {
                            lVar2 = FUN_18046c0a0(0);
                            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
                              fVar8 = (float)HeroData.GetFightExpRate(lVar2,_targetSkill,0);
                              goto LAB_180c6a014;
                            }
                          }
                        }
                      }
                    }
                    else if ((((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null)
                             && (lVar2 = Transform.Find(lVar2,"Title",0)) != null) &&
                            (uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0), _targetSkill != null)) {
                      uVar4 = KungfuSkillLvData.Name(_targetSkill,0,0);
                      uVar4 = String.Format("习得新武功 {0}",uVar4,0);
                      LTLocalization.SetText(uVar3,uVar4,0);
                      SpeShowController.ShowSkillLevelUpParticle(this,*plVar5,_targetSkill,0);
                      return;
                    }
                  }
                  else if (((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                          (lVar2 = Transform.Find(lVar2,"Title",0)) != null) {
                    uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                    LTLocalization.SetText(uVar3,param_5,0);
                    SpeShowController.ShowSkillLevelUpParticle(this,*plVar5,_targetSkill,0);
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/LegendDrop",0);
                    plVar7 = (int64 *)0;
                    if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                      plVar7 = plVar5;
                    }
                    NGUITools.PlaySound(plVar7,0x3f4ccccd,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600210C
    // RVA   : 0xC69AC0   Offset: 0xC682C0   Length: 0x718
    public void ShowGetSkillExp(KungfuSkillLvData _targetSkill, float _totalExp, int _expType, string showText)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        void SpeShowController.ShowGetSkillExp
                     (int64 this,int64 _targetSkill,float _totalExp,int _expType,int64 showText)
        {
        bool bVar1;
        int64 lVar2;
        uint64 uVar3;
        uint64 uVar4;
        int64 *plVar5;
        int64 lVar6;
        int64 *plVar7;
        float fVar8;
        float local_res8 [2];
        float local_res18 [4];
        local_res18[0] = _totalExp;
        bVar1 = 0.0 <= local_res18[0];
        local_res18[0] = (float)Mathf.Max(0,local_res18[0],0);
        this.treasureChestClickTime = 0xffffffff;
        if (this.treasureChest != null) {
          GameObject.SetActive(this.treasureChest,0,0);
          SpeShowController.ShowSpeShowUIPanel(this,0);
          fVar8 = (float)Mathf.Min((*(float **)(DAT_181d7deb0 + 184))[1],
                                    local_res18[0] / **(float **)(DAT_181d7deb0 + 184),0);
          uVar3 = this.skillList;
          this.leftShowTime = fVar8 + 0.5;
          if (*pStatics != 0) {
            uVar4 = *(uint64 *)(*pStatics + 184);
            lVar2 = GlobalData.AddChild(uVar3,uVar4,0);
            this.newObj = lVar2;
            if ((*plVar5 != 0) && (lVar2 = GameObject.GetComponent(*plVar5,DAT_181da1530)) != null) {
              *(int64 *)(lVar2 + 24) = _targetSkill;
              if ((*plVar5 != 0) && (lVar2 = GameObject.GetComponent(*plVar5,DAT_181da1530)) != null)
              {
                *(float *)(lVar2 + 40) = local_res18[0];
                if ((*plVar5 != 0) &&
                   (lVar2 = GameObject.GetComponent(*plVar5,DAT_181da1530)) != null) {
                  *(int *)(lVar2 + 36) = _expType;
                  lVar2 = this.speShowUIRoot;
                  if (showText == null) {
                    if (bVar1) {
                      if (((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                         (lVar2 = Transform.Find(lVar2,"Title",0)) != null) {
                        uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                        plVar5 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                        if ((_targetSkill != null) &&
                           (lVar2 = KungfuSkillLvData.Name(_targetSkill,0,0), plVar5 != (int64 *)0)) {
                          if ((lVar2 != null) &&
                             (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                             lVar6 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          if ((int)plVar5[3] == 0) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar5[4] = lVar2;
                          il2cpp_internal(plVar5 + 4,lVar2);
                          uVar4 = "{0}增加{1}经验 {2} ({3}%)";
                          lVar2 = "理论";
                          if (_expType != null) {
                            lVar2 = "实战";
                          }
                          if ((lVar2 != null) &&
                             (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                             lVar6 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          if (*(uint32 *)(plVar5 + 3) < 2) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar5[5] = lVar2;
                          il2cpp_internal(plVar5 + 5,lVar2);
                          lVar2 = Single.ToString(local_res18,"f0",0);
                          if ((lVar2 != null) &&
                             (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                             lVar6 == null)) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          if (*(uint32 *)(plVar5 + 3) < 3) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          plVar5[6] = lVar2;
                          il2cpp_internal(plVar5 + 6,lVar2);
                          if (_expType == null) {
                            lVar2 = FUN_18046c0a0(0);
                            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
                              fVar8 = (float)HeroData.GetBookExpRate(lVar2,_targetSkill,0);
        LAB_180c6a014:
                              local_res8[0] = (fVar8 - 1.0) * 100.0;
                              lVar2 = Single.ToString(local_res8,"+0;-0;0",0);
                              if ((lVar2 != null) &&
                                 (lVar6 = il2cpp_internal(lVar2,*(uint64 *)(*plVar5 + 64)),
                                 lVar6 == null)) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar3,0);
                              }
                              if (3 < *(uint32 *)(plVar5 + 3)) {
                                plVar5[7] = lVar2;
                                il2cpp_internal(plVar5 + 7,lVar2);
                                uVar4 = String.Format(uVar4,plVar5,0);
                                LTLocalization.SetText(uVar3,uVar4,0);
                                return;
                              }
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar3,0);
                            }
                          }
                          else {
                            lVar2 = FUN_18046c0a0(0);
                            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
                               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
                              fVar8 = (float)HeroData.GetFightExpRate(lVar2,_targetSkill,0);
                              goto LAB_180c6a014;
                            }
                          }
                        }
                      }
                    }
                    else if ((((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null)
                             && (lVar2 = Transform.Find(lVar2,"Title",0)) != null) &&
                            (uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0), _targetSkill != null)) {
                      uVar4 = KungfuSkillLvData.Name(_targetSkill,0,0);
                      uVar4 = String.Format("习得新武功 {0}",uVar4,0);
                      LTLocalization.SetText(uVar3,uVar4,0);
                      SpeShowController.ShowSkillLevelUpParticle(this,*plVar5,_targetSkill,0);
                      return;
                    }
                  }
                  else if (((lVar2 != null) && (lVar2 = GameObject.get_transform(lVar2,0)) != null) &&
                          (lVar2 = Transform.Find(lVar2,"Title",0)) != null) {
                    uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                    LTLocalization.SetText(uVar3,showText,0);
                    SpeShowController.ShowSkillLevelUpParticle(this,*plVar5,_targetSkill,0);
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/LegendDrop",0);
                    plVar7 = (int64 *)0;
                    if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                      plVar7 = plVar5;
                    }
                    NGUITools.PlaySound(plVar7,0x3f4ccccd,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600210D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600210E
    // RVA   : 0xC6AC80   Offset: 0xC69480   Length: 0x3A
    private static void /*cctor*/()
    {
        *(uint32 *)(*(int64 *)(DAT_181d7f230 + 184) + 8) = 0x3f19999a;
    }

    // Token : 0x600210F
    // RVA   : 0xC6ABE0   Offset: 0xC693E0   Length: 0x56
    private void <TreasureChestButtonClicked>b__30_0()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.treasureChest != null) {
          lVar1 = GameObject.get_transform(this.treasureChest,0);
          puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
          if (lVar1 != null) {
            local_20 = *(uint32 *)(puVar2 + 1);
            local_28 = *puVar2;
            Transform.set_localEulerAngles(lVar1,&local_28,0);
            return;
          }
        }
    }

}
