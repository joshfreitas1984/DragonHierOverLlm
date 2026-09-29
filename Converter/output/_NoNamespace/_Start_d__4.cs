// ============================================================
// Type  : <Start>d__4
// Token : 0x2000408
// ============================================================

public class <Start>d__4
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001FCB
    private int <>1__state;

    // Token: 0x4001FCC
    private object <>2__current;

    // Token: 0x4001FCD
    public TeleType <>4__this;

    // Token: 0x4001FCE
    private int <totalVisibleCharacters>5__2;

    // Token: 0x4001FCF
    private int <counter>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024F1
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60024F2
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60024F3
    // RVA   : 0x927850   Offset: 0x926C50   Length: 0x29D
    private virtual bool MoveNext()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        iVar1 = this.<>1__state;
        lVar3 = this.<>4__this;
        if (iVar1 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar3 == null) || (plVar4 = *(int64 **)(lVar3 + 40), plVar4 == (int64 *)0))
          throw; // [null/range check failed]
          (**(code **)(*plVar4 + 0x7d8))(plVar4,0,0,*(uint64 *)(*plVar4 + 0x7e0));
          if ((*(int64 *)(lVar3 + 40) == 0) ||
             (lVar5 = *(int64 *)(*(int64 *)(lVar3 + 40) + 0x368)) == null) throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar5 + 24);
          uVar7 = 0;
          this.<counter>5__3 = 0;
          this.<totalVisibleCharacters>5__2 = uVar2;
        }
        else {
          if (iVar1 == 1) {
            this.<>1__state = 0xffffffff;
            if ((lVar3 != null) && (plVar4 = *(int64 **)(lVar3 + 40), plVar4 != (int64 *)0)) {
              (**(code **)(*plVar4 + 0x558))
                        (plVar4,*(uint64 *)(lVar3 + 32),*(uint64 *)(*plVar4 + 0x560));
              uVar6 = new WaitForSeconds(0x3f800000,0);
              this.<>2__current = uVar6;
              this.<>1__state = 2;
              return true;
            }
            throw; // [null/range check failed]
          }
          if (iVar1 == 2) {
            this.<>1__state = 0xffffffff;
            if ((lVar3 != null) && (plVar4 = *(int64 **)(lVar3 + 40), plVar4 != (int64 *)0)) {
              (**(code **)(*plVar4 + 0x558))
                        (plVar4,*(uint64 *)(lVar3 + 24),*(uint64 *)(*plVar4 + 0x560));
              uVar6 = new WaitForSeconds(0x3f800000,0);
              this.<>2__current = uVar6;
              this.<>1__state = 3;
              return true;
            }
            throw; // [null/range check failed]
          }
          if (iVar1 == 3) {
            this.<>1__state = 0xffffffff;
            goto LAB_180927a51;
          }
          if (iVar1 != 4) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          uVar7 = (int64)this.<counter>5__3 % (int64)(this.<totalVisibleCharacters>5__2 + 1) &
                  0xffffffff;
          if (lVar3 == null) throw; // [null/range check failed]
        }
        if (*(int64 *)(lVar3 + 40) != 0) {
          TMP_Text.set_maxVisibleCharacters(*(int64 *)(lVar3 + 40),uVar7,0);
          if (this.<totalVisibleCharacters>5__2 <= (int)uVar7) {
            uVar6 = new WaitForSeconds(0x3f800000,0);
            this.<>2__current = uVar6;
            this.<>1__state = 1;
            return true;
          }
        LAB_180927a51:
          this.<counter>5__3 = this.<counter>5__3 + 1;
          uVar6 = new WaitForSeconds(0x3d4ccccd,0);
          this.<>2__current = uVar6;
          this.<>1__state = 4;
          return true;
        }
    }

    // Token : 0x60024F4
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60024F5
    // RVA   : 0x927AF0   Offset: 0x926EF0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181db6170);
    }

    // Token : 0x60024F6
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
