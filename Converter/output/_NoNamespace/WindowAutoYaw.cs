// ============================================================
// Type  : WindowAutoYaw
// Token : 0x2000026
// ============================================================

public class WindowAutoYaw
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000098
    public int updateOrder;

    // Token: 0x4000099
    public Camera uiCamera;

    // Token: 0x400009A
    public float yawAmount;

    // Token: 0x400009B
    private Transform mTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000081
    // RVA   : 0x9E7090   Offset: 0x9E5890   Length: 0x3E
    private void OnDisable()
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.mTrans;
        puVar2 = (uint32 *)Quaternion.get_identity(&local_18,0);
        if (lVar1 != null) {
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          Transform.set_localRotation(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x6000082
    // RVA   : 0x9E70D0   Offset: 0x9E58D0   Length: 0xEC
    private void OnEnable()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        uVar4 = this.uiCamera;
        cVar1 = Object.op_Equality(uVar4,0,0);
        if (cVar1) {
          lVar3 = Component.get_gameObject(this,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = GameObject.get_layer(lVar3,0);
          uVar4 = NGUITools.FindCameraForLayer(uVar2,0);
          this.uiCamera = uVar4;
        }
        uVar4 = Component.get_transform(this,0);
        this.mTrans = uVar4;
    }

    // Token : 0x6000083
    // RVA   : 0x9E71C0   Offset: 0x9E59C0   Length: 0x113
    private void Update()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong local_28;
        uint local_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        uVar1 = this.uiCamera;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return;
        }
        lVar2 = this.uiCamera;
        if ((this.mTrans != null) &&
           (puVar4 = (uint64 *)Transform.get_position(&local_18,this.mTrans,0),
           lVar2 != null)) {
          local_28 = *puVar4;
          local_20 = *(uint32 *)(puVar4 + 1);
          puVar4 = (uint64 *)Camera.WorldToViewportPoint(&local_18,lVar2,&local_28,0);
          lVar2 = this.mTrans;
          puVar5 = (uint32 *)
                   Quaternion.Euler(&local_18,0,((float)*puVar4 * 2.0 - 1.0) * this.yawAmount
                                     ,0,0);
          if (lVar2 != null) {
            local_18 = *puVar5;
            uStack_14 = puVar5[1];
            uStack_10 = puVar5[2];
            uStack_c = puVar5[3];
            Transform.set_localRotation(lVar2,&local_18,0);
            return;
          }
        }
    }

    // Token : 0x6000084
    // RVA   : 0x9E72E0   Offset: 0x9E5AE0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1809e72e0(int64 this)
        {
        this.yawAmount = 0x41a00000;
        FUN_18044ef50(this,0);
    }

}
