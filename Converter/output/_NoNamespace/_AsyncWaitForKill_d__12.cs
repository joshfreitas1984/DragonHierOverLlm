// ============================================================
// Type  : <AsyncWaitForKill>d__12
// Token : 0x2000486
// ============================================================

public class <AsyncWaitForKill>d__12
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400214C
    public int <>1__state;

    // Token: 0x400214D
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x400214E
    public Tween t;

    // Token: 0x400214F
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002761
    // RVA   : 0x92B7A0   Offset: 0x92ABA0   Length: 0x1A5
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
        LAB_18092b81f:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(char *)(*(int64 *)(this + 8) + 232) == false) goto LAB_18092b8ee;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_180962ff0(this + 2,local_res18,this,DAT_181d85e90);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_18092b81f;
          if (0 < **(int **)(DAT_181dbff88 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_18092b8ee:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x6002762
    // RVA   : 0x21C390   Offset: 0x21B790   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
