// ============================================================
// Type  : MailData
// Token : 0x200021E
// ============================================================

public class MailData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F81
    public string mailTitle;

    // Token: 0x4000F82
    public string mailText;

    // Token: 0x4000F83
    public TimeData mailTime;

    // Token: 0x4000F84
    public bool important;

    // Token: 0x4000F85
    public bool noticed;

    // Token: 0x4000F86
    public int autoDestroyTime;

    // Token: 0x4000F87
    public bool notImportant;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001084
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
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
            FUN_1800d6620();
          }
          param_4 = (int64 *)TimeData.Clone(lVar1,0);
        }
        this.mailTime = param_4;
        this.important = param_5;
        this.notImportant = param_6;
    }

    // Token : 0x6001085
    // RVA   : 0xA86FA0   Offset: 0xA863A0   Length: 0x18B
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
            FUN_1800d6620();
          }
          _mailTime = (int64 *)TimeData.Clone(lVar1,0);
        }
        this.mailTime = _mailTime;
        this.important = _important;
        this.notImportant = _notImportant;
    }

    // Token : 0x6001086
    // RVA   : 0xA86E20   Offset: 0xA86220   Length: 0x175
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
