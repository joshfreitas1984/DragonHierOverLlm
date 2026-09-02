// ============================================================
// Type  : NGUILookAtTarget
// Token : 0x200001C
// ============================================================

public class NGUILookAtTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400007D
    public int level;

    // Token: 0x400007E
    public Transform target;

    // Token: 0x400007F
    public float speed;

    // Token: 0x4000080
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000065
    // RVA   : 0xB005C0   Offset: 0xAFEDC0   Length: 0x24
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x6000066
    // RVA   : 0xB003B0   Offset: 0xAFEBB0   Length: 0x202
    private void LateUpdate()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        float fVar6;
        float fVar7;
        uint uVar8;
        float local_88;
        float fStack_84;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        uVar1 = this.target;
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          return;
        }
        if (this.target != null) {
          puVar5 = (uint64 *)Transform.get_position(&local_58,this.target,0);
          uVar1 = *puVar5;
          fVar6 = *(float *)(puVar5 + 1);
          if (this.mTrans != null) {
            puVar5 = (uint64 *)Transform.get_position(&local_48,this.mTrans,0);
            fStack_84 = (float)((uint64)uVar1 >> 32);
            local_88 = (float)uVar1;
            local_68 = *puVar5;
            local_60 = *(float *)(puVar5 + 1);
            local_70 = fVar6 - local_60;
            uStack_50 = CONCAT44((int)((uint64)uStack_50 >> 32),local_70);
            local_78 = CONCAT44(fStack_84 - (float)((uint64)local_68 >> 32),
                                local_88 - (float)local_68);
            local_58 = local_68;
            fVar6 = (float)Vector3.get_magnitude(&local_78,0);
            if (0.001 < fVar6) {
              local_68 = local_78;
              local_60 = local_70;
              puVar5 = (uint64 *)Quaternion.LookRotation(&local_48,&local_68,0);
              lVar2 = this.mTrans;
              local_48 = *puVar5;
              uStack_40 = puVar5[1];
              if (lVar2 == null) throw; // [null/range check failed]
              puVar5 = (uint64 *)Transform.get_rotation(&local_48,lVar2,0);
              fVar6 = this.speed;
              uVar1 = *puVar5;
              uVar3 = puVar5[1];
              fVar7 = (float)Time.get_deltaTime(0);
              uVar8 = Mathf.Clamp01(fVar7 * fVar6,0);
              local_58 = uVar1;
              uStack_50 = uVar3;
              puVar5 = (uint64 *)Quaternion.Slerp(&local_68,&local_58,&local_48,uVar8,0);
              local_48 = *puVar5;
              uStack_40 = puVar5[1];
              Transform.set_rotation(lVar2,&local_48,0);
            }
            return;
          }
        }
    }

    // Token : 0x6000067
    // RVA   : 0xB005F0   Offset: 0xAFEDF0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180b005f0(int64 this)
        {
        this.speed = 0x41000000;
        FUN_18044ef50(this,0);
    }

}
