// ============================================================
// Type  : TankProjectile
// Token : 0x2000129
// ============================================================

public class TankProjectile
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400073D
    public float Speed;

    // Token: 0x400073E
    public float Lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009AC
    // RVA   : 0xABD680   Offset: 0xABBE80   Length: 0x41
    private void Start()
    {
        MonoBehaviour.Invoke(this,"DestroySelf",this.Lifetime,0);
    }

    // Token : 0x60009AD
    // RVA   : 0xABD620   Offset: 0xABBE20   Length: 0x5F
    private void DestroySelf()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

    // Token : 0x60009AE
    // RVA   : 0xABD6D0   Offset: 0xABBED0   Length: 0x156
    private void Update()
    {
        float fVar1;
        ulong uVar2;
        float fVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float fVar8;
        float fVar9;
        float local_88;
        float fStack_84;
        ulong local_78;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[64];
        lVar5 = Component.get_transform(this,0);
        lVar6 = Component.get_transform(this,0);
        if (lVar6 != null) {
          puVar7 = (uint64 *)Transform.get_position(local_58,lVar6,0);
          uVar2 = *puVar7;
          fVar3 = *(float *)(puVar7 + 1);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 != null) {
            fVar1 = this.Speed;
            puVar7 = (uint64 *)Transform.get_forward(local_48,lVar6,0);
            local_60 = *(float *)(puVar7 + 1);
            local_68 = *puVar7;
            fVar9 = (float)local_68;
            uVar4 = (uint64)local_68 >> 32;
            fVar8 = (float)Time.get_deltaTime(0);
            local_88 = (float)uVar2;
            fStack_84 = (float)((uint64)uVar2 >> 32);
            local_78 = CONCAT44((float)uVar4 * fVar1 * fVar8 + fStack_84,fVar9 * fVar1 * fVar8 + local_88)
            ;
            if (lVar5 != null) {
              local_68 = local_78;
              local_60 = local_60 * fVar1 * fVar8 + fVar3;
              Transform.set_position(lVar5,&local_68,0);
              return;
            }
          }
        }
    }

    // Token : 0x60009AF
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
