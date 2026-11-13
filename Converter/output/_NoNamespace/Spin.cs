// ============================================================
// Type  : Spin
// Token : 0x2000022
// ============================================================

public class Spin
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000089
    public Vector3 rotationsPerSecond;

    // Token: 0x400008A
    public bool ignoreTimeScale;

    // Token: 0x400008B
    private Rigidbody mRb;

    // Token: 0x400008C
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000073
    // RVA   : 0xA072C0   Offset: 0xA060C0   Length: 0x61
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e78438);
        this.mRb = uVar1;
    }

    // Token : 0x6000074
    // RVA   : 0xA07330   Offset: 0xA06130   Length: 0x88
    private void Update()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        uVar1 = this.mRb;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          if (!this.ignoreTimeScale) {
            uVar3 = Time.get_deltaTime();
          }
          else {
            uVar3 = RealTime.get_deltaTime();
          }
          Spin.ApplyDelta(this,uVar3,0);
        }
    }

    // Token : 0x6000075
    // RVA   : 0xA07240   Offset: 0xA06040   Length: 0x7C
    private void FixedUpdate()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        uVar1 = this.mRb;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar3 = Time.get_deltaTime(0);
          Spin.ApplyDelta(this,uVar3,0);
        }
    }

    // Token : 0x6000076
    // RVA   : 0xA070A0   Offset: 0xA05EA0   Length: 0x194
    public void ApplyDelta(float delta)
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        ulong local_48;
        float fStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint64 uStack_30;
        uint8 local_28 [32];
        delta = delta * 360.0;
        local_38 = this.rotationsPerSecond;
        fStack_40 = *(float *)(this + 32) * delta;
        uStack_30 = CONCAT44(uStack_30._4_4_,fStack_40);
        local_48 = CONCAT44((float)((uint64)local_38 >> 32) * delta,(float)local_38 * delta);
        puVar6 = (uint64 *)Quaternion.Euler(&local_38,&local_48,0);
        uVar1 = this.mRb;
        uVar3 = *puVar6;
        uVar4 = puVar6[1];
        cVar5 = Object.op_Equality(uVar1,0,0);
        if (!cVar5) {
          lVar2 = this.mRb;
          if (lVar2 == null) {
        LAB_180a0722f:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_38 = uVar3;
          uStack_30 = uVar4;
          puVar6 = (uint64 *)Rigidbody.get_rotation(&local_48,lVar2,0);
          local_48 = *puVar6;
          fStack_40 = *(float *)(puVar6 + 1);
          uStack_3c = *(uint32 *)((int64)puVar6 + 12);
          puVar6 = (uint64 *)Quaternion.op_Multiply(local_28,&local_48,&local_38,0);
          local_38 = *puVar6;
          uStack_30 = puVar6[1];
          Rigidbody.MoveRotation(lVar2,&local_38,0);
        }
        else {
          lVar2 = this.mTrans;
          if (lVar2 == null) goto LAB_180a0722f;
          local_38 = uVar3;
          uStack_30 = uVar4;
          puVar6 = (uint64 *)Transform.get_rotation(local_28,lVar2,0);
          local_48 = *puVar6;
          fStack_40 = *(float *)(puVar6 + 1);
          uStack_3c = *(uint32 *)((int64)puVar6 + 12);
          puVar6 = (uint64 *)Quaternion.op_Multiply(local_28,&local_48,&local_38,0);
          local_38 = *puVar6;
          uStack_30 = puVar6[1];
          Transform.set_rotation(lVar2,&local_38,0);
        }
    }

    // Token : 0x6000077
    // RVA   : 0xA073C0   Offset: 0xA061C0   Length: 0x31
    public void /*ctor*/()
    {
        this.rotationsPerSecond = 0x3dcccccd00000000;
        *(uint32 *)(this + 32) = 0;
        FUN_180ae8740(0,0);
    }

}
