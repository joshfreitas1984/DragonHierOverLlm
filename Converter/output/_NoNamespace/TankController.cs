// ============================================================
// Type  : TankController
// Token : 0x2000127
// ============================================================

public class TankController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400072C
    public float TrailMaterialOffsetSpeed;

    // Token: 0x400072D
    public float MoveSpeed;

    // Token: 0x400072E
    public float MoveFriction;

    // Token: 0x400072F
    public float MoveAcceleration;

    // Token: 0x4000730
    public float RotateSpeed;

    // Token: 0x4000731
    public float RotateFriction;

    // Token: 0x4000732
    public float RotateAcceleration;

    // Token: 0x4000733
    public Material TrailMaterial;

    // Token: 0x4000734
    public Animator Animator;

    // Token: 0x4000735
    public List<Trail> TankTrackTrails;

    // Token: 0x4000736
    public TankWeaponController WeaponController;

    // Token: 0x4000737
    private float _moveSpeed;

    // Token: 0x4000738
    private float _rotateSpeed;

    // Token: 0x4000739
    public bool InControl;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009A6
    // RVA   : 0xABCF10   Offset: 0xABB710   Length: 0x709
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d65d98 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        float fVar4;
        long lVar5;
        long lVar6;
        uint32 extraout_var;
        int64 *plVar8;
        float fVar9;
        float fVar10;
        uint32 uVar11;
        uint32 uVar12;
        uint64 local_98;
        float local_90;
        uint64 local_88;
        float local_80;
        uint8 local_78 [8];
        float local_70;
        uint8 local_68 [80];
        if (this.Animator == null) throw; // [null/range check failed]
        FUN_18044e920(this.Animator,"InControl",this.InControl,0);
        lVar6 = this.WeaponController;
        if (!this.InControl) {
          if (lVar6 == null) throw; // [null/range check failed]
          Behaviour.set_enabled(lVar6,0,0);
        }
        else {
          if (lVar6 == null) throw; // [null/range check failed]
          Behaviour.set_enabled(lVar6,1,0);
          cVar3 = FUN_1804625f0(119);
          if (!cVar3) {
            cVar3 = FUN_1804625f0(115);
            lVar6 = this.Animator;
            if (!cVar3) {
              if (lVar6 == null) throw; // [null/range check failed]
              FUN_18044e920(lVar6,"Backward",0,0);
              if (this.Animator == null) throw; // [null/range check failed]
              FUN_18044e920(this.Animator,"Forward",0,0);
            }
            else {
              if (lVar6 == null) throw; // [null/range check failed]
              FUN_18044e920(lVar6,"Backward",1,0);
              if (this.Animator == null) throw; // [null/range check failed]
              FUN_18044e920(this.Animator,"Forward",0,0);
              fVar4 = this._moveSpeed;
              fVar9 = this.MoveAcceleration;
              fVar10 = (float)Time.get_deltaTime(0);
              fVar10 = fVar10 * fVar9;
              fVar4 = fVar4 - (fVar10 + fVar10);
              this._moveSpeed = fVar4;
              if (fVar4 < -this.MoveSpeed) {
                this._moveSpeed = -this.MoveSpeed;
              }
            }
          }
          else {
            if (this.Animator == null) throw; // [null/range check failed]
            FUN_18044e920(this.Animator,"Forward",1,0);
            if (this.Animator == null) throw; // [null/range check failed]
            FUN_18044e920(this.Animator,"Backward",0,0);
            fVar4 = this._moveSpeed;
            fVar9 = this.MoveAcceleration;
            fVar10 = (float)Time.get_deltaTime(0);
            fVar10 = fVar10 * fVar9;
            fVar4 = fVar10 + fVar10 + fVar4;
            this._moveSpeed = fVar4;
            if (this.MoveSpeed < fVar4) {
              this._moveSpeed = this.MoveSpeed;
            }
          }
          cVar3 = FUN_1804625f0(100);
          if (!cVar3) {
            cVar3 = FUN_1804625f0(97);
            if (cVar3) {
              fVar4 = this._rotateSpeed;
              fVar9 = this.RotateAcceleration;
              fVar10 = (float)Time.get_deltaTime(0);
              fVar10 = fVar10 * fVar9;
              fVar4 = fVar4 - (fVar10 + fVar10);
              this._rotateSpeed = fVar4;
              if (fVar4 < -this.RotateSpeed) {
                this._rotateSpeed = -this.RotateSpeed;
              }
            }
          }
          else {
            fVar4 = this._rotateSpeed;
            fVar9 = this.RotateAcceleration;
            fVar10 = (float)Time.get_deltaTime(0);
            fVar10 = fVar10 * fVar9;
            fVar4 = fVar10 + fVar10 + fVar4;
            this._rotateSpeed = fVar4;
            if (this.RotateSpeed < fVar4) {
              this._rotateSpeed = this.RotateSpeed;
            }
          }
        }
        lVar6 = this.TankTrackTrails;
        if (0.0 < ABS(this._moveSpeed)) {
          lVar5 = *(int64 *)(pStatics + 8);
          if (lVar5 == null) {
            uVar1 = **(uint64 **)(DAT_181d65d98 + 184);
            lVar5 = new OnTooltipCB(uVar1,DAT_181d8c710,DAT_181d73308);
            plVar8 = (int64 *)(pStatics + 8);
            goto LAB_180abd347;
          }
        }
        else {
          lVar5 = *(int64 *)(pStatics + 16);
          if (lVar5 == null) {
            uVar1 = **(uint64 **)(DAT_181d65d98 + 184);
            lVar5 = new OnTooltipCB(uVar1,DAT_181d8c790,DAT_181d73308);
            plVar8 = (int64 *)(pStatics + 16);
        LAB_180abd347:
            *plVar8 = lVar5;
            il2cpp_internal(plVar8,lVar5);
          }
        }
        if (lVar6 != null) {
          FUN_181827e60(lVar6,lVar5,DAT_181d80178);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 != null) {
            puVar7 = (uint64 *)Transform.get_position(local_78,lVar6,0);
            local_90 = *(float *)(puVar7 + 1);
            local_98 = *puVar7;
            lVar5 = Component.get_transform(this,0);
            if (lVar5 != null) {
              fVar4 = this._moveSpeed;
              puVar7 = (uint64 *)Transform.get_forward(local_68,lVar5,0);
              local_80 = *(float *)(puVar7 + 1);
              local_88 = *puVar7;
              fVar10 = (float)local_88;
              uVar2 = (uint64)local_88 >> 32;
              local_70 = local_80;
              fVar9 = (float)Time.get_deltaTime(0);
              local_80 = local_80 * fVar4 * fVar9 + local_90;
              local_88 = CONCAT44((float)uVar2 * fVar4 * fVar9 + local_98._4_4_,
                                  fVar10 * fVar4 * fVar9 + (float)local_98);
              local_70 = local_80;
              Transform.set_position(lVar6,&local_88,0);
              lVar6 = Component.get_transform(this,0);
              lVar5 = Component.get_transform(this,0);
              if (lVar5 != null) {
                puVar7 = (uint64 *)Transform.get_position(local_68,lVar5,0);
                uVar1 = *puVar7;
                fVar4 = *(float *)(puVar7 + 1);
                lVar5 = Component.get_transform(this,0);
                if (lVar5 != null) {
                  puVar7 = (uint64 *)Transform.get_up(local_68,lVar5,0);
                  if (lVar6 != null) {
                    local_88 = *puVar7;
                    local_80 = *(float *)(puVar7 + 1);
                    local_98 = uVar1;
                    local_90 = fVar4;
                    Transform.RotateAround(lVar6,&local_98,&local_88,this._rotateSpeed,0);
                    lVar6 = this.TrailMaterial;
                    if (lVar6 != null) {
                      fVar4 = (float)Material.get_mainTextureOffset(lVar6,0);
                      fVar9 = (float)Mathf.Sign(this._moveSpeed,0);
                      fVar10 = (float)Mathf.Lerp(0,this.TrailMaterialOffsetSpeed,
                                                  ABS(this._rotateSpeed /
                                                      this.RotateSpeed) +
                                                  ABS(this._moveSpeed /
                                                      this.MoveSpeed),0);
                      if (this.TrailMaterial != null) {
                        Material.get_mainTextureOffset(this.TrailMaterial,0);
                        Material.set_mainTextureOffset
                                  (lVar6,CONCAT44(extraout_var,fVar10 * fVar9 + fVar4),0);
                        uVar12 = this._moveSpeed;
                        fVar4 = this.MoveFriction;
                        fVar9 = (float)Time.get_deltaTime(0);
                        uVar11 = Mathf.MoveTowards(uVar12,0,fVar9 * fVar4,0);
                        uVar12 = this._rotateSpeed;
                        fVar4 = this.RotateFriction;
                        this._moveSpeed = uVar11;
                        fVar9 = (float)Time.get_deltaTime(0);
                        uVar12 = Mathf.MoveTowards(uVar12,0,fVar9 * fVar4,0);
                        this._rotateSpeed = uVar12;
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60009A7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
