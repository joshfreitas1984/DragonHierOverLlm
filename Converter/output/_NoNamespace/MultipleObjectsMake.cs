// ============================================================
// Type  : MultipleObjectsMake
// Token : 0x20003C8
// ============================================================

public class MultipleObjectsMake
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D78
    public float m_startDelay;

    // Token: 0x4001D79
    public int m_makeCount;

    // Token: 0x4001D7A
    public float m_makeDelay;

    // Token: 0x4001D7B
    public Vector3 m_randomPos;

    // Token: 0x4001D7C
    public Vector3 m_randomRot;

    // Token: 0x4001D7D
    public Vector3 m_randomScale;

    // Token: 0x4001D7E
    private float m_Time;

    // Token: 0x4001D7F
    private float m_Time2;

    // Token: 0x4001D80
    private float m_delayTime;

    // Token: 0x4001D81
    private float m_count;

    // Token: 0x4001D82
    private float m_scalefactor;

    // Token: 0x4001D83
    public float setObjVolumn;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600239A
    // RVA   : 0xAF9C60   Offset: 0xAF8460   Length: 0x70
    private void Start()
    {
        uint uVar1;
        uVar1 = Time.get_time(0);
        this.m_Time2 = uVar1;
        this.m_Time = uVar1;
        this.m_scalefactor = **(uint32 **)(DAT_181d8e610 + 184);
    }

    // Token : 0x600239B
    // RVA   : 0xAF9CD0   Offset: 0xAF84D0   Length: 0x4D0
    private void Update()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        uint uVar9;
        float fVar10;
        uint uVar11;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        ulong uStack_90;
        float local_80;
        float local_70;
        ulong local_68;
        ulong uStack_60;
        fVar10 = (float)Time.get_time(0);
        if (((fVar10 <= this.m_Time + this.m_startDelay) ||
            (fVar10 = (float)Time.get_time(0),
            fVar10 <= this.m_makeDelay + this.m_Time2)) ||
           ((float)this.m_makeCount < this.m_count ||
            (float)this.m_makeCount == this.m_count)) {
          return;
        }
        lVar4 = Component.get_transform(this,0);
        if (lVar4 != null) {
          puVar5 = (uint64 *)Transform.get_position(&local_c8,lVar4,0);
          local_e8 = this.m_randomPos;
          fVar10 = this.m_scalefactor;
          uVar8 = *puVar5;
          local_d0 = *(float *)(puVar5 + 1);
          local_e0 = *(float *)(this + 52);
          puVar5 = (uint64 *)ObjectsMakeBase.GetRandomVector(&local_c8,this,&local_e8,0);
          local_b0 = *(float *)(puVar5 + 1);
          local_b8 = *puVar5;
          local_e8 = CONCAT44((float)((uint64)local_b8 >> 32) * fVar10 +
                              (float)((uint64)uVar8 >> 32),(float)local_b8 * fVar10 + (float)uVar8);
          local_e0 = local_b0 * fVar10 + local_d0;
          local_d8 = uVar8;
          local_a8 = local_b8;
          local_a0 = local_b0;
          lVar4 = Component.get_transform(this,0);
          if (lVar4 != null) {
            puVar5 = (uint64 *)Transform.get_rotation(&local_98,lVar4,0);
            local_d8 = this.m_randomRot;
            uVar8 = *puVar5;
            uVar1 = puVar5[1];
            local_d0 = *(float *)(this + 64);
            puVar5 = (uint64 *)ObjectsMakeBase.GetRandomVector(&local_c8,this,&local_d8,0);
            local_d8 = *puVar5;
            local_d0 = *(float *)(puVar5 + 1);
            puVar5 = (uint64 *)Quaternion.Euler(&local_98,&local_d8,0);
            local_98 = *puVar5;
            uStack_90 = puVar5[1];
            local_68 = uVar8;
            uStack_60 = uVar1;
            puVar5 = (uint64 *)Quaternion.op_Multiply(&local_c8,&local_68,&local_98,0);
            fVar10 = local_e0;
            uVar2 = local_e8;
            uVar9 = 0;
            uVar8 = *puVar5;
            uVar1 = puVar5[1];
            lVar4 = *(int64 *)(this + 24);
            if (lVar4 != null) {
              while( true ) {
                if (*(int *)(lVar4 + 24) <= (int)uVar9) {
                  uVar11 = Time.get_time(0);
                  this.m_count = this.m_count + 1.0;
                  this.m_Time2 = uVar11;
                  return;
                }
                if (lVar4 == null) break;
                if (*(uint32 *)(lVar4 + 24) <= uVar9) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                uVar7 = lVar4[uVar9];
                local_d8 = uVar2;
                local_d0 = fVar10;
                local_c8 = uVar8;
                uStack_c0 = uVar1;
                lVar6 = Object.Instantiate(uVar7,&local_d8,&local_c8,DAT_181d6a0f8);
                lVar4 = *(int64 *)(this + 24);
                if (lVar4 == null) break;
                if (*(uint32 *)(lVar4 + 24) <= uVar9) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar4 = lVar4[uVar9];
                if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null) break;
                puVar5 = (uint64 *)Transform.get_localScale(&local_68,lVar4,0);
                local_a8 = this.m_randomScale;
                uVar7 = *puVar5;
                local_80 = *(float *)(puVar5 + 1);
                local_a0 = *(float *)(this + 76);
                puVar5 = (uint64 *)ObjectsMakeBase.GetRandomVector2(&local_98,this,&local_a8,0);
                local_c8 = *puVar5;
                local_70 = *(float *)(puVar5 + 1);
                uStack_c0 = CONCAT44((int)((uint64)uStack_c0 >> 32),local_70);
                local_e0 = local_80 + local_70;
                local_e8 = CONCAT44((float)((uint64)uVar7 >> 32) +
                                    (float)((uint64)local_c8 >> 32),(float)uVar7 + (float)local_c8);
                if (lVar6 == null) break;
                lVar4 = GameObject.get_transform(lVar6,0);
                uVar7 = Component.get_transform(this,0);
                if (lVar4 == null) break;
                Transform.set_parent(lVar4,uVar7,0);
                lVar4 = GameObject.get_transform(lVar6,0);
                if (lVar4 == null) break;
                local_b0 = local_e0;
                local_b8 = local_e8;
                Transform.set_localScale(lVar4,&local_b8,0);
                uVar7 = GameObject.GetComponent(lVar6,DAT_181d9e558);
                cVar3 = Object.op_Inequality(uVar7,0,0);
                if ((cVar3) && (*(float *)(this + 100) != -1.0)) {
                  lVar4 = GameObject.GetComponent(lVar6,DAT_181d9e558);
                  if (lVar4 == null) break;
                  AudioSource.set_volume(lVar4,*(uint32 *)(this + 100),0);
                }
                lVar4 = *(int64 *)(this + 24);
                uVar9 = uVar9 + 1;
                if (lVar4 == null) break;
              }
            }
          }
        }
    }

    // Token : 0x600239C
    // RVA   : 0xAFA1B0   Offset: 0xAF89B0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180afa1b0(int64 this)
        {
        *(uint32 *)(this + 100) = 0xbf800000;
        TrailRenderer_Base.ctor(this,0);
    }

}
