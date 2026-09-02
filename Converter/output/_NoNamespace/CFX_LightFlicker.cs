// ============================================================
// Type  : CFX_LightFlicker
// Token : 0x20003C1
// ============================================================

public class CFX_LightFlicker
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D4E
    public bool loop;

    // Token: 0x4001D4F
    public float smoothFactor;

    // Token: 0x4001D50
    public float addIntensity;

    // Token: 0x4001D51
    private float minIntensity;

    // Token: 0x4001D52
    private float maxIntensity;

    // Token: 0x4001D53
    private float baseIntensity;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002383
    // RVA   : 0xBD5660   Offset: 0xBD3E60   Length: 0x53
    private void Awake()
    {
        long lVar1;
        uint uVar2;
        lVar1 = Component.GetComponent(this,DAT_181d6bfc0);
        if (lVar1 != null) {
          uVar2 = Light.get_intensity(lVar1,0);
          this.baseIntensity = uVar2;
          return;
        }
    }

    // Token : 0x6002384
    // RVA   : 0xBD56C0   Offset: 0xBD3EC0   Length: 0x15
    private void OnEnable()
    {
        void FUN_180bd56c0(int64 this)
        {
        this.minIntensity = this.baseIntensity;
        this.maxIntensity = this.baseIntensity + this.addIntensity;
    }

    // Token : 0x6002385
    // RVA   : 0xBD56E0   Offset: 0xBD3EE0   Length: 0xAA
    private void Update()
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        uint uVar4;
        uint uVar5;
        lVar2 = Component.GetComponent(this,DAT_181d6bfc0);
        uVar5 = this.minIntensity;
        uVar1 = this.maxIntensity;
        fVar3 = (float)Time.get_time(0);
        uVar4 = Mathf.PerlinNoise(this.smoothFactor * fVar3,0,0);
        uVar5 = Mathf.Lerp(uVar5,uVar1,uVar4,0);
        if (lVar2 != null) {
          Light.set_intensity(lVar2,uVar5,0);
          return;
        }
    }

    // Token : 0x6002386
    // RVA   : 0xBD5790   Offset: 0xBD3F90   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180bd5790(int64 this)
        {
        this.smoothFactor = 0x3f800000;
        this.addIntensity = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
