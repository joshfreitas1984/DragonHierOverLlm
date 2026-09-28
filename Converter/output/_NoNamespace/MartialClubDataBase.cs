// ============================================================
// Type  : MartialClubDataBase
// Token : 0x20001DC
// ============================================================

public class MartialClubDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CA2
    public int id;

    // Token: 0x4000CA3
    public string areaName;

    // Token: 0x4000CA4
    public string goodAtSkillName;

    // Token: 0x4000CA5
    public List<int> skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ECE
    // RVA   : 0xA8D940   Offset: 0xA8CD40   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.skillID = uVar1;
    }

    // Token : 0x6000ECF
    // RVA   : 0xA8D790   Offset: 0xA8CB90   Length: 0x1A7
    public static MartialClubDataBase FindMartialClub(string areaName)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        iVar4 = 0;
        while( true ) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x1d0)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 24) <= iVar4) {
            return 0;
          }
          lVar2 = FUN_18046c100(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 0x1d0) == 0)) throw; // [null/range check failed]
          lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x1d0),iVar4,DAT_181d93988);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = FUN_18171e540(*(uint64 *)(lVar2 + 24),areaName,0);
          if (cVar1) break;
          iVar4 = iVar4 + 1;
        }
        lVar2 = FUN_18046c100(0);
        if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x1d0) != 0)) {
          uVar3 = FUN_180002f80(*(int64 *)(lVar2 + 0x1d0),iVar4,DAT_181d93988);
          return uVar3;
        }
    }

}
