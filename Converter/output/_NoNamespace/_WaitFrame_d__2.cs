// ============================================================
// Type  : <WaitFrame>d__2
// Token : 0x20003D2
// ============================================================

public class <WaitFrame>d__2
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EDD
    private int <>1__state;

    // Token: 0x4001EDE
    private object <>2__current;

    // Token: 0x4001EDF
    public CFX_ShurikenThreadFix <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600249F
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60024A0
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60024A1
    // RVA   : 0x680860   Offset: 0x67F660   Length: 0xCF
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
                FUN_1801e02d0(uVar3,0);
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

    // Token : 0x60024A2
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60024A3
    // RVA   : 0x680930   Offset: 0x67F730   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7c590);
    }

    // Token : 0x60024A4
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
