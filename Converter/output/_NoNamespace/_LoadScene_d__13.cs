// ============================================================
// Type  : <LoadScene>d__13
// Token : 0x2000307
// ============================================================

public class <LoadScene>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001908
    private int <>1__state;

    // Token: 0x4001909
    private object <>2__current;

    // Token: 0x400190A
    public LoadSceneController <>4__this;

    // Token: 0x400190B
    public string sceneName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001957
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001958
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001959
    // RVA   : 0x610300   Offset: 0x60F100   Length: 0xDE
    private virtual bool MoveNext()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.<>4__this;
        if (this.<>1__state == 0) {
          uVar2 = this.sceneName;
          this.<>1__state = 0xffffffff;
          uVar2 = SceneManager.LoadSceneAsync(uVar2,0);
          if (lVar1 != null) {
            *(uint64 *)(lVar1 + 24) = uVar2;
            if (*(int64 *)(lVar1 + 24) != 0) {
              AsyncOperation.set_allowSceneActivation(*(int64 *)(lVar1 + 24),0,0);
              this.<>2__current = *(uint64 *)(lVar1 + 24);
              this.<>1__state = 1;
              return true;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
        }
        return false;
    }

    // Token : 0x600195A
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600195B
    // RVA   : 0x6103E0   Offset: 0x60F1E0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8b720);
    }

    // Token : 0x600195C
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
