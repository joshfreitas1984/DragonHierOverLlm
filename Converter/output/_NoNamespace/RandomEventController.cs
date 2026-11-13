// ============================================================
// Type  : RandomEventController
// Token : 0x2000340
// ============================================================

public class RandomEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B29
    public List<EventData> RandomEventDataBase;

    // Token: 0x4001B2A
    public List<PlotData> EventPlotDataBase;

    // Token: 0x4001B2B
    public List<WorldEventDataBase> worldEventDataBase;

    // Token: 0x4001B2C
    private Dictionary<int, EventData> RandomEventDict;

    // Token: 0x4001B2D
    private Dictionary<int, WorldEventDataBase> WorldEventDict;

    // Token: 0x4001B2E
    public List<int> exploreRandomEventID;

    // Token: 0x4001B2F
    public List<int> bigMapRandomEventID;

    // Token: 0x4001B30
    public List<int> selfForceAreaRandomEventID;

    // Token: 0x4001B31
    public List<int> otherForceAreaRandomEventID;

    // Token: 0x4001B32
    public List<int> cityAreaRandomEventID;

    // Token: 0x4001B33
    public List<int> villageAreaRandomEventID;

    // Token: 0x4001B34
    public List<int> innRandomEventID;

    // Token: 0x4001B35
    public EventData startExternalStorageEventDataBase;

    // Token: 0x4001B36
    private static RandomEventController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020F4
    // RVA   : 0xA62270   Offset: 0xA61070   Length: 0x36
    public static RandomEventController get_Instance()
    {
        return **(uint64 **)(DAT_181e79ad8 + 184);
    }

    // Token : 0x60020F5
    // RVA   : 0xA61A60   Offset: 0xA60860   Length: 0x128
    private void AutoSetEventID()
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        lVar1 = this.RandomEventDataBase;
        uVar3 = 0;
        uVar2 = 0;
        if (lVar1 != null) {
          lVar4 = 32;
          lVar5 = 32;
          do {
            if (lVar1.Count <= (int)uVar2) {
              lVar1 = this.worldEventDataBase;
              if (lVar1 != null) goto LAB_180a61b30;
              break;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar5 + lVar1._items);
            if (lVar1 == null) break;
            lVar1._items = uVar2;
            lVar5 = lVar5 + 8;
            lVar1 = this.RandomEventDataBase;
            uVar2 = uVar2 + 1;
          } while (lVar1 != null);
        }
        throw; // [null/range check failed]
        while( true ) {
          if (lVar1.Count <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(lVar4 + lVar1._items);
          if (lVar1 == null) break;
          lVar1._items = uVar3;
          lVar4 = lVar4 + 8;
          lVar1 = this.worldEventDataBase;
          uVar3 = uVar3 + 1;
          if (lVar1 == null) break;
        LAB_180a61b30:
          if (lVar1.Count <= (int)uVar3) {
            return;
          }
          if (lVar1 == null) break;
        }
    }

    // Token : 0x60020F6
    // RVA   : 0xA61B90   Offset: 0xA60990   Length: 0x290
    private void Awake()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        uVar4 = **(uint64 **)(DAT_181e79ad8 + 184);
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        plVar1 = *(int64 **)(DAT_181e79ad8 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        uVar4 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar4,0);
        lVar6 = this.RandomEventDataBase;
        iVar7 = 0;
        while (lVar6 != null) {
          if (lVar6.Count <= iVar7) {
            return;
          }
          iVar8 = 0;
          while( true ) {
            if (((this.RandomEventDataBase == null) ||
                (lVar5 = FUN_1800024b0(this.RandomEventDataBase,iVar7,DAT_181e68078)) == null) ||
               (*(int64 *)(lVar5 + 40) == 0)) throw; // [null/range check failed]
            lVar6 = this.RandomEventDataBase;
            if (*(int *)(*(int64 *)(lVar5 + 40) + 24) <= iVar8) break;
            if (((lVar6 == null) || (lVar6 = FUN_1800024b0(lVar6,iVar7,DAT_181e68078)) == null) ||
               (*(int64 *)(lVar6 + 40) == 0)) throw; // [null/range check failed]
            uVar3 = FUN_180002480(*(int64 *)(lVar6 + 40),iVar8,DAT_181e67c78);
            switch(uVar3) {
            case 0:
              lVar6 = this.exploreRandomEventID;
              break;
            case 1:
              lVar6 = this.bigMapRandomEventID;
              break;
            case 2:
              lVar6 = this.cityAreaRandomEventID;
              break;
            case 3:
              lVar6 = this.villageAreaRandomEventID;
              break;
            case 4:
              lVar6 = this.selfForceAreaRandomEventID;
              break;
            case 5:
              lVar6 = this.otherForceAreaRandomEventID;
              break;
            case 6:
              lVar6 = this.innRandomEventID;
              break;
            default:
              goto switchD_180a61d8e_default;
            }
            if (((this.RandomEventDataBase == null) ||
                (lVar5 = FUN_1800024b0(this.RandomEventDataBase,iVar7,DAT_181e68078)) == null) ||
               (lVar6 == null)) throw; // [null/range check failed]
            FUN_181769fe0(lVar6,*(uint32 *)(lVar5 + 16),DAT_181e713f0);
        switchD_180a61d8e_default:
            iVar8 = iVar8 + 1;
          }
          iVar7 = iVar7 + 1;
        }
    }

    // Token : 0x60020F7
    // RVA   : 0xA61E40   Offset: 0xA60C40   Length: 0xE3
    public EventData GetRandomEventDataBase(string eventName)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.RandomEventDict == null) {
          uVar4 = il2cpp_internal(DAT_181e60a58);
          FUN_1806e5bc0(uVar4,DAT_181e9aaa8);
          this.RandomEventDict = uVar4;
          lVar5 = this.RandomEventDataBase;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) goto LAB_180a62086;
              lVar2 = this.RandomEventDict;
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar7 + lVar5._items);
              if (lVar5 == null) break;
              lVar3 = this.RandomEventDataBase;
              uVar1 = lVar5._items;
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar2 == null) break;
              FUN_1806da2f0(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181e9ab30
                           );
              lVar5 = this.RandomEventDataBase;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
        else {
        LAB_180a62086:
          if (this.RandomEventDict != null) {
            FUN_18171b450(this.RandomEventDict,eventName,DAT_181e9abb8);
            return;
          }
        }
    }

    // Token : 0x60020F8
    // RVA   : 0xA61F30   Offset: 0xA60D30   Length: 0x195
    public EventData GetRandomEventDataBase(int id)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.RandomEventDict == null) {
          uVar4 = il2cpp_internal(DAT_181e60a58);
          FUN_1806e5bc0(uVar4,DAT_181e9aaa8);
          this.RandomEventDict = uVar4;
          lVar5 = this.RandomEventDataBase;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) goto LAB_180a62086;
              lVar2 = this.RandomEventDict;
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar7 + lVar5._items);
              if (lVar5 == null) break;
              lVar3 = this.RandomEventDataBase;
              uVar1 = lVar5._items;
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar2 == null) break;
              FUN_1806da2f0(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181e9ab30
                           );
              lVar5 = this.RandomEventDataBase;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
        else {
        LAB_180a62086:
          if (this.RandomEventDict != null) {
            FUN_18171b450(this.RandomEventDict,id,DAT_181e9abb8);
            return;
          }
        }
    }

    // Token : 0x60020F9
    // RVA   : 0xA620D0   Offset: 0xA60ED0   Length: 0x195
    public WorldEventDataBase GetWorldEventDataBase(int id)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        if (this.WorldEventDict == null) {
          uVar4 = il2cpp_internal(DAT_181e61a40);
          FUN_1806e5bc0(uVar4,DAT_181ea18f0);
          this.WorldEventDict = uVar4;
          lVar5 = this.worldEventDataBase;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) goto LAB_180a62226;
              lVar2 = this.WorldEventDict;
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = *(int64 *)(lVar7 + lVar5._items);
              if (lVar5 == null) break;
              lVar3 = this.worldEventDataBase;
              uVar1 = lVar5._items;
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar2 == null) break;
              FUN_1806da2f0(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181ea1978
                           );
              lVar5 = this.worldEventDataBase;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
        else {
        LAB_180a62226:
          if (this.WorldEventDict != null) {
            FUN_18171b450(this.WorldEventDict,id,DAT_181ea1a00);
            return;
          }
        }
    }

    // Token : 0x60020FA
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
