// ============================================================
// Type  : Orbiter
// Token : 0x2000124
// ============================================================

public class Orbiter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000722
    public float TankCollisionOrbitRadius;

    // Token: 0x4000723
    public float TankCollisionRotationSpeed;

    // Token: 0x4000724
    public Trail Trail;

    // Token: 0x4000725
    private TankController _tankBeingController;

    // Token: 0x4000726
    private Vector3 _pos;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600099F
    // RVA   : 0x46EC40   Offset: 0x46D440   Length: 0x2A
    private void Start()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this._pos = *puVar1;
        *(uint32 *)(this + 56) = *(uint32 *)(puVar1 + 1);
    }

    // Token : 0x60009A0
    // RVA   : 0x46EC70   Offset: 0x46D470   Length: 0x3BC
    private void Update()
    {
        float fVar2;
        float fVar3;
        ulong uVar4;
        float fVar5;
        bool cVar6;
        long lVar7;
        long lVar10;
        float fVar11;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        uint local_a8;
        uint uStack_a4;
        uint uStack_a0;
        uint32 uStack_9c;
        uint64 local_98;
        uint8 local_88 [24];
        uint64 local_70;
        uint64 uStack_68;
        uint64 local_60;
        uint64 uStack_58;
        uint64 local_50;
        uint32 local_48;
        local_70 = 0;
        uStack_68 = 0;
        local_50 = 0;
        local_60 = 0;
        uStack_58 = 0;
        local_48 = 0;
        lVar7 = Camera.get_main(0);
        puVar8 = (uint64 *)Input.get_mousePosition(local_88,0);
        fVar2 = local_c0;
        if (lVar7 == null) goto LAB_18046f027;
        local_b0 = *(float *)(puVar8 + 1);
        local_b8 = *puVar8;
        puVar9 = (uint32 *)Camera.ScreenPointToRay(local_88,lVar7,&local_b8,0);
        local_a8 = *puVar9;
        uStack_a4 = puVar9[1];
        uStack_a0 = puVar9[2];
        uStack_9c = puVar9[3];
        local_98 = *(uint64 *)(puVar9 + 4);
        cVar6 = Physics.Raycast(&local_a8,&local_70,0x447a0000,0);
        if (cVar6) {
          lVar7 = RaycastHit.get_collider(&local_70,0);
          fVar2 = local_c0;
          if (((lVar7 == null) || (lVar7 = Component.get_transform(lVar7,0), fVar2 = local_c0) == null)
             || (lVar7 = FUN_180da0f40(lVar7,0), fVar2 = local_c0) == null) goto LAB_18046f027;
          lVar7 = Component.GetComponent(lVar7,DAT_181d6d840);
          cVar6 = Object.op_Equality(lVar7,0,0);
          if (!cVar6) {
            fVar2 = local_c0;
            if ((lVar7 == null) ||
               (lVar10 = Component.get_transform(lVar7,0), fVar2 = local_c0) == null)
            goto LAB_18046f027;
            puVar8 = (uint64 *)Transform.get_position(local_88,lVar10,0);
            this._pos = *puVar8;
            *(uint32 *)(this + 56) = *(uint32 *)(puVar8 + 1);
            lVar10 = this._tankBeingController;
            cVar6 = Object.op_Inequality(lVar10,lVar7,0);
            if (cVar6) {
              fVar2 = local_c0;
              if (this.Trail == null) goto LAB_18046f027;
              *(uint8 *)(this.Trail + 32) = 1;
              lVar10 = Component.get_transform(this,0);
              fVar2 = this.TankCollisionOrbitRadius;
              puVar8 = (uint64 *)Vector3.get_one(&local_a8,0);
              local_c8 = *puVar8;
              local_c0 = *(float *)(puVar8 + 1) * fVar2;
              local_b8 = CONCAT44((float)((uint64)local_c8 >> 32) * fVar2,(float)local_c8 * fVar2);
              fVar2 = *(float *)(puVar8 + 1);
              local_b0 = local_c0;
              if (lVar10 == null) goto LAB_18046f027;
              local_c8 = local_b8;
              Transform.set_localScale(lVar10,&local_c8,0);
              lVar10 = Component.get_transform(this,0);
              puVar8 = (uint64 *)Vector3.get_up(&local_a8,0);
              fVar3 = this.TankCollisionRotationSpeed;
              uVar4 = *puVar8;
              fVar5 = *(float *)(puVar8 + 1);
              fVar11 = (float)Time.get_deltaTime(0);
              fVar2 = local_c0;
              if (lVar10 == null) goto LAB_18046f027;
              local_c8 = uVar4;
              local_c0 = fVar5;
              Transform.Rotate(lVar10,&local_c8,fVar11 * fVar3,0);
              lVar10 = Component.get_transform(this,0);
              fVar2 = local_c0;
              if (lVar10 == null) goto LAB_18046f027;
              local_c0 = *(float *)(this + 56);
              local_c8 = this._pos;
              Transform.set_position(lVar10,&local_c8,0);
            }
            cVar6 = Input.GetMouseButtonDown(0,0);
            if (!cVar6) {
              return;
            }
            lVar10 = *plVar1;
            cVar6 = Object.op_Inequality(lVar10,0,0);
            if (!cVar6) {
        LAB_18046efb4:
              *(uint8 *)(lVar7 + 96) = 1;
              *plVar1 = lVar7;
              il2cpp_internal(plVar1,lVar7);
              return;
            }
            fVar2 = local_c0;
            if (*plVar1 != 0) {
              *(uint8 *)(*plVar1 + 96) = 0;
              goto LAB_18046efb4;
            }
            goto LAB_18046f027;
          }
          puVar8 = (uint64 *)FUN_18045e0a0(&local_a8,&local_70,0);
          this._pos = *puVar8;
          *(uint32 *)(this + 56) = *(uint32 *)(puVar8 + 1);
        }
        fVar2 = local_c0;
        if (this.Trail != null) {
          *(uint8 *)(this.Trail + 32) = 0;
          return;
        }
        LAB_18046f027:
        local_c0 = fVar2;
    }

    // Token : 0x60009A1
    // RVA   : 0x46F030   Offset: 0x46D830   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18046f030(int64 this)
        {
        this.TankCollisionOrbitRadius = 0x3fc00000;
        this.TankCollisionRotationSpeed = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
