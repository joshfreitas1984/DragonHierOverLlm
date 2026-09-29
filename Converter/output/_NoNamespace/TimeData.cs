// ============================================================
// Type  : TimeData
// Token : 0x20001D1
// ============================================================

public class TimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C75
    public int year;

    // Token: 0x4000C76
    public int month;

    // Token: 0x4000C77
    public int day;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EBC
    // RVA   : 0x984410   Offset: 0x983810   Length: 0x44
    public void /*ctor*/(int _year, int _month, int _day)
    {
        void SkillDamageRangeData.ctor
                     (int64 this,uint32 _year,uint32 _month,uint32 _day)
        {
        ZhSegment.Initialize(this,0);
        this.year = _year;
        this.month = _month;
        this.day = _day;
    }

    // Token : 0x6000EBD
    // RVA   : 0xAA5840   Offset: 0xAA4C40   Length: 0x17
    public bool IsMeetingTime()
    {
        if ((this.year < 2) && (this.month < 3)) {
          return false;
        }
        return this.day < 6;
    }

    // Token : 0x6000EBE
    // RVA   : 0xAA5860   Offset: 0xAA4C60   Length: 0x9
    public int NextMeetingTime()
    {
        return 31 - this.day;
    }

    // Token : 0x6000EBF
    // RVA   : 0xAA5710   Offset: 0xAA4B10   Length: 0x33
    public int DeltaDay(TimeData targetTime)
    {
        if (targetTime != null) {
          return ((((this.year - *(int *)(targetTime + 16)) * 12 - *(int *)(targetTime + 20)
                   ) + this.month) * 30 - *(int *)(targetTime + 24)) +
                 this.day;
        }
    }

    // Token : 0x6000EC0
    // RVA   : 0xAA5750   Offset: 0xAA4B50   Length: 0xA7
    public string GetDescribe()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[4];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        local_res8[0] = this.year;
        uVar1 = il2cpp_value_box(DAT_181d80430,local_res8);
        local_res18[0] = this.month;
        uVar2 = il2cpp_value_box(DAT_181d80430,local_res18);
        local_res20[0] = this.day;
        uVar3 = il2cpp_value_box(DAT_181d80430,local_res20);
        String.Format("{0}年{1}月{2}日",uVar1,uVar2,uVar3,0);
    }

    // Token : 0x6000EC1
    // RVA   : 0xAA5800   Offset: 0xAA4C00   Length: 0x39
    public float GetExactYear()
    {
        return (float)(this.month + -1) / 12.0 + (float)this.year +
               (float)(this.day + -1) / 360.0;
    }

    // Token : 0x6000EC2
    // RVA   : 0xAA5590   Offset: 0xAA4990   Length: 0x175
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
