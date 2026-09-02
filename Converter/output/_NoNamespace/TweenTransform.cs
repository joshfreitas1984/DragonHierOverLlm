// ============================================================
// Type  : TweenTransform
// Token : 0x20000C3
// ============================================================

public class TweenTransform
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000494
    public Transform from;

    // Token: 0x4000495
    public Transform to;

    // Token: 0x4000496
    public bool parentWhenFinished;

    // Token: 0x4000497
    private Transform mTrans;

    // Token: 0x4000498
    private Vector3 mPos;

    // Token: 0x4000499
    private Quaternion mRot;

    // Token: 0x400049A
    private Vector3 mScale;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005EA
    // RVA   : 0xA73320   Offset: 0xA71B20   Length: 0x681
    protected override void OnUpdate(float factor, bool isFinished)
    {
        ulong uVar2;
        ulong uVar3;
        float fVar4;
        bool cVar5;
        long lVar6;
        float fVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        ulong local_98;
        ulong local_88;
        float local_80;
        ulong local_78;
        float fStack_70;
        uint32 uStack_6c;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uVar2 = this.to;
        cVar5 = Object.op_Inequality(uVar2,0,0);
        if (!cVar5) {
          return;
        }
        lVar6 = this.mTrans;
        cVar5 = Object.op_Equality(lVar6,0,0);
        if (cVar5) {
          lVar6 = Component.get_transform(this,0);
          *plVar1 = lVar6;
          il2cpp_internal(plVar1,lVar6);
          fVar4 = local_80;
          if (*plVar1 == 0) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_position(&local_78,*plVar1,0);
          this.mPos = *puVar7;
          *(uint32 *)(this + 160) = *(uint32 *)(puVar7 + 1);
          fVar4 = local_80;
          if (*plVar1 == 0) goto LAB_180a7399c;
          puVar8 = (uint32 *)Transform.get_rotation(&local_68,*plVar1,0);
          uVar10 = puVar8[1];
          uVar11 = puVar8[2];
          uVar12 = puVar8[3];
          this.mRot = *puVar8;
          *(uint32 *)(this + 168) = uVar10;
          *(uint32 *)(this + 172) = uVar11;
          *(uint32 *)(this + 176) = uVar12;
          fVar4 = local_80;
          if (*plVar1 == 0) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_localScale(&local_78,*plVar1,0);
          this.mScale = *puVar7;
          *(uint32 *)(this + 188) = *(uint32 *)(puVar7 + 1);
        }
        uVar2 = this.from;
        cVar5 = Object.op_Inequality(uVar2,0,0);
        lVar6 = *plVar1;
        if (!cVar5) {
          local_88 = this.mPos;
          fVar13 = (float)local_88;
          uVar3 = (uint64)local_88 >> 32;
          local_80 = *(float *)(this + 160);
          fVar9 = 1.0 - factor;
          fVar14 = local_80 * fVar9;
          fVar4 = local_80;
          if (this.to == null) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_position(&local_68,this.to,0);
          fStack_70 = *(float *)(puVar7 + 1);
          local_78 = *puVar7;
          local_98 = CONCAT44((float)((uint64)local_78 >> 32) * factor + (float)uVar3 * fVar9,
                              (float)local_78 * factor + fVar13 * fVar9);
          local_80 = fStack_70 * factor + fVar14;
          local_88 = local_78;
          fVar4 = fStack_70;
          if (lVar6 == null) goto LAB_180a7399c;
          local_88 = local_98;
          Transform.set_position(lVar6,&local_88,0);
          local_88 = this.mScale;
          fVar13 = (float)local_88;
          uVar3 = (uint64)local_88 >> 32;
          local_80 = *(float *)(this + 188);
          lVar6 = *plVar1;
          fVar14 = local_80 * fVar9;
          fVar4 = local_80;
          local_78 = local_88;
          fStack_70 = local_80;
          if (this.to == null) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_localScale(&local_68,this.to,0);
          fStack_70 = *(float *)(puVar7 + 1);
          local_78 = *puVar7;
          local_98 = CONCAT44((float)((uint64)local_78 >> 32) * factor + (float)uVar3 * fVar9,
                              (float)local_78 * factor + fVar13 * fVar9);
          local_80 = fStack_70 * factor + fVar14;
          local_88 = local_78;
          fVar4 = fStack_70;
          if (lVar6 == null) goto LAB_180a7399c;
          local_88 = local_98;
          Transform.set_localScale(lVar6,&local_88,0);
          lVar6 = *plVar1;
          uVar10 = this.mRot;
          uVar11 = *(uint32 *)(this + 168);
          fVar9 = *(float *)(this + 172);
          uVar12 = *(uint32 *)(this + 176);
        }
        else {
          fVar4 = local_80;
          if (this.from == null) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_position(&local_68,this.from,0);
          fVar9 = 1.0 - factor;
          local_88 = *puVar7;
          fVar13 = (float)local_88;
          uVar3 = (uint64)local_88 >> 32;
          local_80 = *(float *)(puVar7 + 1);
          fVar14 = local_80 * fVar9;
          fVar4 = local_80;
          local_78 = local_88;
          fStack_70 = local_80;
          if (this.to == null) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_position(&local_68,this.to,0);
          fStack_70 = *(float *)(puVar7 + 1);
          local_78 = *puVar7;
          local_98 = CONCAT44((float)((uint64)local_78 >> 32) * factor + (float)uVar3 * fVar9,
                              (float)local_78 * factor + fVar13 * fVar9);
          local_80 = fStack_70 * factor + fVar14;
          local_88 = local_78;
          fVar4 = fStack_70;
          if (lVar6 == null) goto LAB_180a7399c;
          local_88 = local_98;
          Transform.set_position(lVar6,&local_88,0);
          lVar6 = *plVar1;
          fVar4 = local_80;
          if (this.from == null) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_localScale(&local_68,this.from,0);
          local_88 = *puVar7;
          fVar13 = (float)local_88;
          uVar3 = (uint64)local_88 >> 32;
          local_80 = *(float *)(puVar7 + 1);
          fVar14 = local_80 * fVar9;
          fVar4 = local_80;
          local_78 = local_88;
          fStack_70 = local_80;
          if (this.to == null) goto LAB_180a7399c;
          puVar7 = (uint64 *)Transform.get_localScale(&local_68,this.to,0);
          fStack_70 = *(float *)(puVar7 + 1);
          local_78 = *puVar7;
          local_98 = CONCAT44((float)((uint64)local_78 >> 32) * factor + (float)uVar3 * fVar9,
                              (float)local_78 * factor + fVar13 * fVar9);
          local_80 = fStack_70 * factor + fVar14;
          local_88 = local_78;
          fVar4 = fStack_70;
          if (lVar6 == null) goto LAB_180a7399c;
          local_88 = local_98;
          Transform.set_localScale(lVar6,&local_88,0);
          lVar6 = *plVar1;
          fVar4 = local_80;
          if (this.from == null) goto LAB_180a7399c;
          puVar8 = (uint32 *)Transform.get_rotation(&local_68,this.from,0);
          uVar10 = *puVar8;
          uVar11 = puVar8[1];
          fVar9 = (float)puVar8[2];
          uVar12 = puVar8[3];
        }
        fVar4 = local_80;
        if (this.to != null) {
          puVar8 = (uint32 *)Transform.get_rotation(&local_68,this.to,0);
          local_78 = CONCAT44(uVar11,uVar10);
          local_68 = *puVar8;
          uStack_64 = puVar8[1];
          uStack_60 = puVar8[2];
          uStack_5c = puVar8[3];
          fStack_70 = fVar9;
          uStack_6c = uVar12;
          puVar8 = (uint32 *)Quaternion.Slerp(&local_88,&local_78,&local_68,factor,0);
          fVar4 = local_80;
          if (lVar6 != null) {
            local_68 = *puVar8;
            uStack_64 = puVar8[1];
            uStack_60 = puVar8[2];
            uStack_5c = puVar8[3];
            Transform.set_rotation(lVar6,&local_68,0);
            if ((this.parentWhenFinished & isFinished) != 0) {
              fVar4 = local_80;
              if (*plVar1 == 0) goto LAB_180a7399c;
              Transform.set_parent(*plVar1,this.to,0);
            }
            return;
          }
        }
        LAB_180a7399c:
        local_80 = fVar4;
    }

    // Token : 0x60005EB
    // RVA   : 0xA73250   Offset: 0xA71A50   Length: 0xC2
    public static TweenTransform Begin(GameObject go, float duration, Transform to)
    {
        int64 TweenTransform.Begin
                         (uint64 go,float duration,uint64 to,uint64 param_4)
        {
        int64 lVar1;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9dc80);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 120) = to;
          *(uint64 *)(lVar1 + 128) = param_4;
          if (duration <= 0.0) {
            UITweener.Sample(lVar1,0x3f800000,1,0);
            Behaviour.set_enabled(lVar1,0,0);
          }
          return lVar1;
        }
    }

    // Token : 0x60005EC
    // RVA   : 0xA73180   Offset: 0xA71980   Length: 0xCC
    public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
    {
        int64 TweenTransform.Begin
                         (uint64 go,float duration,uint64 from,uint64 to)
        {
        int64 lVar1;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9dc80);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 120) = from;
          *(uint64 *)(lVar1 + 128) = to;
          if (duration <= 0.0) {
            UITweener.Sample(lVar1,0x3f800000,1,0);
            Behaviour.set_enabled(lVar1,0,0);
          }
          return lVar1;
        }
    }

    // Token : 0x60005ED
    // RVA   : 0xA72230   Offset: 0xA70A30   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_180a72230(uint64 this)
        {
        UITweener.ctor(this,0);
    }

}
