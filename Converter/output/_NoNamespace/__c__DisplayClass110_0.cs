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
    // RVA   : 0x9372B0   Offset: 0x9366B0   Length: 0x1ED
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
        uVar3 = JsonConvert.DeserializeObject(uVar3,lVar4,DAT_181d803a8);
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

    // Token : 0x600168F
    // RVA   : 0x9374A0   Offset: 0x9368A0   Length: 0x1EE
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
        uVar3 = JsonConvert.DeserializeObject(uVar3,lVar4,DAT_181d801a8);
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

    // Token : 0x6001690
    // RVA   : 0x937690   Offset: 0x936A90   Length: 0x1EE
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
        uVar3 = JsonConvert.DeserializeObject(uVar3,lVar4,DAT_181d801a8);
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
