// ============================================================
// Type  : BattlePrepareSpellController
// Token : 0x200018D
// ============================================================

public class BattlePrepareSpellController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A66
    public List<BattlePrepareSpellData> BattlePrepareSpellDataBase;

    // Token: 0x4000A67
    public GameObject battlePrepareSpellUI;

    // Token: 0x4000A68
    public GameObject battlePrepareSpellButtonPrefab;

    // Token: 0x4000A69
    public int spellNum;

    // Token: 0x4000A6A
    public List<int> spellUsedID;

    // Token: 0x4000A6B
    private bool inited;

    // Token: 0x4000A6C
    private static BattlePrepareSpellController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA9
    // RVA   : 0x8E1510   Offset: 0x8DFD10   Length: 0x36
    public static BattlePrepareSpellController get_Instance()
    {
        return **(uint64 **)(DAT_181d8b4a8 + 184);
    }

    // Token : 0x6000CAA
    // RVA   : 0x8E09F0   Offset: 0x8DF1F0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8b4a8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000CAB
    // RVA   : 0x8E12A0   Offset: 0x8DFAA0   Length: 0x26E
    public void ShowBattlePrepareSpellUI(int playerTeamID)
    {
        long lVar1;
        long lVar2;
        ulong uVar4;
        int iVar5;
        int iVar6;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (!this.inited) {
          BattlePrepareSpellController.Init(this,0);
        }
        lVar1 = this.BattlePrepareSpellDataBase;
        iVar6 = 0;
        iVar5 = 20;
        if (lVar1 != null) {
          while (iVar6 < lVar1.Count) {
            lVar1 = FUN_18046c0a0(0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) throw; // [null/range check failed]
            lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0);
            if ((this.BattlePrepareSpellDataBase == null) ||
               ((lVar2 = FUN_180002f80(this.BattlePrepareSpellDataBase,iVar6), lVar2 == null || (lVar1 == null))))
            throw; // [null/range check failed]
            lVar1 = HeroData.FindSkill(lVar1);
            if (lVar1 != null) {
              iVar5 = iVar5 + 10;
            }
            lVar1 = this.BattlePrepareSpellDataBase;
            iVar6 = iVar6 + 1;
            if (lVar1 == null) throw; // [null/range check failed]
          }
          this.spellNum = iVar5;
          if (this.spellUsedID != null) {
            FUN_180f56130(this.spellUsedID,DAT_181d67b78);
            if (this.battlePrepareSpellUI != null) {
              GameObject.SetActive(this.battlePrepareSpellUI,1,0);
              if (this.battlePrepareSpellUI != null) {
                lVar1 = GameObject.get_transform(this.battlePrepareSpellUI,0);
                iVar5 = -0x23a;
                if (playerTeamID != null) {
                  iVar5 = 0x23a;
                }
                if (lVar1 != null) {
                  local_28 = CONCAT44(0x43c58000,(float)iVar5);
                  local_20 = 0;
                  Transform.set_localPosition(lVar1,&local_28,0);
                  if (this.battlePrepareSpellUI != null) {
                    lVar1 = GameObject.get_transform(this.battlePrepareSpellUI,0);
                    puVar3 = (uint64 *)Vector3.get_zero(local_18,0);
                    if (lVar1 != null) {
                      local_20 = *(uint32 *)(puVar3 + 1);
                      local_28 = *puVar3;
                      Transform.set_localScale(lVar1,&local_28,0);
                      if (this.battlePrepareSpellUI != null) {
                        uVar4 = GameObject.get_transform(this.battlePrepareSpellUI,0);
                        ShortcutExtensions.DOScale(uVar4,0x3f800000,0x3e800000,0);
                        BattlePrepareSpellController.RefreshUI(this,0);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000CAC
    // RVA   : 0x478350   Offset: 0x476B50   Length: 0x20
    public void HideBattlePrepareSpellUI()
    {
        if (this.battlePrepareSpellUI != null) {
          GameObject.SetActive(this.battlePrepareSpellUI,0,0);
          return;
        }
    }

    // Token : 0x6000CAD
    // RVA   : 0x8E0B60   Offset: 0x8DF360   Length: 0x215
    public void Init()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        lVar2 = this.BattlePrepareSpellDataBase;
        iVar5 = 0;
        this.inited = 1;
        if (lVar2 != null) {
          while (lVar1 = this.battlePrepareSpellUI, iVar5 < lVar2.Count) {
            if (((lVar1 == null) || (lVar2 = GameObject.get_transform(lVar1,0)) == null) ||
               (lVar2 = Transform.Find(lVar2,"SpellGrid",0)) == null) throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar2,0);
            uVar4 = this.battlePrepareSpellButtonPrefab;
            lVar2 = GlobalData.AddChild(uVar3,uVar4,0);
            if (lVar2 == null) throw; // [null/range check failed]
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d9e668);
            if ((this.BattlePrepareSpellDataBase == null) ||
               (uVar4 = FUN_180002f80(this.BattlePrepareSpellDataBase,iVar5), lVar2 == null))
            throw; // [null/range check failed]
            lVar2.Count = uVar4;
            lVar2 = this.BattlePrepareSpellDataBase;
            iVar5 = iVar5 + 1;
            if (lVar2 == null) throw; // [null/range check failed]
          }
          if ((((lVar1 != null) && (lVar2 = GameObject.get_transform(lVar1,0)) != null) &&
              (lVar2 = Transform.Find(lVar2,"SpellGrid",0)) != null) &&
             (lVar2 = Component.GetComponent(lVar2,DAT_181d6e0c0)) != null) {
            UIGrid.set_repositionNow(lVar2,1,0);
            uVar4 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(uVar4,DAT_181d678f8);
            this.spellUsedID = uVar4;
            return;
          }
        }
    }

    // Token : 0x6000CAE
    // RVA   : 0x8E0A50   Offset: 0x8DF250   Length: 0x10C
    public int GetTotalSpellNum()
    {
        long lVar1;
        long lVar2;
        int iVar3;
        int iVar4;
        lVar1 = this.BattlePrepareSpellDataBase;
        iVar3 = 0;
        iVar4 = 20;
        if (lVar1 != null) {
          while( true ) {
            if (lVar1.Count <= iVar3) {
              return iVar4;
            }
            lVar1 = FUN_18046c0a0(0);
            if ((lVar1 == null) || (*(int64 *)(lVar1 + 32) == 0)) break;
            lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0);
            if ((this.BattlePrepareSpellDataBase == null) ||
               ((lVar2 = FUN_180002f80(this.BattlePrepareSpellDataBase,iVar3,DAT_181d57e28), lVar2 == null ||
                (lVar1 == null)))) break;
            lVar1 = HeroData.FindSkill(lVar1,*(uint32 *)(lVar2 + 32),0);
            if (lVar1 != null) {
              iVar4 = iVar4 + 10;
            }
            lVar1 = this.BattlePrepareSpellDataBase;
            iVar3 = iVar3 + 1;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6000CAF
    // RVA   : 0x8E0FD0   Offset: 0x8DF7D0   Length: 0x2CE
    public void RefreshUI()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        float fVar9;
        if (((this.battlePrepareSpellUI != null) &&
            (lVar2 = GameObject.get_transform(this.battlePrepareSpellUI,0)) != null) &&
           (lVar2 = Transform.Find(lVar2,"SpellNum",0)) != null) {
          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
          uVar4 = Int32.ToString(this + 48,0);
          LTLocalization.SetText(uVar3,uVar4,0);
          lVar2 = this.BattlePrepareSpellDataBase;
          uVar7 = 0;
          if (lVar2 != null) {
            lVar8 = 32;
            while( true ) {
              if (lVar2.Count <= (int)uVar7) {
                return;
              }
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar8 + lVar2._items);
              lVar5 = FUN_18046c100(0);
              if (((this.BattlePrepareSpellDataBase == null) ||
                  (lVar6 = FUN_180002f80(this.BattlePrepareSpellDataBase,uVar7,DAT_181d57e28)) == null)
                 || (lVar5 == null)) break;
              uVar3 = GameDataController.StringToSpeAddData(lVar5,*(uint64 *)(lVar6 + 48),0);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x238)) == null) break;
              fVar9 = (float)FUN_1800d6780(lVar5,uVar7,DAT_181d796d8);
              uVar3 = HeroSpeAddData.op_Multiply(uVar3,fVar9 + 1.0,0);
              if (lVar2 == null) break;
              puVar1 = (uint64 *)(lVar2 + 56);
              *puVar1 = uVar3;
              il2cpp_internal(puVar1,uVar3);
              if (((this.battlePrepareSpellUI == null) ||
                  (lVar2 = GameObject.get_transform(this.battlePrepareSpellUI,0)) == null) ||
                 ((lVar2 = Transform.Find(lVar2,"SpellGrid",0), lVar2 == null ||
                  ((lVar2 = Transform.GetChild(lVar2,uVar7,0), lVar2 == null ||
                   (lVar2 = Component.GetComponent(lVar2,DAT_181d6ac40)) == null))))) break;
              BattlePrepareSpellButtonController.Init(lVar2,0);
              lVar2 = this.BattlePrepareSpellDataBase;
              uVar7 = uVar7 + 1;
              lVar8 = lVar8 + 8;
              if (lVar2 == null) break;
            }
          }
        }
    }

    // Token : 0x6000CB0
    // RVA   : 0x8E0A40   Offset: 0x8DF240   Length: 0xA
    public void ChangeSpellNum(int num)
    {
        void FUN_1808e0a40(int64 this,int num)
        {
        this.spellNum = this.spellNum + num;
        BattlePrepareSpellController.RefreshUI(this,0);
    }

    // Token : 0x6000CB1
    // RVA   : 0x8E0D80   Offset: 0x8DF580   Length: 0x24D
    public void ManageSpellRate()
    {
        uint uVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        lVar4 = this.spellUsedID;
        iVar6 = 0;
        if (lVar4 != null) {
          while( true ) {
            if (lVar4.Count <= iVar6) {
              return;
            }
            lVar4 = FUN_18046c0a0(0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) break;
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 0x238);
            if (this.spellUsedID == null) break;
            uVar1 = FUN_1800d6750(this.spellUsedID,iVar6,DAT_181d68270);
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x238);
            if ((this.spellUsedID == null) ||
               (uVar2 = FUN_1800d6750(this.spellUsedID,iVar6,DAT_181d68270), lVar5 == null))
            break;
            FUN_1800d6780(lVar5,uVar2,DAT_181d796d8);
            if (this.spellUsedID == null) break;
            iVar3 = FUN_1800d6750(this.spellUsedID,iVar6,DAT_181d68270);
            Mathf.FloorToInt((float)iVar3 * 0.5,0);
            uVar2 = FUN_1810a8ba0();
            if (lVar4 == null) break;
            FUN_181814d10(lVar4,uVar1,uVar2);
            lVar4 = this.spellUsedID;
            iVar6 = iVar6 + 1;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000CB2
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
