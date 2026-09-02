// ============================================================
// Type  : UIDragResize
// Token : 0x2000041
// ============================================================

public class UIDragResize
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400013A
    public UIWidget target;

    // Token: 0x400013B
    public Pivot pivot;

    // Token: 0x400013C
    public int minWidth;

    // Token: 0x400013D
    public int minHeight;

    // Token: 0x400013E
    public int maxWidth;

    // Token: 0x400013F
    public int maxHeight;

    // Token: 0x4000140
    public bool updateAnchors;

    // Token: 0x4000141
    private Plane mPlane;

    // Token: 0x4000142
    private Vector3 mRayPos;

    // Token: 0x4000143
    private Vector3 mLocalPos;

    // Token: 0x4000144
    private int mWidth;

    // Token: 0x4000145
    private int mHeight;

    // Token: 0x4000146
    private bool mDragging;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000124
    // RVA   : 0x10DFFF0   Offset: 0x10DE7F0   Length: 0x254
    private void OnDragStart()
    {
        uint uVar1;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        ulong local_88;
        uint uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        uint64 local_68;
        uint32 local_60;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint32 local_40;
        uint64 local_28;
        uint64 uStack_20;
        uint64 local_18;
        uVar6 = this.target;
        local_res8[0] = 0;
        cVar3 = Object.op_Inequality(uVar6,0,0);
        if (!cVar3) {
          return;
        }
        plVar2 = this.target;
        if ((plVar2 == (int64 *)0) ||
           (lVar4 = (**(code **)(*plVar2 + 0x1e8))(plVar2,*(uint64 *)(*plVar2 + 0x1f0))) == null)
        {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar1 = *(uint32 *)(lVar4 + 24);
        if (uVar1 == 0) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        local_88 = *(uint64 *)(lVar4 + 32);
        uStack_80 = *(uint32 *)(lVar4 + 40);
        if (1 < uVar1) {
          local_48 = *(uint64 *)(lVar4 + 44);
          local_40 = *(uint32 *)(lVar4 + 52);
          if (uVar1 < 4) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          local_68 = *(uint64 *)(lVar4 + 68);
          local_60 = *(uint32 *)(lVar4 + 76);
          local_58 = 0;
          uStack_50 = 0;
          Plane.ctor(&local_58,&local_88,&local_48,&local_68,0);
          this.mPlane = (uint32)local_58;
          *(uint32 *)(this + 60) = local_58._4_4_;
          *(uint32 *)(this + 64) = (uint32)uStack_50;
          *(uint32 *)(this + 68) = uStack_50._4_4_;
          puVar5 = (uint64 *)UICamera.get_currentRay(&local_48,0);
          local_28 = *puVar5;
          uStack_20 = puVar5[1];
          local_18 = puVar5[2];
          local_88 = *puVar5;
          uStack_80 = *(uint32 *)(puVar5 + 1);
          uStack_7c = *(uint32 *)((int64)puVar5 + 12);
          local_78 = puVar5[2];
          cVar3 = Plane.Raycast(this + 56,&local_88,local_res8,0);
          if (!cVar3) {
            return;
          }
          puVar5 = (uint64 *)Ray.GetPoint(&local_88,&local_28,local_res8[0],0);
          this.mRayPos = *puVar5;
          *(uint32 *)(this + 80) = *(uint32 *)(puVar5 + 1);
          if ((this.target != null) &&
             (lVar4 = UIRect.get_cachedTransform(this.target,0)) != null) {
            puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar4,0);
            lVar4 = this.target;
            this.mLocalPos = *puVar5;
            *(uint32 *)(this + 92) = *(uint32 *)(puVar5 + 1);
            if (lVar4 != null) {
              this.mWidth = lVar4.mWidth;
              *(uint32 *)(this + 100) = lVar4.mHeight;
              this.mDragging = 1;
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar6 = il2cpp_internal();
    }

    // Token : 0x6000125
    // RVA   : 0x10E0250   Offset: 0x10DEA50   Length: 0x3E1
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        long lVar6;
        uint uVar8;
        uint[] local_res8 = new uint[2];
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_98;
        float local_90;
        float local_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint64 local_68;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        local_res8[0] = 0;
        if (this.mDragging) {
          uVar2 = this.target;
          cVar4 = Object.op_Inequality(uVar2,0,0);
          if (cVar4) {
            puVar5 = (uint64 *)UICamera.get_currentRay(&local_b8,0);
            local_58 = *puVar5;
            uStack_50 = puVar5[1];
            local_48 = puVar5[2];
            local_78 = *(uint32 *)puVar5;
            uStack_74 = *(uint32 *)((int64)puVar5 + 4);
            uStack_70 = *(uint32 *)(puVar5 + 1);
            uStack_6c = *(uint32 *)((int64)puVar5 + 12);
            local_68 = puVar5[2];
            cVar4 = Plane.Raycast(this + 56,&local_78,local_res8,0);
            if (cVar4) {
              if ((this.target != null) &&
                 (lVar6 = UIRect.get_cachedTransform(this.target,0)) != null) {
                local_90 = *(float *)(this + 92);
                local_98 = this.mLocalPos;
                Transform.set_localPosition(lVar6,&local_98,0);
                if (this.target != null) {
                  UIWidget.set_width(this.target,this.mWidth,0);
                  if (this.target != null) {
                    UIWidget.set_height(this.target,*(uint32 *)(this + 100),0);
                    local_80 = *(float *)(this + 80);
                    uVar2 = this.mRayPos;
                    puVar5 = (uint64 *)Ray.GetPoint(&local_c8,&local_58,local_res8[0],0);
                    local_90 = *(float *)(puVar5 + 1);
                    uVar1 = *puVar5;
                    uStack_b0._0_4_ = local_90;
                    puVar5 = (uint64 *)Transform.get_position(&local_78,lVar6,0);
                    local_b8 = *puVar5;
                    local_c0 = (local_90 - local_80) + *(float *)(puVar5 + 1);
                    uStack_b0 = CONCAT44(uStack_b0._4_4_,local_c0);
                    local_c8 = CONCAT44(((float)((uint64)uVar1 >> 32) -
                                        (float)((uint64)uVar2 >> 32)) +
                                        (float)((uint64)local_b8 >> 32),
                                        ((float)uVar1 - (float)uVar2) + (float)local_b8);
                    Transform.set_position(lVar6,&local_c8,0);
                    puVar7 = (uint32 *)Transform.get_localRotation(&local_78,lVar6,0);
                    local_78 = *puVar7;
                    uStack_74 = puVar7[1];
                    uStack_70 = puVar7[2];
                    uStack_6c = puVar7[3];
                    puVar5 = (uint64 *)Quaternion.Inverse(&local_b8,&local_78,0);
                    uVar2 = this.mLocalPos;
                    uVar1 = *puVar5;
                    uVar3 = puVar5[1];
                    local_80 = *(float *)(this + 92);
                    puVar5 = (uint64 *)Transform.get_localPosition(&local_78,lVar6,0);
                    local_c0 = *(float *)(puVar5 + 1) - local_80;
                    local_c8 = CONCAT44((float)((uint64)*puVar5 >> 32) -
                                        (float)((uint64)uVar2 >> 32),(float)*puVar5 - (float)uVar2);
                    local_b8 = uVar1;
                    uStack_b0 = uVar3;
                    puVar5 = (uint64 *)Quaternion.op_Multiply(&local_78,&local_b8,&local_c8,0);
                    local_c8 = this.mLocalPos;
                    uVar2 = *puVar5;
                    uVar8 = (uint32)((uint64)uVar2 >> 32);
                    local_c0 = *(float *)(this + 92);
                    Transform.set_localPosition(lVar6,&local_c8,0);
                    NGUIMath.ResizeWidget
                              (this.target,this.pivot,(int)uVar2,
                               CONCAT44(uVar8,uVar8),this.minWidth,
                               this.minHeight,this.maxWidth,
                               this.maxHeight,0);
                    if (!this.updateAnchors) {
                      return;
                    }
                    if (this.target != null) {
                      Component.BroadcastMessage(this.target,"UpdateAnchors",0);
                      return;
                    }
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6000126
    // RVA   : 0x10DFFE0   Offset: 0x10DE7E0   Length: 0x5
    private void OnDragEnd()
    {
        void FUN_1810dffe0(int64 this)
        {
        this.mDragging = 0;
    }

    // Token : 0x6000127
    // RVA   : 0x10E0640   Offset: 0x10DEE40   Length: 0x2A
    public void /*ctor*/()
    {
        void FUN_1810e0640(int64 this)
        {
        this.pivot = 8;
        this.minWidth = 100;
        this.minHeight = 100;
        this.maxWidth = 100000;
        this.maxHeight = 100000;
        FUN_18044ef50(this,0);
    }

}
