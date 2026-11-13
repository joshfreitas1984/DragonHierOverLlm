// ============================================================
// Type  : SpringPosition
// Token : 0x20000B4
// ============================================================

public class SpringPosition
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400043B
    public static SpringPosition current;

    // Token: 0x400043C
    public Vector3 target;

    // Token: 0x400043D
    public float strength;

    // Token: 0x400043E
    public bool worldSpace;

    // Token: 0x400043F
    public bool ignoreTimeScale;

    // Token: 0x4000440
    public bool updateScrollView;

    // Token: 0x4000441
    public float stopMinDistance;

    // Token: 0x4000442
    public OnFinished onFinished;

    // Token: 0x4000443
    private GameObject eventReceiver;

    // Token: 0x4000444
    public string callWhenFinished;

    // Token: 0x4000445
    private Transform mTrans;

    // Token: 0x4000446
    private float mThreshold;

    // Token: 0x4000447
    private UIScrollView mSv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600056C
    // RVA   : 0xA07C60   Offset: 0xA06A60   Length: 0xA9
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        if (this.updateScrollView) {
          uVar1 = Component.get_gameObject(this,0);
          uVar1 = NGUITools.FindInParents(uVar1,DAT_181e72df8);
          this.mSv = uVar1;
        }
    }

    // Token : 0x600056D
    // RVA   : 0xA07D10   Offset: 0xA06B10   Length: 0x562
    private void Update()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        bool cVar5;
        uint uVar7;
        float fVar8;
        float fVar9;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        float local_40;
        byte[] local_38 = new byte[48];
        local_78 = 0;
        local_70 = 0.0;
        if (!this.ignoreTimeScale) {
          uVar7 = Time.get_deltaTime(0);
        }
        else {
          uVar7 = RealTime.get_deltaTime();
        }
        if (!this.worldSpace) {
          if (this.mThreshold == null.0) {
            local_68 = this.target;
            local_60 = *(float *)(this + 32);
            if (this.mTrans == null) goto LAB_180a0826d;
            puVar6 = (uint64 *)Transform.get_localPosition(local_38,this.mTrans,0);
            local_58 = *puVar6;
            local_50 = *(float *)(puVar6 + 1);
            local_70 = local_60 - local_50;
            local_78 = CONCAT44(local_68._4_4_ - (float)((uint64)local_58 >> 32),
                                (float)local_68 - (float)local_58);
            local_40 = local_70;
            fVar8 = (float)Vector3.get_sqrMagnitude(&local_78,0);
            this.mThreshold = fVar8 * 1e-05;
          }
          lVar3 = this.mTrans;
          if (lVar3 == null) goto LAB_180a0826d;
          local_58 = this.target;
          local_50 = *(float *)(this + 32);
          uVar1 = this.strength;
          puVar6 = (uint64 *)Transform.get_localPosition(local_38,lVar3,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1);
          puVar6 = (uint64 *)NGUIMath.SpringLerp(local_38,&local_68,&local_58,uVar1,uVar7,0);
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          Transform.set_localPosition(lVar3,&local_58,0);
          local_68 = this.target;
          local_60 = *(float *)(this + 32);
          fVar8 = this.mThreshold;
          if (this.mTrans == null) goto LAB_180a0826d;
          puVar6 = (uint64 *)Transform.get_localPosition(local_38,this.mTrans,0);
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          local_70 = local_60 - local_50;
          local_78 = CONCAT44(local_68._4_4_ - (float)((uint64)local_58 >> 32),
                              (float)local_68 - (float)local_58);
          local_40 = local_70;
          fVar9 = (float)Vector3.get_sqrMagnitude(&local_78,0);
          if (fVar9 <= fVar8) {
        LAB_180a07f8b:
            if (this.mTrans == null) goto LAB_180a0826d;
            local_58 = this.target;
            local_50 = *(float *)(this + 32);
            Transform.set_localPosition(this.mTrans,&local_58,0);
            goto LAB_180a081df;
          }
          uVar2 = this.target;
          fVar8 = *(float *)(this + 32);
          if (this.mTrans == null) goto LAB_180a0826d;
          puVar6 = (uint64 *)Transform.get_localPosition(local_38,this.mTrans,0);
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          local_68 = uVar2;
          local_60 = fVar8;
          fVar8 = (float)Vector3.Distance(&local_68,&local_58,0);
          if (fVar8 <= this.stopMinDistance) goto LAB_180a07f8b;
        }
        else {
          if (this.mThreshold == null.0) {
            local_68 = this.target;
            local_60 = *(float *)(this + 32);
            if (this.mTrans == null) goto LAB_180a0826d;
            puVar6 = (uint64 *)Transform.get_position(local_38,this.mTrans,0);
            local_58 = *puVar6;
            local_50 = *(float *)(puVar6 + 1);
            local_70 = local_60 - local_50;
            local_78 = CONCAT44(local_68._4_4_ - (float)((uint64)local_58 >> 32),
                                (float)local_68 - (float)local_58);
            local_40 = local_70;
            fVar8 = (float)Vector3.get_sqrMagnitude(&local_78,0);
            this.mThreshold = fVar8 * 0.001;
          }
          lVar3 = this.mTrans;
          if (lVar3 == null) goto LAB_180a0826d;
          local_58 = this.target;
          local_50 = *(float *)(this + 32);
          uVar1 = this.strength;
          puVar6 = (uint64 *)Transform.get_position(local_38,lVar3,0);
          local_68 = *puVar6;
          local_60 = *(float *)(puVar6 + 1);
          puVar6 = (uint64 *)NGUIMath.SpringLerp(local_38,&local_68,&local_58,uVar1,uVar7,0);
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          Transform.set_position(lVar3,&local_58,0);
          local_68 = this.target;
          local_60 = *(float *)(this + 32);
          fVar8 = this.mThreshold;
          if (this.mTrans == null) goto LAB_180a0826d;
          puVar6 = (uint64 *)Transform.get_position(local_38,this.mTrans,0);
          local_58 = *puVar6;
          local_50 = *(float *)(puVar6 + 1);
          local_70 = local_60 - local_50;
          local_78 = CONCAT44(local_68._4_4_ - (float)((uint64)local_58 >> 32),
                              (float)local_68 - (float)local_58);
          local_40 = local_70;
          fVar9 = (float)Vector3.get_sqrMagnitude(&local_78,0);
          if (fVar8 < fVar9) {
            uVar2 = this.target;
            fVar8 = *(float *)(this + 32);
            if (this.mTrans == null) goto LAB_180a0826d;
            puVar6 = (uint64 *)Transform.get_position(local_38,this.mTrans,0);
            local_58 = *puVar6;
            local_50 = *(float *)(puVar6 + 1);
            local_68 = uVar2;
            local_60 = fVar8;
            fVar8 = (float)Vector3.Distance(&local_68,&local_58,0);
            if (this.stopMinDistance < fVar8) goto LAB_180a081f6;
          }
          if (this.mTrans == null) goto LAB_180a0826d;
          local_58 = this.target;
          local_50 = *(float *)(this + 32);
          Transform.set_position(this.mTrans,&local_58,0);
        LAB_180a081df:
          SpringPosition.NotifyListeners(this,0);
          Behaviour.set_enabled(this,0,0);
        }
        LAB_180a081f6:
        uVar2 = this.mSv;
        cVar5 = Object.op_Inequality(uVar2,0,0);
        if (cVar5) {
          plVar4 = this.mSv;
          if (plVar4 == (int64 *)0) {
        LAB_180a0826d:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          (**(code **)(*plVar4 + 0x1b8))(plVar4,1,*(uint64 *)(*plVar4 + 0x1c0));
        }
    }

    // Token : 0x600056E
    // RVA   : 0xA07B70   Offset: 0xA06970   Length: 0xE7
    private void NotifyListeners()
    {
        ulong uVar2;
        bool cVar4;
        plVar1 = *(int64 **)(DAT_181e84fa8 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        if (this.onFinished != null) {
          OnGeometryUpdated.Invoke(this.onFinished,0);
        }
        uVar2 = this.eventReceiver;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (cVar4) {
          cVar4 = FUN_180ad1200(this.callWhenFinished,0);
          if (!cVar4) {
            if (this.eventReceiver == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage
                      (this.eventReceiver,this.callWhenFinished,this,1,0);
          }
        }
        puVar3 = *(uint64 **)(DAT_181e84fa8 + 184);
        *puVar3 = 0;
        il2cpp_internal(puVar3,0);
    }

    // Token : 0x600056F
    // RVA   : 0xA07A50   Offset: 0xA06850   Length: 0x110
    public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        if (go != null) {
          lVar3 = GameObject.GetComponent(go,DAT_181e56bf8);
          cVar2 = Object.op_Equality(lVar3,0,0);
          if (cVar2) {
            lVar3 = GameObject.AddComponent(go,DAT_181e522a8);
          }
          if (lVar3 != null) {
            uVar1 = *(uint32 *)(pos + 1);
            *(uint64 *)(lVar3 + 24) = *pos;
            *(uint32 *)(lVar3 + 32) = uVar1;
            *(uint32 *)(lVar3 + 36) = strength;
            *(uint64 *)(lVar3 + 48) = 0;
            cVar2 = Behaviour.get_enabled(lVar3,0);
            if (!cVar2) {
              Behaviour.set_enabled(lVar3,1,0);
            }
            return lVar3;
          }
        }
    }

    // Token : 0x6000570
    // RVA   : 0xA07A10   Offset: 0xA06810   Length: 0x3A
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.target = *puVar1;
        *(uint32 *)(this + 32) = *(uint32 *)(puVar1 + 1);
        this.strength = 0x41200000;
        FUN_180ae8740(this,0);
    }

}
