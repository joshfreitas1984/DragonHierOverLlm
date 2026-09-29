// ============================================================
// Type  : RandomEventController
// Token : 0x2000336
// ============================================================

public class RandomEventController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AAF
    public List<EventData> RandomEventDataBase;

    // Token: 0x4001AB0
    public List<PlotData> EventPlotDataBase;

    // Token: 0x4001AB1
    public List<WorldEventDataBase> worldEventDataBase;

    // Token: 0x4001AB2
    private Dictionary<int, EventData> RandomEventDict;

    // Token: 0x4001AB3
    private Dictionary<int, WorldEventDataBase> WorldEventDict;

    // Token: 0x4001AB4
    public List<int> exploreRandomEventID;

    // Token: 0x4001AB5
    public List<int> bigMapRandomEventID;

    // Token: 0x4001AB6
    public List<int> selfForceAreaRandomEventID;

    // Token: 0x4001AB7
    public List<int> otherForceAreaRandomEventID;

    // Token: 0x4001AB8
    public List<int> cityAreaRandomEventID;

    // Token: 0x4001AB9
    public List<int> villageAreaRandomEventID;

    // Token: 0x4001ABA
    public List<int> innRandomEventID;

    // Token: 0x4001ABB
    public EventData startExternalStorageEventDataBase;

    // Token: 0x4001ABC
    private static RandomEventController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002055
    // RVA   : 0xD09610   Offset: 0xD08A10   Length: 0x36
    public static RandomEventController get_Instance()
    {
        return **(uint64 **)(DAT_181d99718 + 184);
    }

    // Token : 0x6002056
    // RVA   : 0xD08E00   Offset: 0xD08200   Length: 0x128
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
              if (lVar1 != null) goto LAB_180d08ed0;
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
        LAB_180d08ed0:
          if (lVar1.Count <= (int)uVar3) {
            return;
          }
          if (lVar1 == null) break;
        }
    }

    // Token : 0x6002057
    // RVA   : 0xD08F30   Offset: 0xD08330   Length: 0x290
    private void Awake()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        uVar4 = **(uint64 **)(DAT_181d99718 + 184);
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        plVar1 = *(int64 **)(DAT_181d99718 + 184);
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
                (lVar5 = FUN_180002f80(this.RandomEventDataBase,iVar7,DAT_181d85e38)) == null) ||
               (*(int64 *)(lVar5 + 40) == 0)) throw; // [null/range check failed]
            lVar6 = this.RandomEventDataBase;
            if (*(int *)(*(int64 *)(lVar5 + 40) + 24) <= iVar8) break;
            if (((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,iVar7,DAT_181d85e38)) == null) ||
               (*(int64 *)(lVar6 + 40) == 0)) throw; // [null/range check failed]
            uVar3 = FUN_1800d6760(*(int64 *)(lVar6 + 40),iVar8,DAT_181d85a38);
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
              goto switchD_180d0912e_default;
            }
            if (((this.RandomEventDataBase == null) ||
                (lVar5 = FUN_180002f80(this.RandomEventDataBase,iVar7,DAT_181d85e38)) == null) ||
               (lVar6 == null)) throw; // [null/range check failed]
            FUN_18182a6c0(lVar6,*(uint32 *)(lVar5 + 16),DAT_181d8f230);
        switchD_180d0912e_default:
            iVar8 = iVar8 + 1;
          }
          iVar7 = iVar7 + 1;
        }
    }

    // Token : 0x6002058
    // RVA   : 0xD091E0   Offset: 0xD085E0   Length: 0xE3
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
          uVar4 = il2cpp_internal(DAT_181d80c80);
          FUN_1808b1370(uVar4,DAT_181db94d0);
          this.RandomEventDict = uVar4;
          lVar5 = this.RandomEventDataBase;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) goto LAB_180d09426;
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
              FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181db9558
                           );
              lVar5 = this.RandomEventDataBase;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
        else {
        LAB_180d09426:
          if (this.RandomEventDict != null) {
            FUN_1817da420(this.RandomEventDict,eventName,DAT_181db95e0);
            return;
          }
        }
    }

    // Token : 0x6002059
    // RVA   : 0xD092D0   Offset: 0xD086D0   Length: 0x195
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
          uVar4 = il2cpp_internal(DAT_181d80c80);
          FUN_1808b1370(uVar4,DAT_181db94d0);
          this.RandomEventDict = uVar4;
          lVar5 = this.RandomEventDataBase;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) goto LAB_180d09426;
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
              FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181db9558
                           );
              lVar5 = this.RandomEventDataBase;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
        else {
        LAB_180d09426:
          if (this.RandomEventDict != null) {
            FUN_1817da420(this.RandomEventDict,id,DAT_181db95e0);
            return;
          }
        }
    }

    // Token : 0x600205A
    // RVA   : 0xD09470   Offset: 0xD08870   Length: 0x195
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
          uVar4 = il2cpp_internal(DAT_181d81c80);
          FUN_1808b1370(uVar4,DAT_181dc0070);
          this.WorldEventDict = uVar4;
          lVar5 = this.worldEventDataBase;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar7 = 32;
            do {
              if (lVar5.Count <= (int)uVar6) goto LAB_180d095c6;
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
              FUN_1808ab370(lVar2,uVar1,*(uint64 *)(lVar3._items + lVar7),DAT_181dc00f8
                           );
              lVar5 = this.worldEventDataBase;
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar5 != null);
          }
        }
        else {
        LAB_180d095c6:
          if (this.WorldEventDict != null) {
            FUN_1817da420(this.WorldEventDict,id,DAT_181dc0180);
            return;
          }
        }
    }

    // Token : 0x600205B
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
