// ============================================================
// Type  : <AsyncWaitForKill>d__12
// Token : 0x2000493
// ============================================================

public class <AsyncWaitForKill>d__12
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021DF
    public int <>1__state;

    // Token: 0x40021E0
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x40021E1
    public Tween t;

    // Token: 0x40021E2
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600280B
    // RVA   : 0x671090   Offset: 0x66FE90   Length: 0x1A5
    private virtual void MoveNext()
    {
        bool cVar1;
        byte[] local_res18 = new byte[8];
        byte[] local_res20 = new byte[8];
        local_res18[0] = 0;
        local_res20[0] = 0;
        if (*this == 0) {
          local_res18[0] = (uint8)this[10];
          *(uint8 *)(this + 10) = 0;
          *this = -1;
          do {
            ZhSegment.Initialize(local_res18,0);
        LAB_18067110f:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if (*(char *)(*(int64 *)(this + 8) + 232) == false) goto LAB_1806711de;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_18076da10(this + 2,local_res18,this,DAT_181e691d0);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_18067110f;
          if (0 < **(int **)(DAT_181ea0460 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_1806711de:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x600280C
    // RVA   : 0x670EC0   Offset: 0x66FCC0   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_180670ec0(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
