// ============================================================
// Type  : DelayActive
// Token : 0x20003C6
// ============================================================

public class DelayActive
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D74
    public GameObject[] m_activeObj;

    // Token: 0x4001D75
    public float m_delayTime;

    // Token: 0x4001D76
    private float m_time;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002395
    // RVA   : 0x92B880   Offset: 0x92A080   Length: 0x1B
    private void Start()
    {
        uint uVar1;
        uVar1 = Time.get_time(0);
        this.m_time = uVar1;
    }

    // Token : 0x6002396
    // RVA   : 0x92B8A0   Offset: 0x92A0A0   Length: 0x125
    private void Update()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        float fVar5;
        fVar5 = (float)Time.get_time(0);
        if (fVar5 <= this.m_time + this.m_delayTime) {
          return;
        }
        uVar4 = 0;
        lVar1 = this.m_activeObj;
        while (lVar1 != null) {
          if (*(int *)(lVar1 + 24) <= (int)uVar4) {
            return;
          }
          if (lVar1 == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          uVar3 = lVar1[uVar4];
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if (cVar2) {
            lVar1 = this.m_activeObj;
            if (lVar1 == null) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar1 = lVar1[uVar4];
            if (lVar1 == null) break;
            GameObject.SetActive(lVar1,1);
          }
          uVar4 = uVar4 + 1;
          lVar1 = this.m_activeObj;
        }
    }

    // Token : 0x6002397
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
