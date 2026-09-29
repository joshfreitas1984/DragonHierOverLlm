// ============================================================
// Type  : <LoadScene>d__13
// Token : 0x20002FE
// ============================================================

public class <LoadScene>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018B2
    private int <>1__state;

    // Token: 0x40018B3
    private object <>2__current;

    // Token: 0x40018B4
    public LoadSceneController <>4__this;

    // Token: 0x40018B5
    public string sceneName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018DB
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60018DC
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60018DD
    // RVA   : 0x922C70   Offset: 0x922070   Length: 0xDE
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
          FUN_1800d6620();
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
        }
        return false;
    }

    // Token : 0x60018DE
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60018DF
    // RVA   : 0x922D50   Offset: 0x922150   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181da7d60);
    }

    // Token : 0x60018E0
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
