// ============================================================
// Type  : NGUIPanWithMouse
// Token : 0x200001E
// ============================================================

public class NGUIPanWithMouse
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000081
    public Vector2 degrees;

    // Token: 0x4000082
    public float range;

    // Token: 0x4000083
    private Transform mTrans;

    // Token: 0x4000084
    private Quaternion mStart;

    // Token: 0x4000085
    private Vector2 mRot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600006A
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

    // Token : 0x600006B
    // RVA   : 0x1585F40   Offset: 0x1584740   Length: 0x21A
    private void Update()
    {
        long lVar1;
        ulong uVar2;
        int iVar3;
        int iVar4;
        ulong uVar5;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float local_res8;
        float fStackX_c;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        uint64 uStack_70;
        uint8 local_68 [96];
        fVar8 = (float)RealTime.get_deltaTime(0);
        uVar5 = UICamera.get_lastEventPosition(0);
        iVar3 = Screen.get_width(0);
        iVar4 = Screen.get_height(0);
        fVar11 = this.range;
        if (fVar11 < 0.1) {
          this.range = 0x3dcccccd;
          fVar11 = 0.1;
        }
        local_res8 = (float)uVar5;
        fVar9 = (float)FUN_1810a8ba0(((local_res8 - (float)iVar3 * 0.5) / ((float)iVar3 * 0.5)) / fVar11,
                                     0xbf800000,0x3f800000,0);
        fStackX_c = (float)((uint64)uVar5 >> 32);
        fVar10 = (float)FUN_1810a8ba0(((fStackX_c - (float)iVar4 * 0.5) / ((float)iVar4 * 0.5)) /
                                      this.range,0xbf800000,0x3f800000,0);
        fVar11 = this.mRot;
        fVar12 = *(float *)(this + 68);
        fVar8 = (float)Mathf.Clamp01(fVar8 * 5.0,0);
        fVar11 = (fVar9 - fVar11) * fVar8 + fVar11;
        fVar12 = (fVar10 - fVar12) * fVar8 + fVar12;
        lVar1 = this.mTrans;
        uVar5 = this.mStart;
        uVar2 = *(uint64 *)(this + 56);
        this.mRot = fVar11;
        *(float *)(this + 68) = fVar12;
        puVar6 = (uint32 *)
                 Quaternion.Euler(&local_78,-fVar12 * *(float *)(this + 28),
                                   this.degrees * fVar11,0,0);
        local_88 = *puVar6;
        uStack_84 = puVar6[1];
        uStack_80 = puVar6[2];
        uStack_7c = puVar6[3];
        local_78 = uVar5;
        uStack_70 = uVar2;
        puVar7 = (uint64 *)Quaternion.op_Multiply(local_68,&local_78,&local_88,0);
        if (lVar1 != null) {
          local_78 = *puVar7;
          uStack_70 = puVar7[1];
          Transform.set_localRotation(lVar1,&local_78,0);
          return;
        }
    }

    // Token : 0x600006C
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
