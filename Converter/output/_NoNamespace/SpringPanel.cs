// ============================================================
// Type  : SpringPanel
// Token : 0x2000093
// ============================================================

public class SpringPanel
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000388
    public static SpringPanel current;

    // Token: 0x4000389
    public Vector3 target;

    // Token: 0x400038A
    public float strength;

    // Token: 0x400038B
    public OnFinished onFinished;

    // Token: 0x400038C
    private UIPanel mPanel;

    // Token: 0x400038D
    private Transform mTrans;

    // Token: 0x400038E
    private UIScrollView mDrag;

    // Token: 0x400038F
    private float mDelta;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600045D
    // RVA   : 0xC5E070   Offset: 0xC5D470   Length: 0x8B
    private void Start()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96b60);
        this.mPanel = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96de0);
        this.mDrag = uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x600045E
    // RVA   : 0xC5E1C0   Offset: 0xC5D5C0   Length: 0x11
    private void Update()
    {
        void FUN_180c5e1c0(int64 *this)
        {
                          // WARNING: Could not recover jumptable at 0x000180c5e1ca. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
    }

    // Token : 0x600045F
    // RVA   : 0xC5DBD0   Offset: 0xC5CFD0   Length: 0x38E
    protected virtual void AdvanceTowardsPosition()
    {
        float fVar1;
        ulong uVar2;
        long lVar3;
        bool cVar6;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[8];
        float local_70;
        fVar1 = this.mDelta;
        fVar8 = (float)RealTime.get_deltaTime(0);
        bVar5 = false;
        this.mDelta = fVar8 + fVar1;
        if (this.mTrans != null) {
          puVar7 = (uint64 *)Transform.get_localPosition(local_78,this.mTrans,0);
          local_b8 = this.target;
          local_90 = *(float *)(puVar7 + 1);
          uVar2 = *puVar7;
          fVar13 = (float)uVar2;
          local_80 = *(float *)(puVar7 + 1);
          local_b0 = *(float *)(this + 32);
          local_88 = uVar2;
          puVar7 = (uint64 *)
                   NGUIMath.SpringLerp
                             (local_78,&local_88,&local_b8,this.strength,
                              this.mDelta,0);
          fVar8 = local_90;
          local_88 = this.target;
          local_b8 = *puVar7;
          local_b0 = *(float *)(puVar7 + 1);
          local_98._4_4_ = (float)((uint64)uVar2 >> 32);
          fVar1 = local_98._4_4_;
          local_80 = *(float *)(this + 32);
          local_a0 = local_90 - local_80;
          local_a8 = CONCAT44(local_98._4_4_ - (float)((uint64)local_88 >> 32),
                              fVar13 - (float)local_88);
          local_98 = uVar2;
          local_70 = local_a0;
          fVar9 = (float)Vector3.get_sqrMagnitude(&local_a8,0);
          if (fVar9 < 0.01) {
            uVar2 = this.target;
            fVar10 = (float)uVar2;
            fVar11 = (float)((uint64)uVar2 >> 32);
            fVar8 = *(float *)(this + 32);
            Behaviour.set_enabled(this,0,0);
            bVar5 = true;
            fVar9 = fVar10;
            fVar12 = fVar11;
            local_b8 = uVar2;
          }
          else {
            fVar10 = (float)FUN_18000d7c0((uint32)local_b8);
            local_b8 = CONCAT44(local_b8._4_4_,fVar10);
            fVar11 = (float)FUN_18000d7c0(local_b8._4_4_);
            local_b8 = CONCAT44(fVar11,(uint32)local_b8);
            local_b0 = (float)FUN_18000d7c0(local_b0);
            local_a0 = local_b0 - fVar8;
            local_a8 = CONCAT44(fVar11 - fVar1,fVar10 - fVar13);
            local_70 = local_a0;
            fVar8 = (float)Vector3.get_sqrMagnitude(&local_a8,0);
            if (fVar8 < 0.01) {
              return;
            }
            fVar9 = (float)local_b8;
            fVar12 = (float)((uint64)local_b8 >> 32);
            fVar8 = local_b0;
          }
          this.mDelta = 0;
          if (this.mTrans != null) {
            local_88 = CONCAT44(fVar12,fVar9);
            local_80 = fVar8;
            Transform.set_localPosition(this.mTrans,&local_88,0);
            lVar3 = this.mPanel;
            if (lVar3 != null) {
              UIPanel.set_clipOffset
                        (lVar3,CONCAT44(*(float *)(lVar3 + 0x168) - (fVar11 - fVar1),
                                        lVar3.mClipOffset - (fVar10 - fVar13)),0);
              uVar2 = this.mDrag;
              cVar6 = Object.op_Inequality(uVar2,0,0);
              if (cVar6) {
                plVar4 = this.mDrag;
                if (plVar4 == (int64 *)0) throw; // [null/range check failed]
                (**(code **)(*plVar4 + 0x1b8))(plVar4,0,*(uint64 *)(*plVar4 + 0x1c0));
              }
              if ((bVar5) && (this.onFinished != null)) {
                plVar4 = *(int64 **)(DAT_181da4ad0 + 184);
                *plVar4 = this;
                il2cpp_internal(plVar4,this);
                if (this.onFinished == null) throw; // [null/range check failed]
                OnGeometryUpdated.Invoke(this.onFinished,0);
                puVar7 = *(uint64 **)(DAT_181da4ad0 + 184);
                *puVar7 = 0;
                il2cpp_internal(puVar7,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000460
    // RVA   : 0xC5DF60   Offset: 0xC5D360   Length: 0x102
    public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        if (go != null) {
          lVar3 = GameObject.GetComponent(go,DAT_181d73aa8);
          cVar2 = Object.op_Equality(lVar3,0,0);
          if (cVar2) {
            lVar3 = GameObject.AddComponent(go,DAT_181dc6170);
          }
          if (lVar3 != null) {
            uVar1 = *(uint32 *)(pos + 1);
            *(uint64 *)(lVar3 + 24) = *pos;
            *(uint32 *)(lVar3 + 32) = uVar1;
            *(uint32 *)(lVar3 + 36) = strength;
            *(uint64 *)(lVar3 + 40) = 0;
            Behaviour.set_enabled(lVar3,1,0);
            return lVar3;
          }
        }
    }

    // Token : 0x6000461
    // RVA   : 0xC5E100   Offset: 0xC5D500   Length: 0xB5
    public static SpringPanel Stop(GameObject go)
    {
        bool cVar1;
        long lVar2;
        if (go != null) {
          lVar2 = GameObject.GetComponent(go,DAT_181d73aa8);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (cVar1) {
            if (lVar2 == null) throw; // [null/range check failed]
            cVar1 = Behaviour.get_enabled(lVar2,0);
            if (cVar1) {
              if (*(int64 *)(lVar2 + 40) != 0) {
                OnGeometryUpdated.Invoke(*(int64 *)(lVar2 + 40),0);
              }
              Behaviour.set_enabled(lVar2,0,0);
            }
          }
          return lVar2;
        }
    }

    // Token : 0x6000462
    // RVA   : 0xC5E1E0   Offset: 0xC5D5E0   Length: 0x3A
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.target = *puVar1;
        *(uint32 *)(this + 32) = *(uint32 *)(puVar1 + 1);
        this.strength = 0x41200000;
        FUN_18044ef50(this,0);
    }

}
