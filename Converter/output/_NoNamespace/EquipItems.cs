// ============================================================
// Type  : EquipItems
// Token : 0x2000003
// ============================================================

public class EquipItems
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000006
    public int[] itemIDs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000005
    // RVA   : 0x934DB0   Offset: 0x9335B0   Length: 0x2B9
    private void Start()
    {
        int iVar1;
        uint uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        uint[] local_res8 = new uint[2];
        uVar9 = 0;
        local_res8[0] = 0;
        if ((this.itemIDs != null) &&
           (*(int64 *)(this.itemIDs + 24) != 0)) {
          lVar5 = Component.GetComponent(this,DAT_181d6bd40);
          cVar3 = Object.op_Equality(lVar5,0,0);
          if (cVar3) {
            lVar5 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_180935054;
            lVar5 = GameObject.AddComponent(lVar5,DAT_181d9c710);
          }
          if (this.itemIDs == null) {
        LAB_180935054:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar1 = *(int *)(this.itemIDs + 24);
          if (0 < iVar1) {
            do {
              lVar6 = this.itemIDs;
              if (lVar6 == null) goto LAB_180935054;
              if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              uVar4 = lVar6[uVar9];
              local_res8[0] = uVar4;
              lVar6 = InvDatabase.FindByID(uVar4,0);
              uVar4 = local_res8[0];
              if (lVar6 == null) {
                uVar7 = Int32.ToString(local_res8,0);
                uVar7 = String.Concat("Can't resolve the item ID of ",uVar7,0);
                Debug.LogWarning(uVar7);
              }
              else {
                lVar8 = new InvGameItem(uVar4,lVar6,0);
                uVar4 = FUN_180d8cf10(0,12);
                if (lVar8 == null) goto LAB_180935054;
                *(uint32 *)(lVar8 + 20) = uVar4;
                uVar4 = *(uint32 *)(lVar6 + 44);
                uVar2 = *(uint32 *)(lVar6 + 48);
                uVar4 = NGUITools.RandomRange(uVar4,uVar2,0);
                *(uint32 *)(lVar8 + 24) = uVar4;
                if (lVar5 == null) goto LAB_180935054;
                InvEquipment.Equip(lVar5,lVar8,0);
              }
              uVar9 = uVar9 + 1;
            } while ((int)uVar9 < iVar1);
          }
        }
        Object.Destroy(this,0);
    }

    // Token : 0x6000006
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
