// ============================================================
// Type  : <PlayItemSound>d__33
// Token : 0x2000376
// ============================================================

public class <PlayItemSound>d__33
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C8A
    private int <>1__state;

    // Token: 0x4001C8B
    private object <>2__current;

    // Token: 0x4001C8C
    public float delayTime;

    // Token: 0x4001C8D
    public GameObject targetItemIcon;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002241
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002242
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002243
    // RVA   : 0x611880   Offset: 0x610680   Length: 0x1E9
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

    // Token : 0x6002244
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002245
    // RVA   : 0x611A70   Offset: 0x610870   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e978e0);
    }

    // Token : 0x6002246
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
