// ============================================================
// Type  : MartialClubDataBase
// Token : 0x20001DE
// ============================================================

public class MartialClubDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CB5
    public int id;

    // Token: 0x4000CB6
    public string areaName;

    // Token: 0x4000CB7
    public string goodAtSkillName;

    // Token: 0x4000CB8
    public List<int> skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ED4
    // RVA   : 0x7D1F60   Offset: 0x7D0D60   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar1,DAT_181e71270);
        this.skillID = uVar1;
    }

    // Token : 0x6000ED5
    // RVA   : 0x7D1DB0   Offset: 0x7D0BB0   Length: 0x1A7
    public static MartialClubDataBase FindMartialClub(string areaName)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x1e0)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 24) <= iVar4) {
            return 0;
          }
          lVar2 = FUN_180210740(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x1e0) == 0)) throw; // [null/range check failed]
          lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 0x1e0),iVar4,DAT_181e75bf0);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = FUN_1816387f0(*(uint64 *)(lVar2 + 24),areaName,0);
          if (cVar1) break;
          iVar4 = iVar4 + 1;
        }
        lVar2 = FUN_180210740(0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1e0) != 0)) {
          uVar3 = FUN_1800024b0(*(int64 *)(lVar2 + 0x1e0),iVar4,DAT_181e75bf0);
          return uVar3;
        }
    }

}
