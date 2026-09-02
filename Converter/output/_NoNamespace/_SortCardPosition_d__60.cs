// ============================================================
// Type  : <SortCardPosition>d__60
// Token : 0x200025E
// ============================================================

public class <SortCardPosition>d__60
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400128D
    private int <>1__state;

    // Token: 0x400128E
    private object <>2__current;

    // Token: 0x400128F
    public Transform targetCardGrid;

    // Token: 0x4001290
    public bool isPlayer;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001371
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001372
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001373
    // RVA   : 0x8D04D0   Offset: 0x8CECD0   Length: 0x26B
    private virtual bool MoveNext()
    {
        long lVar1;
        int iVar2;
        ulong uVar3;
        int iVar4;
        float fVar5;
        uint[] local_res8 = new uint[2];
        float local_98;
        float local_94;
        uint local_90;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        lVar1 = this.targetCardGrid;
        iVar4 = 0;
        this.<>1__state = 0xffffffff;
        while (lVar1 != null) {
          iVar2 = Transform.get_childCount(lVar1,0);
          if (iVar2 <= iVar4) {
            return false;
          }
          if (this.targetCardGrid == null) break;
          uVar3 = Transform.GetChild(this.targetCardGrid,iVar4,0);
          if (!this.isPlayer) {
            fVar5 = 10.0;
          }
          else {
            fVar5 = -10.0;
          }
          if (this.targetCardGrid == null) break;
          Transform.get_childCount(this.targetCardGrid,0);
          iVar2 = Mathf.FloorToInt();
          if (this.targetCardGrid == null) break;
          local_98 = (float)iVar2 * fVar5;
          iVar2 = Transform.get_childCount(this.targetCardGrid,0);
          local_90 = 0;
          local_94 = ((float)(iVar2 + -1) * 0.5 - (float)iVar4) * 50.0;
          ShortcutExtensions.DOLocalMove(uVar3,&local_98,0x3e800000,0,0);
          iVar4 = iVar4 + 1;
          lVar1 = this.targetCardGrid;
        }
    }

    // Token : 0x6001374
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001375
    // RVA   : 0x8D0740   Offset: 0x8CEF40   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d77008);
    }

    // Token : 0x6001376
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
