// ============================================================
// Type  : SummonData
// Token : 0x200021E
// ============================================================

public class SummonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F89
    public int id;

    // Token: 0x4000F8A
    public int rareLv;

    // Token: 0x4000F8B
    public string name;

    // Token: 0x4000F8C
    public float baseHp;

    // Token: 0x4000F8D
    public float baseSpeed;

    // Token: 0x4000F8E
    public float baseMoveRange;

    // Token: 0x4000F8F
    public List<int> skillID;

    // Token: 0x4000F90
    public string attackSound;

    // Token: 0x4000F91
    public bool isBuilding;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600108A
    // RVA   : 0x8030D0   Offset: 0x801ED0   Length: 0x1DD
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ushort uVar5;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 uVar6;
        uVar6 = 0;
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar7 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar7);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        BinaryFormatter.Serialize(lVar2,plVar1,this,0);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
        uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
        (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
        lVar2 = *plVar1;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar6 * 16) == DAT_181e58ab8) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar6 * 16) * 16 + 0x138
                       + lVar2);
              goto LAB_180803254;
            }
            uVar5 = (short)uVar6 + 1;
            uVar6 = (uint64)uVar5;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_18019b1f0(plVar1,DAT_181e58ab8,0);
        LAB_180803254:
        (*(code *)*puVar4)(plVar1,puVar4[1]);
        return uVar3;
    }

    // Token : 0x600108B
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
