// ============================================================
// Type  : ToggleColor
// Token : 0x200039A
// ============================================================

public class ToggleColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C80
    public List<ToggleTargetColor> toggleTargetColors;

    // Token: 0x4001C81
    public List<ToggleTargetScale> toggleTargetScales;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600227B
    // RVA   : 0xAC5EE0   Offset: 0xAC46E0   Length: 0x4BB
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
                  (lVar2 = FUN_180002f80(this.toggleTargetColors,uVar5,DAT_181d7fff8)) == null)
                 || (lVar2._items == null)) throw; // [null/range check failed]
              uVar3 = GameObject.GetComponent(lVar2._items,DAT_181d9fe50);
              cVar1 = Object.op_Inequality(uVar3,0,0);
              if (cVar1) {
                if (((this.toggleTargetColors == null) ||
                    (lVar2 = FUN_180002f80(this.toggleTargetColors,uVar5,DAT_181d7fff8)) == null
                    ) || (lVar2._items == null)) throw; // [null/range check failed]
                uVar3 = GameObject.GetComponent(lVar2._items,DAT_181d9fe50);
                lVar2 = this.toggleTargetColors;
                if (!isOn) {
                  if ((lVar2 == null) || (lVar2 = FUN_180002f80(lVar2,uVar5,DAT_181d7fff8)) == null)
                  throw; // [null/range check failed]
                  local_38 = *(uint32 *)(lVar2 + 40);
                  uStack_34 = *(uint32 *)(lVar2 + 44);
                  uStack_30 = *(uint32 *)(lVar2 + 48);
                  uStack_2c = *(uint32 *)(lVar2 + 52);
                }
                else {
                  if ((lVar2 == null) || (lVar2 = FUN_180002f80(lVar2,uVar5,DAT_181d7fff8)) == null)
                  throw; // [null/range check failed]
                  local_38 = lVar2.Count;
                  uStack_34 = lVar2._version;
                  uStack_30 = *(uint32 *)(lVar2 + 32);
                  uStack_2c = *(uint32 *)(lVar2 + 36);
                }
                DOTweenModuleUI.DOColor(uVar3,&local_38,0x3e4ccccd);
              }
              if (((this.toggleTargetColors == null) ||
                  (lVar2 = FUN_180002f80(this.toggleTargetColors,uVar5)) == null) ||
                 (lVar2._items == null)) throw; // [null/range check failed]
              uVar3 = GameObject.GetComponent();
              cVar1 = Object.op_Inequality(uVar3,0,0);
              if (cVar1) {
                if (((this.toggleTargetColors == null) ||
                    (lVar2 = FUN_180002f80(this.toggleTargetColors,uVar5,DAT_181d7fff8)) == null
                    ) || (lVar2._items == null)) throw; // [null/range check failed]
                uVar3 = GameObject.GetComponent(lVar2._items,DAT_181da1eb0);
                lVar2 = this.toggleTargetColors;
                if (!isOn) {
                  if ((lVar2 == null) || (lVar2 = FUN_180002f80(lVar2,uVar5)) == null)
                  throw; // [null/range check failed]
                  local_38 = *(uint32 *)(lVar2 + 40);
                  uStack_34 = *(uint32 *)(lVar2 + 44);
                  uStack_30 = *(uint32 *)(lVar2 + 48);
                  uStack_2c = *(uint32 *)(lVar2 + 52);
                }
                else {
                  if ((lVar2 == null) || (lVar2 = FUN_180002f80(lVar2,uVar5)) == null)
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
                (lVar2 = FUN_180002f80(this.toggleTargetScales,uVar4,DAT_181d800f8)) == null) ||
               (lVar2._items == null)) break;
            uVar3 = GameObject.get_transform(lVar2._items,0);
            if (!isOn) {
              if ((this.toggleTargetScales == null) || (lVar2 = FUN_180002f80()) == null) break;
              uVar8 = lVar2._version;
            }
            else {
              if ((this.toggleTargetScales == null) || (lVar2 = FUN_180002f80()) == null) break;
              uVar8 = lVar2.Count;
            }
            ShortcutExtensions.DOScale(uVar3,uVar8,0x3e4ccccd,0);
          }
        }
    }

    // Token : 0x600227C
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
