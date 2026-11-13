// ============================================================
// Type  : VariousTranslateMove
// Token : 0x20003E7
// ============================================================

public class VariousTranslateMove
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F71
    public float m_power;

    // Token: 0x4001F72
    public float m_reduceTime;

    // Token: 0x4001F73
    public bool m_fowardMove;

    // Token: 0x4001F74
    public bool m_rightMove;

    // Token: 0x4001F75
    public bool m_upMove;

    // Token: 0x4001F76
    public float m_changedFactor;

    // Token: 0x4001F77
    private float m_Time;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024F7
    // RVA   : 0x96A8F0   Offset: 0x9696F0   Length: 0x1B
    private void Start()
    {
        uint uVar1;
        uVar1 = Time.get_time(0);
        this.m_Time = uVar1;
    }

    // Token : 0x60024F8
    // RVA   : 0x96A910   Offset: 0x969710   Length: 0x2F6
    private void Update()
    {
        long lVar1;
        long lVar2;
        float fVar4;
        float fVar5;
        uint uVar6;
        float fVar7;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        this.m_changedFactor = **(uint32 **)(DAT_181e93db8 + 184);
        if (this.m_fowardMove) {
          lVar1 = Component.get_transform(this,0);
          lVar2 = Component.get_transform(this,0);
          fVar7 = local_40;
          if (lVar2 == null) goto LAB_18096ac01;
          fVar7 = this.m_power;
          puVar3 = (uint64 *)Transform.get_forward(local_28,lVar2,0);
          local_48 = *puVar3;
          local_40 = this.m_changedFactor;
          local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar7 * local_40,
                              (float)local_48 * fVar7 * local_40);
          local_40 = *(float *)(puVar3 + 1) * fVar7 * local_40;
          fVar7 = *(float *)(puVar3 + 1);
          if (lVar1 == null) goto LAB_18096ac01;
          local_48 = local_58;
          Transform.Translate(lVar1,&local_48,0);
        }
        if (this.m_rightMove) {
          lVar1 = Component.get_transform(this,0);
          lVar2 = Component.get_transform(this,0);
          fVar7 = local_40;
          if (lVar2 == null) goto LAB_18096ac01;
          fVar7 = this.m_power;
          puVar3 = (uint64 *)Transform.get_right(local_28,lVar2,0);
          local_48 = *puVar3;
          local_40 = this.m_changedFactor;
          local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar7 * local_40,
                              (float)local_48 * fVar7 * local_40);
          local_40 = *(float *)(puVar3 + 1) * fVar7 * local_40;
          fVar7 = *(float *)(puVar3 + 1);
          if (lVar1 == null) goto LAB_18096ac01;
          local_48 = local_58;
          Transform.Translate(lVar1,&local_48,0);
        }
        if (!this.m_upMove) {
        LAB_18096ab95:
          fVar7 = this.m_reduceTime;
          fVar5 = this.m_Time;
          fVar4 = (float)Time.get_time(0);
          if ((fVar7 + fVar5 < fVar4) && (this.m_reduceTime != null.0)) {
            fVar7 = this.m_power;
            fVar5 = (float)Time.get_deltaTime(0);
            fVar7 = fVar7 - fVar5 / 10.0;
            this.m_power = fVar7;
            uVar6 = Mathf.Clamp01(fVar7,0);
            this.m_power = uVar6;
          }
          return;
        }
        lVar1 = Component.get_transform(this,0);
        lVar2 = Component.get_transform(this,0);
        fVar7 = local_40;
        if (lVar2 != null) {
          fVar7 = this.m_power;
          puVar3 = (uint64 *)Transform.get_up(local_28,lVar2,0);
          local_48 = *puVar3;
          local_40 = this.m_changedFactor;
          local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar7 * local_40,
                              (float)local_48 * fVar7 * local_40);
          local_40 = *(float *)(puVar3 + 1) * fVar7 * local_40;
          fVar7 = *(float *)(puVar3 + 1);
          if (lVar1 != null) {
            local_48 = local_58;
            Transform.Translate(lVar1,&local_48,0);
            goto LAB_18096ab95;
          }
        }
        LAB_18096ac01:
        local_40 = fVar7;
    }

    // Token : 0x60024F9
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
