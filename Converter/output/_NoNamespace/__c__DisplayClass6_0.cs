// ============================================================
// Type  : <>c__DisplayClass6_0
// Token : 0x200044F
// ============================================================

public class <>c__DisplayClass6_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002103
    public Transform trans;

    // Token: 0x4002104
    public Rigidbody2D target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002687
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002688
    // RVA   : 0x424410   Offset: 0x423810   Length: 0x3B
    internal Vector3 <DOLocalPath>b__0()
    {
        uint uVar1;
        byte[] local_18 = new byte[16];
        if (*(int64 *)(param_2 + 16) != 0) {
          puVar2 = (uint64 *)Transform.get_localPosition(local_18,*(int64 *)(param_2 + 16),0);
          uVar1 = *(uint32 *)(puVar2 + 1);
          *this = *puVar2;
          *(uint32 *)(this + 1) = uVar1;
          return this;
        }
    }

    // Token : 0x6002689
    // RVA   : 0x93A3B0   Offset: 0x9397B0   Length: 0x111
    internal void <DOLocalPath>b__1(Vector3 x)
    {
        long lVar1;
        ulong uVar2;
        bool cVar4;
        long lVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = this.target;
        if (this.trans == null) throw; // [null/range check failed]
        uVar2 = FUN_180daa030(this.trans,0);
        cVar4 = Object.op_Equality(uVar2,0,0);
        if (!cVar4) {
          if (this.trans == null) throw; // [null/range check failed]
          lVar5 = FUN_180daa030(this.trans,0);
          if (lVar5 == null) throw; // [null/range check failed]
          local_20 = *(uint32 *)(x + 1);
          local_28 = *x;
          puVar3 = (uint64 *)Transform.TransformPoint(local_18,lVar5,&local_28,0);
          local_28 = *puVar3;
        }
        else {
          local_28 = *x;
        }
        if (lVar1 != null) {
          Rigidbody2D.MovePosition(lVar1,local_28,0);
          return;
        }
    }

}
