// ============================================================
// Type  : <>c__DisplayClass112_0
// Token : 0x20002AE
// ============================================================

public class <>c__DisplayClass112_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40015A6
    public GameDataController <>4__this;

    // Token: 0x40015A7
    public object gate;

    // Token: 0x40015A8
    public Exception writeError;

    // Token: 0x40015A9
    public Action<string, object> write;

    // Token: 0x40015AA
    public string p0;

    // Token: 0x40015AB
    public string p1;

    // Token: 0x40015AC
    public string p2;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001704
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001705
    // RVA   : 0x67DD60   Offset: 0x67CB60   Length: 0xEB
    internal void <Save>b__0(string p, object d)
    {
        SaveFileIO.WriteJson(p,d,1,DAT_181e87878);
    }

    // Token : 0x6001706
    // RVA   : 0x67DE50   Offset: 0x67CC50   Length: 0x5E
    internal void <Save>b__1()
    {
        long lVar1;
        if (((this.<>4__this != 0) &&
            (lVar1 = *(int64 *)(this.<>4__this + 48)) != null) &&
           (this.write != null)) {
          Action_2.Invoke(this.write,this.p0,
                           *(uint64 *)(lVar1 + 32),DAT_181e79a00);
          return;
        }
    }

    // Token : 0x6001707
    // RVA   : 0x67DEB0   Offset: 0x67CCB0   Length: 0x5E
    internal void <Save>b__2()
    {
        long lVar1;
        if (((this.<>4__this != 0) &&
            (lVar1 = *(int64 *)(this.<>4__this + 48)) != null) &&
           (this.write != null)) {
          Action_2.Invoke(this.write,this.p1,
                           *(uint64 *)(lVar1 + 40),DAT_181e79a00);
          return;
        }
    }

    // Token : 0x6001708
    // RVA   : 0x67DF10   Offset: 0x67CD10   Length: 0x5E
    internal void <Save>b__3()
    {
        long lVar1;
        if (((this.<>4__this != 0) &&
            (lVar1 = *(int64 *)(this.<>4__this + 48)) != null) &&
           (this.write != null)) {
          Action_2.Invoke(this.write,this.p2,
                           *(uint64 *)(lVar1 + 48),DAT_181e79a00);
          return;
        }
    }

}
