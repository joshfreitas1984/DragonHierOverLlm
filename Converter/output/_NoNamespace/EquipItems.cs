// ============================================================
// Type  : EquipItems
// Token : 0x2000003
// ============================================================

public class EquipItems
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000002
    public int[] itemIDs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000004
    // RVA   : 0x68A5C0   Offset: 0x6893C0   Length: 0x2B9
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
          lVar5 = Component.GetComponent(this,DAT_181e778b8);
          cVar3 = Object.op_Equality(lVar5,0,0);
          if (cVar3) {
            lVar5 = Component.get_gameObject(this,0);
            if (lVar5 == null) goto LAB_18068a864;
            lVar5 = GameObject.AddComponent(lVar5,DAT_181e51560);
          }
          if (this.itemIDs == null) {
        LAB_18068a864:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          iVar1 = *(int *)(this.itemIDs + 24);
          if (0 < iVar1) {
            do {
              lVar6 = this.itemIDs;
              if (lVar6 == null) goto LAB_18068a864;
              if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar7,0);
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
                uVar4 = FUN_180af1860(0,12);
                if (lVar8 == null) goto LAB_18068a864;
                *(uint32 *)(lVar8 + 20) = uVar4;
                uVar4 = *(uint32 *)(lVar6 + 44);
                uVar2 = *(uint32 *)(lVar6 + 48);
                uVar4 = NGUITools.RandomRange(uVar4,uVar2,0);
                *(uint32 *)(lVar8 + 24) = uVar4;
                if (lVar5 == null) goto LAB_18068a864;
                InvEquipment.Equip(lVar5,lVar8,0);
              }
              uVar9 = uVar9 + 1;
            } while ((int)uVar9 < iVar1);
          }
        }
        Object.Destroy(this,0);
    }

    // Token : 0x6000005
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
