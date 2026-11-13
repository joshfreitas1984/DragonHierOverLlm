// ============================================================
// Type  : <AsyncWaitForCompletion>d__10
// Token : 0x2000491
// ============================================================

public class <AsyncWaitForCompletion>d__10
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021D7
    public int <>1__state;

    // Token: 0x40021D8
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x40021D9
    public Tween t;

    // Token: 0x40021DA
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002807
    // RVA   : 0x670D00   Offset: 0x66FB00   Length: 0x1B7
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
        LAB_180670d82:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((*(char *)(*(int64 *)(this + 8) + 232) == false) ||
               (cVar1 = TweenExtensions.IsComplete(), cVar1)) goto LAB_180670e60;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_18076da10(this + 2,local_res18,this,DAT_181e690d0);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_180670d82;
          if (0 < **(int **)(DAT_181ea0460 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_180670e60:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x6002808
    // RVA   : 0x670EC0   Offset: 0x66FCC0   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_180670ec0(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
