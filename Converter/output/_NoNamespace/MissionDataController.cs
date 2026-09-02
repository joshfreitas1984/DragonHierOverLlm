// ============================================================
// Type  : MissionDataController
// Token : 0x20002FF
// ============================================================

public class MissionDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001800
    public List<MissionData> bountyMissionDataBase;

    // Token: 0x4001801
    public List<MissionData> MainMissionDataBase;

    // Token: 0x4001802
    public List<MissionData> BranchMissionDataBase;

    // Token: 0x4001803
    public List<MissionData> LittleMissionDataBase;

    // Token: 0x4001804
    public MissionData TreasureMapMissionDataBase;

    // Token: 0x4001805
    public MissionData SpeKillerMissionDataBase;

    // Token: 0x4001806
    public List<List<int>> bountyTypeID;

    // Token: 0x4001807
    private static MissionDataController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018CA
    // RVA   : 0xAE9650   Offset: 0xAE7E50   Length: 0x36
    public static MissionDataController get_Instance()
    {
        return **(uint64 **)(DAT_181d657f0 + 184);
    }

    // Token : 0x60018CB
    // RVA   : 0xAE92C0   Offset: 0xAE7AC0   Length: 0x384
    private void Awake()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        uVar4 = **(uint64 **)(DAT_181d657f0 + 184);
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        plVar1 = *(int64 **)(DAT_181d657f0 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        uVar4 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar4,0);
        lVar5 = il2cpp_internal(DAT_181d6b5b0);
        FUN_180f58a90(lVar5,DAT_181d51488);
        uVar4 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar4,DAT_181d678f8);
        if (lVar5 != null) {
          FUN_181827900(lVar5,uVar4,DAT_181d51508);
          uVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar4,DAT_181d678f8);
          FUN_181827900(lVar5,uVar4,DAT_181d51508);
          uVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar4,DAT_181d678f8);
          FUN_181827900(lVar5,uVar4,DAT_181d51508);
          uVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar4,DAT_181d678f8);
          FUN_181827900(lVar5,uVar4,DAT_181d51508);
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
                  (lVar6 = FUN_180002f80(this.bountyMissionDataBase,iVar8,DAT_181d6d4e8)) == null)
                 || (*(int64 *)(lVar6 + 64) == 0)) throw; // [null/range check failed]
              lVar5 = this.bountyMissionDataBase;
              if (*(int *)(*(int64 *)(lVar6 + 64) + 24) <= iVar7) break;
              lVar6 = this.bountyTypeID;
              if (((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,iVar8,DAT_181d6d4e8)) == null) ||
                 ((*(int64 *)(lVar5 + 64) == 0 ||
                  ((uVar3 = FUN_1800d6750(*(int64 *)(lVar5 + 64),iVar7,DAT_181d59090), lVar6 == null ||
                   (lVar5 = FUN_180002f80(lVar6,uVar3,DAT_181d51688)) == null))))) throw; // [null/range check failed]
              FUN_181814fa0(lVar5,iVar8,DAT_181d67a78);
              iVar7 = iVar7 + 1;
            }
            iVar8 = iVar8 + 1;
          }
        }
    }

    // Token : 0x60018CC
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
