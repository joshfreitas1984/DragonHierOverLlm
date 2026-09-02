// ============================================================
// Type  : MartialClubDataBase
// Token : 0x20001D6
// ============================================================

public class MartialClubDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C15
    public int id;

    // Token: 0x4000C16
    public string areaName;

    // Token: 0x4000C17
    public string goodAtSkillName;

    // Token: 0x4000C18
    public List<int> skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E99
    // RVA   : 0xA8E920   Offset: 0xA8D120   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.skillID = uVar1;
    }

    // Token : 0x6000E9A
    // RVA   : 0xA8E770   Offset: 0xA8CF70   Length: 0x1A7
    public static MartialClubDataBase FindMartialClub(string areaName)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x1d0)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 24) <= iVar4) {
            return 0;
          }
          lVar2 = FUN_18046c100(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x1d0) == 0)) throw; // [null/range check failed]
          lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x1d0),iVar4,DAT_181d6c1e8);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = FUN_1816fd990(*(uint64 *)(lVar2 + 24),areaName,0);
          if (cVar1) break;
          iVar4 = iVar4 + 1;
        }
        lVar2 = FUN_18046c100(0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1d0) != 0)) {
          uVar3 = FUN_180002f80(*(int64 *)(lVar2 + 0x1d0),iVar4,DAT_181d6c1e8);
          return uVar3;
        }
    }

}
