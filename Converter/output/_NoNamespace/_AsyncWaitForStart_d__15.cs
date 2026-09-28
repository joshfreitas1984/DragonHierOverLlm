// ============================================================
// Type  : <AsyncWaitForStart>d__15
// Token : 0x2000489
// ============================================================

public class <AsyncWaitForStart>d__15
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002159
    public int <>1__state;

    // Token: 0x400215A
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x400215B
    public Tween t;

    // Token: 0x400215C
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002767
    // RVA   : 0x92B6D0   Offset: 0x92AAD0   Length: 0x1B5
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
        LAB_18092b752:
            lVar1 = *(int64 *)(this + 8);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(lVar1 + 232) == false) || (*(char *)(lVar1 + 0x102) != false))
            goto LAB_18092b82e;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar2 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar2);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_180962960(this + 2,local_res18,this,DAT_181d85ff8);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_18092b752;
          if (0 < **(int **)(DAT_181dbff70 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_18092b82e:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x6002768
    // RVA   : 0x21C390   Offset: 0x21B790   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
