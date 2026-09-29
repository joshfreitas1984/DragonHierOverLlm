// ============================================================
// Type  : CFX_LightFlicker
// Token : 0x20003C8
// ============================================================

public class CFX_LightFlicker
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E59
    public bool loop;

    // Token: 0x4001E5A
    public float smoothFactor;

    // Token: 0x4001E5B
    public float addIntensity;

    // Token: 0x4001E5C
    private float minIntensity;

    // Token: 0x4001E5D
    private float maxIntensity;

    // Token: 0x4001E5E
    private float baseIntensity;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002406
    // RVA   : 0xB805B0   Offset: 0xB7F9B0   Length: 0x53
    private void Awake()
    {
        long lVar1;
        uint uVar2;
        lVar1 = Component.GetComponent(this,DAT_181d947f8);
        if (lVar1 != null) {
          uVar2 = Light.get_intensity(lVar1,0);
          this.baseIntensity = uVar2;
          return;
        }
    }

    // Token : 0x6002407
    // RVA   : 0xB80610   Offset: 0xB7FA10   Length: 0x15
    private void OnEnable()
    {
        void FUN_180b80610(int64 this)
        {
        this.minIntensity = this.baseIntensity;
        this.maxIntensity = this.baseIntensity + this.addIntensity;
    }

    // Token : 0x6002408
    // RVA   : 0xB80630   Offset: 0xB7FA30   Length: 0xAA
    private void Update()
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        uint uVar4;
        uint uVar5;
        lVar2 = Component.GetComponent(this,DAT_181d947f8);
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
    // RVA   : 0xB806E0   Offset: 0xB7FAE0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180b806e0(int64 this)
        {
        this.smoothFactor = 0x3f800000;
        this.addIntensity = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
