// ============================================================
// Type  : PerspectivePixelPerfect
// Token : 0x200001F
// ============================================================

public class PerspectivePixelPerfect
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000082
    public float bias;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600006C
    // RVA   : 0x210F40   Offset: 0x20FD40   Length: 0xF9
    private void Start()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        float fVar5;
        float fVar6;
        ulong local_38;
        float local_30;
        lVar1 = Component.get_transform(this,0);
        lVar2 = Camera.get_main(0);
        if (lVar2 != null) {
          uVar3 = Camera.get_nearClipPlane(lVar2,0);
          uVar4 = Camera.get_farClipPlane(lVar2,0);
          fVar5 = (float)Mathf.Lerp(uVar3,uVar4,this.bias,0);
          fVar6 = (float)Camera.get_fieldOfView(lVar2,0);
          fVar6 = (float)FUN_1801e7700(fVar6 * 0.017453292 * 0.5);
          if (lVar1 != null) {
            local_38 = 0;
            local_30 = fVar5;
            Transform.set_localPosition(lVar1,&local_38,0);
            local_30 = 1.0;
            local_38 = CONCAT44(fVar6 * fVar5,fVar6 * fVar5);
            Transform.set_localScale(lVar1,&local_38,0);
            return;
          }
        }
    }

    // Token : 0x600006D
    // RVA   : 0x211040   Offset: 0x20FE40   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180211040(int64 this)
        {
        this.bias = 0x3a83126f;
        FUN_180ae8740(this,0);
    }

}
