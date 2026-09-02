// ============================================================
// Type  : MoveTowardTarget
// Token : 0x2000305
// ============================================================

public class MoveTowardTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400183C
    public GameObject target;

    // Token: 0x400183D
    public float moveTime;

    // Token: 0x400183E
    private Tweener tweener;

    // Token: 0x400183F
    private float startTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001901
    // RVA   : 0xAF9770   Offset: 0xAF7F70   Length: 0x126
    private void Start()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar4;
        uint uVar5;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        uVar5 = RealTime.get_time(0);
        this.startTime = uVar5;
        uVar1 = Component.get_transform(this,0);
        if (this.target != null) {
          lVar2 = GameObject.get_transform(this.target,0);
          if (lVar2 != null) {
            uVar5 = this.moveTime;
            puVar3 = (uint64 *)Transform.get_position(local_28,lVar2,0);
            local_38 = *puVar3;
            local_30 = *(uint32 *)(puVar3 + 1);
            uVar1 = ShortcutExtensions.DOMove(uVar1,&local_38,uVar5,0,0);
            this.tweener = uVar1;
            uVar1 = this.tweener;
            uVar4 = new OnTooltipCB(this,DAT_181d65c80,0);
            TweenSettingsExtensions.OnUpdate(uVar1,uVar4,DAT_181d976d0);
            return;
          }
        }
    }

    // Token : 0x6001902
    // RVA   : 0xAF96F0   Offset: 0xAF7EF0   Length: 0x7E
    private IEnumerator SelfDestroy(float delay)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint32 *)(lVar1 + 32) = delay;
          return lVar1;
        }
    }

    // Token : 0x6001903
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001904
    // RVA   : 0xAF98A0   Offset: 0xAF80A0   Length: 0x16D
    private void <Start>b__4_0()
    {
        long lVar2;
        ulong uVar4;
        float fVar5;
        float fVar6;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        fVar6 = this.moveTime;
        fVar5 = (float)RealTime.get_time(0);
        fVar6 = (float)FUN_1810a8ba0((fVar6 - fVar5) + this.startTime,0,
                                     this.moveTime,0);
        plVar1 = this.tweener;
        if (0.001 <= fVar6) {
          if (this.target != null) {
            lVar2 = GameObject.get_transform(this.target,0);
            if (lVar2 != null) {
              puVar3 = (uint64 *)Transform.get_position(local_28,lVar2,0);
              local_38 = *puVar3;
              local_30 = *(uint32 *)(puVar3 + 1);
              uVar4 = il2cpp_value_box(DAT_181d8e8b8,&local_38);
              if (plVar1 != (int64 *)0) {
                (**(code **)(*plVar1 + 0x1d8))(plVar1,uVar4,fVar6,1,*(uint64 *)(*plVar1 + 0x1e0));
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        TweenExtensions.Complete(plVar1,0);
        lVar2 = new WarpText_d__8(0,0);
        if (lVar2 != null) {
          *(int64 *)(lVar2 + 40) = this;
          *(uint32 *)(lVar2 + 32) = 0x3e4ccccd;
          FUN_180d837c0(this,lVar2,0);
          return;
        }
    }

}
