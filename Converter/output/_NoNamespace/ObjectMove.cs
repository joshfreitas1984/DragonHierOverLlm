// ============================================================
// Type  : ObjectMove
// Token : 0x20003C9
// ============================================================

public class ObjectMove
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D84
    public float time;

    // Token: 0x4001D85
    private float m_time;

    // Token: 0x4001D86
    private float m_time2;

    // Token: 0x4001D87
    public float MoveSpeed;

    // Token: 0x4001D88
    public bool AbleHit;

    // Token: 0x4001D89
    public float HitDelay;

    // Token: 0x4001D8A
    public GameObject m_hitObject;

    // Token: 0x4001D8B
    private GameObject m_makedObject;

    // Token: 0x4001D8C
    public float MaxLength;

    // Token: 0x4001D8D
    public float DestroyTime2;

    // Token: 0x4001D8E
    private float m_scalefactor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600239D
    // RVA   : 0x46DE40   Offset: 0x46C640   Length: 0x77
    private void Start()
    {
        uint uVar1;
        this.m_scalefactor = **(uint32 **)(DAT_181d8e610 + 184);
        uVar1 = Time.get_time(0);
        this.m_time = uVar1;
        uVar1 = Time.get_time(0);
        this.m_time2 = uVar1;
    }

    // Token : 0x600239E
    // RVA   : 0x46DAF0   Offset: 0x46C2F0   Length: 0x340
    private void LateUpdate()
    {
        float fVar1;
        uint uVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        bool cVar6;
        ulong uVar7;
        long lVar8;
        float fVar11;
        float fVar12;
        float fVar13;
        uint uVar14;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        ulong uStack_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        uint local_60;
        ulong local_58;
        ulong uStack_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint32 local_30;
        local_68 = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_60 = 0;
        local_78 = 0;
        uStack_70 = 0;
        fVar11 = (float)Time.get_time(0);
        if (this.m_time + this.time < fVar11) {
          uVar7 = Component.get_gameObject(this,0);
          Object.Destroy(uVar7,0);
        }
        lVar8 = Component.get_transform(this,0);
        puVar9 = (uint64 *)Vector3.get_forward(&local_a8,0);
        local_a0 = *(float *)(puVar9 + 1);
        uVar7 = *puVar9;
        fVar12 = (float)Time.get_deltaTime(0);
        fVar11 = this.MoveSpeed;
        fVar1 = this.m_scalefactor;
        fVar13 = local_a0 * fVar12 * fVar11 * fVar1;
        local_98 = CONCAT44((float)((uint64)uVar7 >> 32) * fVar12 * fVar11 * fVar1,
                            (float)uVar7 * fVar12 * fVar11 * fVar1);
        uStack_90 = CONCAT44(uStack_90._4_4_,fVar13);
        local_a8 = uVar7;
        if (lVar8 != null) {
          local_a8 = local_98;
          local_a0 = fVar13;
          Transform.Translate(lVar8,&local_a8,0);
          if (!this.AbleHit) {
            return;
          }
          lVar8 = Component.get_transform(this,0);
          if (lVar8 != null) {
            puVar9 = (uint64 *)Transform.get_position(&local_a8,lVar8,0);
            uVar7 = *puVar9;
            uVar14 = *(uint32 *)(puVar9 + 1);
            lVar8 = Component.get_transform(this,0);
            if (lVar8 != null) {
              uVar2 = this.MaxLength;
              puVar9 = (uint64 *)Transform.get_forward(&local_98,lVar8,0);
              local_a8 = *puVar9;
              local_a0 = *(float *)(puVar9 + 1);
              uStack_90 = CONCAT44(uStack_90._4_4_,uVar14);
              local_98 = uVar7;
              cVar6 = Physics.Raycast(&local_98,&local_a8,&local_88,uVar2,0);
              if (!cVar6) {
                return;
              }
              fVar11 = (float)Time.get_time(0);
              if (fVar11 <= this.HitDelay + this.m_time2) {
                return;
              }
              uVar14 = Time.get_time(0);
              bVar10 = !DAT_181e6a14f;
              this.m_time2 = uVar14;
              local_30 = local_60;
              local_58 = local_88;
              uStack_50 = uStack_80;
              local_38 = local_68;
              local_48 = (uint32)local_78;
              uStack_44 = local_78._4_4_;
              uStack_40 = (uint32)uStack_70;
              uStack_3c = uStack_70._4_4_;
              if (bVar10) {
                il2cpp_runtime_class_init(&DAT_181d6a0f8);
                il2cpp_runtime_class_init(&DAT_181d68fe8);
                DAT_181e6a14f = true;
              }
              uVar3 = this.m_hitObject;
              puVar9 = (uint64 *)FUN_18045e0a0(&local_a8,&local_58,0);
              uVar7 = *puVar9;
              fVar11 = *(float *)(puVar9 + 1);
              puVar9 = (uint64 *)FUN_18045e080(&local_98,&local_58,0);
              local_a8 = *puVar9;
              local_a0 = *(float *)(puVar9 + 1);
              puVar9 = (uint64 *)Quaternion.LookRotation(&local_98,&local_a8,0);
              uVar4 = *puVar9;
              uVar5 = puVar9[1];
              local_a8 = uVar7;
              local_a0 = fVar11;
              local_98 = uVar4;
              uStack_90 = uVar5;
              lVar8 = Object.Instantiate(uVar3,&local_a8,&local_98,DAT_181d6a0f8);
              if (lVar8 != null) {
                uVar7 = FUN_180fa1260(lVar8,0);
                this.m_makedObject = uVar7;
                Object.Destroy(this.m_makedObject,this.DestroyTime2,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600239F
    // RVA   : 0x46D9B0   Offset: 0x46C1B0   Length: 0x13B
    private void HitObj(RaycastHit hit)
    {
        uint uVar1;
        ulong uVar2;
        long lVar4;
        ulong uVar5;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        uVar2 = this.m_hitObject;
        puVar3 = (uint64 *)FUN_18045e0a0(&local_48,hit,0);
        uVar5 = *puVar3;
        uVar1 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)FUN_18045e080(&local_38,hit,0);
        local_48 = *puVar3;
        local_40 = *(uint32 *)(puVar3 + 1);
        puVar3 = (uint64 *)Quaternion.LookRotation(&local_38,&local_48,0);
        local_38 = *puVar3;
        uStack_30 = puVar3[1];
        local_48 = uVar5;
        local_40 = uVar1;
        lVar4 = Object.Instantiate(uVar2,&local_48,&local_38,DAT_181d6a0f8);
        if (lVar4 != null) {
          uVar5 = FUN_180fa1260(lVar4,0);
          this.m_makedObject = uVar5;
          Object.Destroy(this.m_makedObject,this.DestroyTime2,0);
          return;
        }
    }

    // Token : 0x60023A0
    // RVA   : 0x46DEC0   Offset: 0x46C6C0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18046dec0(int64 this)
        {
        this.MoveSpeed = 0x41200000;
        FUN_18044ef50(this,0);
    }

}
