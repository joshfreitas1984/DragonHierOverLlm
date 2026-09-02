// ============================================================
// Type  : VariousRotateObject
// Token : 0x20003D2
// ============================================================

public class VariousRotateObject
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DD0
    public Vector3 RotateOffset;

    // Token: 0x4001DD1
    private Vector3 RotateMulti;

    // Token: 0x4001DD2
    public float m_delay;

    // Token: 0x4001DD3
    private float m_Time;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023C7
    // RVA   : 0x9DCE80   Offset: 0x9DB680   Length: 0x1B
    private void Awake()
    {
        uint uVar1;
        uVar1 = Time.get_time(0);
        this.m_Time = uVar1;
    }

    // Token : 0x60023C8
    // RVA   : 0x9DCEA0   Offset: 0x9DB6A0   Length: 0x162
    private void Update()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        float fVar5;
        uint uVar6;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        float fStack_40;
        uint32 uStack_3c;
        uint8 local_38 [48];
        fVar5 = (float)Time.get_time(0);
        if (this.m_Time + this.m_delay <= fVar5) {
          fStack_40 = *(float *)(this + 32);
          uVar1 = this.RotateOffset;
          uVar2 = this.RotateMulti;
          uStack_50 = CONCAT44(uStack_50._4_4_,*(uint32 *)(this + 44));
          uVar6 = Time.get_deltaTime(0);
          fVar5 = (float)Mathf.Clamp01(uVar6,0);
          local_58._4_4_ = (float)((uint64)uVar2 >> 32);
          fStack_40 = (fStack_40 - (float)uStack_50) * fVar5 + (float)uStack_50;
          this.RotateMulti =
               CONCAT44(((float)((uint64)uVar1 >> 32) - local_58._4_4_) * fVar5 + local_58._4_4_,
                        ((float)uVar1 - (float)uVar2) * fVar5 + (float)uVar2);
          *(float *)(this + 44) = fStack_40;
          local_58 = uVar2;
          local_48 = uVar1;
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar4 = (uint64 *)Transform.get_rotation(&local_48,lVar3,0);
          local_48 = this.RotateMulti;
          uVar1 = *puVar4;
          uVar2 = puVar4[1];
          fStack_40 = *(float *)(this + 44);
          puVar4 = (uint64 *)Quaternion.Euler(&local_58,&local_48,0);
          local_48 = *puVar4;
          fStack_40 = *(float *)(puVar4 + 1);
          uStack_3c = *(uint32 *)((int64)puVar4 + 12);
          local_58 = uVar1;
          uStack_50 = uVar2;
          puVar4 = (uint64 *)Quaternion.op_Multiply(local_38,&local_58,&local_48,0);
          local_48 = *puVar4;
          fStack_40 = *(float *)(puVar4 + 1);
          uStack_3c = *(uint32 *)((int64)puVar4 + 12);
          Transform.set_rotation(lVar3,&local_48,0);
        }
    }

    // Token : 0x60023C9
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
