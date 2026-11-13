// ============================================================
// Type  : TimeData
// Token : 0x20001D3
// ============================================================

public class TimeData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C88
    public int year;

    // Token: 0x4000C89
    public int month;

    // Token: 0x4000C8A
    public int day;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EC2
    // RVA   : 0x6AC030   Offset: 0x6AAE30   Length: 0x44
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

    // Token : 0x6000EC3
    // RVA   : 0x814A80   Offset: 0x813880   Length: 0x17
    public bool IsMeetingTime()
    {
        if ((this.year < 2) && (this.month < 3)) {
          return false;
        }
        return this.day < 6;
    }

    // Token : 0x6000EC4
    // RVA   : 0x814AA0   Offset: 0x8138A0   Length: 0x9
    public int NextMeetingTime()
    {
        return 31 - this.day;
    }

    // Token : 0x6000EC5
    // RVA   : 0x814950   Offset: 0x813750   Length: 0x33
    public int DeltaDay(TimeData targetTime)
    {
        if (targetTime != null) {
          return ((((this.year - *(int *)(targetTime + 16)) * 12 - *(int *)(targetTime + 20)
                   ) + this.month) * 30 - *(int *)(targetTime + 24)) +
                 this.day;
        }
    }

    // Token : 0x6000EC6
    // RVA   : 0x814990   Offset: 0x813790   Length: 0xA7
    public string GetDescribe()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[4];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        local_res8[0] = this.year;
        uVar1 = il2cpp_value_box(DAT_181e60808,local_res8);
        local_res18[0] = this.month;
        uVar2 = il2cpp_value_box(DAT_181e60808,local_res18);
        local_res20[0] = this.day;
        uVar3 = il2cpp_value_box(DAT_181e60808,local_res20);
        String.Format("{0}年{1}月{2}日",uVar1,uVar2,uVar3,0);
    }

    // Token : 0x6000EC7
    // RVA   : 0x814A40   Offset: 0x813840   Length: 0x39
    public float GetExactYear()
    {
        return (float)(this.month + -1) / 12.0 + (float)this.year +
               (float)(this.day + -1) / 360.0;
    }

    // Token : 0x6000EC8
    // RVA   : 0x8148D0   Offset: 0x8136D0   Length: 0x76
    public virtual object Clone()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        uVar1 = this.year;
        uVar2 = this.month;
        uVar3 = this.day;
        lVar4 = new ZhSegment(0);
        *(uint32 *)(lVar4 + 20) = uVar2;
        *(uint32 *)(lVar4 + 24) = uVar3;
        *(uint32 *)(lVar4 + 16) = uVar1;
        return lVar4;
    }

}
