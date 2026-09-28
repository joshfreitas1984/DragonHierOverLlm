// ============================================================
// Type  : <AsyncWaitForRewind>d__11
// Token : 0x2000485
// ============================================================

public class <AsyncWaitForRewind>d__11
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002147
    public int <>1__state;

    // Token: 0x4002148
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x4002149
    public Tween t;

    // Token: 0x400214A
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600275F
    // RVA   : 0x92B4E0   Offset: 0x92A8E0   Length: 0x1EB
    private virtual void MoveNext()
    {
        float fVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
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
        LAB_18092b567:
            lVar2 = *(int64 *)(this + 8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(lVar2 + 232) == false) ||
               ((*(char *)(lVar2 + 0x102) != false &&
                (fVar1 = *(float *)(lVar2 + 0x104), iVar4 = TweenExtensions.CompletedLoops(),
                (float)(iVar4 + 1) * fVar1 <= 0.0)))) goto LAB_18092b66a;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar3 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar3);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_180962960(this + 2,local_res18,this,DAT_181d85f78);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_18092b567;
          if (0 < **(int **)(DAT_181dbff70 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_18092b66a:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x6002760
    // RVA   : 0x21C390   Offset: 0x21B790   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
