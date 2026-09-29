// ============================================================
// Type  : ResourceData
// Token : 0x20001D0
// ============================================================

public class ResourceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C73
    public int resourceType;

    // Token: 0x4000C74
    public float resourceNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EB8
    // RVA   : 0x46E160   Offset: 0x46D560   Length: 0x36
    public void /*ctor*/(int type, float num)
    {
        ZhSegment.Initialize(this,0);
        this.resourceNum = num;
        this.resourceType = type;
    }

    // Token : 0x6000EB9
    // RVA   : 0xD15FB0   Offset: 0xD153B0   Length: 0xCF
    public string GetDescribe()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x438);
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

    // Token : 0x6000EBA
    // RVA   : 0xD16080   Offset: 0xD15480   Length: 0x8B
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

    // Token : 0x6000EBB
    // RVA   : 0xD15E30   Offset: 0xD15230   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
