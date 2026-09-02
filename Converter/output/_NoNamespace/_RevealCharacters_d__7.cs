// ============================================================
// Type  : <RevealCharacters>d__7
// Token : 0x2000403
// ============================================================

public class <RevealCharacters>d__7
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EC7
    private int <>1__state;

    // Token: 0x4001EC8
    private object <>2__current;

    // Token: 0x4001EC9
    public TMP_Text textComponent;

    // Token: 0x4001ECA
    public TextConsoleSimulator <>4__this;

    // Token: 0x4001ECB
    private TMP_TextInfo <textInfo>5__2;

    // Token: 0x4001ECC
    private int <totalVisibleCharacters>5__3;

    // Token: 0x4001ECD
    private int <visibleCount>5__4;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600247C
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600247D
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600247E
    // RVA   : 0xB13190   Offset: 0xB11990   Length: 0x197
    private virtual bool MoveNext()
    {
        long lVar1;
        ulong uVar3;
        int iVar4;
        iVar4 = this.<>1__state;
        lVar1 = this.<>4__this;
        if (iVar4 == 0) {
          plVar2 = this.textComponent;
          this.<>1__state = 0xffffffff;
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar2 + 0x7d8))(plVar2,0,0,*(uint64 *)(*plVar2 + 0x7e0));
          if (this.textComponent == null) throw; // [null/range check failed]
          this.<textInfo>5__2 = *(uint64 *)(this.textComponent + 0x368);
          if (this.<textInfo>5__2 == 0) throw; // [null/range check failed]
          this.<totalVisibleCharacters>5__3 = *(uint32 *)(this.<textInfo>5__2 + 24);
          this.<visibleCount>5__4 = 0;
        LAB_180b13267:
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(char *)(lVar1 + 32) != false) {
            if (this.<textInfo>5__2 == 0) throw; // [null/range check failed]
            this.<totalVisibleCharacters>5__3 = *(uint32 *)(this.<textInfo>5__2 + 24);
            *(uint8 *)(lVar1 + 32) = 0;
          }
          iVar4 = this.<visibleCount>5__4;
          if (this.<totalVisibleCharacters>5__3 < iVar4) {
            uVar3 = new WaitForSeconds(0x3f800000,0);
            this.<>2__current = uVar3;
            this.<>1__state = 1;
            return true;
          }
        }
        else {
          if (iVar4 != 1) {
            if (iVar4 != 2) {
              return false;
            }
            this.<>1__state = 0xffffffff;
            goto LAB_180b13267;
          }
          this.<>1__state = 0xffffffff;
          iVar4 = 0;
          this.<visibleCount>5__4 = 0;
        }
        if (this.textComponent != null) {
          TMP_Text.set_maxVisibleCharacters(this.textComponent,iVar4,0);
          this.<visibleCount>5__4 = this.<visibleCount>5__4 + 1;
          this.<>2__current = 0;
          this.<>1__state = 2;
          return true;
        }
    }

    // Token : 0x600247F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002480
    // RVA   : 0xB13330   Offset: 0xB11B30   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8cd60);
    }

    // Token : 0x6002481
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
