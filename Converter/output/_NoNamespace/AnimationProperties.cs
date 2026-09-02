// ============================================================
// Type  : AnimationProperties
// Token : 0x20000BE
// ============================================================

public class AnimationProperties
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400047A
    public AnimationLetterOrder animationOrder;

    // Token: 0x400047B
    public float overlap;

    // Token: 0x400047C
    public bool randomDurations;

    // Token: 0x400047D
    public Vector2 randomness;

    // Token: 0x400047E
    public Vector2 offsetRange;

    // Token: 0x400047F
    public Vector3 pos;

    // Token: 0x4000480
    public Vector3 rot;

    // Token: 0x4000481
    public Vector3 scale;

    // Token: 0x4000482
    public float alpha;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005B9
    // RVA   : 0xB05060   Offset: 0xB03860   Length: 0xAE
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        uint8 local_18 [16];
        this.animationOrder = 2;
        this.overlap = 0x3f000000;
        this.randomness = 0x3e800000;
        *(uint32 *)(this + 32) = 0x3f400000;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.offsetRange = local_res8;
        *(uint32 *)(this + 40) = uStackX_c;
        puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
        this.pos = *puVar2;
        *(uint32 *)(this + 52) = *(uint32 *)(puVar2 + 1);
        puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
        this.rot = *puVar2;
        *(uint32 *)(this + 64) = *(uint32 *)(puVar2 + 1);
        puVar2 = (uint64 *)Vector3.get_one(local_18,0);
        this.scale = *puVar2;
        *(uint32 *)(this + 76) = *(uint32 *)(puVar2 + 1);
        this.alpha = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
