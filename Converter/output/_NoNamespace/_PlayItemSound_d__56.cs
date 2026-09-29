// ============================================================
// Type  : <PlayItemSound>d__56
// Token : 0x200025A
// ============================================================

public class <PlayItemSound>d__56
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012D6
    private int <>1__state;

    // Token: 0x40012D7
    private object <>2__current;

    // Token: 0x40012D8
    public float delayTime;

    // Token: 0x40012D9
    public GameObject targetItemIcon;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001376
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001377
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001378
    // RVA   : 0x931F30   Offset: 0x931330   Length: 0x1E9
    private virtual bool MoveNext()
    {
        uint uVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        if (this.<>1__state == 0) {
          uVar1 = this.delayTime;
          this.<>1__state = 0xffffffff;
          uVar3 = new WaitForSeconds(uVar1,0);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (((this.targetItemIcon != null) &&
            (lVar4 = GameObject.GetComponent(this.targetItemIcon,DAT_181d720a0)) != null)
           && (*(int64 *)(lVar4 + 32) != 0)) {
          ItemData.PlayItemSound(*(int64 *)(lVar4 + 32),0);
          if (((this.targetItemIcon != null) &&
              (lVar4 = GameObject.GetComponent(this.targetItemIcon,DAT_181d720a0)) != null)
             && (*(int64 *)(lVar4 + 32) != 0)) {
            iVar2 = *(int *)(*(int64 *)(lVar4 + 32) + 64);
            lVar4 = FUN_18046c100(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 56) != 0)) {
              if (iVar2 < *(int *)(*(int64 *)(lVar4 + 56) + 24) + -1) {
                return false;
              }
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/LegendDrop",0);
              plVar6 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf360)) {
                plVar6 = plVar5;
              }
              NGUITools.PlaySound(plVar6,0x3f000000,0);
              return false;
            }
          }
        }
    }

    // Token : 0x6001379
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600137A
    // RVA   : 0x932120   Offset: 0x931520   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d9a7d0);
    }

    // Token : 0x600137B
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
