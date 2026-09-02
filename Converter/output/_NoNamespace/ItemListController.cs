// ============================================================
// Type  : ItemListController
// Token : 0x20002EC
// ============================================================

public class ItemListController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400178B
    public GameObject itemGrid;

    // Token: 0x400178C
    public ItemListInteractType itemListInteractType;

    // Token: 0x400178D
    public ItemListType forceItemListType;

    // Token: 0x400178E
    public ItemListType nowItemListType;

    // Token: 0x400178F
    public ItemListData targetItemList;

    // Token: 0x4001790
    public GameObject showAllButton;

    // Token: 0x4001791
    public bool noEquipedItem;

    // Token: 0x4001792
    public bool recordSortType;

    // Token: 0x4001793
    private GameObject temp;

    // Token: 0x4001794
    public Dropdown sortTypeDropDown;

    // Token: 0x4001795
    public ItemSortType itemSortType;

    // Token: 0x4001796
    public bool reverseOrder;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600183F
    // RVA   : 0xB7B1E0   Offset: 0xB799E0   Length: 0x12F
    public void ChangeListType(GameObject ButtonClicked)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if ((ButtonClicked != null) && (lVar4 = GameObject.GetComponent(ButtonClicked,DAT_181da2130)) != null) {
          if (*(char *)(lVar4 + 0x118) != false) {
            iVar1 = this.nowItemListType;
            uVar5 = Object.get_name(ButtonClicked,0);
            iVar2 = Int32.Parse(uVar5,0);
            if (iVar1 != iVar2) {
              uVar5 = Object.get_name(ButtonClicked,0);
              uVar3 = Int32.Parse(uVar5,0);
              this.nowItemListType = uVar3;
              ItemListController.RefreshItemList
                        (this,this.targetItemList,this.itemListInteractType,1,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
            }
          }
          return;
        }
    }

    // Token : 0x6001840
    // RVA   : 0xB7CD60   Offset: 0xB7B560   Length: 0x84
    public void ResetListType()
    {
        long lVar1;
        this.nowItemListType = 7;
        if (this.showAllButton != null) {
          lVar1 = GameObject.GetComponent(this.showAllButton,DAT_181da2130);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            if (this.showAllButton != null) {
              lVar1 = GameObject.GetComponent(this.showAllButton,DAT_181da2130);
              if (lVar1 != null) {
                Toggle.set_isOn(lVar1,1,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001841
    // RVA   : 0xB7B6B0   Offset: 0xB79EB0   Length: 0x56
    public void ClearAllItem()
    {
        ulong uVar1;
        uVar1 = this.itemGrid;
        GlobalData.DeleteAllChild(uVar1,0);
    }

    // Token : 0x6001842
    // RVA   : 0xB7B7F0   Offset: 0xB79FF0   Length: 0x23
    public void RefreshItemList(bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,int64 resetPos,uint32 param_3,char param_4)
        {
        uint32 uVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 lVar9;
        int64 *plVar10;
        uint32 *puVar11;
        int *piVar12;
        int64 *plVar13;
        int iVar14;
        int *piVar15;
        uint32 local_res18 [2];
        char local_res20;
        local_res20 = param_4;
        this.itemListInteractType = param_3;
        uVar6 = this.showAllButton;
        local_res18[0] = 0;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (!cVar2) {
        LAB_180b7bc4f:
          uVar1 = this.nowItemListType;
          if (resetPos != null) {
            if (uVar1 == 7) {
              lVar5 = *(int64 *)(resetPos + 40);
            }
            else {
              lVar5 = *(int64 *)(resetPos + 48);
              if (lVar5 == null) goto LAB_180b7cd1d;
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar1];
            }
            if (this.targetItemList == resetPos) {
              if ((this.itemGrid != null) &&
                 (lVar8 = GameObject.get_transform(this.itemGrid,0)) != null) {
                iVar14 = Transform.get_childCount(lVar8,0);
        joined_r0x000180b7bcbf:
                do {
                  iVar14 = iVar14 + -1;
                  if (iVar14 < 0) goto LAB_180b7c085;
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                  uVar6 = Component.GetComponent(lVar8);
                  cVar2 = Object.op_Inequality(uVar6);
                  if (cVar2) {
                    if (this.targetItemList == null) break;
                    lVar8 = this.targetItemList.allItem;
                    if (((this.itemGrid == null) ||
                        (lVar9 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar9 = Transform.GetChild(lVar9,iVar14,0), lVar9 == null ||
                           ((lVar9 = Component.GetComponent(lVar9,DAT_181d6bdc0), lVar9 == null ||
                            (lVar8 == null)))))) break;
                    cVar2 = FUN_1818279a0(lVar8,*(uint64 *)(lVar9 + 32));
                    if (cVar2) {
                      if (this.noEquipedItem) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        cVar2 = ItemData.Equiped(*(int64 *)(lVar8 + 32),0);
                        if (cVar2) goto LAB_180b7bfc1;
                      }
                      plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,(uint32 *)(this + 32))
                      ;
                      if (plVar10 == (int64 *)0) break;
                      lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                      puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                      this.itemListInteractType = *puVar11;
                      if (lVar8 == null) break;
                      cVar2 = String.Contains(lVar8);
                      if (!cVar2) goto joined_r0x000180b7bcbf;
                      if (((this.itemGrid == null) ||
                          (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null
                          ) || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                                ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                                 (*(int64 *)(lVar8 + 32) == 0)))))) break;
                      iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                      lVar8 = FUN_18046c700(0);
                      if (lVar8 == null) break;
                      if (*(int *)(lVar8 + 168) <= iVar3) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                        lVar8 = FUN_18046c700(0);
                        if (lVar8 == null) break;
                        if (iVar3 <= *(int *)(lVar8 + 172)) goto joined_r0x000180b7bcbf;
                      }
                    }
        LAB_180b7bfc1:
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                           (lVar8 = Component.get_gameObject(lVar8,0)) == null))) break;
                    GameObject.SetActive(lVar8,0);
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                    uVar6 = Component.get_gameObject(lVar8);
                    Object.Destroy(uVar6);
                  }
                } while( true );
              }
            }
            else {
              this.targetItemList = resetPos;
              uVar6 = this.itemGrid;
              GlobalData.DeleteAllChild(uVar6,0);
              iVar14 = 0;
              if (lVar5 != null) {
        LAB_180b7c6b0:
                piVar15 = &this.itemListInteractType;
                if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
                if (!this.noEquipedItem) {
        LAB_180b7c6ec:
                  plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                  if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                  lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                  piVar12 = (int *)il2cpp_object_unbox(plVar10);
                  *piVar15 = *piVar12;
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = String.Contains(lVar8,"Trade",0);
                  if (!cVar2) {
        LAB_180b7c7fc:
                    uVar6 = this.itemGrid;
                    lVar8 = FUN_18046c1a0(0);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    uVar7 = *(uint64 *)(lVar8 + 160);
                    uVar6 = GlobalData.AddChild(uVar6,uVar7,0);
                    this.temp = uVar6;
                    if (this.temp == null) goto LAB_180b7cd1d;
                    lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                    uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    *(uint64 *)(lVar8 + 32) = uVar6;
                    if ((this.temp == null) ||
                       (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070),
                       lVar8 == null)) goto LAB_180b7cd1d;
                    *(int *)(lVar8 + 24) = iVar14;
                    plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                    if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                    lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                    piVar12 = (int *)il2cpp_object_unbox(plVar10);
                    *piVar15 = *piVar12;
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    cVar2 = String.Contains(lVar8,"Trade",0);
                    lVar8 = this.temp;
                    if (cVar2) {
                      if ((lVar8 != null) &&
                         (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) != null) {
                        *(uint32 *)(lVar8 + 40) = 2;
                        if (this.temp != null) {
                          lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                          uVar6 = DAT_181d9ec88;
                          uVar6 = Type.GetTypeFromHandle(uVar6,0);
                          plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                          if (plVar10 != (int64 *)0) {
                            uVar7 = (**(code **)(*plVar10 + 0x168))
                                              (plVar10,*(uint64 *)(*plVar10 + 0x170));
                            puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                            this.itemListInteractType = *puVar11;
                            plVar10 = (int64 *)Enum.Parse(uVar6,uVar7,0);
                            if ((lVar8 != null) && (plVar10 != (int64 *)0)) {
                              if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6070(plVar10,DAT_181d880d8);
                              }
                              puVar11 = (uint32 *)il2cpp_object_unbox();
                              *(uint32 *)(lVar8 + 44) = *puVar11;
                              goto LAB_180b7ca6a;
                            }
                          }
                        }
                      }
                      goto LAB_180b7cd1d;
                    }
                    if ((lVar8 == null) ||
                       (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
                    goto LAB_180b7cd1d;
                    iVar14 = iVar14 + 1;
                    *(uint32 *)(lVar8 + 40) = (uint32)(*piVar15 != 0);
                    goto LAB_180b7c6b0;
                  }
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7ca6a;
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c7fc;
                }
                else {
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = ItemData.Equiped(lVar8,0);
                  if (!cVar2) goto LAB_180b7c6ec;
                }
        LAB_180b7ca6a:
                iVar14 = iVar14 + 1;
                goto LAB_180b7c6b0;
              }
            }
          }
        }
        else {
          iVar14 = 0;
          lVar5 = this.showAllButton;
          if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                    (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
          else {
            this.nowItemListType = this.forceItemListType;
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar14)) == null) break;
                uVar6 = Object.get_name(lVar5,0);
                local_res18[0] = this.forceItemListType;
                uVar7 = Int32.ToString(local_res18,0);
                cVar2 = FUN_1816fd990(uVar6,uVar7);
                lVar5 = this.showAllButton;
                if (!cVar2) {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5);
                }
                else {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      ((lVar5 = Transform.GetChild(lVar5,iVar14), lVar5 == null ||
                       (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))))) break;
                  Toggle.set_isOn(lVar5,1);
                  if ((this.showAllButton == null) ||
                     (((lVar5 = GameObject.get_transform(this.showAllButton,0), lVar5 == null ||
                       (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5,DAT_181d6da40);
                }
                if (lVar5 == null) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
        }
        LAB_180b7cd1d:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b7c085:
        iVar14 = 0;
        if (lVar5 != null) {
        LAB_180b7c093:
          piVar15 = &this.itemListInteractType;
          param_4 = local_res20;
          if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
          if (!this.noEquipedItem) {
        LAB_180b7c0d0:
            plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
            if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
            lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
            piVar12 = (int *)il2cpp_object_unbox(plVar10);
            this.itemListInteractType = *piVar12;
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = String.Contains(lVar8,"Trade",0);
            if (!cVar2) {
        LAB_180b7c1e2:
              iVar3 = 0;
              do {
                if ((this.itemGrid == null) ||
                   (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                goto LAB_180b7cd1d;
                iVar4 = Transform.get_childCount(lVar8,0);
                lVar8 = this.itemGrid;
                if (iVar4 <= iVar3) {
                  lVar9 = FUN_18046c1a0(0);
                  if (lVar9 == null) goto LAB_180b7cd1d;
                  uVar6 = *(uint64 *)(lVar9 + 160);
                  lVar8 = GlobalData.AddChild(lVar8,uVar6,0);
                  this.temp = lVar8;
                  if (*plVar10 == 0) goto LAB_180b7cd1d;
                  lVar8 = GameObject.GetComponent(*plVar10,DAT_181da0070);
                  uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  *(uint64 *)(lVar8 + 32) = uVar6;
                  goto LAB_180b7c440;
                }
                if (((lVar8 == null) || (lVar8 = GameObject.get_transform(lVar8,0)) == null) ||
                   (lVar8 = Transform.GetChild(lVar8,iVar3)) == null) goto LAB_180b7cd1d;
                uVar6 = Component.GetComponent(lVar8);
                cVar2 = Object.op_Inequality(uVar6);
                if (cVar2) {
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
                      (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null)))
                  goto LAB_180b7cd1d;
                  lVar8 = *(int64 *)(lVar8 + 32);
                  lVar9 = FUN_180002f80(lVar5);
                  if (lVar8 == lVar9) goto LAB_180b7c303;
                }
                iVar3 = iVar3 + 1;
              } while( true );
            }
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7c637;
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c1e2;
          }
          else {
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = ItemData.Equiped(lVar8);
            if (!cVar2) goto LAB_180b7c0d0;
          }
          goto LAB_180b7c637;
        }
        goto LAB_180b7cd1d;
        LAB_180b7ca79:
        if ((this.itemGrid != null) &&
           (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) {
          iVar14 = Transform.get_childCount(lVar5,0);
        joined_r0x000180b7caa5:
          while (iVar14 = iVar14 + -1, -1 < iVar14) {
            if (this.nowItemListType == 7) {
        LAB_180b7cbc3:
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto code_r0x000180b7cc09;
              goto LAB_180b7cd1d;
            }
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
               ((lVar5 = Component.GetComponent(lVar5,DAT_181d6bdc0), lVar5 == null ||
                (*(int64 *)(lVar5 + 32) == 0)))) goto LAB_180b7cd1d;
            if (*(int *)(*(int64 *)(lVar5 + 32) + 20) == this.nowItemListType)
            goto LAB_180b7cbc3;
            if (((this.itemGrid == null) ||
                (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
               ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                (lVar5 = Component.get_gameObject(lVar5)) == null))) goto LAB_180b7cd1d;
            cVar2 = GameObject.get_activeSelf(lVar5);
            if (cVar2) {
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto LAB_180b7cc5f;
              goto LAB_180b7cd1d;
            }
          }
          ItemListController.ResetSortType(this,0);
          if (param_4) {
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
               (((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d6c940)) == null) ||
                (*(int64 *)(lVar5 + 72) == 0)))) goto LAB_180b7cd1d;
            Scrollbar.set_value(*(int64 *)(lVar5 + 72),0x3f800000,0);
          }
          return;
        }
        goto LAB_180b7cd1d;
        code_r0x000180b7cc09:
        cVar2 = GameObject.get_activeSelf(lVar5);
        if (!cVar2) {
          if ((((this.itemGrid == null) ||
               (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
              (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
             (lVar5 = Component.get_gameObject(lVar5,0)) == null) goto LAB_180b7cd1d;
        LAB_180b7cc5f:
          GameObject.SetActive(lVar5);
        }
        goto joined_r0x000180b7caa5;
        LAB_180b7c303:
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           (lVar8 = Transform.GetChild(lVar8,iVar3,0)) == null) goto LAB_180b7cd1d;
        uVar6 = Component.get_gameObject(lVar8,0);
        this.temp = uVar6;
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
            (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null))) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 52) = 0;
        LAB_180b7c440:
        plVar10 = &this.temp;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(int *)(lVar8 + 24) = iVar14;
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        lVar8 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        piVar12 = (int *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *piVar12;
        if (lVar8 == null) goto LAB_180b7cd1d;
        cVar2 = String.Contains(lVar8,"Trade");
        lVar8 = this.temp;
        if (!cVar2) {
          if ((lVar8 == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
          iVar14 = iVar14 + 1;
          *(uint32 *)(lVar8 + 40) = (uint32)(this.itemListInteractType != null);
          goto LAB_180b7c093;
        }
        if ((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(uint32 *)(lVar8 + 40) = 2;
        if (this.temp == null) goto LAB_180b7cd1d;
        lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
        uVar6 = DAT_181d9ec88;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        uVar7 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        puVar11 = (uint32 *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *puVar11;
        plVar13 = (int64 *)Enum.Parse(uVar6,uVar7,0);
        if ((lVar8 == null) || (plVar13 == (int64 *)0)) goto LAB_180b7cd1d;
        if (*(int64 *)(*plVar13 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar13,DAT_181d880d8);
        }
        puVar11 = (uint32 *)il2cpp_object_unbox();
        *(uint32 *)(lVar8 + 44) = *puVar11;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 55) = 1;
        LAB_180b7c637:
        iVar14 = iVar14 + 1;
        goto LAB_180b7c093;
    }

    // Token : 0x6001843
    // RVA   : 0xB7CD40   Offset: 0xB7B540   Length: 0x1F
    public void RefreshItemList(ItemListData _targetItemList, bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,int64 _targetItemList,uint32 resetPos,char param_4)
        {
        uint32 uVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 lVar9;
        int64 *plVar10;
        uint32 *puVar11;
        int *piVar12;
        int64 *plVar13;
        int iVar14;
        int *piVar15;
        uint32 local_res18 [2];
        char local_res20;
        local_res20 = param_4;
        this.itemListInteractType = resetPos;
        uVar6 = this.showAllButton;
        local_res18[0] = 0;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (!cVar2) {
        LAB_180b7bc4f:
          uVar1 = this.nowItemListType;
          if (_targetItemList != null) {
            if (uVar1 == 7) {
              lVar5 = *(int64 *)(_targetItemList + 40);
            }
            else {
              lVar5 = *(int64 *)(_targetItemList + 48);
              if (lVar5 == null) goto LAB_180b7cd1d;
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar1];
            }
            if (this.targetItemList == _targetItemList) {
              if ((this.itemGrid != null) &&
                 (lVar8 = GameObject.get_transform(this.itemGrid,0)) != null) {
                iVar14 = Transform.get_childCount(lVar8,0);
        joined_r0x000180b7bcbf:
                do {
                  iVar14 = iVar14 + -1;
                  if (iVar14 < 0) goto LAB_180b7c085;
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                  uVar6 = Component.GetComponent(lVar8);
                  cVar2 = Object.op_Inequality(uVar6);
                  if (cVar2) {
                    if (this.targetItemList == null) break;
                    lVar8 = this.targetItemList.allItem;
                    if (((this.itemGrid == null) ||
                        (lVar9 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar9 = Transform.GetChild(lVar9,iVar14,0), lVar9 == null ||
                           ((lVar9 = Component.GetComponent(lVar9,DAT_181d6bdc0), lVar9 == null ||
                            (lVar8 == null)))))) break;
                    cVar2 = FUN_1818279a0(lVar8,*(uint64 *)(lVar9 + 32));
                    if (cVar2) {
                      if (this.noEquipedItem) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        cVar2 = ItemData.Equiped(*(int64 *)(lVar8 + 32),0);
                        if (cVar2) goto LAB_180b7bfc1;
                      }
                      plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,(uint32 *)(this + 32))
                      ;
                      if (plVar10 == (int64 *)0) break;
                      lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                      puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                      this.itemListInteractType = *puVar11;
                      if (lVar8 == null) break;
                      cVar2 = String.Contains(lVar8);
                      if (!cVar2) goto joined_r0x000180b7bcbf;
                      if (((this.itemGrid == null) ||
                          (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null
                          ) || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                                ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                                 (*(int64 *)(lVar8 + 32) == 0)))))) break;
                      iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                      lVar8 = FUN_18046c700(0);
                      if (lVar8 == null) break;
                      if (*(int *)(lVar8 + 168) <= iVar3) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                        lVar8 = FUN_18046c700(0);
                        if (lVar8 == null) break;
                        if (iVar3 <= *(int *)(lVar8 + 172)) goto joined_r0x000180b7bcbf;
                      }
                    }
        LAB_180b7bfc1:
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                           (lVar8 = Component.get_gameObject(lVar8,0)) == null))) break;
                    GameObject.SetActive(lVar8,0);
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                    uVar6 = Component.get_gameObject(lVar8);
                    Object.Destroy(uVar6);
                  }
                } while( true );
              }
            }
            else {
              this.targetItemList = _targetItemList;
              uVar6 = this.itemGrid;
              GlobalData.DeleteAllChild(uVar6,0);
              iVar14 = 0;
              if (lVar5 != null) {
        LAB_180b7c6b0:
                piVar15 = &this.itemListInteractType;
                if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
                if (!this.noEquipedItem) {
        LAB_180b7c6ec:
                  plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                  if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                  lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                  piVar12 = (int *)il2cpp_object_unbox(plVar10);
                  *piVar15 = *piVar12;
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = String.Contains(lVar8,"Trade",0);
                  if (!cVar2) {
        LAB_180b7c7fc:
                    uVar6 = this.itemGrid;
                    lVar8 = FUN_18046c1a0(0);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    uVar7 = *(uint64 *)(lVar8 + 160);
                    uVar6 = GlobalData.AddChild(uVar6,uVar7,0);
                    this.temp = uVar6;
                    if (this.temp == null) goto LAB_180b7cd1d;
                    lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                    uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    *(uint64 *)(lVar8 + 32) = uVar6;
                    if ((this.temp == null) ||
                       (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070),
                       lVar8 == null)) goto LAB_180b7cd1d;
                    *(int *)(lVar8 + 24) = iVar14;
                    plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                    if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                    lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                    piVar12 = (int *)il2cpp_object_unbox(plVar10);
                    *piVar15 = *piVar12;
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    cVar2 = String.Contains(lVar8,"Trade",0);
                    lVar8 = this.temp;
                    if (cVar2) {
                      if ((lVar8 != null) &&
                         (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) != null) {
                        *(uint32 *)(lVar8 + 40) = 2;
                        if (this.temp != null) {
                          lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                          uVar6 = DAT_181d9ec88;
                          uVar6 = Type.GetTypeFromHandle(uVar6,0);
                          plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                          if (plVar10 != (int64 *)0) {
                            uVar7 = (**(code **)(*plVar10 + 0x168))
                                              (plVar10,*(uint64 *)(*plVar10 + 0x170));
                            puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                            this.itemListInteractType = *puVar11;
                            plVar10 = (int64 *)Enum.Parse(uVar6,uVar7,0);
                            if ((lVar8 != null) && (plVar10 != (int64 *)0)) {
                              if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6070(plVar10,DAT_181d880d8);
                              }
                              puVar11 = (uint32 *)il2cpp_object_unbox();
                              *(uint32 *)(lVar8 + 44) = *puVar11;
                              goto LAB_180b7ca6a;
                            }
                          }
                        }
                      }
                      goto LAB_180b7cd1d;
                    }
                    if ((lVar8 == null) ||
                       (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
                    goto LAB_180b7cd1d;
                    iVar14 = iVar14 + 1;
                    *(uint32 *)(lVar8 + 40) = (uint32)(*piVar15 != 0);
                    goto LAB_180b7c6b0;
                  }
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7ca6a;
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c7fc;
                }
                else {
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = ItemData.Equiped(lVar8,0);
                  if (!cVar2) goto LAB_180b7c6ec;
                }
        LAB_180b7ca6a:
                iVar14 = iVar14 + 1;
                goto LAB_180b7c6b0;
              }
            }
          }
        }
        else {
          iVar14 = 0;
          lVar5 = this.showAllButton;
          if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                    (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
          else {
            this.nowItemListType = this.forceItemListType;
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar14)) == null) break;
                uVar6 = Object.get_name(lVar5,0);
                local_res18[0] = this.forceItemListType;
                uVar7 = Int32.ToString(local_res18,0);
                cVar2 = FUN_1816fd990(uVar6,uVar7);
                lVar5 = this.showAllButton;
                if (!cVar2) {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5);
                }
                else {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      ((lVar5 = Transform.GetChild(lVar5,iVar14), lVar5 == null ||
                       (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))))) break;
                  Toggle.set_isOn(lVar5,1);
                  if ((this.showAllButton == null) ||
                     (((lVar5 = GameObject.get_transform(this.showAllButton,0), lVar5 == null ||
                       (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5,DAT_181d6da40);
                }
                if (lVar5 == null) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
        }
        LAB_180b7cd1d:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b7c085:
        iVar14 = 0;
        if (lVar5 != null) {
        LAB_180b7c093:
          piVar15 = &this.itemListInteractType;
          param_4 = local_res20;
          if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
          if (!this.noEquipedItem) {
        LAB_180b7c0d0:
            plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
            if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
            lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
            piVar12 = (int *)il2cpp_object_unbox(plVar10);
            this.itemListInteractType = *piVar12;
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = String.Contains(lVar8,"Trade",0);
            if (!cVar2) {
        LAB_180b7c1e2:
              iVar3 = 0;
              do {
                if ((this.itemGrid == null) ||
                   (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                goto LAB_180b7cd1d;
                iVar4 = Transform.get_childCount(lVar8,0);
                lVar8 = this.itemGrid;
                if (iVar4 <= iVar3) {
                  lVar9 = FUN_18046c1a0(0);
                  if (lVar9 == null) goto LAB_180b7cd1d;
                  uVar6 = *(uint64 *)(lVar9 + 160);
                  lVar8 = GlobalData.AddChild(lVar8,uVar6,0);
                  this.temp = lVar8;
                  if (*plVar10 == 0) goto LAB_180b7cd1d;
                  lVar8 = GameObject.GetComponent(*plVar10,DAT_181da0070);
                  uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  *(uint64 *)(lVar8 + 32) = uVar6;
                  goto LAB_180b7c440;
                }
                if (((lVar8 == null) || (lVar8 = GameObject.get_transform(lVar8,0)) == null) ||
                   (lVar8 = Transform.GetChild(lVar8,iVar3)) == null) goto LAB_180b7cd1d;
                uVar6 = Component.GetComponent(lVar8);
                cVar2 = Object.op_Inequality(uVar6);
                if (cVar2) {
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
                      (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null)))
                  goto LAB_180b7cd1d;
                  lVar8 = *(int64 *)(lVar8 + 32);
                  lVar9 = FUN_180002f80(lVar5);
                  if (lVar8 == lVar9) goto LAB_180b7c303;
                }
                iVar3 = iVar3 + 1;
              } while( true );
            }
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7c637;
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c1e2;
          }
          else {
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = ItemData.Equiped(lVar8);
            if (!cVar2) goto LAB_180b7c0d0;
          }
          goto LAB_180b7c637;
        }
        goto LAB_180b7cd1d;
        LAB_180b7ca79:
        if ((this.itemGrid != null) &&
           (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) {
          iVar14 = Transform.get_childCount(lVar5,0);
        joined_r0x000180b7caa5:
          while (iVar14 = iVar14 + -1, -1 < iVar14) {
            if (this.nowItemListType == 7) {
        LAB_180b7cbc3:
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto code_r0x000180b7cc09;
              goto LAB_180b7cd1d;
            }
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
               ((lVar5 = Component.GetComponent(lVar5,DAT_181d6bdc0), lVar5 == null ||
                (*(int64 *)(lVar5 + 32) == 0)))) goto LAB_180b7cd1d;
            if (*(int *)(*(int64 *)(lVar5 + 32) + 20) == this.nowItemListType)
            goto LAB_180b7cbc3;
            if (((this.itemGrid == null) ||
                (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
               ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                (lVar5 = Component.get_gameObject(lVar5)) == null))) goto LAB_180b7cd1d;
            cVar2 = GameObject.get_activeSelf(lVar5);
            if (cVar2) {
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto LAB_180b7cc5f;
              goto LAB_180b7cd1d;
            }
          }
          ItemListController.ResetSortType(this,0);
          if (param_4) {
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
               (((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d6c940)) == null) ||
                (*(int64 *)(lVar5 + 72) == 0)))) goto LAB_180b7cd1d;
            Scrollbar.set_value(*(int64 *)(lVar5 + 72),0x3f800000,0);
          }
          return;
        }
        goto LAB_180b7cd1d;
        code_r0x000180b7cc09:
        cVar2 = GameObject.get_activeSelf(lVar5);
        if (!cVar2) {
          if ((((this.itemGrid == null) ||
               (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
              (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
             (lVar5 = Component.get_gameObject(lVar5,0)) == null) goto LAB_180b7cd1d;
        LAB_180b7cc5f:
          GameObject.SetActive(lVar5);
        }
        goto joined_r0x000180b7caa5;
        LAB_180b7c303:
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           (lVar8 = Transform.GetChild(lVar8,iVar3,0)) == null) goto LAB_180b7cd1d;
        uVar6 = Component.get_gameObject(lVar8,0);
        this.temp = uVar6;
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
            (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null))) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 52) = 0;
        LAB_180b7c440:
        plVar10 = &this.temp;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(int *)(lVar8 + 24) = iVar14;
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        lVar8 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        piVar12 = (int *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *piVar12;
        if (lVar8 == null) goto LAB_180b7cd1d;
        cVar2 = String.Contains(lVar8,"Trade");
        lVar8 = this.temp;
        if (!cVar2) {
          if ((lVar8 == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
          iVar14 = iVar14 + 1;
          *(uint32 *)(lVar8 + 40) = (uint32)(this.itemListInteractType != null);
          goto LAB_180b7c093;
        }
        if ((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(uint32 *)(lVar8 + 40) = 2;
        if (this.temp == null) goto LAB_180b7cd1d;
        lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
        uVar6 = DAT_181d9ec88;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        uVar7 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        puVar11 = (uint32 *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *puVar11;
        plVar13 = (int64 *)Enum.Parse(uVar6,uVar7,0);
        if ((lVar8 == null) || (plVar13 == (int64 *)0)) goto LAB_180b7cd1d;
        if (*(int64 *)(*plVar13 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar13,DAT_181d880d8);
        }
        puVar11 = (uint32 *)il2cpp_object_unbox();
        *(uint32 *)(lVar8 + 44) = *puVar11;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 55) = 1;
        LAB_180b7c637:
        iVar14 = iVar14 + 1;
        goto LAB_180b7c093;
    }

    // Token : 0x6001844
    // RVA   : 0xB7B7C0   Offset: 0xB79FC0   Length: 0x22
    public void RefreshItemList(ItemListInteractType _itemListInteractType, bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,int64 _itemListInteractType,uint32 resetPos,char param_4)
        {
        uint32 uVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 lVar9;
        int64 *plVar10;
        uint32 *puVar11;
        int *piVar12;
        int64 *plVar13;
        int iVar14;
        int *piVar15;
        uint32 local_res18 [2];
        char local_res20;
        local_res20 = param_4;
        this.itemListInteractType = resetPos;
        uVar6 = this.showAllButton;
        local_res18[0] = 0;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (!cVar2) {
        LAB_180b7bc4f:
          uVar1 = this.nowItemListType;
          if (_itemListInteractType != null) {
            if (uVar1 == 7) {
              lVar5 = *(int64 *)(_itemListInteractType + 40);
            }
            else {
              lVar5 = *(int64 *)(_itemListInteractType + 48);
              if (lVar5 == null) goto LAB_180b7cd1d;
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar1];
            }
            if (this.targetItemList == _itemListInteractType) {
              if ((this.itemGrid != null) &&
                 (lVar8 = GameObject.get_transform(this.itemGrid,0)) != null) {
                iVar14 = Transform.get_childCount(lVar8,0);
        joined_r0x000180b7bcbf:
                do {
                  iVar14 = iVar14 + -1;
                  if (iVar14 < 0) goto LAB_180b7c085;
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                  uVar6 = Component.GetComponent(lVar8);
                  cVar2 = Object.op_Inequality(uVar6);
                  if (cVar2) {
                    if (this.targetItemList == null) break;
                    lVar8 = this.targetItemList.allItem;
                    if (((this.itemGrid == null) ||
                        (lVar9 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar9 = Transform.GetChild(lVar9,iVar14,0), lVar9 == null ||
                           ((lVar9 = Component.GetComponent(lVar9,DAT_181d6bdc0), lVar9 == null ||
                            (lVar8 == null)))))) break;
                    cVar2 = FUN_1818279a0(lVar8,*(uint64 *)(lVar9 + 32));
                    if (cVar2) {
                      if (this.noEquipedItem) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        cVar2 = ItemData.Equiped(*(int64 *)(lVar8 + 32),0);
                        if (cVar2) goto LAB_180b7bfc1;
                      }
                      plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,(uint32 *)(this + 32))
                      ;
                      if (plVar10 == (int64 *)0) break;
                      lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                      puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                      this.itemListInteractType = *puVar11;
                      if (lVar8 == null) break;
                      cVar2 = String.Contains(lVar8);
                      if (!cVar2) goto joined_r0x000180b7bcbf;
                      if (((this.itemGrid == null) ||
                          (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null
                          ) || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                                ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                                 (*(int64 *)(lVar8 + 32) == 0)))))) break;
                      iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                      lVar8 = FUN_18046c700(0);
                      if (lVar8 == null) break;
                      if (*(int *)(lVar8 + 168) <= iVar3) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                        lVar8 = FUN_18046c700(0);
                        if (lVar8 == null) break;
                        if (iVar3 <= *(int *)(lVar8 + 172)) goto joined_r0x000180b7bcbf;
                      }
                    }
        LAB_180b7bfc1:
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                           (lVar8 = Component.get_gameObject(lVar8,0)) == null))) break;
                    GameObject.SetActive(lVar8,0);
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                    uVar6 = Component.get_gameObject(lVar8);
                    Object.Destroy(uVar6);
                  }
                } while( true );
              }
            }
            else {
              this.targetItemList = _itemListInteractType;
              uVar6 = this.itemGrid;
              GlobalData.DeleteAllChild(uVar6,0);
              iVar14 = 0;
              if (lVar5 != null) {
        LAB_180b7c6b0:
                piVar15 = &this.itemListInteractType;
                if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
                if (!this.noEquipedItem) {
        LAB_180b7c6ec:
                  plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                  if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                  lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                  piVar12 = (int *)il2cpp_object_unbox(plVar10);
                  *piVar15 = *piVar12;
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = String.Contains(lVar8,"Trade",0);
                  if (!cVar2) {
        LAB_180b7c7fc:
                    uVar6 = this.itemGrid;
                    lVar8 = FUN_18046c1a0(0);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    uVar7 = *(uint64 *)(lVar8 + 160);
                    uVar6 = GlobalData.AddChild(uVar6,uVar7,0);
                    this.temp = uVar6;
                    if (this.temp == null) goto LAB_180b7cd1d;
                    lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                    uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    *(uint64 *)(lVar8 + 32) = uVar6;
                    if ((this.temp == null) ||
                       (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070),
                       lVar8 == null)) goto LAB_180b7cd1d;
                    *(int *)(lVar8 + 24) = iVar14;
                    plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                    if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                    lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                    piVar12 = (int *)il2cpp_object_unbox(plVar10);
                    *piVar15 = *piVar12;
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    cVar2 = String.Contains(lVar8,"Trade",0);
                    lVar8 = this.temp;
                    if (cVar2) {
                      if ((lVar8 != null) &&
                         (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) != null) {
                        *(uint32 *)(lVar8 + 40) = 2;
                        if (this.temp != null) {
                          lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                          uVar6 = DAT_181d9ec88;
                          uVar6 = Type.GetTypeFromHandle(uVar6,0);
                          plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                          if (plVar10 != (int64 *)0) {
                            uVar7 = (**(code **)(*plVar10 + 0x168))
                                              (plVar10,*(uint64 *)(*plVar10 + 0x170));
                            puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                            this.itemListInteractType = *puVar11;
                            plVar10 = (int64 *)Enum.Parse(uVar6,uVar7,0);
                            if ((lVar8 != null) && (plVar10 != (int64 *)0)) {
                              if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6070(plVar10,DAT_181d880d8);
                              }
                              puVar11 = (uint32 *)il2cpp_object_unbox();
                              *(uint32 *)(lVar8 + 44) = *puVar11;
                              goto LAB_180b7ca6a;
                            }
                          }
                        }
                      }
                      goto LAB_180b7cd1d;
                    }
                    if ((lVar8 == null) ||
                       (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
                    goto LAB_180b7cd1d;
                    iVar14 = iVar14 + 1;
                    *(uint32 *)(lVar8 + 40) = (uint32)(*piVar15 != 0);
                    goto LAB_180b7c6b0;
                  }
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7ca6a;
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c7fc;
                }
                else {
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = ItemData.Equiped(lVar8,0);
                  if (!cVar2) goto LAB_180b7c6ec;
                }
        LAB_180b7ca6a:
                iVar14 = iVar14 + 1;
                goto LAB_180b7c6b0;
              }
            }
          }
        }
        else {
          iVar14 = 0;
          lVar5 = this.showAllButton;
          if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                    (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
          else {
            this.nowItemListType = this.forceItemListType;
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar14)) == null) break;
                uVar6 = Object.get_name(lVar5,0);
                local_res18[0] = this.forceItemListType;
                uVar7 = Int32.ToString(local_res18,0);
                cVar2 = FUN_1816fd990(uVar6,uVar7);
                lVar5 = this.showAllButton;
                if (!cVar2) {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5);
                }
                else {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      ((lVar5 = Transform.GetChild(lVar5,iVar14), lVar5 == null ||
                       (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))))) break;
                  Toggle.set_isOn(lVar5,1);
                  if ((this.showAllButton == null) ||
                     (((lVar5 = GameObject.get_transform(this.showAllButton,0), lVar5 == null ||
                       (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5,DAT_181d6da40);
                }
                if (lVar5 == null) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
        }
        LAB_180b7cd1d:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b7c085:
        iVar14 = 0;
        if (lVar5 != null) {
        LAB_180b7c093:
          piVar15 = &this.itemListInteractType;
          param_4 = local_res20;
          if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
          if (!this.noEquipedItem) {
        LAB_180b7c0d0:
            plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
            if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
            lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
            piVar12 = (int *)il2cpp_object_unbox(plVar10);
            this.itemListInteractType = *piVar12;
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = String.Contains(lVar8,"Trade",0);
            if (!cVar2) {
        LAB_180b7c1e2:
              iVar3 = 0;
              do {
                if ((this.itemGrid == null) ||
                   (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                goto LAB_180b7cd1d;
                iVar4 = Transform.get_childCount(lVar8,0);
                lVar8 = this.itemGrid;
                if (iVar4 <= iVar3) {
                  lVar9 = FUN_18046c1a0(0);
                  if (lVar9 == null) goto LAB_180b7cd1d;
                  uVar6 = *(uint64 *)(lVar9 + 160);
                  lVar8 = GlobalData.AddChild(lVar8,uVar6,0);
                  this.temp = lVar8;
                  if (*plVar10 == 0) goto LAB_180b7cd1d;
                  lVar8 = GameObject.GetComponent(*plVar10,DAT_181da0070);
                  uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  *(uint64 *)(lVar8 + 32) = uVar6;
                  goto LAB_180b7c440;
                }
                if (((lVar8 == null) || (lVar8 = GameObject.get_transform(lVar8,0)) == null) ||
                   (lVar8 = Transform.GetChild(lVar8,iVar3)) == null) goto LAB_180b7cd1d;
                uVar6 = Component.GetComponent(lVar8);
                cVar2 = Object.op_Inequality(uVar6);
                if (cVar2) {
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
                      (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null)))
                  goto LAB_180b7cd1d;
                  lVar8 = *(int64 *)(lVar8 + 32);
                  lVar9 = FUN_180002f80(lVar5);
                  if (lVar8 == lVar9) goto LAB_180b7c303;
                }
                iVar3 = iVar3 + 1;
              } while( true );
            }
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7c637;
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c1e2;
          }
          else {
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = ItemData.Equiped(lVar8);
            if (!cVar2) goto LAB_180b7c0d0;
          }
          goto LAB_180b7c637;
        }
        goto LAB_180b7cd1d;
        LAB_180b7ca79:
        if ((this.itemGrid != null) &&
           (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) {
          iVar14 = Transform.get_childCount(lVar5,0);
        joined_r0x000180b7caa5:
          while (iVar14 = iVar14 + -1, -1 < iVar14) {
            if (this.nowItemListType == 7) {
        LAB_180b7cbc3:
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto code_r0x000180b7cc09;
              goto LAB_180b7cd1d;
            }
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
               ((lVar5 = Component.GetComponent(lVar5,DAT_181d6bdc0), lVar5 == null ||
                (*(int64 *)(lVar5 + 32) == 0)))) goto LAB_180b7cd1d;
            if (*(int *)(*(int64 *)(lVar5 + 32) + 20) == this.nowItemListType)
            goto LAB_180b7cbc3;
            if (((this.itemGrid == null) ||
                (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
               ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                (lVar5 = Component.get_gameObject(lVar5)) == null))) goto LAB_180b7cd1d;
            cVar2 = GameObject.get_activeSelf(lVar5);
            if (cVar2) {
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto LAB_180b7cc5f;
              goto LAB_180b7cd1d;
            }
          }
          ItemListController.ResetSortType(this,0);
          if (param_4) {
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
               (((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d6c940)) == null) ||
                (*(int64 *)(lVar5 + 72) == 0)))) goto LAB_180b7cd1d;
            Scrollbar.set_value(*(int64 *)(lVar5 + 72),0x3f800000,0);
          }
          return;
        }
        goto LAB_180b7cd1d;
        code_r0x000180b7cc09:
        cVar2 = GameObject.get_activeSelf(lVar5);
        if (!cVar2) {
          if ((((this.itemGrid == null) ||
               (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
              (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
             (lVar5 = Component.get_gameObject(lVar5,0)) == null) goto LAB_180b7cd1d;
        LAB_180b7cc5f:
          GameObject.SetActive(lVar5);
        }
        goto joined_r0x000180b7caa5;
        LAB_180b7c303:
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           (lVar8 = Transform.GetChild(lVar8,iVar3,0)) == null) goto LAB_180b7cd1d;
        uVar6 = Component.get_gameObject(lVar8,0);
        this.temp = uVar6;
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
            (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null))) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 52) = 0;
        LAB_180b7c440:
        plVar10 = &this.temp;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(int *)(lVar8 + 24) = iVar14;
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        lVar8 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        piVar12 = (int *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *piVar12;
        if (lVar8 == null) goto LAB_180b7cd1d;
        cVar2 = String.Contains(lVar8,"Trade");
        lVar8 = this.temp;
        if (!cVar2) {
          if ((lVar8 == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
          iVar14 = iVar14 + 1;
          *(uint32 *)(lVar8 + 40) = (uint32)(this.itemListInteractType != null);
          goto LAB_180b7c093;
        }
        if ((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(uint32 *)(lVar8 + 40) = 2;
        if (this.temp == null) goto LAB_180b7cd1d;
        lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
        uVar6 = DAT_181d9ec88;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        uVar7 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        puVar11 = (uint32 *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *puVar11;
        plVar13 = (int64 *)Enum.Parse(uVar6,uVar7,0);
        if ((lVar8 == null) || (plVar13 == (int64 *)0)) goto LAB_180b7cd1d;
        if (*(int64 *)(*plVar13 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar13,DAT_181d880d8);
        }
        puVar11 = (uint32 *)il2cpp_object_unbox();
        *(uint32 *)(lVar8 + 44) = *puVar11;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 55) = 1;
        LAB_180b7c637:
        iVar14 = iVar14 + 1;
        goto LAB_180b7c093;
    }

    // Token : 0x6001845
    // RVA   : 0xB7B820   Offset: 0xB7A020   Length: 0x1514
    public void RefreshItemList(ItemListData _targetItemList, ItemListInteractType _itemListInteractType, bool resetPos)
    {
        void ItemListController.RefreshItemList
                     (int64 this,int64 _targetItemList,uint32 _itemListInteractType,char resetPos)
        {
        uint32 uVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int64 lVar9;
        int64 *plVar10;
        uint32 *puVar11;
        int *piVar12;
        int64 *plVar13;
        int iVar14;
        int *piVar15;
        uint32 local_res18 [2];
        char local_res20;
        local_res20 = resetPos;
        this.itemListInteractType = _itemListInteractType;
        uVar6 = this.showAllButton;
        local_res18[0] = 0;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (!cVar2) {
        LAB_180b7bc4f:
          uVar1 = this.nowItemListType;
          if (_targetItemList != null) {
            if (uVar1 == 7) {
              lVar5 = *(int64 *)(_targetItemList + 40);
            }
            else {
              lVar5 = *(int64 *)(_targetItemList + 48);
              if (lVar5 == null) goto LAB_180b7cd1d;
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar1];
            }
            if (this.targetItemList == _targetItemList) {
              if ((this.itemGrid != null) &&
                 (lVar8 = GameObject.get_transform(this.itemGrid,0)) != null) {
                iVar14 = Transform.get_childCount(lVar8,0);
        joined_r0x000180b7bcbf:
                do {
                  iVar14 = iVar14 + -1;
                  if (iVar14 < 0) goto LAB_180b7c085;
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                  uVar6 = Component.GetComponent(lVar8);
                  cVar2 = Object.op_Inequality(uVar6);
                  if (cVar2) {
                    if (this.targetItemList == null) break;
                    lVar8 = this.targetItemList.allItem;
                    if (((this.itemGrid == null) ||
                        (lVar9 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar9 = Transform.GetChild(lVar9,iVar14,0), lVar9 == null ||
                           ((lVar9 = Component.GetComponent(lVar9,DAT_181d6bdc0), lVar9 == null ||
                            (lVar8 == null)))))) break;
                    cVar2 = FUN_1818279a0(lVar8,*(uint64 *)(lVar9 + 32));
                    if (cVar2) {
                      if (this.noEquipedItem) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        cVar2 = ItemData.Equiped(*(int64 *)(lVar8 + 32),0);
                        if (cVar2) goto LAB_180b7bfc1;
                      }
                      plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,(uint32 *)(this + 32))
                      ;
                      if (plVar10 == (int64 *)0) break;
                      lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                      puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                      this.itemListInteractType = *puVar11;
                      if (lVar8 == null) break;
                      cVar2 = String.Contains(lVar8);
                      if (!cVar2) goto joined_r0x000180b7bcbf;
                      if (((this.itemGrid == null) ||
                          (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null
                          ) || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                                ((lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0), lVar8 == null ||
                                 (*(int64 *)(lVar8 + 32) == 0)))))) break;
                      iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                      lVar8 = FUN_18046c700(0);
                      if (lVar8 == null) break;
                      if (*(int *)(lVar8 + 168) <= iVar3) {
                        if ((((this.itemGrid == null) ||
                             (lVar8 = GameObject.get_transform(this.itemGrid,0),
                             lVar8 == null)) || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) ||
                           ((lVar8 = Component.GetComponent(lVar8), lVar8 == null ||
                            (*(int64 *)(lVar8 + 32) == 0)))) break;
                        iVar3 = *(int *)(*(int64 *)(lVar8 + 32) + 60);
                        lVar8 = FUN_18046c700(0);
                        if (lVar8 == null) break;
                        if (iVar3 <= *(int *)(lVar8 + 172)) goto joined_r0x000180b7bcbf;
                      }
                    }
        LAB_180b7bfc1:
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || ((lVar8 = Transform.GetChild(lVar8,iVar14,0), lVar8 == null ||
                           (lVar8 = Component.get_gameObject(lVar8,0)) == null))) break;
                    GameObject.SetActive(lVar8,0);
                    if (((this.itemGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                       || (lVar8 = Transform.GetChild(lVar8,iVar14,0)) == null) break;
                    uVar6 = Component.get_gameObject(lVar8);
                    Object.Destroy(uVar6);
                  }
                } while( true );
              }
            }
            else {
              this.targetItemList = _targetItemList;
              uVar6 = this.itemGrid;
              GlobalData.DeleteAllChild(uVar6,0);
              iVar14 = 0;
              if (lVar5 != null) {
        LAB_180b7c6b0:
                piVar15 = &this.itemListInteractType;
                if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
                if (!this.noEquipedItem) {
        LAB_180b7c6ec:
                  plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                  if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                  lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                  piVar12 = (int *)il2cpp_object_unbox(plVar10);
                  *piVar15 = *piVar12;
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = String.Contains(lVar8,"Trade",0);
                  if (!cVar2) {
        LAB_180b7c7fc:
                    uVar6 = this.itemGrid;
                    lVar8 = FUN_18046c1a0(0);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    uVar7 = *(uint64 *)(lVar8 + 160);
                    uVar6 = GlobalData.AddChild(uVar6,uVar7,0);
                    this.temp = uVar6;
                    if (this.temp == null) goto LAB_180b7cd1d;
                    lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                    uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    *(uint64 *)(lVar8 + 32) = uVar6;
                    if ((this.temp == null) ||
                       (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070),
                       lVar8 == null)) goto LAB_180b7cd1d;
                    *(int *)(lVar8 + 24) = iVar14;
                    plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                    if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
                    lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                    piVar12 = (int *)il2cpp_object_unbox(plVar10);
                    *piVar15 = *piVar12;
                    if (lVar8 == null) goto LAB_180b7cd1d;
                    cVar2 = String.Contains(lVar8,"Trade",0);
                    lVar8 = this.temp;
                    if (cVar2) {
                      if ((lVar8 != null) &&
                         (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) != null) {
                        *(uint32 *)(lVar8 + 40) = 2;
                        if (this.temp != null) {
                          lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
                          uVar6 = DAT_181d9ec88;
                          uVar6 = Type.GetTypeFromHandle(uVar6,0);
                          plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
                          if (plVar10 != (int64 *)0) {
                            uVar7 = (**(code **)(*plVar10 + 0x168))
                                              (plVar10,*(uint64 *)(*plVar10 + 0x170));
                            puVar11 = (uint32 *)il2cpp_object_unbox(plVar10);
                            this.itemListInteractType = *puVar11;
                            plVar10 = (int64 *)Enum.Parse(uVar6,uVar7,0);
                            if ((lVar8 != null) && (plVar10 != (int64 *)0)) {
                              if (*(int64 *)(*plVar10 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6070(plVar10,DAT_181d880d8);
                              }
                              puVar11 = (uint32 *)il2cpp_object_unbox();
                              *(uint32 *)(lVar8 + 44) = *puVar11;
                              goto LAB_180b7ca6a;
                            }
                          }
                        }
                      }
                      goto LAB_180b7cd1d;
                    }
                    if ((lVar8 == null) ||
                       (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
                    goto LAB_180b7cd1d;
                    iVar14 = iVar14 + 1;
                    *(uint32 *)(lVar8 + 40) = (uint32)(*piVar15 != 0);
                    goto LAB_180b7c6b0;
                  }
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7ca6a;
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  iVar3 = *(int *)(lVar8 + 60);
                  lVar8 = FUN_18046c700(0);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c7fc;
                }
                else {
                  lVar8 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  cVar2 = ItemData.Equiped(lVar8,0);
                  if (!cVar2) goto LAB_180b7c6ec;
                }
        LAB_180b7ca6a:
                iVar14 = iVar14 + 1;
                goto LAB_180b7c6b0;
              }
            }
          }
        }
        else {
          iVar14 = 0;
          lVar5 = this.showAllButton;
          if ((this.forceItemListType + 1U & 0xfffffff7) == 0) {
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                    (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
          else {
            this.nowItemListType = this.forceItemListType;
            if (lVar5 != null) {
              while ((lVar5 = GameObject.get_transform(lVar5,0), lVar5 != null &&
                     (lVar5 = FUN_180da0f00(lVar5,0)) != null)) {
                iVar3 = Transform.get_childCount(lVar5,0);
                if (iVar3 <= iVar14) goto LAB_180b7bc4f;
                if ((((this.showAllButton == null) ||
                     (lVar5 = GameObject.get_transform(this.showAllButton,0)) == null) ||
                    (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                   (lVar5 = Transform.GetChild(lVar5,iVar14)) == null) break;
                uVar6 = Object.get_name(lVar5,0);
                local_res18[0] = this.forceItemListType;
                uVar7 = Int32.ToString(local_res18,0);
                cVar2 = FUN_1816fd990(uVar6,uVar7);
                lVar5 = this.showAllButton;
                if (!cVar2) {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5);
                }
                else {
                  if (((lVar5 == null) || (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
                     ((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                      ((lVar5 = Transform.GetChild(lVar5,iVar14), lVar5 == null ||
                       (lVar5 = Component.GetComponent(lVar5,DAT_181d6da40)) == null))))) break;
                  Toggle.set_isOn(lVar5,1);
                  if ((this.showAllButton == null) ||
                     (((lVar5 = GameObject.get_transform(this.showAllButton,0), lVar5 == null ||
                       (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
                      (lVar5 = Transform.GetChild(lVar5,iVar14)) == null))) break;
                  lVar5 = Component.GetComponent(lVar5,DAT_181d6da40);
                }
                if (lVar5 == null) break;
                Selectable.set_interactable(lVar5);
                lVar5 = this.showAllButton;
                iVar14 = iVar14 + 1;
                if (lVar5 == null) break;
              }
            }
          }
        }
        LAB_180b7cd1d:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b7c085:
        iVar14 = 0;
        if (lVar5 != null) {
        LAB_180b7c093:
          piVar15 = &this.itemListInteractType;
          resetPos = local_res20;
          if (*(int *)(lVar5 + 24) <= iVar14) goto LAB_180b7ca79;
          if (!this.noEquipedItem) {
        LAB_180b7c0d0:
            plVar10 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
            if (plVar10 == (int64 *)0) goto LAB_180b7cd1d;
            lVar8 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
            piVar12 = (int *)il2cpp_object_unbox(plVar10);
            this.itemListInteractType = *piVar12;
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = String.Contains(lVar8,"Trade",0);
            if (!cVar2) {
        LAB_180b7c1e2:
              iVar3 = 0;
              do {
                if ((this.itemGrid == null) ||
                   (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null)
                goto LAB_180b7cd1d;
                iVar4 = Transform.get_childCount(lVar8,0);
                lVar8 = this.itemGrid;
                if (iVar4 <= iVar3) {
                  lVar9 = FUN_18046c1a0(0);
                  if (lVar9 == null) goto LAB_180b7cd1d;
                  uVar6 = *(uint64 *)(lVar9 + 160);
                  lVar8 = GlobalData.AddChild(lVar8,uVar6,0);
                  this.temp = lVar8;
                  if (*plVar10 == 0) goto LAB_180b7cd1d;
                  lVar8 = GameObject.GetComponent(*plVar10,DAT_181da0070);
                  uVar6 = FUN_180002f80(lVar5,iVar14,DAT_181d69770);
                  if (lVar8 == null) goto LAB_180b7cd1d;
                  *(uint64 *)(lVar8 + 32) = uVar6;
                  goto LAB_180b7c440;
                }
                if (((lVar8 == null) || (lVar8 = GameObject.get_transform(lVar8,0)) == null) ||
                   (lVar8 = Transform.GetChild(lVar8,iVar3)) == null) goto LAB_180b7cd1d;
                uVar6 = Component.GetComponent(lVar8);
                cVar2 = Object.op_Inequality(uVar6);
                if (cVar2) {
                  if (((this.itemGrid == null) ||
                      (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                     ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
                      (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null)))
                  goto LAB_180b7cd1d;
                  lVar8 = *(int64 *)(lVar8 + 32);
                  lVar9 = FUN_180002f80(lVar5);
                  if (lVar8 == lVar9) goto LAB_180b7c303;
                }
                iVar3 = iVar3 + 1;
              } while( true );
            }
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 < *(int *)(lVar8 + 168)) goto LAB_180b7c637;
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            iVar3 = *(int *)(lVar8 + 60);
            lVar8 = FUN_18046c700(0);
            if (lVar8 == null) goto LAB_180b7cd1d;
            if (iVar3 <= *(int *)(lVar8 + 172)) goto LAB_180b7c1e2;
          }
          else {
            lVar8 = FUN_180002f80(lVar5);
            if (lVar8 == null) goto LAB_180b7cd1d;
            cVar2 = ItemData.Equiped(lVar8);
            if (!cVar2) goto LAB_180b7c0d0;
          }
          goto LAB_180b7c637;
        }
        goto LAB_180b7cd1d;
        LAB_180b7ca79:
        if ((this.itemGrid != null) &&
           (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) {
          iVar14 = Transform.get_childCount(lVar5,0);
        joined_r0x000180b7caa5:
          while (iVar14 = iVar14 + -1, -1 < iVar14) {
            if (this.nowItemListType == 7) {
        LAB_180b7cbc3:
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto code_r0x000180b7cc09;
              goto LAB_180b7cd1d;
            }
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
               ((lVar5 = Component.GetComponent(lVar5,DAT_181d6bdc0), lVar5 == null ||
                (*(int64 *)(lVar5 + 32) == 0)))) goto LAB_180b7cd1d;
            if (*(int *)(*(int64 *)(lVar5 + 32) + 20) == this.nowItemListType)
            goto LAB_180b7cbc3;
            if (((this.itemGrid == null) ||
                (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
               ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 == null ||
                (lVar5 = Component.get_gameObject(lVar5)) == null))) goto LAB_180b7cd1d;
            cVar2 = GameObject.get_activeSelf(lVar5);
            if (cVar2) {
              if (((this.itemGrid != null) &&
                  (lVar5 = GameObject.get_transform(this.itemGrid,0)) != null) &&
                 ((lVar5 = Transform.GetChild(lVar5,iVar14,0), lVar5 != null &&
                  (lVar5 = Component.get_gameObject(lVar5)) != null))) goto LAB_180b7cc5f;
              goto LAB_180b7cd1d;
            }
          }
          ItemListController.ResetSortType(this,0);
          if (resetPos) {
            if ((((this.itemGrid == null) ||
                 (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
                (lVar5 = FUN_180da0f00(lVar5,0)) == null) ||
               (((lVar5 = FUN_180da0f00(lVar5,0), lVar5 == null ||
                 (lVar5 = Component.GetComponent(lVar5,DAT_181d6c940)) == null) ||
                (*(int64 *)(lVar5 + 72) == 0)))) goto LAB_180b7cd1d;
            Scrollbar.set_value(*(int64 *)(lVar5 + 72),0x3f800000,0);
          }
          return;
        }
        goto LAB_180b7cd1d;
        code_r0x000180b7cc09:
        cVar2 = GameObject.get_activeSelf(lVar5);
        if (!cVar2) {
          if ((((this.itemGrid == null) ||
               (lVar5 = GameObject.get_transform(this.itemGrid,0)) == null) ||
              (lVar5 = Transform.GetChild(lVar5,iVar14,0)) == null) ||
             (lVar5 = Component.get_gameObject(lVar5,0)) == null) goto LAB_180b7cd1d;
        LAB_180b7cc5f:
          GameObject.SetActive(lVar5);
        }
        goto joined_r0x000180b7caa5;
        LAB_180b7c303:
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           (lVar8 = Transform.GetChild(lVar8,iVar3,0)) == null) goto LAB_180b7cd1d;
        uVar6 = Component.get_gameObject(lVar8,0);
        this.temp = uVar6;
        if (((this.itemGrid == null) ||
            (lVar8 = GameObject.get_transform(this.itemGrid,0)) == null) ||
           ((lVar8 = Transform.GetChild(lVar8,iVar3,0), lVar8 == null ||
            (lVar8 = Component.GetComponent(lVar8,DAT_181d6bdc0)) == null))) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 52) = 0;
        LAB_180b7c440:
        plVar10 = &this.temp;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(int *)(lVar8 + 24) = iVar14;
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        lVar8 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        piVar12 = (int *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *piVar12;
        if (lVar8 == null) goto LAB_180b7cd1d;
        cVar2 = String.Contains(lVar8,"Trade");
        lVar8 = this.temp;
        if (!cVar2) {
          if ((lVar8 == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
          iVar14 = iVar14 + 1;
          *(uint32 *)(lVar8 + 40) = (uint32)(this.itemListInteractType != null);
          goto LAB_180b7c093;
        }
        if ((lVar8 == null) || (lVar8 = GameObject.GetComponent(lVar8,DAT_181da0070)) == null)
        goto LAB_180b7cd1d;
        *(uint32 *)(lVar8 + 40) = 2;
        if (this.temp == null) goto LAB_180b7cd1d;
        lVar8 = GameObject.GetComponent(this.temp,DAT_181da0070);
        uVar6 = DAT_181d9ec88;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar13 = (int64 *)il2cpp_value_box(DAT_181d5d0f8,piVar15);
        if (plVar13 == (int64 *)0) goto LAB_180b7cd1d;
        uVar7 = (**(code **)(*plVar13 + 0x168))(plVar13,*(uint64 *)(*plVar13 + 0x170));
        puVar11 = (uint32 *)il2cpp_object_unbox(plVar13);
        this.itemListInteractType = *puVar11;
        plVar13 = (int64 *)Enum.Parse(uVar6,uVar7,0);
        if ((lVar8 == null) || (plVar13 == (int64 *)0)) goto LAB_180b7cd1d;
        if (*(int64 *)(*plVar13 + 64) != *(int64 *)(DAT_181d880d8 + 64)) {
                          // WARNING: Subroutine does not return
          FUN_1800d6070(plVar13,DAT_181d880d8);
        }
        puVar11 = (uint32 *)il2cpp_object_unbox();
        *(uint32 *)(lVar8 + 44) = *puVar11;
        if ((this.temp == null) || (lVar8 = GameObject.GetComponent()) == null) goto LAB_180b7cd1d;
        *(uint8 *)(lVar8 + 55) = 1;
        LAB_180b7c637:
        iVar14 = iVar14 + 1;
        goto LAB_180b7c093;
    }

    // Token : 0x6001846
    // RVA   : 0xB7B710   Offset: 0xB79F10   Length: 0xAB
    public void FreshList(bool resetPos)
    {
        long lVar1;
        ItemListController.ResetSortType(this,0);
        if (!resetPos) {
          return;
        }
        if ((((this.itemGrid != null) &&
             (lVar1 = GameObject.get_transform(this.itemGrid,0)) != null) &&
            (lVar1 = FUN_180da0f00(lVar1,0)) != null) &&
           (((lVar1 = FUN_180da0f00(lVar1,0), lVar1 != null &&
             (lVar1 = Component.GetComponent(lVar1,DAT_181d6c940)) != null) &&
            (*(int64 *)(lVar1 + 72) != 0)))) {
          Scrollbar.set_value(*(int64 *)(lVar1 + 72),0x3f800000,0);
          return;
        }
    }

    // Token : 0x6001847
    // RVA   : 0xB7B550   Offset: 0xB79D50   Length: 0x15E
    public void ChangeSortType()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if (this.sortTypeDropDown != null) {
          this.itemSortType = *(uint32 *)(this.sortTypeDropDown + 0x120);
          if (this.recordSortType) {
            if ((*pStatics == 0) ||
               (lVar1 = *(int64 *)(*pStatics + 32)) == null)
            throw; // [null/range check failed]
            *(uint32 *)(lVar1 + 0x250) = this.itemSortType;
          }
          ItemListController.ResetSortType(this,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0x3f19999a,0);
          return;
        }
    }

    // Token : 0x6001848
    // RVA   : 0xB7B310   Offset: 0xB79B10   Length: 0x23E
    public void ChangeReverseType(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        int iVar4;
        uint local_18;
        float local_14;
        uint local_10;
        this.reverseOrder = !this.reverseOrder;
        if (this.recordSortType) {
          if ((*pStatics == 0) ||
             (lVar1 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          *(uint8 *)(lVar1 + 0x254) = this.reverseOrder;
        }
        if (buttonClicked != null) {
          lVar1 = GameObject.get_transform(buttonClicked,0);
          if (lVar1 != null) {
            uVar2 = Transform.Find(lVar1,"Icon",0);
            iVar4 = -1;
            if (!this.reverseOrder) {
              iVar4 = 1;
            }
            local_18 = 0x3f800000;
            local_10 = 0x3f800000;
            local_14 = (float)iVar4;
            ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
            lVar1 = GameObject.GetComponent(buttonClicked,DAT_181da12b0);
            uVar2 = "升序";
            if (this.reverseOrder) {
              uVar2 = "降序";
            }
            if (lVar1 != null) {
              *(uint64 *)(lVar1 + 24) = uVar2;
              ItemListController.ResetSortType(this,0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
              plVar5 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar5 = plVar3;
              }
              NGUITools.PlaySound(plVar5,0x3f19999a,0);
              return;
            }
          }
        }
    }

    // Token : 0x6001849
    // RVA   : 0xB7CDF0   Offset: 0xB7B5F0   Length: 0x11D
    public void ResetSortType()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        lVar2 = this.itemGrid;
        iVar3 = 0;
        if (lVar2 != null) {
          while (lVar2 = GameObject.get_transform(lVar2,0)) != null {
            iVar1 = Transform.get_childCount(lVar2,0);
            lVar2 = this.itemGrid;
            if (iVar1 <= iVar3) {
              GlobalData.SortChild(lVar2,0);
              return;
            }
            if ((((lVar2 == null) || (lVar2 = GameObject.get_transform(lVar2,0)) == null) ||
                (lVar2 = Transform.GetChild(lVar2,iVar3,0)) == null) ||
               (lVar2 = Component.GetComponent(lVar2,DAT_181d6bdc0)) == null) break;
            ItemIconController.AutoSetName
                      (lVar2,this.itemSortType,this.reverseOrder,0);
            lVar2 = this.itemGrid;
            iVar3 = iVar3 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x600184A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
