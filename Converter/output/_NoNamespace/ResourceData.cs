// ============================================================
// Type  : ResourceData
// Token : 0x20001D2
// ============================================================

public class ResourceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C86
    public int resourceType;

    // Token: 0x4000C87
    public float resourceNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EBE
    // RVA   : 0x212850   Offset: 0x211650   Length: 0x36
    public void /*ctor*/(int type, float num)
    {
        ZhSegment.Initialize(this,0);
        this.resourceNum = num;
        this.resourceType = type;
    }

    // Token : 0x6000EBF
    // RVA   : 0xA6EB00   Offset: 0xA6D900   Length: 0xCF
    public string GetDescribe()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x440);
        if (lVar2 != null) {
          uVar1 = this.resourceType;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar2[uVar1];
          uVar4 = Single.ToString(this + 20,"f0",0);
          String.Concat(uVar3,uVar4,0);
          return;
        }
    }

    // Token : 0x6000EC0
    // RVA   : 0xA6EBD0   Offset: 0xA6D9D0   Length: 0x8B
    public static ResourceData op_Multiply(ResourceData a, int b)
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        if (a != null) {
          uVar2 = *(uint32 *)(a + 16);
          fVar1 = *(float *)(a + 20);
          lVar3 = new ZhSegment(0);
          *(uint32 *)(lVar3 + 16) = uVar2;
          *(float *)(lVar3 + 20) = (float)b * fVar1;
          return lVar3;
        }
    }

    // Token : 0x6000EC1
    // RVA   : 0xA6EA90   Offset: 0xA6D890   Length: 0x6A
    public virtual object Clone()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        uVar2 = this.resourceType;
        uVar1 = this.resourceNum;
        lVar3 = new ZhSegment(0);
        *(uint32 *)(lVar3 + 20) = uVar1;
        *(uint32 *)(lVar3 + 16) = uVar2;
        return lVar3;
    }

}
