// ============================================================
// Type  : UIItemStorage
// Token : 0x2000008
// ============================================================

public class UIItemStorage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000019
    public int maxItemCount;

    // Token: 0x400001A
    public int maxRows;

    // Token: 0x400001B
    public int maxColumns;

    // Token: 0x400001C
    public GameObject template;

    // Token: 0x400001D
    public UIWidget background;

    // Token: 0x400001E
    public int spacing;

    // Token: 0x400001F
    public int padding;

    // Token: 0x4000020
    private List<InvGameItem> mItems;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600001C
    // RVA   : 0x10F3A60   Offset: 0x10F2260   Length: 0x77
    public List<InvGameItem> get_items()
    {
        long lVar1;
        lVar1 = this.mItems;
        while (lVar1 != null) {
          if (this.maxItemCount <= lVar1.Count) {
            return lVar1;
          }
          if (lVar1 == null) break;
          FUN_181827900(lVar1,0,DAT_181d68d70);
          lVar1 = this.mItems;
        }
    }

    // Token : 0x600001D
    // RVA   : 0x10F34F0   Offset: 0x10F1CF0   Length: 0x87
    public InvGameItem GetItem(int slot)
    {
        long lVar1;
        lVar1 = UIItemStorage.get_items(this,0);
        if (lVar1 != null) {
          if (lVar1.Count <= (int)slot) {
            return 0;
          }
          lVar1 = this.mItems;
          if (lVar1 != null) {
            if (lVar1.Count <= slot) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return lVar1._items[slot];
          }
        }
    }

    // Token : 0x600001E
    // RVA   : 0x10F3580   Offset: 0x10F1D80   Length: 0x10C
    public InvGameItem Replace(int slot, InvGameItem item)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (this.maxItemCount <= (int)slot) {
          return item;
        }
        lVar1 = this.mItems;
        do {
          if (lVar1 == null) {
        LAB_1810f3687:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (this.maxItemCount <= lVar1.Count) {
            lVar3 = lVar1;
            if (lVar1.Count <= slot) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.mItems;
            }
            uVar2 = lVar1._items[slot];
            if (lVar3 != null) {
              FUN_18182f280(lVar3,slot,item,DAT_181d68ef0);
              return uVar2;
            }
            goto LAB_1810f3687;
          }
          if (lVar1 == null) goto LAB_1810f3687;
          FUN_181827900(lVar1,0,DAT_181d68d70);
          lVar1 = this.mItems;
        } while( true );
    }

    // Token : 0x600001F
    // RVA   : 0x10F3690   Offset: 0x10F1E90   Length: 0x324
    private void Start()
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        int iVar7;
        int iVar8;
        int iVar9;
        float fVar10;
        float fVar11;
        float local_68;
        float local_64;
        uint local_60;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        uVar1 = this.template;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          iVar8 = 0;
          iVar9 = 0;
          local_48 = 0;
          uStack_40 = 0;
          local_38 = 0;
          if (0 < this.maxRows) {
            do {
              iVar7 = 0;
              if (0 < this.maxColumns) {
                do {
                  uVar3 = Component.get_gameObject(this,0);
                  uVar1 = this.template;
                  lVar4 = NGUITools.AddChild(uVar3,uVar1,0);
                  if (lVar4 == null) goto LAB_1810f39af;
                  lVar5 = GameObject.get_transform(lVar4,0);
                  if (lVar5 == null) goto LAB_1810f39af;
                  local_60 = 0;
                  local_68 = ((float)iVar7 + 0.5) * (float)this.spacing +
                             (float)this.padding;
                  local_64 = (float)-this.padding -
                             ((float)iVar8 + 0.5) * (float)this.spacing;
                  Transform.set_localPosition(lVar5,&local_68);
                  lVar4 = GameObject.GetComponent(lVar4,DAT_181da28b0);
                  cVar2 = Object.op_Inequality(lVar4,0);
                  if (cVar2) {
                    if (lVar4 == null) goto LAB_1810f39af;
                    *(int64 *)(lVar4 + 88) = this;
                    *(int *)(lVar4 + 96) = iVar9;
                  }
                  iVar7 = iVar7 + 1;
                  local_50 = 0;
                  fVar10 = (float)this.padding;
                  fVar11 = (float)-this.padding;
                  local_58 = CONCAT44((fVar11 + fVar11) - (float)((iVar8 + 1) * this.spacing),
                                      (float)(this.spacing * iVar7) + fVar10 + fVar10);
                  Bounds.Encapsulate(&local_48);
                  iVar9 = iVar9 + 1;
                  if (this.maxItemCount > iVar9)
                  {
                    } while (iVar7 < this.maxColumns);
                    }
                    iVar8 = iVar8 + 1;
                    } while (iVar8 < this.maxRows);
                    }
                  }
          uVar1 = this.background;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.background != null) {
              lVar4 = Component.get_transform(this.background,0);
              puVar6 = (uint64 *)Bounds.get_size(&local_68,&local_48,0);
              if (lVar4 != null) {
                local_50 = *(uint32 *)(puVar6 + 1);
                local_58 = *puVar6;
                Transform.set_localScale(lVar4,&local_58,0);
                return;
              }
            }
        LAB_1810f39af:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000020
    // RVA   : 0x10F39C0   Offset: 0x10F21C0   Length: 0x99
    public void /*ctor*/()
    {
        ulong uVar1;
        this.maxItemCount = 8;
        this.maxRows = 4;
        this.maxColumns = 4;
        this.spacing = 128;
        this.padding = 10;
        uVar1 = il2cpp_internal(DAT_181d6f330);
        FUN_180f58a90(uVar1,DAT_181d68cf0);
        this.mItems = uVar1;
        FUN_18044ef50(this,0);
    }

}
