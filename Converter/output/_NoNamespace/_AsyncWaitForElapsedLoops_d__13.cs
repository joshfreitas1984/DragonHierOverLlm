// ============================================================
// Type  : <AsyncWaitForElapsedLoops>d__13
// Token : 0x2000494
// ============================================================

public class <AsyncWaitForElapsedLoops>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021E3
    public int <>1__state;

    // Token: 0x40021E4
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x40021E5
    public Tween t;

    // Token: 0x40021E6
    public int elapsedLoops;

    // Token: 0x40021E7
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600280D
    // RVA   : 0x670ED0   Offset: 0x66FCD0   Length: 0x1B8
    private virtual void MoveNext()
    {
        bool cVar1;
        int iVar2;
        byte[] local_res18 = new byte[8];
        byte[] local_res20 = new byte[8];
        local_res18[0] = 0;
        local_res20[0] = 0;
        if (*this == 0) {
          local_res18[0] = (uint8)this[11];
          *(uint8 *)(this + 11) = 0;
          *this = -1;
          do {
            ZhSegment.Initialize(local_res18,0);
        LAB_180670f52:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((*(char *)(*(int64 *)(this + 8) + 232) == false) ||
               (iVar2 = TweenExtensions.CompletedLoops(), this[10] <= iVar2)) goto LAB_180671031;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 11) = local_res18[0];
          FUN_18076da10(this + 2,local_res18,this,DAT_181e69150);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_180670f52;
          if (0 < **(int **)(DAT_181ea0460 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_180671031:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x600280E
    // RVA   : 0x670EC0   Offset: 0x66FCC0   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_180670ec0(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
