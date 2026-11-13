// ============================================================
// Type  : LagRotation
// Token : 0x200001A
// ============================================================

public class LagRotation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000073
    public float speed;

    // Token: 0x4000074
    public bool ignoreTimeScale;

    // Token: 0x4000075
    private Transform mTrans;

    // Token: 0x4000076
    private Quaternion mRelative;

    // Token: 0x4000077
    private Quaternion mAbsolute;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600005D
    // RVA   : 0x7C4170   Offset: 0x7C2F70   Length: 0x10
    public void OnRepositionEnd()
    {
        void FUN_1807c4170(uint64 this)
        {
        LagRotation.Interpolate(this,0x447a0000,0);
    }

    // Token : 0x600005E
    // RVA   : 0x7C3FE0   Offset: 0x7C2DE0   Length: 0x18F
    private void Interpolate(float delta)
    {
        float fVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar7;
        bool cVar8;
        ulong local_68;
        ulong uStack_60;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint8 local_48 [64];
        uVar2 = this.mTrans;
        cVar8 = Object.op_Inequality(uVar2,0,0);
        if (cVar8) {
          if (this.mTrans != null) {
            lVar3 = FUN_180b05920(this.mTrans,0);
            cVar8 = Object.op_Inequality(lVar3,0,0);
            if (!cVar8) {
              return;
            }
            uVar2 = this.mAbsolute;
            uVar7 = *(uint64 *)(this + 64);
            if (lVar3 != null) {
              local_68 = this.mRelative;
              uStack_60 = *(uint64 *)(this + 48);
              puVar9 = (uint32 *)Transform.get_rotation(&local_58,lVar3,0);
              fVar1 = this.speed;
              local_58 = *puVar9;
              uStack_54 = puVar9[1];
              uStack_50 = puVar9[2];
              uStack_4c = puVar9[3];
              puVar9 = (uint32 *)Quaternion.op_Multiply(local_48,&local_58,&local_68,0);
              local_58 = *puVar9;
              uStack_54 = puVar9[1];
              uStack_50 = puVar9[2];
              uStack_4c = puVar9[3];
              local_68 = uVar2;
              uStack_60 = uVar7;
              puVar9 = (uint32 *)Quaternion.Slerp(local_48,&local_68,&local_58,fVar1 * delta,0);
              uVar4 = puVar9[1];
              uVar5 = puVar9[2];
              uVar6 = puVar9[3];
              this.mAbsolute = *puVar9;
              *(uint32 *)(this + 60) = uVar4;
              *(uint32 *)(this + 64) = uVar5;
              *(uint32 *)(this + 68) = uVar6;
              if (this.mTrans != null) {
                local_58 = *puVar9;
                uStack_54 = puVar9[1];
                uStack_50 = puVar9[2];
                uStack_4c = puVar9[3];
                Transform.set_rotation(this.mTrans,&local_58,0);
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x600005F
    // RVA   : 0x7C4180   Offset: 0x7C2F80   Length: 0x6E
    private void Start()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        byte[] local_18 = new byte[16];
        uVar4 = Component.get_transform(this,0);
        this.mTrans = uVar4;
        if (this.mTrans != null) {
          puVar5 = (uint32 *)Transform.get_localRotation(local_18,this.mTrans,0);
          uVar1 = puVar5[1];
          uVar2 = puVar5[2];
          uVar3 = puVar5[3];
          this.mRelative = *puVar5;
          *(uint32 *)(this + 44) = uVar1;
          *(uint32 *)(this + 48) = uVar2;
          *(uint32 *)(this + 52) = uVar3;
          if (this.mTrans != null) {
            puVar6 = (uint64 *)Transform.get_rotation(local_18,this.mTrans,0);
            uVar4 = puVar6[1];
            this.mAbsolute = *puVar6;
            *(uint64 *)(this + 64) = uVar4;
            return;
          }
        }
    }

    // Token : 0x6000060
    // RVA   : 0x7C41F0   Offset: 0x7C2FF0   Length: 0x32
    private void Update()
    {
        uint uVar1;
        if (!this.ignoreTimeScale) {
          uVar1 = Time.get_deltaTime(0);
        }
        else {
          uVar1 = RealTime.get_deltaTime(0);
        }
        LagRotation.Interpolate(this,uVar1,0);
    }

    // Token : 0x6000061
    // RVA   : 0x7C4230   Offset: 0x7C3030   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1807c4230(int64 this)
        {
        this.speed = 0x41200000;
        FUN_180ae8740(this,0);
    }

}
