// ============================================================
// Type  : LagPosition
// Token : 0x2000019
// ============================================================

public class LagPosition
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000071
    public Vector3 speed;

    // Token: 0x4000072
    public bool ignoreTimeScale;

    // Token: 0x4000073
    private Transform mTrans;

    // Token: 0x4000074
    private Vector3 mRelative;

    // Token: 0x4000075
    private Vector3 mAbsolute;

    // Token: 0x4000076
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000056
    // RVA   : 0xA844A0   Offset: 0xA82CA0   Length: 0x10
    public void OnRepositionEnd()
    {
        void FUN_180a844a0(uint64 this)
        {
        LagPosition.Interpolate(this,0x447a0000,0);
    }

    // Token : 0x6000057
    // RVA   : 0xA84200   Offset: 0xA82A00   Length: 0x22C
    private void Interpolate(float delta)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        uint uVar7;
        uint uVar8;
        float fVar9;
        float fVar10;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint8 local_68 [96];
        if (this.mTrans != null) {
          lVar4 = FUN_180da0f00(this.mTrans,0);
          cVar3 = Object.op_Inequality(lVar4,0,0);
          if (!cVar3) {
            return;
          }
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_position(&local_78,lVar4,0);
            local_98 = this.mRelative;
            uVar1 = *puVar5;
            fVar9 = (float)((uint64)uVar1 >> 32);
            local_80 = *(float *)(puVar5 + 1);
            local_90 = *(float *)(this + 56);
            puVar6 = (uint32 *)Transform.get_rotation(local_68,lVar4,0);
            local_78 = *puVar6;
            uStack_74 = puVar6[1];
            uStack_70 = puVar6[2];
            uStack_6c = puVar6[3];
            puVar5 = (uint64 *)Quaternion.op_Multiply(local_68,&local_78,&local_98,0);
            uVar2 = *puVar5;
            local_90 = *(float *)(puVar5 + 1);
            fVar10 = local_80 + local_90;
            uVar8 = this.mAbsolute;
            local_88 = uVar1;
            uVar7 = Mathf.Clamp01(this.speed * delta,0);
            uVar8 = Mathf.Lerp(uVar8,CONCAT44(fVar9,(float)uVar1 + (float)uVar2),uVar7,0);
            this.mAbsolute = uVar8;
            uVar8 = *(uint32 *)(this + 64);
            uVar7 = Mathf.Clamp01(*(float *)(this + 28) * delta,0);
            uVar8 = Mathf.Lerp(uVar8,CONCAT44(fVar9,fVar9 + (float)((uint64)uVar2 >> 32)),uVar7,0);
            *(uint32 *)(this + 64) = uVar8;
            uVar8 = *(uint32 *)(this + 68);
            uVar7 = Mathf.Clamp01(*(float *)(this + 32) * delta,0);
            uVar8 = Mathf.Lerp(uVar8,fVar10,uVar7,0);
            *(uint32 *)(this + 68) = uVar8;
            if (this.mTrans != null) {
              local_88 = this.mAbsolute;
              local_80 = *(float *)(this + 68);
              Transform.set_position(this.mTrans,&local_88,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000058
    // RVA   : 0xA841D0   Offset: 0xA829D0   Length: 0x24
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x6000059
    // RVA   : 0xA84430   Offset: 0xA82C30   Length: 0x64
    private void OnEnable()
    {
        byte[] local_18 = new byte[16];
        if (!this.mStarted) {
          return;
        }
        if (this.mTrans != null) {
          puVar1 = (uint64 *)Transform.get_position(local_18,this.mTrans,0);
          this.mAbsolute = *puVar1;
          *(uint32 *)(this + 68) = *(uint32 *)(puVar1 + 1);
          if (this.mTrans != null) {
            puVar1 = (uint64 *)Transform.get_localPosition(local_18,this.mTrans,0);
            this.mRelative = *puVar1;
            *(uint32 *)(this + 56) = *(uint32 *)(puVar1 + 1);
            return;
          }
        }
    }

    // Token : 0x600005A
    // RVA   : 0xA84510   Offset: 0xA82D10   Length: 0x62
    private void Start()
    {
        byte[] local_18 = new byte[16];
        this.mStarted = 1;
        if (this.mTrans != null) {
          puVar1 = (uint64 *)Transform.get_position(local_18,this.mTrans,0);
          this.mAbsolute = *puVar1;
          *(uint32 *)(this + 68) = *(uint32 *)(puVar1 + 1);
          if (this.mTrans != null) {
            puVar1 = (uint64 *)Transform.get_localPosition(local_18,this.mTrans,0);
            this.mRelative = *puVar1;
            *(uint32 *)(this + 56) = *(uint32 *)(puVar1 + 1);
            return;
          }
        }
    }

    // Token : 0x600005B
    // RVA   : 0xA844B0   Offset: 0xA82CB0   Length: 0x5E
    public void ResetPosition()
    {
        byte[] local_18 = new byte[16];
        if (this.mTrans != null) {
          puVar1 = (uint64 *)Transform.get_position(local_18,this.mTrans,0);
          this.mAbsolute = *puVar1;
          *(uint32 *)(this + 68) = *(uint32 *)(puVar1 + 1);
          if (this.mTrans != null) {
            puVar1 = (uint64 *)Transform.get_localPosition(local_18,this.mTrans,0);
            this.mRelative = *puVar1;
            *(uint32 *)(this + 56) = *(uint32 *)(puVar1 + 1);
            return;
          }
        }
    }

    // Token : 0x600005C
    // RVA   : 0xA84580   Offset: 0xA82D80   Length: 0x32
    private void Update()
    {
        uint uVar1;
        if (!this.ignoreTimeScale) {
          uVar1 = Time.get_deltaTime(0);
        }
        else {
          uVar1 = RealTime.get_deltaTime(0);
        }
        LagPosition.Interpolate(this,uVar1,0);
    }

    // Token : 0x600005D
    // RVA   : 0xA845C0   Offset: 0xA82DC0   Length: 0x31
    public void /*ctor*/()
    {
        this.speed = 0x4120000041200000;
        *(uint32 *)(this + 32) = 0x41200000;
        FUN_18044ef50(0x41200000,0);
    }

}
