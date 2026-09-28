// ============================================================
// Type  : InvStat
// Token : 0x2000012
// ============================================================

public class InvStat
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000070
    public Identifier id;

    // Token: 0x4000071
    public Modifier modifier;

    // Token: 0x4000072
    public int amount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600005A
    // RVA   : 0xC9D090   Offset: 0xC9C490   Length: 0x75
    public static string GetName(Identifier i)
    {
        ulong uVar2;
        uint[] local_res8 = new uint[2];
        local_res8[0] = i;
        plVar1 = (int64 *)il2cpp_value_box(DAT_181d7afa8,local_res8);
        if (plVar1 != (int64 *)0) {
          uVar2 = (**(code **)(*plVar1 + 0x168))(plVar1,*(uint64 *)(*plVar1 + 0x170));
          il2cpp_object_unbox(plVar1);
          return uVar2;
        }
    }

    // Token : 0x600005B
    // RVA   : 0xC9CF40   Offset: 0xC9C340   Length: 0x98
    public static string GetDescription(Identifier i)
    {
        switch(i) {
        case 0:
          return "Strength increases melee damage";
        case 1:
          return "Constitution increases health";
        case 2:
          return "Agility increases armor";
        case 3:
          return "Intelligence increases mana";
        case 4:
          return "Damage adds to the amount of damage done in combat";
        case 5:
          return "Crit increases the chance of landing a critical strike";
        case 6:
          return "Armor protects from damage";
        case 7:
          return "Health prolongs life";
        case 8:
          return "Mana increases the number of spells that can be cast";
        default:
          return 0;
        }
    }

    // Token : 0x600005C
    // RVA   : 0xC9CDC0   Offset: 0xC9C1C0   Length: 0xB1
    public static int CompareArmor(InvStat a, InvStat b)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        if (a != null) {
          iVar2 = *(int *)(a + 16);
          if (b != null) {
            iVar1 = *(int *)(b + 16);
            if (iVar2 == 6) {
              iVar2 = -0x270a;
            }
            else if (iVar2 == 4) {
              iVar2 = -0x1384;
            }
            if (iVar1 == 6) {
              iVar1 = -0x270a;
            }
            else if (iVar1 == 4) {
              iVar1 = -0x1384;
            }
            iVar3 = iVar2 + 1000;
            if (-1 < *(int *)(a + 24)) {
              iVar3 = iVar2;
            }
            iVar2 = iVar1 + 1000;
            if (-1 < *(int *)(b + 24)) {
              iVar2 = iVar1;
            }
            iVar1 = iVar3 + 100;
            if (*(int *)(a + 20) != 1) {
              iVar1 = iVar3;
            }
            iVar3 = iVar2 + 100;
            if (*(int *)(b + 20) != 1) {
              iVar3 = iVar2;
            }
            if (iVar3 <= iVar1) {
              return (uint64)(iVar3 < iVar1);
            }
            return 0xffffffff;
          }
        }
    }

    // Token : 0x600005D
    // RVA   : 0xC9CE80   Offset: 0xC9C280   Length: 0xB1
    public static int CompareWeapon(InvStat a, InvStat b)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        if (a != null) {
          iVar2 = *(int *)(a + 16);
          if (b != null) {
            iVar1 = *(int *)(b + 16);
            if (iVar2 == 4) {
              iVar2 = -0x270c;
            }
            else if (iVar2 == 6) {
              iVar2 = -0x1382;
            }
            if (iVar1 == 4) {
              iVar1 = -0x270c;
            }
            else if (iVar1 == 6) {
              iVar1 = -0x1382;
            }
            iVar3 = iVar2 + 1000;
            if (-1 < *(int *)(a + 24)) {
              iVar3 = iVar2;
            }
            iVar2 = iVar1 + 1000;
            if (-1 < *(int *)(b + 24)) {
              iVar2 = iVar1;
            }
            iVar1 = iVar3 + 100;
            if (*(int *)(a + 20) != 1) {
              iVar1 = iVar3;
            }
            iVar3 = iVar2 + 100;
            if (*(int *)(b + 20) != 1) {
              iVar3 = iVar2;
            }
            if (iVar3 <= iVar1) {
              return (uint64)(iVar3 < iVar1);
            }
            return 0xffffffff;
          }
        }
    }

    // Token : 0x600005E
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
