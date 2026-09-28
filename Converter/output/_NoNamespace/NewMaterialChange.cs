// ============================================================
// Type  : NewMaterialChange
// Token : 0x20003D5
// ============================================================

public class NewMaterialChange
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EB4
    public bool isParticleSystem;

    // Token: 0x4001EB5
    public Material m_inputMaterial;

    // Token: 0x4001EB6
    private Material m_objectMaterial;

    // Token: 0x4001EB7
    private MeshRenderer m_meshRenderer;

    // Token: 0x4001EB8
    private ParticleSystemRenderer m_particleRenderer;

    // Token: 0x4001EB9
    public float m_timeToReduce;

    // Token: 0x4001EBA
    public float m_reduceFactor;

    // Token: 0x4001EBB
    private float m_time;

    // Token: 0x4001EBC
    private float m_submitReduceFactor;

    // Token: 0x4001EBD
    private float m_cutOutFactor;

    // Token: 0x4001EBE
    public float m_upFactor;

    // Token: 0x4001EBF
    private float upFactor;

    // Token: 0x4001EC0
    private bool isupfactor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002438
    // RVA   : 0xB8EB10   Offset: 0xB8DF10   Length: 0x107
    private void Awake()
    {
        long lVar1;
        ulong uVar2;
        if (!this.isParticleSystem) {
          lVar1 = Component.get_gameObject(this);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = GameObject.GetComponent(lVar1,DAT_181d724e0);
          this.m_meshRenderer = uVar2;
          if (this.m_meshRenderer == null) throw; // [null/range check failed]
          FUN_180d9dad0(this.m_meshRenderer,this.m_inputMaterial,0);
          lVar1 = this.m_meshRenderer;
        }
        else {
          lVar1 = Component.get_gameObject(this);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = GameObject.GetComponent(lVar1,DAT_181d72788);
          this.m_particleRenderer = uVar2;
          if (this.m_particleRenderer == null) throw; // [null/range check failed]
          FUN_180d9dad0(this.m_particleRenderer,this.m_inputMaterial,0);
          lVar1 = this.m_particleRenderer;
        }
        if (lVar1 != null) {
          uVar2 = FUN_180d9d700(lVar1,0);
          this.m_objectMaterial = uVar2;
          this.m_submitReduceFactor = 0;
          this.m_cutOutFactor = 0x3f800000;
          return;
        }
    }

    // Token : 0x6002439
    // RVA   : 0xB8EC20   Offset: 0xB8E020   Length: 0x190
    private void LateUpdate()
    {
        ulong uVar1;
        float fVar2;
        uint uVar3;
        float fVar4;
        float fVar5;
        fVar4 = this.m_time;
        fVar2 = (float)Time.get_deltaTime(0);
        fVar2 = fVar2 + fVar4;
        this.m_time = fVar2;
        if (this.m_timeToReduce <= fVar2 && fVar2 != this.m_timeToReduce) {
          fVar4 = this.m_submitReduceFactor;
          uVar3 = this.m_reduceFactor;
          this.m_cutOutFactor = this.m_cutOutFactor - fVar4;
          fVar2 = (float)Time.get_deltaTime(0);
          uVar3 = Mathf.Lerp(fVar4,uVar3,fVar2 / 50.0,0);
          this.m_submitReduceFactor = uVar3;
        }
        fVar4 = (float)Mathf.Clamp01(this.m_cutOutFactor,0);
        this.m_cutOutFactor = fVar4;
        if ((fVar4 <= 0.0) &&
           (this.m_timeToReduce <= this.m_time &&
            this.m_time != this.m_timeToReduce)) {
          uVar1 = Component.get_gameObject(this,0);
          Object.Destroy(uVar1,0);
        }
        if (this.m_objectMaterial == null) {
        LAB_180b8edab:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        Material.SetFloat(this.m_objectMaterial,"_MaskCutOut",this.m_cutOutFactor,0);
        fVar4 = this.m_upFactor;
        if ((fVar4 != 0.0) && (this.isupfactor)) {
          fVar2 = this.upFactor;
          fVar5 = (float)Time.get_deltaTime(0);
          fVar2 = fVar5 * fVar4 + fVar2;
          this.upFactor = fVar2;
          uVar3 = Mathf.Clamp01(fVar2,0);
          this.upFactor = uVar3;
          if (this.m_objectMaterial == null) goto LAB_180b8edab;
          Material.SetFloat(this.m_objectMaterial,"_MaskCutOut",uVar3,0);
          if (1.0 <= this.upFactor) {
            this.isupfactor = 0;
          }
        }
    }

    // Token : 0x600243A
    // RVA   : 0xB8EDC0   Offset: 0xB8E1C0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_180b8edc0(int64 this)
        {
        this.isupfactor = 1;
        FUN_18044ef50(this,0);
    }

}
