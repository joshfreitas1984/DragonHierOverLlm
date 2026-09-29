// ============================================================
// Type  : SpinWithMouse
// Token : 0x2000024
// ============================================================

public class SpinWithMouse
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000AD
    public Transform target;

    // Token: 0x40000AE
    public float speed;

    // Token: 0x40000AF
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000091
    // RVA   : 0xA7FC50   Offset: 0xA7F050   Length: 0x24
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x6000092
    // RVA   : 0xC5DCC0   Offset: 0xC5D0C0   Length: 0x1AA
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
        lVar7 = *(int64 *)(*(int64 *)(DAT_181daf690 + 184) + 224);
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

    // Token : 0x6000093
    // RVA   : 0xC5DE70   Offset: 0xC5D270   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180c5de70(int64 this)
        {
        this.speed = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
