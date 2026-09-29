// ============================================================
// Type  : <RevealWords>d__8
// Token : 0x200040B
// ============================================================

public class <RevealWords>d__8
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001FD9
    private int <>1__state;

    // Token: 0x4001FDA
    private object <>2__current;

    // Token: 0x4001FDB
    public TMP_Text textComponent;

    // Token: 0x4001FDC
    private int <totalWordCount>5__2;

    // Token: 0x4001FDD
    private int <totalVisibleCharacters>5__3;

    // Token: 0x4001FDE
    private int <counter>5__4;

    // Token: 0x4001FDF
    private int <visibleCount>5__5;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002505
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002506
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002507
    // RVA   : 0x9249A0   Offset: 0x923DA0   Length: 0x1F6
    private virtual bool MoveNext()
    {
        int iVar1;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar1 = this.<>1__state;
        iVar5 = 0;
        if (iVar1 == 0) {
          plVar2 = this.textComponent;
          this.<>1__state = 0xffffffff;
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar2 + 0x7d8))(plVar2,0,0,*(uint64 *)(*plVar2 + 0x7e0));
          lVar3 = this.textComponent;
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) throw; // [null/range check failed]
          iVar1 = *(int *)(*(int64 *)(lVar3 + 0x368) + 36);
          this.<totalWordCount>5__2 = iVar1;
          if (*(int64 *)(lVar3 + 0x368) == 0) throw; // [null/range check failed]
          this.<totalVisibleCharacters>5__3 = *(uint32 *)(*(int64 *)(lVar3 + 0x368) + 24);
          this.<counter>5__4 = 0;
        }
        else {
          if (iVar1 == 1) {
            this.<>1__state = 0xffffffff;
            goto LAB_180924af4;
          }
          if (iVar1 != 2) {
            return false;
          }
          iVar1 = this.<totalWordCount>5__2;
          iVar5 = this.<counter>5__4;
          this.<>1__state = 0xffffffff;
        }
        iVar5 = iVar5 % (iVar1 + 1);
        if (iVar5 == 0) {
          this.<visibleCount>5__5 = 0;
        }
        else if (iVar5 < iVar1) {
          if (((this.textComponent == null) ||
              (lVar3 = *(int64 *)(this.textComponent + 0x368)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 64)) == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar3 + 24) <= (uint32)((int64)iVar5 + -1)) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          this.<visibleCount>5__5 = *(int *)(lVar3 + 44 + ((int64)iVar5 + -1) * 24) + 1;
        }
        else if (iVar5 == iVar1) {
          this.<visibleCount>5__5 = this.<totalVisibleCharacters>5__3;
        }
        if (this.textComponent != null) {
          TMP_Text.set_maxVisibleCharacters
                    (this.textComponent,this.<visibleCount>5__5,0);
          if (this.<totalVisibleCharacters>5__3 <= this.<visibleCount>5__5) {
            uVar4 = new WaitForSeconds(0x3f800000,0);
            this.<>2__current = uVar4;
            this.<>1__state = 1;
            return true;
          }
        LAB_180924af4:
          this.<counter>5__4 = this.<counter>5__4 + 1;
          uVar4 = new WaitForSeconds(0x3dcccccd,0);
          this.<>2__current = uVar4;
          this.<>1__state = 2;
          return true;
        }
    }

    // Token : 0x6002508
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002509
    // RVA   : 0x924BA0   Offset: 0x923FA0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181db6308);
    }

    // Token : 0x600250A
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
