// ============================================================
// Type  : <>c__DisplayClass110_0
// Token : 0x20002A6
// ============================================================

public class <>c__DisplayClass110_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400155E
    public GameDataController <>4__this;

    // Token: 0x400155F
    public int saveID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600168D
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600168E
    // RVA   : 0x937AF0   Offset: 0x936EF0   Length: 0x15B
    internal void <Load>b__0()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar2 = this.<>4__this;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *(int64 *)(lVar2 + 48);
        uVar4 = GameDataController.GetSaveDataPath(lVar2,this.saveID,0,0);
        uVar4 = SaveFileIO.ReadJson(uVar4,DAT_181da41f8);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        puVar1 = (uint64 *)(lVar3 + 32);
        *puVar1 = uVar4;
        il2cpp_internal(puVar1,uVar4);
        if (this.<>4__this != 0) {
          lVar2 = *(int64 *)(this.<>4__this + 48);
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 24) = 1;
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600168F
    // RVA   : 0x937C50   Offset: 0x937050   Length: 0x15C
    internal void <Load>b__1()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar2 = this.<>4__this;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *(int64 *)(lVar2 + 48);
        uVar4 = GameDataController.GetSaveDataPath(lVar2,this.saveID,1);
        uVar4 = SaveFileIO.ReadJson(uVar4,DAT_181da40f8);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        puVar1 = (uint64 *)(lVar3 + 40);
        *puVar1 = uVar4;
        il2cpp_internal(puVar1,uVar4);
        if (this.<>4__this != 0) {
          lVar2 = *(int64 *)(this.<>4__this + 48);
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 25) = 1;
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6001690
    // RVA   : 0x937DB0   Offset: 0x9371B0   Length: 0x15C
    internal void <Load>b__2()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar2 = this.<>4__this;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = *(int64 *)(lVar2 + 48);
        uVar4 = GameDataController.GetSaveDataPath(lVar2,this.saveID,2);
        uVar4 = SaveFileIO.ReadJson(uVar4,DAT_181da40f8);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        puVar1 = (uint64 *)(lVar3 + 48);
        *puVar1 = uVar4;
        il2cpp_internal(puVar1,uVar4);
        if (this.<>4__this != 0) {
          lVar2 = *(int64 *)(this.<>4__this + 48);
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 26) = 1;
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
