// ============================================================
// Type  : RandomAudio
// Token : 0x200032E
// ============================================================

public class RandomAudio
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40019B4
    public AudioSource audioSource;

    // Token: 0x40019B5
    public string audioName;

    // Token: 0x40019B6
    public int randomNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FD3
    // RVA   : 0xC57630   Offset: 0xC55E30   Length: 0x12C
    private void Start()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        uVar3 = this.audioSource;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.GetComponent(this,DAT_181d6ab40);
          this.audioSource = uVar3;
        }
        lVar1 = this.audioSource;
        uVar3 = this.audioName;
        local_res8[0] = FUN_180d8cf10(0,this.randomNum,0);
        uVar4 = Int32.ToString(local_res8,0);
        uVar3 = String.Concat(uVar3,uVar4,0);
        plVar5 = (int64 *)Resources.Load(uVar3,0);
        if (lVar1 != null) {
          plVar6 = (int64 *)0;
          if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
            plVar6 = plVar5;
          }
          AudioSource.set_clip(lVar1,plVar6,0);
          if (this.audioSource != null) {
            AudioSource.Play(this.audioSource,0);
            return;
          }
        }
    }

    // Token : 0x6001FD4
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
