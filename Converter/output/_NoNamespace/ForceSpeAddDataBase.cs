// ============================================================
// Type  : ForceSpeAddDataBase
// Token : 0x20001EA
// ============================================================

public class ForceSpeAddDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000DA0
    public string name;

    // Token: 0x4000DA1
    public string describe;

    // Token: 0x4000DA2
    public bool showPercent;

    // Token: 0x4000DA3
    public float value;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F37
    // RVA   : 0x77EDA0   Offset: 0x77E1A0   Length: 0x41
    public string GetDescribe()
    {
        String.Concat(this.name,":",this.describe,0);
    }

    // Token : 0x6000F38
    // RVA   : 0x77EC20   Offset: 0x77E020   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000F39
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
