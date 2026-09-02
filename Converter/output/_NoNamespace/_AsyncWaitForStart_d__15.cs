// ============================================================
// Type  : <AsyncWaitForStart>d__15
// Token : 0x2000482
// ============================================================

public class <AsyncWaitForStart>d__15
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400204F
    public int <>1__state;

    // Token: 0x4002050
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x4002051
    public Tween t;

    // Token: 0x4002052
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026E4
    // RVA   : 0x8C7E00   Offset: 0x8C6600   Length: 0x1B5
    private virtual void MoveNext()
    {
        long lVar1;
        bool cVar2;
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
        LAB_1808c7e82:
            lVar1 = *(int64 *)(this + 8);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(lVar1 + 232) == false) || (*(char *)(lVar1 + 0x102) != false))
            goto LAB_1808c7f5e;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar2 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar2);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_180952070(this + 2,local_res18,this,DAT_181d5d7d8);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_1808c7e82;
          if (0 < **(int **)(DAT_181d9adc0 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_1808c7f5e:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x60026E5
    // RVA   : 0x21C390   Offset: 0x21AB90   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
