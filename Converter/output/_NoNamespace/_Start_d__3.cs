// ============================================================
// Type  : <Start>d__3
// Token : 0x2000016
// ============================================================

public class <Start>d__3
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400006B
    private int <>1__state;

    // Token: 0x400006C
    private object <>2__current;

    // Token: 0x400006D
    public DownloadTexture <>4__this;

    // Token: 0x400006E
    private UnityWebRequest <www>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600004D
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600004E
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600004F
    // RVA   : 0x8D30F0   Offset: 0x8D18F0   Length: 0x182
    private virtual bool MoveNext()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        lVar1 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar1 != null) {
            uVar3 = UnityWebRequest.Get(*(uint64 *)(lVar1 + 24),0);
            this.<www>5__2 = uVar3;
            if (this.<www>5__2 != 0) {
              uVar3 = UnityWebRequest.SendWebRequest(this.<www>5__2,0);
              this.<>2__current = uVar3;
              this.<>1__state = 1;
              return true;
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          uVar3 = DownloadHandlerTexture.GetContent(this.<www>5__2,0);
          if (lVar1 != null) {
            *(uint64 *)(lVar1 + 40) = uVar3;
            uVar3 = *(uint64 *)(lVar1 + 40);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (cVar2) {
              plVar4 = (int64 *)Component.GetComponent(lVar1,DAT_181d6e6c0);
              if (plVar4 == (int64 *)0) throw; // [null/range check failed]
              (**(code **)(*plVar4 + 0x2f8))
                        (plVar4,*(uint64 *)(lVar1 + 40),*(uint64 *)(*plVar4 + 0x300));
              if (*(char *)(lVar1 + 32) != false) {
                (**(code **)(*plVar4 + 0x348))(plVar4,*(uint64 *)(*plVar4 + 0x350));
              }
            }
            if (this.<www>5__2 != 0) {
              UnityWebRequest.Dispose(this.<www>5__2,0);
              return false;
            }
          }
        }
    }

    // Token : 0x6000050
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000051
    // RVA   : 0x8D3280   Offset: 0x8D1A80   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d77a88);
    }

    // Token : 0x6000052
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
