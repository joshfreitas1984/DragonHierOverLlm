// ============================================================
// Type  : CFX_LightFlicker
// Token : 0x20003D5
// ============================================================

public class CFX_LightFlicker
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EEB
    public bool loop;

    // Token: 0x4001EEC
    public float smoothFactor;

    // Token: 0x4001EED
    public float addIntensity;

    // Token: 0x4001EEE
    private float minIntensity;

    // Token: 0x4001EEF
    private float maxIntensity;

    // Token: 0x4001EF0
    private float baseIntensity;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024B0
    // RVA   : 0x939860   Offset: 0x938660   Length: 0x53
    private void Awake()
    {
        long lVar1;
        uint uVar2;
        lVar1 = Component.GetComponent(this,DAT_181e77b38);
        if (lVar1 != null) {
          uVar2 = Light.get_intensity(lVar1,0);
          this.baseIntensity = uVar2;
          return;
        }
    }

    // Token : 0x60024B1
    // RVA   : 0x9398C0   Offset: 0x9386C0   Length: 0x15
    private void OnEnable()
    {
        void FUN_1809398c0(int64 this)
        {
        this.minIntensity = this.baseIntensity;
        this.maxIntensity = this.baseIntensity + this.addIntensity;
    }

    // Token : 0x60024B2
    // RVA   : 0x9398E0   Offset: 0x9386E0   Length: 0xAA
    private void Update()
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        uint uVar4;
        uint uVar5;
        lVar2 = Component.GetComponent(this,DAT_181e77b38);
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

    // Token : 0x60024B3
    // RVA   : 0x939990   Offset: 0x938790   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180939990(int64 this)
        {
        this.smoothFactor = 0x3f800000;
        this.addIntensity = 0x3f800000;
        FUN_180ae8740(this,0);
    }

}
