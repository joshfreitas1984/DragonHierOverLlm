// ============================================================
// Type  : <AsyncWaitForCompletion>d__10
// Token : 0x2000484
// ============================================================

public class <AsyncWaitForCompletion>d__10
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002144
    public int <>1__state;

    // Token: 0x4002145
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x4002146
    public Tween t;

    // Token: 0x4002147
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600275D
    // RVA   : 0x92B420   Offset: 0x92A820   Length: 0x1B7
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
        LAB_18092b4a2:
            if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(*(int64 *)(this + 8) + 232) == false) ||
               (cVar1 = TweenExtensions.IsComplete(), cVar1)) goto LAB_18092b580;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar1 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar1);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_180962ff0(this + 2,local_res18,this,DAT_181d85d90);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_18092b4a2;
          if (0 < **(int **)(DAT_181dbff88 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_18092b580:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x600275E
    // RVA   : 0x21C390   Offset: 0x21B790   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
