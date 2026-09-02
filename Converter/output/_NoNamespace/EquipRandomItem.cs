// ============================================================
// Type  : EquipRandomItem
// Token : 0x2000004
// ============================================================

public class EquipRandomItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000007
    public InvEquipment equipment;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000007
    // RVA   : 0x935280   Offset: 0x933A80   Length: 0x1D0
    private void OnClick()
    {
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        uVar2 = this.equipment;
        cVar3 = Object.op_Equality(uVar2,0,0);
        if (!cVar3) {
          lVar6 = InvDatabase.get_list(0);
          if (lVar6 != null) {
            if (*(int *)(lVar6 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            if ((*(int64 *)(lVar6 + 32) != 0) &&
               (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 32) + 32)) != null) {
              if (*(int *)(lVar6 + 24) == 0) {
                return;
              }
              uVar4 = FUN_180d8cf10(0,*(int *)(lVar6 + 24),0);
              if (*(uint32 *)(lVar6 + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = lVar6[uVar4];
              lVar7 = new InvGameItem(uVar4,lVar6,0);
              uVar5 = FUN_180d8cf10(0,12);
              if ((lVar7 != null) && (*(uint32 *)(lVar7 + 20) = uVar5, lVar6 != null)) {
                uVar5 = *(uint32 *)(lVar6 + 44);
                uVar1 = *(uint32 *)(lVar6 + 48);
                uVar5 = NGUITools.RandomRange(uVar5,uVar1,0);
                *(uint32 *)(lVar7 + 24) = uVar5;
                if (this.equipment != null) {
                  InvEquipment.Equip(this.equipment,lVar7,0);
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000008
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
