// ============================================================
// Type  : FPSWeaponTrigger
// Token : 0x2000122
// ============================================================

public class FPSWeaponTrigger
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400072F
    public Transform ShellEjectionTransform;

    // Token: 0x4000730
    public float EjectionForce;

    // Token: 0x4000731
    public Rigidbody Shell;

    // Token: 0x4000732
    public Transform Muzzle;

    // Token: 0x4000733
    public GameObject Bullet;

    // Token: 0x4000734
    public float SmokeAfter;

    // Token: 0x4000735
    public float SmokeMax;

    // Token: 0x4000736
    public float SmokeIncrement;

    // Token: 0x4000737
    public SmokePlume MuzzlePlume;

    // Token: 0x4000738
    public GameObject MuzzleFlashObject;

    // Token: 0x4000739
    private float _smoke;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009AD
    // RVA   : 0xB2A030   Offset: 0xB29430   Length: 0x6E
    private void Update()
    {
        float fVar1;
        float fVar2;
        float fVar3;
        if (this.MuzzlePlume == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        *(bool *)(this.MuzzlePlume + 32) =
             this.SmokeAfter <= this._smoke &&
             this._smoke != this.SmokeAfter;
        fVar3 = this._smoke;
        fVar2 = (float)Time.get_deltaTime(0);
        fVar1 = this.SmokeMax;
        fVar3 = fVar3 - fVar2;
        this._smoke = fVar3;
        if (fVar1 < fVar3) {
          this._smoke = fVar1;
          fVar3 = fVar1;
        }
        if (fVar3 < 0.0) {
          this._smoke = 0;
        }
    }

    // Token : 0x60009AE
    // RVA   : 0xB29CA0   Offset: 0xB290A0   Length: 0x35E
    public void Fire()
    {
        ulong uVar1;
        float fVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar7;
        ulong local_88;
        float local_80;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[8];
        float local_50;
        ulong local_48;
        ulong uStack_40;
        if (this.MuzzleFlashObject != null) {
          GameObject.SetActive(this.MuzzleFlashObject,1,0);
          MonoBehaviour.Invoke(this,"LightsOff",0x3d4ccccd,0);
          this._smoke = this.SmokeIncrement + this._smoke;
          if (this.Shell != null) {
            uVar5 = Component.get_gameObject(this.Shell,0);
            if (this.ShellEjectionTransform != null) {
              puVar6 = (uint64 *)Transform.get_position(local_58,this.ShellEjectionTransform,0);
              uVar1 = *puVar6;
              fVar2 = *(float *)(puVar6 + 1);
              if (this.ShellEjectionTransform != null) {
                puVar6 = (uint64 *)Transform.get_rotation(&local_48,this.ShellEjectionTransform,0);
                local_48 = *puVar6;
                uStack_40 = puVar6[1];
                local_88 = uVar1;
                local_80 = fVar2;
                lVar7 = Object.Instantiate(uVar5,&local_88,&local_48,DAT_181d92e18);
                if (lVar7 != null) {
                  lVar7 = GameObject.GetComponent(lVar7,DAT_181d73008);
                  if (this.ShellEjectionTransform != null) {
                    fVar2 = this.EjectionForce;
                    puVar6 = (uint64 *)Transform.get_right(&local_68,this.ShellEjectionTransform,0)
                    ;
                    local_80 = *(float *)(puVar6 + 1);
                    uVar5 = *puVar6;
                    local_70 = local_80;
                    local_50 = local_80;
                    puVar6 = (uint64 *)Random.get_onUnitSphere(&local_48,0);
                    local_50 = *(float *)(puVar6 + 1);
                    local_68 = *puVar6;
                    local_88 = CONCAT44((float)((uint64)uVar5 >> 32) * fVar2 +
                                        (float)((uint64)local_68 >> 32) * 0.25,
                                        (float)uVar5 * fVar2 + (float)local_68 * 0.25);
                    local_80 = local_70 * fVar2 + local_50 * 0.25;
                    local_60 = local_50;
                    if (lVar7 != null) {
                      local_68 = local_88;
                      local_60 = local_80;
                      Rigidbody.set_velocity(lVar7,&local_68,0);
                      fVar2 = this.EjectionForce;
                      puVar6 = (uint64 *)Random.get_onUnitSphere(&local_48,0);
                      local_60 = *(float *)(puVar6 + 1) * fVar2;
                      local_68 = CONCAT44((float)((uint64)*puVar6 >> 32) * fVar2,
                                          (float)*puVar6 * fVar2);
                      local_50 = local_60;
                      Rigidbody.set_angularVelocity(lVar7,&local_68,0);
                      uVar5 = this.Bullet;
                      if (this.Muzzle != null) {
                        lVar7 = Component.get_transform(this.Muzzle,0);
                        if (lVar7 != null) {
                          puVar6 = (uint64 *)Transform.get_position(&local_48,lVar7,0);
                          uVar4 = DAT_181d92e18;
                          uVar1 = *puVar6;
                          uVar3 = *(uint32 *)(puVar6 + 1);
                          if (this.Muzzle != null) {
                            puVar6 = (uint64 *)
                                     Transform.get_rotation(&local_48,this.Muzzle,0);
                            local_48 = *puVar6;
                            uStack_40 = puVar6[1];
                            local_68 = uVar1;
                            local_60 = (float)uVar3;
                            Object.Instantiate(uVar5,&local_68,&local_48,uVar4);
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
        }
    }

    // Token : 0x60009AF
    // RVA   : 0xB2A000   Offset: 0xB29400   Length: 0x20
    private void LightsOff()
    {
        if (this.MuzzleFlashObject != null) {
          GameObject.SetActive(this.MuzzleFlashObject,0,0);
          return;
        }
    }

    // Token : 0x60009B0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
