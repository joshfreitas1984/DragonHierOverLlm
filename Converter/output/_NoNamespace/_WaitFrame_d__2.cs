// ============================================================
// Type  : <WaitFrame>d__2
// Token : 0x20003BE
// ============================================================

public class <WaitFrame>d__2
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D40
    private int <>1__state;

    // Token: 0x4001D41
    private object <>2__current;

    // Token: 0x4001D42
    public CFX_ShurikenThreadFix <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002372
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002373
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002374
    // RVA   : 0x8D8A40   Offset: 0x8D7240   Length: 0xCF
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          this.<>2__current = 0;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (this.<>4__this != 0) {
          lVar1 = *(int64 *)(this.<>4__this + 24);
          uVar4 = 0;
          if (lVar1 != null) {
            while( true ) {
              if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar4) {
                return false;
              }
              if (*(uint32 *)(lVar1 + 24) <= uVar4) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar2 = lVar1[uVar4];
              if (lVar2 == null) break;
              ParticleSystem.set_enableEmission(lVar2,1,0);
              ParticleSystem.Play(lVar2);
              uVar4 = uVar4 + 1;
            }
          }
        }
    }

    // Token : 0x6002375
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002376
    // RVA   : 0x8D8B10   Offset: 0x8D7310   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6fe18);
    }

    // Token : 0x6002377
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
