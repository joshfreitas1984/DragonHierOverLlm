// ============================================================
// Type  : ToggleColor
// Token : 0x20003AE
// ============================================================

public class ToggleColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E18
    public List<ToggleTargetColor> toggleTargetColors;

    // Token: 0x4001E19
    public List<ToggleTargetScale> toggleTargetScales;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023A7
    // RVA   : 0x814E60   Offset: 0x813C60   Length: 0x4BB
    public void OnToggle(bool isOn)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        uint uVar8;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        lVar2 = this.toggleTargetColors;
        uVar4 = 0;
        uVar5 = 0;
        if (lVar2 != null) {
          lVar7 = 32;
          lVar6 = 32;
          while ((int)uVar5 < lVar2.Count) {
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar2.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar6 + lVar2._items);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = lVar2._items;
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (cVar1) {
              if (((this.toggleTargetColors == null) ||
                  (lVar2 = FUN_1800024b0(this.toggleTargetColors,uVar5,DAT_181e89ff0)) == null)
                 || (lVar2._items == null)) throw; // [null/range check failed]
              uVar3 = GameObject.GetComponent(lVar2._items,DAT_181e54f48);
              cVar1 = Object.op_Inequality(uVar3,0,0);
              if (cVar1) {
                if (((this.toggleTargetColors == null) ||
                    (lVar2 = FUN_1800024b0(this.toggleTargetColors,uVar5,DAT_181e89ff0)) == null
                    ) || (lVar2._items == null)) throw; // [null/range check failed]
                uVar3 = GameObject.GetComponent(lVar2._items,DAT_181e54f48);
                lVar2 = this.toggleTargetColors;
                if (!isOn) {
                  if ((lVar2 == null) || (lVar2 = FUN_1800024b0(lVar2,uVar5,DAT_181e89ff0)) == null)
                  throw; // [null/range check failed]
                  local_38 = *(uint32 *)(lVar2 + 40);
                  uStack_34 = *(uint32 *)(lVar2 + 44);
                  uStack_30 = *(uint32 *)(lVar2 + 48);
                  uStack_2c = *(uint32 *)(lVar2 + 52);
                }
                else {
                  if ((lVar2 == null) || (lVar2 = FUN_1800024b0(lVar2,uVar5,DAT_181e89ff0)) == null)
                  throw; // [null/range check failed]
                  local_38 = lVar2.Count;
                  uStack_34 = lVar2._version;
                  uStack_30 = *(uint32 *)(lVar2 + 32);
                  uStack_2c = *(uint32 *)(lVar2 + 36);
                }
                DOTweenModuleUI.DOColor(uVar3,&local_38,0x3e4ccccd);
              }
              if (((this.toggleTargetColors == null) ||
                  (lVar2 = FUN_1800024b0(this.toggleTargetColors,uVar5)) == null) ||
                 (lVar2._items == null)) throw; // [null/range check failed]
              uVar3 = GameObject.GetComponent();
              cVar1 = Object.op_Inequality(uVar3,0,0);
              if (cVar1) {
                if (((this.toggleTargetColors == null) ||
                    (lVar2 = FUN_1800024b0(this.toggleTargetColors,uVar5,DAT_181e89ff0)) == null
                    ) || (lVar2._items == null)) throw; // [null/range check failed]
                uVar3 = GameObject.GetComponent(lVar2._items,DAT_181e571d0);
                lVar2 = this.toggleTargetColors;
                if (!isOn) {
                  if ((lVar2 == null) || (lVar2 = FUN_1800024b0(lVar2,uVar5)) == null)
                  throw; // [null/range check failed]
                  local_38 = *(uint32 *)(lVar2 + 40);
                  uStack_34 = *(uint32 *)(lVar2 + 44);
                  uStack_30 = *(uint32 *)(lVar2 + 48);
                  uStack_2c = *(uint32 *)(lVar2 + 52);
                }
                else {
                  if ((lVar2 == null) || (lVar2 = FUN_1800024b0(lVar2,uVar5)) == null)
                  throw; // [null/range check failed]
                  local_38 = lVar2.Count;
                  uStack_34 = lVar2._version;
                  uStack_30 = *(uint32 *)(lVar2 + 32);
                  uStack_2c = *(uint32 *)(lVar2 + 36);
                }
                DOTweenModuleUI.DOColor(uVar3,&local_38,0x3e4ccccd);
              }
            }
            lVar2 = this.toggleTargetColors;
            uVar5 = uVar5 + 1;
            lVar6 = lVar6 + 8;
            if (lVar2 == null) throw; // [null/range check failed]
          }
          lVar2 = this.toggleTargetScales;
          if (lVar2 == null)
          {
            }
            throw; // [null/range check failed]
            while( true ) {
            lVar2 = this.toggleTargetScales;
            uVar4 = uVar4 + 1;
            lVar7 = lVar7 + 8;
            if (lVar2 == null) break;
          }
          if (lVar2.Count <= (int)uVar4) {
            return;
          }
          if (lVar2 == null) break;
          if (lVar2.Count <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar7 + lVar2._items);
          if (lVar2 == null) break;
          uVar3 = lVar2._items;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (((this.toggleTargetScales == null) ||
                (lVar2 = FUN_1800024b0(this.toggleTargetScales,uVar4,DAT_181e8a0f0)) == null) ||
               (lVar2._items == null)) break;
            uVar3 = GameObject.get_transform(lVar2._items,0);
            if (!isOn) {
              if ((this.toggleTargetScales == null) || (lVar2 = FUN_1800024b0()) == null) break;
              uVar8 = lVar2._version;
            }
            else {
              if ((this.toggleTargetScales == null) || (lVar2 = FUN_1800024b0()) == null) break;
              uVar8 = lVar2.Count;
            }
            ShortcutExtensions.DOScale(uVar3,uVar8,0x3e4ccccd,0);
          }
        }
    }

    // Token : 0x60023A8
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
