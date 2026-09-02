// ============================================================
// Type  : <>c__DisplayClass110_0
// Token : 0x20002A0
// ============================================================

public class <>c__DisplayClass110_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014AC
    public GameDataController <>4__this;

    // Token: 0x40014AD
    public int saveID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001649
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600164A
    // RVA   : 0x8D4D00   Offset: 0x8D3500   Length: 0x1ED
    internal void <Load>b__0()
    {
        long lVar2;
        ulong uVar3;
        long lVar4;
        lVar4 = this.<>4__this;
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = *(int64 *)(lVar4 + 48);
        uVar3 = GameDataController.GetSaveDataPath(lVar4,this.saveID,0,0);
        uVar3 = File.ReadAllText(uVar3,0);
        lVar4 = new JsonSerializerSettings(0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        JsonSerializerSettings.set_ObjectCreationHandling(lVar4,2);
        uVar3 = JsonConvert.DeserializeObject(uVar3,lVar4,DAT_181d57740);
        if (lVar2 != null) {
          puVar1 = (uint64 *)(lVar2 + 32);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *(int64 *)(this.<>4__this + 48);
          if (lVar4 != null) {
            *(uint8 *)(lVar4 + 24) = 1;
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600164B
    // RVA   : 0x8D4EF0   Offset: 0x8D36F0   Length: 0x1EE
    internal void <Load>b__1()
    {
        long lVar2;
        ulong uVar3;
        long lVar4;
        lVar4 = this.<>4__this;
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = *(int64 *)(lVar4 + 48);
        uVar3 = GameDataController.GetSaveDataPath(lVar4,this.saveID,1);
        uVar3 = File.ReadAllText(uVar3,0);
        lVar4 = new JsonSerializerSettings(0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        JsonSerializerSettings.set_ObjectCreationHandling(lVar4,2);
        uVar3 = JsonConvert.DeserializeObject(uVar3,lVar4,DAT_181d57548);
        if (lVar2 != null) {
          puVar1 = (uint64 *)(lVar2 + 40);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *(int64 *)(this.<>4__this + 48);
          if (lVar4 != null) {
            *(uint8 *)(lVar4 + 25) = 1;
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x600164C
    // RVA   : 0x8D50E0   Offset: 0x8D38E0   Length: 0x1EE
    internal void <Load>b__2()
    {
        long lVar2;
        ulong uVar3;
        long lVar4;
        lVar4 = this.<>4__this;
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = *(int64 *)(lVar4 + 48);
        uVar3 = GameDataController.GetSaveDataPath(lVar4,this.saveID,2);
        uVar3 = File.ReadAllText(uVar3,0);
        lVar4 = new JsonSerializerSettings(0);
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        JsonSerializerSettings.set_ObjectCreationHandling(lVar4,2);
        uVar3 = JsonConvert.DeserializeObject(uVar3,lVar4,DAT_181d57548);
        if (lVar2 != null) {
          puVar1 = (uint64 *)(lVar2 + 48);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          if (this.<>4__this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *(int64 *)(this.<>4__this + 48);
          if (lVar4 != null) {
            *(uint8 *)(lVar4 + 26) = 1;
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
