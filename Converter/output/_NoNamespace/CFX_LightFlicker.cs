// ============================================================
// Type  : CFX_LightFlicker
// Token : 0x20003C8
// ============================================================

public class CFX_LightFlicker
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E58
    public bool loop;

    // Token: 0x4001E59
    public float smoothFactor;

    // Token: 0x4001E5A
    public float addIntensity;

    // Token: 0x4001E5B
    private float minIntensity;

    // Token: 0x4001E5C
    private float maxIntensity;

    // Token: 0x4001E5D
    private float baseIntensity;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002406
    // RVA   : 0xB7FEF0   Offset: 0xB7F2F0   Length: 0x53
    private void Awake()
    {
        long lVar1;
        uint uVar2;
        lVar1 = Component.GetComponent(this,DAT_181d947e0);
        if (lVar1 != null) {
          uVar2 = Light.get_intensity(lVar1,0);
          this.baseIntensity = uVar2;
          return;
        }
    }

    // Token : 0x6002407
    // RVA   : 0xB7FF50   Offset: 0xB7F350   Length: 0x15
    private void OnEnable()
    {
        void FUN_180b7ff50(int64 this)
        {
        this.minIntensity = this.baseIntensity;
        this.maxIntensity = this.baseIntensity + this.addIntensity;
    }

    // Token : 0x6002408
    // RVA   : 0xB7FF70   Offset: 0xB7F370   Length: 0xAA
    private void Update()
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        uint uVar4;
        uint uVar5;
        lVar2 = Component.GetComponent(this,DAT_181d947e0);
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

    // Token : 0x6002409
    // RVA   : 0xB80020   Offset: 0xB7F420   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180b80020(int64 this)
        {
        this.smoothFactor = 0x3f800000;
        this.addIntensity = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
