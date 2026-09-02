// ============================================================
// Type  : TankWeaponController
// Token : 0x200012B
// ============================================================

public class TankWeaponController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000741
    public TankProjectile ProjectilePrefab;

    // Token: 0x4000742
    public Transform Nozzle;

    // Token: 0x4000743
    private Animation _animation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B2
    // RVA   : 0xABDA70   Offset: 0xABC270   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6a940);
        this._animation = uVar1;
    }

    // Token : 0x60009B3
    // RVA   : 0xABDAC0   Offset: 0xABC2C0   Length: 0x12B
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
          if ((cVar4) || (cVar4 = FUN_1804625b0(32), !cVar4)) {
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
                Object.Instantiate(uVar3,&local_48,&local_38,DAT_181d6a178);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60009B4
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
