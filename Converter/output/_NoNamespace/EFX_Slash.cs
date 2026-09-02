// ============================================================
// Type  : EFX_Slash
// Token : 0x2000262
// ============================================================

public class EFX_Slash
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012C1
    public Vector3 speed;

    // Token: 0x40012C2
    public Vector3 baseScale;

    // Token: 0x40012C3
    public bool randomRotation;

    // Token: 0x40012C4
    public float onceLifeTime;

    // Token: 0x40012C5
    private float lifeTime;

    // Token: 0x40012C6
    public int countTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001397
    // RVA   : 0x930FF0   Offset: 0x92F7F0   Length: 0x7
    private void Start()
    {
        void FUN_180930ff0(uint64 this)
        {
        EFX_Slash.ResetToBeginning(this,0);
    }

    // Token : 0x6001398
    // RVA   : 0x931000   Offset: 0x92F800   Length: 0x1E3
    private void Update()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        long lVar5;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        if (-1 < this.countTime) {
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) {
        LAB_1809311de:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar4 = (uint64 *)Transform.get_localScale(&local_58,lVar3,0);
          fVar11 = this.speed;
          local_60 = *(float *)(puVar4 + 1);
          uVar2 = *puVar4;
          fVar8 = (float)Time.get_deltaTime(0);
          fVar10 = *(float *)(this + 28);
          fVar9 = (float)Time.get_deltaTime(0);
          local_60 = local_60 + 0.0;
          local_68 = CONCAT44(fVar9 * fVar10 + (float)((uint64)uVar2 >> 32),
                              fVar8 * fVar11 + (float)uVar2);
          local_50 = local_60;
          Transform.set_localScale(lVar3,&local_68,0);
          fVar11 = this.lifeTime;
          fVar10 = (float)Time.get_deltaTime(0);
          fVar11 = fVar11 - fVar10;
          this.lifeTime = fVar11;
          if (fVar11 < 0.0) {
            this.countTime = this.countTime + -1;
            if (this.countTime < 1) {
              lVar3 = Component.get_transform();
              lVar5 = Component.get_transform(this,0);
              if (lVar5 != null) {
                puVar6 = (uint32 *)Transform.get_localScale(&local_58,lVar5,0);
                uVar1 = *puVar6;
                lVar5 = Component.get_transform(this,0);
                if (lVar5 != null) {
                  puVar7 = (uint64 *)Transform.get_localScale(&local_68,lVar5,0);
                  local_58 = *puVar7;
                  local_60 = *(float *)(puVar7 + 1);
                  local_68 = (uint64)uVar1;
                  local_50 = local_60;
                  if (lVar3 != null) {
                    local_58 = local_68;
                    Transform.set_localScale(lVar3,&local_58,0);
                    return;
                  }
                }
              }
              goto LAB_1809311de;
            }
            EFX_Slash.ResetToBeginning(this);
          }
        }
    }

    // Token : 0x6001399
    // RVA   : 0x930F30   Offset: 0x92F730   Length: 0xB4
    private void ResetToBeginning()
    {
        long lVar1;
        uint uVar3;
        ulong local_18;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          uStack_10 = *(uint32 *)(this + 44);
          local_18 = this.baseScale;
          Transform.set_localScale(lVar1,&local_18,0);
          if (this.randomRotation) {
            lVar1 = Component.get_transform(this,0);
            uVar3 = Random.Range(0,0x43b40000,0);
            puVar2 = (uint64 *)Quaternion.Euler(&local_18,0,0,uVar3,0);
            if (lVar1 == null) throw; // [null/range check failed]
            local_18 = *puVar2;
            uStack_10 = *(uint32 *)(puVar2 + 1);
            uStack_c = *(uint32 *)((int64)puVar2 + 12);
            Transform.set_localRotation(lVar1,&local_18,0);
          }
          this.lifeTime = this.onceLifeTime;
          return;
        }
    }

    // Token : 0x600139A
    // RVA   : 0x930EB0   Offset: 0x92F6B0   Length: 0x74
    private void RandomRotation()
    {
        long lVar1;
        uint uVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.randomRotation) {
          lVar1 = Component.get_transform(this,0);
          uVar3 = Random.Range(0,0x43b40000,0);
          puVar2 = (uint32 *)Quaternion.Euler(&local_18,0,0,uVar3,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          Transform.set_localRotation(lVar1,&local_18,0);
        }
    }

    // Token : 0x600139B
    // RVA   : 0x9311F0   Offset: 0x92F9F0   Length: 0x4E
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_one(local_18,0);
        this.speed = *puVar1;
        *(uint32 *)(this + 32) = *(uint32 *)(puVar1 + 1);
        puVar1 = (uint64 *)Vector3.get_one(local_18,0);
        this.baseScale = *puVar1;
        *(uint32 *)(this + 44) = *(uint32 *)(puVar1 + 1);
        FUN_18044ef50(this,0);
    }

}
