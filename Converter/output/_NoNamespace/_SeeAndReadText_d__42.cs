// ============================================================
// Type  : <SeeAndReadText>d__42
// Token : 0x2000345
// ============================================================

public class <SeeAndReadText>d__42
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B65
    private int <>1__state;

    // Token: 0x4001B66
    private object <>2__current;

    // Token: 0x4001B67
    public GameObject target;

    // Token: 0x4001B68
    public ReadBookController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600211F
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002120
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002121
    // RVA   : 0x612390   Offset: 0x611190   Length: 0x24A
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
             (lVar2 = GameObject.GetComponent(this.target,DAT_181e55b80)) != null)
          {
            if (*(char *)(lVar2 + 41) != false) {
              return false;
            }
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) {
              cVar1 = FUN_18175e190(*(int64 *)(lVar3 + 88),this.target,
                                    DAT_181e6b7f8);
              if (cVar1) {
                return false;
              }
              if (*(int64 *)(lVar3 + 88) != 0) {
                FUN_18175de30(*(int64 *)(lVar3 + 88),this.target,DAT_181e6b6f8);
                if ((this.target != null) &&
                   (lVar3 = GameObject.GetComponent(this.target,DAT_181e55b80),
                   lVar3 != null)) {
                  ReadBookTextController.SeeText(lVar3,0);
                  if (this.target != null) {
                    uVar4 = GameObject.get_transform(this.target,0);
                    uVar4 = ShortcutExtensions.DOShakePosition
                                      (uVar4,0x3f733333,0x41200000,10,0x42b40000,0,1,0);
                    TweenSettingsExtensions.SetEase(uVar4,9,DAT_181ea4c98);
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
             (lVar2 = GameObject.GetComponent(this.target,DAT_181e55b80)) != null)
          {
            if (*(char *)(lVar2 + 41) == false) {
              if ((this.target == null) ||
                 (lVar2 = GameObject.GetComponent(this.target,DAT_181e55b80),
                 lVar2 == null)) throw; // [null/range check failed]
              ReadBookTextController.ReadText(lVar2,0);
            }
            if ((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) {
              FUN_181665e90(*(int64 *)(lVar3 + 88),this.target,DAT_181e6b978);
              return false;
            }
          }
        }
    }

    // Token : 0x6002122
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002123
    // RVA   : 0x6125E0   Offset: 0x6113E0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8ef88);
    }

    // Token : 0x6002124
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
