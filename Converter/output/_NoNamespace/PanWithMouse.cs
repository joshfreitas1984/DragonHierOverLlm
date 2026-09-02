// ============================================================
// Type  : PanWithMouse
// Token : 0x200030A
// ============================================================

public class PanWithMouse
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001851
    public Vector2 degrees;

    // Token: 0x4001852
    public float range;

    // Token: 0x4001853
    private Transform mTrans;

    // Token: 0x4001854
    private Quaternion mStart;

    // Token: 0x4001855
    private Vector2 mRot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600191D
    // RVA   : 0x4734C0   Offset: 0x471CC0   Length: 0x51
    private void Start()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        if (this.mTrans != null) {
          puVar2 = (uint64 *)Transform.get_localRotation(local_18,this.mTrans,0);
          uVar1 = puVar2[1];
          this.mStart = *puVar2;
          *(uint64 *)(this + 56) = uVar1;
          return;
        }
    }

    // Token : 0x600191E
    // RVA   : 0x473520   Offset: 0x471D20   Length: 0x1E8
    private void Update()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        int iVar4;
        int iVar5;
        float fVar8;
        float fVar9;
        ulong uVar10;
        float fVar11;
        float fVar12;
        ulong local_88;
        ulong uStack_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint8 local_68 [96];
        fVar8 = (float)RealTime.get_deltaTime(0);
        puVar6 = (uint64 *)Input.get_mousePosition(&local_78,0);
        local_88 = *puVar6;
        uStack_80 = CONCAT44(uStack_80._4_4_,*(uint32 *)(puVar6 + 1));
        iVar4 = Screen.get_width(0);
        iVar5 = Screen.get_height(0);
        fVar12 = this.range;
        if (fVar12 < 0.1) {
          this.range = 0x3dcccccd;
          fVar12 = 0.1;
        }
        fVar9 = (float)FUN_1810a8ba0((((float)local_88 - (float)iVar4 * 0.5) / ((float)iVar4 * 0.5)) /
                                     fVar12,0xbf800000,0x3f800000,0);
        uVar10 = FUN_1810a8ba0(((local_88._4_4_ - (float)iVar5 * 0.5) / ((float)iVar5 * 0.5)) /
                               this.range,0xbf800000,0x3f800000,0);
        fVar12 = this.mRot;
        fVar11 = *(float *)(this + 68);
        fVar8 = (float)Mathf.Clamp01(fVar8 * 5.0,0);
        fVar12 = (fVar9 - fVar12) * fVar8 + fVar12;
        fVar11 = ((float)uVar10 - fVar11) * fVar8 + fVar11;
        lVar1 = this.mTrans;
        uVar2 = this.mStart;
        uVar3 = *(uint64 *)(this + 56);
        this.mRot = fVar12;
        *(float *)(this + 68) = fVar11;
        puVar7 = (uint32 *)
                 Quaternion.Euler(&local_78,
                                   CONCAT44((int)((uint64)uVar10 >> 32),
                                            -fVar11 * *(float *)(this + 28)) ^ 0x8000000000000000,
                                   this.degrees * fVar12,0,0);
        local_78 = *puVar7;
        uStack_74 = puVar7[1];
        uStack_70 = puVar7[2];
        uStack_6c = puVar7[3];
        local_88 = uVar2;
        uStack_80 = uVar3;
        puVar7 = (uint32 *)Quaternion.op_Multiply(local_68,&local_88,&local_78,0);
        if (lVar1 != null) {
          local_78 = *puVar7;
          uStack_74 = puVar7[1];
          uStack_70 = puVar7[2];
          uStack_6c = puVar7[3];
          Transform.set_localRotation(lVar1,&local_78,0);
          return;
        }
    }

    // Token : 0x600191F
    // RVA   : 0x473710   Offset: 0x471F10   Length: 0x4F
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        this.degrees = 0x40a00000;
        *(uint32 *)(this + 28) = 0x40400000;
        this.range = 0x3f800000;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mRot = local_res8;
        *(uint32 *)(this + 68) = uStackX_c;
        FUN_18044ef50(this,0);
    }

}
