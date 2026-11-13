// ============================================================
// Type  : TankWeaponController
// Token : 0x200012B
// ============================================================

public class TankWeaponController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400073D
    public TankProjectile ProjectilePrefab;

    // Token: 0x400073E
    public Transform Nozzle;

    // Token: 0x400073F
    private Animation _animation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B1
    // RVA   : 0x80CA60   Offset: 0x80B860   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e764c8);
        this._animation = uVar1;
    }

    // Token : 0x60009B2
    // RVA   : 0x80CAB0   Offset: 0x80B8B0   Length: 0x12B
    private void Update()
    {
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        if (this._animation != null) {
          cVar4 = Animation.get_isPlaying(this._animation,0);
          if ((cVar4) || (cVar4 = FUN_181844860(32), !cVar4)) {
            return;
          }
          if (this._animation != null) {
            Animation.Play(this._animation,0);
            uVar3 = this.ProjectilePrefab;
            if (this.Nozzle != null) {
              puVar5 = (uint64 *)Transform.get_position(&local_48,this.Nozzle,0);
              uVar1 = *puVar5;
              uVar2 = *(uint32 *)(puVar5 + 1);
              if (this.Nozzle != null) {
                puVar5 = (uint64 *)Transform.get_rotation(&local_38,this.Nozzle,0);
                local_38 = *puVar5;
                uStack_30 = puVar5[1];
                local_48 = uVar1;
                local_40 = uVar2;
                Object.Instantiate(uVar3,&local_48,&local_38,DAT_181e76378);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60009B3
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
