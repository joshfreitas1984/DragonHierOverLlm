// ============================================================
// Type  : UIItemStorage
// Token : 0x2000008
// ============================================================

public class UIItemStorage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000015
    public int maxItemCount;

    // Token: 0x4000016
    public int maxRows;

    // Token: 0x4000017
    public int maxColumns;

    // Token: 0x4000018
    public GameObject template;

    // Token: 0x4000019
    public UIWidget background;

    // Token: 0x400001A
    public int spacing;

    // Token: 0x400001B
    public int padding;

    // Token: 0x400001C
    private List<InvGameItem> mItems;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600001B
    // RVA   : 0xF8A2C0   Offset: 0xF890C0   Length: 0x77
    public List<InvGameItem> get_items()
    {
        long lVar1;
        lVar1 = this.mItems;
        while (lVar1 != null) {
          if (this.maxItemCount <= lVar1.Count) {
            return lVar1;
          }
          if (lVar1 == null) break;
          FUN_18175de30(lVar1,0,DAT_181e726f0);
          lVar1 = this.mItems;
        }
    }

    // Token : 0x600001C
    // RVA   : 0xF89D50   Offset: 0xF88B50   Length: 0x87
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

    // Token : 0x600001D
    // RVA   : 0xF89DE0   Offset: 0xF88BE0   Length: 0x10C
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
        LAB_180f89ee7:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (this.maxItemCount <= lVar1.Count) {
            lVar3 = lVar1;
            if (lVar1.Count <= slot) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.mItems;
            }
            uVar2 = lVar1._items[slot];
            if (lVar3 != null) {
              FUN_181769c00(lVar3,slot,item,DAT_181e72870);
              return uVar2;
            }
            goto LAB_180f89ee7;
          }
          if (lVar1 == null) goto LAB_180f89ee7;
          FUN_18175de30(lVar1,0,DAT_181e726f0);
          lVar1 = this.mItems;
        } while( true );
    }

    // Token : 0x600001E
    // RVA   : 0xF89EF0   Offset: 0xF88CF0   Length: 0x324
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
                  if (lVar4 == null) goto LAB_180f8a20f;
                  lVar5 = GameObject.get_transform(lVar4,0);
                  if (lVar5 == null) goto LAB_180f8a20f;
                  local_60 = 0;
                  local_68 = ((float)iVar7 + 0.5) * (float)this.spacing +
                             (float)this.padding;
                  local_64 = (float)-this.padding -
                             ((float)iVar8 + 0.5) * (float)this.spacing;
                  Transform.set_localPosition(lVar5,&local_68);
                  lVar4 = GameObject.GetComponent(lVar4,DAT_181e57c70);
                  cVar2 = Object.op_Inequality(lVar4,0);
                  if (cVar2) {
                    if (lVar4 == null) goto LAB_180f8a20f;
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
        LAB_180f8a20f:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600001F
    // RVA   : 0xF8A220   Offset: 0xF89020   Length: 0x99
    public void /*ctor*/()
    {
        ulong uVar1;
        this.maxItemCount = 8;
        this.maxRows = 4;
        this.maxColumns = 4;
        this.spacing = 128;
        this.padding = 10;
        uVar1 = il2cpp_internal(DAT_181e73fb8);
        FUN_1810f3480(uVar1,DAT_181e72670);
        this.mItems = uVar1;
        FUN_180ae8740(this,0);
    }

}
