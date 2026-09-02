// ============================================================
// Type  : FPSText
// Token : 0x2000275
// ============================================================

public class FPSText
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400135F
    public Text FPS_Text;

    // Token: 0x4001360
    private float m_UpdateShowDeltaTime;

    // Token: 0x4001361
    private int m_FrameUpdate;

    // Token: 0x4001362
    private float m_FPS;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001415
    // RVA   : 0xBA1260   Offset: 0xB9FA60   Length: 0x142
    private void Update()
    {
        float fVar1;
        ulong uVar3;
        float fVar5;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        this.m_FrameUpdate = this.m_FrameUpdate + 1;
        fVar1 = this.m_UpdateShowDeltaTime;
        fVar5 = (float)Time.get_deltaTime(0);
        fVar5 = fVar5 + fVar1;
        this.m_UpdateShowDeltaTime = fVar5;
        if (fVar5 < 0.5) {
          return;
        }
        this.m_UpdateShowDeltaTime = 0;
        plVar2 = this.FPS_Text;
        this.m_FPS = (float)this.m_FrameUpdate / fVar5;
        uVar3 = Single.ToString(this + 40,"f0",0);
        uVar3 = String.Format("FPS:{0}",uVar3,0);
        if (plVar2 != (int64 *)0) {
          (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar3,*(uint64 *)(*plVar2 + 0x5f0));
          plVar2 = this.FPS_Text;
          if (this.m_FPS < 15.0) {
            puVar4 = (uint32 *)Color.get_red(&local_28,0);
          }
          else if (this.m_FPS < 30.0) {
            puVar4 = (uint32 *)Color.get_yellow();
          }
          else {
            puVar4 = (uint32 *)Color.get_green();
          }
          if (plVar2 != (int64 *)0) {
            local_28 = *puVar4;
            uStack_24 = puVar4[1];
            uStack_20 = puVar4[2];
            uStack_1c = puVar4[3];
            (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_28,*(uint64 *)(*plVar2 + 0x2b0));
            return;
          }
        }
    }

    // Token : 0x6001416
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
