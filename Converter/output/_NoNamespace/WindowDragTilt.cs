// ============================================================
// Type  : WindowDragTilt
// Token : 0x2000028
// ============================================================

public class WindowDragTilt
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000B8
    public int updateOrder;

    // Token: 0x40000B9
    public float degrees;

    // Token: 0x40000BA
    private Vector3 mLastPos;

    // Token: 0x40000BB
    private Transform mTrans;

    // Token: 0x40000BC
    private float mAngle;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600009D
    // RVA   : 0x9C98D0   Offset: 0x9C8CD0   Length: 0x59
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

    // Token : 0x600009E
    // RVA   : 0x9C9930   Offset: 0x9C8D30   Length: 0x110
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

    // Token : 0x600009F
    // RVA   : 0x9C9A50   Offset: 0x9C8E50   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1809c9a50(int64 this)
        {
        this.degrees = 0x41f00000;
        FUN_18044ef50(this,0);
    }

}
