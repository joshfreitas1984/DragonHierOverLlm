// ============================================================
// Type  : <AsyncWaitForRewind>d__11
// Token : 0x200047E
// ============================================================

public class <AsyncWaitForRewind>d__11
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400203D
    public int <>1__state;

    // Token: 0x400203E
    public AsyncTaskMethodBuilder <>t__builder;

    // Token: 0x400203F
    public Tween t;

    // Token: 0x4002040
    private YieldAwaiter <>u__1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026DC
    // RVA   : 0x8C7C10   Offset: 0x8C6410   Length: 0x1EB
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
        LAB_1808c7c97:
            lVar2 = *(int64 *)(this + 8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if ((*(char *)(lVar2 + 232) == false) ||
               ((*(char *)(lVar2 + 0x102) != false &&
                (fVar1 = *(float *)(lVar2 + 0x104), iVar4 = TweenExtensions.CompletedLoops(),
                (float)(iVar4 + 1) * fVar1 <= 0.0)))) goto LAB_1808c7d9a;
            local_res20[0] = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(0)
            ;
            local_res18[0] =
                 CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly(local_res20);
            cVar3 = CircularBuffer_1__System_Collections_Generic_ICollection_T.get_IsReadOnly
                              (local_res18);
          } while (cVar3);
          *this = 0;
          *(uint8 *)(this + 10) = local_res18[0];
          FUN_180952070(this + 2,local_res18,this,DAT_181d5d758);
        }
        else {
          if (*(int64 *)(this + 8) == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(char *)(*(int64 *)(this + 8) + 232) != false) goto LAB_1808c7c97;
          if (0 < **(int **)(DAT_181d9adc0 + 184)) {
            Debugger.LogInvalidTween(*(uint64 *)(this + 8),0);
          }
        LAB_1808c7d9a:
          *this = -2;
          AsyncTaskMethodBuilder.SetResult(this + 2,0);
        }
    }

    // Token : 0x60026DD
    // RVA   : 0x21C390   Offset: 0x21AB90   Length: 0xC
    private virtual void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        void FUN_18021c390(int64 this,uint64 stateMachine)
        {
        AsyncTaskMethodBuilder.SetStateMachine(this + 8,stateMachine,0);
    }

}
