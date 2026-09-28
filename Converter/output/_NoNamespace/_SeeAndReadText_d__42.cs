// ============================================================
// Type  : <SeeAndReadText>d__42
// Token : 0x200033B
// ============================================================

public class <SeeAndReadText>d__42
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AEA
    private int <>1__state;

    // Token: 0x4001AEB
    private object <>2__current;

    // Token: 0x4001AEC
    public GameObject target;

    // Token: 0x4001AED
    public ReadBookController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002080
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002081
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002082
    // RVA   : 0x8F1D60   Offset: 0x8F1160   Length: 0x24A
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
             (lVar2 = GameObject.GetComponent(this.target,DAT_181d72ab8)) != null)
          {
            if (*(char *)(lVar2 + 41) != false) {
              return false;
            }
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) {
              cVar1 = FUN_18181e400(*(int64 *)(lVar3 + 88),this.target,
                                    DAT_181d89498);
              if (cVar1) {
                return false;
              }
              if (*(int64 *)(lVar3 + 88) != 0) {
                FUN_18181e0a0(*(int64 *)(lVar3 + 88),this.target,DAT_181d89398);
                if ((this.target != null) &&
                   (lVar3 = GameObject.GetComponent(this.target,DAT_181d72ab8),
                   lVar3 != null)) {
                  ReadBookTextController.SeeText(lVar3,0);
                  if (this.target != null) {
                    uVar4 = GameObject.get_transform(this.target,0);
                    uVar4 = ShortcutExtensions.DOShakePosition
                                      (uVar4,0x3f733333,0x41200000,10,0x42b40000,0,1,0);
                    TweenSettingsExtensions.SetEase(uVar4,9,DAT_181dc1088);
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
             (lVar2 = GameObject.GetComponent(this.target,DAT_181d72ab8)) != null)
          {
            if (*(char *)(lVar2 + 41) == false) {
              if ((this.target == null) ||
                 (lVar2 = GameObject.GetComponent(this.target,DAT_181d72ab8),
                 lVar2 == null)) throw; // [null/range check failed]
              ReadBookTextController.ReadText(lVar2,0);
            }
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) {
              FUN_1817eee00(*(int64 *)(lVar3 + 88),this.target,DAT_181d89618);
              return false;
            }
          }
        }
    }

    // Token : 0x6002083
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002084
    // RVA   : 0x8F1FB0   Offset: 0x8F13B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181dab448);
    }

    // Token : 0x6002085
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
