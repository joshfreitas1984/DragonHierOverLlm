// ============================================================
// Type  : <AsyncWaitForElapsedLoops>d__13
// Token : 0x2000487
// ============================================================

public class <AsyncWaitForElapsedLoops>d__13
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400214F
    public int <>1__state;

    // Token: 0x4002150
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x4002151
    public Tween t;

    // Token: 0x4002152
    public int elapsedLoops;

    // Token: 0x4002153
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002763
    // RVA   : 0x92AF80   Offset: 0x92A380   Length: 0x1B8
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
        LAB_18092b002:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(*(int64 *)(this + 8) + 232) == false) ||
               (iVar2 = TweenExtensions.CompletedLoops(), this[10] <= iVar2)) goto LAB_18092b0e1;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 11) = local_res18[0];
          FUN_180962960(this + 2,local_res18,this,DAT_181d85df8);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_18092b002;
          if (0 < **(int **)(DAT_181dbff70 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_18092b0e1:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x6002764
    // RVA   : 0x21C390   Offset: 0x21B790   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
