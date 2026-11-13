// ============================================================
// Type  : NonBreakingSpaceTextComponent
// Token : 0x2000319
// ============================================================

public class NonBreakingSpaceTextComponent
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019B1
    public static readonly string no_breaking_space;

    // Token: 0x40019B2
    protected Text text;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001A02
    // RVA   : 0x90C380   Offset: 0x90B180   Length: 0xB4
    private void Awake()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181e79538);
        this.text = uVar2;
        lVar1 = this.text;
        uVar2 = new OnTooltipCB(this,DAT_181e74ef8,0);
        if (lVar1 != null) {
          Graphic.RegisterDirtyVerticesCallback(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6001A03
    // RVA   : 0x90C440   Offset: 0x90B240   Length: 0xFE
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
              uVar4 = String.Replace(lVar3," ",**(uint64 **)(DAT_181e6d4e8 + 184),0);
              (**(code **)(*plVar1 + 0x5e8))(plVar1,uVar4,*(uint64 *)(*plVar1 + 0x5f0));
              return;
            }
          }
        }
    }

    // Token : 0x6001A04
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6001A05
    // RVA   : 0x90C540   Offset: 0x90B340   Length: 0x4D
    private static void /*cctor*/()
    {
        **(uint64 **)(DAT_181e6d4e8 + 184) = " ";
        il2cpp_internal();
    }

}
