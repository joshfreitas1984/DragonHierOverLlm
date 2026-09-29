// ============================================================
// Type  : RandomAudio
// Token : 0x2000335
// ============================================================

public class RandomAudio
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AAC
    public AudioSource audioSource;

    // Token: 0x4001AAD
    public string audioName;

    // Token: 0x4001AAE
    public int randomNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002053
    // RVA   : 0xD08CD0   Offset: 0xD080D0   Length: 0x12C
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
          uVar3 = Component.GetComponent(this,DAT_181d93378);
          this.audioSource = uVar3;
        }
        lVar1 = this.audioSource;
        uVar3 = this.audioName;
        local_res8[0] = FUN_180d96040(0,this.randomNum,0);
        uVar4 = Int32.ToString(local_res8,0);
        uVar3 = String.Concat(uVar3,uVar4,0);
        plVar5 = (int64 *)Resources.Load(uVar3,0);
        if (lVar1 != null) {
          plVar6 = (int64 *)0;
          if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf360)) {
            plVar6 = plVar5;
          }
          AudioSource.set_clip(lVar1,plVar6,0);
          if (this.audioSource != null) {
            AudioSource.Play(this.audioSource,0);
            return;
          }
        }
    }

    // Token : 0x6002054
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
