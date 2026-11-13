// ============================================================
// Type  : MissionDataController
// Token : 0x2000310
// ============================================================

public class MissionDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001961
    public List<MissionData> bountyMissionDataBase;

    // Token: 0x4001962
    public List<MissionData> MainMissionDataBase;

    // Token: 0x4001963
    public List<MissionData> BranchMissionDataBase;

    // Token: 0x4001964
    public List<MissionData> LittleMissionDataBase;

    // Token: 0x4001965
    public MissionData TreasureMapMissionDataBase;

    // Token: 0x4001966
    public MissionData SpeKillerMissionDataBase;

    // Token: 0x4001967
    public List<List<int>> bountyTypeID;

    // Token: 0x4001968
    private static MissionDataController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019BB
    // RVA   : 0x8474A0   Offset: 0x8462A0   Length: 0x36
    public static MissionDataController get_Instance()
    {
        return **(uint64 **)(DAT_181e6adf0 + 184);
    }

    // Token : 0x60019BC
    // RVA   : 0x847110   Offset: 0x845F10   Length: 0x384
    private void Awake()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        uVar4 = **(uint64 **)(DAT_181e6adf0 + 184);
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        plVar1 = *(int64 **)(DAT_181e6adf0 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        uVar4 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar4,0);
        lVar5 = il2cpp_internal(DAT_181e6ffb8);
        FUN_1810f3480(lVar5,DAT_181e5a220);
        uVar4 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar4,DAT_181e71270);
        if (lVar5 != null) {
          FUN_18175de30(lVar5,uVar4,DAT_181e5a330);
          uVar4 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(uVar4,DAT_181e71270);
          FUN_18175de30(lVar5,uVar4,DAT_181e5a330);
          uVar4 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(uVar4,DAT_181e71270);
          FUN_18175de30(lVar5,uVar4,DAT_181e5a330);
          uVar4 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(uVar4,DAT_181e71270);
          FUN_18175de30(lVar5,uVar4,DAT_181e5a330);
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
                  (lVar6 = FUN_1800024b0(this.bountyMissionDataBase,iVar8,DAT_181e76ee0)) == null)
                 || (*(int64 *)(lVar6 + 64) == 0)) throw; // [null/range check failed]
              lVar5 = this.bountyMissionDataBase;
              if (*(int *)(*(int64 *)(lVar6 + 64) + 24) <= iVar7) break;
              lVar6 = this.bountyTypeID;
              if (((lVar5 == null) || (lVar5 = FUN_1800024b0(lVar5,iVar8,DAT_181e76ee0)) == null) ||
                 ((*(int64 *)(lVar5 + 64) == 0 ||
                  ((uVar3 = FUN_180002480(*(int64 *)(lVar5 + 64),iVar7,DAT_181e62978), lVar6 == null ||
                   (lVar5 = FUN_1800024b0(lVar6,uVar3,DAT_181e5a4c8)) == null))))) throw; // [null/range check failed]
              FUN_181769fe0(lVar5,iVar8,DAT_181e713f0);
              iVar7 = iVar7 + 1;
            }
            iVar8 = iVar8 + 1;
          }
        }
    }

    // Token : 0x60019BD
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
