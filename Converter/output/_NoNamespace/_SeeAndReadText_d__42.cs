// ============================================================
// Type  : <SeeAndReadText>d__42
// Token : 0x2000334
// ============================================================

public class <SeeAndReadText>d__42
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019F3
    private int <>1__state;

    // Token: 0x40019F4
    private object <>2__current;

    // Token: 0x40019F5
    public GameObject target;

    // Token: 0x40019F6
    public ReadBookController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002000
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002001
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002002
    // RVA   : 0x8CFAE0   Offset: 0x8CE2E0   Length: 0x24A
    private virtual bool MoveNext()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if ((this.target != null) &&
             (lVar2 = GameObject.GetComponent(this.target,DAT_181da0a88)) != null)
          {
            if (*(char *)(lVar2 + 41) != false) {
              return false;
            }
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) {
              cVar1 = FUN_1818279a0(*(int64 *)(lVar3 + 88),this.target,
                                    DAT_181d61cf8);
              if (cVar1) {
                return false;
              }
              if (*(int64 *)(lVar3 + 88) != 0) {
                FUN_181827900(*(int64 *)(lVar3 + 88),this.target,DAT_181d61bf8);
                if ((this.target != null) &&
                   (lVar3 = GameObject.GetComponent(this.target,DAT_181da0a88),
                   lVar3 != null)) {
                  ReadBookTextController.SeeText(lVar3,0);
                  if (this.target != null) {
                    uVar4 = GameObject.get_transform(this.target,0);
                    uVar4 = ShortcutExtensions.DOShakePosition
                                      (uVar4,0x3f733333,0x41200000,10,0x42b40000,0,1,0);
                    TweenSettingsExtensions.SetEase(uVar4,9,DAT_181d97db8);
                    uVar4 = new WaitForSecondsRealtime(0x3f800000,0);
                    this.<>2__current = uVar4;
                    this.<>1__state = 1;
                    return true;
                  }
                }
              }
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((this.target != null) &&
             (lVar2 = GameObject.GetComponent(this.target,DAT_181da0a88)) != null)
          {
            if (*(char *)(lVar2 + 41) == false) {
              if ((this.target == null) ||
                 (lVar2 = GameObject.GetComponent(this.target,DAT_181da0a88),
                 lVar2 == null)) throw; // [null/range check failed]
              ReadBookTextController.ReadText(lVar2,0);
            }
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) {
              FUN_181801c10(*(int64 *)(lVar3 + 88),this.target,DAT_181d61e78);
              return false;
            }
          }
        }
    }

    // Token : 0x6002003
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002004
    // RVA   : 0x8CFD30   Offset: 0x8CE530   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d82528);
    }

    // Token : 0x6002005
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
