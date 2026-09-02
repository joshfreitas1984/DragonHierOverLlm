// ============================================================
// Type  : <AsyncWaitForElapsedLoops>d__13
// Token : 0x2000480
// ============================================================

public class <AsyncWaitForElapsedLoops>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002045
    public int <>1__state;

    // Token: 0x4002046
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x4002047
    public Tween t;

    // Token: 0x4002048
    public int elapsedLoops;

    // Token: 0x4002049
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026E0
    // RVA   : 0x8C76B0   Offset: 0x8C5EB0   Length: 0x1B8
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
        LAB_1808c7732:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(*(int64 *)(this + 8) + 232) == false) ||
               (iVar2 = TweenExtensions.CompletedLoops(), this[10] <= iVar2)) goto LAB_1808c7811;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 11) = local_res18[0];
          FUN_180952070(this + 2,local_res18,this,DAT_181d5d5d8);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_1808c7732;
          if (0 < **(int **)(DAT_181d9adc0 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_1808c7811:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x60026E1
    // RVA   : 0x21C390   Offset: 0x21AB90   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
