// ============================================================
// Type  : WindowDragTilt
// Token : 0x2000027
// ============================================================

public class WindowDragTilt
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400009C
    public int updateOrder;

    // Token: 0x400009D
    public float degrees;

    // Token: 0x400009E
    private Vector3 mLastPos;

    // Token: 0x400009F
    private Transform mTrans;

    // Token: 0x40000A0
    private float mAngle;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000085
    // RVA   : 0x9E72F0   Offset: 0x9E5AF0   Length: 0x59
    private void OnEnable()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        if (this.mTrans != null) {
          puVar2 = (uint64 *)Transform.get_position(local_18,this.mTrans,0);
          this.mLastPos = *puVar2;
          *(uint32 *)(this + 40) = *(uint32 *)(puVar2 + 1);
          return;
        }
    }

    // Token : 0x6000086
    // RVA   : 0x9E7350   Offset: 0x9E5B50   Length: 0x110
    private void Update()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uint uVar5;
        uint uVar6;
        float fVar7;
        ulong local_38;
        uint uStack_30;
        uint32 uStack_2c;
        if (this.mTrans != null) {
          uStack_30 = *(uint32 *)(this + 40);
          uVar1 = this.mLastPos;
          puVar4 = (uint64 *)Transform.get_position(&local_38,this.mTrans,0);
          uVar2 = *puVar4;
          uStack_30 = *(uint32 *)(puVar4 + 1);
          local_38 = uVar1;
          if (this.mTrans != null) {
            puVar4 = (uint64 *)Transform.get_position(&local_38,this.mTrans,0);
            fVar7 = ((float)uVar2 - (float)uVar1) * this.degrees +
                    this.mAngle;
            this.mLastPos = *puVar4;
            *(uint32 *)(this + 40) = *(uint32 *)(puVar4 + 1);
            this.mAngle = fVar7;
            uVar5 = Time.get_deltaTime(0);
            uVar6 = NGUIMath.SpringLerp(fVar7,0,0x41a00000,uVar5,0);
            this.mAngle = uVar6;
            lVar3 = this.mTrans;
            puVar4 = (uint64 *)Quaternion.Euler(&local_38,0,0,uVar6 ^ 0x80000000,0);
            if (lVar3 != null) {
              local_38 = *puVar4;
              uStack_30 = *(uint32 *)(puVar4 + 1);
              uStack_2c = *(uint32 *)((int64)puVar4 + 12);
              Transform.set_localRotation(lVar3,&local_38,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000087
    // RVA   : 0x9E7470   Offset: 0x9E5C70   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1809e7470(int64 this)
        {
        this.degrees = 0x41f00000;
        FUN_18044ef50(this,0);
    }

}
