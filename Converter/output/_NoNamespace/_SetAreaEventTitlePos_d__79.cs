// ============================================================
// Type  : <SetAreaEventTitlePos>d__79
// Token : 0x2000140
// ============================================================

public class <SetAreaEventTitlePos>d__79
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007F0
    private int <>1__state;

    // Token: 0x40007F1
    private object <>2__current;

    // Token: 0x40007F2
    public AreaController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A64
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000A65
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000A66
    // RVA   : 0xB26470   Offset: 0xB24C70   Length: 0x191
    private virtual bool MoveNext()
    {
        var plVar2 = *(int64*)(lVar2 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        ulong local_18;
        uint local_10;
        iVar1 = this.<>1__state;
        lVar2 = this.<>4__this;
        if (iVar1 == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 0;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar5;
          this.<>1__state = 1;
          return true;
        }
        if (iVar1 == 1) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 0;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar5;
          this.<>1__state = 2;
          return true;
        }
        if (iVar1 != 2) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (((lVar2 != null) && (*(int64 *)(lVar2 + 128) != 0)) &&
           (lVar3 = GameObject.get_transform(*(int64 *)(lVar2 + 128),0)) != null) {
          lVar3 = Transform.Find(lVar3,"EventTitle",0);
          if (plVar2 != 0) {
            if (*(int *)(plVar2 + 24) < 1) {
              puVar4 = (uint64 *)Vector3.get_zero(&local_18);
            }
            else {
              puVar4 = (uint64 *)Vector3.get_one();
            }
            local_10 = *(uint32 *)(puVar4 + 1);
            local_18 = *puVar4;
            if (lVar3 != null) {
              Transform.set_localScale(lVar3,&local_18,0);
              return false;
            }
          }
        }
    }

    // Token : 0x6000A67
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000A68
    // RVA   : 0xB26610   Offset: 0xB24E10   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6c598);
    }

    // Token : 0x6000A69
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
