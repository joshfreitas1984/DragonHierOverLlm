// ============================================================
// Type  : ReadBookTextTypeData
// Token : 0x2000341
// ============================================================

public class ReadBookTextTypeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B37
    public string showName;

    // Token: 0x4001B38
    public string fullName;

    // Token: 0x4001B39
    public string describe;

    // Token: 0x4001B3A
    public bool simpleText;

    // Token: 0x4001B3B
    public bool negative;

    // Token: 0x4001B3C
    public int minBookItemLv;

    // Token: 0x4001B3D
    public float exp;

    // Token: 0x4001B3E
    public float expRate;

    // Token: 0x4001B3F
    public int patient;

    // Token: 0x4001B40
    public int costPatient;

    // Token: 0x4001B41
    public float numPercent;

    // Token: 0x4001B42
    public float textReadedNumChangePercent;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020FB
    // RVA   : 0xA6A9E0   Offset: 0xA697E0   Length: 0x1A8
    public string GetDescribe()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        local_res8[0] = 0;
        uVar3 = "";
        if (!this.simpleText) {
          uVar3 = this.fullName;
          uVar2 = "red";
          if (!this.negative) {
            uVar2 = "green";
          }
          uVar2 = String.Format("\n<color={0}><i><size=14>{1}</size></i></color>",uVar2,this.describe,0);
          uVar3 = String.Concat(uVar3,uVar2,0);
        }
        if ((this.exp != null.0) && (!this.simpleText)) {
          local_res8[0] = ReadBookTextTypeData.GetExp(this,0);
          uVar2 = Single.ToString(local_res8,"+0;-0;0",0);
          uVar3 = String.Concat(uVar3,"\n经验 ",uVar2,0);
        }
        if (this.costPatient != null) {
          cVar1 = FUN_1816387f0(uVar3,"",0);
          uVar2 = "\n";
          if (cVar1) {
            uVar2 = "";
          }
          uVar4 = Int32.ToString(this + 60,0);
          uVar3 = String.Concat(uVar3,uVar2,"消耗耐心 ",uVar4,0);
          return uVar3;
        }
        return uVar3;
    }

    // Token : 0x60020FC
    // RVA   : 0xA6AC20   Offset: 0xA69A20   Length: 0x112
    public float GetExp()
    {
        var pStatics = *(int64*)(DAT_181e7a058 + 184);
        float fVar1;
        ulong uVar2;
        if (this.exp == null.0) {
          return 0;
        }
        if (0.0 < this.exp) {
          fVar1 = this.textReadedNumChangePercent;
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          Mathf.Max(0,(float)*(int *)(*pStatics + 132) * fVar1 + 1.0,0);
          uVar2 = Mathf.Max(0x3f800000);
          return uVar2;
        }
        ReadBookTextTypeData.GetExpRate(this,0);
        uVar2 = Mathf.Min(0xbf800000);
        return uVar2;
    }

    // Token : 0x60020FD
    // RVA   : 0xA6AB90   Offset: 0xA69990   Length: 0x84
    public float GetExpRate()
    {
        var pStatics = *(int64*)(DAT_181e7a058 + 184);
        float fVar1;
        float fVar2;
        fVar1 = this.expRate;
        fVar2 = this.textReadedNumChangePercent;
        if (*pStatics != 0) {
          fVar2 = (float)Mathf.Max(0,(float)*(int *)(*pStatics + 132) *
                                      fVar2 + 1.0,0);
          return fVar2 * fVar1;
        }
    }

    // Token : 0x60020FE
    // RVA   : 0xA6A860   Offset: 0xA69660   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x60020FF
    // RVA   : 0xA6AD40   Offset: 0xA69B40   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180a6ad40(int64 this)
        {
        this.expRate = 0x3f800000;
        ZhSegment.Initialize(this,0);
    }

}
