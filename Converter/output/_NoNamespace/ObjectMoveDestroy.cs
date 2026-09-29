// ============================================================
// Type  : ObjectMoveDestroy
// Token : 0x20003D1
// ============================================================

public class ObjectMoveDestroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E9A
    public GameObject m_gameObjectMain;

    // Token: 0x4001E9B
    public GameObject m_gameObjectTail;

    // Token: 0x4001E9C
    private GameObject m_makedObject;

    // Token: 0x4001E9D
    public Transform m_hitObject;

    // Token: 0x4001E9E
    public float maxLength;

    // Token: 0x4001E9F
    public bool isDestroy;

    // Token: 0x4001EA0
    public float ObjectDestroyTime;

    // Token: 0x4001EA1
    public float TailDestroyTime;

    // Token: 0x4001EA2
    public float HitObjectDestroyTime;

    // Token: 0x4001EA3
    public float maxTime;

    // Token: 0x4001EA4
    public float MoveSpeed;

    // Token: 0x4001EA5
    public bool isCheckHitTag;

    // Token: 0x4001EA6
    public string mtag;

    // Token: 0x4001EA7
    public bool isShieldActive;

    // Token: 0x4001EA8
    public bool isHitMake;

    // Token: 0x4001EA9
    private float time;

    // Token: 0x4001EAA
    private bool ishit;

    // Token: 0x4001EAB
    private float m_scalefactor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002424
    // RVA   : 0xB901B0   Offset: 0xB8F5B0   Length: 0x6B
    private void Start()
    {
        uint uVar1;
        this.m_scalefactor = **(uint32 **)(DAT_181db38e0 + 184);
        uVar1 = Time.get_time(0);
        *(uint32 *)(this + 100) = uVar1;
    }

    // Token : 0x6002425
    // RVA   : 0xB8FA50   Offset: 0xB8EE50   Length: 0x3D6
    private void LateUpdate()
    {
        float fVar1;
        uint uVar2;
        ulong uVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        bool cVar7;
        long lVar8;
        long lVar10;
        ulong uVar11;
        float fVar12;
        float fVar13;
        float fVar14;
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
        local_60 = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        uStack_70 = 0;
        lVar8 = Component.get_transform(this,0);
        puVar9 = (uint64 *)Vector3.get_forward(&local_a8,0);
        local_a0 = *(float *)(puVar9 + 1);
        uVar11 = *puVar9;
        fVar12 = (float)Time.get_deltaTime(0);
        fVar14 = this.MoveSpeed;
        fVar1 = this.m_scalefactor;
        fVar13 = local_a0 * fVar12 * fVar14 * fVar1;
        local_98 = CONCAT44((float)((uint64)uVar11 >> 32) * fVar12 * fVar14 * fVar1,
                            (float)uVar11 * fVar12 * fVar14 * fVar1);
        uStack_90 = CONCAT44(uStack_90._4_4_,fVar13);
        local_a8 = uVar11;
        if (lVar8 == null) goto LAB_180b8fe21;
        local_a8 = local_98;
        local_a0 = fVar13;
        Transform.Translate(lVar8,&local_a8,0);
        if (!this.ishit) {
          lVar8 = Component.get_transform(this,0);
          if (lVar8 == null) goto LAB_180b8fe21;
          puVar9 = (uint64 *)Transform.get_position(&local_a8,lVar8,0);
          uVar11 = *puVar9;
          uVar4 = *(uint32 *)(puVar9 + 1);
          lVar8 = Component.get_transform(this,0);
          if (lVar8 == null) goto LAB_180b8fe21;
          uVar2 = this.maxLength;
          puVar9 = (uint64 *)Transform.get_forward(&local_98,lVar8,0);
          local_a8 = *puVar9;
          local_a0 = *(float *)(puVar9 + 1);
          uStack_90 = CONCAT44(uStack_90._4_4_,uVar4);
          local_98 = uVar11;
          cVar7 = Physics.Raycast(&local_98,&local_a8,&local_88,uVar2,0);
          if (cVar7) {
            local_58 = local_88;
            uStack_50 = uStack_80;
            local_38 = local_68;
            local_48 = (uint32)local_78;
            uStack_44 = local_78._4_4_;
            uStack_40 = (uint32)uStack_70;
            uStack_3c = uStack_70._4_4_;
            local_30 = local_60;
            ObjectMoveDestroy.HitObj(this,&local_58,0);
          }
        }
        if (this.isDestroy) {
          fVar14 = (float)Time.get_time(0);
          if (*(float *)(this + 100) + this.ObjectDestroyTime < fVar14) {
            lVar8 = Component.get_transform(this,0);
            if (this.isHitMake) {
              uVar11 = this.m_hitObject;
              if (lVar8 == null) {
        LAB_180b8fe21:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar10 = Component.get_transform(lVar8,0);
              if (lVar10 == null) goto LAB_180b8fe21;
              puVar9 = (uint64 *)Transform.get_position(&local_a8,lVar10,0);
              uVar3 = *puVar9;
              fVar14 = *(float *)(puVar9 + 1);
              puVar9 = (uint64 *)Transform.get_rotation(&local_a8,lVar8,0);
              uVar5 = *puVar9;
              uVar6 = puVar9[1];
              local_a8 = uVar3;
              local_a0 = fVar14;
              local_98 = uVar5;
              uStack_90 = uVar6;
              lVar8 = Object.Instantiate(uVar11,&local_a8,&local_98,DAT_181d92db0);
              if (lVar8 == null) goto LAB_180b8fe21;
              uVar11 = Component.get_gameObject(lVar8,0);
              this.m_makedObject = uVar11;
              if (this.m_makedObject == null) goto LAB_180b8fe21;
              lVar8 = GameObject.get_transform(this.m_makedObject,0);
              lVar10 = Component.get_transform(this,0);
              if (lVar10 == null) goto LAB_180b8fe21;
              uVar11 = FUN_180daa030(lVar10,0);
              if (lVar8 == null) goto LAB_180b8fe21;
              Transform.set_parent(lVar8,uVar11,0);
              if (this.m_makedObject == null) goto LAB_180b8fe21;
              lVar8 = GameObject.get_transform(this.m_makedObject,0);
              if (lVar8 == null) goto LAB_180b8fe21;
              local_98 = 0x3f8000003f800000;
              uStack_90 = CONCAT44(uStack_90._4_4_,0x3f800000);
              Transform.set_localScale(lVar8,&local_98,0);
            }
            uVar11 = Component.get_gameObject(this,0);
            Object.Destroy(uVar11,0);
          }
        }
    }

    // Token : 0x6002426
    // RVA   : 0xB8FE30   Offset: 0xB8F230   Length: 0x1B8
    private void MakeHitObject(RaycastHit hit)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        if (!this.isHitMake) {
          return;
        }
        uVar5 = this.m_hitObject;
        if ((hit != null) && (lVar3 = Component.get_transform(hit,0)) != null) {
          puVar4 = (uint64 *)Transform.get_position(&local_48,lVar3,0);
          uVar1 = *puVar4;
          uVar2 = *(uint32 *)(puVar4 + 1);
          puVar4 = (uint64 *)Transform.get_rotation(&local_38,hit,0);
          local_38 = *puVar4;
          uStack_30 = puVar4[1];
          local_48 = uVar1;
          local_40 = uVar2;
          lVar3 = Object.Instantiate(uVar5,&local_48,&local_38,DAT_181d92db0);
          if (lVar3 != null) {
            uVar5 = Component.get_gameObject(lVar3,0);
            this.m_makedObject = uVar5;
            if (this.m_makedObject != null) {
              lVar3 = GameObject.get_transform(this.m_makedObject,0);
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 != null) && (uVar5 = FUN_180daa030(lVar6,0), lVar3 != null)) {
                Transform.set_parent(lVar3,uVar5,0);
                if ((this.m_makedObject != null) &&
                   (lVar3 = GameObject.get_transform(this.m_makedObject,0)) != null) {
                  local_48 = 0x3f8000003f800000;
                  local_40 = 0x3f800000;
                  Transform.set_localScale(lVar3,&local_48,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002427
    // RVA   : 0xB8FFF0   Offset: 0xB8F3F0   Length: 0x1B1
    private void MakeHitObject(Transform point)
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        if (!this.isHitMake) {
          return;
        }
        uVar5 = this.m_hitObject;
        if ((point != null) && (lVar3 = Component.get_transform(point,0)) != null) {
          puVar4 = (uint64 *)Transform.get_position(&local_48,lVar3,0);
          uVar1 = *puVar4;
          uVar2 = *(uint32 *)(puVar4 + 1);
          puVar4 = (uint64 *)Transform.get_rotation(&local_38,point,0);
          local_38 = *puVar4;
          uStack_30 = puVar4[1];
          local_48 = uVar1;
          local_40 = uVar2;
          lVar3 = Object.Instantiate(uVar5,&local_48,&local_38,DAT_181d92db0);
          if (lVar3 != null) {
            uVar5 = Component.get_gameObject(lVar3,0);
            this.m_makedObject = uVar5;
            if (this.m_makedObject != null) {
              lVar3 = GameObject.get_transform(this.m_makedObject,0);
              lVar6 = Component.get_transform(this,0);
              if ((lVar6 != null) && (uVar5 = FUN_180daa030(lVar6,0), lVar3 != null)) {
                Transform.set_parent(lVar3,uVar5,0);
                if ((this.m_makedObject != null) &&
                   (lVar3 = GameObject.get_transform(this.m_makedObject,0)) != null) {
                  local_48 = 0x3f8000003f800000;
                  local_40 = 0x3f800000;
                  Transform.set_localScale(lVar3,&local_48,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002428
    // RVA   : 0xB8F6A0   Offset: 0xB8EAA0   Length: 0x3A0
    private void HitObj(RaycastHit hit)
    {
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        ulong local_78;
        uint local_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        uint32 local_30;
        if (this.isCheckHitTag) {
          lVar4 = RaycastHit.get_transform(hit,0);
          if (lVar4 == null) goto LAB_180b8fa3b;
          cVar3 = Component.CompareTag(lVar4,this.mtag,0);
          if (!cVar3) {
            return;
          }
        }
        uVar6 = this.m_gameObjectTail;
        this.ishit = 1;
        cVar3 = Object.op_Implicit(uVar6,0);
        if (cVar3) {
          if ((this.m_gameObjectTail == null) ||
             (lVar4 = GameObject.get_transform(this.m_gameObjectTail,0)) == null)
          goto LAB_180b8fa3b;
          Transform.set_parent(lVar4,0,0);
        }
        local_58 = *hit;
        uStack_50 = hit[1];
        local_30 = *(uint32 *)(hit + 5);
        local_48 = *(uint32 *)(hit + 2);
        uStack_44 = *(uint32 *)((int64)hit + 20);
        uStack_40 = *(uint32 *)(hit + 3);
        uStack_3c = *(uint32 *)((int64)hit + 28);
        local_38 = hit[4];
        if (this.isHitMake) {
          uVar2 = this.m_hitObject;
          puVar5 = (uint64 *)FUN_18045e0a0(&local_78,&local_58,0);
          uVar6 = *puVar5;
          uVar1 = *(uint32 *)(puVar5 + 1);
          puVar5 = (uint64 *)FUN_18045e080(&local_68,&local_58,0);
          local_78 = *puVar5;
          local_70 = *(uint32 *)(puVar5 + 1);
          puVar5 = (uint64 *)Quaternion.LookRotation(&local_68,&local_78,0);
          local_68 = *puVar5;
          uStack_60 = puVar5[1];
          local_78 = uVar6;
          local_70 = uVar1;
          lVar4 = Object.Instantiate(uVar2,&local_78,&local_68,DAT_181d92db0);
          if (lVar4 == null) goto LAB_180b8fa3b;
          uVar6 = Component.get_gameObject(lVar4,0);
          this.m_makedObject = uVar6;
          if (this.m_makedObject == null) goto LAB_180b8fa3b;
          lVar4 = GameObject.get_transform(this.m_makedObject,0);
          lVar7 = Component.get_transform(this,0);
          if ((lVar7 == null) || (uVar6 = FUN_180daa030(lVar7,0), lVar4 == null)) goto LAB_180b8fa3b;
          Transform.set_parent(lVar4,uVar6,0);
          if ((this.m_makedObject == null) ||
             (lVar4 = GameObject.get_transform(this.m_makedObject,0)) == null)
          goto LAB_180b8fa3b;
          local_78 = 0x3f8000003f800000;
          local_70 = 0x3f800000;
          Transform.set_localScale(lVar4,&local_78,0);
        }
        if (this.isShieldActive) {
          lVar4 = RaycastHit.get_transform(hit,0);
          if (lVar4 == null) {
        LAB_180b8fa3b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = Component.GetComponent(lVar4,DAT_181d95378);
          cVar3 = Object.op_Implicit(lVar4,0);
          if (cVar3) {
            puVar5 = (uint64 *)FUN_18045e0a0(&local_68,hit,0);
            if (lVar4 == null) goto LAB_180b8fa3b;
            local_78 = *puVar5;
            local_70 = *(uint32 *)(puVar5 + 1);
            ShieldActivate.AddHitObject(lVar4,&local_78,0);
          }
        }
        uVar6 = Component.get_gameObject(this,0);
        Object.Destroy(uVar6,0);
        Object.Destroy(this.m_gameObjectTail,this.TailDestroyTime,0);
        Object.Destroy(this.m_makedObject,this.HitObjectDestroyTime,0);
    }

    // Token : 0x6002429
    // RVA   : 0xB90220   Offset: 0xB8F620   Length: 0x19
    public void /*ctor*/()
    {
        void FUN_180b90220(int64 this)
        {
        this.maxTime = 0x3f800000;
        this.MoveSpeed = 0x41200000;
        this.isHitMake = 1;
        FUN_18044ef50(this,0);
    }

}
