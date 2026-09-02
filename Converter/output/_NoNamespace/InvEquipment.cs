// ============================================================
// Type  : InvEquipment
// Token : 0x200000E
// ============================================================

public class InvEquipment
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000040
    private InvGameItem[] mItems;

    // Token: 0x4000041
    private InvAttachmentPoint[] mAttachments;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000031
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    public InvGameItem[] get_equippedItems()
    {
        return this.mItems;
    }

    // Token : 0x6000032
    // RVA   : 0xB721F0   Offset: 0xB709F0   Length: 0x3E5
    public InvGameItem Replace(Slot slot, InvGameItem item)
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar8;
        long lVar9;
        uint uVar10;
        uVar8 = 0;
        uVar3 = uVar8;
        if (item != null) {
          uVar3 = InvGameItem.get_baseItem(item,0);
        }
        if (slot == null) {
          if (item != null) {
            lVar4 = InvGameItem.get_baseItem(item,0);
            if (lVar4 != null) {
              plVar5 = (int64 *)il2cpp_value_box(DAT_181d55bf0,item + 20);
              if (plVar5 == (int64 *)0) {
        LAB_180b72590:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              puVar7 = (uint32 *)il2cpp_object_unbox(plVar5);
              *(uint32 *)(item + 20) = *puVar7;
              lVar4 = InvGameItem.get_baseItem(item,0);
              if (lVar4 == null) goto LAB_180b72590;
              uVar8 = String.Concat(uVar6," ",*(uint64 *)(lVar4 + 24),0);
            }
            uVar6 = String.Concat("Can't equip \"",uVar8,"\" because it doesn't specify an item slot",0);
            Debug.LogWarning(uVar6,0);
          }
        }
        else if ((uVar3 == 0) || (*(int *)(uVar3 + 40) == slot)) {
          plVar5 = this.mItems;
          if (plVar5 == (int64 *)0) {
            uVar6 = FUN_1800d60b0(DAT_181d7e900,8);
            this.mItems = uVar6;
            plVar5 = this.mItems;
            if (plVar5 == (int64 *)0) goto LAB_180b72590;
          }
          if (*(uint32 *)(plVar5 + 3) <= slot - 1U) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          lVar4 = plVar5[(int64)slot + 3];
          if ((item != null) &&
             (lVar9 = il2cpp_internal(item,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if (*(uint32 *)(plVar5 + 3) <= slot - 1U) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar5[(int64)slot + 3] = item;
          il2cpp_internal(plVar5 + (int64)slot + 3,item);
          lVar9 = this.mAttachments;
          if (lVar9 == null) {
            uVar6 = FUN_180956bf0(this,DAT_181d6fc40);
            this.mAttachments = uVar6;
            lVar9 = this.mAttachments;
            if (lVar9 == null) goto LAB_180b72590;
          }
          iVar1 = *(int *)(lVar9 + 24);
          item = lVar4;
          if (0 < iVar1) {
            do {
              lVar4 = this.mAttachments;
              if (lVar4 == null) goto LAB_180b72590;
              uVar10 = (uint32)uVar8;
              if (*(uint32 *)(lVar4 + 24) <= uVar10) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              lVar4 = lVar4[uVar10];
              if (lVar4 == null) goto LAB_180b72590;
              if (*(int *)(lVar4 + 24) == slot) {
                if (uVar3 == 0) {
                  InvAttachmentPoint.Attach(lVar4,0,0);
                }
                else {
                  lVar4 = InvAttachmentPoint.Attach(lVar4,*(uint64 *)(uVar3 + 64),0);
                  cVar2 = Object.op_Inequality(lVar4);
                  if (cVar2) {
                    if (lVar4 == null) goto LAB_180b72590;
                    lVar4 = GameObject.GetComponent(lVar4);
                    cVar2 = Object.op_Inequality(lVar4);
                    if (cVar2) {
                      if ((lVar4 == null) || (lVar4 = FUN_180d94be0(lVar4,0)) == null)
                      goto LAB_180b72590;
                      Material.set_color(lVar4);
                    }
                  }
                }
              }
              uVar8 = (uint64)(uVar10 + 1);
            } while ((int)(uVar10 + 1) < iVar1);
          }
        }
        return item;
    }

    // Token : 0x6000033
    // RVA   : 0xB71FE0   Offset: 0xB707E0   Length: 0xC6
    public InvGameItem Equip(InvGameItem item)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[6];
        if (item != null) {
          lVar1 = InvGameItem.get_baseItem(item,0);
          if (lVar1 != null) {
            lVar1 = InvEquipment.Replace(this,*(uint32 *)(lVar1 + 40),item,0);
            return lVar1;
          }
          local_res10[0] = *(uint32 *)(item + 16);
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("Can't resolve the item ID of ",uVar2,0);
          Debug.LogWarning(uVar2,0);
        }
        return item;
    }

    // Token : 0x6000034
    // RVA   : 0xB725E0   Offset: 0xB70DE0   Length: 0x4D
    public InvGameItem Unequip(InvGameItem item)
    {
        void FUN_180b72630(uint64 this,uint64 item)
        {
        InvEquipment.Replace(this,item,0,0);
    }

    // Token : 0x6000035
    // RVA   : 0xB72630   Offset: 0xB70E30   Length: 0xB
    public InvGameItem Unequip(Slot slot)
    {
        void FUN_180b72630(uint64 this,uint64 slot)
        {
        InvEquipment.Replace(this,slot,0,0);
    }

    // Token : 0x6000036
    // RVA   : 0xB721A0   Offset: 0xB709A0   Length: 0x4B
    public bool HasEquipped(InvGameItem item)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        if (this.mItems != null) {
          iVar1 = *(int *)(this.mItems + 24);
          uVar4 = 0;
          if (0 < iVar1) {
            do {
              lVar2 = this.mItems;
              if (lVar2 == null) {
        LAB_180b7217d:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(uint32 *)(lVar2 + 24) <= uVar4) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              if (lVar2[uVar4] == 0) goto LAB_180b7217d;
              lVar2 = InvGameItem.get_baseItem();
              if ((lVar2 != null) && (*(int *)(lVar2 + 40) == item)) {
                return true;
              }
              uVar4 = uVar4 + 1;
            } while ((int)uVar4 < iVar1);
          }
        }
        return false;
    }

    // Token : 0x6000037
    // RVA   : 0xB72100   Offset: 0xB70900   Length: 0x92
    public bool HasEquipped(Slot slot)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        if (this.mItems != null) {
          iVar1 = *(int *)(this.mItems + 24);
          uVar4 = 0;
          if (0 < iVar1) {
            do {
              lVar2 = this.mItems;
              if (lVar2 == null) {
        LAB_180b7217d:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(uint32 *)(lVar2 + 24) <= uVar4) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              if (lVar2[uVar4] == 0) goto LAB_180b7217d;
              lVar2 = InvGameItem.get_baseItem();
              if ((lVar2 != null) && (*(int *)(lVar2 + 40) == slot)) {
                return true;
              }
              uVar4 = uVar4 + 1;
            } while ((int)uVar4 < iVar1);
          }
        }
        return false;
    }

    // Token : 0x6000038
    // RVA   : 0xB720B0   Offset: 0xB708B0   Length: 0x45
    public InvGameItem GetItem(Slot slot)
    {
        long lVar1;
        ulong uVar2;
        if ((slot != null) && (lVar1 = this.mItems) != null) {
          if (slot <= (int)*(uint32 *)(lVar1 + 24)) {
            if ((uint32)((int64)slot + -1) < *(uint32 *)(lVar1 + 24)) {
              return *(uint64 *)(lVar1 + 32 + ((int64)slot + -1) * 8);
            }
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
        }
        return 0;
    }

    // Token : 0x6000039
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
