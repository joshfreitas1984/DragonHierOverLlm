// ============================================================
// Type  : <PlayItemSound>d__56
// Token : 0x200025E
// ============================================================

public class <PlayItemSound>d__56
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012F4
    private int <>1__state;

    // Token: 0x40012F5
    private object <>2__current;

    // Token: 0x40012F6
    public float delayTime;

    // Token: 0x40012F7
    public GameObject targetItemIcon;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600139A
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600139B
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600139C
    // RVA   : 0x677820   Offset: 0x676620   Length: 0x1E9
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
            (lVar4 = GameObject.GetComponent(this.targetItemIcon,DAT_181e55168)) != null)
           && (*(int64 *)(lVar4 + 32) != 0)) {
          ItemData.PlayItemSound(*(int64 *)(lVar4 + 32),0);
          if (((this.targetItemIcon != null) &&
              (lVar4 = GameObject.GetComponent(this.targetItemIcon,DAT_181e55168)) != null)
             && (*(int64 *)(lVar4 + 32) != 0)) {
            iVar2 = *(int *)(*(int64 *)(lVar4 + 32) + 64);
            lVar4 = FUN_180210740(0);
            if ((lVar4 != null) && (*(int64 *)(lVar4 + 56) != 0)) {
              if (iVar2 < *(int *)(*(int64 *)(lVar4 + 56) + 24) + -1) {
                return false;
              }
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/LegendDrop",0);
              plVar6 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
                plVar6 = plVar5;
              }
              NGUITools.PlaySound(plVar6,0x3f000000,0);
              return false;
            }
          }
        }
    }

    // Token : 0x600139D
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600139E
    // RVA   : 0x677A10   Offset: 0x676810   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7df10);
    }

    // Token : 0x600139F
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
