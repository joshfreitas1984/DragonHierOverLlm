// ============================================================
// Type  : <>c__DisplayClass113_0
// Token : 0x20002AF
// ============================================================

public class <>c__DisplayClass113_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40015AD
    public GameDataController <>4__this;

    // Token: 0x40015AE
    public int saveID;

    // Token: 0x40015AF
    public Stopwatch loadWatch;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001709
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600170A
    // RVA   : 0x67DF70   Offset: 0x67CD70   Length: 0x2E1
    internal void <Load>b__0()
    {
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long[] local_res8 = new long[2];
        ulong local_res18;
        long local_res20;
        local_res8[0] = this;
        local_res18 = 0;
        lVar4 = Stopwatch.StartNew(0);
        lVar2 = this.<>4__this;
        local_res20 = lVar4;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar3 = *(int64 *)(lVar2 + 48);
        uVar5 = GameDataController.GetSaveDataPath(lVar2,this.saveID,0,0);
        uVar5 = SaveFileIO.ReadJson(uVar5,DAT_181e877f8);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        puVar1 = (uint64 *)(lVar3 + 32);
        *puVar1 = uVar5;
        il2cpp_internal(puVar1,uVar5);
        if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar2 = *(int64 *)(this.<>4__this + 48);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        *(uint8 *)(lVar2 + 24) = 1;
        if (lVar4 != null) {
          Stopwatch.Stop(lVar4,0);
          local_res8[0] = Stopwatch.get_ElapsedMilliseconds(lVar4,0);
          uVar5 = il2cpp_value_box(DAT_181e60a80,local_res8);
          if (this.loadWatch != null) {
            local_res18 = Stopwatch.get_ElapsedMilliseconds(this.loadWatch,0);
            uVar6 = il2cpp_value_box(DAT_181e60a80,&local_res18);
            uVar5 = String.Format("[Load] World 读完 {0}ms（距开始 {1}ms）",uVar5,uVar6,0);
            Debug.Log(uVar5,0);
            return;
          }
        }
    }

    // Token : 0x600170B
    // RVA   : 0x67E260   Offset: 0x67D060   Length: 0x2E2
    internal void <Load>b__1()
    {
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long[] local_res8 = new long[2];
        ulong local_res18;
        long local_res20;
        local_res8[0] = this;
        local_res18 = 0;
        lVar4 = Stopwatch.StartNew(0);
        lVar2 = this.<>4__this;
        local_res20 = lVar4;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar3 = *(int64 *)(lVar2 + 48);
        uVar5 = GameDataController.GetSaveDataPath(lVar2,this.saveID,1);
        uVar5 = SaveFileIO.ReadJson(uVar5,DAT_181e876f8);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        puVar1 = (uint64 *)(lVar3 + 40);
        *puVar1 = uVar5;
        il2cpp_internal(puVar1,uVar5);
        if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar2 = *(int64 *)(this.<>4__this + 48);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        *(uint8 *)(lVar2 + 25) = 1;
        if (lVar4 != null) {
          Stopwatch.Stop(lVar4,0);
          local_res8[0] = Stopwatch.get_ElapsedMilliseconds(lVar4,0);
          uVar5 = il2cpp_value_box(DAT_181e60a80,local_res8);
          if (this.loadWatch != null) {
            local_res18 = Stopwatch.get_ElapsedMilliseconds(this.loadWatch,0);
            uVar6 = il2cpp_value_box(DAT_181e60a80,&local_res18);
            uVar5 = String.Format("[Load] Hero 读完 {0}ms（距开始 {1}ms）",uVar5,uVar6,0);
            Debug.Log(uVar5,0);
            return;
          }
        }
    }

    // Token : 0x600170C
    // RVA   : 0x67E550   Offset: 0x67D350   Length: 0x2E2
    internal void <Load>b__2()
    {
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long[] local_res8 = new long[2];
        ulong local_res18;
        long local_res20;
        local_res8[0] = this;
        local_res18 = 0;
        lVar4 = Stopwatch.StartNew(0);
        lVar2 = this.<>4__this;
        local_res20 = lVar4;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar3 = *(int64 *)(lVar2 + 48);
        uVar5 = GameDataController.GetSaveDataPath(lVar2,this.saveID,2);
        uVar5 = SaveFileIO.ReadJson(uVar5,DAT_181e876f8);
        if (lVar3 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        puVar1 = (uint64 *)(lVar3 + 48);
        *puVar1 = uVar5;
        il2cpp_internal(puVar1,uVar5);
        if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar2 = *(int64 *)(this.<>4__this + 48);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        *(uint8 *)(lVar2 + 26) = 1;
        if (lVar4 != null) {
          Stopwatch.Stop(lVar4,0);
          local_res8[0] = Stopwatch.get_ElapsedMilliseconds(lVar4,0);
          uVar5 = il2cpp_value_box(DAT_181e60a80,local_res8);
          if (this.loadWatch != null) {
            local_res18 = Stopwatch.get_ElapsedMilliseconds(this.loadWatch,0);
            uVar6 = il2cpp_value_box(DAT_181e60a80,&local_res18);
            uVar5 = String.Format("[Load] TempHero 读完 {0}ms（距开始 {1}ms）",uVar5,uVar6,0);
            Debug.Log(uVar5,0);
            return;
          }
        }
    }

}
