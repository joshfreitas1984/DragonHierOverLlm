// ============================================================
// Type  : SpinWithMouse
// Token : 0x2000023
// ============================================================

public class SpinWithMouse
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000091
    public Transform target;

    // Token: 0x4000092
    public float speed;

    // Token: 0x4000093
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000079
    // RVA   : 0xA841D0   Offset: 0xA829D0   Length: 0x24
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x600007A
    // RVA   : 0xC6E090   Offset: 0xC6C890   Length: 0x1AA
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar7;
        float fVar8;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        lVar7 = *(int64 *)(*(int64 *)(DAT_181d8a458 + 184) + 224);
        if (lVar7 != null) {
          *(uint32 *)(lVar7 + 112) = 0;
          uVar1 = this.target;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          fVar8 = delta * -0.5 * this.speed;
          if (!cVar3) {
            lVar7 = this.mTrans;
            puVar4 = (uint64 *)Quaternion.Euler(&local_38,0,fVar8,0,0);
            uVar1 = *puVar4;
            uVar2 = puVar4[1];
            if (this.mTrans == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localRotation(&local_38,this.mTrans,0)
            ;
            puVar4 = &local_48;
            puVar6 = &local_38;
            local_48 = *puVar5;
            uStack_40 = puVar5[1];
            local_38 = uVar1;
            uStack_30 = uVar2;
          }
          else {
            lVar7 = this.target;
            puVar4 = (uint64 *)Quaternion.Euler(local_28,0,fVar8,0,0);
            uVar1 = *puVar4;
            uVar2 = puVar4[1];
            if (this.target == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localRotation(local_28,this.target,0);
            puVar4 = &local_38;
            puVar6 = &local_48;
            local_38 = *puVar5;
            uStack_30 = puVar5[1];
            local_48 = uVar1;
            uStack_40 = uVar2;
          }
          puVar4 = (uint64 *)Quaternion.op_Multiply(local_28,puVar6,puVar4,0);
          if (lVar7 != null) {
            local_38 = *puVar4;
            uStack_30 = puVar4[1];
            Transform.set_localRotation(lVar7,&local_38,0);
            return;
          }
        }
    }

    // Token : 0x600007B
    // RVA   : 0xC6E240   Offset: 0xC6CA40   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180c6e240(int64 this)
        {
        this.speed = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
