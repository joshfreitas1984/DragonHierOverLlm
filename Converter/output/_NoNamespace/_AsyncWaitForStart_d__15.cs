// ============================================================
// Type  : <AsyncWaitForStart>d__15
// Token : 0x2000496
// ============================================================

public class <AsyncWaitForStart>d__15
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021ED
    public int <>1__state;

    // Token: 0x40021EE
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x40021EF
    public Tween t;

    // Token: 0x40021F0
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002811
    // RVA   : 0x671620   Offset: 0x670420   Length: 0x1B5
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
        LAB_1806716a2:
            lVar1 = *(int64 *)(this + 8);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((*(char *)(lVar1 + 232) == false) || (*(char *)(lVar1 + 0x102) != false))
            goto LAB_18067177e;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar2 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar2);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_18076da10(this + 2,local_res18,this,DAT_181e69350);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_1806716a2;
          if (0 < **(int **)(DAT_181ea0460 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_18067177e:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x6002812
    // RVA   : 0x670EC0   Offset: 0x66FCC0   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_180670ec0(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
