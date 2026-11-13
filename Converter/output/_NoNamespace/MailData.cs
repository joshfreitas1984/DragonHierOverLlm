// ============================================================
// Type  : MailData
// Token : 0x2000220
// ============================================================

public class MailData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F95
    public string mailTitle;

    // Token: 0x4000F96
    public string mailText;

    // Token: 0x4000F97
    public TimeData mailTime;

    // Token: 0x4000F98
    public bool important;

    // Token: 0x4000F99
    public bool noticed;

    // Token: 0x4000F9A
    public int autoDestroyTime;

    // Token: 0x4000F9B
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600108E
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
                         uint8 param_5,uint8 param_6)
        {
        int64 lVar1;
        ZhSegment.Initialize(this,0);
        this.mailTitle = param_2;
        this.mailText = param_3;
        if (param_4 == (int64 *)0) {
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (lVar1 = lVar1.worldTime) == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          param_4 = (int64 *)TimeData.Clone(lVar1,0);
        }
        this.mailTime = param_4;
        this.important = param_5;
        this.notImportant = param_6;
    }

    // Token : 0x600108F
    // RVA   : 0x7CAF00   Offset: 0x7C9D00   Length: 0x18B
    public void /*ctor*/(string _mailTitle, string _mailText, TimeData _mailTime, bool _important, bool _notImportant)
    {
                         uint8 _important,uint8 _notImportant)
        {
        int64 lVar1;
        ZhSegment.Initialize(this,0);
        this.mailTitle = _mailTitle;
        this.mailText = _mailText;
        if (_mailTime == (int64 *)0) {
          if (((GameController._instance == null) ||
              (lVar1 = GameController._instance.worldData) == null) ||
             (lVar1 = lVar1.worldTime) == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          _mailTime = (int64 *)TimeData.Clone(lVar1,0);
        }
        this.mailTime = _mailTime;
        this.important = _important;
        this.notImportant = _notImportant;
    }

    // Token : 0x6001090
    // RVA   : 0x7CAD80   Offset: 0x7C9B80   Length: 0x175
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

}
