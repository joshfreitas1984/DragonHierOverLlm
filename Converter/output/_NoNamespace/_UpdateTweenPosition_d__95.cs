// ============================================================
// Type  : <UpdateTweenPosition>d__95
// Token : 0x2000059
// ============================================================

public class <UpdateTweenPosition>d__95
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400021D
    private int <>1__state;

    // Token: 0x400021E
    private object <>2__current;

    // Token: 0x400021F
    public UIPopupList <>4__this;

    // Token: 0x4000220
    private TweenPosition <tp>5__2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001FB
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60001FC
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60001FD
    // RVA   : 0x617C90   Offset: 0x616A90   Length: 0x202
    private virtual bool MoveNext()
    {
        long lVar2;
        bool cVar3;
        ulong uVar4;
        byte[] local_18 = new byte[16];
        plVar1 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (plVar1 == (int64 *)0) throw; // [null/range check failed]
          lVar2 = plVar1[30];
          cVar3 = Object.op_Inequality(lVar2,0,0);
          if (!cVar3) goto LAB_180617e74;
          lVar2 = plVar1[31];
          cVar3 = Object.op_Inequality(lVar2,0,0);
          if (!cVar3) goto LAB_180617e74;
          if (plVar1[30] == 0) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(plVar1[30],DAT_181e79838);
          this.<tp>5__2 = uVar4;
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
        }
        uVar4 = this.<tp>5__2;
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (cVar3) {
          if (this.<tp>5__2 == 0) throw; // [null/range check failed]
          cVar3 = Behaviour.get_enabled(this.<tp>5__2,0);
          if (cVar3) {
            lVar2 = this.<tp>5__2;
            if ((plVar1 != (int64 *)0) &&
               (puVar5 = (uint64 *)
                         (**(code **)(*plVar1 + 0x248))(local_18,plVar1,*(uint64 *)(*plVar1 + 0x250)),
               lVar2 != null)) {
              *(uint64 *)(lVar2 + 132) = *puVar5;
              *(uint32 *)(lVar2 + 140) = *(uint32 *)(puVar5 + 1);
              this.<>2__current = 0;
              this.<>1__state = 1;
              return true;
            }
            throw; // [null/range check failed]
          }
        }
        this.<tp>5__2 = 0;
        if (plVar1 != (int64 *)0) {
        LAB_180617e74:
          *(uint8 *)((int64)plVar1 + 0x15a) = 0;
          return false;
        }
    }

    // Token : 0x60001FE
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60001FF
    // RVA   : 0x617EA0   Offset: 0x616CA0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e9ba20);
    }

    // Token : 0x6000200
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
