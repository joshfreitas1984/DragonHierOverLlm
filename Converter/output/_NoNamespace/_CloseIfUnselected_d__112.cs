// ============================================================
// Type  : <CloseIfUnselected>d__112
// Token : 0x200005A
// ============================================================

public class <CloseIfUnselected>d__112
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000221
    private int <>1__state;

    // Token: 0x4000222
    private object <>2__current;

    // Token: 0x4000223
    public UIPopupList <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000201
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000202
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000203
    // RVA   : 0x6097A0   Offset: 0x6085A0   Length: 0x256
    private virtual bool MoveNext()
    {
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        plVar1 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          goto LAB_180609809;
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          lVar4 = UICamera.get_selectedObject(0);
          if (plVar1 == (int64 *)0) {
        LAB_1806099f1:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = plVar1[34];
          cVar3 = Object.op_Inequality(lVar4,lVar2,0);
          if (!cVar3) {
        LAB_180609809:
            this.<>2__current = 0;
            this.<>1__state = 1;
            return true;
          }
          cVar3 = Object.op_Equality(lVar4,0,0);
          if (!cVar3) {
            uVar5 = UIPopupList.mChild;
            cVar3 = Object.op_Equality(lVar4,uVar5,0);
            if (cVar3) goto LAB_180609809;
            lVar2 = UIPopupList.mChild;
            if ((lVar2 == null) || (uVar5 = GameObject.get_transform(lVar2,0), lVar4 == null))
            goto LAB_1806099f1;
            uVar6 = GameObject.get_transform(lVar4,0);
            cVar3 = NGUITools.IsChild(uVar5,uVar6,0);
            if (cVar3) goto LAB_180609809;
          }
          (**(code **)(*plVar1 + 0x2d8))(plVar1,*(uint64 *)(*plVar1 + 0x2e0));
        }
        return false;
    }

    // Token : 0x6000204
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000205
    // RVA   : 0x609A00   Offset: 0x608800   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e9b998);
    }

    // Token : 0x6000206
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
