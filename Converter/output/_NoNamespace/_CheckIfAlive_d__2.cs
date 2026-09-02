// ============================================================
// Type  : <CheckIfAlive>d__2
// Token : 0x20003B9
// ============================================================

public class <CheckIfAlive>d__2
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D33
    private int <>1__state;

    // Token: 0x4001D34
    private object <>2__current;

    // Token: 0x4001D35
    public CFX_AutoDestructShuriken <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002361
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002362
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002363
    // RVA   : 0x8C8B90   Offset: 0x8C7390   Length: 0x14C
    private virtual bool MoveNext()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        lVar4 = this.<>4__this;
        if (this.<>1__state != 0) {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((lVar4 != null) && (lVar2 = Component.GetComponent(lVar4,DAT_181d6c340)) != null) {
            cVar1 = ParticleSystem.IsAlive(lVar2,1,0);
            if (cVar1) goto LAB_1808c8c27;
            if (*(char *)(lVar4 + 24) == false) {
              uVar3 = Component.get_gameObject(lVar4);
              Object.Destroy(uVar3,0);
              return false;
            }
            lVar4 = Component.get_gameObject(lVar4);
            if (lVar4 != null) {
              GameObject.SetActive(lVar4,0,0);
              return false;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        this.<>1__state = 0xffffffff;
        LAB_1808c8c27:
        uVar3 = new WaitForSeconds(0x3f000000,0);
        this.<>2__current = uVar3;
        this.<>1__state = 1;
        return true;
    }

    // Token : 0x6002364
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002365
    // RVA   : 0x8C8CE0   Offset: 0x8C74E0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6fd18);
    }

    // Token : 0x6002366
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
