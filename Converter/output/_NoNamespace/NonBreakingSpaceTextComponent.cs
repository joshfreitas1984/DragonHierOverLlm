// ============================================================
// Type  : NonBreakingSpaceTextComponent
// Token : 0x200030F
// ============================================================

public class NonBreakingSpaceTextComponent
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001937
    public static readonly string no_breaking_space;

    // Token: 0x4001938
    protected Text text;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600196C
    // RVA   : 0xB8EDD0   Offset: 0xB8E1D0   Length: 0xB4
    private void Awake()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181d96160);
        this.text = uVar2;
        lVar1 = this.text;
        uVar2 = new OnTooltipCB(this,DAT_181d91a18,0);
        if (lVar1 != null) {
          Graphic.RegisterDirtyVerticesCallback(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x600196D
    // RVA   : 0xB8EE90   Offset: 0xB8E290   Length: 0xFE
    public void OnTextChange()
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        plVar1 = this.text;
        if ((plVar1 != (int64 *)0) &&
           (lVar3 = (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0))) != null)
        {
          cVar2 = String.Contains(lVar3," ",0);
          if (!cVar2) {
            return;
          }
          plVar1 = this.text;
          if (plVar1 != (int64 *)0) {
            lVar3 = (**(code **)(*plVar1 + 0x5d8))(plVar1,*(uint64 *)(*plVar1 + 0x5e0));
            if (lVar3 != null) {
              uVar4 = String.Replace(lVar3," ",**(uint64 **)(DAT_181d8d110 + 184),0);
              (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar4,*(uint64 *)(*plVar1 + 0x5f0));
              return;
            }
          }
        }
    }

    // Token : 0x600196E
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600196F
    // RVA   : 0xB8EF90   Offset: 0xB8E390   Length: 0x4D
    private static void /*cctor*/()
    {
        **(uint64 **)(DAT_181d8d110 + 184) = " ";
        il2cpp_internal();
    }

}
