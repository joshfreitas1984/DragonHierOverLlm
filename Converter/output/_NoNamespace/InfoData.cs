// ============================================================
// Type  : InfoData
// Token : 0x20001CE
// ============================================================

public class InfoData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C69
    public InfoType infoType;

    // Token: 0x4000C6A
    public TimeData infotime;

    // Token: 0x4000C6B
    public string infoText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EB2
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.infoType = param_2;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 168)) != null) {
          plVar2 = (int64 *)TimeData.Clone(lVar1,0);
          this.infotime = plVar2;
          this.infoText = param_3;
          return;
        }
    }

    // Token : 0x6000EB3
    // RVA   : 0xC98300   Offset: 0xC97700   Length: 0xCA
    public void /*ctor*/(InfoType type, TimeData time, string text)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.infoType = type;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 168)) != null) {
          plVar2 = (int64 *)TimeData.Clone(lVar1,0);
          this.infotime = plVar2;
          this.infoText = time;
          return;
        }
    }

    // Token : 0x6000EB4
    // RVA   : 0xC983D0   Offset: 0xC977D0   Length: 0x151
    public void /*ctor*/(InfoType type, string text)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.infoType = type;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 168)) != null) {
          plVar2 = (int64 *)TimeData.Clone(lVar1,0);
          this.infotime = plVar2;
          this.infoText = text;
          return;
        }
    }

    // Token : 0x6000EB5
    // RVA   : 0xC98180   Offset: 0xC97580   Length: 0x175
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

}
