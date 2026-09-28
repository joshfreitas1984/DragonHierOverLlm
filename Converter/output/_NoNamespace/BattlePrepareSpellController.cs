// ============================================================
// Type  : BattlePrepareSpellController
// Token : 0x2000193
// ============================================================

public class BattlePrepareSpellController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AEC
    public List<BattlePrepareSpellData> BattlePrepareSpellDataBase;

    // Token: 0x4000AED
    public GameObject battlePrepareSpellUI;

    // Token: 0x4000AEE
    public GameObject battlePrepareSpellButtonPrefab;

    // Token: 0x4000AEF
    public int spellNum;

    // Token: 0x4000AF0
    public List<int> spellUsedID;

    // Token: 0x4000AF1
    private bool inited;

    // Token: 0x4000AF2
    private static BattlePrepareSpellController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CD8
    // RVA   : 0x8CC780   Offset: 0x8CBB80   Length: 0x36
    public static BattlePrepareSpellController get_Instance()
    {
        return **(uint64 **)(DAT_181db05c8 + 184);
    }

    // Token : 0x6000CD9
    // RVA   : 0x8CBC00   Offset: 0x8CB000   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181db05c8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000CDA
    // RVA   : 0x8CC510   Offset: 0x8CB910   Length: 0x26E
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
            FUN_1812f9a10(this.spellUsedID,DAT_181d8f318);
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

    // Token : 0x6000CDB
    // RVA   : 0x8CBD70   Offset: 0x8CB170   Length: 0x20
    public void HideBattlePrepareSpellUI()
    {
        if (this.battlePrepareSpellUI != null) {
          GameObject.SetActive(this.battlePrepareSpellUI,0,0);
          return;
        }
    }

    // Token : 0x6000CDC
    // RVA   : 0x8CBDA0   Offset: 0x8CB1A0   Length: 0x215
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
            lVar2 = GameObject.GetComponent(lVar2,DAT_181dc7408);
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
             (lVar2 = Component.GetComponent(lVar2,DAT_181d96960)) != null) {
            UIGrid.set_repositionNow(lVar2,1,0);
            uVar4 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(uVar4,DAT_181d8f098);
            this.spellUsedID = uVar4;
            return;
          }
        }
    }

    // Token : 0x6000CDD
    // RVA   : 0x8CBC60   Offset: 0x8CB060   Length: 0x10C
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
               ((lVar2 = FUN_180002f80(this.BattlePrepareSpellDataBase,iVar3,DAT_181d7f5b0), lVar2 == null ||
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

    // Token : 0x6000CDE
    // RVA   : 0x8CC210   Offset: 0x8CB610   Length: 0x2FD
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
          uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
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
                  (lVar6 = FUN_180002f80(this.BattlePrepareSpellDataBase,uVar7,DAT_181d7f5b0)) == null)
                 || (lVar5 == null)) break;
              uVar3 = GameDataController.StringToSpeAddData(lVar5,*(uint64 *)(lVar6 + 48),0);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x238)) == null) break;
              fVar9 = (float)FUN_1800d6790(lVar5,uVar7,DAT_181da1078);
              uVar3 = HeroSpeAddData.op_Multiply(uVar3,fVar9 + 1.0,0);
              if (lVar2 == null) break;
              puVar1 = (uint64 *)(lVar2 + 56);
              *puVar1 = uVar3;
              il2cpp_internal(puVar1,uVar3);
              if ((((this.battlePrepareSpellUI == null) ||
                   (lVar2 = GameObject.get_transform(this.battlePrepareSpellUI,0)) == null) ||
                  (lVar2 = Transform.Find(lVar2,"SpellGrid",0)) == null) ||
                 ((lVar2 = Transform.GetChild(lVar2,uVar7,0), lVar2 == null ||
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d93460)) == null))) break;
              BattlePrepareSpellButtonController.Init(lVar2,0);
              lVar2 = this.BattlePrepareSpellDataBase;
              uVar7 = uVar7 + 1;
              lVar8 = lVar8 + 8;
              if (lVar2 == null) break;
            }
          }
        }
    }

    // Token : 0x6000CDF
    // RVA   : 0x8CBC50   Offset: 0x8CB050   Length: 0xA
    public void ChangeSpellNum(int num)
    {
        void FUN_1808cbc50(int64 this,int num)
        {
        this.spellNum = this.spellNum + num;
        BattlePrepareSpellController.RefreshUI(this,0);
    }

    // Token : 0x6000CE0
    // RVA   : 0x8CBFC0   Offset: 0x8CB3C0   Length: 0x24D
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
            uVar1 = FUN_1800d6760(this.spellUsedID,iVar6,DAT_181d8fa18);
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) break;
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 0x238);
            if ((this.spellUsedID == null) ||
               (uVar2 = FUN_1800d6760(this.spellUsedID,iVar6,DAT_181d8fa18), lVar5 == null))
            break;
            FUN_1800d6790(lVar5,uVar2,DAT_181da1078);
            if (this.spellUsedID == null) break;
            iVar3 = FUN_1800d6760(this.spellUsedID,iVar6,DAT_181d8fa18);
            Mathf.FloorToInt((float)iVar3 * 0.5,0);
            uVar2 = FUN_1810e36c0();
            if (lVar4 == null) break;
            FUN_181829d40(lVar4,uVar1,uVar2);
            lVar4 = this.spellUsedID;
            iVar6 = iVar6 + 1;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000CE1
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
