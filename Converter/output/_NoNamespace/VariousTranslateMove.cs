// ============================================================
// Type  : VariousTranslateMove
// Token : 0x20003DA
// ============================================================

public class VariousTranslateMove
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EDF
    public float m_power;

    // Token: 0x4001EE0
    public float m_reduceTime;

    // Token: 0x4001EE1
    public bool m_fowardMove;

    // Token: 0x4001EE2
    public bool m_rightMove;

    // Token: 0x4001EE3
    public bool m_upMove;

    // Token: 0x4001EE4
    public float m_changedFactor;

    // Token: 0x4001EE5
    private float m_Time;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600244D
    // RVA   : 0xC11640   Offset: 0xC10A40   Length: 0x1B
    private void Start()
    {
        uint uVar1;
        uVar1 = Time.get_time(0);
        this.m_Time = uVar1;
    }

    // Token : 0x600244E
    // RVA   : 0xC11660   Offset: 0xC10A60   Length: 0x2F6
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
        this.m_changedFactor = **(uint32 **)(DAT_181db38e0 + 184);
        if (this.m_fowardMove) {
          lVar1 = Component.get_transform(this,0);
          lVar2 = Component.get_transform(this,0);
          fVar7 = local_40;
          if (lVar2 == null) goto LAB_180c11951;
          fVar7 = this.m_power;
          puVar3 = (uint64 *)Transform.get_forward(local_28,lVar2,0);
          local_48 = *puVar3;
          local_40 = this.m_changedFactor;
          local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar7 * local_40,
                              (float)local_48 * fVar7 * local_40);
          local_40 = *(float *)(puVar3 + 1) * fVar7 * local_40;
          fVar7 = *(float *)(puVar3 + 1);
          if (lVar1 == null) goto LAB_180c11951;
          local_48 = local_58;
          Transform.Translate(lVar1,&local_48,0);
        }
        if (this.m_rightMove) {
          lVar1 = Component.get_transform(this,0);
          lVar2 = Component.get_transform(this,0);
          fVar7 = local_40;
          if (lVar2 == null) goto LAB_180c11951;
          fVar7 = this.m_power;
          puVar3 = (uint64 *)Transform.get_right(local_28,lVar2,0);
          local_48 = *puVar3;
          local_40 = this.m_changedFactor;
          local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar7 * local_40,
                              (float)local_48 * fVar7 * local_40);
          local_40 = *(float *)(puVar3 + 1) * fVar7 * local_40;
          fVar7 = *(float *)(puVar3 + 1);
          if (lVar1 == null) goto LAB_180c11951;
          local_48 = local_58;
          Transform.Translate(lVar1,&local_48,0);
        }
        if (!this.m_upMove) {
        LAB_180c118e5:
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
            goto LAB_180c118e5;
          }
        }
        LAB_180c11951:
        local_40 = fVar7;
    }

    // Token : 0x600244F
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
