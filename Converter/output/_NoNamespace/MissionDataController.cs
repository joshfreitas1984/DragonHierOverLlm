// ============================================================
// Type  : MissionDataController
// Token : 0x2000306
// ============================================================

public class MissionDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018EE
    public List<MissionData> bountyMissionDataBase;

    // Token: 0x40018EF
    public List<MissionData> MainMissionDataBase;

    // Token: 0x40018F0
    public List<MissionData> BranchMissionDataBase;

    // Token: 0x40018F1
    public List<MissionData> LittleMissionDataBase;

    // Token: 0x40018F2
    public MissionData TreasureMapMissionDataBase;

    // Token: 0x40018F3
    public MissionData SpeKillerMissionDataBase;

    // Token: 0x40018F4
    public List<List<int>> bountyTypeID;

    // Token: 0x40018F5
    private static MissionDataController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001927
    // RVA   : 0xE63500   Offset: 0xE62900   Length: 0x36
    public static MissionDataController get_Instance()
    {
        return **(uint64 **)(DAT_181d8aa10 + 184);
    }

    // Token : 0x6001928
    // RVA   : 0xE63170   Offset: 0xE62570   Length: 0x384
    private void Awake()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        uVar4 = **(uint64 **)(DAT_181d8aa10 + 184);
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        plVar1 = *(int64 **)(DAT_181d8aa10 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        uVar4 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar4,0);
        lVar5 = il2cpp_internal(DAT_181d90160);
        FUN_18132faf0(lVar5,DAT_181d787a8);
        uVar4 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar4,DAT_181d8f098);
        if (lVar5 != null) {
          FUN_18181e0a0(lVar5,uVar4,DAT_181d78828);
          uVar4 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar4,DAT_181d8f098);
          FUN_18181e0a0(lVar5,uVar4,DAT_181d78828);
          uVar4 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar4,DAT_181d8f098);
          FUN_18181e0a0(lVar5,uVar4,DAT_181d78828);
          uVar4 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar4,DAT_181d8f098);
          FUN_18181e0a0(lVar5,uVar4,DAT_181d78828);
          this.bountyTypeID = lVar5;
          lVar5 = this.bountyMissionDataBase;
          iVar8 = 0;
          while (lVar5 != null) {
            if (lVar5.Count <= iVar8) {
              return;
            }
            iVar7 = 0;
            while( true ) {
              if (((this.bountyMissionDataBase == null) ||
                  (lVar6 = FUN_180002f80(this.bountyMissionDataBase,iVar8,DAT_181d94c88)) == null)
                 || (*(int64 *)(lVar6 + 64) == 0)) throw; // [null/range check failed]
              lVar5 = this.bountyMissionDataBase;
              if (*(int *)(*(int64 *)(lVar6 + 64) + 24) <= iVar7) break;
              lVar6 = this.bountyTypeID;
              if (((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,iVar8,DAT_181d94c88)) == null) ||
                 ((*(int64 *)(lVar5 + 64) == 0 ||
                  ((uVar3 = FUN_1800d6760(*(int64 *)(lVar5 + 64),iVar7,DAT_181d80820), lVar6 == null ||
                   (lVar5 = FUN_180002f80(lVar6,uVar3,DAT_181d789a8)) == null))))) throw; // [null/range check failed]
              FUN_18182a0b0(lVar5,iVar8,DAT_181d8f218);
              iVar7 = iVar7 + 1;
            }
            iVar8 = iVar8 + 1;
          }
        }
    }

    // Token : 0x6001929
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
