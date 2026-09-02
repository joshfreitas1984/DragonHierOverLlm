// ============================================================
// Type  : LittlePeopleController
// Token : 0x20002F3
// ============================================================

public class LittlePeopleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017B0
    public int areaDirection;

    // Token: 0x40017B1
    public SkeletonAnimation skeleton;

    // Token: 0x40017B2
    private bool moving;

    // Token: 0x40017B3
    private float waitTime;

    // Token: 0x40017B4
    public Vector3 moveTargetPos;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001874
    // RVA   : 0xA84C10   Offset: 0xA83410   Length: 0x40
    private void Start()
    {
        float fVar1;
        uint uVar2;
        fVar1 = (float)Random.get_value(0);
        if (fVar1 <= 0.5) {
          uVar2 = Random.Range(0x3f800000,0x41400000,0);
          this.waitTime = uVar2;
        }
    }

    // Token : 0x6001875
    // RVA   : 0xA84C50   Offset: 0xA83450   Length: 0x85A
    private void Update()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar7;
        long lVar9;
        float fVar10;
        uint uVar11;
        float fVar12;
        uint uVar13;
        float fVar14;
        float fVar15;
        ulong[] local_res8 = new ulong[2];
        ulong local_res18;
        ulong local_res20;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        uint local_90;
        ulong local_88;
        float fStack_80;
        uint32 uStack_7c;
        local_b8 = 0;
        local_b0 = 0.0;
        local_res8[0] = 0;
        if (!this.moving) {
          fVar15 = this.waitTime;
          fVar10 = (float)Time.get_deltaTime(0);
          fVar15 = fVar15 - fVar10;
          this.waitTime = fVar15;
          if (fVar15 <= 0.0) {
            this.moving = 1;
            uVar11 = Random.Range(0x3f800000,0x41400000,0);
            this.waitTime = uVar11;
            lVar3 = FUN_18046bac0(0);
            lVar4 = FUN_18046bac0(0);
            if ((lVar4 == null) || (lVar3 == null)) throw; // [null/range check failed]
            puVar5 = (uint64 *)
                     AreaController.GetAreaRandomRoadPos
                               (&local_88,lVar3,*(uint64 *)(lVar4 + 88),
                                this.areaDirection,0);
            this.moveTargetPos = *puVar5;
            *(uint32 *)(this + 56) = *(uint32 *)(puVar5 + 1);
          }
        }
        uVar7 = this.moveTargetPos;
        uVar11 = *(uint32 *)(this + 56);
        puVar5 = (uint64 *)Vector3.get_zero(&local_88,0);
        local_a8 = *puVar5;
        local_a0 = *(float *)(puVar5 + 1);
        local_98 = uVar7;
        local_90 = uVar11;
        cVar2 = Vector3.op_Inequality(&local_98,&local_a8,0);
        if (cVar2) {
          this.moving = 1;
          Vector2.get_zero(0);
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar3,0);
          local_98 = this.moveTargetPos;
          local_90 = *(uint32 *)(this + 56);
          fVar15 = (float)Vector2.Distance(*puVar5,local_98,0);
          if (fVar15 <= 0.01) {
        LAB_180a8527f:
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            local_90 = *(uint32 *)(this + 56);
            local_98 = this.moveTargetPos;
            Transform.set_localPosition(lVar3,&local_98,0);
            puVar5 = (uint64 *)Vector3.get_zero(&local_88,0);
            this.moveTargetPos = *puVar5;
            *(uint32 *)(this + 56) = *(uint32 *)(puVar5 + 1);
            if (this.skeleton == null) throw; // [null/range check failed]
            lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
            if (lVar3 == null) throw; // [null/range check failed]
            AnimationState.SetAnimation(lVar3,0,"idle",1,0);
            this.moving = 0;
          }
          else {
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            pfVar6 = (float *)Transform.get_localPosition(&local_88,lVar3,0);
            fVar15 = *pfVar6;
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar3,0);
            local_98 = *puVar5;
            local_90 = *(uint32 *)(puVar5 + 1);
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar3,0);
            local_a8 = this.moveTargetPos;
            uVar7 = *puVar5;
            local_a0 = *(float *)(this + 56);
            local_b0 = local_a0 - 0.0;
            local_b8 = CONCAT44((float)((uint64)local_a8 >> 32) - local_98._4_4_,
                                (float)local_a8 - fVar15);
            local_88 = local_a8;
            fStack_80 = local_b0;
            puVar5 = (uint64 *)Vector3.get_normalized(&local_88,&local_b8,0);
            uVar1 = *puVar5;
            fStack_80 = *(float *)(puVar5 + 1);
            fVar15 = (float)Time.get_deltaTime(0);
            fVar10 = (float)((uint64)uVar1 >> 32) * fVar15 * 0.1 + (float)((uint64)uVar7 >> 32);
            fVar15 = (float)uVar1 * fVar15 * 0.1 + (float)uVar7;
            fStack_80 = *(float *)(this + 56);
            local_88 = this.moveTargetPos;
            local_res8[0] =
                 CONCAT44(fVar10 - (float)((uint64)local_88 >> 32),fVar15 - (float)local_88);
            local_res18 = Vector2.get_normalized(local_res8,0);
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_localPosition(&local_98,lVar3,0);
            fStack_80 = *(float *)(this + 56);
            local_88 = this.moveTargetPos;
            local_res8[0] =
                 CONCAT44((float)((uint64)*puVar5 >> 32) - (float)((uint64)local_88 >> 32),
                          (float)*puVar5 - (float)local_88);
            uVar7 = Vector2.get_normalized(local_res8,0);
            local_res20._0_4_ = (float)uVar7;
            fVar12 = (float)local_res18 - (float)local_res20;
            local_res20._4_4_ = (float)((uint64)uVar7 >> 32);
            fVar14 = local_res18._4_4_ - local_res20._4_4_;
            local_res20 = uVar7;
            if (9.9999994e-11 <= fVar14 * fVar14 + fVar12 * fVar12) goto LAB_180a8527f;
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            pfVar6 = (float *)Transform.get_localPosition(&local_88,lVar3,0);
            if (*pfVar6 <= fVar15 && fVar15 != *pfVar6) {
              if (this.skeleton == null) throw; // [null/range check failed]
              lVar3 = Component.get_transform(this.skeleton,0);
              puVar8 = (uint32 *)Quaternion.get_identity(&local_88,0);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar11 = *puVar8;
              uVar13 = puVar8[1];
              fStack_80 = (float)puVar8[2];
              uStack_7c = puVar8[3];
        LAB_180a85196:
              local_88 = CONCAT44(uVar13,uVar11);
              Transform.set_localRotation(lVar3,&local_88,0);
            }
            else {
              lVar3 = Component.get_transform(this,0);
              if (lVar3 == null) throw; // [null/range check failed]
              pfVar6 = (float *)Transform.get_localPosition(&local_88,lVar3,0);
              if (fVar15 < *pfVar6) {
                if (this.skeleton == null) throw; // [null/range check failed]
                lVar3 = Component.get_transform(this.skeleton,0);
                lVar4 = *(int64 *)(DAT_181d4ef00 + 184);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar11 = *(uint32 *)(lVar4 + 0x688);
                uVar13 = *(uint32 *)(lVar4 + 0x68c);
                fStack_80 = *(float *)(lVar4 + 0x690);
                uStack_7c = *(uint32 *)(lVar4 + 0x694);
                goto LAB_180a85196;
              }
            }
            lVar3 = Component.get_transform(this,0);
            local_a8 = CONCAT44(fVar10,fVar15);
            local_a0 = 0.0;
            if (lVar3 == null) throw; // [null/range check failed]
            local_98 = local_a8;
            local_90 = 0;
            Transform.set_localPosition(lVar3,&local_98,0);
            if (this.skeleton == null) throw; // [null/range check failed]
            lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3 = AnimationState.GetCurrent(lVar3,0,0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 16) == 0)) throw; // [null/range check failed]
            cVar2 = String.op_Inequality
                              (*(uint64 *)(*(int64 *)(lVar3 + 16) + 16),"walk",0);
            if (cVar2) {
              if (this.skeleton == null) throw; // [null/range check failed]
              lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
              if (lVar3 == null) throw; // [null/range check failed]
              AnimationState.SetAnimation(lVar3,0,"walk",1,0);
            }
          }
        }
        lVar3 = Component.get_transform(this,0);
        lVar4 = Component.get_transform(this,0);
        if (lVar4 != null) {
          puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar4,0);
          uVar7 = *puVar5;
          uVar11 = *(uint32 *)(puVar5 + 1);
          lVar4 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
          lVar9 = Component.get_transform(this,0);
          if (lVar9 != null) {
            puVar5 = (uint64 *)Transform.get_localPosition(&local_88,lVar9,0);
            local_98 = *puVar5;
            local_90 = *(uint32 *)(puVar5 + 1);
            if (lVar4 != null) {
              local_98._4_4_ = (float)((uint64)local_98 >> 32);
              uVar13 = local_98._4_4_;
              fVar15 = (float)AreaController.GetAreaZPos(lVar4,uVar13,0);
              local_98 = uVar7;
              local_90 = uVar11;
              puVar5 = (uint64 *)GlobalData.SetZ(&local_88,&local_98,fVar15 * 0.01,0);
              if (lVar3 != null) {
                local_98 = *puVar5;
                local_90 = *(uint32 *)(puVar5 + 1);
                Transform.set_localPosition(lVar3,&local_98,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001876
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
